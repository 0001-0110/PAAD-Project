using PAAD.BLL.Utilities;
using PAAD.DAL.Models;
using System.Security.Cryptography;

namespace PAAD.BLL.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IDataService dataService;
        private HashAlgorithm hashAlgorithm;

        public Action OnLogOut { get; set; }
        public User? CurrentUser { get; private set; }

        public AuthenticationService(IDataService dataService, HashAlgorithm hashAlgorithm)
        {
            this.dataService = dataService;
            this.hashAlgorithm = hashAlgorithm;
        }

        public bool TryAuthenticate(string email, string password)
        {
            // Find the correct user
            User? user = dataService.GetAllUsers().FirstOrDefault(user => user.Email == email);
            // If the email or the password is incorrect, authentication fails
            if (user == null || !SecurityUtility.VerifyPassword(password, user.PasswordHash, hashAlgorithm))
                return false;

            // Else, register the current user
            CurrentUser = user;
            return true;
        }

        public void LogOut()
        {
            CurrentUser = null;
            OnLogOut.Invoke();
        }
    }
}
