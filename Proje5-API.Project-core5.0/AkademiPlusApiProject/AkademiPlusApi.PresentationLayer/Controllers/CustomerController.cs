﻿using AkademiPlusApi.BusinessLayer.Abstract;
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

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
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
            return Ok();
        }

        [HttpDelete]
        public IActionResult CustomerDelete(int id)
        {
            var deletedCustomer = _customerService.TGetByID(id);
            _customerService.TDelete(deletedCustomer);
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