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

namespace PAAD.HMI.Administrator
{
    public partial class AdminHeaderUC : UserControl
    {
        public AdminHeaderUC()
        {
            InitializeComponent();
        }

        public void DisplayUser(User user)
            => lbLecturerName.Text = $"{user.FirstName} {user.LastName}";

        private void btnLogout_Click(object sender, EventArgs e)
            => Application.Restart();
    }
}
