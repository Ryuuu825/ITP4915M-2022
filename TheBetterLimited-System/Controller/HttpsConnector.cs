using Newtonsoft.Json;
using SDPTest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;
using RestSharp;
using System.Threading;

namespace SDPTest.Controller
{
    internal class HttpsConnector : Attribute
    {
        private string _url;
        public HttpsConnector(string url)
        {
            _url = url;
        }

        [HttpsConnector("http://localhost:5233/api/login")]
        public string SendPostRequest(string requestParams)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(_url);
            request.Method = "POST";
            request.ContentType = "application/json";
            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            request.ContentLength = byteArray.Length;
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
                requestStream.Close();
            }
            
            try
            {
                //get the response
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                        string Json = rdr.ReadToEnd(); // response from server
                        rdr.Close();
                        response.Close();
                        return Json;
                    }

                }
            }
            catch (WebException e)
            {
                Console.WriteLine("This program is expected to throw WebException on successful run." +
                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);
                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                            string Json = rdr.ReadToEnd(); // response from server
                            Console.WriteLine(Json);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return null;
        }
      
/*
        [HttpsConnector("http://localhost:5233/api/login")]
        public async Task<HttpResponseMessage> SendRequestAsync(string json)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var data = new FormUrlEncodedContent(json);
                Console.WriteLine(data);
                HttpResponseMessage responseMessage = null;

                    responseMessage = await httpClient.PostAsync(_url, data);
   
                return responseMessage;
            }
        }
          */
        public object GetRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
            request.Method = "Get";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            var result = JsonConvert.DeserializeObject(@reader.ReadToEnd().ToString());
            return result;
        }

        public async Task<string> PostRequestAsync(string json)
        {
            RestClient client = new RestClient(_url);
            var request = new RestRequest()
                        .AddJsonBody(json);
            var response = await client.PostAsync<ResponseResult>(request);
            Console.WriteLine(response);
            return null;
        }
    }
}
