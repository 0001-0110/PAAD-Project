namespace PAAD.DAL.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Lecturer> Lecturers { get; set; }
        public virtual IEnumerable<Notification> Notifications { get; set; }
    }
}
