namespace PAAD.HMI.Administrator
{
    [Obsolete]
    public partial class AdminViewLecturersForm : Form
    {
        private DAL.Models.Administrator CurrentUser;

        public AdminViewLecturersForm(DAL.Models.Administrator user)
        {
            InitializeComponent();
            CurrentUser = user;
            adminHeaderUC.DisplayUser(user);
        }
    }
}
