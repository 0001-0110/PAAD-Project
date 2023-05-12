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
    public partial class AdminViewCoursesForm : Form
    {

        /*
         * Taille des colonnes:
         * "Course name" (DataGridViewTextColumn): 600 
         * "Edit" (DataGridViewButtonColumn): 273
         * "Delete" (DataGridViewButtonColumn): 273
         * 
         * Taille des lignes: 50
         * 
         * A créer via code pour bien les initialiser.
         */
        private DAL.Models.Administrator CurrentUser;

        public AdminViewCoursesForm(DAL.Models.Administrator user)
        {
            InitializeComponent();
            CurrentUser = user;
            adminHeaderUC.DisplayUser(user);
        }

        private void AdminViewCoursesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
