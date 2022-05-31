namespace Domain.Entities
{
    public class Comments
    {
        public int Id { get; set; }
        public long SendDate { get; set; }
        public string? Alias { get; set; }
        public string? Subject { get; set; }
        public string? Content { get; set; }
        public string? Email { get; set; }
        public int RepliedTo { get; set; }
        public bool Unread { get; set; }
        public bool Status { get; set; }
    }
}