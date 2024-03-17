using Microsoft.AspNetCore.Mvc;

namespace Budi.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("free-anxiety")]
        public IActionResult FreeAnxiety()
        {
            return View();
        }
        [Route("less-stress")]
        public IActionResult LessStress()
        {
            return View();
        }
        [Route("sleep-better")]
        public IActionResult SleepBetter()
        {
            return View();
        }
    }
}
