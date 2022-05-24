using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBetterLimited.Models;
using TheBetterLimited.Utils;

namespace TheBetterLimited.Controller
{
    internal class UserController
    {
        private RestClient client;

        /**
         * Search User
         */
        public DataTable GetAllAccount()
        {
            var request = new RestRequest("/api/users", Method.Get)
                        .AddHeader("limit", 100);
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response.Content, (typeof(DataTable)));
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetSpecificAccount(string qry)
        {
           var request = new RestRequest("/api/users/sql", Method.Get)
                        .AddQueryParameter("querystring", qry );
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                Console.WriteLine(response.Content);
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response.Content, (typeof(DataTable)));
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        /**
         * Add User
         */

        /**
         * Edit User
         */

        /**
         * Delete User
         */

        /**
         * Lock User Account
         */
        public String LockAccount(string uid)
        {
            var request = new RestRequest("/api/users/lock", Method.Post)
                        .AddJsonBody(new { id = uid, lockDay = 1 });
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                string res = JObject.Parse(response.Content).ToString();
                Console.WriteLine(res);
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Cannot connect to server!";
            }
        }

        /**
         * Unlock User Account
         */
        public String UnlockAccount(string uid)
        {
            var request = new RestRequest("/api/users/unlock", Method.Post)
                        .AddJsonBody(new { id = uid});
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                string res = JObject.Parse(response.Content).ToString();
                Console.WriteLine(res);
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Cannot connect to server!";
            }
        }
    }
}
