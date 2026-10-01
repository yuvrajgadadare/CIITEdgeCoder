using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.GitHub.Controllers
{
    [Area("GitHub")]

    public class GitHubEcosystemAndWorkflowController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MarkdownDocumentation()
        {
            return View();
        }
        public IActionResult GitHubIssues()
        {
            return View();
        }
        public IActionResult GitHubActions()
        {
            return View();
        }
        public IActionResult GitHubPages()
        {
            return View();
        }
    }
}
