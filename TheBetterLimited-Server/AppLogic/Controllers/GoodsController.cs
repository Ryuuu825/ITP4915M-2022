using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;
namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class GoodsController : AppControllerBase<Goods>
    {
        private Data.Repositories.Repository<Data.Entity.Catalogue> _CatTable;
        private Data.Repositories.Repository<Data.Entity.Goods> _GoodsTable;
        private Data.Repositories.Repository<Data.Entity.Location> _LocTable;
        private Data.Repositories.Repository<Data.Entity.Account> _AccTable;
        private Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock> _Supplier_Goods_StockTable;
        private Data.Repositories.Repository<Data.Entity.Supplier_Goods> _Supplier_GoodsTable;
        private Data.Repositories.Repository<Data.Entity.Warehouse> _WarehouseTable;
        public GoodsController(Data.DataContext dataContext) : base(dataContext)
        {
            _CatTable = new Data.Repositories.Repository<Data.Entity.Catalogue>(dataContext);
            _LocTable = new Data.Repositories.Repository<Data.Entity.Location>(dataContext);
            _AccTable = new Data.Repositories.Repository<Data.Entity.Account>(dataContext);
            _Supplier_Goods_StockTable = new Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock>(dataContext);
            _WarehouseTable = new Data.Repositories.Repository<Data.Entity.Warehouse>(dataContext);
            _GoodsTable = new Data.Repositories.Repository<Data.Entity.Goods>(dataContext);
            _Supplier_GoodsTable = new Data.Repositories.Repository<Data.Entity.Supplier_Goods>(dataContext);
        }
        
        public Hashtable ToOutDto(Goods entry, string UserName , string lang = "en")
        {
            // get the user account to trace the store user at
             Account user = _AccTable.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>("UserName:"+UserName)
            ).FirstOrDefault();

            // localized the goods
            var localizedEntry = entry;
            localizedEntry = Helpers.Localizer.TryLocalize<Goods>(lang , entry);

            // localized the cataloge
            var localizedCat = Helpers.Localizer.TryLocalize<Catalogue>(lang , localizedEntry.Catalogue);
            
            // get all the supplier goods from the goods
            var supplierGoods = _Supplier_GoodsTable.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods>("_goodsId:"+entry.Id)
            ).FirstOrDefault(); // we assume there is only one supplier goods per goods in this stage
            // get the location from the user account 
            Location loc = user.Staff.store.Location;

            // get the stock level in the store that user belongs to
            Supplier_Goods_Stock InstoreStock = _Supplier_Goods_StockTable.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods_Stock>($"_locationId:{loc.Id};_supplierGoodsId:{supplierGoods.ID}")
            ).FirstOrDefault();
            int InStoreStockQty = InstoreStock.Quantity;
            GoodsStockStatus InstoreStockStatus = InStoreStockQty < InstoreStock.MinLimit ? GoodsStockStatus.OutOfStock : InStoreStockQty < InstoreStock.ReorderLevel ? GoodsStockStatus.LowStock : GoodsStockStatus.InStock;
            // get all warehouse to return the supplier_goods stock level in the warehouse
            List<GoodsStockOutDto.GoodsWarehouseStockOutDto> WarehouseStock = new List<GoodsStockOutDto.GoodsWarehouseStockOutDto>();
            var Warehouses = _WarehouseTable.GetAll();

            foreach(var warehouse in Warehouses)
            {
                var Warehouse_SupplierGoods = _Supplier_Goods_StockTable.GetBySQL(
                    Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods_Stock>($"_locationId:{warehouse.Location.Id};_supplierGoodsId:{supplierGoods.ID}")
                ).FirstOrDefault();
                WarehouseStock.Add(
                    new GoodsStockOutDto.GoodsWarehouseStockOutDto
                    {
                        Location = warehouse.Location.Loc,
                        Stock = Warehouse_SupplierGoods.Quantity,
                        Status = Warehouse_SupplierGoods.Quantity < Warehouse_SupplierGoods.MinLimit ? GoodsStockStatus.OutOfStock : Warehouse_SupplierGoods.Quantity < Warehouse_SupplierGoods.ReorderLevel ? GoodsStockStatus.LowStock : GoodsStockStatus.InStock
                    }
                );
            }

            return new GoodsOutDto()
                {
                    GoodsId = localizedEntry.Id,
                    GoodsName = localizedEntry.Name,
                    Catalogue = localizedCat.Name,
                    GTINCode = localizedEntry.GTINCode,
                    Price = localizedEntry.Price,
                    GoodsSize = localizedEntry.Size,
                    GoodsStatus = localizedEntry.Status,
                    StockLevel = new GoodsStockOutDto
                    {
                        WarehouseStock = WarehouseStock,
                        InStoreStock = new GoodsStockOutDto.GoodsStoreStockOutDto
                        {
                            InStoreStock = InStoreStockQty,
                            Status = InstoreStockStatus 
                        }

                    },
                    Description = localizedEntry.Description,
                    Photo = localizedEntry.Photo 

                }.MapToDto();
        }

        public async Task<List<Hashtable>> ToOutDto(List<Goods> entries , string UserName, string lang = "en")
        {
            // get the user account to trace the store user at
             Account user = _AccTable.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>("UserName:"+UserName)
            ).FirstOrDefault();

            // the res
            // return a list of GoodsOutDto
            List<Hashtable> returnList = new List<Hashtable>();

            // iterate through the products entry
            foreach( var entry in entries)
            {
                // localized the goods
                var localizedEntry = entry;
                localizedEntry = Helpers.Localizer.TryLocalize<Goods>(lang , entry);

                // localized the cataloge
                var localizedCat = Helpers.Localizer.TryLocalize<Catalogue>(lang , localizedEntry.Catalogue);
                
                // get the location from the user account 
                Location loc = user.Staff.store.Location;
                // get the stock level in the store that user belongs to
                List<Supplier_Goods_Stock> InstoreStock = _Supplier_Goods_StockTable.GetBySQL(
                    Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods_Stock>($"_locationId:{loc.Id}")
                );

                int InStoreStockQty = 0 ;
                foreach( var sg in InstoreStock )
                {
                    InStoreStockQty += sg.Quantity;
                }

                GoodsStockStatus InstoreStockStatus = InStoreStockQty < InstoreStock[0].MinLimit ? GoodsStockStatus.OutOfStock : InStoreStockQty < InstoreStock[0].ReorderLevel ? GoodsStockStatus.LowStock : GoodsStockStatus.InStock;

                // get all warehouse to return the supplier_goods stock level in the warehouse
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
                            InStoreStock = new GoodsStockOutDto.GoodsStoreStockOutDto
                            {
                                Status = InstoreStockStatus,
                                InStoreStock = InStoreStockQty
                            },
                            WarehouseStock = WarehouseStock
                        },
                        Description = localizedEntry.Description

                    }.MapToDto() // convert the object to hashmap
                );
            }

            return returnList;
        }

        public async Task<List<Hashtable>> GetAll(string UserName , string lang = "en")
        {
           return await ToOutDto(await _GoodsTable.GetAllAsync() , UserName , lang);
        }

        public async Task<List<Hashtable>> GetWithLimit(string UserName , int limit = 0 , uint offset = 0 , string lang = "en")
        {
            List<Goods> res = _GoodsTable.GetAll().AsReadOnly().ToList();
            if (offset + limit > res.Count())
                throw new BadArgException("The limit or offset is invalid");

            limit = limit > res.Count() ? res.Count() : limit;
            offset = offset > res.Count() ? (uint) res.Count() : offset; 
            res = res.GetRange((int)offset , (int)limit);

            return await ToOutDto(res , UserName , lang);
        }

        public async Task<Hashtable> GetById(string UserName , string id , string lang = "en")
        {
            Goods res = await _GoodsTable.GetByIdAsync(id);
            return ToOutDto( res , UserName , lang);
        }

        public async Task<List<Hashtable>> GetByQueruString(string Username , string queryString , string lang = "en")
        {
            List<Goods> res = await _GoodsTable.GetBySQLAsync(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Goods>(queryString)
            );
            return await ToOutDto(res , Username , lang);
        }

    }
}