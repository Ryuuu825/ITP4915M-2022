namespace TheBetterLimited_Server.Data.Dto;

public class Many
{
    public int id { get; set; }
    public ICollection<ManyToMany> m { get; set; }
}