using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSharp.Controllers
{
    [Area("CSharp")]

    public class AdvanceFeatureController : Controller
    {
        
        public IActionResult ExceptionHandling()
        {
            return View();

        }
        public IActionResult DelegatesAndEvents()
        {
            return View();
        }
        public IActionResult LambdaExpressions()
        {
            return View();
        }
        public IActionResult ExtensionMethods()

        {
            return View();
        }
        public IActionResult LINQ()
        {
            return View();
        }
    }
}
