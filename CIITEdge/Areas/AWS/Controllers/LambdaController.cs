using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.AWS.Controllers
{
    [Area("AWS")]
    public class LambdaController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult IntroductionToLambda() => View();
        public IActionResult LambdaFunctions() => View();
        public IActionResult Triggers() => View();
        public IActionResult EnvironmentVariables() => View();
    }
}
