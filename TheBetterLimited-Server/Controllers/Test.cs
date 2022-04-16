<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBetterLimited_Server.Controllers
{
    [Route("api/[controller]")]
    public class Test : Controller
    {
        [HttpGet("/")]        
        public IActionResult Get()
        {
            return Ok("Hello World");
        }

        [HttpGet("json")]
        public IActionResult Get(JObject payload)
        {
            return Ok(payload);
        }
    }
      
}
