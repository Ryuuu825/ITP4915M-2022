using TheBetterLimited_Server.AppLogic.Controllers;
using Microsoft.AspNetCore.Mvc;
namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/order")]
    public class Order : APIControllerBase<Data.Entity.SalesOrder>
    {
        private readonly OrderController controller;
        private readonly IConfiguration _config;
        public Order(Data.DataContext db , IConfiguration _config ) : base(db)
        {
            this._config = _config;
            controller = new OrderController(db);
        }


        [HttpPost("create")]
        public async Task<IActionResult> Add([FromBody] Data.Dto.OrderInDto order , [FromHeader] string Language = "en")
        {
            try 
            {   
                await controller.CreateSalesOrder(order);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPost]
        public override async Task<IActionResult> Add([FromBody] Data.Entity.SalesOrder entity, string language)
        {
            return StatusCode(301, "please use /api/order/create");
        }




    }
}