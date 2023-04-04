using Microsoft.AspNetCore.Mvc;

namespace SpryStore.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        //ccdm axwm udiz upbu - mail işlemlerinde kullanılacak key

        public IActionResult Index()
        {
            return View();
        }
    }
}