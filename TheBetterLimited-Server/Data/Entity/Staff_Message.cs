namespace TheBetterLimited_Server.Data.Entity
{
    public class Staff_Message
    {
        [ForeignKey("message")]
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string _messageId { get; set; }

        public virtual Message message { get; set; }

        [ForeignKey("receiver")]
        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _receiverId { get; set; }

        public virtual Account receiver { get; set; }
    }
}