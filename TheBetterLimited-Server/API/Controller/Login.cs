using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TheBetterLimited_Server.AppLogic.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBetterLimited_Server.API.Controllers;

[Route("api/[controller]")]
public class Login : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] JObject data)
    {
        var result = LoginController.Login("", "");
        var str = $"{{\"Result\":\"{result}\"}}";
        return Ok(JObject.Parse(str));
    }
}