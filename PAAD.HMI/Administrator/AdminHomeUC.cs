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
		//=> _injector.Instantiate<AdminViewNotifForm>()!.ShowDialog();
		{
			AdminViewNotifsUC adminViewNotifsUC = _injector.Instantiate<AdminViewNotifsUC>()!;
			adminViewNotifsUC.Dock = DockStyle.Fill;

			Parent.Controls.Add(adminViewNotifsUC);
			Parent.Controls.Remove(this);
			Dispose();
		}

		private void btnLecturers_Click(object sender, EventArgs e)
		//=> new AdminViewLecturersForm().ShowDialog();
		{
			AdminViewLecturersUC adminViewLecturersUC = _injector.Instantiate<AdminViewLecturersUC>()!;
			adminViewLecturersUC.Dock = DockStyle.Fill;

			Parent.Controls.Add(adminViewLecturersUC);
			Parent.Controls.Remove(this);

			Dispose();
		}

		private void btnCourses_Click(object sender, EventArgs e)
		//=> new AdminViewCoursesForm(CurrentUser).ShowDialog();
		{
			AdminViewCoursesUC adminViewCoursesUC = _injector.Instantiate<AdminViewCoursesUC>()!;
			adminViewCoursesUC.Dock = DockStyle.Fill;

			Parent.Controls.Add(adminViewCoursesUC);
			Parent.Controls.Remove(this);

			Dispose();
		}
	}
}
