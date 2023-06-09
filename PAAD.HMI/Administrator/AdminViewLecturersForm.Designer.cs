namespace PAAD.HMI.Administrator
{
    partial class AdminViewLecturersForm
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
            btnAddLecturer = new Button();
            btnBack = new Button();
            dataGridView1 = new DataGridView();
            dgvColumnLecturer = new DataGridViewTextBoxColumn();
            dgvColumnCourse = new DataGridViewTextBoxColumn();
            dgvColumnEdit = new DataGridViewTextBoxColumn();
            dgvColumnDelete = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddLecturer
            // 
            btnAddLecturer.Anchor = AnchorStyles.Bottom;
            btnAddLecturer.BackColor = SystemColors.Highlight;
            btnAddLecturer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddLecturer.ForeColor = SystemColors.ButtonHighlight;
            btnAddLecturer.Location = new Point(559, 636);
            btnAddLecturer.Margin = new Padding(2);
            btnAddLecturer.Name = "btnAddLecturer";
            btnAddLecturer.Size = new Size(134, 52);
            btnAddLecturer.TabIndex = 17;
            btnAddLecturer.Text = "Add lecturer";
            btnAddLecturer.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.backarrow;
            btnBack.Location = new Point(18, 112);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 47);
            btnBack.TabIndex = 16;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvColumnLecturer, dgvColumnCourse, dgvColumnEdit, dgvColumnDelete });
            dataGridView1.Location = new Point(45, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1160, 440);
            dataGridView1.TabIndex = 18;
            // 
            // dgvColumnLecturer
            // 
            dgvColumnLecturer.HeaderText = "Lecturer";
            dgvColumnLecturer.MinimumWidth = 6;
            dgvColumnLecturer.Name = "dgvColumnLecturer";
            dgvColumnLecturer.ReadOnly = true;
            // 
            // dgvColumnCourse
            // 
            dgvColumnCourse.HeaderText = "Course name";
            dgvColumnCourse.MinimumWidth = 6;
            dgvColumnCourse.Name = "dgvColumnCourse";
            dgvColumnCourse.ReadOnly = true;
            // 
            // dgvColumnEdit
            // 
            dgvColumnEdit.HeaderText = "";
            dgvColumnEdit.MinimumWidth = 6;
            dgvColumnEdit.Name = "dgvColumnEdit";
            dgvColumnEdit.ReadOnly = true;
            // 
            // dgvColumnDelete
            // 
            dgvColumnDelete.HeaderText = "";
            dgvColumnDelete.MinimumWidth = 6;
            dgvColumnDelete.Name = "dgvColumnDelete";
            dgvColumnDelete.ReadOnly = true;
            // 
            // AdminViewLecturersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 709);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddLecturer);
            Controls.Add(btnBack);
            Name = "AdminViewLecturersForm";
            Text = "AdminViewLecturersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AdminHeaderUC adminHeaderUC;
        private Button btnAddLecturer;
        private Button btnBack;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dgvColumnLecturer;
        private DataGridViewTextBoxColumn dgvColumnCourse;
        private DataGridViewTextBoxColumn dgvColumnEdit;
        private DataGridViewTextBoxColumn dgvColumnDelete;
    }
}