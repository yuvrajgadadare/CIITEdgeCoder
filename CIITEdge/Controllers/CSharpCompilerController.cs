using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Controllers
{
    public class CSharpCompilerController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Index(string code)
        {
            ViewBag.TutorialCode = code;

            return View();
        }
        public IActionResult Sample()
        {
            return View();
        }
    }
}
