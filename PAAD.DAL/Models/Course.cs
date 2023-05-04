namespace PAAD.DAL.Models
{
    internal class Course : Model
    {
        public string Name { get; set; }

        public virtual IEnumerable<Lecturer> Lecturers { get; set; }
        public virtual IEnumerable<Notification> Notifications { get; set; }
    }
}
