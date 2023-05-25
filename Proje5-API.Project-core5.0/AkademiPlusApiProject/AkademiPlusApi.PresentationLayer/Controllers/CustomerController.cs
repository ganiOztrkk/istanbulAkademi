using System.Linq;
using AkademiPlusApi.BusinessLayer.Abstract;
using AkademiPlusApi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusApi.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IBalanceService _balanceService;

        public CustomerController(ICustomerService customerService, IBalanceService balanceService)
        {
            _customerService = customerService;
            _balanceService = balanceService;
        }

        [HttpGet]
        public IActionResult CustomerList()
        {
            var values = _customerService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CustomerAdd(Customer customer)
        {
            _customerService.TInsert(customer);
            Balance balance = new Balance()
            {
                AccountNumber = customer.AccountNumber,
                Currency = "₺",
                CustomerBalance = 0
            };
            _balanceService.TInsert(balance);
            return Ok();
        }

        [HttpDelete]
        public IActionResult CustomerDelete(int id)
        {
            var deletedCustomer = _customerService.TGetByID(id);
            _customerService.TDelete(deletedCustomer);
            var balanceList = _balanceService.TGetList();
            var balance = balanceList.Find(x => x.AccountNumber == deletedCustomer.AccountNumber);
            _balanceService.TDelete(balance);
            return Ok();
        }

        [HttpPut]
        public IActionResult CustomerUpdate(Customer customer)
        {
            _customerService.TUpdate(customer);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
             var selectedCustomer = _customerService.TGetByID(id);
            return Ok(selectedCustomer);
        }

    }
}
