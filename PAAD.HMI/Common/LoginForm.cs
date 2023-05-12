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

        private void btnSubmitLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (!authenticationService.TryAuthenticate(tbEmail.Text, tbPassword.Text))
            {
                lbError.Visible = true;
                return;
            }

            // Authentication success
            CurrentUser = authenticationService.CurrentUser!;
            Form mainForm;
            if (CurrentUser is PAAD.DAL.Models.Administrator)
                mainForm = new AdminHomeForm((DAL.Models.Administrator)CurrentUser);
            else
                mainForm = new LecturerViewNotifForm((DAL.Models.Lecturer)CurrentUser);

            Hide();
            mainForm.ShowDialog();
            Close();
        }
    }
}
