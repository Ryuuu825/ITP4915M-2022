using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class OrderController : AppControllerBase<Data.Entity.SalesOrder>
    {
        private readonly Data.Repositories.Repository<SalesOrderItem> _SalesOrderItemTable;

        private readonly Data.Repositories.Repository<Appointment> _AppointmentTable; 
        private readonly Data.Repositories.Repository<BookingOrder> _BookingOrderTable;

        public OrderController(Data.DataContext db) : base(db)
        {
            _SalesOrderItemTable = new Data.Repositories.Repository<SalesOrderItem>(db);
            _AppointmentTable = new Data.Repositories.Repository<Appointment>(db);
            _BookingOrderTable = new Data.Repositories.Repository<BookingOrder>(db);
        }

        public void CreateSalesOrder(OrderDto order)
        {
            // first create the sales order
            // then create appointments and booking orders
            // and finally create sales order items


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
                throw new BadArgException("Invalid CreatorId or StoreId");
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


            // foreach (var item in order.SalesOrderItems)
            // {
               
            //     items.Add(
            //         new SalesOrderItem()
            //         {
            //             _salesOrderId = newOrder.ID,
            //             _supplierGoodsStockId = item.SupplierGoodsStockId,
            //             Quantity = item.Quantity,
            //             _appointmentId = appointments[0]?.ID,
            //         }

            //     );
            // }
            
        }
    }
}