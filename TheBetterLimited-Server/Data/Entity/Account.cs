using System.ComponentModel;

namespace TheBetterLimited_Server.Data.Entity;

public class Account : Dto.Acc
{
    [Column(TypeName = "int(1)")]
    [Description("How many time the user fail to login")]
    public int LoginFailedCount { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [Description("The date when user login attempt failed")]
    public DateTime? LoginFailedAt { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime? LastLogin { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [Description("The time system unlock user account")]
    public DateTime? unlockDate { get; set; }
}