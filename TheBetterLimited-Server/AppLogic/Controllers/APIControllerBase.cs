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

        public async Task<List<string>> Index()
        {
            return DtoType.GetPropertiesToString();
        }


        public async Task<List<Hashtable>> GetAll(string lang = "en")
        {

            var list = await repository.GetAllAsync();
            for (var i = 0 ; i < list.Count ; i++)
            {
                list[i] = Helpers.Localizer.TryLocalize<T>(lang , list[i] );
            }
            return list.MapToDto<T>();

        }


        public async Task<string> GetCSV(string queryString)
        {
            List<T> list = await GetRecords(queryString);
            

            return Helpers.File.CSVFactory.Create<T>(list);
        }

        public async Task<byte[]> GetPDF(string queryString , string lang = "en")
        {
            var list = Helpers.Localizer.TryLocalize(lang, (await GetRecords(queryString)));

            // get headers from the attributes of the item with type T
            StringBuilder header = new StringBuilder();
            var Instance = Activator.CreateInstance<T>();
            foreach(var item in Instance.GetType().GetProperties())
            {
                // ignore the properties that are not mapped to dto and is a class or collection
                if  (    
                        System.Attribute.IsDefined(item , typeof(AppLogic.Attribute.NotMapToDtoAttribute)) ||
                        item.PropertyType is ICollection || 
                        item.GetAccessors()[0].IsVirtual
                    )
                    continue;

                header.Append($"<th scope=\"col\">{item.Name}</th>");
            }

            // create the html table
            /**
                <tr>
                    <th scope="row">1</th>
                    <td>Mark</td>
                    <td>Otto</td>
                    <td>@mdo</td>
                </tr>
             */
            StringBuilder table = new StringBuilder();
            foreach(var item in list)
            {
                table.Append($"<tr>");
                foreach(var prop in item.GetType().GetProperties())
                {
                    if (    
                        System.Attribute.IsDefined(prop , typeof(AppLogic.Attribute.NotMapToDtoAttribute)) ||
                        prop.PropertyType is ICollection || 
                        prop.GetAccessors()[0].IsVirtual // a foreign key object
                    )
                        continue;
                    table.Append($"<td>{prop.GetValue(item)}</td>");
                }
                table.Append($"</tr>");
            }

            List<UpdateObjectModel> content = new List<UpdateObjectModel>
            {
                new UpdateObjectModel
                {
                    Attribute = "record",
                    Value = typeof(T).Name
                },
                new UpdateObjectModel
                {
                    Attribute = "header",
                    Value = header.ToString()
                },
                new UpdateObjectModel
                {
                    Attribute = "body",
                    Value = table.ToString()
                }
            };

            string temp = Helpers.File.DynamicFile.UpdatePlaceHolder("template/Records.html" , content);

            // create a html file for wkhtmltopdf to convert
            string htmlFilePath = AppDomain.CurrentDomain.BaseDirectory+ "var/tmp/record.html";
            using (FileStream fs = new FileStream(htmlFilePath, FileMode.OpenOrCreate))
            {
                await fs.WriteAsync(Encoding.UTF8.GetBytes(temp));
            }
            return Helpers.File.PDFFactory.Instance.Create(htmlFilePath);
        }
        
        public async Task<List<Hashtable>> GetWithLimit(int limit, string lang = "en")
        {
            var list = (await repository.GetAllAsync()).AsReadOnly().ToList();
            limit = limit > list.Count ? list.Count : limit;
            list = list.GetRange(0, limit);
            for (var i = 0 ; i < list.Count ; i++)
            {
                list[i] = Helpers.Localizer.TryLocalize<T>(lang , list[i] );
            }
            return list.MapToDto();

        }

        public async Task<Hashtable> GetById(string id,string lang = "en")
        {
            var goods = await repository.GetByIdAsync(id);
            return Helpers.Localizer.TryLocalize<T>(lang , goods).MapToDto();
        }

        public async Task<List<Hashtable>> GetByQueryString(string queryString,string lang = "en")
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

        public unsafe async void ModifyRange(string queryString , List<AppLogic.Models.UpdateObjectModel> content , string Language = "en")
        {
            var potnetialList = repository.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<T>(queryString)
            );

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

        public async Task<List<T>> GetRecords(string queryString)
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