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
        private Data.Repositories.Repository<Data.Entity.SalesOrder> _OrderTable;

        public GoodsController(Data.DataContext dataContext) : base(dataContext)
        {
            _CatTable = new Data.Repositories.Repository<Data.Entity.Catalogue>(dataContext);
            _LocTable = new Data.Repositories.Repository<Data.Entity.Location>(dataContext);
            _AccTable = new Data.Repositories.Repository<Data.Entity.Account>(dataContext);
            _Supplier_Goods_StockTable = new Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock>(dataContext);
            _WarehouseTable = new Data.Repositories.Repository<Data.Entity.Warehouse>(dataContext);
            _GoodsTable = new Data.Repositories.Repository<Data.Entity.Goods>(dataContext);
            _OrderTable = new Data.Repositories.Repository<Data.Entity.SalesOrder>(dataContext);
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


            var supplierGoods = _Supplier_GoodsTable.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods>("_goodsId:"+entry.Id)
            ).FirstOrDefault(); // we assume there is only one suppli

            return new GoodsOutDto()
            {
                GoodsId = localizedEntry.Id,
                Catalogue = localizedCat.Name,
                GoodsName = localizedEntry.Name,
                GTINCode = localizedEntry.GTINCode,
                Price = localizedEntry.Price,
                GoodsSize = localizedEntry.Size,
                GoodsStatus = localizedEntry.Status,
                StockLevel = GetGoodsStockOutDtoAsync(user , supplierGoods , localizedEntry , lang).Result,
                Description = localizedEntry.Description

            }.MapToDto(); // convert the object to hashmap
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
                
                var supplierGoods = _Supplier_GoodsTable.GetBySQL(
                    Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods>("_goodsId:"+entry.Id)
                ).FirstOrDefault(); // we assume there is only one suppli
                

                returnList.Add(
                     new GoodsOutDto()
                    {
                        GoodsId = localizedEntry.Id,
                        GoodsName = localizedEntry.Name,
                        Catalogue = localizedCat.Name,
                        GTINCode = localizedEntry.GTINCode,
                        Price = localizedEntry.Price,
                        GoodsSize = localizedEntry.Size,
                        GoodsStatus = localizedEntry.Status,
                        StockLevel = GetGoodsStockOutDtoAsync(user , supplierGoods , localizedEntry , lang).Result,
                        Description = localizedEntry.Description

                    }.MapToDto() // convert the object to hashmap
                );
            }

            return returnList;
        }
        private async Task<GoodsStockOutDto> GetGoodsStockOutDtoAsync(Account user , Supplier_Goods supplierGoods , Goods entry, string lang = "en")
        {
            GoodsStockOutDto GoodsStockInfo = new GoodsStockOutDto();

                // try to get any instore stock
                try {
                
                    // get the location from the user account 
                    Location loc = user.Staff.store.Location;
                    // get the stock level in the store that user belongs to
                    List<Supplier_Goods_Stock> InstoreStock = _Supplier_Goods_StockTable.GetBySQL(
                        Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods_Stock>($"_locationId:{loc.Id};_supplierGoodsId:{supplierGoods.ID}")
                    );

                    int InStoreStockQty = 0 ;
                    foreach( var sg in InstoreStock )
                    {
                        InStoreStockQty += sg.Quantity;
                    }

                    GoodsStockStatus InstoreStockStatus = GetStockLevel(InstoreStock[0]);
                    GoodsStockInfo.InStoreStock = new GoodsStockOutDto.GoodsStoreStockOutDto
                    {
                        Status = InstoreStockStatus,
                        InStoreStock = InStoreStockQty,
                        _supplier_Goods_Stock_Id = InstoreStock[0].Id
                    };
                }catch (Exception e)
                {
                    GoodsStockInfo.InStoreStock = null;
                }

                // try to get any warehouse stock
                try{
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
                                _supplier_Goods_Stock_Id = Warehouse_SupplierGoods.Id,
                                Status = GetStockLevel(Warehouse_SupplierGoods)
                            }
                        );
                    }

                    GoodsStockInfo.WarehouseStock = WarehouseStock;

                }catch(Exception e)
                {
                    GoodsStockInfo.WarehouseStock = null;
                }

                return GoodsStockInfo;
        }

        public async Task<List<Hashtable>> GetAll(string UserName , string lang = "en")
        {
            try
            {
                return await ToOutDto(await _GoodsTable.GetAllAsync() , UserName , lang);
            }catch (ArgumentOutOfRangeException ex)
            {
                throw new BadArgException("Invalid Id");
            }
        }

        public async Task<List<Hashtable>> GetWithLimit(string UserName , int limit = 0 , uint offset = 0 , string lang = "en")
        {
            List<Goods> res = _GoodsTable.GetAll().AsReadOnly().ToList();
            if (offset + limit > res.Count())
                throw new BadArgException("The limit or offset is invalid");

            limit = limit > res.Count() ? res.Count() : limit;
            offset = offset > res.Count() ? (uint) res.Count() : offset; 
            res = res.GetRange((int)offset , (int)limit);

            try
            {
                return await ToOutDto(res , UserName , lang);
            }catch (ArgumentOutOfRangeException ex)
            {
                throw new BadArgException("Invalid Id");
            }
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
            try
            {
                return await ToOutDto(res , Username , lang);
            }catch (ArgumentOutOfRangeException ex)
            {
                throw new BadArgException("Invalid Id");
            }
        }


        public async Task AddImage(string id , byte[] image , string lang = "en")
        {
            var entry = await _GoodsTable.GetByIdAsync(id);
            entry.Photo = image;

            try
            {
                await _GoodsTable.UpdateAsync(entry);
            }catch(Exception e)
            {
                int size = image.Length;
                throw new BadArgException("The photo is too large: " + size + " bytes");
            }
        }

        public GoodsStockStatus GetStockLevel(Supplier_Goods_Stock sgs)
        {
            var stock = sgs.Quantity;
            var min = sgs.MinLimit;
            var reorder = sgs.ReorderLevel;
            var max = sgs.MaxLimit;

            // get the amount of the stock that is sold in this week
            // first get the order in this week
            var orders = _OrderTable.GetBySQL(
                "SELECT * FROM SalesOrder WHERE createdAt BETWEEN '" + DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") + "' AND '" + DateTime.Now.ToString("yyyy-MM-dd") + "'"
            );
            int sold = 0;
            foreach (var order in orders)
            {
                foreach (var orderItem in order.Items)
                {
                    if (orderItem._supplierGoodsStockId == sgs.Id)
                    {
                        sold += orderItem.Quantity;
                    }
                }
            }

            
            if (stock < min)
            {
                return GoodsStockStatus.OutOfStock;
            }
            else if (stock < reorder)
            {
                return GoodsStockStatus.LowStock;
            }
            else if (stock - sold < reorder)
            {
                return GoodsStockStatus.Danger;
            }
            else
            {
                return GoodsStockStatus.InStock;
            }

        }

    }
}