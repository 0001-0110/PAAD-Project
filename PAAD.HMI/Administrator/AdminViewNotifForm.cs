using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Common;
using PAAD.HMI.Lecturer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAAD.HMI.Administrator
{
    public partial class AdminViewNotifForm : Form
    {
        private readonly IDependencyInjector _injector;
        private readonly IDataService _dataService;
        private DAL.Models.Administrator CurrentUser;

        public AdminViewNotifForm(IDependencyInjector injector, IDataService dataService, DAL.Models.Administrator user)
        {
            InitializeComponent();
            _injector = injector;
            _dataService = dataService;
            CurrentUser = user;
            adminHeaderUC.DisplayUser(user);
        }

        private void AdminViewNotifForm_Load(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Course> courses = _dataService.GetAll<Course>();
                foreach (Course course in courses)
                    cbCourses.Items.Add(course);
            }
            catch(Exception ex)
            {
                Utils.ShowError(ex.Message);
                Environment.Exit(1);
            }
        }
        
        private void btnBack_Click(object sender, EventArgs e)
            => Close();

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpNotificationsContainer.Controls.Clear();
            if (cbCourses.SelectedItem == null)
                return;
            try
            {
                Course currentCourse = (Course) cbCourses.SelectedItem;
                IEnumerable<Notification> notifications = _dataService.GetAll<Notification>().Where(x => x.CourseId == currentCourse.Id);
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
            if (cbCourses.SelectedItem == null)
                return;
            AddNotifForm addNotifForm = new AddNotifForm();
            if (addNotifForm.ShowDialog() == DialogResult.OK)
            {
                Course currentCourse = (Course) cbCourses.SelectedItem;
                Notification notification = addNotifForm.GetNotification();
                notification.AuthorId = CurrentUser.Id;
                notification.CourseId = currentCourse.Id;
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
