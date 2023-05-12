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

namespace PAAD.HMI.Administrator
{
    public partial class AdminViewLecturersForm : Form
    {
        private DAL.Models.Administrator CurrentUser;

        public AdminViewLecturersForm(DAL.Models.Administrator user)
        {
            InitializeComponent();
            CurrentUser = user;
            adminHeaderUC.DisplayUser(user);
        }
    }
}
