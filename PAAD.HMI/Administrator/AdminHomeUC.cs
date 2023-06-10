using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.HMI.Common;

namespace PAAD.HMI.Administrator
{
	public partial class AdminHomeUC : UserControl
	{
		private readonly IDependencyInjector _injector;
		private readonly IAuthenticationService _authenticationService;

		public AdminHomeUC(IDependencyInjector injector, IAuthenticationService authenticationService)
		{
			_injector = injector;
			_authenticationService = authenticationService;
			InitializeComponent();
			AddHeader();
		}

		private void AddHeader()
		{
			HeaderUC headerUC = _injector.Instantiate<HeaderUC>()!;
			headerUC.Dock = DockStyle.Top;
			Controls.Add(headerUC);
		}

		private void btnNotifs_Click(object sender, EventArgs e)
			=> showUC(_injector.Instantiate<AdminViewNotifsUC>()!);

		private void btnLecturers_Click(object sender, EventArgs e)
			=> showUC(_injector.Instantiate<AdminViewLecturersUC>()!);

		private void btnCourses_Click(object sender, EventArgs e)
			=> showUC(_injector.Instantiate<AdminViewCoursesUC>()!);

		private void showUC(UserControl userControl)
		{
			userControl.Dock = DockStyle.Fill;

			Parent.Controls.Add(userControl);
			Parent.Controls.Remove(this);

			Dispose();
		}
	}
}
