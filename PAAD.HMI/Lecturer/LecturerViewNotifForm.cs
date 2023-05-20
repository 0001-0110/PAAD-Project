using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Common;
using PAAD.HMI.Utilities;
using System.Data;

namespace PAAD.HMI.Lecturer
{
    public partial class LecturerViewNotifForm : Form
    {
        private readonly IDependencyInjector _injector;
        private readonly IDataService _dataService;
        private DAL.Models.Lecturer CurrentUser;

        public LecturerViewNotifForm(IDependencyInjector injector, IDataService dataService, DAL.Models.Lecturer user)
        {
            InitializeComponent();
            _injector = injector;
            _dataService = dataService;
            CurrentUser = user;
        }

        private void LecturerViewNotifForm_Load(object sender, EventArgs e)
        {
            lbLecturerName.Text = $"{CurrentUser.FirstName} {CurrentUser.LastName}";
            lbCourseName.Text = CurrentUser.Course == null ? "" : CurrentUser.Course.Name;
            try
            {
                IEnumerable<Notification> notifications = 
                    _dataService.GetAll<Notification>().Where(x => x.CourseId == CurrentUser.CourseId);
                foreach (Notification notification in notifications)
                    flpNotificationsContainer.Controls.Add(_injector.Instantiate<NotificationUC>(notification));
            }
            catch (Exception ex)
            {
                MessageBoxUtility.ShowError(ex.Message);
                Environment.Exit(1);
            }
        }

        public void btnLogout_Click(object sender, EventArgs e)
            => Application.Restart();

        public void btnPost_Click(object sender, EventArgs e)
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
                    MessageBoxUtility.ShowError(ex.Message);
                    Environment.Exit(1);
                }
                flpNotificationsContainer.Controls.Add(_injector.Instantiate<NotificationUC>(notification));
            }
        }
    }
}
