﻿namespace PAAD_Client.Administrator
{
    partial class AdminViewCoursesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnBack = new Button();
            btnAddCourse = new Button();
            pnlDataGridContainer = new Panel();
            dgvCourses = new DataGridView();
            CourseName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            adminHeaderuc1 = new AdminHeaderUC();
            pnlDataGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(510, 121);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 13;
            label1.Text = "Courses";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(18, 106);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 45);
            btnBack.TabIndex = 14;
            btnBack.Text = "[back array]";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.BackColor = SystemColors.Highlight;
            btnAddCourse.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCourse.ForeColor = SystemColors.ButtonHighlight;
            btnAddCourse.Location = new Point(497, 608);
            btnAddCourse.Margin = new Padding(2, 2, 2, 2);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(119, 50);
            btnAddCourse.TabIndex = 15;
            btnAddCourse.Text = "Add course";
            btnAddCourse.UseVisualStyleBackColor = false;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // pnlDataGridContainer
            // 
            pnlDataGridContainer.Controls.Add(dgvCourses);
            pnlDataGridContainer.Location = new Point(62, 182);
            pnlDataGridContainer.Margin = new Padding(2, 2, 2, 2);
            pnlDataGridContainer.Name = "pnlDataGridContainer";
            pnlDataGridContainer.Size = new Size(990, 408);
            pnlDataGridContainer.TabIndex = 16;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AllowUserToResizeColumns = false;
            dgvCourses.AllowUserToResizeRows = false;
            dgvCourses.ColumnHeadersHeight = 50;
            dgvCourses.Columns.AddRange(new DataGridViewColumn[] { CourseName, Edit, Delete });
            dgvCourses.Dock = DockStyle.Fill;
            dgvCourses.Location = new Point(0, 0);
            dgvCourses.Margin = new Padding(2, 2, 2, 2);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 62;
            dgvCourses.RowTemplate.Height = 50;
            dgvCourses.ScrollBars = ScrollBars.Vertical;
            dgvCourses.Size = new Size(990, 408);
            dgvCourses.TabIndex = 0;
            // 
            // CourseName
            // 
            CourseName.HeaderText = "Course name";
            CourseName.MinimumWidth = 8;
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            CourseName.Width = 600;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 273;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 273;
            // 
            // adminHeaderuc1
            // 
            adminHeaderuc1.BackColor = SystemColors.ScrollBar;
            adminHeaderuc1.Dock = DockStyle.Top;
            adminHeaderuc1.Location = new Point(0, 0);
            adminHeaderuc1.Name = "adminHeaderuc1";
            adminHeaderuc1.Size = new Size(1112, 90);
            adminHeaderuc1.TabIndex = 17;
            // 
            // AdminViewCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 675);
            Controls.Add(adminHeaderuc1);
            Controls.Add(pnlDataGridContainer);
            Controls.Add(btnAddCourse);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AdminViewCoursesForm";
            Text = "View courses";
            pnlDataGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private Button btnAddCourse;
        private Panel pnlDataGridContainer;
        private DataGridView dgvCourses;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private AdminHeaderUC adminHeaderuc1;
    }
}