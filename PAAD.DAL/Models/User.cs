namespace PAAD.DAL.Models
{
    internal abstract class User : Model
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // TODO This might not be the right type
        public string PasswordHash { get; set; }

        public virtual IEnumerable<Notification> Notifications { get; set; }
    }
}
