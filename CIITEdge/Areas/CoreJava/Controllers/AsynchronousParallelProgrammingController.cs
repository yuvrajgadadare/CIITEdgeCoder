using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CoreJava.Controllers
{
    [Area("CoreJava")]
    public class AsynchronousParallelProgrammingController : Controller
    {
        public IActionResult AsynchronousProgramming() => View();

        public IActionResult Multithreading() => View();

        public IActionResult ParallelProcessing() => View();
    }
}