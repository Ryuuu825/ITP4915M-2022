using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.AppLogic.Controllers;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.AppLogic.Models;
using Microsoft.AspNetCore.Authorization;
using System.Collections;
using TheBetterLimited_Server.Helpers.LogHelper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBetterLimited_Server.API.Controllers;

[Route("api/login")]
public class LoginController : ControllerBase
{
    private readonly AppLogic.Controllers.LoginController controller;

    public LoginController(DataContext data)
    {
        controller = new AppLogic.Controllers.LoginController(data);
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromBody] LoginModel data)
    {
        LoginOkModel token;
        if (controller.Login(data.UserName , data.Password, out token))
            return Ok(token);
        else 
            return StatusCode(401 , "Invalid username or password");
    }

#if DEBUG
    [HttpPost("UpdateUserPasswordAsHashedPassword")]
    public async Task Test([FromBody] LoginModel data)
    {
        await controller.UpdateUserPasswordAsHashedPassword(data.UserName );
    }
#endif

    [Authorize]
    [HttpGet("claims")]
    public Hashtable Get()
    {
        var keyvalue = Helpers.HttpReader.GetClaims(HttpContext.Request);
        return keyvalue;

    }


    // User request to change password and the system will send a email to the user to change the password
    [HttpPost("requestresetpwd")]
    public void RequestResetPwd( [FromHeader] string lang , [FromBody] ForgetPwModel data)
    {
        controller.RequestForgetPW(data, lang);
    }

    // the web page that the user click to change the password
    [HttpGet("resetpwd/page")]
    public ContentResult ResetPwdPage( string token , string lang)
    {
        try
        {
            string html = String.Empty;
            controller.GetResetPwPage(token , lang , ref html);

            return base.Content(html, "text/html");

        }catch(Exception e)
        {
            ConsoleLogger.Debug(e.Message);
            return base.Content("<h1>Error</h1>", "text/html");
        }

    }

    [HttpPost("resetpwd")]
    [Authorize(Roles = "Admin,resetpassword")]
    public IActionResult ResetPwd([FromForm] string password)
    {
        try
        {
            controller.ResetPW(HttpContext.Request ,  password);
            return Ok();

        }catch (System.UnauthorizedAccessException e)
        {
            return StatusCode(401 , e.Message);
        }

    }
}