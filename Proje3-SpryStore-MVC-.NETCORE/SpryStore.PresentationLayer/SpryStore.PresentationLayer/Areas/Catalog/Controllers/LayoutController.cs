using Microsoft.AspNetCore.Mvc;

namespace SpryStore.PresentationLayer.Areas.Catalog.Controllers
{
    [Area("Catalog")]
    public class LayoutController : Controller
    {
        public IActionResult _CatalogLayout()
        {
            return View();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult NavbarHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}
