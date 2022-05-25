namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class AppTranslatableControllerBase<T> : IAppTranslatableControllerBase<T>
        where T : class
    {
        protected readonly Data.DataContext db;
        protected Data.Repositories.Repository<T> repository;
        protected readonly Type DtoType;

        public AppTranslatableControllerBase(Data.DataContext dataContext)
        {
            db = dataContext;
            repository = new Data.Repositories.Repository<T>(dataContext);
            DtoType = typeof(T).ToDto();
        }

        public async Task<List<string>> Index()
        {
            return DtoType.GetPropertiesToString();
        }

        public async Task<List<T>> GetAll(string lang = "en")
        {
            if (Helpers.Localizer.isLanguageSupported<T>(lang))
            {
                var list = await repository.GetAllAsync();
                for (var i = 0 ; i < list.Count ; i++)
                {
                    list[i] = Helpers.Localizer.TryLocalize<T>(lang , list[i] );
                }
                return list;
            }
            else
            {
                throw new BadArgException("The language type not support.");
            }
        }

        public async Task<List<T>> GetWithLimit(int limit, string lang = "en")
        {
            var list = (await repository.GetAllAsync()).AsReadOnly().ToList();
            limit = limit > list.Count ? list.Count : limit;
            list = list.GetRange(0, limit);
            for (var i = 0 ; i < list.Count ; i++)
            {
                list[i] = Helpers.Localizer.TryLocalize<T>(lang , list[i] );
            }
            return list;

        }

        public async Task<T> GetById(string id,string lang = "en")
        {
            var goods = await repository.GetByIdAsync(id);
            return Helpers.Localizer.TryLocalize<T>(lang , goods);
        }

        public async Task<List<T>> GetByQueryString(string queryString,string lang = "en")
        {
            var goods = await repository.GetBySQLAsync(queryString);
            for (var i = 0 ; i < goods.Count ; i++)
            {
                goods[i] = Helpers.Localizer.TryLocalize<T>(lang , goods[i] );
            }
            return goods;
        }
        public async Task Add(T entity,string lang = "en")
        {
            var newObj = entity.CopyAsDto().CopyAs<T>();

            foreach (var item in newObj.GetType().GetProperties())
            {
                if (System.Attribute.IsDefined(item, typeof(AppLogic.Attribute.TranslatableAttribute)))
                {
                    string id =  "T" + Helpers.Secure.RandomId.GetID(4);
                    Helpers.Localizer.UpdateWord<Data.Entity.Goods>(
                        lang , 
                        id,
                        item.GetValue(newObj).ToString()
                    );
                    // replace the translation with its tranlsation id
                    item.SetValue(newObj, "@$" + id);
                }
            }
            await repository.AddAsync(newObj);
            await db.SaveChangesAsync();
        }
        public async Task Modify(string id, List<AppLogic.Models.UpdateObjectModel> content,string lang = "en")
        {
            var potnetialObj = await repository.GetByIdAsync(id);
            if (potnetialObj is null)
            {
                throw new BadArgException($"The {typeof(T).Name} not found.");
            }
            Helpers.Entity.EntityUpdater.Update<T>(ref potnetialObj, content);
            await repository.UpdateAsync(potnetialObj);
            await db.SaveChangesAsync();
        }

                public async Task ModifyRange(string queryString , List<AppLogic.Models.UpdateObjectModel> content , string Language = "en")
        {
            var potnetialList = await repository.GetBySQLAsync(queryString);

            for (int i = 0 ; i < potnetialList.Count ; i++)
            {   
                if (potnetialList[i] is not null)
                {
                    // A property or indexer may not be passed as an out or ref parameter [TheBetterLimited-Server]
                    // wrong: TheBetterLimited_Server.Helpers.Entity.EntityUpdater.Update<T>(ref potnetialList[i], content);
                    potnetialList[i] = TheBetterLimited_Server.Helpers.Entity.EntityUpdater.Update<T>(potnetialList[i] , content , Language);
                    await repository.UpdateAsync(potnetialList[i]);
                }
            }
            await db.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var potnetialObj = await repository.GetByIdAsync(id);
            await repository.DeleteAsync(potnetialObj);
            await db.SaveChangesAsync();
        }

        public async Task<string> GetCSV(string lang , string queryString)
        {
            List<T> list;
            if (queryString is not null)
            {
                list = await repository.GetBySQLAsync(
                    Helpers.Sql.QueryStringBuilder.GetSqlStatement<T>(queryString)
                );
            }
            else 
            {
                list = await repository.GetAllAsync();
            }
            
            for(int i = 0 ; i < list.Count ; i++)
            {
                list[i] = Helpers.Localizer.TryLocalize<T>(lang , list[i]);
            }

            return Helpers.File.CSVFactory.Create<T>(list);

            
        }
    }
}