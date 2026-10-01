using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.AWS.Controllers
{
    [Area("AWS")]
    public class S3Controller : Controller
    {
        public IActionResult Index() => View();
        public IActionResult IntroductionToS3() => View();
        public IActionResult S3Buckets() => View();
        public IActionResult S3Objects() => View();
        public IActionResult Versioning() => View();
        public IActionResult BucketPolicies() => View();
    }
}
