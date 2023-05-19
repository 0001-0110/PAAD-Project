using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
				Utils.ShowError("Course name should not be empty");
			else
				DialogResult = DialogResult.OK;
		}
	}
}
