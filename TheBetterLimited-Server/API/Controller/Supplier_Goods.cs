using Microsoft.AspNetCore.Mvc;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/psg")]
    public class Purchase_Supplier_Goods : ControllerBase
    {
        private Data.DataContext db;
        private Data.Repositories.Repository<Data.Entity.Supplier_Goods> repository;
        public Purchase_Supplier_Goods(Data.DataContext db)
        {
            this.db = db;
            repository = new Data.Repositories.Repository<Data.Entity.Supplier_Goods>(db);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id, [FromHeader] string Language)
        {
            var supplier_goods = repository.GetAll().Where(x => x._supplierId == id);
            List<Hashtable> goods = new List<Hashtable>();
            foreach (var item in supplier_goods)
            {
                var a = Helpers.Localizer.TryLocalize<Data.Entity.Goods>(Language , item.Goods);
                goods.Add(a.MapToDto());
            }
            return Ok(goods);
        }
    }
}