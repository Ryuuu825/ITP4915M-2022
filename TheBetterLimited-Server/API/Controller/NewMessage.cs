using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Data.Dto;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.AppLogic.Controllers;
using TheBetterLimited_Server.AppLogic.Models;

namespace TheBetterLimited_Server.API.Controller
{
   [Route("api/v2/message")]
    public class TestMessage : ControllerBase
    {
        private readonly Data.Repositories.Repository<Data.Entity.Staff_Message> _receiveMessageTable;
        private readonly Data.Repositories.Repository<Data.Entity.Message> _sendMessageTable;
        private readonly Data.Repositories.UserInfoRepository _userInfo;
        private readonly Data.DataContext _db;

        public TestMessage(DataContext dataContext)
        {
            _receiveMessageTable = new Data.Repositories.Repository<Data.Entity.Staff_Message>(dataContext);
            _sendMessageTable = new Data.Repositories.Repository<Data.Entity.Message>(dataContext);
            _userInfo = new Data.Repositories.UserInfoRepository(dataContext);
            _db = dataContext;
        }

        [HttpGet("content")]
        [Authorize]
        public IActionResult GetMessageContent()
        {
            var staff = _userInfo.GetStaffFromUserName(User.Identity.Name);
            var message = _receiveMessageTable.GetBySQL(
               $"SELECT * FROM `staff_message` WHERE `_receiverId` = \"{staff._AccountId}\""
            );
            List<string> content = new List<string>();
            List<ContentItemDto> res = new List<ContentItemDto>();
            foreach (var item in message)
            {
                if (!content.Contains(item.message.sender.UserName))
                {
                    content.Add(item.message.sender.UserName);
                    res.Add(new ContentItemDto{Name = item.message.sender.UserName , _staffId = item.message.sender.Id});
                }
            }
            return Ok(res);
        }

        public class ContentItemDto
        {
            public string Name { get; set; }
            public string _staffId { get; set; }
        }
        
    }
}