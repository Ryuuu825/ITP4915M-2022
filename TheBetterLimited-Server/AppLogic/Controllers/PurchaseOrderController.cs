using TheBetterLimited_Server.Data.Dto;

namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class PurchaseOrderController
    {
        private readonly Data.DataContext db;
        private readonly Data.Repositories.Repository<Data.Entity.PurchaseOrder> repository;
        private readonly Data.Repositories.UserInfoRepository userInfoRepository;
        private readonly Data.Repositories.Repository<Data.Entity.Goods> _GoodsTable;
        private readonly Data.Repositories.Repository<Data.Entity.Supplier> _SupplierTable;
        private readonly Data.Repositories.Repository<Data.Entity.Warehouse> _WarehouseTable;
        private readonly Data.Repositories.Repository<Data.Entity.PurchaseOrder_Supplier_Goods> _PurchaseOrder_Supplier_GoodsTable;

        private readonly Data.Repositories.Repository<Data.Entity.Supplier_Goods> _Supplier_GoodsTable;

        private readonly AppLogic.Controllers.GoodsController _GoodsController;

        public PurchaseOrderController(Data.DataContext db)
        {
            this.db = db;
            repository = new Data.Repositories.Repository<Data.Entity.PurchaseOrder>(db);
            userInfoRepository = new Data.Repositories.UserInfoRepository(db);
            _GoodsTable = new Data.Repositories.Repository<Data.Entity.Goods>(db);
            _SupplierTable = new Data.Repositories.Repository<Data.Entity.Supplier>(db);
            _Supplier_GoodsTable = new Data.Repositories.Repository<Data.Entity.Supplier_Goods>(db);
            _WarehouseTable = new Data.Repositories.Repository<Data.Entity.Warehouse>(db);
            _PurchaseOrder_Supplier_GoodsTable = new Data.Repositories.Repository<Data.Entity.PurchaseOrder_Supplier_Goods>(db);

        }

        public List<PurchaseOrderOutDto> GetAll(string username, string lang)
        {
            /*
                public string Id { get; set; }
                public DateTime CreateAt { get; set; }
                public DateTime UpdateAt { get; set; }
                public string _operatorId { get; set; }
                public string _creatorId { get; set; }
                public Data.Entity.PurchaseOrderStatus Status { get; set; }
                public decimal Total { get; set; }
                public string _warehouseId { get; set; }
                public string _supplierId { get; set; }
                public List<PurchaseOrderItemInDto> Items { get; set; }

                public class PurchaseOrderItemInDto
                {
                    public string _goodsId { get; set; }
                    public int Quantity { get; set; }
                }
            */
            List<Data.Entity.PurchaseOrder> query = repository.GetAll();
            return ToDto(query , username , lang);

           
        }

        public List<PurchaseOrderOutDto> ToDto(List<Data.Entity.PurchaseOrder> query, string username, string lang = "en")
        {
            List<PurchaseOrderOutDto> result = new List<PurchaseOrderOutDto>();
            List<Data.Entity.Supplier_Goods> supplier_Goods = _Supplier_GoodsTable.GetAll();
            foreach(var entry in query)
            {
                PurchaseOrderOutDto dto = new PurchaseOrderOutDto();
                dto.Id = entry.ID;
                dto.CreateAt = entry.CreateTime;
                dto.UpdateAt = entry.OperateTime;
                dto._operatorId = entry._operatorId;
                dto._creatorId = entry._createrId;
                dto.Status = entry.Status;
                dto.Items = new List<PurchaseOrderItemOutDto>();

                decimal Total = 0;
                foreach(var item in entry.Items)
                {
                    Total += (decimal) (item.Supplier_Goods.Price * item.Quantity);
                    dto.Items.Add(
                        new PurchaseOrderItemOutDto
                        {
                            Goods = _GoodsController.ToOutDto(item.Supplier_Goods.Goods , username , lang),
                            Quantity = (int) item.Quantity
                        }
                    );
                }
                dto.Total = Total;
                dto._warehouseId = entry._warehouseId;
                dto._supplierId = entry._supplierId;
            }
            return result;
        }

        public void CreateEntry(PurchaseOrderInDto dto, string username)
        {
            Data.Entity.PurchaseOrder entry = new Data.Entity.PurchaseOrder();
            entry.ID = Helpers.Sql.PrimaryKeyGenerator.Get<Data.Entity.PurchaseOrder>(db);
            entry.CreateTime = DateTime.Now;
            entry.OperateTime = DateTime.Now;
            entry._operatorId = userInfoRepository.GetStaffFromUserName(username).Id;
            entry._createrId =  userInfoRepository.GetStaffFromUserName(username).Id;
            entry.Status = Data.Entity.PurchaseOrderStatus.Pending;
            entry._warehouseId = dto._warehouseId;
            entry._supplierId = dto._supplierId;
            entry.Items = new List<Data.Entity.PurchaseOrder_Supplier_Goods>();
            foreach(var item in dto.Items)
            {
                if (item.Quantity <= 0)
                    throw new BadArgException("Quantity must be greater than 0");
                Data.Entity.PurchaseOrder_Supplier_Goods entryItem = new Data.Entity.PurchaseOrder_Supplier_Goods();
                entryItem._purchaseOrderId = entry.ID;
                entryItem.Quantity = (uint) item.Quantity;

                Data.Entity.Supplier_Goods potential = _Supplier_GoodsTable.GetBySQL(
                    "SELECT * FROM `Supplier_Goods` WHERE `_supplierId` = '" + dto._supplierId + "' AND `_goodsId` = \"" + item._goodsId + "\""
                ).FirstOrDefault();
                
                if (potential is null)
                {
                    potential = new Data.Entity.Supplier_Goods()
                    {
                        ID = Helpers.Sql.PrimaryKeyGenerator.Get<Data.Entity.Supplier_Goods>(db),
                        _supplierId = dto._supplierId,
                        _goodsId = item._goodsId,
                        Price = item.Price
                    };
                };

                entryItem._purchaseOrderId = potential.ID;
                entry.Items.Add(entryItem);
            }
            repository.Add(entry);
        }
    }
}