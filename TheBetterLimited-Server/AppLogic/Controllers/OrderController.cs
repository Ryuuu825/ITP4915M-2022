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
        private readonly AppLogic.Controllers.MessageController _MessageController;

        public OrderController(Data.DataContext db) : base(db)
        {
            _SalesOrderItemTable = new Data.Repositories.Repository<SalesOrderItem>(db);
            _AppointmentTable = new Data.Repositories.Repository<Appointment>(db);
            _BookingOrderTable = new Data.Repositories.Repository<BookingOrder>(db);
            _Supplier_Goods_StockTable = new Data.Repositories.Repository<Supplier_Goods_Stock>(db);
            _MessageController = new AppLogic.Controllers.MessageController(db);
            _StaffTable = new Data.Repositories.Repository<Staff>(db);
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
                        Quantity = item.Quantity
                    }
                );

                Supplier_Goods_Stock sgs = (await _Supplier_Goods_StockTable.GetBySQLAsync(
                    Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods_Stock>("Id:" + item.SupplierGoodsStockId)
                )).FirstOrDefault();

                ConsoleLogger.Debug (sgs.Quantity - item.Quantity);
                ConsoleLogger.Debug (sgs.Quantity - item.Quantity < 0);
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




            // List<SalesOrderItem> items = new List<SalesOrderItem>();

            // Customer c;
            // if (order.Customer is not null)
            // {
            //     c = new Customer()
            //     {
            //         ID = Helpers.Sql.PrimaryKeyGenerator.Get<Customer>(db),
            //         Name = order.Customer.Name,
            //         Phone = order.Customer.Phone,
            //         Address = order.Customer.Address,
            //     };
            // }


            // Appointment[]? appointments = new Appointment[2];
            // if (order.Appointments is not null)
            // {
            //     for (int i = 0 ; i < 2 ; i++)
            //     {
            //         if (order.Appointments[i] is null)
            //             break;

            //         appointments[i] = new Appointment
            //         {
            //             ID = Helpers.Sql.PrimaryKeyGenerator.Get<Appointment>(db),
            //             _sessionId = order.Appointments[i].SessionId,
            //             _departmentId = order.Appointments[i].DepartmentId,
            //             _teamId = null
            //         };
            //     };
            // }

            await db.SaveChangesAsync();
        }
    }
}