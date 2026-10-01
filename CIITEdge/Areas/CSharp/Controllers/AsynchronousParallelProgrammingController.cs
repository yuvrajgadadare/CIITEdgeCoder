using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSharp.Controllers
{
    [Area("CSharp")]

    public class AsynchronousParallelProgrammingController : Controller
    {
        public IActionResult AsynchronousProgramming()
        {
            return View();
        }
        public IActionResult Multithreading()
        {
            return View();
        }
        public IActionResult ParallelProcessing()
        {
            return View();
        }
    }
}
