using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {


            return Ok(_customerService.GetAll());
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            _customerService.Add(customer);

            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            _customerService.Update(customer);

            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            _customerService.Delete(customer);

            return Ok();
        }
    }
}