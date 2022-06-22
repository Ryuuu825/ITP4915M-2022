namespace TheBetterLimited_Server.Data.Dto
{
    public class ReceiveMessageDto
    {
        public string senderName { get; set; }
        public string sentDate { get; set; }

        public string Title { get; set; }
        public string content { get; set; }
    }

    public class SendMessageDto 
    {
        public List<string> receiver { get; set; } // the account id -.-
        public string Title { get; set; }
        public string content { get; set; }
    }
}