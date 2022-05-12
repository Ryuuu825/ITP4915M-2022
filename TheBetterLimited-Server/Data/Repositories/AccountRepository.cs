using TheBetterLimited_Server.AppLogic.Exceptions;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Helpers.Entity;

namespace TheBetterLimited_Server.Data.Repositories;

public class AccountRepository : Repository<Account>
{
    protected readonly DataContext DbContext;
    private DbSet<Staff> Staffs;
    
    public AccountRepository(DataContext dbContext) : base(dbContext , dbContext.accounts)
    {
        Staffs = dbContext.staffs;
    }

    public bool CreateUser(ref Account acc)
    {
        var staff = Staffs.Find(acc._StaffId);
        var e = base.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"id:{acc.Id}" , "accounts")
        );

        if (acc._StaffId is not null && staff is null) // No foreign key match
        {
            throw new BadArgException("Staff is not exist in database.");
        }
        else if (e.Count != 0) // a staff has one account only
        {
            throw new BadArgException("The staff already have a account");
        }
        else if (staff is not null) // assign the staff obj to the acc
        {
            acc.Staff = staff;
            Console.WriteLine(staff.Debug());
        }

        if (base.IsRecordExist(acc.Id))
        {
            throw new DuplicateEntryException("Account ID is already exist ");
        }

        return base.Add(acc);

    }
}