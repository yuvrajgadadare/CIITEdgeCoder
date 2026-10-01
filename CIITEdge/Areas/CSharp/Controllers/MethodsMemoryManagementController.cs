using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSharp.Controllers
{
    [Area("CSharp")]

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
