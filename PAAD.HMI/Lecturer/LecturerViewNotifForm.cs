using InversionOfControl;
using Microsoft.VisualBasic.ApplicationServices;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO Replace by HeaderUC
            lbLecturerName.Text = $"{CurrentUser.FirstName} {CurrentUser.LastName}";
            lbCourseName.Text = CurrentUser.Course == null ? "" : CurrentUser.Course.Name;
            if (CurrentUser.Notifications != null)
            {
                foreach (Notification notification in CurrentUser.Notifications)
                    flpNotificationsContainer.Controls.Add(_injector.Instantiate<NotificationUC>(notification));
            }
        }

        public void btnLogout_Click(object sender, EventArgs e)
            => Application.Restart();

        public void btnPost_Click(object sender, EventArgs e)
        {
            AddNotifForm addNotifForm = new AddNotifForm();
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
