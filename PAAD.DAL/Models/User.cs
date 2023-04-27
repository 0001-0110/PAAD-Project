namespace PAAD.DAL.Models
{
    internal abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // TODO Is this the right way to handle this thing ?
        public string Password { get; set; }
    }
}
