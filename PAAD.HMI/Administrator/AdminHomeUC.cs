using InversionOfControl;
using PAAD.BLL.Services;

namespace PAAD.HMI.Administrator
{
	public partial class AdminHomeUC : UserControl
	{
		private readonly IDependencyInjector _injector;
		private readonly IAuthenticationService _authenticationService;
		public AdminHomeUC(IDependencyInjector injector, IAuthenticationService authenticationService)
		{
			InitializeComponent();
			_injector = injector;
			_authenticationService = authenticationService;
			AddHeader((DAL.Models.Administrator)_authenticationService.CurrentUser!);

		}

		private void AddHeader(DAL.Models.Administrator user)
		{
			AdminHeaderUC headerUC = new AdminHeaderUC();
			//HeaderUC headerUC = new HeaderUC(IDataService dataService)
			headerUC.DisplayUser(user);
		}

		private void btnNotifs_Click(object sender, EventArgs e)
			=> _injector.Instantiate<AdminViewNotifForm>()!.ShowDialog();
		//	  =>  

		private void btnLecturers_Click(object sender, EventArgs e)
		//=> new AdminViewLecturersForm().ShowDialog();
		{
			AdminViewLecturersUC adminViewLecturersUC = _injector.Instantiate<AdminViewLecturersUC>()!;
			adminViewLecturersUC.Dock = DockStyle.Fill;

			Parent.Controls.Add(adminViewLecturersUC);
			Parent.Controls.Remove(this);

			this.Dispose();
		}

		private void btnCourses_Click(object sender, EventArgs e)
		//=> new AdminViewCoursesForm(CurrentUser).ShowDialog();
		{
			AdminViewCoursesUC adminViewCoursesUC = _injector.Instantiate<AdminViewCoursesUC>()!;
			adminViewCoursesUC.Dock = DockStyle.Fill;

			Parent.Controls.Add(adminViewCoursesUC);
			Parent.Controls.Remove(this);

			this.Dispose();
		}
	}
}

