namespace PAAD.HMI.Administrator
{
    partial class AdminViewNotifsUC
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
            btnBack = new Button();
            cbCourses = new ComboBox();
            btnPost = new Button();
            flpNotificationsContainer = new FlowLayoutPanel();
            lbNotifs = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.backarrow;
            btnBack.Location = new Point(20, 111);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 47);
            btnBack.TabIndex = 16;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cbCourses
            // 
            cbCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCourses.FormattingEnabled = true;
            cbCourses.Location = new Point(418, 186);
            cbCourses.Margin = new Padding(2);
            cbCourses.Name = "cbCourses";
            cbCourses.Size = new Size(416, 29);
            cbCourses.TabIndex = 15;
            cbCourses.SelectedIndexChanged += cbCourses_SelectedIndexChanged;
            // 
            // btnPost
            // 
            btnPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPost.Location = new Point(559, 638);
            btnPost.Margin = new Padding(2);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(134, 52);
            btnPost.TabIndex = 12;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // flpNotificationsContainer
            // 
            flpNotificationsContainer.AutoScroll = true;
            flpNotificationsContainer.BackColor = SystemColors.ControlLight;
            flpNotificationsContainer.Location = new Point(81, 244);
            flpNotificationsContainer.Margin = new Padding(2);
            flpNotificationsContainer.Name = "flpNotificationsContainer";
            flpNotificationsContainer.Padding = new Padding(4, 4, 4, 4);
            flpNotificationsContainer.Size = new Size(1089, 374);
            flpNotificationsContainer.TabIndex = 14;
            // 
            // lbNotifs
            // 
            lbNotifs.AutoSize = true;
            lbNotifs.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbNotifs.Location = new Point(545, 127);
            lbNotifs.Margin = new Padding(2, 0, 2, 0);
            lbNotifs.Name = "lbNotifs";
            lbNotifs.Size = new Size(123, 25);
            lbNotifs.TabIndex = 13;
            lbNotifs.Text = "Notifications";
            // 
            // AdminViewNotifsUC
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBack);
            Controls.Add(cbCourses);
            Controls.Add(btnPost);
            Controls.Add(flpNotificationsContainer);
            Controls.Add(lbNotifs);
            Name = "AdminViewNotifsUC";
            Size = new Size(1251, 709);
            Load += AdminViewNotifsUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private ComboBox cbCourses;
        private Button btnPost;
        private FlowLayoutPanel flpNotificationsContainer;
        private Label lbNotifs;
    }
}
