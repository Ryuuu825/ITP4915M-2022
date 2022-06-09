using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.Data;


namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/inventory/sgs")]
    public class Inventory_Supplier_Goods_Stock : ControllerBase
    {
        private readonly Data.Repositories.Repository<Data.Entity.Goods> repository;
        private readonly Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock> sgs;
        private readonly Data.Repositories.Repository<Data.Entity.Store> StoreTable;

        private readonly AppLogic.Controllers.GoodsController goodsController;
        public Inventory_Supplier_Goods_Stock(DataContext db)
        {
            repository = new Data.Repositories.Repository<Data.Entity.Goods>(db);
            sgs = new Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock>(db);
            StoreTable = new Data.Repositories.Repository<Data.Entity.Store>(db);
            goodsController = new AppLogic.Controllers.GoodsController(db);
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
                result.Add(h);
            }

            return Ok(result);
        }
    }
}