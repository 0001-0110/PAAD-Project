namespace PAAD.HMI.Administrator
{
	partial class AdminHomeUC
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
			btnCourses = new Button();
			btnLecturers = new Button();
			btnNotifs = new Button();
			SuspendLayout();
			// 
			// btnCourses
			// 
			btnCourses.Anchor = AnchorStyles.None;
			btnCourses.BackColor = SystemColors.ScrollBar;
			btnCourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnCourses.Location = new Point(570, 536);
			btnCourses.Margin = new Padding(4);
			btnCourses.Name = "btnCourses";
			btnCourses.Size = new Size(250, 62);
			btnCourses.TabIndex = 6;
			btnCourses.Text = "View courses";
			btnCourses.UseVisualStyleBackColor = false;
			btnCourses.Click += btnCourses_Click;
			// 
			// btnLecturers
			// 
			btnLecturers.Anchor = AnchorStyles.None;
			btnLecturers.BackColor = SystemColors.ScrollBar;
			btnLecturers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLecturers.Location = new Point(570, 392);
			btnLecturers.Margin = new Padding(4);
			btnLecturers.Name = "btnLecturers";
			btnLecturers.Size = new Size(250, 62);
			btnLecturers.TabIndex = 5;
			btnLecturers.Text = "View lecturers";
			btnLecturers.UseVisualStyleBackColor = false;
			btnLecturers.Click += btnLecturers_Click;
			// 
			// btnNotifs
			// 
			btnNotifs.Anchor = AnchorStyles.None;
			btnNotifs.BackColor = SystemColors.ScrollBar;
			btnNotifs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnNotifs.Location = new Point(570, 246);
			btnNotifs.Margin = new Padding(4);
			btnNotifs.Name = "btnNotifs";
			btnNotifs.Size = new Size(250, 62);
			btnNotifs.TabIndex = 4;
			btnNotifs.Text = "View notifications";
			btnNotifs.UseVisualStyleBackColor = false;
			btnNotifs.Click += btnNotifs_Click;
			// 
			// AdminHomeUC
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnCourses);
			Controls.Add(btnLecturers);
			Controls.Add(btnNotifs);
			Name = "AdminHomeUC";
			Size = new Size(1390, 844);
			ResumeLayout(false);
		}

		#endregion

		private Button btnCourses;
		private Button btnLecturers;
		private Button btnNotifs;
	}
}
