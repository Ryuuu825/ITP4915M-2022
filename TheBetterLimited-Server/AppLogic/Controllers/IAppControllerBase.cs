namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public interface IAppControllerBase<T>
    {
        public Task<List<string>> Index();
        public Task<List<Hashtable>> GetAll();
        public Task<Hashtable> GetById(string id);

        public Task<List<Hashtable>> GetByQueryString(string queryString);
        public Task Add(T entity);
        public Task Modify(string id, List<AppLogic.Models.UpdateObjectModel> content);

        public Task Delete(string id);

    }
}