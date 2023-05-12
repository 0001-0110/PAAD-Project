namespace PAAD.HMI.Administrator
{
    partial class AdminHomeForm
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
            btnNotifs = new Button();
            btnLecturers = new Button();
            btnCourses = new Button();
            adminHeaderUC = new AdminHeaderUC();
            SuspendLayout();
            // 
            // btnNotifs
            // 
            btnNotifs.Anchor = AnchorStyles.None;
            btnNotifs.BackColor = SystemColors.ScrollBar;
            btnNotifs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotifs.Location = new Point(456, 234);
            btnNotifs.Name = "btnNotifs";
            btnNotifs.Size = new Size(200, 50);
            btnNotifs.TabIndex = 1;
            btnNotifs.Text = "View notifications";
            btnNotifs.UseVisualStyleBackColor = false;
            // 
            // btnLecturers
            // 
            btnLecturers.Anchor = AnchorStyles.None;
            btnLecturers.BackColor = SystemColors.ScrollBar;
            btnLecturers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLecturers.Location = new Point(456, 350);
            btnLecturers.Name = "btnLecturers";
            btnLecturers.Size = new Size(200, 50);
            btnLecturers.TabIndex = 2;
            btnLecturers.Text = "View lecturers";
            btnLecturers.UseVisualStyleBackColor = false;
            // 
            // btnCourses
            // 
            btnCourses.Anchor = AnchorStyles.None;
            btnCourses.BackColor = SystemColors.ScrollBar;
            btnCourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCourses.Location = new Point(456, 466);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(200, 50);
            btnCourses.TabIndex = 3;
            btnCourses.Text = "View courses";
            btnCourses.UseVisualStyleBackColor = false;
            // 
            // adminHeaderUC
            // 
            adminHeaderUC.BackColor = SystemColors.ScrollBar;
            adminHeaderUC.Dock = DockStyle.Top;
            adminHeaderUC.Location = new Point(0, 0);
            adminHeaderUC.Name = "adminHeaderUC";
            adminHeaderUC.Size = new Size(1112, 90);
            adminHeaderUC.TabIndex = 4;
            // 
            // AdminHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 675);
            Controls.Add(adminHeaderUC);
            Controls.Add(btnCourses);
            Controls.Add(btnLecturers);
            Controls.Add(btnNotifs);
            Name = "AdminHomeForm";
            Text = "AdminHomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNotifs;
        private Button btnLecturers;
        private Button btnCourses;
        private AdminHeaderUC adminHeaderUC;
    }
}