namespace PAAD.DAL.Models
{
    // This class is unused for now
    // (But I don't know anything better than obsolete to mark that)
    [Obsolete]
    internal class Student : User
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
