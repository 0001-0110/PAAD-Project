﻿namespace PAAD_Client.Administrator
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
            cbCourses = new ComboBox();
            btnBack = new Button();
            adminHeaderuc1 = new AdminHeaderUC();
            SuspendLayout();
            // 
            // btnPost
            // 
            btnPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPost.Location = new Point(497, 608);
            btnPost.Margin = new Padding(2, 2, 2, 2);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(119, 50);
            btnPost.TabIndex = 0;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // flpNotificationsContainer
            // 
            flpNotificationsContainer.AutoScroll = true;
            flpNotificationsContainer.BackColor = SystemColors.ControlLight;
            flpNotificationsContainer.Location = new Point(72, 233);
            flpNotificationsContainer.Margin = new Padding(2, 2, 2, 2);
            flpNotificationsContainer.Name = "flpNotificationsContainer";
            flpNotificationsContainer.Padding = new Padding(4, 4, 4, 4);
            flpNotificationsContainer.Size = new Size(968, 356);
            flpNotificationsContainer.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(485, 121);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 7;
            label1.Text = "Notifications";
            // 
            // cbCourses
            // 
            cbCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCourses.FormattingEnabled = true;
            cbCourses.Location = new Point(371, 178);
            cbCourses.Margin = new Padding(2, 2, 2, 2);
            cbCourses.Name = "cbCourses";
            cbCourses.Size = new Size(370, 28);
            cbCourses.TabIndex = 10;
            cbCourses.SelectedIndexChanged += cbCourses_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(18, 106);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 45);
            btnBack.TabIndex = 11;
            btnBack.Text = "[back array]";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // adminHeaderuc1
            // 
            adminHeaderuc1.BackColor = SystemColors.ScrollBar;
            adminHeaderuc1.Dock = DockStyle.Top;
            adminHeaderuc1.Location = new Point(0, 0);
            adminHeaderuc1.Name = "adminHeaderuc1";
            adminHeaderuc1.Size = new Size(1112, 90);
            adminHeaderuc1.TabIndex = 12;
            // 
            // AdminViewNotifForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 675);
            Controls.Add(adminHeaderuc1);
            Controls.Add(btnBack);
            Controls.Add(cbCourses);
            Controls.Add(btnPost);
            Controls.Add(flpNotificationsContainer);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AdminViewNotifForm";
            Text = "View Notifications";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPost;
        private FlowLayoutPanel flpNotificationsContainer;
        private Label label1;
        private ComboBox cbCourses;
        private Button btnBack;
        private AdminHeaderUC adminHeaderuc1;
    }
}