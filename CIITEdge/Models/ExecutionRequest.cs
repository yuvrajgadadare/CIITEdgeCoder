namespace CIITEdge.Models
{
    public class ExecutionRequest
    {
        public string Code { get; set; } = string.Empty;
        public int TimeoutMs { get; set; } = 3000; // Default 3 sec
    }
}
