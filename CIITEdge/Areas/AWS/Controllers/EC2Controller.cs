using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.AWS.Controllers
{
    [Area("AWS")]
    public class EC2Controller : Controller
    {
        public IActionResult Index() => View();
        public IActionResult IntroductionToEC2() => View();
        public IActionResult EC2InstanceTypes() => View();
        public IActionResult LaunchEC2Instance() => View();
        public IActionResult SecurityGroups() => View();
        public IActionResult KeyPairs() => View();
        public IActionResult ElasticBlockStore() => View();
    }
}
