namespace PAAD.HMI.Administrator
{
    partial class AdminViewNotifForm
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
            btnPost = new Button();
            flpNotificationsContainer = new FlowLayoutPanel();
            label1 = new Label();
            pnlHeader = new Panel();
            btnLogout = new Button();
            lbAdmin = new Label();
            lbLecturerName = new Label();
            cbCourses = new ComboBox();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // btnPost
            // 
            btnPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPost.Location = new Point(621, 760);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(149, 62);
            btnPost.TabIndex = 0;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // flpNotificationsContainer
            // 
            flpNotificationsContainer.AutoScroll = true;
            flpNotificationsContainer.BackColor = SystemColors.ControlLight;
            flpNotificationsContainer.Location = new Point(90, 291);
            flpNotificationsContainer.Name = "flpNotificationsContainer";
            flpNotificationsContainer.Padding = new Padding(5);
            flpNotificationsContainer.Size = new Size(1210, 445);
            flpNotificationsContainer.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(606, 151);
            label1.Name = "label1";
            label1.Size = new Size(179, 38);
            label1.TabIndex = 7;
            label1.Text = "Notifications";
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
            pnlHeader.TabIndex = 6;
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
            btnLogout.Click += btnLogout_Click;
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
            // cbCourses
            // 
            cbCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCourses.FormattingEnabled = true;
            cbCourses.Location = new Point(464, 222);
            cbCourses.Name = "cbCourses";
            cbCourses.Size = new Size(462, 33);
            cbCourses.TabIndex = 10;
            cbCourses.SelectedIndexChanged += cbCourses_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(23, 133);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 56);
            btnBack.TabIndex = 11;
            btnBack.Text = "[back array]";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminViewNotifForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 844);
            Controls.Add(btnBack);
            Controls.Add(cbCourses);
            Controls.Add(btnPost);
            Controls.Add(flpNotificationsContainer);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            Name = "AdminViewNotifForm";
            Text = "View Notifications";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPost;
        private FlowLayoutPanel flpNotificationsContainer;
        private Label label1;
        private Panel pnlHeader;
        private Label lbAdmin;
        private Label lbLecturerName;
        private ComboBox cbCourses;
        private Button btnLogout;
        private Button btnBack;
    }
}