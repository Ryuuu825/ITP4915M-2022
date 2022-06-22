namespace TheBetterLimited_Server.Data.Dto
{
    public class PurchaseOrderDto
    {
        public string _warehouseId { get; set; }
        public string _supplierId { get; set; }
    }

    public class PurchaseOrderItemOutDto
    {
        public Hashtable Goods { get; set; }
        public int Quantity { get; set; }
    }

    public class PurchaseOrderItemInDto
    {
        public string _goodsId { get; set; }
        public int Quantity { get; set; }
        public int? Price { get; set; }
    }

    public class PurchaseOrderInDto : PurchaseOrderDto 
    {
        public List<PurchaseOrderItemInDto> Items { get; set; }
    }

     public class PurchaseOrderUpdateDto : PurchaseOrderInDto
    {
        public string Id { get; set; }
        public Data.Entity.PurchaseOrderStatus Status { get; set; }
    }

    public class PurchaseOrderOutDto : PurchaseOrderDto
    {
        public string Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string _operatorId { get; set; }
        public string _creatorId { get; set; }
        public Data.Entity.PurchaseOrderStatus Status { get; set; }
        public decimal Total { get; set; }
        public List<PurchaseOrderItemOutDto> Items { get; set; }
    }
}