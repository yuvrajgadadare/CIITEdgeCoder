using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class ModernJavaScriptController : Controller
    {
        // 1. Modern JavaScript
        public IActionResult Index()
        {
            return View();
        }


        // 2. Let & Const
        public IActionResult LetConst()
        {
            return View();
        }


        // 3. Template Literals
        public IActionResult TemplateLiterals()
        {
            return View();
        }


        // 4. Spread & Rest
        public IActionResult SpreadRest()
        {
            return View();
        }


        // 5. Modules
        public IActionResult Modules()
        {
            return View();
        }
    }
}