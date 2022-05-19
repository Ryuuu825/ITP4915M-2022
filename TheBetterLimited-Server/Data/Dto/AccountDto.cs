using System.ComponentModel;
using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data.Dto;

public class AccountDto
{
    [Required]
    [MaxLength(5)]
    [Column(TypeName = "char(5)")]
    public string Id { get; set; }

    [Required]
    [MaxLength(10)]
    [Column(TypeName = "char(10)")]
    public string UserName { get; set; }

    [Required]
    [MaxLength(100)]
    [Column(TypeName = "varchar(100)")]
    [Description("The hashed password of the user account")]
    public string Password { get; set; }

    [Required]
    [EmailAddress]
    [Column(TypeName = "varchar(50)")]
    public string EmailAddress { get; set; }


    [Required]
    [MaxLength(1)]
    [RegularExpression("(O|N|L)")]
    [Column(TypeName = "char(1)")]
    public string Status { get; set; }

    [MaxLength(5)]
    [Column(TypeName = "char(5)")]
    public string _StaffId {get; set; }
    [Column(TypeName = "varchar(100)")] public string? Remarks { get; set; }
}

