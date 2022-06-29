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
        private AppLogic.Controllers.GoodsController _GoodsController;
        private Data.DataContext db;


        public Restock(Data.DataContext db)
        {
            repository = new Data.Repositories.Repository<Data.Entity.RestockRequest>(db);
            _SGSTable = new Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock>(db);
            _RSGTable = new Data.Repositories.Repository<Data.Entity.RestockRequest_Supplier_Goods>(db);
            userInfo = new Data.Repositories.UserInfoRepository(db);
            _GoodsController = new AppLogic.Controllers.GoodsController(db);
            this.db = db;
        }


        public class RestockRequestInDto
        {
            public List<RestockRequestItemInDto> Items { get; set; }

            public class RestockRequestItemInDto
            {
                public string _supplierGoodsStockId { get; set; }
                public int Quantity { get; set; }
            }
        }

        public class RestockRequestOutDto 
        {
            public string Id { get; set; }
            public string _storeId { get; set; }
            public DateTime CreateAt { get; set; }
            public DateTime UpdateAt { get; set; }
            public string _operatorId { get; set; }
            public string _creatorId { get; set; }
            public Data.Entity.RestockRequestStatus Status { get; set; }
            public List<RestockRequestItemOutDto> Items { get; set; }

            public class RestockRequestItemOutDto
            {
                public Hashtable Goods { get; set; }
                public int Quantity { get; set; }
                public uint ReceivedQuantity { get; set; }
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] RestockRequestInDto dto)
        {
            try
            {
                Data.Entity.Staff s = userInfo.GetStaffFromUserName(User.Identity.Name);
                Data.Entity.RestockRequest rr = new Data.Entity.RestockRequest
                {
                    ID = Helpers.Sql.PrimaryKeyGenerator.Get<Data.Entity.RestockRequest>(db),
                    _createrId = s.Id,
                    _operatorId = s.Id,
                    _storeId = s.store._locationID,
                    CreateTime = DateTime.Now,
                    OperateTime = DateTime.Now,
                    Status = Data.Entity.RestockRequestStatus.Pending
                };
                repository.Add(rr);

                foreach( var item in dto.Items)
                {
                    Data.Entity.Supplier_Goods_Stock sgs = _SGSTable.GetBySQL($"SELECT * FROM `Supplier_Goods_Stock` WHERE `Id` = '{item._supplierGoodsStockId}'").FirstOrDefault();
                    Data.Entity.RestockRequest_Supplier_Goods rgs = new Data.Entity.RestockRequest_Supplier_Goods
                    {
                        _restockRequestId = rr.ID,
                        _supplierGoodsId = sgs.Id,
                        _quantity = (uint) item.Quantity
                    };
                    _RSGTable.Add(rgs);
                }
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
            catch (NullReferenceException e)
            {
                return StatusCode((int) HttpStatusCode.BadRequest , new { code = HttpStatusCode.BadRequest , message = e.Message });
            }
        }

        [HttpGet]
        [Authorize]
        public IActionResult Get([FromBody] string Langauge)
        {
            try
            {
                Data.Entity.Staff s = userInfo.GetStaffFromUserName(User.Identity.Name);
                List<Data.Entity.RestockRequest> rr = repository.GetBySQL($"SELECT * FROM `RestockRequest` WHERE `_storeId` = '{s.store._locationID}'").ToList();
                return Ok(ToDto(rr,User.Identity.Name, Langauge));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
            catch (NullReferenceException e)
            {
                return StatusCode((int) HttpStatusCode.BadRequest , new { code = HttpStatusCode.BadRequest , message = e.Message });
            }
        }

        public List<RestockRequestOutDto> ToDto(List<Data.Entity.RestockRequest> requests , string username , string lang = "en")
        {
            List<RestockRequestOutDto> dto = new List<RestockRequestOutDto>();
            foreach(var req in requests)
            {
                /*
                    public string Id { get; set; }
                    public string _storeId { get; set; }
                    public string _supplierId { get; set; }
                    public DateTime CreateAt { get; set; }
                    public DateTime UpdateAt { get; set; }
                    public string _operatorId { get; set; }
                    public string _creatorId { get; set; }
                    public Data.Entity.RestockRequestStatus Status { get; set; }
                */
                RestockRequestOutDto r = new RestockRequestOutDto
                {
                    Id = req.ID,
                    _storeId = req._storeId,
                    CreateAt = req.CreateTime,
                    UpdateAt = req.OperateTime,
                    _operatorId = req._operatorId,
                    _creatorId = req._createrId,
                    Status = req.Status,
                    Items = new List<RestockRequestOutDto.RestockRequestItemOutDto>()
                };

                foreach (var item in req.Items)
                {
                    /*
                        public Hashtable Goods { get; set; }
                        public int Quantity { get; set; }
                        public bool isNewItem { get; set; }
                        public uint ReceivedQuantity { get; set; }
                    */
                    r.Items.Add(new RestockRequestOutDto.RestockRequestItemOutDto
                    {
                        Goods = _GoodsController.ToOutDto(item.Supplier_Goods.Goods , username , lang),
                        Quantity = (int) item._quantity,
                        ReceivedQuantity = item._quantityReceived
                    });
                }
                dto.Add(r);
            }
            return dto;
        }
    }
}