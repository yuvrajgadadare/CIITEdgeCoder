using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class FunctionsController : Controller
    {
        // 1. Functions
        public IActionResult Index()
        {
            return View();
        }


        // 2. Function Declaration
        public IActionResult FunctionDeclaration()
        {
            return View();
        }


        // 3. Parameters & Arguments
        public IActionResult ParametersArguments()
        {
            return View();
        }


        // 4. Return Values
        public IActionResult ReturnValues()
        {
            return View();
        }


        // 5. Arrow Functions
        public IActionResult ArrowFunctions()
        {
            return View();
        }


        // 6. Callback Functions
        public IActionResult CallbackFunctions()
        {
            return View();
        }
    }
}