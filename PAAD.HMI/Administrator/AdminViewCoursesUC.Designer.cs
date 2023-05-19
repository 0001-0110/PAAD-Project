namespace PAAD.HMI.Administrator
{
	partial class AdminViewCoursesUC
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			pnlDataGridContainer = new Panel();
			dgvCourses = new DataGridView();
			btnAddCourse = new Button();
			lbCourses = new Label();
			btnBack = new Button();
			CourseName = new DataGridViewTextBoxColumn();
			Edit = new DataGridViewButtonColumn();
			Delete = new DataGridViewButtonColumn();
			pnlDataGridContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
			SuspendLayout();
			// 
			// pnlDataGridContainer
			// 
			pnlDataGridContainer.Controls.Add(dgvCourses);
			pnlDataGridContainer.Location = new Point(78, 229);
			pnlDataGridContainer.Margin = new Padding(2);
			pnlDataGridContainer.Name = "pnlDataGridContainer";
			pnlDataGridContainer.Size = new Size(1238, 510);
			pnlDataGridContainer.TabIndex = 20;
			// 
			// dgvCourses
			// 
			dgvCourses.AllowUserToAddRows = false;
			dgvCourses.AllowUserToDeleteRows = false;
			dgvCourses.AllowUserToResizeColumns = false;
			dgvCourses.AllowUserToResizeRows = false;
			dgvCourses.ColumnHeadersHeight = 50;
			dgvCourses.Columns.AddRange(new DataGridViewColumn[] { CourseName, Edit, Delete });
			dgvCourses.Dock = DockStyle.Fill;
			dgvCourses.Location = new Point(0, 0);
			dgvCourses.Margin = new Padding(2);
			dgvCourses.MultiSelect = false;
			dgvCourses.Name = "dgvCourses";
			dgvCourses.ReadOnly = true;
			dgvCourses.RowHeadersWidth = 62;
			dgvCourses.RowTemplate.Height = 50;
			dgvCourses.ScrollBars = ScrollBars.Vertical;
			dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCourses.Size = new Size(1238, 510);
			dgvCourses.TabIndex = 0;
			dgvCourses.CellContentClick += dgvCourses_CellContentClick;
			// 
			// btnAddCourse
			// 
			btnAddCourse.BackColor = SystemColors.Highlight;
			btnAddCourse.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			btnAddCourse.ForeColor = SystemColors.ButtonHighlight;
			btnAddCourse.Location = new Point(621, 761);
			btnAddCourse.Margin = new Padding(2);
			btnAddCourse.Name = "btnAddCourse";
			btnAddCourse.Size = new Size(149, 62);
			btnAddCourse.TabIndex = 19;
			btnAddCourse.Text = "Add course";
			btnAddCourse.UseVisualStyleBackColor = false;
			btnAddCourse.Click += btnAddCourse_Click;
			// 
			// lbCourses
			// 
			lbCourses.AutoSize = true;
			lbCourses.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
			lbCourses.Location = new Point(638, 151);
			lbCourses.Margin = new Padding(2, 0, 2, 0);
			lbCourses.Name = "lbCourses";
			lbCourses.Size = new Size(116, 38);
			lbCourses.TabIndex = 17;
			lbCourses.Text = "Courses";
			// 
			// btnBack
			// 
			btnBack.Location = new Point(22, 132);
			btnBack.Margin = new Padding(2);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(121, 56);
			btnBack.TabIndex = 18;
			btnBack.Text = "[back array]";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// CourseName
			// 
			CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			CourseName.HeaderText = "Course name";
			CourseName.MinimumWidth = 8;
			CourseName.Name = "CourseName";
			CourseName.ReadOnly = true;
			// 
			// Edit
			// 
			Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.LightGreen;
			dataGridViewCellStyle1.ForeColor = Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			Edit.DefaultCellStyle = dataGridViewCellStyle1;
			Edit.FlatStyle = FlatStyle.Flat;
			Edit.HeaderText = "";
			Edit.MinimumWidth = 8;
			Edit.Name = "Edit";
			Edit.ReadOnly = true;
			Edit.Text = "Edit";
			// 
			// Delete
			// 
			Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = Color.Red;
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 128);
			dataGridViewCellStyle2.SelectionForeColor = Color.White;
			Delete.DefaultCellStyle = dataGridViewCellStyle2;
			Delete.FlatStyle = FlatStyle.Flat;
			Delete.HeaderText = "";
			Delete.MinimumWidth = 8;
			Delete.Name = "Delete";
			Delete.ReadOnly = true;
			// 
			// AdminViewCoursesUC
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(pnlDataGridContainer);
			Controls.Add(btnAddCourse);
			Controls.Add(lbCourses);
			Controls.Add(btnBack);
			Name = "AdminViewCoursesUC";
			Size = new Size(1390, 844);
			Load += AdminViewCoursesUC_Load;
			pnlDataGridContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pnlDataGridContainer;
		private DataGridView dgvCourses;
		private Button btnAddCourse;
		private Label lbCourses;
		private Button btnBack;
		private DataGridViewTextBoxColumn CourseName;
		private DataGridViewButtonColumn Edit;
		private DataGridViewButtonColumn Delete;
	}
}
