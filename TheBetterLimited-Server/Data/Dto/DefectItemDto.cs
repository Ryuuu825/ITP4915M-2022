namespace TheBetterLimited_Server.Data.Dto
{
    public class DefectItemDto
    {
        public string _supplierGoodsStockId { get; set; }
        public string _salesOrderId { get; set; }
        public Data.Entity.DefectItemHandleStatus HandleStatus { get; set; }
        public string _customerId { get; set; }
        public string Remark { get; set; }
    }
}