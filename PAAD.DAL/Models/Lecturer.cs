namespace PAAD.DAL.Models
{
    public class Lecturer : User
    {
        public int? CourseId { get; set; }
        public virtual Course? Course { get; set; }
    }
}
