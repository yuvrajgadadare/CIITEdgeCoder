using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Controllers
{
    public class CSharpController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.code = "using System;class Program\r\n{\r\n    static void Main()\r\n    {\r\n        Console.Write(\"What is your first name? \");\r\n        string first = Console.ReadLine();\r\n\r\n        Console.Write(\"What is your last name? \");\r\n        string last = Console.ReadLine();\r\n\r\n        Console.WriteLine($\"\\nProcessing data for {first} {last}...\");\r\n        \r\n        Console.Write(\"Enter your birth year: \");\r\n        int year = int.Parse(Console.ReadLine());\r\n        \r\n        Console.WriteLine($\"Result: You are {2026 - year} years old!\");\r\n    }\r\n}";
            string codeSnippet = @"using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(""Hello, World!"");
        }
    }
}";

            ViewBag.CodeSnippet = codeSnippet;
            return View();
        }
        public IActionResult Introduction()
        {
            return View();
        }
    }
}
