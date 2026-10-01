using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CoreJava.Controllers
{
    [Area("CoreJava")]
    public class AdvancedFeaturesController : Controller
    {
        public IActionResult ExceptionHandling()
        {
            return View();
        }

        public IActionResult LambdaExpressions()
        {
            return View();
        }

        public IActionResult FunctionalInterfaces()
        {
            return View();
        }

        public IActionResult StreamAPI()
        {
            return View();
        }

        public IActionResult Optional()
        {
            return View();
        }

        public IActionResult DateAndTimeAPI()
        {
            return View();
        }
    }
}