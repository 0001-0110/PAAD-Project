using PAAD.BLL.Services;

namespace PAAD.HMI.Common
{
    public partial class LoginForm : Form
    {
        private IAuthenticationService authenticationService;

        public LoginForm(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
            InitializeComponent();
        }

        private void btnSubmitLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (!authenticationService.TryAuthenticate(tbEmail.Text, tbPassword.Text))
            {
                lbError.Visible = true;
                return;
            }

            // Authentication success
            // TODO Go to the next screen
        }
    }
}
