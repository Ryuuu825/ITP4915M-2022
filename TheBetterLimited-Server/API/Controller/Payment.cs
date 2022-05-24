namespace TheBetterLimited_Server.API.Controller
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using TheBetterLimited_Server.AppLogic.Controllers;

    [Route("api/[controller]")]
    // [Authorize]
    public class Payment : ControllerBase
    {
        private readonly PaymentController controller;

        public Payment(Data.DataContext db)
        {
            controller = new PaymentController(db);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreatePayment( [FromBody] Data.Dto.TransactionDto req)
        {
            Data.Dto.TransactionResDto res = await controller.CreatePayment(req);
            return Ok(res);
        }
    }
}