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
    internal class StockController : ControllerBase
    {
        public StockController(string ControllerName) : base(ControllerName)
        {
            this.ControllerName = ControllerName;
        }
        public RestResponse Update(string id, object UpdateContent, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName + "/" + id, Method.Put)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddJsonBody(UpdateContent);
            return GetRestResponse(request);
        }
    }
}
