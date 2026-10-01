using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSharp.Controllers
{
    [Area("CSharp")]

    public class BasicLanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VariableAndDataTypes()
        {
            return View();
        }
        public IActionResult TypeConversion()
        {
            return View();
        }
        public IActionResult Operators()
        {
            return View();
        }
        public IActionResult ControlFlowStatements()
        {
            return View();
        }
        public IActionResult Loops()
        {
            return View();
        }
    }
}
