using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CoreJava.Controllers
{
    [Area("CoreJava")]
    public class IntroductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DevelopmentTools()
        {
            return View();
        }

        public IActionResult FirstProgram()
        {
            return View();
        }
    }
}