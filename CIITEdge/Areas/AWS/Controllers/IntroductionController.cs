using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.AWS.Controllers
{
    [Area("AWS")]
    public class IntroductionController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult WhatIsAWS() => View();
        public IActionResult AWSGlobalInfrastructure() => View();
        public IActionResult AWSManagementConsole() => View();
        public IActionResult RootVsIAM() => View();
        public IActionResult AWSFreeTier() => View();
        public IActionResult AWSAccountSetup() => View();
    }
}
