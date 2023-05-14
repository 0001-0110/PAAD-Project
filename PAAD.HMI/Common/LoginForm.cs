using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Administrator;
using PAAD.HMI.Lecturer;

namespace PAAD.HMI.Common
{
    public partial class LoginForm : Form
    {
        private IAuthenticationService authenticationService;
        public User CurrentUser;

        public LoginForm(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
            InitializeComponent();
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!authenticationService.TryAuthenticate(tbEmail.Text, tbPassword.Text))
                {
                    lbError.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex.Message);
                Environment.Exit(1);
            }

            // Authentication success
            CurrentUser = authenticationService.CurrentUser!;
            Close();
        }
    }
}
