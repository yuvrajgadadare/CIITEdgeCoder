using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSS.Controllers
{
    [Area("CSS")]
    public class ResponsiveDesignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ResponsiveWebDesign()
        {
            return View();
        }

        public IActionResult Viewport()
        {
            return View();
        }

        public IActionResult MediaQueries()
        {
            return View();
        }

        public IActionResult Breakpoints()
        {
            return View();
        }

        public IActionResult MobileFirst()
        {
            return View();
        }

        public IActionResult ResponsiveImages()
        {
            return View();
        }

        public IActionResult ResponsiveTypography()
        {
            return View();
        }
    }
}