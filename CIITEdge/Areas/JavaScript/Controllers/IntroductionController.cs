using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class IntroductionController : Controller
    {
        // 1. Introduction to JavaScript
        public IActionResult Index()
        {
            return View();
        }


        // 2. JavaScript History
        public IActionResult JavaScriptHistory()
        {
            return View();
        }


        // 3. How JavaScript Works
        public IActionResult HowJavaScriptWorks()
        {
            return View();
        }


        // 4. JavaScript in the Browser
        public IActionResult JavaScriptInBrowser()
        {
            return View();
        }


        // 5. Browser Developer Tools
        public IActionResult DeveloperTools()
        {
            return View();
        }
    }
}