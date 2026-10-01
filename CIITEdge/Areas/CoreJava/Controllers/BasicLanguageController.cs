using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CoreJava.Controllers
{
    [Area("CoreJava")]
    public class BasicLanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VariablesAndDataTypes()
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