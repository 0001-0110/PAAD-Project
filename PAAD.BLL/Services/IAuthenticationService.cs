using PAAD.DAL.Models;

namespace PAAD.BLL.Services
{
    public interface IAuthenticationService
    {
        Action OnLogOut { get; set; }
        User? CurrentUser { get; }

        bool TryAuthenticate(string email, string password);
        void LogOut();
    }
}
