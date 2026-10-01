using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.HTML.Controllers
{
    [Area("HTML")]
    public class BasicHTMLController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HTMLElements()
        {
            return View();
        }

        public IActionResult HTMLAttributes()
        {
            return View();
        }

        public IActionResult Headings()
        {
            return View();
        }

        public IActionResult Paragraphs()
        {
            return View();
        }

        public IActionResult Comments()
        {
            return View();
        }

        public IActionResult LineBreaks()
        {
            return View();
        }

        public IActionResult HorizontalRules()
        {
            return View();
        }
    }
}