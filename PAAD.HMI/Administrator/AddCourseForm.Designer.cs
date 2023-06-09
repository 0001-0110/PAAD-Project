namespace PAAD.HMI.Administrator
{
	partial class AddCourseForm
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
			label1 = new Label();
			lbAction = new Label();
			lbName = new Label();
			btnCancel = new Button();
			tbName = new TextBox();
			btnSubmit = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(250, 25);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(0, 32);
			label1.TabIndex = 0;
			// 
			// lbAction
			// 
			lbAction.AutoSize = true;
			lbAction.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
			lbAction.Location = new Point(163, 24);
			lbAction.Margin = new Padding(2, 0, 2, 0);
			lbAction.Name = "lbAction";
			lbAction.Size = new Size(178, 32);
			lbAction.TabIndex = 1;
			lbAction.Text = "[Action] course";
			// 
			// lbName
			// 
			lbName.AutoSize = true;
			lbName.Location = new Point(41, 111);
			lbName.Margin = new Padding(2, 0, 2, 0);
			lbName.Name = "lbName";
			lbName.Size = new Size(52, 20);
			lbName.TabIndex = 2;
			lbName.Text = "Name:";
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.Brown;
			btnCancel.DialogResult = DialogResult.Cancel;
			btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			btnCancel.ForeColor = SystemColors.ButtonHighlight;
			btnCancel.Location = new Point(297, 240);
			btnCancel.Margin = new Padding(2, 3, 2, 3);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(143, 43);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			// 
			// tbName
			// 
			tbName.Location = new Point(41, 145);
			tbName.Margin = new Padding(2, 3, 2, 3);
			tbName.Name = "tbName";
			tbName.Size = new Size(413, 27);
			tbName.TabIndex = 4;
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = SystemColors.Highlight;
			btnSubmit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			btnSubmit.ForeColor = SystemColors.ButtonHighlight;
			btnSubmit.Location = new Point(56, 240);
			btnSubmit.Margin = new Padding(2, 3, 2, 3);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(143, 43);
			btnSubmit.TabIndex = 5;
			btnSubmit.Text = "Submit";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// AddCourseForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(493, 334);
			Controls.Add(btnSubmit);
			Controls.Add(tbName);
			Controls.Add(btnCancel);
			Controls.Add(lbName);
			Controls.Add(lbAction);
			Controls.Add(label1);
			Margin = new Padding(2, 3, 2, 3);
			CourseName = "AddCourseForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Add course";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label lbAction;
		private Label lbName;
		private Button btnCancel;
		private TextBox tbName;
		private Button btnSubmit;
	}
}