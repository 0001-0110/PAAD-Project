namespace PAAD.DAL.Models
{
    public class Notification : Model
    {
        public int? AuthorId { get; set; }
        public virtual User? Author { get; set; }
        
        // TODO This should never be null, but dbContext is not happy otherwise
        public int? CourseId { get; set; }
        public virtual Course? Course { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PublishedDateTime { get; set; }
        public DateTime ExpirationDateTime { get; set; }
    }
}
