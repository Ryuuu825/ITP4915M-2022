namespace TheBetterLimited_Server.Data.Entity;

public class Staff
{
    [Key]
    [MaxLength(5)]
    [Column(TypeName = "char(5)")]
    public string Id {get; set; }

    public string FirstName { get; set; }

    public string lastName { get; set; }

    public Account acc { get; set; }
}