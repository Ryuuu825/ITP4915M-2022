using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Helpers;
using System.IO.Compression;

namespace TheBetterLimited_Server.Data
{
    public static class DummyDataFactory
    {
        public static Random ran = new Random();

        public static async Task Create(DataContext db)
        {
            try
            {

                db.Set<Department>().AddRange(CreateDepartment());
                db.Set<Staff>().AddRange(CreateStaff());
                db.Set<Position>().AddRange(CreatePosition());
                db.Set<Catalogue>().AddRange(CreateCatalogue());
                db.Set<Goods>().AddRange(CreateGoods());
                db.Set<Supplier>().AddRange(CreateSupplier());
                db.Set<Location>().AddRange(CreateLocation());
                db.Set<Store>().AddRange(CreateStore());
                db.Set<Warehouse>().AddRange(CreateWarehouse());
                db.Set<SessionSetting>().AddRange(CreateSessionSetting());

                db.SaveChanges();

                db.Set<Session>().AddRange(CreateSession(db));
                db.Set<Supplier_Goods>().AddRange(CreateSupplier_Goods());
                db.Set<Supplier_Goods_Stock>().AddRange(CreateSupplier_Goods_Stock());
                db.SaveChanges();

                db.Set<Team>().AddRange(CreateTeam());

                using (Repositories.AccountRepository _userTable = new Repositories.AccountRepository(db))
                {
                    var accs = CreateAccount();
                    foreach (var acc in accs)
                    {
                        var entity = acc;
                        _userTable.CreateUser(ref entity);
                    }
                }

                CreateGoodsPhoto(db);

                db.Set<Customer>().AddRange(CreateCustomer());
                db.SaveChanges();

                db.Set<BookingOrder>().AddRange(CreateBookingOrder());
                db.Set<SalesOrder>().AddRange(CreateSalesOrder());
                db.SaveChanges();

                db.Set<SalesOrderItem>().AddRange(CreateSalesOrderItem());
                db.Set<Appointment>().AddRange(CreateAppointment());
                db.SaveChanges();

                db.Set<SalesOrderItem_Appointment>().AddRange(CreateSalesOrderItem_Appointment());
                db.SaveChanges();

            }
            catch (Exception e)
            {
                // user may already inserted the data before
                // so we just ignore the exception
                ConsoleLogger.Debug(e.Message);
                ConsoleLogger.Debug("Please ignore the exception, you may already inserted the data before");
            }
            finally
            {
                db.Dispose();
                GC.SuppressFinalize(db);
                GC.Collect();
            }
        }

        public static List<SalesOrder> CreateSalesOrder()
        {
            int i = 1000000000;
            return new List<SalesOrder>()
            {
                new SalesOrder
                {
                    ID = (++i).ToString(),
                    _creatorId = "S0001",
                    _operatorId = "S0001",
                    _storeId = "H01",
                    createdAt = new DateTime(2022, 6, 9, 12, 0, 0),
                    updatedAt = new DateTime(2022, 6, 9, 12 , 0 ,0),
                    Status = SalesOrderStatus.Placed
                },
                new SalesOrder
                {
                    ID = (++i).ToString(),
                    _creatorId = "S0001",
                    _operatorId = "S0001",
                    _storeId = "H01",
                    createdAt = new DateTime(2022, 6, 9 , 10, 0, 0),
                    updatedAt = new DateTime(2022, 6, 9, 10, 0, 0),
                    Status = SalesOrderStatus.Booking 
                },
                new SalesOrder
                {
                    ID = (++i).ToString(),
                    _creatorId = "S0001",
                    _operatorId = "S0001",
                    _storeId = "H01",
                    createdAt = new DateTime(2022, 6, 9, 22 , 0, 0),
                    updatedAt = new DateTime(2022, 6, 9, 22, 0 , 0),
                    Status = SalesOrderStatus.Completed
                },
                new SalesOrder
                {
                    ID = (++i).ToString(),
                    _creatorId = "S0001",
                    _operatorId = "S0001",
                    _storeId = "H01",
                    createdAt = new DateTime(2022, 6, 9, 15, 0 , 0),
                    updatedAt = new DateTime(2022, 6, 9, 15, 0 , 0),
                    Status = SalesOrderStatus.Completed
                },
                new SalesOrder
                {
                    ID = (++i).ToString(),
                    _creatorId = "S0209",
                    _operatorId = "S0209",
                    _storeId = "H02",
                    createdAt = new DateTime(2022, 6, 9, 15, 0 , 0),
                    updatedAt = new DateTime(2022, 6, 9, 15, 0 , 0),
                    Status = SalesOrderStatus.Placed
                },
                new SalesOrder
                {
                    ID = (++i).ToString(),
                    _creatorId = "S0001",
                    _operatorId = "S0001",
                    _storeId = "H01",
                    createdAt = new DateTime(2022 , 6 , 17 , 9 , 57 , 0),
                    updatedAt = new DateTime(2022 , 6 , 17 , 9 , 57 , 0),
                    Status = SalesOrderStatus.Placed
                },
                new SalesOrder
                {
                    ID = (++i).ToString(),
                    _creatorId = "S0001",
                    _operatorId = "S0001",
                    _storeId = "H01",
                    createdAt = new DateTime(2022 , 6 , 17 , 9 , 57 , 0),
                    updatedAt = new DateTime(2022 , 6 , 17 , 9 , 57 , 0),
                    Status = SalesOrderStatus.Completed
                },
                new SalesOrder
                {
                    ID = (++i).ToString(),
                    _creatorId = "S0001",
                    _operatorId = "S0001",
                    _storeId = "H01",
                    createdAt = new DateTime(2022 , 6 , 17 , 9 , 57 , 0),
                    updatedAt = new DateTime(2022 , 6 , 17 , 9 , 57 , 0),
                    Status = SalesOrderStatus.PendingDelivery
                }
            };
        }

        public static List<SalesOrderItem> CreateSalesOrderItem()
        {
            int i = 1000000000;
            return new List<SalesOrderItem>
            {
                new SalesOrderItem
                {
                    Id = (++i).ToString(),
                    _salesOrderId = (i).ToString(),
                    _supplierGoodsStockId = "100000046",
                    Quantity = 3,
                    _bookingOrderId = null,
                    Price = 15580
                },
                new SalesOrderItem
                {
                    Id = (++i).ToString(),
                    _salesOrderId = (i).ToString(),
                    _supplierGoodsStockId = "100000038",
                    Quantity = 1,
                    _bookingOrderId = "1000000001",
                    Price = 3999
                },
                new SalesOrderItem
                {
                    Id = (++i).ToString(),
                    _salesOrderId = (i).ToString(),
                    _supplierGoodsStockId = "100000035",
                    Quantity = 2,
                    _bookingOrderId = null,
                    Price = 799
                },
                new SalesOrderItem
                {
                    Id = (++i).ToString(),
                    _salesOrderId = (i).ToString(),
                    _supplierGoodsStockId = "100000055",
                    Quantity = 1,
                    _bookingOrderId = null,
                    Price = 6399
                },
                new SalesOrderItem
                {
                    Id = (++i).ToString(),
                    _salesOrderId = (i).ToString(),
                    _supplierGoodsStockId = "100000001",
                    Quantity = 1,
                    _bookingOrderId = null,
                    Price = 12990
                },
                new SalesOrderItem
                {
                    Id = (++i).ToString(),
                    _salesOrderId = (i).ToString(),
                    _supplierGoodsStockId = "100000001",
                    Quantity = 1,
                    _bookingOrderId = null,
                    Price = 10990
                },
                new SalesOrderItem
                {
                    Id = (++i).ToString(),
                    _salesOrderId = (i).ToString(),
                    _supplierGoodsStockId = "100000001",
                    Quantity = 1,
                    _bookingOrderId = null,
                    Price = 10990
                },
                new SalesOrderItem
                {
                    Id = (++i).ToString(),
                    _salesOrderId = (i).ToString(),
                    _supplierGoodsStockId = "100000098",
                    Quantity = 1,
                    _bookingOrderId = null,
                    Price = 8560
                },
            };
        }

        public static List<BookingOrder> CreateBookingOrder()
        {
            int i = 1000000000;
            return new List<BookingOrder>()
            {
                new BookingOrder
                {
                    ID = (++i).ToString(),
                    _customerId = "1000000001",
                    _appointmentId = null,
                    Remarks = "",
                },
                new BookingOrder
                {
                    ID = (++i).ToString(),
                    _customerId = "1000000002",
                    _appointmentId = null,
                    Remarks = "",
                },
                new BookingOrder
                {
                    ID = (++i).ToString(),
                    _customerId = "1000000003",
                    _appointmentId = null,
                    Remarks = "",
                }
            };
        }

        public static List<Customer> CreateCustomer()
        {
            int i = 1000000000;
            return new List<Customer>()
            {
                new Customer
                {
                    ID = (++i).ToString(),
                    Name = "Ken",
                    Address = "20 Tsing Yi Road,Tsing Yi Island, New Territories",
                    Phone = "2436 8333"
                },
                new Customer
                {
                    ID = (++i).ToString(),
                    Name = "John C NA",
                    Address = "Bing Chilling Lin Road,Tsing Yi Island, New Territories",
                    Phone = "2436 8333"
                },
                new Customer
                {
                    ID = (++i).ToString(),
                    Name = "Terence L.",
                    Address = "駿景園10座1 Tsun King Rd, Royal Ascot",
                    Phone = "2436 8333"
                },
                new Customer
                {
                    ID = (++i).ToString(),
                    Name = "Justin Chan",
                    Address = "80 Tat Chee Ave, Kowloon Tong",
                    Phone = "2436 8333"
                },
                new Customer
                {
                    ID = (++i).ToString(),
                    Name = "Joe Ng",
                    Address = "Wong Ching Road, ShaTin, New Territories",
                    Phone = "2436 8333"
                },
                new Customer
                {
                    ID = (++i).ToString(),
                    Name = "Karen",
                    Address = "8 Chui Chuk St, Chuk Un",
                    Phone = "2436 8333"
                },
            };
        }

        public static List<Appointment> CreateAppointment()
        {
            int i = 1000000000;
            return new List<Appointment>
            {
                new Appointment
                {   
                    ID = (++i).ToString(),
                    _sessionId = "000000008",
                    _departmentId = "300",
                    _teamId = null,
                    _customerId = "1000000001"
                },
                new Appointment
                {
                    ID = (++i).ToString(),
                    _sessionId = "000000011",
                    _departmentId = "700",
                    _teamId = null,
                    _customerId = "1000000001"
                },
                new Appointment
                {
                    ID = (++i).ToString(),
                    _sessionId = "000000012",
                    _departmentId = "300",
                    _teamId = null,
                    _customerId = "1000000003"
                },
                new Appointment
                {
                    ID = (++i).ToString(),
                    _sessionId = "000000031",
                    _departmentId = "700",
                    _teamId = null,
                    _customerId = "1000000003"
                },
                new Appointment
                {
                    ID = (++i).ToString(),
                    _sessionId = "000000002", // must be today
                    _departmentId = "300",
                    _teamId = "301",
                    _customerId = "1000000004"
                },
                new Appointment
                {
                    ID = (++i).ToString(),
                    _sessionId = "100000001", // must be today
                    _departmentId = "300",
                    _teamId = "301",
                    _customerId = "1000000005"
                },
                new Appointment
                {
                    ID = "000000000",
                    _sessionId = "999999999", // must be today
                    _departmentId = "300",
                    _teamId = "301",
                    _customerId = "1000000006"
                },
                new Appointment
                {
                    ID = "000000001",
                    _sessionId = "999999999", // must be today
                    _departmentId = "700",
                    _teamId = "701",
                    _customerId = "1000000006"
                },
            };
        }

        public static List<SalesOrderItem_Appointment> CreateSalesOrderItem_Appointment()
        {
            int i = 1000000000;
            return new List<SalesOrderItem_Appointment>
            {
                new SalesOrderItem_Appointment
                {
                    _salesOrderItemId = "1000000001",
                    _appointmentId = "1000000001"
                },
                new SalesOrderItem_Appointment
                {
                    _salesOrderItemId = "1000000001",
                    _appointmentId = "1000000002"
                },
                new SalesOrderItem_Appointment
                {
                    _salesOrderItemId = "1000000005",
                    _appointmentId = "1000000003"
                },
                new SalesOrderItem_Appointment
                {
                    _salesOrderItemId = "1000000005",
                    _appointmentId = "1000000004"
                },
                new SalesOrderItem_Appointment
                {
                    _salesOrderItemId = "1000000006",
                    _appointmentId = "1000000005"
                },
                new SalesOrderItem_Appointment
                {
                    _salesOrderItemId = "1000000007",
                    _appointmentId = "1000000006"
                },
                new SalesOrderItem_Appointment
                {
                    _salesOrderItemId = "1000000008",
                    _appointmentId = "000000000"
                },
                new SalesOrderItem_Appointment
                {
                    _salesOrderItemId = "1000000008",
                    _appointmentId = "000000001"
                }
            };
        }

        public static List<Staff> CreateStaff()
        {
            return new List<Staff>()
            {
                new Staff()
                {
                    Id = "S0000",
                    _departmentId = "000",
                    _positionId = "000",
                    FirstName = "The Better",
                    LastName = "Limited",
                },
                new Staff()
                {
                    Id = "S0001",
                    _departmentId = "010",
                    _positionId = "001",
                    FirstName = "Admin",
                    LastName = "Lee",
                    Sex = 'M',
                    Age = 18,
                    _storeId = "H01",

                },
                new Staff()
                {
                    Id = "S0002",
                    _departmentId = "010",
                    _positionId = "001",
                    FirstName = "Admin1",
                    LastName = "Pan",
                    Sex = 'M',
                    Age = 18,
                    _storeId = "H01",

                },
                new Staff()
                {
                    Id = "S0003",
                    _departmentId = "999",
                    _positionId = "999",
                    FirstName = "Freerider",
                    LastName = "Leung",
                    Sex = 'M',
                    Age = 20,
                    _storeId = "H01",

                },
                new Staff()
                {
                    Id = "S0004",
                    _departmentId = "010",
                    _positionId = "001",
                    FirstName = "Admin2",
                    LastName = "Lam",
                    Sex = 'M',
                    Age = 20,
                    _storeId = "H01",

                },
                // create few staff who work for sales deparment as salesman
                new Staff
                {
                    Id = "S0205",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "John",
                    LastName = "Doe",
                    Sex = 'M',
                    Age = 30,
                    _storeId="H01"
                },
                new Staff
                {
                    Id = "S0206",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Sex = 'F',
                    Age = 30,
                    _storeId="H01"
                },
                new Staff
                {
                    Id = "S0207",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Joe",
                    LastName = "Chan",
                    Sex = 'M',
                    Age = 20,
                    _storeId="H01"
                },
                new Staff
                {
                    Id = "S0208",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Sophia",
                    LastName = "Wu",
                    Sex = 'F',
                    Age = 19,
                    _storeId="H01"
                },
                new Staff
                {
                    Id = "S0209",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "John",
                    LastName = "Cena",
                    Sex = 'M',
                    Age = 30,
                    _storeId="H02"
                },
                new Staff
                {
                    Id = "S0210",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Joey",
                    LastName = "AD",
                    Sex = 'F',
                    Age = 30,
                    _storeId="H02"
                },
                new Staff
                {
                    Id = "S0211",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Ben",
                    LastName = "Chan",
                    Sex = 'M',
                    Age = 20,
                    _storeId="H02"
                },
                new Staff
                {
                    Id = "S0212",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Sophena",
                    LastName = "Wai",
                    Sex = 'F',
                    Age = 19,
                    _storeId="H02"
                },
                // two sales manager
                new Staff
                {
                    Id = "S0299",
                    _departmentId = "200",
                    _positionId = "202",
                    FirstName = "Tom",
                    LastName = "Lee",
                    _storeId = "H01",
                    Sex = 'M',
                    Age = 42
                },
                new Staff
                {
                    Id = "S0298",
                    _departmentId = "200",
                    _positionId = "202",
                    FirstName = "But",
                    LastName = "But",
                    _storeId = "H02",
                    Sex = 'F',
                    Age = 24
                },
                // inventory clerk
                new Staff
                {
                    Id = "S0301",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Bob",
                    LastName = "Wong",
                    Sex = 'M',
                    Age = 33,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0302",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Watame",
                    LastName = "Tsunomaki",
                    Sex = 'F',
                    Age = 18,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0303",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Joey",
                    LastName = "Chan",
                    Sex = 'F',
                    Age = 20,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0304",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Athena",
                    LastName = "Lam",
                    Sex = 'F',
                    Age = 19,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0305",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Coco",
                    LastName = "Lam",
                    Sex = 'F',
                    Age = 19,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0306",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Yanny",
                    LastName = "Lam",
                    Sex = 'F',
                    Age = 19,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0307",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Selena",
                    LastName = "Kim",
                    Sex = 'F',
                    Age = 20,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0308",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Jenny",
                    LastName = "Lam",
                    Sex = 'F',
                    Age = 56,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0309",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Mia",
                    LastName = "Wong",
                    Sex = 'F',
                    Age = 27,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0310",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "May",
                    LastName = "Wong",
                    Sex = 'F',
                    Age = 18,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0311",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Ian",
                    LastName = "Lai",
                    Sex = 'M',
                    Age = 20,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0312",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Justin",
                    LastName = "Ng",
                    Sex = 'M',
                    Age = 19,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0313",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Jimmy",
                    LastName = "Lam",
                    Sex = 'M',
                    Age = 20,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0314",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Revees",
                    LastName = "Lai",
                    Sex = 'F',
                    Age = 27,
                    _warehouseId = "001"
                },
                // one inventory manager
                new Staff
                {
                    Id = "S0315",
                    _departmentId = "300",
                    _positionId = "302",
                    FirstName = "Sen",
                    LastName = "Ikura",
                    Sex = 'F',
                    Age = 43,
                    _warehouseId = "001"
                },
                // 15 delivery workman
                new Staff
                {
                    Id = "S0316",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Seven",
                    LastName = "Sea",
                    Sex = 'F',
                    Age = 32,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0317",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Pao",
                    LastName = "Chan",
                    Sex = 'M',
                    Age = 25,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0318",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Ben",
                    LastName = "Chao",
                    Sex = 'M',
                    Age = 18,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0319",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Leo",
                    LastName = "Lai",
                    Sex = 'M',
                    Age = 45,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0320",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Arthur",
                    LastName = "Lo",
                    Sex = 'M',
                    Age = 38,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0321",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Stephen",
                    LastName = "Kwok",
                    Sex = 'M',
                    Age = 40,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0322",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Jessie",
                    LastName = "Wong",
                    Sex = 'F',
                    Age = 20,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0323",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Alkoline",
                    LastName = "Water",
                    Sex = 'M',
                    Age = 60,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0324",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Gigi",
                    LastName = "Wong",
                    Sex = 'F',
                    Age = 21,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0325",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Anson",
                    LastName = "Pink",
                    Sex = 'M',
                    Age = 28,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0326",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Momoko",
                    LastName = "Lai",
                    Sex = 'F',
                    Age = 27,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0327",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Joan",
                    LastName = "Lo",
                    Sex = 'M',
                    Age = 43,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0328",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Sophia",
                    LastName = "Lam",
                    Sex = 'F',
                    Age = 47,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0329",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "KK",
                    LastName = "Ip",
                    Sex = 'M',
                    Age = 51,
                    _warehouseId = "001"
                },
                new Staff
                {
                    Id = "S0330",
                    _departmentId = "300",
                    _positionId = "303",
                    FirstName = "Michelle",
                    LastName = "Sum",
                    Sex = 'F',
                    Age = 19,
                    _warehouseId = "001"
                },
                // 15 techinal workman
                new Staff
                {
                    Id = "S0701",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Eden",
                    LastName = "Chan",
                    Sex = 'M',
                    Age = 18
                },
                new Staff
                {
                    Id = "S0702",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Cinderella",
                    LastName = "Luk",
                    Sex = 'F',
                    Age = 26
                },
                new Staff
                {
                    Id = "S0703",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Jerry",
                    LastName = "Young",
                    Sex = 'M',
                    Age = 37
                },
                new Staff
                {
                    Id = "S0704",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Crystal",
                    LastName = "Chan",
                    Sex = 'F',
                    Age = 31
                },
                new Staff
                {
                    Id = "S0705",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "John",
                    LastName = "Ng",
                    Sex = 'M',
                    Age = 36
                },
                new Staff
                {
                    Id = "S0706",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Yannis",
                    LastName = "Ng",
                    Sex = 'F',
                    Age = 34
                },
                new Staff
                {
                    Id = "S0707",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Jimmy",
                    LastName = "Wong",
                    Sex = 'M',
                    Age = 21
                },
                new Staff
                {
                    Id = "S0708",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Sandy",
                    LastName = "Lam",
                    Sex = 'F',
                    Age = 23
                },
                new Staff
                {
                    Id = "S0709",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Dylan",
                    LastName = "Lee",
                    Sex = 'M',
                    Age = 24
                },
                new Staff
                {
                    Id = "S0710",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Sally",
                    LastName = "Ma",
                    Sex = 'F',
                    Age = 28
                },
                new Staff
                {
                    Id = "S0711",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Dareum",
                    LastName = "Nam",
                    Sex = 'M',
                    Age = 34
                },
                new Staff
                {
                    Id = "S0712",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Harry",
                    LastName = "Potter",
                    Sex = 'M',
                    Age = 18
                },
                new Staff
                {
                    Id = "S0713",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Jacky",
                    LastName = "Chan",
                    Sex = 'M',
                    Age = 19
                },
                new Staff
                {
                    Id = "S0714",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Anya",
                    LastName = "Forger",
                    Sex = 'F',
                    Age = 24
                },
                new Staff
                {
                    Id = "S0715",
                    _departmentId = "700",
                    _positionId = "701",
                    FirstName = "Rider",
                    LastName = "Light",
                    Sex = 'M',
                    Age = 25
                },
                new Staff
                {
                    Id = "S0716",
                    _departmentId = "700",
                    _positionId = "702",
                    FirstName = "John",
                    LastName = "Cena",
                    Sex = 'M',
                    Age = 45
                },
                new Staff
                {
                    Id = "S0717",
                    _departmentId = "800",
                    _positionId = "801",
                    FirstName = "Gwar",
                    LastName = "Gura",
                    Sex = 'M',
                    Age = 45
                },
                new Staff
                {
                    Id = "S0718",
                    _departmentId = "800",
                    _positionId = "801",
                    FirstName = "Calliope",
                    LastName = "Mori",
                    Sex = 'M',
                    Age = 45
                },
                 new Staff
                {
                    Id = "S0719",
                    _departmentId = "800",
                    _positionId = "802",
                    FirstName = "Amelia",
                    LastName = "Waston",
                    Sex = 'M',
                    Age = 45
                },
            };
        }

        public static List<Account> CreateAccount()
        {
            return new List<Account>
            {
                new Account
                {
                    Id = "A0000",
                    _StaffId = "S0000",
                    LoginFailedCount = Int16.MinValue,
                    LoginFailedAt = DateTime.MinValue,
                    Icon = null,
                    UserName = "system",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("system"),
                    EmailAddress = Helpers.EmailSender.GetEmailAddress(),
                    Status = "N",
                    Remarks = "Used for boardcast message"
                },
                new Account
                {
                    Id = "A0001",
                    _StaffId = "S0001",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "admin",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@example.com",
                    Status = "N",
                    Remarks = "none"
                },
                new Account
                {
                    Id = "A0002",
                    _StaffId = "S0002",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "admin1",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@example.com",
                    Status = "N",
                    Remarks = "none"
                },
                new Account
                {
                    Id = "A0003",
                    _StaffId = "S0003",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.MaxValue,
                    Icon = null,
                    UserName = "admin2",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "str@domain.com",
                    Status = "N",
                    Remarks = "none"
                },
                new Account
                {
                    Id = "A0004",
                    _StaffId = "S0004",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "admin3",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@domain.com",
                    Status = "N",
                    Remarks = "none"
                },
                // two retail store manager
                new Account
                {
                    Id = "A0005",
                    _StaffId = "S0299",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "TW StoreManager",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@domain.com",
                    Status = "N",
                    Remarks = "none"
                },
                new Account
                {
                    Id = "A0006",
                    _StaffId = "S0298",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "KL StoreManager",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@domain.com",
                    Status = "N",
                    Remarks = "none"
                },
                    // one inventory manager
                new Account
                {
                    Id = "A0007",
                    _StaffId = "S0315",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "InventoryManager",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@domain.com",
                    Status = "N",
                    Remarks = "none"
                },
                // delivery workman
                new Account
                {
                    Id = "A0008",
                    _StaffId = "S0316",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "DeliveryWorkman",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@domain.com",
                    Status = "N",
                    Remarks = "none"
                },
                // technical workman
                new Account
                {
                    Id = "A0009",
                    _StaffId = "S0701",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "TechnicalWorkman",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@domain.com",
                    Status = "N",
                    Remarks = "none"
                },

                //optional
                //inventory clerk
                new Account
                {
                    Id = "A0010",
                    _StaffId = "S0301",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "InventoryClerk",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@domain.com",
                    Status = "N",
                    Remarks = "none"
                },

                //salesman
                new Account
                {
                    Id = "A0011",
                    _StaffId = "S0205",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "Salesman",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@domain.com",
                    Status = "N",
                    Remarks = "none"
                },

                //Technical Manager
                new Account
                {
                    Id = "A0012",
                    _StaffId = "S0716",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "TechnicalManager",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "user@domain.com",
                    Status = "N",
                    Remarks = "none"
                },  
                // Purchase Clerk
                new Account
                {
                    Id = "A0013",
                    _StaffId = "S0717",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "PurchaseClerk",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "abs@hololive.com",
                    Status = "N",
                    Remarks = "none"
                },
                // Purchase Manager
                 new Account
                {
                    Id = "A0015",
                    _StaffId = "S0719",
                    LoginFailedCount = 0,
                    LoginFailedAt = null,
                    LastLogin = null,
                    unlockDate = DateTime.Now,
                    Icon = null,
                    UserName = "PurchaseManager",
                    Password = TheBetterLimited_Server.Helpers.Secure.Hasher.Hash("admin"),
                    EmailAddress = "abs@hololive.com",
                    Status = "N",
                    Remarks = "none"
                },
            };
        }

        public static Department[] CreateDepartment()
        {
            return new Department[]
            {
                new Department
                {
                    Id = "000",
                    Name = "System"
                },
                new Department
                {
                    Id = "010",
                    Name = "Admin"
                },
                new Department
                {
                    Id = "200",
                    Name = "Sales"
                },
                new Department
                {
                    Id = "300",
                    Name = "Inventory"
                },
                new Department
                {
                    Id = "400",
                    Name = "Accounting"
                },
                new Department
                {
                    Id = "500",
                    Name = "Human Resource"
                },
                new Department
                {
                    Id = "600",
                    Name = "Information Technology"
                },
                new Department
                {
                    Id = "700",
                    Name = "Technical"
                },
                new Department
                {
                    Id = "800",
                    Name = "Purchase"
                },
                new Department
                {
                    Id = "900",
                    Name = "Management"
                },
                new Department
                {
                    Id = "999",
                    Name = "Freeride"
                }
            };
        }


        public static Position[] CreatePosition()
        {
            return new Position[]
            {
                new Position
                {
                    Id = "000",
                    jobTitle = "Server",
                    _departmentId = "000",
                },
                new Position
                {
                    Id = "001",
                    jobTitle = "Admin",
                    _departmentId = "010"
                },
                new Position
                {
                    Id = "999",
                    jobTitle = "Freerider",
                    _departmentId = "999"
                },
                new Position
                {
                    Id = "201",
                    jobTitle = "Salesman",
                    _departmentId = "200"
                },
                new Position
                {
                    Id = "202",
                    jobTitle = "Sales Manager",
                    _departmentId = "200"
                },
                new  Position
                {
                    Id = "203",
                    jobTitle = "Store manager",
                    _departmentId = "200"
                },
                new Position
                {
                    Id = "301",
                    jobTitle = "Inventory Clerk",
                    _departmentId = "300"
                },
                new Position
                {
                    Id = "302",
                    jobTitle = "Inventory Manager",
                    _departmentId = "300"
                },
                new Position
                {
                    Id = "303",
                    jobTitle = "Delivery Workman",
                    _departmentId = "300"
                },
                new Position
                {
                    Id = "401",
                    jobTitle = "Accountant",
                    _departmentId = "400"
                },
                new Position
                {
                    Id = "402",
                    jobTitle = "Accountant Manager",
                    _departmentId = "400"
                },
                new Position
                {
                    Id = "501",
                    jobTitle = "HR Staff",
                    _departmentId = "500"
                },
                new Position
                {
                    Id = "502",
                    jobTitle = "HR Manager",
                    _departmentId = "500"
                },
                new Position
                {
                    Id = "601",
                    jobTitle = "IT Staff",
                    _departmentId = "600"
                },
                new Position
                {
                    Id = "602",
                    jobTitle = "IT Manager",
                    _departmentId = "600"
                },
                new Position
                {
                    Id = "603",
                    jobTitle = "IT Director",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "604",
                    jobTitle = "IS Manager",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "605",
                    jobTitle = "Project Manager",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "701",
                    jobTitle = "Technical Workman",
                    _departmentId = "700"
                },
                new Position
                {
                    Id = "702",
                    jobTitle = "Technical Manager",
                    _departmentId = "700"
                },
                new Position
                {
                    Id = "801",
                    jobTitle = "Purchase Clerk",
                    _departmentId = "800"
                },
                new Position
                {
                    Id = "802",
                    jobTitle = "Purchase Manager",
                    _departmentId = "800"
                },
                new Position
                {
                    Id = "901",
                    jobTitle = "Chief executive officer",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "902",
                    jobTitle = "Chief financial officer",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "903",
                    jobTitle = "Operations Manager",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "904",
                    jobTitle = "President",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "905",
                    jobTitle = "General Manager",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "906",
                    jobTitle = "Vice President",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "907",
                    jobTitle = "Risk Manager",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "908",
                    jobTitle = "Chief information officer",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "909",
                    jobTitle = "Chief operating officer",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "910",
                    jobTitle = "Chief financial officer",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "911",
                    jobTitle = "Chief marketing officer",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "912",
                    jobTitle = "Chief legal officer",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "913",
                    jobTitle = "Chief product officer",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "914",
                    jobTitle = "Chief data officer",
                    _departmentId = "900"
                },
                new Position
                {
                    Id = "915",
                    jobTitle = "Chief technology officer",
                    _departmentId = "900"
                }
            };
        }

        public static Catalogue[] CreateCatalogue()
        {
            return new Catalogue[]
            {
                new Catalogue
                {
                    Id = "100",
                    Name = "@$T100",
                },
                new Catalogue
                {
                    Id = "200",
                    Name = "@$T200",
                },
                new Catalogue
                {
                    Id = "300",
                    Name = "@$T300",
                },
                new Catalogue
                {
                    Id = "400",
                    Name = "@$T400",
                },
                new Catalogue
                {
                    Id = "500",
                    Name = "@$T500",
                },
                new Catalogue
                {
                    Id = "600",
                    Name = "@$T600",
                },
                new Catalogue
                {
                    Id = "700",
                    Name = "@$T700",
                }
            };
        }

        public static List<Goods> CreateGoods()
        {
            int i = "100000".ToInt();
            return new List<Goods>()
            {
                new Goods
                {
                    Id = "TVA0000001",
                    Name = "@$TVA0000001N",
                    _catalogueId = "100",
                    Description = "@$TVA0000001D",
                    Price = (decimal) 4550,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "TVA0000002",
                    Name = "@$TVA0000002N",
                    _catalogueId = "100",
                    Description = "@$TVA0000002D",
                    Price = (decimal) 3950,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000003",
                    Name = "@$TVA0000003N",
                    _catalogueId = "100",
                    Description = "@$TVA0000003D",
                    Price = (decimal) 7080,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000004",
                    Name = "@$TVA0000004N",
                    _catalogueId = "100",
                    Description = "@$TVA0000004D",
                    Price = (decimal) 116980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000005",
                    Name = "@$TVA0000005N",
                    _catalogueId = "100",
                    Description = "@$TVA0000005D",
                    Price = 6399,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000006",
                    Name = "@$TVA0000006N",
                    _catalogueId = "100",
                    Description = "@$TVA0000006D",
                    Price = (decimal) 3199,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                //new
                new Goods
                {
                    Id = "TVA0000007",
                    Name = "@$TVA0000007N",
                    _catalogueId = "100",
                    Description = "@$TVA0000007D",
                    Price = (decimal) 5490,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000008",
                    Name = "@$TVA0000008N",
                    _catalogueId = "100",
                    Description = "@$TVA0000008D",
                    Price = (decimal) 5580,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000009",
                    Name = "@$TVA0000009N",
                    _catalogueId = "100",
                    Description = "@$TVA0000009D",
                    Price = (decimal) 5980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000010",
                    Name = "@$TVA0000010N",
                    _catalogueId = "100",
                    Description = "@$TVA0000010D",
                    Price = (decimal) 8980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000011",
                    Name = "@$TVA0000011N",
                    _catalogueId = "100",
                    Description = "@$TVA0000011D",
                    Price = (decimal) 1238,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000012",
                    Name = "@$TVA0000012N",
                    _catalogueId = "100",
                    Description = "@$TVA0000012D",
                    Price = (decimal) 4498,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000013",
                    Name = "@$TVA0000013N",
                    _catalogueId = "100",
                    Description = "@$TVA0000013D",
                    Price = (decimal) 320,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000014",
                    Name = "@$TVA0000014N",
                    _catalogueId = "100",
                    Description = "@$TVA0000014D",
                    Price = (decimal) 1690,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000015",
                    Name = "@$TVA0000015N",
                    _catalogueId = "100",
                    Description = "@$TVA0000015D",
                    Price = (decimal) 1490,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000016",
                    Name = "@$TVA0000016N",
                    _catalogueId = "100",
                    Description = "@$TVA0000016D",
                    Price = (decimal) 4980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000017",
                    Name = "@$TVA0000017N",
                    _catalogueId = "100",
                    Description = "@$TVA0000017D",
                    Price = (decimal) 1690,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000018",
                    Name = "@$TVA0000018N",
                    _catalogueId = "100",
                    Description = "@$TVA0000018D",
                    Price = (decimal) 648,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000019",
                    Name = "@$TVA0000019N",
                    _catalogueId = "100",
                    Description = "@$TVA0000019D",
                    Price = (decimal) 648,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "TVA0000020",
                    Name = "@$TVA0000020N",
                    _catalogueId = "100",
                    Description = "@$TVA0000020D",
                    Price = (decimal) 19799,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                },
                // end new

                //  Refrigerators and Freezers 200
                // new 
                new Goods
                {
                    Id = "RFS1000001",
                    Name = "@$RFS1000001N",
                    _catalogueId = "200",
                    Description = "@$RFS1000001D",
                    Price = (decimal) 11100,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "RFS1000002",
                    Name = "@$RFS1000002N",
                    _catalogueId = "200",
                    Description = "@$RFS1000002D",
                    Price = (decimal) 3790,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "RFS1000003",
                    Name = "@$RFS1000003N",
                    _catalogueId = "200",
                    Description = "@$RFS1000003D",
                    Price = (decimal) 19189,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "RFS1000004",
                    Name = "@$RFS1000004N",
                    _catalogueId = "200",
                    Description = "@$RFS1000004D",
                    Price = (decimal) 9990,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "RFS1000005",
                    Name = "@$RFS1000005N",
                    _catalogueId = "200",
                    Description = "@$RFS1000005D",
                    Price = (decimal) 4399,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "RFS1000006",
                    Name = "@$RFS1000006N",
                    _catalogueId = "200",
                    Description = "@$RFS1000006D",
                    Price = (decimal) 15399,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                // end new
                new Goods
                {
                    Id = "RFS1000007",
                    Name = "@$RFS1000007N",
                    _catalogueId = "200",
                    Description = "@$RFS1000007D",
                    Price = (decimal) 7814,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "RFS1000008",
                    Name = "@$RFS1000008N",
                    _catalogueId = "200",
                    Description = "@$RFS1000008D",
                    Price = (decimal) 2599,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                // new
                new Goods
                {
                    Id = "RFS1000009",
                    Name = "@$RFS1000009N",
                    _catalogueId = "200",
                    Description = "@$RFS1000009D",
                    Price = (decimal) 2799,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000010",
                    Name = "@$RFS1000010N",
                    _catalogueId = "200",
                    Description = "@$RFS1000010D",
                    Price = (decimal) 26078,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000011",
                    Name = "@$RFS1000011N",
                    _catalogueId = "200",
                    Description = "@$RFS1000011D",
                    Price = (decimal) 5490,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000012",
                    Name = "@$RFS1000012N",
                    _catalogueId = "200",
                    Description = "@$RFS1000012D",
                    Price = (decimal) 18024,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000013",
                    Name = "@$RFS1000013N",
                    _catalogueId = "200",
                    Description = "@$RFS1000013D",
                    Price = (decimal) 29223,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000014",
                    Name = "@$RFS1000014N",
                    _catalogueId = "200",
                    Description = "@$RFS1000014D",
                    Price = (decimal) 14178,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000015",
                    Name = "@$RFS1000015N",
                    _catalogueId = "200",
                    Description = "@$RFS1000015D",
                    Price = (decimal) 7138,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000016",
                    Name = "@$RFS1000016N",
                    _catalogueId = "200",
                    Description = "@$RFS1000016D",
                    Price = (decimal) 138000,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000017",
                    Name = "@$RFS1000017N",
                    _catalogueId = "200",
                    Description = "@$RFS1000017D",
                    Price = (decimal) 3780,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000018",
                    Name = "@$RFS1000018N",
                    _catalogueId = "200",
                    Description = "@$RFS1000018D",
                    Price = (decimal) 2099,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000019",
                    Name = "@$RFS1000019N",
                    _catalogueId = "200",
                    Description = "@$RFS1000019D",
                    Price = (decimal) 1480,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.PhasingOut,

                },
                new Goods
                {
                    Id = "RFS1000020",
                    Name = "@$RFS1000020N",
                    _catalogueId = "200",
                    Description = "@$RFS1000020D",
                    Price = (decimal) 5598,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,

                },
                // end new

                // Washing Machines 300
                // Data Code Design:
                // new
                new Goods
                {
                    Id = "WMF1000001",
                    Name = "@$WMF1000001N",
                    _catalogueId = "300",
                    Description = "@$WMF1000001D",
                    Price = (decimal) 1998,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "WMF1000002",
                    Name = "@$WMF1000002N",
                    _catalogueId = "300",
                    Description = "@$WMF1000002D",
                    Price = (decimal) 8980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "WMF1000003",
                    Name = "@$WMF1000003N",
                    _catalogueId = "300",
                    Description = "@$WMF1000003D",
                    Price = (decimal) 32850,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "WMF1000004",
                    Name = "@$WMF1000004N",
                    _catalogueId = "300",
                    Description = "@$WMF1000004D",
                    Price = (decimal) 13482,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "WMF1000005",
                    Name = "@$WMF1000005N",
                    _catalogueId = "300",
                    Description = "@$WMF1000005D",
                    Price = (decimal) 3068,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "WMF1000006",
                    Name = "@$WMF1000006N",
                    _catalogueId = "300",
                    Description = "@$WMF1000006D",
                    Price = (decimal) 4480,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "WMF1000007",
                    Name = "@$WMF1000007N",
                    _catalogueId = "300",
                    Description = "@$WMF1000007D",
                    Price = (decimal) 6524,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "WMF1000008",
                    Name = "@$WMF1000008N",
                    _catalogueId = "300",
                    Description = "@$WMF1000008D",
                    Price = (decimal) 3980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                // end new
                new Goods
                {
                    Id = "WMF1000009",
                    Name = "@$WMF1000009N",
                    _catalogueId = "300",
                    Description = "@$WMF1000009D",
                    Price = (decimal) 6980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "WMF1000010",
                    Name = "@$WMF1000010N",
                    _catalogueId = "300",
                    Description = "@$WMF1000010D",
                    Price = (decimal) 4180,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                // new
                new Goods
                {
                    Id = "WMF1000011",
                    Name = "@$WMF1000011N",
                    _catalogueId = "300",
                    Description = "@$WMF1000011D",
                    Price = (decimal) 4388,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                new Goods
                {
                    Id = "WMF1000012",
                    Name = "@$WMF1000012N",
                    _catalogueId = "300",
                    Description = "@$WMF1000012D",
                    Price = (decimal) 4890,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                new Goods
                {
                    Id = "WMF1000013",
                    Name = "@$WMF1000013N",
                    _catalogueId = "300",
                    Description = "@$WMF1000013D",
                    Price = (decimal) 7865,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                new Goods
                {
                    Id = "WMF1000014",
                    Name = "@$WMF1000014N",
                    _catalogueId = "300",
                    Description = "@$WMF1000014D",
                    Price = (decimal) 5600,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                new Goods
                {
                    Id = "WMF1000015",
                    Name = "@$WMF1000015N",
                    _catalogueId = "300",
                    Description = "@$WMF1000015D",
                    Price = (decimal) 3508,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                new Goods
                {
                    Id = "WMF1000016",
                    Name = "@$WMF1000016N",
                    _catalogueId = "300",
                    Description = "@$WMF1000016D",
                    Price = (decimal) 3582,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                new Goods
                {
                    Id = "WMF1000017",
                    Name = "@$WMF1000017N",
                    _catalogueId = "300",
                    Description = "@$WMF1000017D",
                    Price = (decimal) 799,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                new Goods
                {
                    Id = "WMF1000018",
                    Name = "@$WMF1000018N",
                    _catalogueId = "300",
                    Description = "@$WMF1000018D",
                    Price = (decimal) 5980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                new Goods
                {
                    Id = "WMF1000019",
                    Name = "@$WMF1000019N",
                    _catalogueId = "300",
                    Description = "@$WMF1000019D",
                    Price = (decimal) 3890,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                new Goods
                {
                    Id = "WMF1000020",
                    Name = "@$WMF1000020N",
                    _catalogueId = "300",
                    Description = "@$WMF1000020D",
                    Price = (decimal) 4326,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                // end new

                // Air Conditioners 400
                // Data Code Design:
                // new
                new Goods
                {
                    Id = "ACS1000001",
                    Name = "@$ACS1000001N",
                    _catalogueId = "400",
                    Description = "@$ACS1000001D",
                    Price = (decimal) 5590,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000002",
                    Name = "@$ACS1000002N",
                    _catalogueId = "400",
                    Description = "@$ACS1000002D",
                    Price = (decimal) 7080,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000003",
                    Name = "@$ACS1000003N",
                    _catalogueId = "400",
                    Description = "@$ACS1000003D",
                    Price = (decimal) 9980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000004",
                    Name = "@$ACS1000004N",
                    _catalogueId = "400",
                    Description = "@$ACS1000004D",
                    Price = (decimal) 29060,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000005",
                    Name = "@$ACS1000005N",
                    _catalogueId = "400",
                    Description = "@$ACS1000005D",
                    Price = (decimal) 5298,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000006",
                    Name = "@$ACS1000006N",
                    _catalogueId = "400",
                    Description = "@$ACS1000006D",
                    Price = (decimal) 7870,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000007",
                    Name = "@$ACS1000007N",
                    _catalogueId = "400",
                    Description = "@$ACS1000007D",
                    Price = (decimal) 3622,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000008",
                    Name = "@$ACS1000008N",
                    _catalogueId = "400",
                    Description = "@$ACS1000008D",
                    Price = (decimal) 17820,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000009",
                    Name = "@$ACS1000009N",
                    _catalogueId = "400",
                    Description = "@$ACS1000009D",
                    Price = (decimal) 6012,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000010",
                    Name = "@$ACS1000010N",
                    _catalogueId = "400",
                    Description = "@$ACS1000010D",
                    Price = (decimal) 7298,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                // end new
                new Goods
                {
                    Id = "ACS1000011",
                    Name = "@$ACS1000011N",
                    _catalogueId = "400",
                    Description = "@$ACS1000011D",
                    Price = (decimal) 15580,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,

                },
                new Goods
                {
                    Id = "ACS1000012",
                    Name = "@$ACS1000012N",
                    _catalogueId = "400",
                    Description = "@$ACS1000012D",
                    Price = (decimal) 12990,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                // new
                new Goods
                {
                    Id = "ACS1000013",
                    Name = "@$ACS1000013N",
                    _catalogueId = "400",
                    Description = "@$ACS1000013D",
                    Price = (decimal) 6592,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000014",
                    Name = "@$ACS1000014N",
                    _catalogueId = "400",
                    Description = "@$ACS1000014D",
                    Price = (decimal) 11480,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000015",
                    Name = "@$ACS1000015N",
                    _catalogueId = "400",
                    Description = "@$ACS1000015D",
                    Price = (decimal) 4971,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000016",
                    Name = "@$ACS1000016N",
                    _catalogueId = "400",
                    Description = "@$ACS1000016D",
                    Price = (decimal) 9928,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000017",
                    Name = "@$ACS1000017N",
                    _catalogueId = "400",
                    Description = "@$ACS1000017D",
                    Price = (decimal) 8560,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000018",
                    Name = "@$ACS1000018N",
                    _catalogueId = "400",
                    Description = "@$ACS1000018D",
                    Price = (decimal) 12400,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000019",
                    Name = "@$ACS1000019N",
                    _catalogueId = "400",
                    Description = "@$ACS1000019D",
                    Price = (decimal) 4380,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "ACS1000020",
                    Name = "@$ACS1000020N",
                    _catalogueId = "400",
                    Description = "@$ACS1000020D",
                    Price = (decimal) 3299,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                },
                // end new

                // Home and Kitchen Appliances 500
                // new
                new Goods
                {
                    Id = "HKA1000001",
                    Name = "@$HKA1000001N",
                    _catalogueId = "500",
                    Description = "@$HKA1000001D",
                    Price = (decimal) 5340,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000002",
                    Name = "@$HKA1000002N",
                    _catalogueId = "500",
                    Description = "@$HKA1000002D",
                    Price = (decimal) 4050,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000003",
                    Name = "@$HKA1000003N",
                    _catalogueId = "500",
                    Description = "@$HKA1000003D",
                    Price = (decimal) 3980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000004",
                    Name = "@$HKA1000004N",
                    _catalogueId = "500",
                    Description = "@$HKA1000004D",
                    Price = (decimal) 3058,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000005",
                    Name = "@$HKA1000005N",
                    _catalogueId = "500",
                    Description = "@$HKA1000005D",
                    Price = (decimal) 2980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000006",
                    Name = "@$HKA1000006N",
                    _catalogueId = "500",
                    Description = "@$HKA1000006D",
                    Price = (decimal) 1580,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000007",
                    Name = "@$HKA1000007N",
                    _catalogueId = "500",
                    Description = "@$HKA1000007D",
                    Price = (decimal) 1298,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000008",
                    Name = "@$HKA1000008N",
                    _catalogueId = "500",
                    Description = "@$HKA1000008D",
                    Price = (decimal) 4200,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000009",
                    Name = "@$HKA1000009N",
                    _catalogueId = "500",
                    Description = "@$HKA1000009D",
                    Price = (decimal) 5020,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000010",
                    Name = "@$HKA1000010N",
                    _catalogueId = "500",
                    Description = "@$HKA1000010D",
                    Price = (decimal) 3942,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000011",
                    Name = "@$HKA1000011N",
                    _catalogueId = "500",
                    Description = "@$HKA1000011D",
                    Price = (decimal) 718,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000012",
                    Name = "@$HKA1000012N",
                    _catalogueId = "500",
                    Description = "@$HKA1000012D",
                    Price = (decimal) 1048,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling
                },
                // end new
                new Goods
                {
                    Id = "HKA1000013",
                    Name = "@$HKA1000013N",
                    _catalogueId = "500",
                    Description = "@$HKA1000013D",
                    Price = (decimal) 5990,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000014",
                    Name = "@$HKA1000014N",
                    _catalogueId = "500",
                    Description = "@$HKA1000014D",
                    Price = (decimal) 4990,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                },
                new Goods
                {
                    Id = "HKA1000015",
                    Name = "@$HKA1000015N",
                    _catalogueId = "500",
                    Description = "@$HKA1000015D",
                    Price = (decimal) 1999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000016",
                    Name = "@$HKA1000016N",
                    _catalogueId = "500",
                    Description = "@$HKA1000016D",
                    Price = (decimal) 368,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.PhasingOut,
                },
                new Goods
                {
                    Id = "HKA1000017",
                    Name = "@$HKA1000017N",
                    _catalogueId = "500",
                    Description = "@$HKA1000017D",
                    Price = (decimal) 1999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000018",
                    Name = "@$HKA1000018N",
                    _catalogueId = "500",
                    Description = "@$HKA1000018D",
                    Price = (decimal) 3999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling
                },
                // new
                new Goods
                {
                    Id = "HKA1000019",
                    Name = "@$HKA1000019N",
                    _catalogueId = "500",
                    Description = "@$HKA1000019D",
                    Price = (decimal) 758,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "HKA1000020",
                    Name = "@$HKA1000020N",
                    _catalogueId = "500",
                    Description = "@$HKA1000020D",
                    Price = (decimal) 39888,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling
                },
                // end new
                // Mobile and Communication Devices 600
                // new
                new Goods
                {
                    Id = "MCD1000001",
                    Name = "@$MCD1000001N",
                    _catalogueId = "600",
                    Description = "@$MCD1000001D",
                    Price = (decimal) 1899,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000002",
                    Name = "@$MCD1000002N",
                    _catalogueId = "600",
                    Description = "@$MCD1000002D",
                    Price = (decimal) 2680,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000003",
                    Name = "@$MCD1000003N",
                    _catalogueId = "600",
                    Description = "@$MCD1000003D",
                    Price = (decimal) 2698,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000004",
                    Name = "@$MCD1000004N",
                    _catalogueId = "600",
                    Description = "@$MCD1000004D",
                    Price = (decimal) 1598,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000005",
                    Name = "@$MCD1000005N",
                    _catalogueId = "600",
                    Description = "@$MCD1000005D",
                    Price = (decimal) 3699,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000006",
                    Name = "@$MCD1000006N",
                    _catalogueId = "600",
                    Description = "@$MCD1000006D",
                    Price = (decimal) 9688,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000007",
                    Name = "@$MCD1000007N",
                    _catalogueId = "600",
                    Description = "@$MCD1000007D",
                    Price = (decimal) 10988,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000008",
                    Name = "@$MCD1000008N",
                    _catalogueId = "600",
                    Description = "@$MCD1000008D",
                    Price = (decimal) 4798,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000009",
                    Name = "@$MCD1000009N",
                    _catalogueId = "600",
                    Description = "@$MCD1000009D",
                    Price = (decimal) 9980,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000010",
                    Name = "@$MCD1000010N",
                    _catalogueId = "600",
                    Description = "@$MCD1000010D",
                    Price = (decimal) 6599,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000011",
                    Name = "@$MCD1000011N",
                    _catalogueId = "600",
                    Description = "@$MCD1000011D",
                    Price = (decimal) 5499,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000012",
                    Name = "@$MCD1000012N",
                    _catalogueId = "600",
                    Description = "@$MCD1000012D",
                    Price = (decimal) 3698,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000013",
                    Name = "@$MCD1000013N",
                    _catalogueId = "600",
                    Description = "@$MCD1000013D",
                    Price = (decimal) 3999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000014",
                    Name = "@$MCD1000014N",
                    _catalogueId = "600",
                    Description = "@$MCD1000014D",
                    Price = (decimal) 8499,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000015",
                    Name = "@$MCD1000015N",
                    _catalogueId = "600",
                    Description = "@$MCD1000015D",
                    Price = (decimal) 3999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000016",
                    Name = "@$MCD1000016N",
                    _catalogueId = "600",
                    Description = "@$MCD1000016D",
                    Price = (decimal) 3380,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000017",
                    Name = "@$MCD1000017N",
                    _catalogueId = "600",
                    Description = "@$MCD1000017D",
                    Price = (decimal) 2199,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                // end new
                new Goods
                {
                    Id = "MCD1000018",
                    Name = "@$MCD1000018N",
                    _catalogueId = "600",
                    Description = "@$MCD1000018D",
                    Price = (decimal) 3799,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000019",
                    Name = "@$MCD1000019N",
                    _catalogueId = "600",
                    Description = "@$MCD1000019D",
                    Price = (decimal) 799,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000020",
                    Name = "@$MCD1000020N",
                    _catalogueId = "600",
                    Description = "@$MCD1000020D",
                    Price = (decimal) 1399,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000021",
                    Name = "@$MCD1000021N",
                    _catalogueId = "600",
                    Description = "@$MCD1000021D",
                    Price = (decimal) 7298,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "MCD1000022",
                                        Name = "@$MCD1000022N",
                    _catalogueId = "600",
                    Description = "@$MCD1000022D",
                    Price = (decimal) 7298,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },

                // Computer and Offices
                // new
                new Goods
                {
                    Id = "COF1000001",
                    Name = "@$COF1000001N",
                    _catalogueId = "700",
                    Description = "@$COF1000001D",
                    Price = (decimal) 22998,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000002",
                    Name = "@$COF1000002N",
                    _catalogueId = "700",
                    Description = "@$COF1000002D",
                    Price = (decimal) 6999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000003",
                    Name = "@$COF1000003N",
                    _catalogueId = "700",
                    Description = "@$COF1000003D",
                    Price = (decimal) 7480,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000004",
                    Name = "@$COF1000004N",
                    _catalogueId = "700",
                    Description = "@$COF1000004D",
                    Price = (decimal) 5888,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000005",
                    Name = "@$COF1000005N",
                    _catalogueId = "700",
                    Description = "@$COF1000005D",
                    Price = (decimal) 12998,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000006",
                    Name = "@$COF1000006N",
                    _catalogueId = "700",
                    Description = "@$COF1000006D",
                    Price = (decimal) 30899,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000007",
                    Name = "@$COF1000007N",
                    _catalogueId = "700",
                    Description = "@$COF1000007D",
                    Price = (decimal) 18998,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000008",
                    Name = "@$COF1000008N",
                    _catalogueId = "700",
                    Description = "@$COF1000008D",
                    Price = (decimal) 948,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000009",
                    Name = "@$COF1000009N",
                    _catalogueId = "700",
                    Description = "@$COF1000009D",
                    Price = (decimal) 3699,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000010",
                    Name = "@$COF1000010N",
                    _catalogueId = "700",
                    Description = "@$COF1000010D",
                    Price = (decimal) 14998,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000011",
                    Name = "@$COF1000011N",
                    _catalogueId = "700",
                    Description = "@$COF1000011D",
                    Price = (decimal) 1359,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000012",
                    Name = "@$COF1000012N",
                    _catalogueId = "700",
                    Description = "@$COF1000012D",
                    Price = (decimal) 729,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000013",
                    Name = "@$COF1000013N",
                    _catalogueId = "700",
                    Description = "@$COF1000013D",
                    Price = (decimal) 4498,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000014",
                    Name = "@$COF1000014N",
                    _catalogueId = "700",
                    Description = "@$COF1000014D",
                    Price = (decimal) 9999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000015",
                    Name = "@$COF1000015N",
                    _catalogueId = "700",
                    Description = "@$COF1000015D",
                    Price = (decimal) 2699,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000016",
                    Name = "@$COF1000016N",
                    _catalogueId = "700",
                    Description = "@$COF1000016D",
                    Price = (decimal) 21999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000017",
                    Name = "@$COF1000017N",
                    _catalogueId = "700",
                    Description = "@$COF1000017D",
                    Price = (decimal) 9398,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000018",
                    Name = "@$COF1000018N",
                    _catalogueId = "700",
                    Description = "@$COF1000018D",
                    Price = (decimal) 4598,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000019",
                    Name = "@$COF1000019N",
                    _catalogueId = "700",
                    Description = "@$COF1000019D",
                    Price = (decimal) 16998,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000020",
                    Name = "@$COF1000020N",
                    _catalogueId = "700",
                    Description = "@$COF1000020D",
                    Price = (decimal) 409,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000021",
                    Name = "@$COF1000021N",
                    _catalogueId = "700",
                    Description = "@$COF1000021D",
                    Price = (decimal) 1199,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000022",
                    Name = "@$COF1000022N",
                    _catalogueId = "700",
                    Description = "@$COF1000022D",
                    Price = (decimal) 899,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                // end new
                new Goods
                {
                    Id = "COF1000023",
                    Name = "@$COF1000023N",
                    _catalogueId = "700",
                    Description = "@$COF1000023D",
                    Price = (decimal) 18898,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000024",
                    Name = "@$COF1000024N",
                    _catalogueId = "700",
                    Description = "@$COF1000024D",
                    Price = (decimal) 15999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000025",
                    Name = "@$COF1000025N",
                    _catalogueId = "700",
                    Description = "@$COF1000025D",
                    Price = (decimal) 15999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000026",
                    Name = "@$COF1000026N",
                    _catalogueId = "700",
                    Description = "@$COF1000026D",
                    Price = (decimal) 15999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
                new Goods
                {
                    Id = "COF1000027",
                    Name = "@$COF1000027N",
                    _catalogueId = "700",
                    Description = "@$COF1000027D",
                    Price = (decimal) 15999,
                    GTINCode = GTINGenerator.L((++i).ToString()),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling
                },
            };
        }

        public static Supplier[] CreateSupplier()
        {
            return new Supplier[]
            {
                new Supplier
                {
                    ID = "001",
                    Name = "The Worst Limited",
                    Address = "123 Fake Street",
                    Phone = "123-123-1234",
                    Contact = "Mr. Fake",
                    Email = "supplier001@domain.com"
                },
                new Supplier
                {
                    ID = "002",
                    Name = "Good Luck Limited",
                    Address = "456 Fake Street",
                    Phone = "456-456-4567",
                    Contact = "Mr. Good",
                    Email = "supplier002@domain.com"
                },
                new Supplier
                {
                    ID = "003",
                    Name = "Best Limited",
                    Address = "789 Fake Street",
                    Phone = "789-789-7890",
                    Contact = "Mr. Best",
                    Email = "dfsf@domain.com"
                },
                new Supplier
                {
                    ID = "004",
                    Name = "Hongkong Hardware Supplier Ltd",
                    Address = ", Hongkong",
                    Phone = "898-898-898",
                    Contact = "Mr. Hongkong",
                    Email = "abc@domain.com"
                },
                new Supplier
                {
                    ID = "005",
                    Name = "China Ontrade (HK) Limited",
                    Address = "SDPL, TY, Hongkong",
                    Phone = "898-898-898",
                    Contact = "Mr. China",
                },
                new Supplier
                {
                    ID = "006",
                    Name = "IVE TY Limited",
                    Address = "20 Tsing Yi Road,Tsing Yi Island, New Territories",
                    Phone = "898-898-898",
                    Contact = "Miss. IVE TY",
                }
            };
        }

        public static Location[] CreateLocation()
        {
            return new Location[]
            {
                new Location
                {
                    Id = "001",
                    Loc = "Admin",
                    Name = "TY IVE"
                },
                new Location
                {
                    Id = "002",
                    Loc = "Room 10 ,10F ,9 Sheung Yuet Road, Kowloon Bay, Kowloon",
                    Name = "Head Office"
                },
                new Location
                {
                    Id = "003",
                    Loc = "59 Tai Yip Street Kowloon Bay Kolwoon, Hong Kong",
                    Name = "Kolwoon Warehouse"
                },
                new Location
                {
                    Id = "004",
                    Loc = "55 Chung On Street, Tsuen Wan 16/F, Emperor Plaza, Hong Kong",
                    Name = "TW Main Store"
                },
                new Location
                {
                    Id = "005",
                    Loc = "Unit 34 on Level 2 of MegaBox, Enterprise Square Five, 38 Wang Chiu Road, Kowloon Bay, Kowloon",
                    Name = "KB Store"
                }
            };
        }

        public static Warehouse[] CreateWarehouse()
        {
            return new Warehouse[]
            {
                new Warehouse
                {
                    ID = "001",
                    _locationID = "003"
                }
            };
        }

        public static Store[] CreateStore()
        {
            return new Store[]
            {
                new Store
                {
                    ID = "H01",
                    _locationID = "004"
                },
                new Store
                {
                    ID = "H02",
                    _locationID = "005"
                }
            };
        }

        public static Supplier_Goods[] CreateSupplier_Goods()
        {
            Supplier[] suppliers = CreateSupplier();
            int i = "100000030".ToInt();
            // get a random supplier
            return new Supplier_Goods[]
            {
                new Supplier_Goods
                {
                    ID = "100000000",
                    _supplierId = "001",
                    _goodsId = "ACS1000011",
                    Price = 15580
                },
                new Supplier_Goods
                {
                    ID = "100000001",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000012",
                    Price = 10990
                },
                new Supplier_Goods
                {
                    ID = "100000003",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000023",
                    Price = 15999
                },
                new Supplier_Goods
                {
                    ID = "100000004",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000024",
                    Price = 15999
                },
                new Supplier_Goods
                {
                    ID = "100000005",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000025",
                    Price = 15999
                },
                new Supplier_Goods
                {
                    ID = "100000006",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000026",
                    Price = 15999
                },
                new Supplier_Goods
                {
                    ID = "100000007",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000027",
                    Price = 15999
                },
                new Supplier_Goods
                {
                    ID = "100000008",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000013",
                    Price = 4990
                },
                new Supplier_Goods
                {
                    ID = "100000009",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000014",
                    Price = 4990
                },
                new Supplier_Goods
                {
                    ID = "100000010",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000015",
                    Price = 1899
                },
                new Supplier_Goods
                {
                    ID = "100000011",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000016",
                    Price = 300
                },
                new Supplier_Goods
                {
                    ID = "100000012",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000017",
                    Price = 1899
                },
                new Supplier_Goods
                {
                    ID = "100000013",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000018",
                    Price = 1899
                },
                new Supplier_Goods
                {
                    ID = "100000014",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000019",
                    Price = 700
                },
                new Supplier_Goods
                {
                    ID = "100000015",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000020",
                    Price = 700
                },
                new Supplier_Goods
                {
                    ID = "100000016",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000021",
                    Price = 6888
                },
                new Supplier_Goods
                {
                    ID = "100000017",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000022",
                    Price = 6888
                },
                new Supplier_Goods
                {
                    ID = "100000018",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000007",
                    Price = 7888
                },
                new Supplier_Goods
                {
                    ID = "100000019",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000008",
                    Price = 888
                },
                new Supplier_Goods
                {
                    ID = "100000020",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000001",
                    Price = 3888
                },
                new Supplier_Goods
                {
                    ID = "100000021",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000002",
                    Price = 3000
                },
                new Supplier_Goods
                {
                    ID = "100000022",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000003",
                    Price = 3888
                },
                new Supplier_Goods
                {
                    ID = "100000023",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000004",
                    Price = 3888
                },
                new Supplier_Goods
                {
                    ID = "100000024",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000005",
                    Price = 3888
                },
                new Supplier_Goods
                {
                    ID = "100000025",
                    _supplierId = "001",
                    _goodsId = "TVA0000006",
                    Price = 2888
                },
                new Supplier_Goods
                {
                    ID = "100000026",
                    _supplierId = "002",
                    _goodsId = "TVA0000006",
                    Price = 3798
                },
                new Supplier_Goods
                {
                    ID = "100000027",
                    _supplierId = "003",
                    _goodsId = "TVA0000006",
                    Price = 2500
                },
                new Supplier_Goods
                {
                    ID = "100000028",
                    _supplierId = "004",
                    _goodsId = "TVA0000006",
                    Price = 1203
                },
                new Supplier_Goods
                {
                    ID = "100000029",
                    _supplierId = "005",
                    _goodsId = "TVA0000006",
                    Price = 3999
                },
                new Supplier_Goods
                {
                    ID = "100000030",
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000018",
                    Price = 3888
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000018",
                    Price = 3888
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000009",
                    Price = 5980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000010",
                    Price = 4180
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000007",
                    Price = 5490
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000008",
                    Price = 5580
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000009",
                    Price = 5980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000010",
                    Price = 8980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000011",
                    Price = 1238
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000012",
                    Price = 4498
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000013",
                    Price = 320
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000014",
                    Price = 1690
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000015",
                    Price = 1490
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000016",
                    Price = 4980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000017",
                    Price = 5680
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000018",
                    Price = 1699
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000019",
                    Price = 648
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "TVA0000020",
                    Price = 19799
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000001",
                    Price = 11100
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000002",
                    Price = 3790
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000003",
                    Price = 19189
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000004",
                    Price = 9990
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000005",
                    Price = 4399
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000006",
                    Price = 15399
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000009",
                    Price = 2799
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000010",
                    Price = 26078
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000011",
                    Price = 5490
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000012",
                    Price = 18024
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000013",
                    Price = 29223
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000014",
                    Price = 14178
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000015",
                    Price = 7138
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000016",
                    Price = 138000
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000017",
                    Price = 3780
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000018",
                    Price = 2099
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000019",
                    Price = 1480
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "RFS1000020",
                    Price = 5598
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000001",
                    Price = 1998
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000002",
                    Price = 8980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000003",
                    Price = 32850
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000004",
                    Price = 13482
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000005",
                    Price = 3068
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000006",
                    Price = 4480
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000007",
                    Price = 6524
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000008",
                    Price = 3980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000011",
                    Price = 4388
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000012",
                    Price = 4890
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000013",
                    Price = 7865
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000014",
                    Price = 5600
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000015",
                    Price = 3508
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000016",
                    Price = 3582
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000017",
                    Price = 799
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000018",
                    Price = 5980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000019",
                    Price = 3890
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "WMF1000020",
                    Price = 4326
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000001",
                    Price = 5590
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000002",
                    Price = 7080
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000003",
                    Price = 9980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000004",
                    Price = 29060
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000005",
                    Price = 5298
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000006",
                    Price = 7870
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000007",
                    Price = 3622
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000008",
                    Price = 17820
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000009",
                    Price = 6012
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000010",
                    Price = 7298
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000013",
                    Price = 6592
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000014",
                    Price = 11480
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000015",
                    Price = 4971
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000016",
                    Price = 9928
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000017",
                    Price = 8560
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000018",
                    Price = 12400
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000019",
                    Price = 4380
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "ACS1000020",
                    Price = 3299
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000001",
                    Price = 5340
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000002",
                    Price = 4050
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000003",
                    Price = 3980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000004",
                    Price = 3058
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000005",
                    Price = 2980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000006",
                    Price = 1580
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000007",
                    Price = 1298
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000008",
                    Price = 4200
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000009",
                    Price = 5020
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000010",
                    Price = 3942
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000011",
                    Price = 718
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000012",
                    Price = 1048
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000019",
                    Price = 758
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "HKA1000020",
                    Price = 39888
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000001",
                    Price = 1899
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000002",
                    Price = 2680
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000003",
                    Price = 2698
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000004",
                    Price = 1598
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000005",
                    Price = 3699
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000006",
                    Price = 9688
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000007",
                    Price = 10988
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000008",
                    Price = 4798
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000009",
                    Price = 9980
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000010",
                    Price = 6599
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000011",
                    Price = 5499
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000012",
                    Price = 3698
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000013",
                    Price = 3999
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000014",
                    Price = 8499
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000015",
                    Price = 3999
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000016",
                    Price = 3380
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "MCD1000017",
                    Price = 2199
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000001",
                    Price = 22998
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000002",
                    Price = 6999
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000003",
                    Price = 7480
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000004",
                    Price = 5888
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000005",
                    Price = 12998
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000006",
                    Price = 30899
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000007",
                    Price = 18998
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000008",
                    Price = 948
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000009",
                    Price = 3699
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000010",
                    Price = 14998
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000011",
                    Price = 1359
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000012",
                    Price = 729
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000013",
                    Price = 4498
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000014",
                    Price = 9999
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000015",
                    Price = 2699
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000016",
                    Price = 21999
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000017",
                    Price = 9398
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000018",
                    Price = 4598
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000019",
                    Price = 16998
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000020",
                    Price = 409
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000021",
                    Price = 1199
                },
                new Supplier_Goods
                {
                    ID = (++i).ToString(),
                    _supplierId = suppliers[ran.Next(0, suppliers.Length)].ID,
                    _goodsId = "COF1000022",
                    Price = 899
                }
            };
        }

        public static Supplier_Goods_Stock[] CreateSupplier_Goods_Stock()
        {
            int i = "100000044".ToInt();
            return new Supplier_Goods_Stock[]
            {
                new Supplier_Goods_Stock
                {
                    Id = "100000001",
                    _locationId = "003",
                    _supplierGoodsId = "100000001",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000004",
                    _locationId = "003",
                    _supplierGoodsId = "100000003",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000005",
                    _locationId = "004",
                    _supplierGoodsId = "100000003",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000006",
                    _locationId = "005",
                    _supplierGoodsId = "100000003",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000007",
                    _locationId = "003",
                    _supplierGoodsId = "100000004",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000008",
                    _locationId = "004",
                    _supplierGoodsId = "100000004",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000009",
                    _locationId = "005",
                    _supplierGoodsId = "100000004",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000010",
                    _locationId = "003",
                    _supplierGoodsId = "100000005",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000011",
                    _locationId = "004",
                    _supplierGoodsId = "100000005",
                    Quantity = ran.Next(20,100),
                    MaxLimit = ran.Next(105, 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20, 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000012",
                    _locationId = "005",
                    _supplierGoodsId = "100000005",
                    Quantity = ran.Next(20,100),
                    MaxLimit = ran.Next(105, 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20, 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000013",
                    _locationId = "003",
                    _supplierGoodsId = "100000006",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000014",
                    _locationId = "004",
                    _supplierGoodsId = "100000006",
                    Quantity = ran.Next(20,100),
                    MaxLimit = ran.Next(105, 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20, 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000015",
                    _locationId = "005",
                    _supplierGoodsId = "100000006",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "110000097",
                    _locationId = "003",
                    _supplierGoodsId = "100000007",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000016",
                    _locationId = "004",
                    _supplierGoodsId = "100000007",
                    Quantity = ran.Next(20,100),
                    MaxLimit = ran.Next(105, 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20, 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000017",
                    _locationId = "005",
                    _supplierGoodsId = "100000007",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000018",
                    _locationId = "003",
                    _supplierGoodsId = "100000008",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000020",
                    _locationId = "003",
                    _supplierGoodsId = "100000009",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000021",
                    _locationId = "004",
                    _supplierGoodsId = "100000009",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000022",
                    _locationId = "005",
                    _supplierGoodsId = "100000009",
                    Quantity = ran.Next(20,100),
                    MaxLimit = ran.Next(105, 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20, 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000023",
                    _locationId = "003",
                    _supplierGoodsId = "100000010",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000024",
                    _locationId = "004",
                    _supplierGoodsId = "100000010",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000025",
                    _locationId = "005",
                    _supplierGoodsId = "100000010",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000026",
                    _locationId = "003",
                    _supplierGoodsId = "100000011",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000027",
                    _locationId = "004",
                    _supplierGoodsId = "100000011",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "110000099",
                    _locationId = "005",
                    _supplierGoodsId = "100000011",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000028",
                    _locationId = "003",
                    _supplierGoodsId = "100000012",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000029",
                    _locationId = "004",
                    _supplierGoodsId = "100000012",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000030",
                    _locationId = "005",
                    _supplierGoodsId = "100000012",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000031",
                    _locationId = "003",
                    _supplierGoodsId = "100000013",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000032",
                    _locationId = "004",
                    _supplierGoodsId = "100000013",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000033",
                    _locationId = "005",
                    _supplierGoodsId = "100000013",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000034",
                    _locationId = "003",
                    _supplierGoodsId = "100000014",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000035",
                    _locationId = "004",
                    _supplierGoodsId = "100000014",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000036",
                    _locationId = "005",
                    _supplierGoodsId = "100000014",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30),
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000037",
                    _locationId = "003",
                    _supplierGoodsId = "100000015",
                    Quantity = 0,
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = 11,
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000038",
                    _locationId = "003",
                    _supplierGoodsId = "100000030",
                    Quantity = 0,
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = 11,
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000039",
                    _locationId = "003",
                    _supplierGoodsId = "100000016",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000040",
                    _locationId = "004",
                    _supplierGoodsId = "100000016",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000041",
                    _locationId = "005",
                    _supplierGoodsId = "100000016",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000042",
                    _locationId = "003",
                    _supplierGoodsId = "100000017",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000043",
                    _locationId = "004",
                    _supplierGoodsId = "100000017",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = "100000044",
                    _locationId = "005",
                    _supplierGoodsId = "100000017",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000018",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000000",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000019",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000020",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000021",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000022",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000023",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000023",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000023",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000024",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000024",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000024",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000025",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000025",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000025",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000026",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000026",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000026",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000027",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000027",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000027",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000028",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000028",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000028",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000029",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000029",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000029",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000031",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000032",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000032",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000032",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000033",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000033",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000033",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000034",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000035",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000036",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000037",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000038",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000038",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000038",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000039",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000039",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000039",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000040",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000040",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000040",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000041",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000041",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000041",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000042",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000042",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000042",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000043",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000043",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000043",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000044",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000044",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000044",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000045",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000045",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000045",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000046",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000046",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000046",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000047",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000047",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000047",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000048",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000049",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000050",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000051",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000052",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000053",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000054",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000055",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000056",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000057",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000058",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000059",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000060",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000061",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000062",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000063",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000064",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000064",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000064",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000065",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000066",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000067",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000068",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000069",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000070",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000071",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000072",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000073",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000074",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000075",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000076",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000077",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000078",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000079",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000080",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000081",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000082",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000083",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000084",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000085",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000086",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000087",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000088",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000089",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000090",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000091",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000092",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000093",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000094",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000095",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000096",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000097",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000098",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000099",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000099",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000099",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000100",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000100",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000100",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000101",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000101",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000101",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000102",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000103",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000104",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000105",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000106",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000107",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000108",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000108",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000108",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000109",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000110",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000111",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000112",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000112",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000112",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000113",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000113",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000113",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000114",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000114",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000114",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000115",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000115",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000115",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000116",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000116",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000116",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000117",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000117",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000117",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000118",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000118",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000118",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000119",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000119",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000119",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000120",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000120",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000120",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000121",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000121",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000121",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000122",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000122",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000122",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000123",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000123",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000123",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000124",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000124",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000124",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000125",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000125",
                    Quantity = 23,
                    MaxLimit= 30,
                    MinLimit = 23,
                    ReorderLevel = 24
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000125",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000126",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000126",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000126",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000127",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000127",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000127",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000128",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000128",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000128",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000129",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000129",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000129",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000130",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000130",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000130",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000131",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000131",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000131",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000132",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000132",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000132",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000133",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000133",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000133",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000134",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000134",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000134",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000135",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000135",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000135",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000136",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000136",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000136",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000137",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000137",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000137",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000138",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000138",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000138",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000139",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000139",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000139",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000140",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000140",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000140",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000141",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000141",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000141",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000142",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000142",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000142",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000143",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000143",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000143",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000144",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000144",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000144",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000145",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000145",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000145",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000146",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000146",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000146",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000147",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000147",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000147",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000148",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000148",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000148",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000149",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000149",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000149",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000150",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000150",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000150",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000151",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000151",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000151",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000152",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000152",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000152",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000153",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000153",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000153",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "003",
                    _supplierGoodsId = "100000154",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "004",
                    _supplierGoodsId = "100000154",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                },
                new Supplier_Goods_Stock
                {
                    Id = (++i).ToString(),
                    _locationId = "005",
                    _supplierGoodsId = "100000154",
                    Quantity = ran.Next(20,100),
                    MaxLimit= ran.Next(105 , 120),
                    MinLimit = ran.Next(5, 20),
                    ReorderLevel = ran.Next(20 , 30)
                }
            };

        }

        public static List<SessionSetting> CreateSessionSetting()
        {
            return new List<SessionSetting>
            {
                new SessionSetting
                {
                    ID = "001",
                    StartTime = DateTime.Today.AddHours(9),
                    EndTime = DateTime.Today.AddHours(12),
                    NumOfAppointments = 5
                },
                new SessionSetting
                {
                    ID = "002",
                    StartTime = DateTime.Today.AddHours(13),
                    EndTime = DateTime.Today.AddHours(17),
                    NumOfAppointments = 5
                },
                new SessionSetting
                {
                    ID = "003",
                    StartTime = DateTime.Today.AddHours(18),
                    EndTime = DateTime.Today.AddHours(22),
                    NumOfAppointments = 5
                }
            };
        }


        public static List<Session> CreateSession(DataContext db)
        {


            List<SessionSetting> sessionRange = db.Set<SessionSetting>().ToList();
            List<Session> sessions = new List<Session>();

            int scounter = 0;
            // sessions.Add (new Session
            // {
            //     ID = "001"
            //     StartTime = sessionRange[scounter].StartTime,
            //     EndTime = sessionRange[scounter].EndTime,
            //     NumOfAppointments = sessionRange[scounter].NumOfAppointments,
            //     SessionSettingID = sessionRange[scounter].ID
            // });
            for (int i = 1; i < 188;)
            {
                if (scounter >= sessionRange.Count)
                    scounter = 0;
                i++;
                sessions.Add(
                    new Session
                    {
                        // padding the id with 0s automatically
                        ID = i.ToString("D9"),
                        _departmentId = "300",
                        StartTime = sessionRange[scounter].StartTime,
                        EndTime = sessionRange[scounter].EndTime,
                        Date = GenDate(),
                        NumOfAppointments = (sessionRange[scounter].NumOfAppointments)
                    }
                );
                i++;
                sessions.Add(
                    new Session
                    {
                        ID = i.ToString("D9"),
                        _departmentId = "700",
                        StartTime = sessionRange[scounter].StartTime,
                        EndTime = sessionRange[scounter].EndTime,
                        Date = GenDate(),
                        NumOfAppointments = (sessionRange[scounter].NumOfAppointments)
                    }
                );
                scounter++;
            }

            int invertCounter = 100000001;
            for ( int i = 0 ; i < 3 ; i++)
            {
                sessions.Add(
                    new Session
                    {
                        ID = (invertCounter++).ToString(),
                        _departmentId = "300",
                        StartTime = sessionRange[i].StartTime,
                        EndTime = sessionRange[i].EndTime,
                        Date = new DateTime(DateTime.Today.Year , DateTime.Today.Month , DateTime.Today.Day - 1),
                        NumOfAppointments = (sessionRange[scounter].NumOfAppointments)
                    }
                );

                sessions.Add(
                    new Session
                    {
                        ID = (invertCounter++).ToString(),
                        _departmentId = "700",
                        StartTime = sessionRange[i].StartTime,
                        EndTime = sessionRange[i].EndTime,
                        Date = new DateTime(DateTime.Today.Year , DateTime.Today.Month , DateTime.Today.AddDays(-1).Day),
                        NumOfAppointments = (sessionRange[scounter].NumOfAppointments)
                    }
                );
            }
            sessions.Add( // a specical session for demo purpose. To show the appointment is pending install service
                new Session
                {         
                    ID = "999999999",
                    _departmentId = "300",
                    StartTime = new DateTime(DateTime.Today.Year , DateTime.Today.Month , DateTime.Today.AddDays(-1).Day , DateTime.Now.AddHours(1).Hour , 0 , 0),
                    EndTime = new DateTime(DateTime.Today.Year , DateTime.Today.Month , DateTime.Today.AddDays(-1).Day , DateTime.Now.AddHours(2).Hour , 0 , 0),
                    Date = DateTime.Now,
                    NumOfAppointments = 1
                }
            );
            

            return sessions;
        }

        private static DateTime last = DateTime.Today;

        private static int counter = 0;

        public static DateTime GenDate()
        {
            if (counter >= 6)
            {
                last = last.AddDays(1);
                counter = 0;
            }
            counter++;

            return last;
        }

        public static Team[] CreateTeam()
        {
            return new Team[]
            {
                new Team
                {
                    ID = "301",
                    _departmentId = "300",
                    Name = "Delivery T1",
                },
                new Team
                {
                    ID = "302",
                    _departmentId = "300",
                    Name = "Delivery T2",
                },
                new Team
                {
                    ID = "303",
                    _departmentId = "300",
                    Name = "Delivery T3",
                },
                new Team
                {
                    ID = "304",
                    _departmentId = "300",
                    Name = "Delivery T4",
                },
                new Team
                {
                    ID = "305",
                    _departmentId = "300",
                    Name = "Delivery T5",
                },
                new Team
                {
                    ID = "701",
                    _departmentId = "700",
                    Name = "Installation T1",
                },
                new Team
                {
                    ID = "702",
                    _departmentId = "700",
                    Name = "Installation T2",
                },
                new Team
                {
                    ID = "703",
                    _departmentId = "700",
                    Name = "Installation T3",
                },
                new Team
                {
                    ID = "704",
                    _departmentId = "700",
                    Name = "Installation T4",
                },
                new Team
                {
                    ID = "705",
                    _departmentId = "700",
                    Name = "Installation T5",
                }
            };
        }

        public static void CreateGoodsPhoto(DataContext db)
        {
            string path = "resources/product/image";

            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + path))
            {
                Directory.Delete(AppDomain.CurrentDomain.BaseDirectory + path, true);
            }
            ConsoleLogger.Debug(AppDomain.CurrentDomain.BaseDirectory + path);
            Helpers.File.ZipHelper.Decompress("resources/product/image.zip", "resources/product");
            // get the all the files in the folder
            // FileInfo[] files = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + path).GetFiles();

            // List<Goods> goods = db.Set<Goods>().ToList();
            // for(int i = 0 ; i < files.Length && i < goods.Count; i++)
            // {
            //     // goods[i].Photo = Helpers.ByteArrayCompressor.Compress(File.ReadAllBytes(files[i].FullName));
            //     goods[i].Photo = File.ReadAllBytes(files[i].FullName);

            //     db.Set<Goods>().Update(goods[i]);
            //     db.SaveChanges();
            // }
            List<Goods> goods = db.Set<Goods>().ToList();


            foreach (Goods g in goods)
            {
                g.Photo = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + path + "/" + g.Id + ".png");
                db.Set<Goods>().Update(g);
                db.SaveChanges();
            }

            Directory.Delete(AppDomain.CurrentDomain.BaseDirectory + path, true);

        }
    }
}