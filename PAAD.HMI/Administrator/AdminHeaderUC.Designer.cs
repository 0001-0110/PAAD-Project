namespace PAAD.HMI.Administrator
{
	partial class AdminHeaderUC
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
			btnLogout = new Button();
			lbInfo = new Label();
			lbLecturerName = new Label();
			SuspendLayout();
			// 
			// btnLogout
			// 
			btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogout.Location = new Point(1144, 24);
			btnLogout.Margin = new Padding(2, 4, 2, 4);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(168, 66);
			btnLogout.TabIndex = 14;
			btnLogout.Text = "Log out";
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Click += btnLogout_Click;
			// 
			// lbInfo
			// 
			lbInfo.Anchor = AnchorStyles.Left;
			lbInfo.AutoSize = true;
			lbInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbInfo.Location = new Point(66, 64);
			lbInfo.Margin = new Padding(2, 0, 2, 0);
			lbInfo.Name = "lbInfo";
			lbInfo.Size = new Size(158, 32);
			lbInfo.TabIndex = 13;
			lbInfo.Text = "Administrator";
			// 
			// lbLecturerName
			// 
			lbLecturerName.Anchor = AnchorStyles.Left;
			lbLecturerName.AutoSize = true;
			lbLecturerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbLecturerName.Location = new Point(66, 14);
			lbLecturerName.Margin = new Padding(2, 0, 2, 0);
			lbLecturerName.Name = "lbLecturerName";
			lbLecturerName.Size = new Size(268, 32);
			lbLecturerName.TabIndex = 12;
			lbLecturerName.Text = "[First name] [Last name]";
			// 
			// AdminHeaderUC
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ScrollBar;
			Controls.Add(btnLogout);
			Controls.Add(lbInfo);
			Controls.Add(lbLecturerName);
			Margin = new Padding(4, 4, 4, 4);
			Name = "AdminHeaderUC";
			Size = new Size(1375, 112);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLogout;
		private Label lbInfo;
		private Label lbLecturerName;
	}
}
