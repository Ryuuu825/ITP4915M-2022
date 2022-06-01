using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data.Dto
{
    public class OrderInDto
    {
        public SalesOrderDto SalesOrder { get; set; }
        public List<SalesOrderItemDto> SalesOrderItems { get; set;}
        public List<AppointmentDto>? Appointments { get; set; }
        public CustomerDto? Customer { get; set; }
    }

    public class SalesOrderDto
    {
        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string CreatorId { get; set; }

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string StoreId { get; set; }
    }

    public class SalesOrderItemDto
    {
        public string SupplierGoodsStockId { get; set; }
        public int Quantity { get; set; }
        public bool NeedDelivery { get; set; }
        public bool NeedInstall { get; set; }
        public bool NeedBooking { get; set; }
    }

    public class AppointmentDto
    {
        public string SessionId { get; set; }
        public string DepartmentId { get; set; }
    }

    public class CustomerDto
    {
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set;}

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }

        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; }
    }
}