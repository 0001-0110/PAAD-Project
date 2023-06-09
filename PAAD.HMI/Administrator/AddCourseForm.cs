using Microsoft.IdentityModel.Tokens;
using PAAD.HMI.Extensions;
using PAAD.HMI.Utilities;

namespace PAAD.HMI.Administrator
{
    public partial class AddCourseForm : Form
    {
        public string CourseName { get; set; }

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
    }
}
