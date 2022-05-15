using TheBetterLimited_Server.Data.Dto;

namespace TheBetterLimited_Server.AppLogic.Models
{
    public class LoginModel
    {
        [Required]
        [MaxLength(10)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
    }

    public class LoginOkModel 
    {
        public string Status { get; set; } 
        public string Token {get; set;}
        public DateTime ExpireAt {get; set;}
        public List<Permission> permissions {get; set;}
    }

    public class ForgetPwModel
    {
        public string UserName { get ; set ; }
        public string EmailAddress { get ; set ; }

    }

    public class Permission 
    {
        public string menu_name { get; set; }
        public bool? read { get; set; }

        public bool? write { get; set; }

        public bool? delete { get; set; }
    }
}