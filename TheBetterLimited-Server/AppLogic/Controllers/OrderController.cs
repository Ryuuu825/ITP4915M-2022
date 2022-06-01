using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class OrderController : AppControllerBase<Data.Entity.SalesOrder>
    {
        private readonly Data.Repositories.Repository<SalesOrderItem> _SalesOrderItemTable;

        private readonly Data.Repositories.Repository<Appointment> _AppointmentTable; 
        private readonly Data.Repositories.Repository<BookingOrder> _BookingOrderTable;
        private readonly Data.Repositories.Repository<Supplier_Goods_Stock> _Supplier_Goods_StockTable;
        private readonly Data.Repositories.Repository<Staff> _StaffTable;
        private readonly Data.Repositories.Repository<Transaction> _TransactionTable;
        private readonly AppLogic.Controllers.MessageController _MessageController;

        public OrderController(Data.DataContext db) : base(db)
        {
            _SalesOrderItemTable = new Data.Repositories.Repository<SalesOrderItem>(db);
            _AppointmentTable = new Data.Repositories.Repository<Appointment>(db);
            _BookingOrderTable = new Data.Repositories.Repository<BookingOrder>(db);
            _Supplier_Goods_StockTable = new Data.Repositories.Repository<Supplier_Goods_Stock>(db);
            _MessageController = new AppLogic.Controllers.MessageController(db);
            _StaffTable = new Data.Repositories.Repository<Staff>(db);
            _TransactionTable = new Data.Repositories.Repository<Transaction>(db);
        }

        public override async Task<List<Hashtable>> GetAll(string lang = "en")
        {
            var salesOrders = await repository.GetAllAsync();
            List<Hashtable> res = new List<Hashtable>();

            // all the sales record in the system
            for (var i = 0; i < salesOrders.Count; i++)
            {
                // localize the sales record
                salesOrders[i] = Helpers.Localizer.TryLocalize<SalesOrder>(lang, salesOrders[i]);
               
                // get the sales record items
                var salesOrderItemList = await _SalesOrderItemTable.GetBySQLAsync(
                    "SELECT * FROM SalesOrderItem WHERE _salesOrderId = " + salesOrders[i].ID
                );

                // tmp list to convert the sales order item to dto
                List<SalesOrderItemOutDto> tmp = new List<SalesOrderItemOutDto>();

                // convert the sales order item to dto
                foreach(var salesOrderItem in salesOrderItemList)
                {
                    var salesOrderItemDto = salesOrderItem.CopyAs<SalesOrderItemOutDto>();
                    salesOrderItemDto.SupplierGoodsStockId = salesOrderItem._supplierGoodsStockId;
                    salesOrderItemDto.Name = salesOrderItem.SupplierGoodsStock.Supplier_Goods.Goods.Name;
                    tmp.Add(salesOrderItemDto);
                }

                // get the store name
                Store store = (await _StaffTable.GetByIdAsync(salesOrders[i]._creatorId)).store;

                // get the amount paid
                decimal paid = 0;
                var transactionRecords = await _TransactionTable.GetBySQLAsync(
                    "SELECT * FROM Transaction WHERE _salesOrderId = " + salesOrders[i].ID
                );
                foreach(var record in transactionRecords)
                {
                    paid += record.Amount;
                }

                decimal total = 0;
                // get the price from the supplier goods stock record
                // get the qty from the sales order item record
                foreach(var salesOrderItem in salesOrderItemList)
                {
                    total += salesOrderItem.Price * salesOrderItem.Quantity;
                }
                

                res.Add(
                    new OrderOutDto
                    {
                        orderItems = tmp,
                        _creatorId = salesOrders[i]._creatorId,
                        _operatorId = salesOrders[i]._operatorId,
                        store = store,
                        createAt = salesOrders[i].createdAt,
                        updateAt = salesOrders[i].updatedAt,
                        status = salesOrders[i].Status.ToString(),
                        total = total,
                        paid = paid
                    }.MapToDto()
                );
            }

            return res;
        }

        
        public async Task CreateSalesOrder(OrderInDto order)
        {
            // first create the sales order
            // and create sales order items
            // and create appointments
            // and last add appointment to the sales order item.


            var newOrder = new SalesOrder()
            {
                ID = Helpers.Sql.PrimaryKeyGenerator.Get<SalesOrder>(db),
                _creatorId = order.SalesOrder.CreatorId,
                _operatorId = order.SalesOrder.CreatorId,
                _storeId = order.SalesOrder.StoreId,
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now,
                Status =  SalesOrderStatus.Placed
            };

            try 
            {
                repository.Add(newOrder);

            }catch(Exception e)
            {
                // sales order should be created successfully first.
                throw new BadArgException("Invalid CreatorId or StoreId");
            }

            List<SalesOrderItem> salesOrderItems = new List<SalesOrderItem>();
            foreach (var item in order.SalesOrderItems)
            {
                salesOrderItems.Add(
                    new SalesOrderItem()
                    {
                        _salesOrderId = newOrder.ID,
                        _supplierGoodsStockId = item.SupplierGoodsStockId,
                        Quantity = item.Quantity,
                        Price = item.Price
                    }
                );

                Supplier_Goods_Stock sgs = (await _Supplier_Goods_StockTable.GetBySQLAsync(
                    Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods_Stock>("Id:" + item.SupplierGoodsStockId)
                )).FirstOrDefault();

                if (sgs.Quantity - item.Quantity < 0)
                {
                    throw new NotEnoughStockException();
                }

                sgs.Quantity = sgs.Quantity - item.Quantity;

                if (sgs.Quantity < sgs.MinLimit)
                {
                    List<string> receivers = new List<string>();
                    var staffs = (await _StaffTable.GetBySQLAsync(
                        Helpers.Sql.QueryStringBuilder.GetSqlStatement<Staff>($"_storeId:{newOrder._storeId};_positionId:202")
                    ));

                    foreach (var staff in staffs)
                    {
                        receivers.Add(staff.acc.UserName);
                    }

                    _MessageController.SendMessage("system" ,
                        new SendMessageDto
                        {
                            receiver = receivers,
                            content = $"The quantity of {sgs._supplierGoodsId} is less than the minimum limit. Please check the stock."
                        }
                    );
                    
                }

                _Supplier_Goods_StockTable.Update(sgs);
            }
            // await _SalesOrderItemTable.AddRangeAsync(salesOrderItems);
            foreach(var item in salesOrderItems)
            {
                _SalesOrderItemTable.Add(item);
            }
            await db.SaveChangesAsync();
        }

        public void CleanOrder(string id)
        {
            // delete the sales order and the sales order items
            // delete the appointments
            // delete the booking order

            // get the sales order
            var salesOrder = repository.GetById(id);
            // get the sales order items
            var salesOrderItems = _SalesOrderItemTable.GetBySQL(
                "SELECT * FROM SalesOrderItem WHERE _salesOrderId = " + salesOrder.ID
            );
            foreach (var soi in salesOrderItems)
            {
                _SalesOrderItemTable.Delete(soi);
            }
            // TODO: delete the appointments
            // TODO: delete the booking order

            repository.Delete(salesOrder);

        }
    }

    
}