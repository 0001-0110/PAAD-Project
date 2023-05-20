using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Common;
using PAAD.HMI.Lecturer;
using PAAD.HMI.Utilities;

namespace PAAD.HMI.Administrator
{
    public partial class AdminViewNotifsUC : UserControl
	{
		private readonly IDataService _dataService;
		private readonly IDependencyInjector _injector;
		private readonly IAuthenticationService _authenticationService;

		public AdminViewNotifsUC(IDataService dataService, IDependencyInjector injector, IAuthenticationService authenticationService)
		{
			_dataService = dataService;
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

		private void AdminViewNotifsUC_Load(object sender, EventArgs e)
		{
			try
			{
				IEnumerable<Course> courses = _dataService.GetAll<Course>();
				foreach (Course course in courses)
					cbCourses.Items.Add(course);
				if(cbCourses.Items.Count > 0)
					cbCourses.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				MessageBoxUtility.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}


		private void btnBack_Click(object sender, EventArgs e)
		{
			AdminHomeUC adminHomeUC = _injector.Instantiate<AdminHomeUC>()!;
			adminHomeUC.Dock = DockStyle.Fill;
			Parent.Controls.Add(adminHomeUC);
			Parent.Controls.Remove(this);
			this.Dispose();
		}

		private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
		{
			flpNotificationsContainer.Controls.Clear();
			if (cbCourses.SelectedItem == null)
				return;
			try
			{
				Course currentCourse = (Course)cbCourses.SelectedItem;
				IEnumerable<Notification> notifications = _dataService.GetAll<Notification>().Where(x => x.CourseId == currentCourse.Id);
				foreach (Notification notification in notifications)
					flpNotificationsContainer.Controls.Add(_injector.Instantiate<NotificationUC>(notification));
			}
			catch (Exception ex)
			{
				MessageBoxUtility.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}

		private void btnPost_Click(object sender, EventArgs e)
		{
			if (cbCourses.SelectedItem == null)
				return;
			AddNotifForm addNotifForm = _injector.Instantiate<AddNotifForm>()!;
			if (addNotifForm.ShowDialog() == DialogResult.OK)
			{
				Course currentCourse = (Course)cbCourses.SelectedItem;
				Notification notification = addNotifForm.GetNotification();
				notification.AuthorId = _authenticationService.CurrentUser!.Id;
				notification.CourseId = currentCourse.Id;
				try
				{
					_dataService.Create<Notification>(notification);
				}
				catch (Exception ex)
				{
					MessageBoxUtility.ShowError(ex.Message);
					Environment.Exit(1);
				}
				flpNotificationsContainer.Controls.Add(_injector.Instantiate<NotificationUC>(notification));
			}
		}

		
	}
}
