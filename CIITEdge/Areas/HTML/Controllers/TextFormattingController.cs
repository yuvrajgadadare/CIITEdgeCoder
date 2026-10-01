using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.HTML.Controllers
{
    [Area("HTML")]
    public class TextFormattingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TextFormatting()
        {
            return View();
        }

        public IActionResult BoldAndStrong()
        {
            return View();
        }

        public IActionResult ItalicAndEmphasis()
        {
            return View();
        }

        public IActionResult UnderlineAndHighlight()
        {
            return View();
        }

        public IActionResult SubscriptAndSuperscript()
        {
            return View();
        }

        public IActionResult Quotations()
        {
            return View();
        }

        public IActionResult Abbreviations()
        {
            return View();
        }

        public IActionResult SpecialCharacters()
        {
            return View();
        }
    }
}