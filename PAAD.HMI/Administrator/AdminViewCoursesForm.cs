namespace PAAD.HMI.Administrator
{
    public partial class AdminViewCoursesForm : Form
    {


        private DAL.Models.Administrator CurrentUser;

        [Obsolete]
        public AdminViewCoursesForm(DAL.Models.Administrator user)
        {
            InitializeComponent();
            CurrentUser = user;
            adminHeaderUC.DisplayUser(user);
        }

        private void AdminViewCoursesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
