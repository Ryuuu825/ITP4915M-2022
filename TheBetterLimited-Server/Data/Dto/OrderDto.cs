using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data.Dto
{
    public class OrderOutDto 
    {
        /* { 
            orderItem : [ { item1 xxx} , { item 2 xxx} ] ,
             _creatorId : "" , 
             _operatorId : "" , 
             store : {} , 
             createAt : "" , 
             updateAt : "" , 
             Status : "Selling" , 
             total: 1000, 
             paid:800}
        
        */
        public List<SalesOrderItemOutDto> orderItems { get; set; }
        public string _creatorId { get; set; }
        public string _operatorId { get; set; }
        public Store store { get; set; }
        public DateTime createAt { get; set; }
        public DateTime updateAt { get; set; }
        public string status { get; set; }
        public decimal total { get; set; }
        public decimal paid { get; set; }
        public string Id { get ; set; }

    }




    public class OrderInDto
    {
        public List<SalesOrderItemInDto> SalesOrderItems { get; set;}
        public List<AppointmentDto>? Appointments { get; set; }
        public int? BookingDeposit { get; set; }
        public CustomerDto? Customer { get; set; }
    }



    public class SalesOrderItemInDto
    {
        public string SupplierGoodsStockId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public bool NeedDelivery { get; set; }
        public bool NeedInstall { get; set; }
        public bool NeedBooking { get; set; }
    }
    public class SalesOrderItemOutDto : SalesOrderItemInDto
    {
        public string Name { get; set; }
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