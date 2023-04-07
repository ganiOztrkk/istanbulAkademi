using Microsoft.AspNetCore.Mvc;

namespace SpryStore.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        //ccdmaxwmudizupbu - mail işlemlerinde kullanılacak key

        public IActionResult Index()
        {
            return View();
        }
    }
}