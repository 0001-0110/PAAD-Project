namespace PAAD.HMI.Administrator
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
            btnLogout = new Button();
            lbAdmin = new Label();
            pnlHeader = new Panel();
            lbLecturerName = new Label();
            btnBack = new Button();
            btnAddCourse = new Button();
            pnlDataGridContainer = new Panel();
            dgvCourses = new DataGridView();
            CourseName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            pnlHeader.SuspendLayout();
            pnlDataGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(637, 151);
            label1.Name = "label1";
            label1.Size = new Size(116, 38);
            label1.TabIndex = 13;
            label1.Text = "Courses";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(1202, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(168, 66);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAdmin.Location = new Point(12, 62);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(158, 32);
            lbAdmin.TabIndex = 1;
            lbAdmin.Text = "Administrator";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ScrollBar;
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lbAdmin);
            pnlHeader.Controls.Add(lbLecturerName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.ForeColor = SystemColors.ControlText;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1390, 111);
            pnlHeader.TabIndex = 12;
            // 
            // lbLecturerName
            // 
            lbLecturerName.AutoSize = true;
            lbLecturerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLecturerName.Location = new Point(12, 13);
            lbLecturerName.Name = "lbLecturerName";
            lbLecturerName.Size = new Size(268, 32);
            lbLecturerName.TabIndex = 0;
            lbLecturerName.Text = "[First name] [Last name]";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(23, 133);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 56);
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
            btnAddCourse.Location = new Point(621, 760);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(149, 62);
            btnAddCourse.TabIndex = 15;
            btnAddCourse.Text = "Add course";
            btnAddCourse.UseVisualStyleBackColor = false;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // pnlDataGridContainer
            // 
            pnlDataGridContainer.Controls.Add(dgvCourses);
            pnlDataGridContainer.Location = new Point(77, 228);
            pnlDataGridContainer.Name = "pnlDataGridContainer";
            pnlDataGridContainer.Size = new Size(1237, 510);
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
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 62;
            dgvCourses.RowTemplate.Height = 50;
            dgvCourses.ScrollBars = ScrollBars.Vertical;
            dgvCourses.Size = new Size(1237, 510);
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
            // AdminViewCoursesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 844);
            Controls.Add(pnlDataGridContainer);
            Controls.Add(btnAddCourse);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            Controls.Add(btnBack);
            Name = "AdminViewCoursesForm";
            Text = "View courses";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlDataGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Label lbAdmin;
        private Panel pnlHeader;
        private Label lbLecturerName;
        private Button btnBack;
        private Button btnAddCourse;
        private Panel pnlDataGridContainer;
        private DataGridView dgvCourses;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}