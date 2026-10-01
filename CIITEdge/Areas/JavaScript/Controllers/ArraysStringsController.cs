using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class ArraysStringsController : Controller
    {
        // 1. Arrays & Strings
        public IActionResult Index()
        {
            return View();
        }


        // 2. Arrays
        public IActionResult Arrays()
        {
            return View();
        }


        // 3. Array Methods
        public IActionResult ArrayMethods()
        {
            return View();
        }


        // 4. Strings
        public IActionResult Strings()
        {
            return View();
        }


        // 5. String Methods
        public IActionResult StringMethods()
        {
            return View();
        }
    }
}