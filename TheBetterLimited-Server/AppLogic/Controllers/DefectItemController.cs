using TheBetterLimited_Server.Helpers.Extension;
namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class DefectItemController 
    {
        protected readonly Data.DataContext db;
        private Data.Repositories.Repository<Data.Entity.DefectItemRecord> repository;
        private Data.Repositories.Repository<Data.Entity.Customer> _CustomerTable;
        private Data.Repositories.Repository<Data.Entity.SalesOrder> _SalesOrderTable;
        private Data.Repositories.UserInfoRepository userInfo;
        private AppLogic.Controllers.OrderController orderController;
        public DefectItemController(Data.DataContext db) 
        {
            this.db = db;
            repository = new Data.Repositories.Repository<Data.Entity.DefectItemRecord>(db);
            _CustomerTable = new Data.Repositories.Repository<Data.Entity.Customer>(db);
            _SalesOrderTable = new Data.Repositories.Repository<Data.Entity.SalesOrder>(db);
            userInfo = new Data.Repositories.UserInfoRepository(db);
            orderController = new OrderController(db);
        }

        public void AddRefectItemRecord(string user , Data.Dto.DefectItemDto record)
        {
            try 
            {
                string CollectAddress = String.Empty;
                string CustomerId = null;
                if (record.Customer is null)
                {
                    CollectAddress = userInfo.GetStaffFromUserName(user).store.Location.Loc;
                }
                else
                {
                    CollectAddress = record.Customer.Address;
                    Data.Entity.Customer cust = new Data.Entity.Customer
                                                {
                                                    ID = Helpers.Sql.PrimaryKeyGenerator.Get<Data.Entity.Customer>(db),
                                                    Name = record.Customer.Name,
                                                    Phone = record.Customer.Phone,
                                                    Address = record.Customer.Address
                                                };
                    _CustomerTable.Add(cust);
                    CustomerId = cust.ID;
                }

                // get the order
                var order = _SalesOrderTable.GetById(record._salesOrderId);
                var orderDto = orderController.GetById(record._salesOrderId).GetAwaiter().GetResult();
                
                int TotalQty = orderDto.orderItems.Where(x => x.SupplierGoodsStockId == record._supplierGoodsStockId).First().NormalQuantity;
                if (TotalQty - record.Qty < 0)
                    throw new BadArgException("Invalid Quantity");

                if (orderDto.orderItems.Count() == 1 && record.HandleStatus == Data.Entity.DefectItemHandleStatus.Refund) // the order consit of one order item only
                {
                    order.Status = Data.Entity.SalesOrderStatus.Refunded;
                }
                _SalesOrderTable.Update(order);

                repository.Add(
                    new Data.Entity.DefectItemRecord
                    {
                        ID = Helpers.Sql.PrimaryKeyGenerator.Get<Data.Entity.DefectItemRecord>(db),
                        _supplierGoodsStockId = record._supplierGoodsStockId,
                        _salesOrderId = record._salesOrderId,
                        _creatorId = userInfo.GetStaffFromUserName(user).Id,
                        _operatorId = userInfo.GetStaffFromUserName(user).Id,
                        Status = Data.Entity.DefectItemRecordStatus.Pending,
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now,
                        Remark = record.Remark,
                        HandleStatus = record.HandleStatus,
                        _customerId = CustomerId,
                        CollectAddress = CollectAddress,
                        Quantity = record.Qty,
                    }
                );

            }
            catch(MySqlConnector.MySqlException e)
            {
                throw new Exceptions.BadForeignKeyException("The foreign key is not valid.");
            }
            catch(Microsoft.EntityFrameworkCore.DbUpdateException e)
            {
                throw new Exceptions.BadForeignKeyException("The foreign key is not valid.");
            }
            catch (ICustException e)
            {
                throw e;
            }
            catch(Exception e)
            {
                throw new BadArgException("The entry already exists.");
            }
        }

        public async Task<List<Data.Entity.DefectItemRecord>> GetPotentialRecord(string salesOrderId , string salesOrderItemId )
        {
            return (await repository.GetBySQLAsync(
                "SELECT * FROM DefectItemRecord WHERE _salesOrderId = \"" + salesOrderId + "\" AND _salesOrderItemId = \"" + salesOrderItemId  + "\""
            ));
        }


        public List<Hashtable> GetAll(string username , string lang)
        {
            List<Hashtable> res = new List<Hashtable>();
            List<Data.Entity.DefectItemRecord> records = repository.GetAll();

            foreach (var record in records)
            {
                Data.Entity.Goods goods = record.SupplierGoodsStock.Supplier_Goods.Goods;
                var localizeGoods = Helpers.Localizer.TryLocalize<Data.Entity.Goods>(lang , goods);
                Data.Dto.CustomerDto cust ;

                if (record.customer is not null)
                {
                    cust = new Data.Dto.CustomerDto
                    {
                        Name = record.customer.Name,
                        Address = record.customer.Address,
                        Phone = record.customer.Phone
                    };
                }
               

                res.Add(
                    new Data.Dto.DefectItemOutDto
                    {
                        Id = record.ID.ToString(),
                        _creatorId = record._creatorId,
                        _operatorId = record._operatorId,
                        _supplierGoodsStockId = record._supplierGoodsStockId,
                        _salesOrderId = record._salesOrderId,
                        Status = record.Status.ToString(),
                        GoodsName = localizeGoods.Name,
                        CollectAddress = record.CollectAddress,
                        Supplier = record.SupplierGoodsStock.Supplier_Goods.Supplier.MapToDto(),
                        CreateAt = record.createdAt,
                        OperatedAt = record.updatedAt,
                        StoreName = record.SalesOrder.Store.Location.Name,
                        Customer = cust,
                        Qty = record.Quantity,
                        Remark = record.Remark
                    }.MapToDto()
                );
            }

            return res;
        }


        public void UpdateDefectItemStatus(string username , Data.Dto.DefectItemUpdateStatusDto status)
        {
            var record = repository.GetById(status.Id);
            if (record is null)
            {
                throw new BadArgException("Invalid Id");
            }
            record.Status = status.Status;
            record._operatorId = userInfo.GetStaffFromUserName(username).Id;
            record.updatedAt = DateTime.Now;
            repository.Update(record);
        }
        
    }
}