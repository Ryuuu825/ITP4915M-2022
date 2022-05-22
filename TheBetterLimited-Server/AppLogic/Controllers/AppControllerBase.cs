namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class AppControllerBase<T> : IAppControllerBase<T>
        where T : class
    {
        protected readonly Data.DataContext db;
        protected readonly Data.Repositories.Repository<T> repository;

        public AppControllerBase(Data.DataContext dataContext)
        {
            db = dataContext;
            repository = new Data.Repositories.Repository<T>(dataContext);
        }

        public async Task<List<T>> GetAll()
        {
            return await repository.GetAllAsync();
        }

        public async Task<List<T>> GetWithLimit(int limit)
        {
            var list = (await repository.GetAllAsync()).AsReadOnly().ToList();
            limit = limit > list.Count ? list.Count : limit;
            return list.GetRange(0, limit);
        }
        public async Task<T> GetById(string id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task<List<T>> GetByQueryString(string queryString)
        {
            return await repository.GetBySQLAsync(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<T>(queryString)
            );
        }
        public async Task Add(T entity)
        {
            await repository.AddAsync(entity);
            await db.SaveChangesAsync();
        }
        public async Task Modify(string id, List<AppLogic.Models.UpdateObjectModel> content)
        {
            var potnetialObj = await repository.GetByIdAsync(id);
            if (potnetialObj is null)
            {
                throw new BadArgException($"The {typeof(T).Name} not found.");
            }

            TheBetterLimited_Server.Helpers.Entity.EntityUpdater.Update<T>(ref potnetialObj, content);
            await repository.UpdateAsync(potnetialObj);
            await db.SaveChangesAsync();
        }
        public async Task Delete(string id)
        {
            var potnetialObj = await repository.GetByIdAsync(id);
            await repository.DeleteAsync(potnetialObj);
            await db.SaveChangesAsync();
        }
    }
}