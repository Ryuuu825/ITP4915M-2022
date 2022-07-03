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
    internal class OrderController : ControllerBase
    {
        public OrderController(string ControllerName) : base(ControllerName)
        {
            this.ControllerName = ControllerName;
        }

        public RestResponse Cancel(string id, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName + "/cancel/" + id, Method.Delete)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            return GetRestResponse(request);
        }

        public RestResponse Modify(object obj, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName + "/d", Method.Put)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddBody(obj);
            return GetRestResponse(request);
        }
    }
}
