using Microsoft.AspNetCore.Mvc;

namespace Budi.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
