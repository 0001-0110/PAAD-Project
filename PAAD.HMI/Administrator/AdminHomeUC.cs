using InversionOfControl;

namespace PAAD.HMI.Administrator
{
	public partial class AdminHomeUC : UserControl
	{
		private readonly IDependencyInjector _injector;
		private DAL.Models.Administrator CurrentUser;
		public AdminHomeUC(IDependencyInjector injector, DAL.Models.Administrator user)
		{
			InitializeComponent();
			_injector = injector;
			CurrentUser = user;
			AddHeader(CurrentUser);

		}

		private void AddHeader(DAL.Models.Administrator user)
		{
			AdminHeaderUC headerUC = new AdminHeaderUC();
			//HeaderUC headerUC = new HeaderUC(IDataService dataService)
			headerUC.DisplayUser(user);
		}

		private void btnNotifs_Click(object sender, EventArgs e)
			=> _injector.Instantiate<AdminViewNotifForm>(CurrentUser)!.ShowDialog();
		//	  =>  

		private void btnLecturers_Click(object sender, EventArgs e)
			=> new AdminViewLecturersForm(CurrentUser).ShowDialog();

		private void btnCourses_Click(object sender, EventArgs e)
		//=> new AdminViewCoursesForm(CurrentUser).ShowDialog();
		{
			AdminViewCoursesUC adminViewCoursesUC = _injector.Instantiate<AdminViewCoursesUC>(CurrentUser)!;
			adminViewCoursesUC.Dock = DockStyle.Fill;

			Parent.Controls.Add(adminViewCoursesUC);
			Parent.Controls.Remove(this);

			this.Dispose();
		}
	}
}

