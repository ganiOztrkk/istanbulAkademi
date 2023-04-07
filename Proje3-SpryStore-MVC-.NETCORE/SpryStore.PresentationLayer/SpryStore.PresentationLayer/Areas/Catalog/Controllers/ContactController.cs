using Microsoft.AspNetCore.Mvc;

namespace SpryStore.PresentationLayer.Areas.Catalog.Controllers
{
    public class ContactController : Controller
    {
        [Area("Catalog")]
        public IActionResult Index()
        {
            return View();
        }
    }
}