using TheBetterLimited_Server.API.Controllers;
using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        accounts = this.Set<Account>();
    }


    public DbSet<Account> accounts { get;  }
    
    public DbSet<TestOne> TestOnes { get; } 
}