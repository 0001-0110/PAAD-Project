﻿using PAAD.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAAD.HMI.Administrator
{
    public partial class AdminHomeForm : Form
    {
        private DAL.Models.Administrator CurrentUser;

        public AdminHomeForm(DAL.Models.Administrator user)
        {
            InitializeComponent();
            CurrentUser = user;
            adminHeaderUC.DisplayUser(user);
        }

        private void btnNotifs_Click(object sender, EventArgs e)
            => new AdminViewNotifForm(CurrentUser).ShowDialog();

        private void btnLecturers_Click(object sender, EventArgs e)
            => new AdminViewLecturersForm(CurrentUser).ShowDialog();

        private void btnCourses_Click(object sender, EventArgs e)
            => new AdminViewCoursesForm(CurrentUser).ShowDialog();
    }
}
