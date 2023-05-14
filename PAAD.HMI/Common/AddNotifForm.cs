using PAAD.DAL.Models;
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
    public partial class AddNotifForm : Form
    {
        private Notification Notification;

        // Add notification
        public AddNotifForm()
        {
            InitializeComponent();
            Notification = new Notification();
        }

        // Edit notification
        public AddNotifForm(Notification notification) : this()
        {
            this.Notification = notification;

            // Display the current notification's data
            lbAction.Text = "Edit notification";
            tbName.Text = Notification.Title;
            tbExpirationDate.Text = Notification.ExpirationDateTime.ToString();
            tbDescription.Text = Notification.Text;
        }

        public Notification GetNotification()
        {
            Notification.Title = tbName.Text;
            Notification.ExpirationDateTime = DateTime.Parse(tbExpirationDate.Text);
            Notification.Text = tbDescription.Text;
            return Notification;
        }

    }
}
