using TheBetterLimited_Server.API.Controllers;
using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace TheBetterLimited_Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder
        .UseLazyLoadingProxies()
        .UseMySql(
            _Secret["ConnectionString"],
            ServerVersion.AutoDetect(_Secret["ConnectionString"])
        );
    
    protected override void OnModelCreating(ModelBuilder md)
    {
        // md.Entity<Account>()
        //     .HasOne(a => a.Staff)
        //     .WithOne(s => s.acc)
        //     .HasForeignKey<Account>(a => a._StaffId);
        
        // md.Entity<Staff>()
        //     .HasOne(s => s.acc)
        //     .WithOne(a => a.Staff)
        //     .HasForeignKey<Staff>(s => s._AccountId);
        
        // set two foreign key in permission table as the primary key
        md.Entity<Permission>()
            .HasKey(p => new { p._menuId, p._positionId });
        
        md.Entity<Staff>()
            .HasCheckConstraint("staff_age_check", "age >= 18 and age <= 60");

    }
    
    public DbSet<Account> accounts { get;  }
    public DbSet<Staff> staffs { get; }

    public DbSet<Menu> menus { get; }
    public DbSet<Position> positions { get; }
    public DbSet<Permission> permissions { get; }
    public DbSet<Department> departments { get; }
    

}