using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSharp.Controllers
{
    [Area("CSharp")]

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
