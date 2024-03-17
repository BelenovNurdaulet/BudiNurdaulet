using Microsoft.AspNetCore.Mvc;

namespace Budi.Controllers
{
    [Route("about-budi")]
    public class AboutBudiController : Controller
    {
        //[Route("/about-budi/our-quality/")] // Добавляем маршрут для ссылки с слешем в конце
        //public IActionResult OurQualitySlash()
        //{
        //    return RedirectToActionPermanent("OurQuality"); // Перенаправляем на действие OurQuality без слеша
        //}

        [Route("our-quality")]
        public IActionResult OurQuality()
        {
            return View();
        }
    
        [Route("our-process")]
        public IActionResult OurProcess()
        {
            return View();
        }
        [Route("our-story")]
        public IActionResult OurStory()
        {
            return View();
        }
     
    }
}
