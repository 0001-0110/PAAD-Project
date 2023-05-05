namespace PAAD_Client.Administrator
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
            adminHeaderuc1 = new AdminHeaderUC();
            btnNotifs = new Button();
            btnLecturers = new Button();
            btnCourses = new Button();
            SuspendLayout();
            // 
            // adminHeaderuc1
            // 
            adminHeaderuc1.BackColor = SystemColors.ScrollBar;
            adminHeaderuc1.Dock = DockStyle.Top;
            adminHeaderuc1.Location = new Point(0, 0);
            adminHeaderuc1.Name = "adminHeaderuc1";
            adminHeaderuc1.Size = new Size(582, 90);
            adminHeaderuc1.TabIndex = 0;
            // 
            // btnNotifs
            // 
            btnNotifs.Anchor = AnchorStyles.None;
            btnNotifs.BackColor = SystemColors.ScrollBar;
            btnNotifs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotifs.Location = new Point(191, 173);
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
            btnLecturers.Location = new Point(191, 289);
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
            btnCourses.Location = new Point(191, 405);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(200, 50);
            btnCourses.TabIndex = 3;
            btnCourses.Text = "View courses";
            btnCourses.UseVisualStyleBackColor = false;
            // 
            // AdminHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(btnCourses);
            Controls.Add(btnLecturers);
            Controls.Add(btnNotifs);
            Controls.Add(adminHeaderuc1);
            Name = "AdminHomeForm";
            Text = "AdminHomeForm";
            ResumeLayout(false);
        }

        #endregion

        private AdminHeaderUC adminHeaderuc1;
        private Button btnNotifs;
        private Button btnLecturers;
        private Button btnCourses;
    }
}