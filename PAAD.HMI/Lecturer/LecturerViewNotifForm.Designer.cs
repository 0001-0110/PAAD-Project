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
            lbTitle = new Label();
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
            pnlHeader.Size = new Size(1112, 89);
            pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.RosyBrown;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(962, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(134, 56);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lbCourseName
            // 
            lbCourseName.AutoSize = true;
            lbCourseName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCourseName.Location = new Point(10, 50);
            lbCourseName.Name = "lbCourseName";
            lbCourseName.Size = new Size(137, 28);
            lbCourseName.TabIndex = 1;
            lbCourseName.Text = "[Course name]";
            // 
            // lbLecturerName
            // 
            lbLecturerName.AutoSize = true;
            lbLecturerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLecturerName.Location = new Point(10, 10);
            lbLecturerName.Name = "lbLecturerName";
            lbLecturerName.Size = new Size(218, 28);
            lbLecturerName.TabIndex = 0;
            lbLecturerName.Text = "[First name] [Last name]";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(484, 113);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(152, 32);
            lbTitle.TabIndex = 3;
            lbTitle.Text = "Notifications";
            // 
            // flpNotificationsContainer
            // 
            flpNotificationsContainer.AutoScroll = true;
            flpNotificationsContainer.BackColor = SystemColors.ControlLight;
            flpNotificationsContainer.Location = new Point(72, 170);
            flpNotificationsContainer.Name = "flpNotificationsContainer";
            flpNotificationsContainer.Padding = new Padding(4);
            flpNotificationsContainer.Size = new Size(968, 400);
            flpNotificationsContainer.TabIndex = 4;
            // 
            // btnPost
            // 
            btnPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPost.Location = new Point(497, 599);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(119, 50);
            btnPost.TabIndex = 5;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // LecturerViewNotifForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 675);
            Controls.Add(btnPost);
            Controls.Add(flpNotificationsContainer);
            Controls.Add(lbTitle);
            Controls.Add(pnlHeader);
            Name = "LecturerViewNotifForm";
            Text = "View notifications";
            Load += LecturerViewNotifForm_Load;
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
        private Label lbTitle;
        private FlowLayoutPanel flpNotificationsContainer;
        private Button btnPost;
    }
}