using TheBetterLimited_Server.Data.Entity;
namespace TheBetterLimited_Server.Data.Dto
{
    public class GoodsDto
    {
        
    }

    public class GoodsOutDto 
    {
        public string GoodsId { get; set; }
        public string Catalogue { get; set; }
        public string GTINCode { get; set; }
        public decimal Price { get; set; }
        public GoodsSize? GoodsSize { get; set;}
        public GoodsStockOutDto StockLevel { get; set; }
        public GoodsStatus GoodsStatus { get; set; }
        public string Description { get; set; }
    }

    public class GoodsStockOutDto 
    {
        public class GoodsWarehouseStockOutDto
        {
            public string Location { get; set; }
            public int Stock { get; set; }
        }
        public int InStoreStock { get; set;}
        public List<GoodsWarehouseStockOutDto> WarehouseStock { get ; set;}
    }

    
}