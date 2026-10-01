using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class AdvancedJavaScriptController : Controller
    {
        // 1. Advanced JavaScript
        public IActionResult Index()
        {
            return View();
        }


        // 2. Scope
        public IActionResult Scope()
        {
            return View();
        }


        // 3. Closures
        public IActionResult Closures()
        {
            return View();
        }


        // 4. Error Handling
        public IActionResult ErrorHandling()
        {
            return View();
        }


        // 5. Best Practices
        public IActionResult BestPractices()
        {
            return View();
        }
    }
}