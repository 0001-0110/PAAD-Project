using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;

namespace PAAD.HMI.Common
{
    public partial class HeaderUC : UserControl
	{
		private readonly IDependencyInjector _injector;
		private readonly IAuthenticationService _authenticationService;
		private readonly IDataService _dataService;

		public HeaderUC(IDependencyInjector injector, IAuthenticationService authenticationService, IDataService dataService)
		{
			_injector = injector;
			_authenticationService = authenticationService;
			_dataService = dataService;
			InitializeComponent();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			_authenticationService.LogOut();
			FindForm().Close();
		}

		public void DisplayUser()
		{
			User user = _authenticationService.CurrentUser!;
			lbLecturerName.Text = $"{user.FirstName} {user.LastName}";

			if (user is DAL.Models.Lecturer lecturer)
				lbInfo.Text = lecturer.Course?.Name;
			else
				lbInfo.Text = "Administrator";
		}

		private void HeaderUC_Load(object sender, EventArgs e)
		{
			DisplayUser();
		}
	}
}
