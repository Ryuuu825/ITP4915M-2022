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
        private readonly Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock> sgs;
        private readonly Data.Repositories.Repository<Data.Entity.Store> StoreTable;
        private readonly Data.Repositories.Repository<Data.Entity.Warehouse> WarehouseTable;
        private readonly Data.Repositories.Repository<Data.Entity.Account> AccTable;
        private readonly DataContext db;

        private readonly AppLogic.Controllers.GoodsController goodsController;
        public Inventory_Supplier_Goods_Stock(DataContext db)
        {
            repository = new Data.Repositories.Repository<Data.Entity.Goods>(db);
            sgs = new Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock>(db);
            StoreTable = new Data.Repositories.Repository<Data.Entity.Store>(db);
            AccTable = new Data.Repositories.Repository<Data.Entity.Account>(db);
            WarehouseTable = new Data.Repositories.Repository<Data.Entity.Warehouse>(db);
            goodsController = new AppLogic.Controllers.GoodsController(db);
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
                ConsoleLogger.Debug("sfsfk" + p.Supplier_Goods.Goods.Id);
                var goods = Helpers.Localizer.TryLocalize<Data.Entity.Goods>(Language , p.Supplier_Goods.Goods);
                res.Add("GoodsName" , goods.Name);
                return Ok(res);
            }catch(Exception e)
            {
                return StatusCode(500 , e.Message);
            }

        }

        [HttpGet]
        public IActionResult GetAll([FromHeader] string Language = "en")
        {
            var p = repository.GetAll();
            List<Data.Entity.Goods> goods = new List<Data.Entity.Goods>();
            foreach( var g in p)
            {
                goods.Add(Helpers.Localizer.TryLocalize<Data.Entity.Goods>(Language , g));
            }

            var store = StoreTable.GetAll();
            
            var res = sgs.GetAll();
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
        


            var entry = new Data.Entity.Supplier_Goods_Stock()
            {
                Id = Helpers.Sql.PrimaryKeyGenerator.Get<Data.Entity.Supplier_Goods_Stock>(db),
                _locationId = LocationId,
                _supplierGoodsId = content.Supplier_GoodsID,
                Quantity = content.Quantity,
                MaxLimit = content.MaxLimit,
                MinLimit = content.MinLimit,
                ReorderLevel = content.ReorderLevel,
                isSoftDeleted = false
            };
            sgs.Add(entry);
            return Ok();
        }

        public class InDto 
        {
            public string Supplier_GoodsID { get; set; }
            public int Quantity { get; set; }
            public int MaxLimit { get; set; }   
            public int MinLimit { get; set; }
            public int ReorderLevel { get; set; }

        }
    }
}