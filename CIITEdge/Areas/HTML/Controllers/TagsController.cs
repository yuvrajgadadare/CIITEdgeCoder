using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.HTML.Controllers
{
    [Area("HTML")]
    public class TagsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}