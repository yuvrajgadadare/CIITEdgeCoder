using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Controllers
{
    public class AccountController : Controller
    {
        // Login Page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Registration Page
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}