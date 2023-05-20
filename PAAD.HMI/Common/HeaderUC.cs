using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;

namespace PAAD.HMI.Common
{
	public partial class HeaderUC : UserControl
	{
		private readonly IAuthenticationService _authenticationService;
		private readonly IDependencyInjector _injector;
		private readonly IDataService _dataService;
		public HeaderUC(IAuthenticationService authenticationService, IDataService dataService,IDependencyInjector injector )
		{
			_authenticationService = authenticationService;
			_dataService = dataService;
			_injector = injector;
			InitializeComponent();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			((CommonForm)Parent.Parent).Dispose();
		}

		public void DisplayUser()
		{
			User user = _authenticationService.CurrentUser!;
			lbLecturerName.Text = $"{user.FirstName} {user.LastName}";

			if (user is DAL.Models.Lecturer lecturer)
			{
				lbInfo.Text = _dataService.GetById<Course>((int)lecturer.CourseId!)!.ToString();
			}
			else
				lbInfo.Text = "Administrator";
		}

		private void HeaderUC_Load(object sender, EventArgs e)
		{
			DisplayUser();
		}
	}
}
