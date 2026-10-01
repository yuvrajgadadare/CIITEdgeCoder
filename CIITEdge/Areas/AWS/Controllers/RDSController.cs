using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.AWS.Controllers
{
    [Area("AWS")]
    public class RDSController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult IntroductionToRDS() => View();
        public IActionResult DatabaseEngines() => View();
        public IActionResult CreateRDSDatabase() => View();
        public IActionResult Backups() => View();
    }
}
