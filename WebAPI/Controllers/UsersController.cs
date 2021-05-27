using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult Getall()
        {
            return Ok(_userService.GetAll());
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            _userService.Add(user);

            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            _userService.Update(user);

            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            _userService.Delete(user);

            return Ok();
        }
    }
}