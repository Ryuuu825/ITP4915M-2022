using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.AppLogic.Controllers;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.AppLogic.Models;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/[controller]")]
    public class SessionSetting : ControllerBase
    {   
        private readonly SessionSetttingController controller;
        public SessionSetting(DataContext db)
        {
            controller = new SessionSetttingController(db);
        }

        [HttpPost("{id}")]
        public IActionResult Post(string id , [FromBody] List<UpdateObjectModel> content)
        {
            try
            {
                controller.UpdateSessionSetting(id, content);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(controller.GetAll("en"));
        }
        
    }
}