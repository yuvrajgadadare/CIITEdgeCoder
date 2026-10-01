using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.GitHub.Controllers
{
    [Area("GitHub")]

    public class LocalGitWorkflowController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InitializingRepositories()
        {
            return View();
        }
        public IActionResult ThreeStates()
        {
            return View();
        }
        public IActionResult TrackingChanges()
        {
            return View();
        }
        public IActionResult CheckingStatus()
        {
            return View();
        }
        public IActionResult InspectingHistory()
        {
            return View();
        }
        public IActionResult IgnoringFiles()
        {
            return View();
        }
    }
}
