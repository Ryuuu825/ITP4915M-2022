
using System.Reflection;
using System.Runtime.Loader;
using DinkToPdf;
using DinkToPdf.Contracts;

namespace TheBetterLimited_Server.AppLogic.Controllers
{

    public class AppControllerBase<T> : IAppControllerBase<T>
        where T : class
    {
        protected readonly Data.DataContext db;
        protected readonly Data.Repositories.Repository<T> repository;
        protected readonly Type DtoType;
        protected readonly IConverter _convertor;

        public AppControllerBase(Data.DataContext dataContext , IConverter convertor)

        {
            db = dataContext;
            repository = new Data.Repositories.Repository<T>(dataContext);
            DtoType = typeof(T).ToDto();
            _convertor = convertor;
        }
        public async Task<List<string>> Index()
        {
            return DtoType.GetPropertiesToString();
        }

        public async Task<List<Hashtable>> GetAll()
        {
            return (await repository.GetAllAsync()).MapToDto<T>();
        }

        public async Task<List<T>> GetWithLimit(int limit)
        {
            var list = (await repository.GetAllAsync()).AsReadOnly().ToList();
            limit = limit > list.Count ? list.Count : limit;
            return list.GetRange(0, limit);
        }
        public async Task<Hashtable?> GetById(string id)
        {
            return (await repository.GetByIdAsync(id))?.MapToDto();
        }

        public async Task<List<Hashtable>> GetByQueryString(string queryString)
        {
            return (await repository.GetBySQLAsync(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<T>(queryString)
            )).MapToDto<T>();
        }
        public async Task Add(T entity)
        {
            var newObj = entity.CopyAsDto().CopyAs<T>();
            await repository.AddAsync(newObj);

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

        public async Task ModifyRange(string queryString , List<AppLogic.Models.UpdateObjectModel> content)
        {
            var potnetialList = await repository.GetBySQLAsync(queryString);

            for (int i = 0 ; i < potnetialList.Count ; i++)
            {   
                if (potnetialList[i] is not null)
                {
                    // A property or indexer may not be passed as an out or ref parameter [TheBetterLimited-Server]
                    // wrong: TheBetterLimited_Server.Helpers.Entity.EntityUpdater.Update<T>(ref potnetialList[i], content);
                    potnetialList[i] = TheBetterLimited_Server.Helpers.Entity.EntityUpdater.Update<T>(potnetialList[i] , content);
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

        public async Task<string> GetCSV(string queryString)
        {
            List<T> list = await GetRecords(queryString);
            

            return Helpers.File.CSVFactory.Create<T>(list);
        }

        public async Task<byte[]> GetPDF(string queryString)
        {
            List<T> list = await GetRecords(queryString);
            
            string htmlString = "<h1>Document</h1> <p>This is an HTML document which is converted to a pdf file.</p>";
            
            var doc = new HtmlToPdfDocument()
            { 
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Landscape,
                    PaperSize = PaperKind.A4Plus,
                },
                Objects = {
                    new ObjectSettings() {
                        PagesCount = true,
                        HtmlContent = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In consectetur mauris eget ultrices  iaculis. Ut                               odio viverra, molestie lectus nec, venenatis turpis.",
                        WebSettings = { DefaultEncoding = "utf-8" },
                        HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
                    }
                }
            };

            return _convertor.Convert(doc);


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
    
    internal class CustomAssemblyLoadContext : AssemblyLoadContext
    {
        public IntPtr LoadUnmanagedLibrary(string absolutePath)
        {
            return LoadUnmanagedDll(absolutePath);
        }
        protected override IntPtr LoadUnmanagedDll(String unmanagedDllName)
        {
            return LoadUnmanagedDllFromPath(unmanagedDllName);
        }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            throw new NotImplementedException();
        }
    }
}