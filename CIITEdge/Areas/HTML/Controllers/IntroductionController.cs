using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.HTML.Controllers
{
    [Area("HTML")]
    public class IntroductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WhatIsHTML()
        {
            return View();
        }

        public IActionResult HTMLDocumentStructure()
        {
            return View();
        }

        public IActionResult HowHTMLWorks()
        {
            return View();
        }

        public IActionResult HTMLvsCSSvsJavaScript()
        {
            return View();
        }
    }
}