using TheBetterLimited_Server.AppLogic.Models;

namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class AppControllerBase<T> : IAppTranslatableControllerBase<T>
        where T : class
    {
        protected readonly Data.DataContext db;
        protected Data.Repositories.Repository<T> repository;
        protected readonly Type DtoType;

        public AppControllerBase(Data.DataContext dataContext)
        {
            db = dataContext;
            repository = new Data.Repositories.Repository<T>(dataContext);
            DtoType = typeof(T).ToDto();
        }

        public AppControllerBase(Data.DataContext dataContext , string prefix)
        {
            db = dataContext;
            repository = new Data.Repositories.Repository<T>(dataContext);
            DtoType = typeof(T).ToDto();
        }

        public async Task<List<string>> Index()
        {
            return DtoType.GetPropertiesToString();
        }


        public virtual async Task<List<Hashtable>> GetAll(string lang = "en")
        {

            var list = await repository.GetAllAsync();
            for (var i = 0 ; i < list.Count ; i++)
            {
                list[i] = Helpers.Localizer.TryLocalize<T>(lang , list[i] );
            }
            return list.MapToDto<T>();

        }

        public virtual async Task<string> GetCSV(string queryString)
        {
            List<T> list = await GetRecords(queryString);
            

            return Helpers.File.CSVFactory.Create<T>(list);
        }

        public virtual async Task<byte[]> GetPDF(string queryString , string lang = "en")
        {
            var list = await GetRecords(queryString);
            for (var i = 0 ; i < list.Count ; i++)
            {
                list[i] = Helpers.Localizer.TryLocalize<T>(lang , list[i] );
            }

            return await Helpers.File.PDFFactory.Instance.Create(list);
        }
        
        public virtual async Task<List<Hashtable>> GetWithLimit(int limit, uint offset = 0 ,string lang = "en")
        {
            var list = (await repository.GetAllAsync()).AsReadOnly().ToList();
            limit = limit > list.Count ? list.Count : limit;
            offset = offset > list.Count ? (uint) list.Count : offset;
            list = list.GetRange((int)offset, limit);
            for (var i = 0 ; i < list.Count ; i++)
            {
                list[i] = Helpers.Localizer.TryLocalize<T>(lang , list[i] );
            }
            return list.MapToDto();
        }

        public virtual async Task<Hashtable> GetById(string id,string lang = "en")
        {
            var goods = await repository.GetByIdAsync(id);
            return Helpers.Localizer.TryLocalize<T>(lang , goods).MapToDto();
        }

        public virtual async Task<List<Hashtable>> GetByQueryString(string queryString,string lang = "en")
        {
            var goods = await repository.GetBySQLAsync(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<T>(queryString)
            );
            for (var i = 0 ; i < goods.Count ; i++)
            {
                goods[i] = Helpers.Localizer.TryLocalize<T>(lang , goods[i] );
            }
            return goods.MapToDto();
        }
        public virtual async Task Add(T entity,string lang = "en")
        {
            var newObj = entity.CopyAsDto().CopyAs<T>();
            newObj  .GetType()
                    .GetProperties()
                    .Where(x => x.Name.ToLower() == "id")
                    .FirstOrDefault()
                    .SetValue(newObj , Helpers.Sql.PrimaryKeyGenerator.Get<T>(db));

                

            // update the word in the object
            foreach (var item in newObj.GetType().GetProperties())
            {
                if (System.Attribute.IsDefined(item, typeof(AppLogic.Attribute.TranslatableAttribute)))
                {
                    string id =  "T" + Helpers.Secure.RandomId.GetID(9);
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
        public virtual async Task Modify(string id, List<AppLogic.Models.UpdateObjectModel> content,string lang = "en")
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

        public virtual void ModifyRange(string queryString , List<AppLogic.Models.UpdateObjectModel> content , string Language = "en")
        {
            var potnetialList = repository.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<T>(queryString)
            );

            if (potnetialList.Count == 0)
            {
                throw new BadArgException($"The query return no result.");
            }
            else
            {
                for (int i = 0 ; i < potnetialList.Count ; i++)
                {
                    var potnetial = potnetialList[i];
                    if (potnetial is not null)
                    {
                        // pass a reference to the object to be updated
                        Helpers.Entity.EntityUpdater.Update( ref potnetial, content);
                        repository.Update(potnetial);
                    }
                }
                db.SaveChanges();
            }

            
        }

        public virtual async Task Delete(string id)
        {
            var potnetialObj = await repository.GetByIdAsync(id);
            await repository.DeleteAsync(potnetialObj);
            await db.SaveChangesAsync();
        }

        public virtual async Task<string> GetCSV(string lang , string queryString)
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

        public virtual async Task<List<T>> GetRecords(string queryString)
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
            return list;
        }
    }
}