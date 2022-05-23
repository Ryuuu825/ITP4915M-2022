using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBetterLimited.Models;

namespace TheBetterLimited.Models
{
    internal class Account
    {
        private string id;
        private string userName;
        private string password;
        private string emailAddress;
        private string status;
        private string remarks;

        public Account(string id, string userName, string password,string emailAddress, string status, string remarks)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.emailAddress = emailAddress;
            this.status = status;
            this.remarks = remarks;
        }

        public string Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Status { get => status; set => status = value; }
        public string Remarks { get => remarks; set => remarks = value; }

    }
}
