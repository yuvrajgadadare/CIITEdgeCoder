using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.GitHub.Controllers
{
    [Area("GitHub")]

    public class RemoteCollaborationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ConnectingRemotes()
        {
            return View();
        }
        public IActionResult CloningProjects()
        {
            return View();
        }
        public IActionResult PushingCode()
        {
            return View();
        }
        public IActionResult PullingUpdates()
        {
            return View();
        }
        public IActionResult PullRequests()
        {
            return View();
        }
        public IActionResult ForksvsClones()
        {
            return View();
        }
    }
}
