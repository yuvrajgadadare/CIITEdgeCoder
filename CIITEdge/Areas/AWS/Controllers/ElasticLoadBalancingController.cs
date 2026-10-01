using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.AWS.Controllers
{
    [Area("AWS")]
    public class ElasticLoadBalancingController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Introduction() => View();
        public IActionResult ApplicationLoadBalancer() => View();
        public IActionResult NetworkLoadBalancer() => View();
        public IActionResult GatewayLoadBalancer() => View();
        public IActionResult TargetGroups() => View();
        public IActionResult HealthChecks() => View();
        public IActionResult ListenerAndRules() => View();
    }
}
