namespace CIITEdge.Models
{
    public class CodeExecutionResponse
    {
        public string Output { get; set; } = string.Empty;
        public string Error { get; set; } = string.Empty;
        public int ExitCode { get; set; }
        public bool IsTimedOut { get; set; }
        public double ExecutionTimeMs { get; set; }
    }
}
