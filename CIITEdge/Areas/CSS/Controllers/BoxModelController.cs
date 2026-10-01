using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSS.Controllers
{
    [Area("CSS")]
    public class BoxModelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WidthAndHeight()
        {
            return View();
        }

        public IActionResult Padding()
        {
            return View();
        }

        public IActionResult Margin()
        {
            return View();
        }

        public IActionResult Border()
        {
            return View();
        }

        public IActionResult BorderRadius()
        {
            return View();
        }

        public IActionResult BoxSizing()
        {
            return View();
        }

        public IActionResult BoxShadow()
        {
            return View();
        }

        public IActionResult Overflow()
        {
            return View();
        }
    }
}