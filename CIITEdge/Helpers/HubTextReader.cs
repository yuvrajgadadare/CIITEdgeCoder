namespace CIITEdge.Helpers
{
    public class HubTextReader : TextReader
    {
        private TaskCompletionSource<string>? _inputTcs;

        // Called by the SignalR hub when the user sends a new line of text
        public void SupplyInput(string input)
        {
            _inputTcs?.TrySetResult(input);
        }

        // Overriding ReadLine to block execution until SupplyInput is called
        public override string? ReadLine()
        {
            _inputTcs = new TaskCompletionSource<string>();

            // Block synchronous thread safely until the task completes
            return _inputTcs.Task.GetAwaiter().GetResult();
        }
    }
}
