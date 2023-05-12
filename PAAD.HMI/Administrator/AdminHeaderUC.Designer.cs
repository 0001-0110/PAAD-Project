namespace PAAD.HMI.Administrator
{
    partial class AdminHeaderUC
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
            btnLogout = new Button();
            lbAdmin = new Label();
            lbLecturerName = new Label();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(915, 19);
            btnLogout.Margin = new Padding(2, 3, 2, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(134, 53);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lbAdmin
            // 
            lbAdmin.Anchor = AnchorStyles.Left;
            lbAdmin.AutoSize = true;
            lbAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAdmin.Location = new Point(53, 51);
            lbAdmin.Margin = new Padding(2, 0, 2, 0);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(133, 28);
            lbAdmin.TabIndex = 13;
            lbAdmin.Text = "Administrator";
            // 
            // lbLecturerName
            // 
            lbLecturerName.Anchor = AnchorStyles.Left;
            lbLecturerName.AutoSize = true;
            lbLecturerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLecturerName.Location = new Point(53, 11);
            lbLecturerName.Margin = new Padding(2, 0, 2, 0);
            lbLecturerName.Name = "lbLecturerName";
            lbLecturerName.Size = new Size(218, 28);
            lbLecturerName.TabIndex = 12;
            lbLecturerName.Text = "[First name] [Last name]";
            // 
            // AdminHeaderUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(btnLogout);
            Controls.Add(lbAdmin);
            Controls.Add(lbLecturerName);
            Name = "AdminHeaderUC";
            Size = new Size(1100, 90);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Label lbAdmin;
        private Label lbLecturerName;
    }
}
