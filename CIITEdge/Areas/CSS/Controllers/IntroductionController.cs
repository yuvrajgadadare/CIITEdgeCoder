using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.CSS.Controllers
{
    [Area("CSS")]
    public class IntroductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WhatIsCSS()
        {
            return View();
        }

        public IActionResult HowCSSWorks()
        {
            return View();
        }

        public IActionResult CSSvsHTML()
        {
            return View();
        }

        public IActionResult AddingCSS()
        {
            return View();
        }
    }
}