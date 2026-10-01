namespace CIITEdge.Models
{
    public class CodeExecutionRequest
    {
        public string Language { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public int TimeoutMilliseconds { get; set; } = 5000;
    }

   
}
