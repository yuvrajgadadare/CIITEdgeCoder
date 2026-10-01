using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class OperatorsControlFlowController : Controller
    {
        // 1. Operators & Control Flow
        public IActionResult Index()
        {
            return View();
        }


        // 2. Arithmetic Operators
        public IActionResult ArithmeticOperators()
        {
            return View();
        }


        // 3. Comparison & Logical Operators
        public IActionResult ComparisonLogicalOperators()
        {
            return View();
        }


        // 4. If Else
        public IActionResult IfElse()
        {
            return View();
        }


        // 5. Switch
        public IActionResult Switch()
        {
            return View();
        }


        // 6. Loops
        public IActionResult Loops()
        {
            return View();
        }
    }
}