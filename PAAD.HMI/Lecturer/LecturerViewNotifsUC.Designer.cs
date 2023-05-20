namespace PAAD.HMI.Lecturer
{
	partial class LecturerViewNotifsUC
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
			btnPost = new Button();
			flpNotificationsContainer = new FlowLayoutPanel();
			lbTitle = new Label();
			SuspendLayout();
			// 
			// btnPost
			// 
			btnPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnPost.Location = new Point(621, 749);
			btnPost.Margin = new Padding(4);
			btnPost.Name = "btnPost";
			btnPost.Size = new Size(149, 62);
			btnPost.TabIndex = 8;
			btnPost.Text = "Post";
			btnPost.UseVisualStyleBackColor = true;
			btnPost.Click += btnPost_Click;
			// 
			// flpNotificationsContainer
			// 
			flpNotificationsContainer.AutoScroll = true;
			flpNotificationsContainer.BackColor = SystemColors.ControlLight;
			flpNotificationsContainer.Location = new Point(90, 212);
			flpNotificationsContainer.Margin = new Padding(4);
			flpNotificationsContainer.Name = "flpNotificationsContainer";
			flpNotificationsContainer.Padding = new Padding(5);
			flpNotificationsContainer.Size = new Size(1210, 500);
			flpNotificationsContainer.TabIndex = 7;
			// 
			// lbTitle
			// 
			lbTitle.AutoSize = true;
			lbTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
			lbTitle.Location = new Point(605, 141);
			lbTitle.Margin = new Padding(4, 0, 4, 0);
			lbTitle.Name = "lbTitle";
			lbTitle.Size = new Size(179, 38);
			lbTitle.TabIndex = 6;
			lbTitle.Text = "Notifications";
			// 
			// LecturerViewNotifsUC
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnPost);
			Controls.Add(flpNotificationsContainer);
			Controls.Add(lbTitle);
			Name = "LecturerViewNotifsUC";
			Size = new Size(1390, 844);
			Load += LecturerViewNotifsUC_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnPost;
		private FlowLayoutPanel flpNotificationsContainer;
		private Label lbTitle;
	}
}
