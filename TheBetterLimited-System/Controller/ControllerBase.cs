namespace TheBetterLimited_System.Controller
{
    public class ControllerBase
    {
        // CURD controller
        // GET      /api/[controller]/index
        // GET      /api/[controller]?limit={limit}&Language={lang}&offset={offset}
        // GET      /api/[controller]/csv?queryString={queryString}&Language={Language}
        // GET      /api/[controller]/pdf?queryString={queryString}&Language={Language}
        // GET      /api/[controller]?queryString={queryString}&Language={Language}
        // POST     /api/[controller]?Language={lang}
        // PUT      /api/[controller]?queryString={queryString}&Language={Language}
        // PUT      /api/[controller]/{id}?Language={lang}
        // DELETE   /api/[controller]/{id}

        public string ControllerName { get; set; }

        public ControllerBase(string ControllerName)
        {
            this.ControllerName = char.ToUpper(ControllerName[0]) + ControllerName.Substring(1);
        }

        public RestResponse GetRestResponse(RestRequest req)
        {
            try 
            {
                var response = RestClientUtils.client.ExecuteAsync(request).GetAwaiter().GetResult();
                return response;
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
        public RestResponse GetIndex()
        {
            var request = new RestRequest("/api/" + ControllerName + "/index", Method.Get)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            return GetRestResponse(request);
        }

        public RestResponse GetAll(string limit = "0", string offset = "0", string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName, Method.Get)
                        .AddQueryParameter("limit", limit)
                        .AddQueryParameter("offset", offset)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            return GetRestResponse(request);
        }

        public RestResponse GetByQueryString(string QueryString, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName + "/search", Method.Get)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddQueryParameter("querystring", qry);
            return GetRestResponse(request);
        }

        public RestResponse GetById(string id, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName + "/" + id, Method.Get)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            return GetRestResponse(request);
        }

        public RestResponse Create(object o , string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName, Method.Post)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddJsonBody(o);
            return GetRestResponse(request);
        }

        public RestResponse Update(string id , List<object> UpdateContent , string lang = "en" )
        {
            var request = new RestRequest("/api/" + ControllerName + "/" + id, Method.Put)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddJsonBody(UpdateContent);
            return GetRestResponse(request);
        }

        public RestResponse UpdateRange(string QueryString , List<object> UpdateContent, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName + "/update", Method.Put)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddQueryParameter("querystring", QueryString)
                        .AddJsonBody(UpdateContent);
            return GetRestResponse(request);
        }

        public RestResponse Delete(string id, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName + "/" + id, Method.Delete)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            return GetRestResponse(request);
        }

        public RestResponse DeleteRange(List<string> ids, string lang = "en")
        {
            foreach (var item in ids)
            {
                yield return Delete(item, lang);
            }
        }


    }
}