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
    public partial class LecturerViewNotifForm : Form
    {
        public static DAL.Models.Lecturer CurrentUser;

        public LecturerViewNotifForm(DAL.Models.Lecturer user)
        {
            InitializeComponent();
            CurrentUser = user;
            // TODO Replace by HeaderUC
            lbLecturerName.Text = $"{user.FirstName} {user.LastName}";
            lbCourseName.Text = CurrentUser.Course == null ? "" : CurrentUser.Course.Name;
        }

        public void btnLogout_Click(object sender, EventArgs e)
            => Application.Restart();

        public void btnPost_Click(object sender, EventArgs e)
        {

        }
    }
}
