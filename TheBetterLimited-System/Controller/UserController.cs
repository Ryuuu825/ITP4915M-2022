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
         * Search All User
         */
        public RestResponse GetAllAccount()
        {
            Console.WriteLine("Get all users");
            var request = new RestRequest("/api/users", Method.Get)
                        .AddHeader("limit", 0)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                Console.WriteLine("StatusCode: " + response.StatusCode);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        /**
         * Search Specific User
         */
        public RestResponse GetAccountByQry(string qry)
        {
            Console.WriteLine("Get users by " + qry);
            var request = new RestRequest("/api/users/sql", Method.Get)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddQueryParameter("querystring", qry);
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                Console.WriteLine("StatusCode: " + response.StatusCode);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        /**
         * Search Specific User by ID
         */
        public RestResponse GetAccountById(string uid)
        {
            Console.WriteLine("Get users by " + uid);
            var request = new RestRequest($"/api/users/{uid}", Method.Get)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                Console.WriteLine("StatusCode: " + response.StatusCode);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
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
                Console.WriteLine("StatusCode: " + response.StatusCode);
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
        public RestResponse UpdateAccount(object json, string uid)
        {
            Console.WriteLine("Update user by "+uid);
            var request = new RestRequest($"/api/users/{uid}", Method.Put)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddBody(json);
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                Console.WriteLine("StatusCode: " + response.StatusCode);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public RestResponse UpdatePersonalAccount(List<object> json)
        {
            Console.WriteLine("Update user");
            var request = new RestRequest($"/api/users/", Method.Put)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddBody(json);
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                Console.WriteLine("StatusCode: " + response.StatusCode);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        /**
         * Delete User
         */
        public RestResponse DeleteAccount(string uid)
        {
            Console.WriteLine("Delete " + uid);
            var request = new RestRequest($"/api/users/{uid}", Method.Delete)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                Console.WriteLine("StatusCode: " + response.StatusCode);
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
                Console.WriteLine("StatusCode: " + response.StatusCode);
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
                Console.WriteLine("StatusCode: " + response.StatusCode);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        /**
         * Get User Icon
         */
        public Bitmap GetUserIcon()
        {
            var request = new RestRequest("/api/users/icon", Method.Get)
                       .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            try
            {
                var response = RestClientUtils.client.DownloadDataAsync(request).GetAwaiter().GetResult();
                Console.WriteLine("Content: " + response);
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

        public Bitmap GetUserIconById(string uid)
        {
            Console.WriteLine("Get icon by " + uid);
            Console.WriteLine("/api/users/" + uid + "/icon");
            var request = new RestRequest($"/api/users/{uid}/icon", Method.Get)
                       .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            try
            {
                var response = RestClientUtils.client.DownloadDataAsync(request).GetAwaiter().GetResult();
                Console.WriteLine("Content: " + response);
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

        /**
        * Upload User Icon
        */
        public RestResponse UploadUserIcon(byte[] img, string uid)
        {
            Console.WriteLine($"/api/users/{uid}/icon");
            var request = new RestRequest($"/api/users/{uid}/icon", Method.Post)
                       .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                       .AddBody(Convert.ToBase64String(img));
            try
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                Console.WriteLine("StatusCode: "+response.StatusCode);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
