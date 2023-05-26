using AkademiPlusApi.BusinessLayer.Abstract;
using AkademiPlusApi.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusApi.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private readonly IBalanceService _balanceService;

        public BalanceController(IBalanceService balanceService)
        {
            _balanceService = balanceService;
        }

        [HttpGet]
        public IActionResult BalanceList()
        {
            var balanceList = _balanceService.TGetList();
            return Ok(balanceList);
        }

        [HttpPost]
        public IActionResult AddBalance(Balance balance)
        {
            _balanceService.TInsert(balance);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteBalance(int id)
        {
            var balance = _balanceService.TGetByID(id);
            _balanceService.TDelete(balance);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBalance(Balance balance)
        {
            _balanceService.TUpdate(balance);
            return Ok();
        }
    }
}
