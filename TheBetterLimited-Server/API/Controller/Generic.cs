
using Microsoft.AspNetCore.Authorization;
using TheBetterLimited_Server.AppLogic.Controllers;
using TheBetterLimited_Server.Data;
namespace TheBetterLimited_Server.API.Controller
{
    public class Warehouse : APIControllerBase<Data.Entity.Warehouse>
    {
        public Warehouse(Data.DataContext db ) : base(db ) {}
    }

    public class Location : APIControllerBase<Data.Entity.Location>
    {
        public Location(Data.DataContext db) : base(db) {}
    }

    public class Supplier : APIControllerBase<Data.Entity.Supplier>
    {
        public Supplier(Data.DataContext db) : base(db) {}
    }

    public class Appointment : APIControllerBase<Data.Entity.Appointment>
    {
        public Appointment(Data.DataContext db) : base(db) {}
    }
    public class BookingOrder : APIControllerBase<Data.Entity.BookingOrder>
    {
        public BookingOrder(Data.DataContext db) : base(db) {}
    }
    public class Budget : APIControllerBase<Data.Entity.Budget>
    {
        public Budget (Data.DataContext db) : base(db) {}
    }
    public class Catalogue : APIControllerBase<Data.Entity.Catalogue>
    {
        public Catalogue (Data.DataContext db) : base(db) {}
    }
    public class Customer : APIControllerBase<Data.Entity.Customer>
    {
        public Customer(Data.DataContext db) : base(db) {}
    }
    public class DayOffRecord : APIControllerBase<Data.Entity.DayOffRecord>
    {
        public DayOffRecord(Data.DataContext db) : base(db) {}
    }

    public class Department : APIControllerBase<Data.Entity.Department>
    {
        public Department(Data.DataContext db) : base(db) {}
    }
    public class DefectItemRecord : APIControllerBase<Data.Entity.DefectItemRecord>
    {
        public DefectItemRecord(Data.DataContext db) : base(db) {}
    }
    public class DisplayItem : APIControllerBase<Data.Entity.DisplayItem>
    {
        public DisplayItem(Data.DataContext db) : base(db) {}
    }

    public class Menu : APIControllerBase<Data.Entity.Menu>
    {
        public Menu(Data.DataContext db) : base(db) {}
    }

    public class Permission : APIControllerBase<Data.Entity.Permission>
    {
        public Permission(Data.DataContext db) : base(db) {}
    }
    public class Position : APIControllerBase<Data.Entity.Position>
    {
        public Position(Data.DataContext db) : base(db) {}
    }
    public class PurchaseOrder_Supplier_Goods : APIControllerBase<Data.Entity.PurchaseOrder_Supplier_Goods>
    {
        public PurchaseOrder_Supplier_Goods(Data.DataContext db) : base(db) {}
    }
    public class PurchaseOrder : APIControllerBase<Data.Entity.PurchaseOrder>
    {
        public PurchaseOrder(Data.DataContext db) : base(db) {}
    }
    public class RestockRequest_Supplier_Goods : APIControllerBase<Data.Entity.RestockRequest_Supplier_Goods>
    {
        public RestockRequest_Supplier_Goods(Data.DataContext db) : base(db) {}
    }
    public class SalesOrder : APIControllerBase<Data.Entity.SalesOrder>
    {
        public SalesOrder(Data.DataContext db) : base(db) {}
    }
    public class SalesOrderItem : APIControllerBase<Data.Entity.SalesOrderItem>
    {
        public SalesOrderItem(Data.DataContext db) : base(db) {}
    }
    public class Staff : APIControllerBase<Data.Entity.Staff>
    {
        public Staff(Data.DataContext db) : base(db) {}
    }
    public class Session : APIControllerBase<Data.Entity.Session>
    {
        public Session(Data.DataContext db) : base(db) {}
    }

    public class Staff_Message : APIControllerBase<Data.Entity.Staff_Message>
    {
        public Staff_Message(Data.DataContext db) : base(db) {}
    }
    public class Store : APIControllerBase<Data.Entity.Store>
    {
        public Store(Data.DataContext db) : base(db) {}
    }
    public class Supplier_Goods : APIControllerBase<Data.Entity.Supplier_Goods>
    {
        public Supplier_Goods(Data.DataContext db) : base(db) {}
    }
    public class Supplier_Goods_Stock : APIControllerBase<Data.Entity.Supplier_Goods_Stock>
    {
        public Supplier_Goods_Stock(Data.DataContext db) : base(db) {}
    }
    public class Team : APIControllerBase<Data.Entity.Team>
    {
        public Team(Data.DataContext db) : base(db) {}
    }
    public class Transaction : APIControllerBase<Data.Entity.Transaction>
    {
        public Transaction(Data.DataContext db) : base(db) {}
    }




    
}