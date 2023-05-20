using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Common;

namespace PAAD.HMI.Lecturer
{
	public partial class LecturerViewNotifsUC : UserControl
	{
		private readonly IDependencyInjector _injector;
		private readonly IDataService _dataService;
		private readonly IAuthenticationService _authenticationService;
		private DAL.Models.Lecturer CurrentUser;
		
		public LecturerViewNotifsUC(IDependencyInjector injector, IDataService dataService, IAuthenticationService authenticationService)
		{
			_injector = injector;
			_dataService = dataService;
			_authenticationService = authenticationService;
			CurrentUser = (DAL.Models.Lecturer)_authenticationService.CurrentUser!;
			InitializeComponent();
			AddHeader();
		}

		private void AddHeader()
		{
			HeaderUC headerUC = _injector.Instantiate<HeaderUC>()!;
			headerUC.Dock = DockStyle.Top;
			Controls.Add(headerUC);
		}

		private void LecturerViewNotifsUC_Load(object sender, EventArgs e)
		{
			try
			{
				IEnumerable<Notification> notifications =
					_dataService.GetAll<Notification>().Where(x => x.CourseId == CurrentUser.CourseId);
				foreach (Notification notification in notifications)
					flpNotificationsContainer.Controls.Add(_injector.Instantiate<NotificationUC>(notification));
			}
			catch (Exception ex)
			{
				Utils.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}

		private void btnPost_Click(object sender, EventArgs e)
		{
			AddNotifForm addNotifForm = _injector.Instantiate<AddNotifForm>()!;
			if (addNotifForm.ShowDialog() == DialogResult.OK)
			{
				Notification notification = addNotifForm.GetNotification();
				notification.AuthorId = CurrentUser.Id;
				notification.CourseId = CurrentUser.CourseId;
				try
				{
					_dataService.Create<Notification>(notification);
				}
				catch (Exception ex)
				{
					Utils.ShowError(ex.Message);
					Environment.Exit(1);
				}
				flpNotificationsContainer.Controls.Add(_injector.Instantiate<NotificationUC>(notification));
			}
		}
	}
}
