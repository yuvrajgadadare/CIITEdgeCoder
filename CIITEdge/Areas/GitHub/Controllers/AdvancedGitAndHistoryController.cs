using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.GitHub.Controllers
{
    [Area("GitHub")]
    public class AdvancedGitAndHistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Stashing()
        {
            return View();
        }
        public IActionResult UndoingMistakes()
        {
            return View();
        }
        public IActionResult Rebasing()
        {
            return View();
        }
        public IActionResult Tagging()
        {
            return View();
        }
        public IActionResult BlamingAuditing()
        {
            return View();
        }
    }
}
