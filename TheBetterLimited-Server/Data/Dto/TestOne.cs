using System.ComponentModel;

namespace TheBetterLimited_Server.Data.Dto
{
    public class TestOne
    {
        [Required]
        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string Id { get; set; }

    }


}

