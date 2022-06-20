namespace TheBetterLimited_Server.Data.Dto
{
    public class DefectItemDto
    {
        public string _supplierGoodsStockId { get; set; }
        public string _salesOrderId { get; set; }
        public Data.Entity.DefectItemHandleStatus HandleStatus { get; set; }
        public CustomerDto Customer { get; set; }
        public string Remark { get; set; }
        public int Qty { get; set; }
    }


    public class DefectItemOutDto : DefectItemDto
    {
        public string Id { get; set; }
        public string _creatorId { get; set; }
        public string _operatorId { get; set; }
        public string Status { get; set ; }
        public string GoodsName { get; set; }
        public string CollectAddress { get; set; }
        public string? StoreName { get; set; }
        public Hashtable Supplier { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime OperatedAt { get; set; }
        public int Qty { get; set; }

    }

    public class DefectItemUpdateStatusDto
    {
        public string Id { get; set; }
        public Data.Entity.DefectItemRecordStatus Status { get; set; }
    }
}