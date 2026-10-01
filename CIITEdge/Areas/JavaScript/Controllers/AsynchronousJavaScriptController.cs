using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class AsynchronousJavaScriptController : Controller
    {
        // 1. Asynchronous JavaScript
        public IActionResult Index()
        {
            return View();
        }


        // 2. Callbacks
        public IActionResult Callbacks()
        {
            return View();
        }


        // 3. Promises
        public IActionResult Promises()
        {
            return View();
        }


        // 4. Async / Await
        public IActionResult AsyncAwait()
        {
            return View();
        }


        // 5. Fetch API
        public IActionResult FetchAPI()
        {
            return View();
        }
    }
}