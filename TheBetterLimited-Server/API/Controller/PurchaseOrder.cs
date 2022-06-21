using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/purchase/order")]
    public class Purchase_PurchaseOrder : ControllerBase
    {
        private AppLogic.Controllers.PurchaseOrderController controller;

        public Purchase_PurchaseOrder(Data.DataContext db)
        {
            controller = new AppLogic.Controllers.PurchaseOrderController(db);
        }


        [HttpGet]
        [Authorize]
        public IActionResult GetAll([FromHeader] string Language)
        {
            try
            {
                return Ok(controller.GetAll(User.Identity.Name , Language));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] Data.Dto.PurchaseOrderInDto dto)
        {
            try
            {
                // print the raw request body
                ConsoleLogger.Debug( dto is null);
                controller.CreateEntry(dto, User.Identity.Name);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }
        }
        
        [HttpDelete]
        public IActionResult Delete([FromHeader] string id)
        {
            try
            {
                controller.Delete(id);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }
        }
    }
}