using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class OrderController :  IDisposable
    {
        private readonly Data.Repositories.Repository<SalesOrderItem> _SalesOrderItemTable;
        private readonly Data.Repositories.Repository<SalesOrder> repository;

        private readonly Data.Repositories.Repository<Appointment> _AppointmentTable; 
        private readonly Data.Repositories.Repository<BookingOrder> _BookingOrderTable;
        private readonly Data.Repositories.Repository<Supplier_Goods_Stock> _Supplier_Goods_StockTable;
        private readonly Data.Repositories.Repository<Staff> _StaffTable;
        private readonly Data.Repositories.Repository<Transaction> _TransactionTable;
        private readonly Data.Repositories.Repository<Store> _StoreTable;
        private readonly Data.Repositories.Repository<Account> _AccountTable;
        private readonly Data.Repositories.Repository<Customer> _CustomerTable;
        private readonly Data.Repositories.Repository<SalesOrderItem_Appointment> _SalesOrderItem_AppointmentTable;
        private readonly Data.Repositories.Repository<Session> _SessionTable;
        private readonly AppLogic.Controllers.MessageController _MessageController;

        private readonly Data.DataContext db;

        public OrderController(Data.DataContext db) 
        {
            repository = new Data.Repositories.Repository<SalesOrder>(db);
            _SalesOrderItemTable = new Data.Repositories.Repository<SalesOrderItem>(db);
            _AppointmentTable = new Data.Repositories.Repository<Appointment>(db);
            _BookingOrderTable = new Data.Repositories.Repository<BookingOrder>(db);
            _Supplier_Goods_StockTable = new Data.Repositories.Repository<Supplier_Goods_Stock>(db);
            _MessageController = new AppLogic.Controllers.MessageController(db);
            _StaffTable = new Data.Repositories.Repository<Staff>(db);
            _TransactionTable = new Data.Repositories.Repository<Transaction>(db);
            _StoreTable = new Data.Repositories.Repository<Store>(db);
            _AccountTable = new Data.Repositories.Repository<Account>(db);
            _CustomerTable = new Data.Repositories.Repository<Customer>(db);
            _CustomerTable = new Data.Repositories.Repository<Customer>(db);
            _SessionTable = new Data.Repositories.Repository<Session>(db);
            _SalesOrderItem_AppointmentTable = new Data.Repositories.Repository<SalesOrderItem_Appointment>(db);

            this.db = db;
        }

        ~OrderController()
        {
            // Dispose();
        }

        public void Dispose()
        {
            // _SalesOrderItemTable.Dispose();
            // _AppointmentTable.Dispose();
            // _BookingOrderTable.Dispose();
            // _Supplier_Goods_StockTable.Dispose();
            // _StaffTable.Dispose();
            // _TransactionTable.Dispose();
            // _StoreTable.Dispose();
            // _AccountTable.Dispose();
            // _CustomerTable.Dispose();
            // _CustomerTable.Dispose();
            // _SessionTable.Dispose();
            // _SalesOrderItem_AppointmentTable.Dispose();

            // db.Database.CloseConnection();
        }



        public async Task<List<OrderOutDto>> ToDto(List<SalesOrder> salesOrders ,  string lang = "en")
        {
            if (salesOrders.Count == 0)
            {
                return new List<OrderOutDto>();// empty list
            }
            List<OrderOutDto> res = new List<OrderOutDto>(salesOrders.Count);
            // get the store name
            Store store = (await _StaffTable.GetByIdAsync(salesOrders[0]._creatorId)).store;

            // get delivery appointment


            // all the sales record in the system
            for (var i = 0; i < salesOrders.Count; i++)
            {
                AppointmentOutDto? deliveryAppointment = null;
                AppointmentOutDto? installatAppointment = null;
                Customer? customer = null;

                // get the sales record items
                var salesOrderItemList = (await _SalesOrderItemTable.GetBySQLAsync(
                    "SELECT * FROM SalesOrderItem WHERE _salesOrderId = " + salesOrders[i].ID
                )).AsReadOnly();

                // tmp list to convert the sales order item to dto
                List<SalesOrderItemOutDto> tmp = new List<SalesOrderItemOutDto>(salesOrderItemList.Count);

                // convert the sales order item to dto
                foreach(var salesOrderItem in salesOrderItemList)
                {
                    SalesOrderItemOutDto salesOrderItemDto = salesOrderItem.TryCopy<SalesOrderItemOutDto>();
                    salesOrderItemDto.SupplierGoodsStockId = salesOrderItem._supplierGoodsStockId;
                    Goods goods = Helpers.Localizer.TryLocalize<Goods>(lang, salesOrderItem.SupplierGoodsStock.Supplier_Goods.Goods);
                    salesOrderItemDto.Name = goods.Name;
                    tmp.Add(salesOrderItemDto);
                }

                // get the amount paid
                decimal paid = 0;
                var transactionRecords = (await _TransactionTable.GetBySQLAsync(
                    "SELECT * FROM Transaction WHERE _salesOrderId = " + salesOrders[i].ID
                ));
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

                    var appointments = salesOrderItem.SaleOrderItem_Appointment;
                    // if ( appointments is null || appointments.Count == 0)
                    //     continue;   

                    if (salesOrderItem.BookingOrder is not null) // booking order
                    {
                        ConsoleLogger.Debug(salesOrderItem.BookingOrder._customerId);
                        customer = _CustomerTable.GetById(salesOrderItem.BookingOrder._customerId);
                    }
                    else if (appointments is not null || appointments?.Count != 0) // appointment order
                    {
                        try 
                        {
                            customer = _CustomerTable.GetById(appointments[0].Appointment._customerId); // we assume there is only one customer per appointment and both appointment (delivery and installation) have the same customer
                        }catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                            continue; // idk why this happens
                        }
                        foreach(var appointmentItem in appointments)
                        {
                            var session = await _SessionTable.GetByIdAsync(appointmentItem.Appointment._sessionId);

                            if (appointmentItem.Appointment._departmentId == "300") // hard code (this is delivery order)
                            {
                                if (deliveryAppointment == null)
                                {
                                    // lazyloader proxy did not work on the appointment
                                    deliveryAppointment = new AppointmentOutDto
                                    {
                                        AppointmentId = appointmentItem.Appointment.ID,
                                        Date = session.Date,
                                        StartTime = session.StartTime,
                                        EndTime = session.EndTime,
                                        Items = null // we decided to not show to reduce the memory usage , also we assume that all the goods in the sales order are delivered in the same appointment
                                    };
                                }
                            }
                            else if (appointmentItem.Appointment._departmentId == "700") // hard code (this is installat order)
                            {
                                // var goods = salesOrderItem.SupplierGoodsStock.Supplier_Goods.Goods;
                                var goods = Helpers.Localizer.TryLocalize<Goods>(lang, salesOrderItem.SupplierGoodsStock.Supplier_Goods.Goods);
                                if (installatAppointment == null)
                                {
                                    installatAppointment = new AppointmentOutDto
                                    {
                                        AppointmentId = appointmentItem.Appointment.ID,
                                        Date = session.Date,
                                        StartTime = session.StartTime,
                                        EndTime = session.EndTime,
                                        Items = new List<SalesOrderItem_AppointmentOutDto>()
                                        {
                                            new SalesOrderItem_AppointmentOutDto
                                            {
                                                ItemNames = goods.Name,
                                                ItemsId = salesOrderItem.Id
                                            }
                                        }
                                    };
                                }
                                else
                                {
                                    installatAppointment.Items.Add(new SalesOrderItem_AppointmentOutDto
                                    {
                                        ItemNames = goods.Name,
                                        ItemsId = salesOrderItem.Id
                                    });
                                }
                            }
                        }
                    }
                    else 
                    {
                        customer = null;
                        continue;
                    }
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
                        paid = paid,
                        Id = salesOrders[i].ID,
                        Delivery= deliveryAppointment,
                        Installation = installatAppointment,
                        Customer = customer
                    }
                );

                GC.Collect();
            }

            return res;
        }

        public async Task<List<OrderOutDto>> GetAll(string lang = "en")
        {
            var salesOrders = (await repository.GetAllAsync());
            return await ToDto(salesOrders, lang);
        }

        public async Task<List<OrderOutDto>> GetByQueryString(string sql, string lang = "en")
        {
            var salesOrders = (await repository.GetBySQLAsync(Helpers.Sql.QueryStringBuilder.GetSqlStatement<SalesOrder>(sql)));
            return await ToDto(salesOrders, lang);
        }

        public async Task<OrderOutDto> GetById(string id, string lang = "en")
        {
            var salesOrder = (await repository.GetByIdAsync(id));
            var order = new List<SalesOrder>(1) { salesOrder };
            return (await ToDto( order , lang))[0];
        }

        public virtual async Task<List<OrderOutDto>> GetWithLimit(int limit, uint offset = 0 ,string lang = "en")
        {
            var list = (await repository.GetAllAsync()).AsReadOnly().ToList();
            limit = limit > list.Count ? list.Count : limit;
            offset = offset > list.Count ? (uint) list.Count : offset;
            list = list.GetRange((int)offset, limit);
            return await ToDto(list, lang);
        }
        
        public async Task<string> CreateSalesOrder(string Username , OrderInDto order)
        {

            // first create the sales order
            // and create sales order items
            // and create appointments
            // and last add appointment to the sales order item.

            var account = (await _AccountTable.GetBySQLAsync(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"UserName:{Username}")
            )).FirstOrDefault();

            if(account == null)
            {
                throw new Exception("Account not found");
            }

            string StaffId = account._StaffId;
            var staff = (await _StaffTable.GetByIdAsync(StaffId));
            string storeId = (await _StoreTable.GetByIdAsync(staff._storeId)).ID;

            var newOrder = new SalesOrder()
            {
                ID = Helpers.Sql.PrimaryKeyGenerator.Get<SalesOrder>(db),
                _creatorId = StaffId,
                _operatorId = StaffId,
                _storeId = storeId,
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now,
                Status =  SalesOrderStatus.Placed
            };

            try 
            {
                repository.Add(newOrder);
            }catch(Exception e)
            {
                throw e;
                // sales order should be created successfully first.
                throw new BadArgException("Invalid CreatorId or StoreId");
            }

            List<SalesOrderItem> salesOrderItems = new List<SalesOrderItem>();

            
            foreach (var item in order.SalesOrderItems)
            {

                SalesOrderItem i = new SalesOrderItem()
                    {
                        Id = Helpers.Sql.PrimaryKeyGenerator.Get<SalesOrderItem>(db),
                        _salesOrderId = newOrder.ID,
                        _supplierGoodsStockId = item.SupplierGoodsStockId,
                        Quantity = item.Quantity,
                        Price = item.Price
                    };
                salesOrderItems.Add(i);              
                _SalesOrderItemTable.Add(i);

                Supplier_Goods_Stock sgs = (await _Supplier_Goods_StockTable.GetBySQLAsync(
                    Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods_Stock>("Id:" + item.SupplierGoodsStockId)
                )).FirstOrDefault();
                if (sgs is null)
                {
                    CleanOrder(newOrder.ID);
                    throw new BadArgException("Invalid goods stock id : " + item.SupplierGoodsStockId);
                }

                if (sgs.Quantity - item.Quantity < 0)
                {
                    //throw new NotEnoughStockException();
                }

                sgs.Quantity = sgs.Quantity - item.Quantity;

                if (sgs.Quantity < sgs.MinLimit)
                {
                    List<string> receivers = new List<string>();
                    var StoreManager = (await _StaffTable.GetBySQLAsync(
                        Helpers.Sql.QueryStringBuilder.GetSqlStatement<Staff>($"_storeId:{newOrder._storeId};_positionId:202")
                    ));

                    foreach (var s in StoreManager)
                    {
                        receivers.Add(account.UserName);
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
            
            // this is a normal booking, which mean no booking or appointment is needed.
            // and the customer should take the goods at the store
            if (order.Customer is null) // this is a normal order
            {
                salesOrderItems.ForEach(x => x = null);
                salesOrderItems= null;
                account = null;
                staff = null;
                GC.Collect();
                newOrder.Status = SalesOrderStatus.Completed;
                repository.Update(newOrder);
                return newOrder.ID; 
            }
            else // there are some booking, or appointment
            {
                 _CustomerTable.Add(
                    new Customer
                    {
                        ID = Helpers.Sql.PrimaryKeyGenerator.Get<Customer>(db),
                        Name = order.Customer.Name,
                        Phone = order.Customer.Phone,
                        Address = order.Customer.Address

                    });
            }

            // create appointments
            // only have 0 , 1 , or 2 appointments in the list.
            // if there is no (0) appointment, then skip this part
            // if this order needed to be booked, then there are no appointment
            // if there is (1 or 2 ) appointment, then create the appointment


            bool isBooked = false;
            bool isAppointment = false;
    
            // determine is this order needed to be booked or needed to be appointed
            if (order.SalesOrderItems[0].NeedBooking)
            {
                isBooked = true;
            }

            if (order.SalesOrderItems[0].NeedDelivery || order.SalesOrderItems[0].NeedInstall)
            {
                isAppointment = true;

            }
            BookingOrder bookingOrder = new BookingOrder()
            {
                ID = Helpers.Sql.PrimaryKeyGenerator.Get<BookingOrder>(db),
                _customerId = _CustomerTable.GetAll().Last().ID,
            };
            _BookingOrderTable.Add(bookingOrder);
            Appointment[] appointments = new Appointment[2];

            var SalesOrderItemsList = (await _SalesOrderItemTable.GetBySQLAsync(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<SalesOrderItem>($"_salesOrderId:{newOrder.ID}")
            ));

            if (isBooked)
            {
                ConsoleLogger.Debug("Booking order is needed");
                var entry = SalesOrderItemsList[0];
                entry._bookingOrderId = bookingOrder.ID;
                _SalesOrderItemTable.Update(entry);


                newOrder.Status = SalesOrderStatus.Booking;
                repository.Update(newOrder);
            }
            else if (isAppointment)
            {

                newOrder.Status = SalesOrderStatus.PendingDelivery;
                repository.Update(newOrder);
                
                if(order.Appointments.Count == 1)
                {
                    // delivery appointment
                    appointments[0] = new Appointment
                    {
                        ID = Helpers.Sql.PrimaryKeyGenerator.Get<Appointment>(db),
                        _sessionId = order.Appointments[0].SessionId, // hard code
                        _departmentId = order.Appointments[0].DepartmentId, // hard code
                        _customerId = _CustomerTable.GetAll().Last().ID
                    };
                    try 
                    {
                        _AppointmentTable.Add(appointments[0]);

                    }catch(Exception e)
                    {
                        CleanOrder(newOrder.ID);
                        throw new BadArgException("Invalid Appointment");
                    }

                    foreach (var salesOrderItem in SalesOrderItemsList)
                    {
                        _SalesOrderItem_AppointmentTable.Add(
                            new SalesOrderItem_Appointment{
                                _salesOrderItemId = salesOrderItem.Id,
                                _appointmentId = appointments[0].ID
                            }
                        );
                    }
                }
                else if (order.Appointments.Count == 2)
                {
                    // delivery appointment
                    appointments[0] = new Appointment
                    {
                        ID = Helpers.Sql.PrimaryKeyGenerator.Get<Appointment>(db),
                        _sessionId = order.Appointments[0].SessionId, // hard code
                        _departmentId = order.Appointments[0].DepartmentId, // hard code
                        _customerId = _CustomerTable.GetAll().Last().ID,
                    };
                    _AppointmentTable.Add(appointments[0]);  // hard code
                    Session s0 = _SessionTable.GetBySQL(
                        Helpers.Sql.QueryStringBuilder.GetSqlStatement<Session>($"Id:{order.Appointments[0].SessionId}")
                    ).FirstOrDefault();
                    if (s0.NumOfAppointments - 1 <= 0)
                    {
                        CleanOrder(newOrder.ID);
                        throw new BadArgException("Cannot create appointment, the session is full");
                    }
                    s0.NumOfAppointments -= 1;
                    _SessionTable.Update(s0);
                    s0 = null;

                    appointments[1] = new Appointment
                    {
                        ID = Helpers.Sql.PrimaryKeyGenerator.Get<Appointment>(db),
                        _sessionId = order.Appointments[1].SessionId, // hard code
                        _departmentId = order.Appointments[1].DepartmentId, // hard code
                        _customerId = _CustomerTable.GetAll().Last().ID,
                    };
                    _AppointmentTable.Add(appointments[1]); // hard code

                    Session s1 = _SessionTable.GetBySQL(
                        Helpers.Sql.QueryStringBuilder.GetSqlStatement<Session>($"Id:{order.Appointments[1].SessionId}")
                    ).FirstOrDefault();
                     if (s1.NumOfAppointments - 1 <= 0)
                    {
                        CleanOrder(newOrder.ID);
                        throw new BadArgException("Cannot create appointment, the session is full");
                    }
                    s1.NumOfAppointments -= 1;
                    _SessionTable.Update(s1);
                    s1 = null;

                    List<SalesOrderItem_Appointment> salesOrderItem_Appointments = new List<SalesOrderItem_Appointment>();
                    for (int i = 0 ; i < SalesOrderItemsList.Count ; i++)
                    {
                        if (order.SalesOrderItems[i].NeedInstall)
                        {
                            SalesOrderItem_Appointment ientry = new SalesOrderItem_Appointment{
                                _salesOrderItemId = SalesOrderItemsList[i].Id,
                                _appointmentId = appointments[1].ID 
                            };
                            salesOrderItem_Appointments.Add(ientry);
                            ientry = null;
                        }
                        
                        if (order.SalesOrderItems[i].NeedDelivery)
                        {
                            SalesOrderItem_Appointment dentry = new SalesOrderItem_Appointment{
                                    _salesOrderItemId = SalesOrderItemsList[i].Id,
                                    _appointmentId = appointments[0].ID 
                                };
                            salesOrderItem_Appointments.Add(dentry);
                            dentry = null;
                        }
                        
                    }
                    foreach (var entry in salesOrderItem_Appointments)
                    {
                        _SalesOrderItem_AppointmentTable.Add(entry);
                        db.SaveChanges();
                    }
                    salesOrderItem_Appointments = null;
                }
            }

            GC.Collect();
            return newOrder.ID;
        }

        public void CleanOrder(string id)
        {
            // delete the sales order and the sales order items
            // delete the appointments
            // delete the booking order
            db.SaveChanges();

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
            db.SaveChanges();
        }

        public string HoldOrder(OrderInDto TmpOrder)
        {
            string json = JObject.FromObject(TmpOrder).ToString();
            Helpers.File.TempFile tmp =  Helpers.File.TempFileManager.Create();
            tmp.WriteAllText(json);
            return tmp.GetFileName();
        }

        public void DeleteHoldedOrder(string HoldedOrderFileName)
        {
            Helpers.File.TempFileManager.CloseTempFile(HoldedOrderFileName);
        }

        public string GetHoldedOrder(string id)
        {
            try
            {
                return Helpers.File.TempFileManager.GetFileContent(id);
            }catch(FileNotFoundException e)
            {
                throw new FileNotExistException("The Id is invalid" , HttpStatusCode.BadRequest);
            }
        }

        public void updateOrder(UpdateOrderDto dto)
        {
            SalesOrder order = repository.GetById(dto.OrderId);
            List<SalesOrderItem> items = order.Items;

            if (dto.DeliverySessionId is not null || dto.InstallationtSessionId is not null)
            {
                List<string> appointmentID = new List<string>(2);
                foreach (var item in items)
                {
                    foreach(var appointment in item.SaleOrderItem_Appointment)
                    {
                        if (appointmentID.Contains(appointment.Appointment.ID))
                        {
                            continue;
                        }
                        appointmentID.Add(appointment.Appointment.ID);
                    }
                }

                foreach (var appointment in appointmentID)
                {
                    
                    var app = _AppointmentTable.GetById(appointment);
                    _SessionTable.GetBySQL(
                        Helpers.Sql.QueryStringBuilder.GetSqlStatement<Session>(
                            $"Id:{app._sessionId}"
                        )
                    ).FirstOrDefault();

                    if (app._departmentId == "300")
                    {
                        var newDApp = _SessionTable.GetBySQL(
                        Helpers.Sql.QueryStringBuilder.GetSqlStatement<Session>(
                            $"Id:{dto.DeliverySessionId}"
                        )
                        ).FirstOrDefault();

                        newDApp.NumOfAppointments -= 1;
                        _SessionTable.Update(newDApp);
                        app._sessionId = dto.DeliverySessionId;
                    }
                    else if (app._departmentId == "700")
                    {
                        var newIApp = _SessionTable.GetBySQL(
                        Helpers.Sql.QueryStringBuilder.GetSqlStatement<Session>(
                            $"Id:{dto.InstallationtSessionId}"
                        )
                        ).FirstOrDefault();

                        newIApp.NumOfAppointments -= 1;
                        _SessionTable.Update(newIApp);
                        app._sessionId = dto.InstallationtSessionId;
                    }
                }
            }
           

            // update customer infor
            if (dto.CustomerId is not null)
            {
                var customer = _CustomerTable.GetById(dto.CustomerId);
                customer.Name = dto.CustomerName;
                customer.Phone = dto.CustomerPhone;
                customer.Address = dto.CustomerAddress;
                _CustomerTable.Update(customer);

            }

        }



        public class UpdateOrderDto
        {
            public string OrderId { get; set; }
            public string? DeliverySessionId { get; set; }
            public string? InstallationtSessionId { get; set; }
            public string? CustomerId { get; set; }
            public string? CustomerName { get; set; }
            public string? CustomerPhone { get; set; }
            public string? CustomerAddress { get; set; }

        }
    }

    
}