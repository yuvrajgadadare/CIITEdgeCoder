using CIITEdge.Models;
using System.Diagnostics;

namespace CIITEdge.Services
{
   public class CodeRunnerService : ICodeRunnerService
    {
        public async Task<CodeExecutionResponse> ExecuteCodeAsync(CodeExecutionRequest request)
        {
            var stopwatch = Stopwatch.StartNew();
            string tempDir = Path.Combine(Path.GetTempPath(), "ciit_runner_" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(tempDir);

            try
            {
                var (command, args, fileName) = GetLanguageConfig(request.Language, tempDir);
                string filePath = Path.Combine(tempDir, fileName);

                // Write submitted code to temporary directory
                await File.WriteAllTextAsync(filePath, request.Code);

                var psi = new ProcessStartInfo
                {
                    FileName = command,
                    Arguments = args,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = tempDir
                };

                using var process = new Process { StartInfo = psi };
                process.Start();

                var outputTask = process.StandardOutput.ReadToEndAsync();
                var errorTask = process.StandardError.ReadToEndAsync();

                // Enforce execution timeout
                var completedTask = await Task.WhenAny(process.WaitForExitAsync(), Task.Delay(request.TimeoutMilliseconds));

                stopwatch.Stop();

                if (completedTask != process.WaitForExitAsync())
                {
                    process.Kill(true);
                    return new CodeExecutionResponse
                    {
                        Error = "Execution Timed Out: Program exceeded max allowed runtime limit.",
                        IsTimedOut = true,
                        ExitCode = -1,
                        ExecutionTimeMs = stopwatch.ElapsedMilliseconds
                    };
                }

                return new CodeExecutionResponse
                {
                    Output = await outputTask,
                    Error = await errorTask,
                    ExitCode = process.ExitCode,
                    IsTimedOut = false,
                    ExecutionTimeMs = stopwatch.ElapsedMilliseconds
                };
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                return new CodeExecutionResponse
                {
                    Error = $"Server Execution Error: {ex.Message}",
                    ExitCode = 500,
                    ExecutionTimeMs = stopwatch.ElapsedMilliseconds
                };
            }
            finally
            {
                // Cleanup temp workspace
                if (Directory.Exists(tempDir))
                {
                    try { Directory.Delete(tempDir, recursive: true); } catch { }
                }
            }
        }

        private static (string Command, string Args, string FileName) GetLanguageConfig(string language, string workDir)
        {
            return language.ToLower() switch
            {
                "java" => ("java", "Main.java", "Main.java"), // Requires Java 11+ single-file execution
                "python" => ("python", "script.py", "script.py"),
                "javascript" => ("node", "script.js", "script.js"),
                "csharp" => ("dotnet", "script.csx", "script.csx"), // Requires dotnet-script installed
                "typescript" => ("npx", "ts-node script.ts", "script.ts"),
                _ => throw new ArgumentException($"Language '{language}' is not supported.")
            };
        }
    }
}
