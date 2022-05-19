using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    public class User
    {
        private string status;
        private string token;
        private string expireAt;
        private Account account;

        public string Status { get => status; set => status = value; }
        public string Token { get => token; set => token = value; }
        public string ExpireAt { get => expireAt; set => expireAt = value; }
        internal Account Account { get => account; set => account = value; }

        public static implicit operator RestResponse(User v)
        {
            throw new NotImplementedException();
        }
    }
}
