
using TheBetterLimited_Server.AppLogic.Controllers;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.AppLogic.Models;
using System.Collections;
using TheBetterLimited_Server.Helpers.LogHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

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
        try
        {
            LoginOkModel token;
            controller.Login(data.UserName , data.Password, out token , HttpContext.Request);
            return Ok(token);
            
        }catch (ICustException e)
        {
            Helpers.LogHelper.FileLogger.InvalidAcceccLog(
                Helpers.HttpReader.GetClientSocket(HttpContext),
                Helpers.HttpReader.GetURL(HttpContext.Request),
                data.UserName is null ? "Unknown" : data.UserName
            );
          
            return StatusCode(e.ReturnCode , e.GetHttpResult());
        };
       
    }


    // User request to change password and the system will send a email to the user to change the password
    [HttpPost("requestresetpwd")]
    public IActionResult RequestResetPwd( [FromHeader] string lang , [FromBody] ForgetPwModel data)
    {
        try
        {
            controller.RequestForgetPW(data, lang);
            return Ok(new{status= 200 , message = "Email  is being sent to your mail box! Please check your mail box (or Junk box also) to reset your password."});

        }catch (ICustException e)
        {
            return StatusCode(e.ReturnCode , e.GetHttpResult());
        }
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


    [HttpPut("changepwd")]
    public void ChangePws(string username , string password)
    {
        controller.ChangePW(username , password);
    }
}