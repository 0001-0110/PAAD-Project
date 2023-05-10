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
            btnNotifs = new Button();
            btnLecturers = new Button();
            btnCourses = new Button();
            SuspendLayout();
            // 
            // btnNotifs
            // 
            btnNotifs.Anchor = AnchorStyles.None;
            btnNotifs.BackColor = SystemColors.ScrollBar;
            btnNotifs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotifs.Location = new Point(513, 246);
            btnNotifs.Name = "btnNotifs";
            btnNotifs.Size = new Size(225, 52);
            btnNotifs.TabIndex = 1;
            btnNotifs.Text = "View notifications";
            btnNotifs.UseVisualStyleBackColor = false;
            // 
            // btnLecturers
            // 
            btnLecturers.Anchor = AnchorStyles.None;
            btnLecturers.BackColor = SystemColors.ScrollBar;
            btnLecturers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLecturers.Location = new Point(513, 367);
            btnLecturers.Name = "btnLecturers";
            btnLecturers.Size = new Size(225, 52);
            btnLecturers.TabIndex = 2;
            btnLecturers.Text = "View lecturers";
            btnLecturers.UseVisualStyleBackColor = false;
            // 
            // btnCourses
            // 
            btnCourses.Anchor = AnchorStyles.None;
            btnCourses.BackColor = SystemColors.ScrollBar;
            btnCourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCourses.Location = new Point(513, 489);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(225, 52);
            btnCourses.TabIndex = 3;
            btnCourses.Text = "View courses";
            btnCourses.UseVisualStyleBackColor = false;
            // 
            // AdminHomeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 709);
            Controls.Add(btnCourses);
            Controls.Add(btnLecturers);
            Controls.Add(btnNotifs);
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