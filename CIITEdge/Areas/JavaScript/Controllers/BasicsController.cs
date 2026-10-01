using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    public class BasicsController : Controller
    {
        // 1. JavaScript Basics
        public IActionResult Index()
        {
            return View();
        }


        // 2. Variables
        public IActionResult Variables()
        {
            return View();
        }


        // 3. Data Types
        public IActionResult DataTypes()
        {
            return View();
        }


        // 4. Type Conversion
        public IActionResult TypeConversion()
        {
            return View();
        }


        // 5. Input and Output
        public IActionResult InputOutput()
        {
            return View();
        }
    }
}