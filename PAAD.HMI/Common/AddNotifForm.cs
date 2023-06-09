using InversionOfControl;
using PAAD.DAL.Models;
using PAAD.HMI.Extensions;

namespace PAAD.HMI.Lecturer
{
    public partial class AddNotifForm : Form
    {
        private Notification notification;
        private readonly IDependencyInjector injector;

        // Add notification
        public AddNotifForm(IDependencyInjector injector)
        {
            this.injector = injector;
            InitializeComponent();
            notification = this.injector.Instantiate<Notification>()!;
            dateTimePicker_ExpirationDate.Value = DateTime.Today.AddDays(1);

            tbName.SetValidator(textBox => textBox.Text != string.Empty, "This notification needs a name");
            tbDescription.SetValidator(textBox => textBox.Text != string.Empty, "This notification needs a description");
            dateTimePicker_ExpirationDate.SetValidator(dateTimePicker => dateTimePicker.Value > DateTime.Now, "You need to reach 88 miles per hour first");
        }

        // Edit notification
        public AddNotifForm(IDependencyInjector injector, Notification notification) : this(injector)
        {
            this.notification = notification;

            // Display the current notification's data
            lbAction.Text = "Edit notification";
            tbName.Text = this.notification.Title;
            dateTimePicker_ExpirationDate.Value = this.notification.ExpirationDateTime;
            tbDescription.Text = this.notification.Text;
        }

        public Notification GetNotification()
        {
            notification.Title = tbName.Text;
            notification.ExpirationDateTime = dateTimePicker_ExpirationDate.Value;
            notification.Text = tbDescription.Text;
            return notification;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!this.IsFormValid())
                return;

            DialogResult = DialogResult.OK;
        }
    }
}
