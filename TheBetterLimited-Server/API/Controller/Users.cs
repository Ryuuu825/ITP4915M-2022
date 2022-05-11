using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.AppLogic.Controllers;
using TheBetterLimited_Server.AppLogic.Exceptions;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Helpers.Entity;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBetterLimited_Server.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Users : ControllerBase
{
    
    private readonly UserController controller;

    public Users(DataContext data)
    {
        controller = new UserController(data);
    }
    
    [HttpGet("index")]
    public List<String> Index()
    {
        return typeof(AccountDto).GetPropertiesToString();
    }
    // GET: api/values
    [HttpGet]
    public IActionResult GetWithLimit(int limit = 0 )
    {
        if (limit == 0)
            return Ok(controller.GetAllUsers());

        try
        {
            return Ok(controller.GetUsers(limit));
        }
        catch (BadArgException e)
        {
            return StatusCode(e.ReturnCode , e.GetHttpResult());
        }
        
    }

    [HttpGet("sql")]
    public async Task<IActionResult> GetAcc(string querystring)
    {
        string queryStr;
        if (querystring.Contains(":"))
            queryStr = Helpers.Sql.QueryStringBuilder.CreateSQLQuery( querystring , "accounts");
        else 
            queryStr = Helpers.Sql.QueryStringBuilder.LazyCreateSQLQuery<AccountDto>( querystring, "accounts");
        try
        {
            var o = await controller.GetUsersBySql(queryStr);
            
            return Ok(o);
        }
        catch (HasNoElementException e)
        {
            return StatusCode(e.ReturnCode, e.GetHttpResult());
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
    public async Task<IActionResult> PostAsync([FromBody] AccountDto value)
    {

        try
        {
            await controller.CreateUser(value);
        }
        catch (ICustException e)
        {
            return StatusCode(e.ReturnCode, e.GetHttpResult());
        }
        
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

    [HttpGet("test/{id}")]
    public IActionResult CheckIsExist(string id)
    {
        return Ok(controller.CheckIsExist(id));
    }
}