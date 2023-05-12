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
    public partial class AdminViewNotifForm : Form
    {
        private DAL.Models.Administrator CurrentUser;

        public AdminViewNotifForm(DAL.Models.Administrator user)
        {
            InitializeComponent();
            CurrentUser = user;
            adminHeaderUC.DisplayUser(user);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnPost_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
