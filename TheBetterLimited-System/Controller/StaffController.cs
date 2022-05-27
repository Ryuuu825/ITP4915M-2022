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
    internal class StaffController
    {
        private RestClient client;

        /**
         * Search Staff
         */
        public RestResponse GetAllStaff()
        {
            Console.WriteLine("Get all staff");
            var request = new RestRequest("/api/Staff", Method.Get)
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

        public RestResponse GetStaffsByQry(string qry)
        {
            Console.WriteLine("Get staff by " + qry);
            var request = new RestRequest("/api/Staff/search", Method.Get)
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

        public RestResponse GetStaffById(string uid)
        {
            Console.WriteLine("Get staff by " + uid);
            var request = new RestRequest("/api/Staff/"+uid, Method.Get)
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

        /**
         * Add Staff
         */

        /**
         * Edit Staff
         */

        /**
         * Delete Staff
         */
        public RestResponse DeleteStaff(string uid)
        {
            Console.WriteLine("Delete " + uid);
            var request = new RestRequest("/api/Staff/" + uid, Method.Delete)
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
    }
}
