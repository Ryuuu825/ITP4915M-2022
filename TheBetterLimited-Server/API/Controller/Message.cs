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
        [HttpGet("unread")]
        [Authorize]
        public ReceiveMessageModel GetMessage()
        {
            return controller.GetUnReadMessage( User.Identity.Name );
        }

        [HttpGet("unreceived")]
        [Authorize]
        public ReceiveMessageModel GetUnreceiveMessage()
        {
            return controller.GetUnreceivedMessage( User.Identity.Name );
        }

        [HttpPut("read/{id}")]
        [Authorize]
        public void GetMessage(string id)
        {
            controller.setMessageRead(id);
        }


        [HttpGet]
        [Authorize]
        public ReceiveMessageModel GetReadMessage(uint limit = 0)
        {
            return controller.GetMessage( User.Identity.Name , limit );

        }

        [HttpPost]
        [Authorize]
        public IActionResult SendMessage([FromBody] Data.Dto.SendMessageDto message)
        {
            try
            {
                controller.SendMessage(User.Identity.Name , message);
                return Ok();
            }catch (ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }
        }

        [HttpGet("user/{username}")]
        public IActionResult CheckUserExist(string username)
        {
            if (controller.CheckUserExist(username))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}