using Microsoft.AspNetCore.Mvc;

namespace Budi.Controllers
{
    [Route("our-services")]
    public class OurServicesController : Controller
    {
        [Route("customer-support")]
        public IActionResult CustomerSupport()
        {
            return View();
        }
        [Route("deliveries-returns")]
        public IActionResult DeliveriesReturns()
        {
            return View();
        }
        [Route("reseller-program")]
        public IActionResult ResellerProgram()
        {
            return View();
        }
    }
}
