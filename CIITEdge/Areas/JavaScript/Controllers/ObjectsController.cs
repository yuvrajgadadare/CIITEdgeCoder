using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class ObjectsController : Controller
    {
        // 1. Objects
        public IActionResult Index()
        {
            return View();
        }


        // 2. Object Properties
        public IActionResult ObjectProperties()
        {
            return View();
        }


        // 3. Object Methods
        public IActionResult ObjectMethods()
        {
            return View();
        }


        // 4. This Keyword
        public IActionResult ThisKeyword()
        {
            return View();
        }


        // 5. Destructuring
        public IActionResult Destructuring()
        {
            return View();
        }
    }
}