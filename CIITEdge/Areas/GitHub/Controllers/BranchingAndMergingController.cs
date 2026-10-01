using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.GitHub.Controllers
{
    [Area("GitHub")]

    public class BranchingAndMergingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GitBranchingConcept()
        {
            return View();
        }
        public IActionResult ManagingBranches()
        {
            return View();
        }
        public IActionResult SwitchingContexts()
        {
            return View();
        }
        public IActionResult BasicMerging()
        {
            return View();
        }
        public IActionResult ResolvingMergeConflicts()
        {
            return View();
        }
    }
}
