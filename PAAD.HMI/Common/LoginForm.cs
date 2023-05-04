using PAAD.BLL.Services;
using PAAD.DAL.Models;

namespace PAAD_Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSubmitLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (!AuthenticationService.Instance.TryAuthenticate(tbEmail.Text, tbPassword.Text))
                return;

            // Authentication success
            // TODO Go to the next screen
        }
    }
}
