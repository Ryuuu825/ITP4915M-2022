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
        
        md.Entity<Permission>()
            .HasKey(p => new { p._menuId , p._positionId });
        
        md.Entity<Staff_Message>()
            .HasKey(sm => new { sm._messageId , sm._receiverId});
        
        md.Entity<PurchaseOrder_Supplier_Goods>()
            .HasKey(posg => new { posg._purchaseOrderId, posg._supplierGoodsId });
        
        md.Entity<RestockRequest_Supplier_Goods>()
            .HasKey(rsg => new { rsg._restockRequestId, rsg._supplierGoodsId });
        
        md.Entity<SalesOrderItem>()
            .HasKey(soi => new { soi._salesOrderId, soi._supplierGoodsStockId });
        
        md.Entity<Supplier_Goods>()
            .HasOne(sg => sg.Supplier)
            .WithMany(s => s.Supplier_Goods)
            .HasForeignKey(sg => sg._supplierId);

        md.Entity<Supplier_Goods_Stock>()
            .HasKey(sg => new { sg._supplierGoodsId, sg._locationId });

        md.Entity<DefectItemRecord>()
            .HasOne(d => d.SupplierGoodsStock)
            .WithMany(sgs => sgs.DefectItemRecords)
            .HasPrincipalKey(sgs => new { sgs._supplierGoodsId, sgs._locationId });
        
        md.Entity<Supplier_Goods_Stock>()
            .HasOne(sgs => sgs.Supplier_Goods)
            .WithMany(sg => sg.Supplier_Goods_Stocks)
            .HasPrincipalKey(sg => new {sg._goodsId , sg._supplierId});
        
        md.Entity<SalesOrderItem>()
            .HasOne(soi => soi.SupplierGoodsStock)
            .WithMany(sgs => sgs.SalesOrderItems)
            .HasPrincipalKey(sgs => new { sgs._supplierGoodsId, sgs._locationId });


        md.Entity<Staff>()
            .HasCheckConstraint("age_cc", "age >= 18 and age <= 60")
            .HasCheckConstraint("sex_cc" , "sex in ('M' , 'F') ");
        
    }
    
    // create dbset for all entity in TheBetterLimited.Data.Entity
    public DbSet<Account> account { get;  }
    public DbSet<Appointment> appointment {get; }
    public DbSet<BookingOrder> bookingOrder {get;}
    public DbSet<Budget> budget {get; }
    public DbSet<Catalogue> category {get; }
    public DbSet<Customer> customer {get; }
    public DbSet<DayOffRecord> dayOffRecord {get; }
    public DbSet<Department> department {get; }
    public DbSet<DefectItemRecord> defectItemRecord {get; }
    public DbSet<DisplayItem> displayItem {get; }
    public DbSet<Goods> goods {get; }
    public DbSet<Location> location {get; }
    public DbSet<Menu> menu {get; }
    public DbSet<Message> message {get; }
    public DbSet<Permission> permission {get; }
    public DbSet<Position> position {get; }
    public DbSet<PurchaseOrder_Supplier_Goods> purchaseOrder_Supplier_Goods {get; }
    public DbSet<PurchaseOrder> purchaseOrder {get; }
    public DbSet<RestockRequest_Supplier_Goods> restockRequest_Supplier_Goods {get; }
    public DbSet<SalesOrder> salesOrder {get; }
    public DbSet<SalesOrderItem> salesOrderItem {get; }
    public DbSet<Staff> staff {get; }
    public DbSet<Session> session {get; }
    public DbSet<Supplier> supplier {get; }
    public DbSet<Staff_Message> staff_Message {get; }
    public DbSet<Store> store {get; }
    public DbSet<Supplier_Goods> supplier_Goods {get; }
    public DbSet<Supplier_Goods_Stock> supplier_Goods_Stock {get; }
    public DbSet<Team> team {get; }
    public DbSet<Transaction> transaction {get; }
    public DbSet<Warehouse> warehouse {get; }







    

}