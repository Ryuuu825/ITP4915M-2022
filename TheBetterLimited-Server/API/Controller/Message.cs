namespace TheBetterLimited_Server.API.Controller
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using TheBetterLimited_Server.Data;
    using TheBetterLimited_Server.AppLogic.Controllers;
    using TheBetterLimited_Server.AppLogic.Models;

    [Route("api/message")]
    public class Message : ControllerBase
    {
        private readonly MessageController controller;

        public Message(DataContext db)
        {
            controller = new MessageController(db);
        }
        [HttpGet]
        [Authorize]
        public ReceiveMessageModel GetMessage()
        {
            return controller.GetMessage( User.Identity.Name );
        }

        [HttpPost]
        [Authorize]
        public IActionResult SendMessage([FromBody] Data.Dto.SendMessageDto message)
        {
            controller.SendMessage(User.Identity.Name , message);
            return Ok();
        }
    }
}