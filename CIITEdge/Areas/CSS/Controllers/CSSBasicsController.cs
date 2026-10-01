using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSS.Controllers
{
    [Area("CSS")]
    public class CSSBasicsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CSSSyntax()
        {
            return View();
        }

        public IActionResult InlineCSS()
        {
            return View();
        }

        public IActionResult InternalCSS()
        {
            return View();
        }

        public IActionResult ExternalCSS()
        {
            return View();
        }

        public IActionResult CSSComments()
        {
            return View();
        }
    }
}