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

        public GoodsController(DataContext dataContext)
        {
            db = dataContext;
            goodsRepository = new Data.Repositories.Repository<Data.Entity.Goods>(dataContext);
        }

        public async Task<List<Data.Entity.Goods>> GetAllGoods()
        {
            var goods = await goodsRepository.GetAllAsync();
            for (var i = 0 ; i < goods.Count ; i++)
            {
                goods[i] = Helpers.Localizer.TryLocalize<Data.Entity.Goods>("zh" , goods[i] );
            }

            return goods;

        }

    }
}