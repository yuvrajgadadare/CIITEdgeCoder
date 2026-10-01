using CIITEdge.Models;

namespace CIITEdge.Services
{
    public interface ICodeRunnerService
    {
        Task<CodeExecutionResponse> ExecuteCodeAsync(CodeExecutionRequest request);
    }
}
