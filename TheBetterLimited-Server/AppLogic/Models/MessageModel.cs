namespace TheBetterLimited_Server.AppLogic.Models
{
    using TheBetterLimited_Server.Data.Dto;

    public class MessageModel
    {
        
    }

    public class ReceiveMessageModel
    {
        public short messageReceived { get; set; }
        public List<ReceiveMessageDto> messages { get; set; }
    }
}