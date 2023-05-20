using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Administrator;
using PAAD.HMI.Lecturer;

namespace PAAD.HMI.Common
{
	public partial class CommonForm : Form
	{
		private IAuthenticationService _authenticationService;
		private IDependencyInjector _injector;
		public CommonForm(IDependencyInjector injector, IAuthenticationService authenticationService)
		{
			_injector = injector;
			_authenticationService = authenticationService;
			InitializeComponent();
			DisplayInitialView();
		}


		private void DisplayInitialView()
		{
			User user = _authenticationService.CurrentUser!;
			if(user is DAL.Models.Administrator)
			{
				AdminHomeUC adminHomeUC = _injector.Instantiate<AdminHomeUC>()!;
				adminHomeUC.Dock = DockStyle.Fill;

				this.Controls.Add(adminHomeUC);
			}
			else
			{
				LecturerViewNotifsUC lecturerViewNotifsUC = _injector.Instantiate<LecturerViewNotifsUC>()!;
				lecturerViewNotifsUC.Dock = DockStyle.Fill;

				this.Controls.Add(lecturerViewNotifsUC);
			}
		}
	}
}
