using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
        public RestResponse GetAllAccount()
        {
            Console.WriteLine("Get all departments");
            var request = new RestRequest("/api/users", Method.Get)
                        .AddHeader("limit", 100)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public RestResponse GetAccountByQry(string qry)
        {
            Console.WriteLine("Get departments by " + qry);
            var request = new RestRequest("/api/users/sql", Method.Get)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddQueryParameter("querystring", qry);
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }


        /**
         * Add User
         */
        public RestResponse AddAccount(object json)
        {
            Console.WriteLine("Create user " + json.GetType().GetProperty("userName").GetValue(json));
            var request = new RestRequest("/api/users/", Method.Post)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddJsonBody(json);
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        /**
         * Edit User
         */

        /**
         * Delete User
         */
        public RestResponse DeleteAccount(string uid)
        {
            Console.WriteLine("Delete " + uid);
            var request = new RestRequest("/api/users/" + uid, Method.Delete)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        /**
         * Lock User Account
         */
        public RestResponse LockAccount(string uid)
        {
            Console.WriteLine("Lock " + uid);
            var request = new RestRequest("/api/users/lock", Method.Post)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddJsonBody(new { id = uid, lockDay = 1 });
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        /**
         * Unlock User Account
         */
        public RestResponse UnlockAccount(string uid)
        {
            Console.WriteLine("Unlock " + uid);
            var request = new RestRequest("/api/users/unlock", Method.Post)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddJsonBody(new { id = uid });
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        /**
         * User Icon
         */
        public Bitmap InitUserIcon()
        {
            var request = new RestRequest("/api/goods/photo/001/1", Method.Get)
                       .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            try
            {
                var response = RestClientUtils.client.DownloadDataAsync(request).GetAwaiter().GetResult();
                Console.WriteLine(response);
                var ms = new MemoryStream(response);
                Bitmap bmp = new Bitmap(ms);
                ms.Close();
                return bmp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
