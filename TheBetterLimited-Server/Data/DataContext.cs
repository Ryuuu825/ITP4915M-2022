using TheBetterLimited_Server.API.Controllers;
using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder md)
    {
        md.Entity<Account>()
            .HasOne(a => a.Staff)
            .WithOne(s => s.acc)
            .HasForeignKey<Account>(a => a._StaffId);
        
        md.Entity<Staff>()
            .HasOne(s => s.acc)
            .WithOne(a => a.Staff)
            .HasForeignKey<Staff>(s => s._AccountId);
    }
    
    public DbSet<Account> accounts { get;  }
    public DbSet<Staff> staffs { get; }

}