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
            adminHeaderUC = new AdminHeaderUC();
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
            // adminHeaderUC
            // 
            adminHeaderUC.BackColor = SystemColors.ScrollBar;
            adminHeaderUC.Dock = DockStyle.Top;
            adminHeaderUC.Location = new Point(0, 0);
            adminHeaderUC.Name = "adminHeaderUC";
            adminHeaderUC.Size = new Size(1112, 90);
            adminHeaderUC.TabIndex = 0;
            // 
            // btnAddLecturer
            // 
            btnAddLecturer.Anchor = AnchorStyles.Bottom;
            btnAddLecturer.BackColor = SystemColors.Highlight;
            btnAddLecturer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddLecturer.ForeColor = SystemColors.ButtonHighlight;
            btnAddLecturer.Location = new Point(497, 606);
            btnAddLecturer.Margin = new Padding(2);
            btnAddLecturer.Name = "btnAddLecturer";
            btnAddLecturer.Size = new Size(119, 50);
            btnAddLecturer.TabIndex = 17;
            btnAddLecturer.Text = "Add lecturer";
            btnAddLecturer.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(16, 107);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 45);
            btnBack.TabIndex = 16;
            btnBack.Text = "[back array]";
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
            dataGridView1.Location = new Point(40, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1031, 419);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 675);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddLecturer);
            Controls.Add(btnBack);
            Controls.Add(adminHeaderUC);
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