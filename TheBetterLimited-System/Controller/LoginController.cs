using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SDPTest.CustomizeControl;
using SDPTest.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SDPTest.Controller
{
    internal class LoginController
    {

        /**
        * change password
        */
        public string ChangePassword(string username, string oldPwd, string newPwd)
         {
            HttpsConnector http = new HttpsConnector(@"http://localhost:5233/api/login/requestresetpwd");
            var acc = new { userName = username, password = newPwd };
            string json = JsonConvert.SerializeObject(acc);
            var response = http.SendPostRequest(json);
            Console.WriteLine("response:" + response);
            if (response != null)
            {
                User user = JsonConvert.DeserializeObject<User>(response);
                GlobalsData.Token = user.Token;
                GlobalsData.ExpireAt = user.ExpireAt;
                GlobalsData.Firstname = "Ben";
                GlobalsData.Lastname = "Poon";
                GlobalsData.JobTitle = "Admin";
                Console.WriteLine(user.Status);

                return user.Status;
            }
            return null;
        }

        /**
         * reset password
         */
        public ResponseResult ResetPassword(string username, string email)
        {
            RestClient client = new RestClient("http://localhost:5233/api/login/requestresetpwd");
            string l = CultureInfo.CurrentCulture.Name.Split('-')[0];
            var json = new { userName = username, emailAddress = email, lang = l};
            var request = new RestRequest("/", Method.Post)
                        .AddHeader("lang",l)
                        .AddJsonBody(json);
            var response = client.ExecuteAsync(request).GetAwaiter().GetResult();
            var res = JObject.Parse(response.Content);
            ResponseResult values = new ResponseResult(res["status"].ToString(), res["message"].ToString());
            return values;
        }

        /**
         * login system
         */
        public string Login(string username, string pwd)
        {
            RestClient client = new RestClient("http://localhost:5233/api/login");
            var json = new { userName = username , password = pwd};
            var request = new RestRequest("/", Method.Post)
                        .AddJsonBody(json);
            var response = client.ExecuteAsync(request).GetAwaiter().GetResult();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var res = JObject.Parse(response.Content);
                GlobalsData.Token = res["token"].ToString();
                GlobalsData.ExpireAt = res["expireAt"].ToString();
                GlobalsData.Firstname = "Ben";
                GlobalsData.Lastname = "Poon";
                GlobalsData.JobTitle = "Admin";
                //GlobalsData.UserId = user.Account.Id;
                return "ok";
            }else
            {
                var res = JObject.Parse(response.Content);
                return res["message"].ToString();
            }
        }
    }
}
