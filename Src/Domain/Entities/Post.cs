namespace Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool Status { get; set; }
        public int OrderNo { get; set; }
        public string GetLink()=>$"Blog/{this.Id}";
    }
}