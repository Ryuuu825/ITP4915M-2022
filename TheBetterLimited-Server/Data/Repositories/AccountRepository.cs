using TheBetterLimited_Server.AppLogic.Exceptions;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Helpers.Entity;
using System.Reflection;

namespace TheBetterLimited_Server.Data.Repositories;

public class AccountRepository : Repository<Account>
{
    protected readonly DataContext DbContext;
    private DbSet<Staff> Staffs;
    private DbSet<Menu> Menus;
    private DbSet<Position> Positions;
    private DbSet<Permission> Permissions;
    private DbSet<Department> Departments;
    
    public AccountRepository(DataContext dbContext) : base(dbContext)
    {
        DbContext = dbContext;
        Staffs = DbContext.Set<Staff>();
    }

    public bool CreateUser(ref Account acc)
    {
        var staff = Staffs.Find(acc._StaffId);
        var checkKey = base.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"id:{acc.Id}" , "accounts")
        );
        var checkUserName = base.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"UserName:{acc.UserName}" , "accounts")
        );

        if ( acc._StaffId is not null && staff is null) // No foreign key match
        {
            throw new BadArgException("Staff is not exist in database.");
        }
        else if (checkKey.Count != 0 || checkUserName.Count != 0) // a staff can only has one account only, with unique id and user name
        {
            throw new BadArgException("The staff already have a account");
        }
        else if (staff is not null) // assign the staff obj to the acc
        {
            acc.Staff = staff;
            Console.WriteLine(staff.Debug());
        }

        return base.Add(acc);

    }

    // a recursive function to load all foreign key data from database
    // escape the recursion when there are no foreign key
    public void LoadForeignKeyData(object acc)
    {
        if (acc is null)
            return;

        // load all foreign key data from database
        foreach (var item in acc.GetType().GetProperties())
        {
            if (item.PropertyType == typeof(List<>))
            {
                DbContext.Entry(acc).Collection(item.Name).Load();
                foreach (var item2 in item.GetValue(acc) as List<object>)
                {
                    LoadForeignKeyData(item2);
                }
            }
            else if (item.PropertyType.IsClass && item.PropertyType != typeof(string))
            {
                ConsoleLogger.Debug($"{item.Name} is a class");
                DbContext.Entry(acc).Reference(item.Name).Load();
                LoadForeignKeyData(item.GetValue(acc));
            }
        }     
           
    }

    // load all foreign key data from database
    public void LoadUser(ref Account account)
    {
        // DbContext.Entry(account).Reference( a => a.Staff).Load();
        // DbContext.Entry(account.Staff).Reference(s => s.department).Load();
        // DbContext.Entry(account.Staff).Reference(s=>s.position).Load();


        LoadForeignKeyData(account);
        DbContext.Entry(account.Staff.position).Collection(p => p.permissions).Load();
        foreach (var permission in account.Staff.position.permissions)
        {
            DbContext.Entry(permission).Reference(p => p.menu).Load();
        }
        ConsoleLogger.Debug(account.Staff.Debug());
        ConsoleLogger.Debug(account.Staff.department.Debug());
        ConsoleLogger.Debug(account.Staff.position.Debug());


    }
}