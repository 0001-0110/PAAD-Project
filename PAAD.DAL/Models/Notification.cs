namespace PAAD.DAL.Models
{
    public class Notification : Model
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public int? AuthorId { get; set; }
        public virtual User? Author { get; set; }
        public int? CourseId { get; set; }
        public virtual Course? Course { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PublishedDateTime { get; set; }
        public DateTime ExpirationDateTime { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
