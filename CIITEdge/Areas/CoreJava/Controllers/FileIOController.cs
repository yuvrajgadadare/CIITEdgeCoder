using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CoreJava.Controllers
{
    [Area("CoreJava")]
    public class FileIOController : Controller
    {
        public IActionResult FileSystem()
        {
            return View();
        }

        public IActionResult Serialization()
        {
            return View();
        }
    }
}