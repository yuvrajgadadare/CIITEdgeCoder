using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSS.Controllers
{
    [Area("CSS")]
    public class SelectorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ElementSelector()
        {
            return View();
        }

        public IActionResult ClassSelector()
        {
            return View();
        }

        public IActionResult IdSelector()
        {
            return View();
        }

        public IActionResult UniversalSelector()
        {
            return View();
        }

        public IActionResult GroupingSelector()
        {
            return View();
        }

        public IActionResult AttributeSelector()
        {
            return View();
        }

        public IActionResult DescendantSelector()
        {
            return View();
        }

        public IActionResult ChildSelector()
        {
            return View();
        }

        public IActionResult PseudoClassSelector()
        {
            return View();
        }

        public IActionResult PseudoElementSelector()
        {
            return View();
        }
    }
}