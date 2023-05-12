using PAAD.DAL.Models;

namespace PAAD.BLL.Services
{
    public interface IAuthenticationService
    {
        User? CurrentUser { get; }

        bool TryAuthenticate(string email, string password);
    }
}
