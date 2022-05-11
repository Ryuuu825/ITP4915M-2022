using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data.Dto;

public class Staff
{
    [Key]
    [MaxLength(5)]
    [Column(TypeName = "char(5)")]
    public int Id {get; set; }

    public string FirstName { get; set; }

    public string lastName { get; set; }

    public Account acc { get; set; }
}