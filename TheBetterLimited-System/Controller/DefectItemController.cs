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
    internal class DefectItemController : ControllerBase
    {
        public DefectItemController(string ControllerName) : base(ControllerName)
        {
            this.ControllerName = ControllerName;
        }

        public RestResponse Update(object data,string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName, Method.Put)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddBody(data);
            return GetRestResponse(request);
        }
    }
}
