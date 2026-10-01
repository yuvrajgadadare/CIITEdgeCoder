using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.HTML.Controllers
{
    [Area("HTML")]
    public class LinksAndMediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hyperlinks()
        {
            return View();
        }

        public IActionResult LinkAttributes()
        {
            return View();
        }

        public IActionResult Images()
        {
            return View();
        }

        public IActionResult ImageAttributes()
        {
            return View();
        }

        public IActionResult Audio()
        {
            return View();
        }

        public IActionResult Video()
        {
            return View();
        }

        public IActionResult Iframes()
        {
            return View();
        }
    }
}