using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.AWS.Controllers
{
    [Area("AWS")]
    public class IAMController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult IAMUsers() => View();
        public IActionResult IAMGroups() => View();
        public IActionResult IAMPolicies() => View();
        public IActionResult IAMRoles() => View();
        public IActionResult MultiFactorAuthentication() => View();
    }
}
