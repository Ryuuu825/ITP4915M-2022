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

namespace TheBetterLimited.Controller
{
    internal class UserController
    {
        /**
         * Search User
         */
        public DataTable GetAllAccount()
        {
            RestClient client = new RestClient("http://localhost:5233/api/users");
            var request = new RestRequest("/", Method.Get)
                        .AddHeader("limit", 100);
            try
            {
                var response = client.ExecuteAsync(request).GetAwaiter().GetResult();
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
            RestClient client = new RestClient("http://localhost:5233/api/users/sql");
            var request = new RestRequest("/", Method.Get)
                        .AddHeader("querystring", qry);
            try
            {
                var response = client.ExecuteAsync(request).GetAwaiter().GetResult();
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
            RestClient client = new RestClient("http://localhost:5233/api/users/lock");
            var request = new RestRequest("/", Method.Post)
                        .AddJsonBody(new { id = uid, lockDay = 1 });
            try
            {
                var response = client.ExecuteAsync(request).GetAwaiter().GetResult();
                string res = JObject.Parse(response.Content).ToString();
                Console.WriteLine(res);
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /**
         * Lock User Account
         */
        public String UnlockAccount(string uid)
        {
            RestClient client = new RestClient("http://localhost:5233/api/users/unlock");
            var request = new RestRequest("/", Method.Post)
                        .AddJsonBody(new { id = uid, lockDay = 1 });
            try
            {
                var response = client.ExecuteAsync(request).GetAwaiter().GetResult();
                string res = JObject.Parse(response.Content).ToString();
                Console.WriteLine(res);
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
