using PAAD.HMI.Utilities;

namespace PAAD.HMI.Administrator
{
    public partial class AddCourseForm : Form
	{
		public AddCourseForm(string action)
		{
			InitializeComponent();
			DisplayText(action);
		}

		private void DisplayText(string action)
		{
			lbAction.Text = $"{action} course";
		}

		public string GetName()
			=> tbName.Text;

		internal void SetName(string initialName)
		{
			tbName.Text = initialName;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (tbName.Text == "")
				MessageBoxUtility.ShowError("Course name should not be empty");
			else
				DialogResult = DialogResult.OK;
		}
	}
}
