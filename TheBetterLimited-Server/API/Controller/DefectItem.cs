using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/[controller]")]
    public class DefectItem : ControllerBase
    {
        private AppLogic.Controllers.DefectItemController controller;
        public DefectItem(Data.DataContext db) 
        {
            controller = new AppLogic.Controllers.DefectItemController(db);
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add([FromBody] Data.Dto.DefectItemDto record)
        {
            try
            {
                controller.AddRefectItemRecord(User.Identity.Name, record);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }
        
    }
}