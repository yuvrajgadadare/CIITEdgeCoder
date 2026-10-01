using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class EventsController : Controller
    {
        // 1. Events
        public IActionResult Index()
        {
            return View();
        }


        // 2. Click Events
        public IActionResult ClickEvents()
        {
            return View();
        }


        // 3. Keyboard Events
        public IActionResult KeyboardEvents()
        {
            return View();
        }


        // 4. Form Events
        public IActionResult FormEvents()
        {
            return View();
        }


        // 5. Event Listeners
        public IActionResult EventListeners()
        {
            return View();
        }
    }
}