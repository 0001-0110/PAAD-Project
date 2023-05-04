namespace PAAD.DAL.Models
{
    public class Notification : Model
    {
        public User Author { get; set; }
        public Course Course { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PublishedDateTime { get; set; }
        public DateTime ExpirationDateTime { get; set; }
    }
}
