using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBetterLimited.Models;
using TheBetterLimited.Utils;

namespace TheBetterLimited.Controller
{
    internal class CatalogueController
    {
        private RestClient client;

        /**
         * Search Department
         */
        public RestResponse GetAllCatalogue()
        {
            Console.WriteLine("Get all catalogues");
            var request = new RestRequest("/api/Catalogue", Method.Get)
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

        public RestResponse GetCatalogueByQry(string qry)
        {
            Console.WriteLine("Get catalogue by " + qry);
            var request = new RestRequest("/api/Catalogue/search", Method.Get)
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

        public RestResponse GetCatalogueById(string uid)
        {
            Console.WriteLine("Get catalogue by " + uid);
            var request = new RestRequest("/api/Catalogue/" + uid, Method.Get)
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
         * Add Goods
         */

        /**
         * Edit Goods
         */

        /**
         * Delete Goods
         */
        public RestResponse DeleteCatalogue(string uid)
        {
            Console.WriteLine("Delete " + uid);
            var request = new RestRequest("/api/Catalogue/" + uid, Method.Delete)
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
         * Get Goods PDF
         */
        public byte[] GetCataloguePDF()
        {
            Console.WriteLine("Get Catalogue PDF");
            var request = new RestRequest("/api/Warehouse/pdf", Method.Get)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            try
            {
                var response = RestClientUtils.client.DownloadDataAsync(request).GetAwaiter().GetResult();
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
