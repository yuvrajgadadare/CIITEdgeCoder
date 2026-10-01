using CIITEdge.Models;
using CIITEdge.Services;
using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Controllers
{
    public class CodeRunnerController : Controller
    {

        private readonly ICodeRunnerService _codeRunnerService;

        public CodeRunnerController(ICodeRunnerService codeRunnerService)
        {
            _codeRunnerService = codeRunnerService;
        }

        // GET: /CodeRunner
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Returns the compiler page UI
        }

        // POST: /CodeRunner/Execute
        [HttpPost]
        public async Task<IActionResult> Execute([FromBody] CodeExecutionRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Code))
            {
                return BadRequest(new CodeExecutionResponse { Error = "Source code cannot be empty." });
            }

            var result = await _codeRunnerService.ExecuteCodeAsync(request);
            return Ok(result);
        }



        public IActionResult HtmlRunner()
        {
            return View();
        }
    }
}
