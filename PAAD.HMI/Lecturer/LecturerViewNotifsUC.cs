using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Common;
using PAAD.HMI.Utilities;

namespace PAAD.HMI.Lecturer
{
    public partial class LecturerViewNotifsUC : UserControl
	{
		private readonly IDependencyInjector _injector;
		private readonly IAuthenticationService _authenticationService;
		private DAL.Models.Lecturer currentUser;
		private readonly IDataService _dataService;
		
		public LecturerViewNotifsUC(IDependencyInjector injector, IAuthenticationService authenticationService, IDataService dataService)
		{
			_injector = injector;
			_dataService = dataService;
			_authenticationService = authenticationService;
			currentUser = (DAL.Models.Lecturer)_authenticationService.CurrentUser!;
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
			// TODO Why is this thing inside a try catch ? Can it even fail ?
			try
			{
				IEnumerable<Notification> notifications =
					_dataService.GetAll<Notification>().Where(x => x.CourseId == currentUser.CourseId);
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
			AddNotifForm addNotifForm = _injector.Instantiate<AddNotifForm>()!;
			if (addNotifForm.ShowDialog() == DialogResult.OK)
			{
				Notification notification = addNotifForm.GetNotification();
				notification.AuthorId = currentUser.Id;
				notification.CourseId = currentUser.CourseId;
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
