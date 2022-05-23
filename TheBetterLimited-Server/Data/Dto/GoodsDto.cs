using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data.Dto
{
    public class GoodsDto
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set;}

        [MaxLength(5)]
        public string _catalogueId { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        public double Price { get; set; }

        [MaxLength(15)]
        public string? GTINNode { get; set; }

        public GoodsSize? Size { get; set; }

        public GoodsStatus Status { get; set; }

        public short PhotoAmt {get ; set;}
    }
}