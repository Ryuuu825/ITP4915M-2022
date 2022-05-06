using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.AppLogic.Controllers;
using TheBetterLimited_Server.AppLogic.Exceptions;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Helpers.Entity;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBetterLimited_Server.API.Controllers;

[Route("api/[controller]")]
[Authorize(Roles = "admin,staff")]
public class Users : ControllerBase
{
    private readonly UserController controller;

    public Users(DataContext data)
    {
        controller = new UserController(data);
    }
    
    [HttpGet("index")]
    public IActionResult Index()
    {
        return Ok(typeof(UserController).GetPropertiesToString<Account>());
    }
    // GET: api/values
    [HttpGet]
    public IActionResult GetWithLimit(int limit )
    {
        if (limit == 0)
            return Ok(controller.GetAllUsers());
        
        try
        {
            return Ok(controller.GetUsers(limit));
        }
        catch (System.ArgumentException e)
        {
            return BadRequest("Limit too large or too small");
        }
    }

    [HttpGet("sql/{querystring}")]
    public IActionResult GetAcc(string querystring)
    {
        string queryStr;
        if (querystring.Contains("="))
            queryStr = Helpers.Sql.QueryStringBuilder.CreateSQLQuery<Account>( querystring);
        else 
            queryStr = Helpers.Sql.QueryStringBuilder.LazyCreateSQLQuery<Account>( querystring);
        try
        {
            return Ok(controller.GetUserBySql(queryStr));
        }
        catch (HasNoElementException e)
        {
            return base.NotFound("Object not found");
        }
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        return Ok(controller.GetUserByID(id));
    }

    // POST api/values
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] Data.Dto.Acc value)
    {
        controller.CreateUser(value.Copy<Data.Entity.Account>() );
        return Ok();
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}