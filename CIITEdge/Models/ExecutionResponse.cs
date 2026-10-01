namespace CIITEdge.Models
{
    public class ExecutionResponse
    {
        public string Output { get; set; } = string.Empty;
        public string Error { get; set; } = string.Empty;
        public bool IsTimedOut { get; set; }
        public long ExecutionTimeMs { get; set; }
    }
}
