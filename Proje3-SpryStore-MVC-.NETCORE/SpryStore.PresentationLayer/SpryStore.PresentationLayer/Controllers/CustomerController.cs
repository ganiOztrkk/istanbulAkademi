using Microsoft.AspNetCore.Mvc;
using SpryStore.BusinessLayer.Abstract;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var values = _customerService.TGetList();
            return View(values);
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = _customerService.TGetByID(id);
            _customerService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.TInsert(customer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var values = _customerService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.TUpdate(customer);
            return RedirectToAction("Index");
        }

    }
}
