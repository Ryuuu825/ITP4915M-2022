using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/restock")]
    public class Restock : ControllerBase
    {
        private Data.Repositories.Repository<Data.Entity.RestockRequest> repository;
        private Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock> _SGSTable;
        private Data.Repositories.Repository<Data.Entity.RestockRequest_Supplier_Goods> _RSGTable;
        private Data.Repositories.UserInfoRepository userInfo;
        private Data.DataContext db;


        public Restock(Data.DataContext db)
        {
            repository = new Data.Repositories.Repository<Data.Entity.RestockRequest>(db);
            _SGSTable = new Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock>(db);
            _RSGTable = new Data.Repositories.Repository<Data.Entity.RestockRequest_Supplier_Goods>(db);
            userInfo = new Data.Repositories.UserInfoRepository(db);
            this.db = db;
        }


        public class RestockRequestInDto
        {
            public string _storeId { get; set; }
            public List<RestockRequestItemInDto> Items { get; set; }

            public class RestockRequestItemInDto
            {
                public string _supplierGoodsStockId { get; set; }
                public int Quantity { get; set; }
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] RestockRequestInDto dto)
        {
            try
            {
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }
    }
}