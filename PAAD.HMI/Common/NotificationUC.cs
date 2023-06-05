using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Lecturer;
using PAAD.HMI.Utilities;

namespace PAAD.HMI.Common
{
    public partial class NotificationUC : UserControl
    {
        private readonly IDataService _dataService;
        private readonly IDependencyInjector _injector;
        private Notification notification;

        public NotificationUC(IDataService dataService, IDependencyInjector injector, Notification notification)
        {
            InitializeComponent();
            _dataService = dataService;
            _injector = injector;
            this.notification = notification;
        }

        private void NotificationUC_Load(object sender, EventArgs e)
        {
            lbTitle.Text = notification.Title;
            if (notification.Author != null)
                lbAuthor.Text = $"{notification.Author!.FirstName} {notification.Author.LastName}";
            else
                lbAuthor.Text = "Deleted user";
            lbDescription.Text = notification.Text;
            lbPublicationDate.Text = notification.PublishedDateTime.ToString("d");
            lbExpirationDate.Text = notification.ExpirationDateTime.ToString("d");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddNotifForm addNotifForm = _injector.Instantiate<AddNotifForm>(notification)!;
            if (addNotifForm.ShowDialog() == DialogResult.OK)
            {
                notification = addNotifForm.GetNotification();
                _dataService.Edit<Notification>(notification.Id, notification);
                NotificationUC_Load(this, EventArgs.Empty);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(new ConfirmationForm().ShowDialog() == DialogResult.OK)
            {
                _dataService.Delete<Notification>(notification.Id);
                Parent.Controls.Remove(this);
            }
        }
    }
}
