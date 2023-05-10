namespace PAAD_Client.Administrator
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
            lbNotifs = new Label();
            cbCourses = new ComboBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnPost
            // 
            btnPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPost.Location = new Point(559, 638);
            btnPost.Margin = new Padding(2);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(134, 52);
            btnPost.TabIndex = 0;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // flpNotificationsContainer
            // 
            flpNotificationsContainer.AutoScroll = true;
            flpNotificationsContainer.BackColor = SystemColors.ControlLight;
            flpNotificationsContainer.Location = new Point(81, 245);
            flpNotificationsContainer.Margin = new Padding(2);
            flpNotificationsContainer.Name = "flpNotificationsContainer";
            flpNotificationsContainer.Padding = new Padding(4);
            flpNotificationsContainer.Size = new Size(1089, 374);
            flpNotificationsContainer.TabIndex = 8;
            // 
            // lbNotifs
            // 
            lbNotifs.AutoSize = true;
            lbNotifs.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbNotifs.Location = new Point(546, 127);
            lbNotifs.Margin = new Padding(2, 0, 2, 0);
            lbNotifs.Name = "lbNotifs";
            lbNotifs.Size = new Size(123, 25);
            lbNotifs.TabIndex = 7;
            lbNotifs.Text = "Notifications";
            // 
            // cbCourses
            // 
            cbCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCourses.FormattingEnabled = true;
            cbCourses.Location = new Point(417, 187);
            cbCourses.Margin = new Padding(2);
            cbCourses.Name = "cbCourses";
            cbCourses.Size = new Size(416, 29);
            cbCourses.TabIndex = 10;
            cbCourses.SelectedIndexChanged += cbCourses_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 111);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 47);
            btnBack.TabIndex = 11;
            btnBack.Text = "[back array]";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminViewNotifForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 709);
            Controls.Add(btnBack);
            Controls.Add(cbCourses);
            Controls.Add(btnPost);
            Controls.Add(flpNotificationsContainer);
            Controls.Add(lbNotifs);
            Margin = new Padding(2);
            Name = "AdminViewNotifForm";
            Text = "View Notifications";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPost;
        private FlowLayoutPanel flpNotificationsContainer;
        private Label lbNotifs;
        private ComboBox cbCourses;
        private Button btnBack;
        private AdminHeaderUC adminHeaderuc1;
    }
}