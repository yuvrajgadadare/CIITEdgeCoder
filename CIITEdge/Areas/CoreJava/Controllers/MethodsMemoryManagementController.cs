using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CoreJava.Controllers
{
    [Area("CoreJava")]
    public class MethodsMemoryManagementController : Controller
    {
        public IActionResult Methods()
        {
            return View();
        }

        public IActionResult MethodOverloading()
        {
            return View();
        }

        public IActionResult MemoryBasics()
        {
            return View();
        }

        public IActionResult GarbageCollection()
        {
            return View();
        }
    }
}