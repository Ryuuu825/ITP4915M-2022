using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data
{
    public static class DummyDataFactory
    {
        public static void Create(DbContext db)
        {
            var staff = new Staff[]
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

            };

            var department = new Department[] 
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
                }
            };
            

            var account = new Account[]
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
                }
            };

            var position = new Position[]
            {
                new Position
                {
                    Id = "001",
                    jobTitle = "Admin",
                    _departmentId = "010"
                }
            };

            var Catalog = new Catalogue[]
            {
                new Catalogue
                {
                    Id = "100",
                    Name = "Phone"
                },
                new Catalogue
                {
                    Id = "020",
                    Name = "Computer"
                }
            };

            var goods = new Goods[]
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




            try
            {
                db.Set<Staff>().AddRange(staff);
                db.Set<Department>().AddRange(department);
                db.Set<Account>().AddRange(account);
                db.Set<Position>().AddRange(position);
                db.Set<Catalogue>().AddRange(Catalog);
                db.Set<Goods>().AddRange(goods);
                db.SaveChanges();
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
            
    }
}