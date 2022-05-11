using TheBetterLimited_Server.API.Controllers;
using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        accounts = this.Set<Account>();
        staffs = this.Set<Staff>();
    }

    protected override void OnModelCreating(ModelBuilder md)
    {
        md.Entity<Account>()
            .HasOne(a => a.Staff)
            .WithOne(s => s.acc)
            .HasForeignKey<Account>(a => a._StaffId);
    }
    
    public DbSet<Account> accounts { get;  }
    public DbSet<Staff> staffs { get; }

}