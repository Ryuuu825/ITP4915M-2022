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
    internal class PositionController
    {
        private RestClient client;

        /**
         * Search Postion
         */
        public RestResponse GetAllPosition()
        {
            Console.WriteLine("Get all positions");
            var request = new RestRequest("/api/Position", Method.Get)
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

        public RestResponse GetPositionByQry(string qry)
        {
            Console.WriteLine("Get positions by " + qry);
            var request = new RestRequest("/api/Position/search", Method.Get)
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

        public RestResponse GetPositionById(string uid)
        {
            Console.WriteLine("Get position by " + uid);
            var request = new RestRequest("/api/Position/"+uid, Method.Get)
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
         * Add Position
         */

        /**
         * Edit Position
         */

        /**
         * Delete Position
         */
        public RestResponse DeletePosition(string uid)
        {
            Console.WriteLine("Delete " + uid);
            var request = new RestRequest("/api/Position/" + uid, Method.Delete)
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
