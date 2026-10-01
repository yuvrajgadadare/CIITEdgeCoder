using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSharp.Controllers
{
    [Area("CSharp")]

    public class DataStructuresCollectionController : Controller
    {
        public IActionResult Arrays()
        {
            return View();
        }
        public IActionResult Strings()
        {
            return View();
        }
        public IActionResult Generics()
        {
            return View();
        }
        public IActionResult Collections()
        {
            return View();
        }
    }
}
