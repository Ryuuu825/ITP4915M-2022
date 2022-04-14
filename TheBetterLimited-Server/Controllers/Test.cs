using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace TheBetterLimited_Server.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class Test : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }


        [HttpGet("json")]
        public IActionResult Get(JObject payload)
        {
            return Ok(payload.ToString());
        }

        
    }
}
