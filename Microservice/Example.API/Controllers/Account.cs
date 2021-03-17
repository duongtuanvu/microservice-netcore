using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Example.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Account : Controller
    {
        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return Ok("lol");
        }
    }
}
