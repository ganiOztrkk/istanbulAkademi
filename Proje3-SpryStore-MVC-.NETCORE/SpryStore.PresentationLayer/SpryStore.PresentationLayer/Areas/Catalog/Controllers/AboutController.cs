using Microsoft.AspNetCore.Mvc;
using SpryStore.BusinessLayer.Abstract;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.PresentationLayer.Areas.Catalog.Controllers
{
    public class AboutController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public AboutController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [Area("Catalog")]
        public IActionResult Index()
        {
            var values = _employeeService.TGetList();
            return View(values);
        }

        public PartialViewResult PartialAboutCover()
        {
            return PartialView();
        }
        public PartialViewResult PartialAboutWhatWeDo()
        {
            return PartialView();
        }
        public PartialViewResult PartialAboutEmployee()
        {
            return PartialView();
        }
    }
}
