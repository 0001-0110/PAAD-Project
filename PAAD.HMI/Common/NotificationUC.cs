using PAAD.BLL.Services;
using PAAD.DAL.Models;
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

namespace PAAD.HMI.Common
{
    public partial class NotificationUC : UserControl
    {
        private readonly IDataService _dataService;
        private Notification notification;

        public NotificationUC(IDataService dataService, Notification notification)
        {
            InitializeComponent();
            _dataService = dataService;
            this.notification = notification;
        }

        private void NotificationUC_Load(object sender, EventArgs e)
        {
            lbTitle.Text = notification.Title;
            lbAuthor.Text = $"{notification.Author.FirstName} {notification.Author.LastName}";
            lbDescription.Text = notification.Text;
            lbPublicationDate.Text = notification.PublishedDateTime.ToString("d");
            lbExpirationDate.Text = notification.ExpirationDateTime.ToString("d");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddNotifForm addNotifForm = new AddNotifForm(notification);
            if (addNotifForm.ShowDialog() == DialogResult.OK)
            {
                notification = addNotifForm.GetNotification();
                try
                {
                    _dataService.Edit<Notification>(notification.Id, notification);
                }
                catch (Exception ex) 
                {
                    Utils.ShowError(ex.Message);
                    Environment.Exit(1);
                }
                NotificationUC_Load(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(new ConfirmationForm().ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _dataService.Delete<Notification>(notification.Id);
                }
                catch (Exception ex)
                {
                    Utils.ShowError(ex.Message);
                    Environment.Exit(1);
                }
                Parent.Controls.Remove(this);
            }
        }
    }
}
