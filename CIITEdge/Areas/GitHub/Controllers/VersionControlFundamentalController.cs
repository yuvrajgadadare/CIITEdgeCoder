using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.GitHub.Controllers
{
    [Area("GitHub")]
    public class VersionControlFundamentalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WhatisVersionControl()
        {
            return View();
        }
        public IActionResult GitAndGitHub()
        {
            return View();
        }
        public IActionResult InstallationAndSetup()
        {
            return View();
        }
        public IActionResult InitialConfiguration()
        {
            return View();
        }
    }
}
