namespace PAAD.HMI.Administrator
{
    partial class AdminViewLecturersUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView_Lecturer = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnAddLecturer = new Button();
            btnBack = new Button();
            dgvColumnLecturer = new DataGridViewTextBoxColumn();
            dgvColumnCourse = new DataGridViewTextBoxColumn();
            Lecturer = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            lbLecturers = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Lecturer).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Lecturer
            // 
            dataGridView_Lecturer.AllowUserToAddRows = false;
            dataGridView_Lecturer.AllowUserToDeleteRows = false;
            dataGridView_Lecturer.Anchor = AnchorStyles.None;
            dataGridView_Lecturer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Lecturer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Lecturer.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Course, Edit, Delete });
            dataGridView_Lecturer.Location = new Point(45, 176);
            dataGridView_Lecturer.Margin = new Padding(4, 3, 4, 3);
            dataGridView_Lecturer.MultiSelect = false;
            dataGridView_Lecturer.Name = "dataGridView_Lecturer";
            dataGridView_Lecturer.ReadOnly = true;
            dataGridView_Lecturer.RowHeadersWidth = 51;
            dataGridView_Lecturer.RowTemplate.Height = 29;
            dataGridView_Lecturer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Lecturer.Size = new Size(1160, 440);
            dataGridView_Lecturer.TabIndex = 21;
            dataGridView_Lecturer.CellContentClick += dataGridView_Lecturer_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Lecturer";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Course
            // 
            Course.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Course.HeaderText = "Course name";
            Course.MinimumWidth = 8;
            Course.Name = "Course";
            Course.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGreen;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            Edit.DefaultCellStyle = dataGridViewCellStyle3;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.HeaderText = "";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Red;
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            Delete.DefaultCellStyle = dataGridViewCellStyle4;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnAddLecturer
            // 
            btnAddLecturer.Anchor = AnchorStyles.Bottom;
            btnAddLecturer.BackColor = SystemColors.Highlight;
            btnAddLecturer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddLecturer.ForeColor = SystemColors.ButtonHighlight;
            btnAddLecturer.Location = new Point(559, 637);
            btnAddLecturer.Margin = new Padding(2);
            btnAddLecturer.Name = "btnAddLecturer";
            btnAddLecturer.Size = new Size(134, 52);
            btnAddLecturer.TabIndex = 20;
            btnAddLecturer.Text = "Add lecturer";
            btnAddLecturer.UseVisualStyleBackColor = false;
            btnAddLecturer.Click += btnAddLecturer_Click;
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.backarrow;
            btnBack.Location = new Point(18, 113);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 47);
            btnBack.TabIndex = 19;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvColumnLecturer
            // 
            dgvColumnLecturer.HeaderText = "Lecturer";
            dgvColumnLecturer.MinimumWidth = 6;
            dgvColumnLecturer.Name = "dgvColumnLecturer";
            dgvColumnLecturer.Width = 309;
            // 
            // dgvColumnCourse
            // 
            dgvColumnCourse.HeaderText = "Course name";
            dgvColumnCourse.MinimumWidth = 6;
            dgvColumnCourse.Name = "dgvColumnCourse";
            dgvColumnCourse.Width = 309;
            // 
            // Lecturer
            // 
            Lecturer.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Lecturer.HeaderText = "Lecturer";
            Lecturer.MinimumWidth = 8;
            Lecturer.Name = "Lecturer";
            // 
            // CourseName
            // 
            CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CourseName.HeaderText = "Course name";
            CourseName.MinimumWidth = 8;
            CourseName.Name = "CourseName";
            // 
            // lbLecturers
            // 
            lbLecturers.AutoSize = true;
            lbLecturers.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbLecturers.Location = new Point(583, 127);
            lbLecturers.Margin = new Padding(2, 0, 2, 0);
            lbLecturers.Name = "lbLecturers";
            lbLecturers.Size = new Size(90, 25);
            lbLecturers.TabIndex = 22;
            lbLecturers.Text = "Lecturers";
            // 
            // AdminViewLecturersUC
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbLecturers);
            Controls.Add(dataGridView_Lecturer);
            Controls.Add(btnAddLecturer);
            Controls.Add(btnBack);
            Name = "AdminViewLecturersUC";
            Size = new Size(1251, 709);
            Load += AdminViewLecturersUC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Lecturer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Lecturer;
        private Button btnAddLecturer;
        private Button btnBack;
        private DataGridViewTextBoxColumn dgvColumnLecturer;
        private DataGridViewTextBoxColumn dgvColumnCourse;
        private DataGridViewTextBoxColumn Lecturer;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Label lbLecturers;
    }
}
