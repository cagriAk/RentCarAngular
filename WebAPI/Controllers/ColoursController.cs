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
    public class ColoursController : ControllerBase
    {
        IColourService _colourService;
        public ColoursController(IColourService colourService)
        {
            _colourService = colourService;

        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {


            return Ok(_colourService.GetAll());
        }

        [HttpPost("add")]

        public IActionResult Add(Colour colour)
        {
            _colourService.Add(colour);

            return Ok();
        }

        [HttpPost("update")]

        public IActionResult Update(Colour colour)
        {
            _colourService.Update(colour);

            return Ok();
        }

        [HttpPost("delete")]

        public IActionResult Delete(Colour colour)
        {
            _colourService.Delete(colour);

            return Ok();
        }
    }
}