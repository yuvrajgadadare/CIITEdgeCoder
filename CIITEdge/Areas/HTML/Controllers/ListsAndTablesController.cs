using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.HTML.Controllers
{
    [Area("HTML")]
    public class ListsAndTablesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UnorderedLists()
        {
            return View();
        }

        public IActionResult OrderedLists()
        {
            return View();
        }

        public IActionResult DescriptionLists()
        {
            return View();
        }

        public IActionResult NestedLists()
        {
            return View();
        }

        public IActionResult Tables()
        {
            return View();
        }

        public IActionResult TableHeaders()
        {
            return View();
        }

        public IActionResult ColspanAndRowspan()
        {
            return View();
        }
    }
}