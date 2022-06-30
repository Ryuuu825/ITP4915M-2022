using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/restock")]
    public class Restock : ControllerBase
    {
        private Data.Repositories.Repository<Data.Entity.RestockRequest> repository;
        private Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock> _SGSTable;
        private Data.Repositories.Repository<Data.Entity.RestockRequest_Supplier_Goods_Stock> _RSGTable;
        private Data.Repositories.UserInfoRepository userInfo;
        private AppLogic.Controllers.GoodsController _GoodsController;
        private AppLogic.Controllers.MessageController message;
        private Data.DataContext db;


        public Restock(Data.DataContext db)
        {
            repository = new Data.Repositories.Repository<Data.Entity.RestockRequest>(db);
            _SGSTable = new Data.Repositories.Repository<Data.Entity.Supplier_Goods_Stock>(db);
            _RSGTable = new Data.Repositories.Repository<Data.Entity.RestockRequest_Supplier_Goods_Stock>(db);
            userInfo = new Data.Repositories.UserInfoRepository(db);
            _GoodsController = new AppLogic.Controllers.GoodsController(db);
            message = new AppLogic.Controllers.MessageController(db);
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
            public Hashtable Location { get; set; }
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
                string locationId = String.Empty;
                if (userInfo.IsSales(User.Identity.Name))
                {
                    locationId = s.store._locationID;
                }
                else
                {
                    locationId = s.warehouse._locationID;
                }
                Data.Entity.RestockRequest rr = new Data.Entity.RestockRequest
                {
                    ID = Helpers.Sql.PrimaryKeyGenerator.Get<Data.Entity.RestockRequest>(db),
                    _createrId = s.Id,
                    _operatorId = s.Id,
                    _locationId = locationId,
                    CreateTime = DateTime.Now,
                    OperateTime = DateTime.Now,
                    Status = Data.Entity.RestockRequestStatus.Pending
                };
                repository.Add(rr);

                foreach( var item in dto.Items)
                {
                    Data.Entity.Supplier_Goods_Stock sgs = _SGSTable.GetBySQL($"SELECT * FROM `Supplier_Goods_Stock` WHERE `Id` = '{item._supplierGoodsStockId}'").First();
                    Data.Entity.RestockRequest_Supplier_Goods_Stock rgs = new Data.Entity.RestockRequest_Supplier_Goods_Stock
                    {
                        _restockRequestId = rr.ID,
                        _supplierGoodsStockId = sgs.Id,
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
/*            catch (NullReferenceException e)
            {
                return StatusCode((int) HttpStatusCode.BadRequest , new { code = HttpStatusCode.BadRequest , message = e.Message });
            }*/
        }


        [HttpGet]
        [Authorize]
        public IActionResult Get([FromHeader] string Langauge = "en")
        {
            try
            {
                Data.Entity.Staff s = userInfo.GetStaffFromUserName(User.Identity.Name);
                List<Data.Entity.RestockRequest> rr = repository.GetBySQL($"SELECT * FROM `RestockRequest` WHERE `_storeId` = '{s.store._locationID}'").ToList();
                if (userInfo.IsSales(User.Identity.Name))
                {
                    message.BoardcastMessage(User.Identity.Name, "300" , "New Restock Request" , "You have new restock request");
                }
                else if (userInfo.IsWarehouseStaff(User.Identity.Name))
                {
                    message.BoardcastMessage(User.Identity.Name, "800" , "New Restock Request" , "You have new restock request");
                }
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

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetById(string id , [FromHeader] string Language)
        {
            try
            {
                Data.Entity.RestockRequest rr = repository.GetById(id);
                return Ok(ToDto(new List<Data.Entity.RestockRequest>{rr},User.Identity.Name, Language)[0]);
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

        [HttpPut("status/{id}")]
        [Authorize]
        /*
            Update status of a restock request:
                - Pending,
                - Approved,
                - Rejected,
                - Cancelled,
                - Handling,
                - Completed
        */ 
        public IActionResult UpdateOrderStatus(string id  , [FromBody] int status)
        {
            try
            {
                Data.Entity.RestockRequestStatus RestockRequestStatus = (Data.Entity.RestockRequestStatus) status;
                Data.Entity.RestockRequest rr = repository.GetById(id);
                rr.Status = RestockRequestStatus;
                rr._operatorId = userInfo.GetStaffFromUserName(User.Identity.Name).Id;
                rr.OperateTime = DateTime.Now;
                repository.Update(rr);

                if (RestockRequestStatus  == Data.Entity.RestockRequestStatus.Approved || RestockRequestStatus == Data.Entity.RestockRequestStatus.Rejected)
                {
                    // send a msg to the creator of the request
                }
                else if (RestockRequestStatus == Data.Entity.RestockRequestStatus.Handling)
                {
                    // send a msg to warehouse staff
                }
                
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                repository.Delete(repository.GetById(id));
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



        [NonAction]
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
                    Location = req.Location.MapToDto(),
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
                        Goods = _GoodsController.ToOutDto(item.Supplier_Goods_Stock.Supplier_Goods.Goods , username , lang),
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