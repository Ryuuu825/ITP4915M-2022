namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Message")]
    public class Message
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string Id { get; set; }

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _senderId { get; set; }

        [ForeignKey("_senderId")]
        public virtual Account sender { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Content { get; set; }

        public DateTime SentDate { get; set; }

    }
}