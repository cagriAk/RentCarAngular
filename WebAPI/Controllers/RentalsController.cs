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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult Getall()
        {


            return Ok(_rentalService.GetAll());
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            _rentalService.Add(rental);

            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            _rentalService.Update(rental);

            return Ok();
        }


        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            _rentalService.Delete(rental);

            return Ok();
        }
    }
}