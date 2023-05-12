namespace PAAD.HMI.Lecturer
{
    partial class LecturerViewNotifForm
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
            pnlHeader = new Panel();
            btnLogout = new Button();
            lbCourseName = new Label();
            lbLecturerName = new Label();
            label1 = new Label();
            flpNotificationsContainer = new FlowLayoutPanel();
            btnPost = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ScrollBar;
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lbCourseName);
            pnlHeader.Controls.Add(lbLecturerName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.ForeColor = SystemColors.ControlText;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1390, 111);
            pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.RosyBrown;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(1202, 19);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(168, 70);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lbCourseName
            // 
            lbCourseName.AutoSize = true;
            lbCourseName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCourseName.Location = new Point(12, 62);
            lbCourseName.Name = "lbCourseName";
            lbCourseName.Size = new Size(169, 32);
            lbCourseName.TabIndex = 1;
            lbCourseName.Text = "[Course name]";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(606, 142);
            label1.Name = "label1";
            label1.Size = new Size(179, 38);
            label1.TabIndex = 3;
            label1.Text = "Notifications";
            // 
            // flpNotificationsContainer
            // 
            flpNotificationsContainer.AutoScroll = true;
            flpNotificationsContainer.BackColor = SystemColors.ControlLight;
            flpNotificationsContainer.Location = new Point(90, 213);
            flpNotificationsContainer.Name = "flpNotificationsContainer";
            flpNotificationsContainer.Padding = new Padding(5);
            flpNotificationsContainer.Size = new Size(1210, 500);
            flpNotificationsContainer.TabIndex = 4;
            // 
            // btnPost
            // 
            btnPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPost.Location = new Point(621, 749);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(149, 62);
            btnPost.TabIndex = 5;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // LecturerViewNotifForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 844);
            Controls.Add(btnPost);
            Controls.Add(flpNotificationsContainer);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            Name = "LecturerViewNotifForm";
            Text = "View notifications";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Button btnLogout;
        private Label lbCourseName;
        private Label lbLecturerName;
        private Label label1;
        private FlowLayoutPanel flpNotificationsContainer;
        private Button btnPost;
    }
}