using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data
{
    public static class DummyDataFactory
    {
        public static async Task Create(DbContext db)
        {
            try
            {
                db.Set<Staff>().AddRange(CreateStaff());
                db.Set<Department>().AddRange(CreateDepartment());
                db.Set<Account>().AddRange(CreateAccount());
                db.Set<Position>().AddRange(CreatePosition());
                db.Set<Catalogue>().AddRange(CreateCatalogue());
                db.Set<Goods>().AddRange(CreateGoods());
                db.SaveChanges();
            }
            catch (Exception e)
            {
                // user may already inserted the data before
                // so we just ignore the exception
                ConsoleLogger.Debug(e.Message);
                ConsoleLogger.Debug(e.InnerException);

                ConsoleLogger.Debug("Please ignore the exception, you may already inserted the data before");
            }
            finally
            {
                db.Dispose();
                GC.SuppressFinalize(db);
            }
        }

        public static Staff[] CreateStaff()
        {
            return new Staff[]
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

        
        public static Account[] CreateAccount()
        {
            return new Account[]
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
            byte[] icon = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + @"/img/test.jpeg");
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
                    Name = "Washer",
                },
                new Catalogue
                {
                    Id = "020",
                    Name = "Computer"
                },
                new Catalogue
                {
                    Id = "030",
                    Name = "Cloth Dryers"
                },
                new Catalogue
                {
                    Id = "001",
                    Name = "Air Cooler"
                }
            };
        }

        public static Goods[] CreateGoods()
        {
            return new Goods[]
            {
                new Goods
                {
                    Id = "001",
                    _catalogueId = "100",
                    Name = "@$T0001",
                    Description = "@$T0002",
                    Price = 10000,
                    GTINNode = "12313131",
                    Size = GoodsSize.Small,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 1
                },
                new Goods
                {
                    Id = "002",
                    _catalogueId = "020",
                    Name = "@$T0003",
                    Description = "@$T0004",
                    Price = 10000,
                    GTINNode = "1231313112",
                    Size = GoodsSize.Medium,
                    Status = GoodsStatus.Selling,
                    PhotoAmt = 0
                }
            };
        }

    }
}