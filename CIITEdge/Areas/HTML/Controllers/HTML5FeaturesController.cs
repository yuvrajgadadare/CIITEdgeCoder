using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.HTML.Controllers
{
    [Area("HTML")]
    public class HTML5FeaturesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HTML5Introduction()
        {
            return View();
        }

        public IActionResult NewInputTypes()
        {
            return View();
        }

        public IActionResult AudioVideo()
        {
            return View();
        }

        public IActionResult Canvas()
        {
            return View();
        }

        public IActionResult SVG()
        {
            return View();
        }

        public IActionResult ProgressMeter()
        {
            return View();
        }

        public IActionResult DetailsSummary()
        {
            return View();
        }

        public IActionResult DataAttributes()
        {
            return View();
        }
    }
}