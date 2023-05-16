namespace PAAD.DAL.Models
{
    public class Course : Model
    {
        public string Name { get; set; }

        public virtual IEnumerable<Student> Students { get; set; }
        public virtual IEnumerable<Lecturer> Lecturers { get; set; }
        public virtual IEnumerable<Notification> Notifications { get; set; }

        public override string? ToString()
            => Name;
    }
}
