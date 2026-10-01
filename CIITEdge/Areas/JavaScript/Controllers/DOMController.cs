using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class DOMController : Controller
    {
        // 1. DOM Manipulation
        public IActionResult Index()
        {
            return View();
        }


        // 2. Selecting Elements
        public IActionResult SelectingElements()
        {
            return View();
        }


        // 3. Changing Content
        public IActionResult ChangingContent()
        {
            return View();
        }


        // 4. Changing Styles
        public IActionResult ChangingStyles()
        {
            return View();
        }


        // 5. Creating Elements
        public IActionResult CreatingElements()
        {
            return View();
        }
    }
}