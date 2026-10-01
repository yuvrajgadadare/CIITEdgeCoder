using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.AWS.Controllers
{
    [Area("AWS")]
    public class CloudWatchController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult IntroductionToCloudWatch() => View();
        public IActionResult Metrics() => View();
        public IActionResult CloudWatchLogs() => View();
        public IActionResult Alarms() => View();
    }
}
