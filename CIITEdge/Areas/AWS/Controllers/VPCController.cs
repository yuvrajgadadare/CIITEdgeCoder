using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.AWS.Controllers
{
    [Area("AWS")]
    public class VPCController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult IntroductionToVPC() => View();
        public IActionResult Subnets() => View();
        public IActionResult RouteTables() => View();
        public IActionResult InternetGateway() => View();
        public IActionResult NATGateway() => View();
        public IActionResult VPCSecurityGroups() => View();
    }
}
