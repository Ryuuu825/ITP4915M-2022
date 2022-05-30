using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Helpers;


namespace TheBetterLimited_Server.Data
{
    public static class DummyDataFactory
    {
        public static async Task Create(DataContext db)
        {
            try
            {

                db.Set<Department>().AddRange(CreateDepartment());
                db.Set<Staff>().AddRange(CreateStaff());
                db.Set<Position>().AddRange(CreatePosition());
                db.Set<Catalogue>().AddRange(CreateCatalogue());
                db.Set<Goods>().AddRange(CreateGoods());
                // db.Set<Supplier>().AddRange(CreateSupplier());
                db.SaveChanges();

                using (Repositories.AccountRepository _userTable = new Repositories.AccountRepository(db))
                {
                    var accs =  CreateAccount();
                    foreach(var acc in accs)
                    {
                        var entity = acc;
                        _userTable.CreateUser(ref entity);
                    }
                }
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
                    Age = 18
                },
                new Staff()
                {
                    Id = "S0002",
                    _departmentId = "010",
                    _positionId = "001",
                    FirstName = "Admin1",
                    LastName = "Pan",
                    Sex = 'M',
                    Age = 18
                },
                new Staff()
                {
                    Id = "S0003",
                    _departmentId = "999",
                    _positionId = "999",
                    FirstName = "Freerider",
                    LastName = "Leung",
                    Sex = 'M',
                    Age = 20
                },
                new Staff()
                {
                    Id = "S0004",
                    _departmentId = "010",
                    _positionId = "001",
                    FirstName = "Admin2",
                    LastName = "Lam",
                    Sex = 'M',
                    Age = 20
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
                    Age = 30
                },
                new Staff
                {
                    Id = "S0206",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Sex = 'F',
                    Age = 30
                },
                new Staff
                {
                    Id = "S0207",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Joe",
                    LastName = "Chan",
                    Sex = 'M',
                    Age = 20
                },
                new Staff 
                {
                    Id = "S0208",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Sophia",
                    LastName = "Wu",
                    Sex = 'F',
                    Age = 19
                },
                // two sales manager
                new Staff 
                {
                    Id = "S0299",
                    _departmentId = "200",
                    _positionId = "202",
                    FirstName = "Tom",
                    LastName = "Lee",
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
                    Age = 33
                },
                new Staff
                {
                    Id = "S0302",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "Watame",
                    LastName = "Tsunomaki",
                    Sex = 'F',
                    Age = 18
                },
                new Staff
                {
                    Id = "S0303",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Joey",
                    LastName = "Chan",
                    Sex = 'F',
                    Age = 20
                },
                new Staff 
                {
                    Id = "S0304",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Athena",
                    LastName = "Lam",
                    Sex = 'F',
                    Age = 19
                },
                new Staff 
                {
                    Id = "S0305",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Coco",
                    LastName = "Lam",
                    Sex = 'F',
                    Age = 19
                },
                new Staff 
                {
                    Id = "S0306",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Yanny",
                    LastName = "Lam",
                    Sex = 'F',
                    Age = 19
                },
                new Staff
                {
                    Id = "S0307",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Selena",
                    LastName = "Kim",
                    Sex = 'F',
                    Age = 20
                },
                new Staff 
                {
                    Id = "S0308",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Jenny",
                    LastName = "Lam",
                    Sex = 'F',
                    Age = 56
                },
                new Staff
                {
                    Id = "S0309",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Mia",
                    LastName = "Wong",
                    Sex = 'F',
                    Age = 27
                },
                new Staff
                {
                    Id = "S0310",
                    _departmentId = "200",
                    _positionId = "201",
                    FirstName = "May",
                    LastName = "Wong",
                    Sex = 'F',
                    Age = 18
                },
                new Staff
                {
                    Id = "S0311",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Ian",
                    LastName = "Lai",
                    Sex = 'M',
                    Age = 20
                },
                new Staff 
                {
                    Id = "S0312",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Justin",
                    LastName = "Ng",
                    Sex = 'M',
                    Age = 19
                },
                new Staff
                {
                    Id = "S0313",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Jimmy",
                    LastName = "Lam",
                    Sex = 'M',
                    Age = 20
                },
                new Staff 
                {
                    Id = "S0314",
                    _departmentId = "300",
                    _positionId = "301",
                    FirstName = "Revees",
                    LastName = "Lai",
                    Sex = 'F',
                    Age = 27
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
                    Age = 43
                }


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
            // Data Code Design for all type of goods:
            // First three digits is reserved to represent the charactistic of the goods
            // Last Seven digits is the sequence number of the goods

            return new List<Goods>(30)
            {
                new Goods
                {
                    Id = "TVA0000001",
                    Name = "@$TVA0000001N",
                    _catalogueId = "100",
                    Description = "@$TVA0000001D",
                    Price = (decimal) 4550,
                    GTINNode = GTINGenerator.L("00001"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                },
                new Goods
                {
                    Id = "TVA0000002",
                    Name = "@$TVA0000002N",
                    _catalogueId = "100",
                    Description = "@$TVA0000002D",
                    Price = (decimal) 3950,
                    GTINNode = GTINGenerator.L("00002"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                },
                new Goods 
                {
                    Id = "TVA0000003",
                    Name = "@$TVA0000003N",
                    _catalogueId = "100",
                    Description = "@$TVA0000003D",
                    Price = (decimal) 7080,
                    GTINNode = GTINGenerator.L("00003"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                },
                new Goods
                {
                    Id = "TVA0000004",
                    Name = "@$TVA0000004N",
                    _catalogueId = "100",
                    Description = "@$TVA0000004D",
                    Price = (decimal) 116980,
                    GTINNode = GTINGenerator.L("10004"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                },
                new Goods
                {
                    Id = "TVA0000005",
                    Name = "@$TVA0000005N",
                    _catalogueId = "100",
                    Description = "@$TVA0000005D",
                    Price = 6399,
                    GTINNode = GTINGenerator.L("10005"),    
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                },
                new Goods 
                {
                    Id = "TVA0000006",
                    Name = "@$TVA0000006N",
                    _catalogueId = "100",
                    Description = "@$TVA0000006D",
                    Price = (decimal) 3199,
                    GTINNode = GTINGenerator.L("10006"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                },

                //  Refrigerators and Freezers 200
                new Goods
                {
                    Id = "RFS1000007",
                    Name = "@$RFS1000007N",
                    _catalogueId = "200",
                    Description = "@$RFS1000007D",
                    Price = (decimal) 7814,
                    GTINNode = GTINGenerator.L("10007"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                },
                new Goods 
                {
                    Id = "RFS1000008",
                    Name = "@$RFS1000008N",
                    _catalogueId = "200",
                    Description = "@$RFS1000008D",
                    Price = (decimal) 2599,
                    GTINNode = GTINGenerator.L("10008"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.PhasingOut,
                    PhotoAmt = 0
                },

                // Washing Machines 300
                // Data Code Design:
                new Goods
                {
                    Id = "WMF1000009",
                    Name = "@$WMF1000009N",
                    _catalogueId = "300",
                    Description = "@$WMF1000009D",
                    Price = (decimal) 5980,
                    GTINNode = GTINGenerator.L("10009"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                },
                new Goods
                {
                    Id = "WMF1000010",
                    Name = "@$WMF1000010N",
                    _catalogueId = "300",
                    Description = "@$WMF1000010D",
                    Price = (decimal) 4180,
                    GTINNode = GTINGenerator.L("100010"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.StopSelling,
                    PhotoAmt = 0
                },

                // Air Conditioners 400
                // Data Code Design:
                new Goods
                {
                    Id = "ACS1000011",
                    Name = "@$ACS1000011N",
                    _catalogueId = "400",
                    Description = "@$ACS1000011D",
                    Price = (decimal) 15580,
                    GTINNode = GTINGenerator.L("100011"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                },
                new Goods
                {
                    Id = "ACS1000012",
                    Name = "@$ACS1000012N",
                    _catalogueId = "400",
                    Description = "@$ACS1000012D",
                    Price = (decimal) 12990,
                    GTINNode = GTINGenerator.L("100012"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                },

                // Home and Kitchen Appliances 500
                new Goods
                {
                    Id = "HKA1000013",
                    Name = "@$HKA1000013N",
                    _catalogueId = "500",
                    Description = "@$HKA1000013D",
                    Price = (decimal) 5990,
                    GTINNode = GTINGenerator.L("100013"),
                    Size = GoodsSize.Large,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "HKA1000014",
                    Name = "@$HKA1000014N",
                    _catalogueId = "500",
                    Description = "@$HKA1000014D",
                    Price = (decimal) 4990,
                    GTINNode = GTINGenerator.L("100014"),
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
                    GTINNode = GTINGenerator.L("100015"),
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "HKA1000016",
                    Name = "@$HKA1000016N",
                    _catalogueId = "500",
                    Description = "@$HKA1000016D",
                    Price = (decimal) 368,
                    GTINNode = GTINGenerator.L("100016"),
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
                    GTINNode = GTINGenerator.L("100017"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                // Mobile and Communication Devices 600
                new Goods
                {
                    Id = "MCD1000018",
                    Name = "@$MCD1000018N",
                    _catalogueId = "600",
                    Description = "@$MCD1000018D",
                    Price = (decimal) 3799,
                    GTINNode = GTINGenerator.L("100018"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "MCD1000019",
                    Name = "@$MCD1000019N",
                    _catalogueId = "600",
                    Description = "@$MCD1000019D",
                    Price = (decimal) 799,
                    GTINNode = GTINGenerator.L("100019"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "MCD1000020",
                    Name = "@$MCD1000020N",
                    _catalogueId = "600",
                    Description = "@$MCD1000020D",
                    Price = (decimal) 1399,
                    GTINNode = GTINGenerator.L("100020"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "MCD1000021",
                    Name = "@$MCD1000021N",
                    _catalogueId = "600",
                    Description = "@$MCD1000021D",
                    Price = (decimal) 7298,
                    GTINNode = GTINGenerator.L("100021"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods
                {
                    Id = "MCD1000022",
                    Name = "@$MCD1000022N",
                    _catalogueId = "600",
                    Description = "@$MCD1000022D",
                    Price = (decimal) 7298,
                    GTINNode = GTINGenerator.L("100022"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },

                // Computer and Offices 
                new Goods 
                {
                    Id = "COF1000023",
                    Name = "@$COF1000023N",
                    _catalogueId = "700",
                    Description = "@$COF1000023D",
                    Price = (decimal) 18898,
                    GTINNode = GTINGenerator.L("100023"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                new Goods 
                {
                    Id = "COF1000024",
                    Name = "@$COF1000024N",
                    _catalogueId = "700",
                    Description = "@$COF1000024D",
                    Price = (decimal) 15999,
                    GTINNode = GTINGenerator.L("100024"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                                new Goods 
                {
                    Id = "COF1000025",
                    Name = "@$COF1000025N",
                    _catalogueId = "700",
                    Description = "@$COF1000025D",
                    Price = (decimal) 15999,
                    GTINNode = GTINGenerator.L("100025"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                                new Goods 
                {
                    Id = "COF1000026",
                    Name = "@$COF1000026N",
                    _catalogueId = "700",
                    Description = "@$COF1000026D",
                    Price = (decimal) 15999,
                    GTINNode = GTINGenerator.L("100026"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                },
                                new Goods 
                {
                    Id = "COF1000027",
                    Name = "@$COF1000027N",
                    _catalogueId = "700",
                    Description = "@$COF1000027D",
                    Price = (decimal) 15999,
                    GTINNode = GTINGenerator.L("100027"),
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                }
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

    }
}