using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using TheBetterLimited.Utils;

namespace TheBetterLimited.Controller
{
    internal class LoginController
    {

        /**
        * change password
        */
        public RestResponse ChangePassword(string username, string newPwd)
        {
            var request = new RestRequest("/api/change", Method.Post)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddQueryParameter("username", username)
                        .AddQueryParameter("password", newPwd);
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /**
         * reset password
         */
        public RestResponse ResetPassword(string username, string email)
        {
            string l = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var json = new { userName = username, emailAddress = email, lang = l };
            var request = new RestRequest("/api/login/requestresetpwd", Method.Post)
                        .AddHeader("lang", l)
                        .AddJsonBody(json);
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /**
         * login system
         */
        public string Login(string username, string pwd)
        {
            var json = new { userName = username, password = pwd };
            var request = new RestRequest("/api/login", Method.Post)
                        .AddJsonBody(json);
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var res = JObject.Parse(response.Content);
                    GlobalsData.currentUser.Add("token", res["userToken"]["tokenString"].ToString());
                    GlobalsData.currentUser.Add("expireAt", res["userToken"]["expireAt"].ToString());
                    GlobalsData.currentUser.Add("displayName", res["initData"]["displayName"].ToString());
                    GlobalsData.currentUser.Add("department", res["initData"]["department"].ToString());
                    GlobalsData.currentUser.Add("position", res["initData"]["position"].ToString());
                    GlobalsData.currentUser.Add("staffId", res["initData"]["_StaffId"].ToString());
                    return "ok";
                }
                else
                {
                    var res = JObject.Parse(response.Content);
                    return res["message"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Cannot connect to server!";
            }
        }
    }
}
