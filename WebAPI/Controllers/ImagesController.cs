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
    public class ImagesController : ControllerBase
    {
        IImageService __ımageService;
        
        public ImagesController(IImageService ımageService)
        {
            __ımageService = ımageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] Image ımage)
        {
            var result = __ımageService.Add(ımage, file);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}