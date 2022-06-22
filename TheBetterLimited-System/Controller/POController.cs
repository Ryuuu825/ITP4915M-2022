using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Controller
{
    internal class POController : ControllerBase
    {
        public POController(string ControllerName) : base(ControllerName)
        {
            this.ControllerName = ControllerName;
        }
        public RestResponse Update(object UpdateContent, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName, Method.Put)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddJsonBody(UpdateContent);
            return GetRestResponse(request);
        }
        public RestResponse Delete(string id, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName + "/", Method.Delete)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddHeader("id", id);
            return GetRestResponse(request);
        }
        public RestResponse UpdateStatus(string id, int status, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName + "/status/"+id, Method.Delete)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddBody(status);
            return GetRestResponse(request);
        }
    }
}
