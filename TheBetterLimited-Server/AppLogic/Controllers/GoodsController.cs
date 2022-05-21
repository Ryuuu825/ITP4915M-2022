using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Helpers.Secure;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.AppLogic.Models;
using TheBetterLimited_Server.Helpers.LogHelper;
using TheBetterLimited_Server.Data.Dto;

namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class GoodsController
    {
        // GetAllGoods
        // GetGoodsById
        // AddGoods
        // ModifyGoods
        // DeleteGoods
        // SearchGoods

        private readonly DataContext db;
        private Data.Repositories.Repository<Data.Entity.Goods> goodsRepository;
        private Data.Repositories.Repository<Data.Entity.Catalogue> catalogueRepository;

        public GoodsController(DataContext dataContext)
        {
            db = dataContext;
            goodsRepository = new Data.Repositories.Repository<Data.Entity.Goods>(dataContext);
            catalogueRepository = new Data.Repositories.Repository<Data.Entity.Catalogue>(dataContext);
        }

        public async Task<List<Data.Entity.Goods>> GetAllGoods(string lang)
        {
            if (Helpers.Localizer.isLanguageSupported<Data.Entity.Goods>(lang))
            {
                
                var goods = await goodsRepository.GetAllAsync();
                for (var i = 0 ; i < goods.Count ; i++)
                {
                    goods[i] = Helpers.Localizer.TryLocalize<Data.Entity.Goods>(lang , goods[i] );
                }
                return goods;
            }
            else
            {
                throw new BadArgException("The language type not support.");
            } 
        }

        public async Task<Data.Entity.Goods?> GetGoodsById(string id)
        {
            var goods = await goodsRepository.GetByIdAsync(id);
            return goods;
        }

        public async Task<short?> GetGoodsPhotoAmt(string id)
        {
            var goods = await goodsRepository.GetByIdAsync(id);
            if (goods is null)
            {
                throw new BadArgException("The goods not found.");
            }
            return goods.PhotoAmt;
        }

        public async Task<Tuple<byte[]?, string>> GetGoodsPhoto(string id, int index)
        {
            string photoPath = AppDomain.CurrentDomain.BaseDirectory + $"resources/product/image/{id}";
            FileInfo[] dir = new DirectoryInfo(photoPath).GetFiles();
            foreach( var file in dir)
            {
                if (file.Name.Split('.')[0] == index.ToString())
                {
                    return Tuple.Create<byte[]?,string>(await File.ReadAllBytesAsync(file.FullName) , file.Name.Split('.')[1] );
                }
            }
            throw new FileNotExistException("The photo not exist." , HttpStatusCode.NotFound);
        }

        public async Task AddGoods(string language , Data.Dto.GoodsDto goods)
        {
            var cat = await catalogueRepository.GetByIdAsync(goods._catalogueId);
            if (cat is null)        
            {
                throw new BadForeignKeyException("The catalogue not found.");
            }
            var newObj = goods.CopyAs<Data.Entity.Goods>();

            foreach (var item in newObj.GetType().GetProperties())
            {
                if (System.Attribute.IsDefined(item, typeof(AppLogic.Attribute.TranslatableAttribute)))
                {
                    string id =  "T" + Helpers.Secure.RandomId.GetID(4);
                    Helpers.Localizer.UpdateWord<Data.Entity.Goods>(
                        language , 
                        id,
                        item.GetValue(newObj).ToString()
                    );
                    // replace the translation with its tranlsation id
                    item.SetValue(newObj, "@$" + id);
                }
            }

            await goodsRepository.AddAsync(newObj);
            await db.SaveChangesAsync();
        }

        public async Task ModifyGoods(string id , string language , List<AppLogic.Models.UpdateObjectModel> content)
        {
            var potentialGoods = await goodsRepository.GetByIdAsync(id);
            if (potentialGoods is null)
            {
                throw new BadArgException("The goods not found.");
            }

            Helpers.Entity.EntityUpdater.Update<Data.Entity.Goods>(ref potentialGoods , content , language);
            await goodsRepository.UpdateAsync(potentialGoods);
            await db.SaveChangesAsync();
        }

        public async Task DeleteGoods(string id)
        {
            var potentialGoods = await goodsRepository.GetByIdAsync(id);
            await goodsRepository.DeleteAsync(potentialGoods);
            await db.SaveChangesAsync();
        }

        public async Task<List<Data.Entity.Goods>> SearchGoods(string language , string queryString)
        {
            var goods = await goodsRepository.GetBySQLAsync(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Data.Entity.Goods>(queryString)
            );
            for (var i = 0 ; i < goods.Count ; i++)
            {
                goods[i] = Helpers.Localizer.TryLocalize<Data.Entity.Goods>(language , goods[i] );
            }
            return goods;
        }

    }
}