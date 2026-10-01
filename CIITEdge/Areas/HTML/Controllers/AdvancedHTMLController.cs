using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.HTML.Controllers
{
    [Area("HTML")]
    public class AdvancedHTMLController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GlobalAttributes()
        {
            return View();
        }

        public IActionResult MetaTags()
        {
            return View();
        }

        public IActionResult Viewport()
        {
            return View();
        }

        public IActionResult HTMLAccessibility()
        {
            return View();
        }

        public IActionResult ARIABasics()
        {
            return View();
        }

        public IActionResult BestPractices()
        {
            return View();
        }

        public IActionResult SEOFriendlyHTML()
        {
            return View();
        }
    }
}