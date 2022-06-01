using TheBetterLimited_Server.AppLogic.Exceptions;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Helpers.Entity;
using System.Reflection;

namespace TheBetterLimited_Server.Data.Repositories;

public class AccountRepository : Repository<Account>
{
    private readonly DataContext DbContext;
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


    public void CreateUser(ref Account acc)
    {
        var staff = Staffs.Find(acc._StaffId);

        // check if user name is exist
        var checkUserName = base.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"UserName:{acc.UserName}" )
        );

        if ( acc._StaffId is not null && staff is null) // No foreign key match
        {
            throw new BadArgException("Staff is not exist in database.");
        }
        else if (checkUserName.Count != 0) // a staff can only has one account only, with unique id and user name
        {
            throw new BadArgException("The username cannot be repeated.");
        }
        else if (staff is not null) // assign the staff obj to the acc
        {
            acc.Staff = staff;
        }

        base.Add(acc);
        staff._AccountId = acc.Id;

        Staffs.Update(staff);
        DbContext.SaveChanges();

    }

    
}