namespace PAAD.HMI.Administrator
{
	partial class AddLecturerForm
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
			lbTitle = new Label();
			tbFirstName = new TextBox();
			lbFirstName = new Label();
			tbLastName = new TextBox();
			lbLastName = new Label();
			tbEmail = new TextBox();
			lbEmail = new Label();
			tbPassword = new TextBox();
			lbPassword = new Label();
			lbCourse = new Label();
			cbCourses = new ComboBox();
			btnSubmit = new Button();
			btnCancel = new Button();
			SuspendLayout();
			// 
			// lbTitle
			// 
			lbTitle.AutoSize = true;
			lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			lbTitle.Location = new Point(331, 35);
			lbTitle.Margin = new Padding(2, 0, 2, 0);
			lbTitle.Name = "lbTitle";
			lbTitle.Size = new Size(232, 38);
			lbTitle.TabIndex = 0;
			lbTitle.Text = "[Action] lecturer";
			// 
			// tbFirstName
			// 
			tbFirstName.Location = new Point(29, 141);
			tbFirstName.Margin = new Padding(1);
			tbFirstName.Name = "tbFirstName";
			tbFirstName.Size = new Size(375, 31);
			tbFirstName.TabIndex = 6;
			// 
			// lbFirstName
			// 
			lbFirstName.AutoSize = true;
			lbFirstName.Location = new Point(29, 111);
			lbFirstName.Margin = new Padding(1, 0, 1, 0);
			lbFirstName.Name = "lbFirstName";
			lbFirstName.Size = new Size(98, 25);
			lbFirstName.TabIndex = 5;
			lbFirstName.Text = "First name:";
			// 
			// tbLastName
			// 
			tbLastName.Location = new Point(29, 236);
			tbLastName.Margin = new Padding(1);
			tbLastName.Name = "tbLastName";
			tbLastName.Size = new Size(375, 31);
			tbLastName.TabIndex = 8;
			// 
			// lbLastName
			// 
			lbLastName.AutoSize = true;
			lbLastName.Location = new Point(29, 206);
			lbLastName.Margin = new Padding(1, 0, 1, 0);
			lbLastName.Name = "lbLastName";
			lbLastName.Size = new Size(96, 25);
			lbLastName.TabIndex = 7;
			lbLastName.Text = "Last name:";
			// 
			// tbEmail
			// 
			tbEmail.Location = new Point(510, 141);
			tbEmail.Margin = new Padding(1);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(375, 31);
			tbEmail.TabIndex = 10;
			// 
			// lbEmail
			// 
			lbEmail.AutoSize = true;
			lbEmail.Location = new Point(510, 111);
			lbEmail.Margin = new Padding(1, 0, 1, 0);
			lbEmail.Name = "lbEmail";
			lbEmail.Size = new Size(58, 25);
			lbEmail.TabIndex = 9;
			lbEmail.Text = "Email:";
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(510, 235);
			tbPassword.Margin = new Padding(1);
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '•';
			tbPassword.Size = new Size(375, 31);
			tbPassword.TabIndex = 12;
			// 
			// lbPassword
			// 
			lbPassword.AutoSize = true;
			lbPassword.Location = new Point(510, 205);
			lbPassword.Margin = new Padding(1, 0, 1, 0);
			lbPassword.Name = "lbPassword";
			lbPassword.Size = new Size(91, 25);
			lbPassword.TabIndex = 11;
			lbPassword.Text = "Password:";
			// 
			// lbCourse
			// 
			lbCourse.AutoSize = true;
			lbCourse.Location = new Point(29, 301);
			lbCourse.Margin = new Padding(1, 0, 1, 0);
			lbCourse.Name = "lbCourse";
			lbCourse.Size = new Size(71, 25);
			lbCourse.TabIndex = 13;
			lbCourse.Text = "Course:";
			// 
			// cbCourses
			// 
			cbCourses.FormattingEnabled = true;
			cbCourses.Location = new Point(29, 331);
			cbCourses.Margin = new Padding(4);
			cbCourses.Name = "cbCourses";
			cbCourses.Size = new Size(375, 33);
			cbCourses.Sorted = true;
			cbCourses.TabIndex = 14;
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = SystemColors.Highlight;
			btnSubmit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			btnSubmit.ForeColor = SystemColors.ButtonHighlight;
			btnSubmit.Location = new Point(132, 404);
			btnSubmit.Margin = new Padding(2);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(179, 52);
			btnSubmit.TabIndex = 16;
			btnSubmit.Text = "Submit";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.Brown;
			btnCancel.DialogResult = DialogResult.Cancel;
			btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			btnCancel.ForeColor = SystemColors.ButtonHighlight;
			btnCancel.Location = new Point(614, 404);
			btnCancel.Margin = new Padding(2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(179, 52);
			btnCancel.TabIndex = 15;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			// 
			// AddLecturerForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(915, 504);
			Controls.Add(btnSubmit);
			Controls.Add(btnCancel);
			Controls.Add(cbCourses);
			Controls.Add(lbCourse);
			Controls.Add(tbPassword);
			Controls.Add(lbPassword);
			Controls.Add(tbEmail);
			Controls.Add(lbEmail);
			Controls.Add(tbLastName);
			Controls.Add(lbLastName);
			Controls.Add(tbFirstName);
			Controls.Add(lbFirstName);
			Controls.Add(lbTitle);
			Margin = new Padding(4);
			Name = "AddLecturerForm";
			Text = "AddLecturerForm";
			Load += AddLecturerForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbTitle;
		private TextBox tbFirstName;
		private Label lbFirstName;
		private TextBox tbLastName;
		private Label lbLastName;
		private TextBox tbEmail;
		private Label lbEmail;
		private TextBox tbPassword;
		private Label lbPassword;
		private Label lbCourse;
		private ComboBox cbCourses;
		private Button btnSubmit;
		private Button btnCancel;
	}
}