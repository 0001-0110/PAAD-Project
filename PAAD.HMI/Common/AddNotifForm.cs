using InversionOfControl;
using PAAD.DAL.Models;

namespace PAAD.HMI.Lecturer
{
	public partial class AddNotifForm : Form
	{
		private Notification Notification;
		private readonly IDependencyInjector _injector;

		// Add notification
		public AddNotifForm(IDependencyInjector injector)
		{
			_injector = injector;
			InitializeComponent();
			Notification = _injector.Instantiate<Notification>()!;
		}

		// Edit notification
		public AddNotifForm(IDependencyInjector injector, Notification notification) : this(injector)
		{
			this.Notification = notification;

			// Display the current notification's data
			lbAction.Text = "Edit notification";
			tbName.Text = Notification.Title;
			dateTimePicker_ExpirationDate.Value = Notification.ExpirationDateTime;
			tbDescription.Text = Notification.Text;
		}

		public Notification GetNotification()
		{
			Notification.Title = tbName.Text;
			Notification.ExpirationDateTime = dateTimePicker_ExpirationDate.Value;
			Notification.Text = tbDescription.Text;
			return Notification;
		}

	}
}
