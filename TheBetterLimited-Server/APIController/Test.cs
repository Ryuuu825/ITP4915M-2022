using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TheBetterLimited_Server.Helper.File;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBetterLimited_Server.APIController
{
    [Route("api/[controller]")]
    public class Test : Controller
    {

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            return Ok(id);
        }

        [HttpPost("asd")]
        public IActionResult Post()
        {
            string str = @"{'Ken' : 'A'}";
            return Ok(JObject.Parse(str));
        }

        [HttpGet("tmp")]
        public IActionResult GetAsync()
        {
            String str = "";
            using (TempFile tmp = new TempFile() )
            {
                tmp.WriteAllText("This is something");
                str = tmp.ReadAllText();
            }
           
            return Ok(str);
        }
    }

}
