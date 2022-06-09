namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public interface IAppTranslatableControllerBase<T>
    {
        public Task<List<Hashtable>> GetAll(string lang = "en");
        public Task<Hashtable> GetById(string id,string lang = "en");

        public Task<List<Hashtable>> GetByQueryString(string queryString,string lang = "en");
        public Task<string> Add(T entity,string lang = "en");
        public Task Modify(string id, List<AppLogic.Models.UpdateObjectModel> content,string lang = "en");

        public Task Delete(string id);
    }
}