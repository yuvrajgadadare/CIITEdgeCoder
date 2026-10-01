using CIITEdge.Helpers;
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Concurrent;
using System.Reflection;

namespace CIITEdge.Hubs
{
    public class CompilerHub : Hub
    {
        // Keeps track of the active readers for each connected terminal session
        private static readonly ConcurrentDictionary<string, HubTextReader> ActiveSessions = new();

        public async Task CompileAndRun(string sourceCode)
        {
            var connectionId = Context.ConnectionId;
            var customReader = new HubTextReader();
            ActiveSessions[connectionId] = customReader;

            await Clients.Caller.SendAsync("ReceiveOutput", "⚙️ Compiling code...\n");

            // 1. Setup Roslyn parser
            var syntaxTree = CSharpSyntaxTree.ParseText(sourceCode);
            string assemblyName = Path.GetRandomFileName();
            var references = new List<MetadataReference>
    {
        MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
        MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
        MetadataReference.CreateFromFile(Path.Combine(Path.GetDirectoryName(typeof(object).Assembly.Location)!, "System.Runtime.dll"))
    };

            var compilation = CSharpCompilation.Create(
                assemblyName,
                new[] { syntaxTree },
                references,
                new CSharpCompilationOptions(OutputKind.ConsoleApplication));

            using var ms = new MemoryStream();
            var result = compilation.Emit(ms);

            if (!result.Success)
            {
                var failures = result.Diagnostics.Where(d => d.IsWarningAsError || d.Severity == DiagnosticSeverity.Error);
                await Clients.Caller.SendAsync("ReceiveOutput", "❌ Compilation Failed:\n" + string.Join("\n", failures.Select(f => f.GetMessage())) + "\n");
                ActiveSessions.TryRemove(connectionId, out _);
                return;
            }

            ms.Seek(0, SeekOrigin.Begin);
            var assembly = Assembly.Load(ms.ToArray());
            var entryPoint = assembly.EntryPoint;

            if (entryPoint == null)
            {
                await Clients.Caller.SendAsync("ReceiveOutput", "❌ Error: Main method missing.\n");
                ActiveSessions.TryRemove(connectionId, out _);
                return;
            }

            // Capture the hub context so we can safely stream data back from the background thread
            var hubContext = Clients.Caller;

            await hubContext.SendAsync("ReceiveOutput", "🚀 Program started. Interactive mode active:\n\n");

            // 2. Spin execution off onto a background thread
            _ = Task.Run(async () =>
            {
                // Preserve original system terminal streams
                var originalOut = Console.Out;
                var originalIn = Console.In;

                // Move the using blocks INSIDE the background thread so they live as long as the execution loops
                using var customWriter = new ObservableStringWriter(async (text) =>
                {
                    await hubContext.SendAsync("ReceiveOutput", text);
                });

                try
                {
                    Console.SetOut(customWriter);
                    Console.SetIn(customReader);

                    var parameters = entryPoint.GetParameters().Length > 0 ? new object[] { Array.Empty<string>() } : null;
                    entryPoint.Invoke(null, parameters);

                    customWriter.Write("\n🏁 Program completed execution.");
                }
                catch (TargetInvocationException ex)
                {
                    customWriter.Write($"\n💥 Runtime Error: {ex.InnerException?.Message}");
                }
                finally
                {
                    // Clean up and restore system streams safely before disposing the writer
                    Console.SetOut(originalOut);
                    Console.SetIn(originalIn);
                    ActiveSessions.TryRemove(connectionId, out _);
                }
            });
        }

        // UI triggers this whenever the user types something in the terminal input and hits Enter
        public void SendInputToProgram(string inputData)
        {
            if (ActiveSessions.TryGetValue(Context.ConnectionId, out var reader))
            {
                // Unblocks Console.ReadLine() inside the background worker
                reader.SupplyInput(inputData);
            }
        }
    }

    // Helper writer that fires a callback function instantly whenever text is written to the stream
    public class ObservableStringWriter : StringWriter
    {
        private readonly Func<string, Task> _onWriteAsync;
        public ObservableStringWriter(Func<string, Task> onWriteAsync) => _onWriteAsync = onWriteAsync;

        public override void Write(string? value)
        {
            base.Write(value);
            if (value != null) _onWriteAsync(value).GetAwaiter().GetResult();
        }

        public override void Write(char[] buffer, int index, int count)
        {
            base.Write(buffer, index, count);
            _onWriteAsync(new string(buffer, index, count)).GetAwaiter().GetResult();
        }
    }
}
