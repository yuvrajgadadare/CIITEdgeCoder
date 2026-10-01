using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class WebAPIBrowserStorageController : Controller
    {
        // 1. Web APIs & Browser Storage
        public IActionResult Index()
        {
            return View();
        }


        // 2. Local Storage
        public IActionResult LocalStorage()
        {
            return View();
        }


        // 3. Session Storage
        public IActionResult SessionStorage()
        {
            return View();
        }


        // 4. JSON
        public IActionResult JSON()
        {
            return View();
        }


        // 5. Date and Time
        public IActionResult DateAndTime()
        {
            return View();
        }
    }
}