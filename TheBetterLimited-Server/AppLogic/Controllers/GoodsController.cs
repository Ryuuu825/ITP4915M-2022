using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;
namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class GoodsController : AppControllerBase<Data.Entity.Goods>
    {
        private Data.Repositories.Repository<Data.Entity.Catalogue> _CatTable;
        private Data.Repositories.Repository<Data.Entity.Location> _LocTable;
        private Data.Repositories.Repository<Data.Entity.Account> _AccTable;
        private Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock> _Supplier_Goods_StockTable;
        private Data.Repositories.Repository<Data.Entity.Warehouse> _WarehouseTable;
        public GoodsController(Data.DataContext dataContext) : base(dataContext) {
            _CatTable = new Data.Repositories.Repository<Data.Entity.Catalogue>(dataContext);
            _LocTable = new Data.Repositories.Repository<Data.Entity.Location>(dataContext);
            _AccTable = new Data.Repositories.Repository<Data.Entity.Account>(dataContext);
            _Supplier_Goods_StockTable = new Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock>(dataContext);
            _WarehouseTable = new Data.Repositories.Repository<Data.Entity.Warehouse>(dataContext);
        }

        public override Task<List<Hashtable>> GetAll(string lang="en")
        {
            return GetAll("admin");
        }

        public async Task<List<Hashtable>> GetAll(string UserName , string lang = "en")
        {
            Account user = _AccTable.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>("UserName:"+UserName)
            ).FirstOrDefault();
            List<Hashtable> returnList = new List<Hashtable>();
            List<Goods> entries = base.repository.GetAll();

            foreach( var entry in entries)
            {
                var localizedEntry = entry;
                localizedEntry = Helpers.Localizer.TryLocalize<Goods>(lang , entry);

                var localizedCat = Helpers.Localizer.TryLocalize<Catalogue>(lang , localizedEntry.Catalogue);
                Location loc = user.Staff.store.Location;
                int InstoreStock = _Supplier_Goods_StockTable.GetBySQL(
                    Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods_Stock>($"_locationId:{loc.Id}")
                ).FirstOrDefault().Quantity;

                List<GoodsStockOutDto.GoodsWarehouseStockOutDto> WarehouseStock = new List<GoodsStockOutDto.GoodsWarehouseStockOutDto>();
                var Warehouses = _WarehouseTable.GetAll();
                foreach(var warehouse in Warehouses)
                {
                    var Warehouse_SupplierGoods = _Supplier_Goods_StockTable.GetBySQL(
                        Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods_Stock>($"_locationId:{warehouse.Location.Id}")
                    ).FirstOrDefault();
                    WarehouseStock.Add(
                        new GoodsStockOutDto.GoodsWarehouseStockOutDto
                        {
                            Location = warehouse.Location.Loc,
                            Stock = Warehouse_SupplierGoods.Quantity
                        }
                    );
                }

                returnList.Add(
                     new GoodsOutDto()
                    {
                        GoodsId = localizedEntry.Id,
                        Catalogue = localizedCat.Name,
                        GTINCode = localizedEntry.GTINCode,
                        Price = localizedEntry.Price,
                        GoodsSize = localizedEntry.Size,
                        GoodsStatus = localizedEntry.Status,
                        StockLevel = new GoodsStockOutDto
                        {
                            InStoreStock = InstoreStock,
                            WarehouseStock = WarehouseStock
                        },
                        Description = localizedEntry.Description

                    }.MapToDto()
                );
            }

            return returnList;
        }
    }
}