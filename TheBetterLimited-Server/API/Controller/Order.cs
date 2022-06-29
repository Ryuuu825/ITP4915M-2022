using TheBetterLimited_Server.AppLogic.Controllers;
using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.Data.Dto;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public async Task<IActionResult> Add([FromBody] Data.Dto.OrderInDto order , [FromHeader] string Language = "en")
        {
            try 
            {   
                string orderId = await controller.CreateSalesOrder(User.Identity.Name , order);
                return Ok(await controller.GetById(orderId , Language));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet]
        public override async Task<IActionResult> Get(int limit = 0, uint offset = 0, [FromHeader] string Language = "en")
        {
            try
            {
                if (limit == 0)
                {
                    return Ok(await controller.GetAll(Language));
                }
                else
                {
                    return Ok(await controller.GetWithLimit(limit, offset, Language));
                }
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet("month/{month}")]

        public async Task<IActionResult> GetByMonth( int month, [FromHeader] string Language = "en")
        {
            try
            {
                return Ok(await controller.GetOrderByMonth(month, Language));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet("myorder")]
        [Authorize]
        public async Task<IActionResult> GetSelfOrderByDay( [FromHeader] string Language = "en")
        {
            try
            {
                return Ok(await controller.GetTodayOrder(User.Identity.Name , Language));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }


        [HttpGet("{id}")]
        public override async Task<IActionResult> GetById(string id, [FromHeader] string Language = "en")
        {
            try
            {
                return Ok(await controller.GetById(id, Language));
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

        [HttpDelete("{id}")]
        public override async Task<IActionResult> Delete(string id)
        {
            try
            {
                controller.SoftDeleteOrder(id);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpDelete("cancel/{id}")]
        public async Task<IActionResult> Cancel(string id)
        {
            try
            {
                controller.CancelOrder(id);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        
        [HttpPost("hold")]
        public IActionResult HoldOrder([FromBody] OrderInDto orderItems)
        {
            return Ok(controller.HoldOrder(orderItems));
        }

        [HttpGet("hold/{id}")]
        public IActionResult RetreiveHoldedOrder(string id)
        {
            try 
            {
                return Ok(controller.GetHoldedOrder(id));
            }catch(ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpDelete("hold/{id}")]
        public IActionResult DeleteHoldedOrder( string id)
        {
            try
            {
                controller.DeleteHoldedOrder(id);
                return Ok();
            }catch (ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }
        }

        [HttpGet("search")]
        public override async Task<IActionResult> GetByQueryString([FromQuery] string queryString , [FromHeader] string Language)
        {
            try
            {
                return Ok(await controller.GetByQueryString(queryString , Language));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPut("d")]
        [Authorize]
        public IActionResult Update([FromBody] OrderController.UpdateOrderDto entity, string language)
        {
            controller.updateOrder(User.Identity.Name , entity);
            return Ok();
        }




    }
}