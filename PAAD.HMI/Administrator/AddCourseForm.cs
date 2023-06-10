using Microsoft.IdentityModel.Tokens;
using PAAD.HMI.Extensions;

namespace PAAD.HMI.Administrator
{
    public partial class AddCourseForm : Form
    {
        public string CourseName 
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        public AddCourseForm(string action)
        {
            InitializeComponent();
            DisplayText(action);

            lbName.SetValidator(textBox => !textBox.Text.IsNullOrEmpty(), "What were you expecting ?");
        }

        private void DisplayText(string action)
        {
            lbAction.Text = $"{action} course";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!this.IsFormValid())
                return;

            DialogResult = DialogResult.OK;
        }

        private void AddCourseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DisposeValidators();
        }
    }
}
