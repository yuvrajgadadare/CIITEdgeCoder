using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSharp.Controllers
{
    [Area("CSharp")]

    public class ModernCSharpController : Controller
    {
        public IActionResult RecordTypes()
        {
            return View();
        }
        public IActionResult PatternMatching()
        {
            return View();
        }
        public IActionResult TopLevelStatements()
        {
            return View();
        }
        public IActionResult NullableReferenceTypes()
        {
            return View();
        }

    }
}
