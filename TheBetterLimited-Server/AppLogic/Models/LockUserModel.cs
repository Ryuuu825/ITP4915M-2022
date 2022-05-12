namespace TheBetterLimited_Server.AppLogic.Models
{
    public class LockUserModel
    {
        public string id {get; set;}
        public uint lockDay {get; set;}
    }

    public class UnlockUserModel
    {
        public string id {get; set;}
    }
}