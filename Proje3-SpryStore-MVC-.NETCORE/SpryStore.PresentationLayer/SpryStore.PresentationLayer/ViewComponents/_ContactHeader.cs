using Microsoft.AspNetCore.Mvc;

namespace SpryStore.PresentationLayer.ViewComponents
{
    public class _ContactHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
