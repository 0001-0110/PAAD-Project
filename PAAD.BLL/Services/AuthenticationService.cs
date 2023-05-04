using PAAD.DAL.Models;

namespace PAAD.BLL.Services
{
    public class AuthenticationService
    {
        public static readonly AuthenticationService Instance = new AuthenticationService();

        public User? CurrentUser { get; private set; }

        private static string GetHash(string password)
        {
            throw new NotImplementedException("Flemme");

            /*// Generate a 128-bit salt using a sequence of
            // cryptographically strong random bytes.
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8); // divide by 8 to convert bits to bytes
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password!,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return hashed;*/
        }

        public bool TryAuthenticate(string email, string password)
        {
            // Find the correct user
            User? user = DataService.Instance.GetAllUsers().FirstOrDefault(user => user.Email == email);
            // If the user doesn't exist or the password is incorrect, authentication fails
            if (user == null || GetHash(password) != user.PasswordHash)
                return false;

            // Else, register the current user
            CurrentUser = user;
            return true;
        }
    }
}
