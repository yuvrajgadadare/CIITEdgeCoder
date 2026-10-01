using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CoreJava.Controllers
{
    [Area("CoreJava")]
    public class ModernJavaController : Controller
    {
        public IActionResult VarKeyword() => View();

        public IActionResult SwitchExpressions() => View();

        public IActionResult PatternMatching() => View();

        public IActionResult TextBlocks() => View();

        public IActionResult RecordClasses() => View();

        public IActionResult SealedClasses() => View();

        public IActionResult ModernInterfaces() => View();

        public IActionResult ModernJavaFeatures() => View();
    }
}