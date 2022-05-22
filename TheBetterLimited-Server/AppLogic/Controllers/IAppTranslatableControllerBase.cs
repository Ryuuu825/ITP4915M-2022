namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public interface IAppTranslatableControllerBase<T>
    {
        public Task<List<T>> GetAll(string lang = "en");
        public Task<T> GetById(string id,string lang = "en");

        public Task<List<T>> GetByQueryString(string queryString,string lang = "en");
        public Task Add(T entity,string lang = "en");
        public Task Modify(string id, List<AppLogic.Models.UpdateObjectModel> content,string lang = "en");

        public Task Delete(string id);
    }

    public interface IAppTranslatableControllerBase<T,DTO>
    {
        public Task<List<T>> GetAll(string lang = "en");
        public Task<T> GetById(string id,string lang = "en");

        public Task<List<T>> GetByQueryString(string queryString,string lang = "en");
        public Task Add(T entity,string lang = "en");
        public Task Modify(string id, List<AppLogic.Models.UpdateObjectModel> content,string lang = "en");

        public Task Delete(string id);
    }
}