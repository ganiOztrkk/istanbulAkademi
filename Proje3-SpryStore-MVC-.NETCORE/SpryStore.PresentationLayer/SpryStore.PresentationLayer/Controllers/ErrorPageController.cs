using Microsoft.AspNetCore.Mvc;

namespace SpryStore.PresentationLayer.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Page404()
        {
            return View();
        }
    }
}
