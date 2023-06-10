using PAAD.DAL.Models;

namespace PAAD.HMI.Administrator
{
    [Obsolete]
	public partial class AdminHeaderUC : UserControl
	{
		public AdminHeaderUC()
		{
			InitializeComponent();
		}

		public void DisplayUser(User user)
			=> lbLecturerName.Text = $"{user.FirstName} {user.LastName}";

		private void btnLogout_Click(object sender, EventArgs e)
			=> Application.Restart();
	}
}
