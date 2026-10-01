using CIITEdge.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CIITEdge.Controllers
{
    public class HomeController : Controller
    {

        // Home page: shows the list of tutorials
        [Route("")]
        public IActionResult Index()
        {
             
            return View();
        }
        [Route("learning-path")]
        public IActionResult LearningPath()
        {

            return View();
        }
        // Details page: shows a single tutorial topic



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
