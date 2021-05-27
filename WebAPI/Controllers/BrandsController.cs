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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //if (DateTime.Now.Hour==00)
            //{
            //    return BadRequest();
            //}

            return Ok(_brandService.GetAll());

        }

        [HttpPost("add")]

        public IActionResult Add(Brand brand)
        {
            _brandService.Add(brand);

            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Brand brand)
        {
            _brandService.Delete(brand);

            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(Brand brand)
        {
            _brandService.Update(brand);

            return Ok();
        }
    }
}