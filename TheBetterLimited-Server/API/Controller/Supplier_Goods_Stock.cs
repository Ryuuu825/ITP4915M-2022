using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.AppLogic.Models;
using Microsoft.AspNetCore.Authorization;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/inventory/sgs")]
    public class Inventory_Supplier_Goods_Stock : ControllerBase
    {
        private readonly Data.Repositories.Repository<Data.Entity.Goods> repository;
        private readonly Data.Repositories.Repository<Data.Entity.Supplier_Goods> sg;
        private readonly Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock> sgs;
        private readonly Data.Repositories.Repository<Data.Entity.Store> StoreTable;
        private readonly Data.Repositories.Repository<Data.Entity.Warehouse> WarehouseTable;
        private readonly Data.Repositories.Repository<Data.Entity.Account> AccTable;
        private readonly Data.Repositories.Repository<Data.Entity.PurchaseOrder> PurchaseOrderTable;
         private readonly Data.Repositories.Repository<Data.Entity.PurchaseOrder_Supplier_Goods> PurchaseOrder_SupplierGoods_Table;
        private readonly Data.Repositories.Repository<Data.Entity.RestockRequest> RestockRequestTable;
         private readonly Data.Repositories.UserInfoRepository userInfo;
        private readonly DataContext db;

        private readonly AppLogic.Controllers.GoodsController goodsController;
        public Inventory_Supplier_Goods_Stock(DataContext db)
        {
            repository = new Data.Repositories.Repository<Data.Entity.Goods>(db);
            sg = new Data.Repositories.Repository<Data.Entity.Supplier_Goods>(db);
            sgs = new Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock>(db);
            StoreTable = new Data.Repositories.Repository<Data.Entity.Store>(db);
            AccTable = new Data.Repositories.Repository<Data.Entity.Account>(db);
            WarehouseTable = new Data.Repositories.Repository<Data.Entity.Warehouse>(db);
            PurchaseOrderTable = new Data.Repositories.Repository<Data.Entity.PurchaseOrder>(db);
            RestockRequestTable = new Data.Repositories.Repository<Data.Entity.RestockRequest>(db);
            PurchaseOrder_SupplierGoods_Table = new Data.Repositories.Repository<Data.Entity.PurchaseOrder_Supplier_Goods>(db);
            goodsController = new AppLogic.Controllers.GoodsController(db);
            userInfo = new Data.Repositories.UserInfoRepository(db);
            this.db = db;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var entry = sgs.GetAll().Where(s => s.Id == id).FirstOrDefault();
            if (entry == null)
            {
                return NotFound();
            }
            entry.isSoftDeleted = true;
            sgs.Update(entry);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(string id , [FromHeader] string Language) // supplier goods stock id
        {
            try 
            {
                var p = sgs.GetAll().Where(s => s.Id == id).FirstOrDefault();
                Hashtable res = p.MapToDto();
                var goods = Helpers.Localizer.TryLocalize<Data.Entity.Goods>(Language , p.Supplier_Goods.Goods);
                res.Add("GoodsName" , goods.Name);
                return Ok(res);
            }catch(Exception e)
            {
                return StatusCode(500 , e.Message);
            }

        }

        

        [HttpGet]
        public IActionResult GetAll( [FromQuery] string? location , [FromHeader] string Language = "en")
        {
            var p = repository.GetAll();

            
            List<Data.Entity.Goods> goods = new List<Data.Entity.Goods>();
            foreach( var g in p)
            {
                goods.Add(Helpers.Localizer.TryLocalize<Data.Entity.Goods>(Language , g));
            }

            var store = StoreTable.GetAll();
            
            var res = sgs.GetAll();

            if (location != null)
            {
                res = res.ToList().Where(s => s._locationId == location).ToList();
            }
            List<Hashtable> result = new List<Hashtable>();
            foreach (var r in res) 
            {
                Hashtable h = new Hashtable();
                h.Add("Id" , r.Id);
                h.Add("GoodsName" , goods.Find(x => x.Id == r.Supplier_Goods.Goods.Id).Name);
                h.Add("_locationId" , r._locationId);
                h.Add("LocName" , r.Location.Name) ;
                h.Add("_supplierGoodsId" , r._supplierGoodsId);
                h.Add("Quantity" , r.Quantity);
                h.Add("MaxLimit" , r.MaxLimit);
                h.Add("MinLimit" , r.MinLimit);
                h.Add("ReorderLevel" , r.ReorderLevel);
                h.Add("Status" , goodsController.GetStockLevel(r).ToString());
                h.Add("isDeleted" , r.isSoftDeleted);
                result.Add(h);
            }

            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id , [FromBody] List<UpdateObjectModel> content)
        {
            var entry = sgs.GetAll().Where(s => s.Id == id).FirstOrDefault();
            if (entry == null)
            {
                return NotFound();
            }
            Helpers.Entity.EntityUpdater.Update( ref entry, content);
            sgs.Update(entry);
            return Ok();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] InDto content)
        {
            Data.Entity.Staff staff = AccTable.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Data.Entity.Account>($"UserName:{User.Identity.Name}")
                ).FirstOrDefault().Staff;
            if (staff == null)
            {
                return StatusCode(500 , "Staff not found");
            }

            // try to get the location from the store or warehouse
            string LocationId = "";
            try 
            {   
                LocationId = StoreTable.GetAll().Where(s => s.ID == staff.store.ID).FirstOrDefault()._locationID;
            }catch(Exception e)
            {
                // return StatusCode(500 , e.Message);
            }
            try 
            {
                LocationId = WarehouseTable.GetAll().Where(s => s.ID == staff.warehouse.ID).FirstOrDefault()._locationID;
            }catch(Exception e)
            {
                // return StatusCode(500 , e.Message);
            }

            if (LocationId == "")
            {
                return StatusCode(500 , "Location not found");
            }

            // get the supplier goods id
            ConsoleLogger.Debug(content.GoodsId);
            var supplierGoods = sg.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods>($"_goodsId:{content.GoodsId}")
                ).FirstOrDefault();

            if (supplierGoods == null)
            {
                return StatusCode(500 , "Supplier Goods not found");
            }


            var entry = new Data.Entity.Supplier_Goods_Stock()
            {
                Id = Helpers.Sql.PrimaryKeyGenerator.Get<Data.Entity.Supplier_Goods_Stock>(db),
                _locationId = LocationId,
                _supplierGoodsId = supplierGoods.ID,
                Quantity = content.Quantity,
                MaxLimit = content.MaxLimit,
                MinLimit = content.MinLimit,
                ReorderLevel = content.ReorderLevel,
                isSoftDeleted = false
            };
            try
            {
                sgs.Add(entry);
                return Ok();

            }catch(Exception e)
            {
                return StatusCode(500 , "The stock already exit");
            }
           
        }

        [HttpPut("bound")]
        [Authorize]
        public IActionResult InBoundOutBound([FromBody] InOutBoundDto dto)
        {   
            var staff = userInfo.GetStaffFromUserName(User.Identity.Name);
            string location = String.Empty;
            if (AppLogic.Constraint.AdminDepartmentId.Contains(staff._departmentId)) 
            { 
                if (dto._purchaseOrderId != "")
                {
                    var po = PurchaseOrderTable.GetById(dto._purchaseOrderId);
                    location = po.Warehouse.Location.Id;
                }
                else
                {
                    var rr = RestockRequestTable.GetById(dto._restockRequestId);
                    location = rr.Creater.store is null ? rr.Creater.warehouse._locationID : rr.Creater.store._locationID;
                }
            }
            else if (staff.warehouse is null && staff.store is not null)
            {
                location = staff.store._locationID;
            }
            else if (staff.store is null && staff.warehouse is not null)
            {
                location = staff.warehouse._locationID;
            } 
            else 
            {
                return StatusCode(401 , "unauthorized");
            }

            if (location.Equals(String.Empty))
                return StatusCode(404, "No location is found");


            try 
            {
                foreach(var item in dto.items)
                {
                    // update the stock according to the user location
                    Data.Entity.Supplier_Goods_Stock stock = repository.GetBySQL(
                            $"SELECT * FROM `Goods` WHERE `Id` = '{item._goodsId}'"
                    ).FirstOrDefault()
                     .Supplier_Goods.FirstOrDefault()
                     .Supplier_Goods_Stocks.Where(x => x._locationId == location)
                     .FirstOrDefault();
                    if (stock is null) throw new BadArgException("Not record found");
                    if (stock.isSoftDeleted) throw new BadArgException("The stock records is soft deleted");

                    stock.Quantity += (int) item.qty;
                    sgs.Update(stock);

                    if (dto._purchaseOrderId != "") 
                    {
                        // warehouse stock inbound
                        var po = PurchaseOrderTable.GetById(dto._purchaseOrderId);
                        if (po is null) throw new BadArgException("Purchase Order not found");

                        po.Status = Data.Entity.PurchaseOrderStatus.Inbound;
                        PurchaseOrderTable.Update(po);
                        ConsoleLogger.Debug(po.Debug());

                        var poItem = po.Items.Where(x => x._supplierGoodsId == stock._supplierGoodsId).FirstOrDefault();
                        poItem.ReceivedQuantity = (uint) item.qty;
                        PurchaseOrder_SupplierGoods_Table.Update(poItem);

                    }
                    else if (dto._restockRequestId != "") // warehouse outbound OR store inbound
                    {
                        var potentialWarehouse = WarehouseTable.GetAll().Where(w => w.Location.Id == location).FirstOrDefault();
                        var potentialStore = StoreTable.GetAll().Where(s => s.Location.Id == location).FirstOrDefault();

                        // warehouse stock outbound 
                        if ( potentialWarehouse is not null)
                        {
                            
                        }
                        // store stock inbound
                        else if (potentialStore is not null)
                        {
                            var rr = RestockRequestTable.GetById(dto._restockRequestId);
                            rr.Status = Data.Entity.RestockRequestStatus.Completed;

                            RestockRequestTable.Update(rr);
                        }
                    }
                }
                    
            }
            catch(ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }
            
            
            return Ok();
        }

        public class InDto 
        {
            public string GoodsId { get; set; }
            public int Quantity { get; set; }
            public int MaxLimit { get; set; }   
            public int MinLimit { get; set; }
            public int ReorderLevel { get; set; }
        }

        public class InOutBoundDto
        {
            public string? _purchaseOrderId { get; set; } // warehouse inbound
            public string? _restockRequestId { get; set; } // outbound
            public class InOutBoundItem
            {
                public string _goodsId { get; set; }
                public int qty { get; set; }
            }
            public List<InOutBoundItem> items { get; set; }
        }
    }
}