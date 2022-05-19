using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class GlobalsData
    {
        private static string userId;
        private static string token;
        private static string expireAt;
        private static string firstname;
        private static string lastname;
        private static string jobTitle;
        private static string pwdMsg;

        public static string Token { get => token; set => token = value; }
        public static string ExpireAt { get => expireAt; set => expireAt = value; }
        public static string Firstname { get => firstname; set => firstname = value; }
        public static string Lastname { get => lastname; set => lastname = value; }
        public static string JobTitle { get => jobTitle; set => jobTitle = value; }
        public static string PwdMsg { get => pwdMsg; set => pwdMsg = value; }
        public static string UserId { get => userId; set => userId = value; }
    }
}
