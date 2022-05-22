namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public interface IAppControllerBase<T>
    {
        public Task<List<T>> GetAll();
        public Task<T> GetById(string id);

        public Task<List<T>> GetByQueryString(string queryString);
        public Task Add(T entity);
        public Task Modify(string id, List<AppLogic.Models.UpdateObjectModel> content);

        public Task Delete(string id);
    }
}