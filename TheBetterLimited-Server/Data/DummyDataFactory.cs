using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data
{
    public static class DummyDataFactory
    {
        public static async Task Create(DbContext db)
        {
            try
            {
                await db.Set<Staff>().AddRangeAsync(CreateStaff());
                await db.Set<Department>().AddRangeAsync(CreateDepartment());
                await db.Set<Account>().AddRangeAsync(CreateAccount());
                await db.Set<Position>().AddRangeAsync(CreatePosition());
                await db.Set<Catalogue>().AddRangeAsync(CreateCatalogue());
                await db.Set<Goods>().AddRangeAsync(CreateGoods());
                await db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                // user may already inserted the data before
                // so we just ignore the exception
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
                    _departmentId = "050",
                    _positionId = "002",
                    FirstName = "Freerider",
                    LastName = "Leung",
                    Sex = 'M',
                    Age = 20
                },
                new Staff()
                {
                    Id = "S0004",
                    _departmentId = "040",
                    _positionId = "003",
                    FirstName = "Admin2",
                    LastName = "Lam",
                    Sex = 'M',
                    Age = 20
                }

            };
        }   

        public static Department[] CreateDepartment()
        {
            return new Department[] 
            {
                new Department
                {
                    Id = "010",
                    Name = "Admin"
                },
                new Department
                {
                    Id = "020",
                    Name = "Public Relation"
                },
                new Department
                {
                    Id = "030",
                    Name = "Sales"
                },
                new Department
                {
                    Id = "040",
                    Name = "IT"
                },
                new Department
                {
                    Id = "050",
                    Name = "Freeride"
                }
            };
        }

        public static Account[] CreateAccount()
        {
            return new Account[]
            {
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
    
        public static Position[] CreatePosition()
        {
            return new Position[]
            {
                new Position
                {
                    Id = "001",
                    jobTitle = "Admin",
                    _departmentId = "010"
                },
                new Position
                {
                    Id = "002",
                    jobTitle = "Freerider",
                    _departmentId = "050"
                },
                new Position
                {
                    Id = "003",
                    jobTitle = "IT Manager",
                    _departmentId = "040"
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