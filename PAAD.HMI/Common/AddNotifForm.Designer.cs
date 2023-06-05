﻿namespace PAAD.HMI.Lecturer
{
	partial class AddNotifForm
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
			btnSubmit = new Button();
			tbName = new TextBox();
			btnCancel = new Button();
			lbName = new Label();
			lbAction = new Label();
			lbExpirationDate = new Label();
			tbDescription = new TextBox();
			lbDescription = new Label();
			dateTimePicker_ExpirationDate = new DateTimePicker();
			SuspendLayout();
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = SystemColors.Highlight;
			btnSubmit.DialogResult = DialogResult.OK;
			btnSubmit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			btnSubmit.ForeColor = SystemColors.ButtonHighlight;
			btnSubmit.Location = new Point(214, 436);
			btnSubmit.Margin = new Padding(4, 4, 4, 4);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(179, 54);
			btnSubmit.TabIndex = 10;
			btnSubmit.Text = "Submit";
			btnSubmit.UseVisualStyleBackColor = false;
			// 
			// tbName
			// 
			tbName.Location = new Point(196, 75);
			tbName.Margin = new Padding(4, 4, 4, 4);
			tbName.Name = "tbName";
			tbName.Size = new Size(515, 31);
			tbName.TabIndex = 9;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.Brown;
			btnCancel.DialogResult = DialogResult.Cancel;
			btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
			btnCancel.ForeColor = SystemColors.ButtonHighlight;
			btnCancel.Location = new Point(515, 436);
			btnCancel.Margin = new Padding(4, 4, 4, 4);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(179, 54);
			btnCancel.TabIndex = 8;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			// 
			// lbName
			// 
			lbName.AutoSize = true;
			lbName.Location = new Point(196, 46);
			lbName.Margin = new Padding(4, 0, 4, 0);
			lbName.Name = "lbName";
			lbName.Size = new Size(63, 25);
			lbName.TabIndex = 7;
			lbName.Text = "Name:";
			// 
			// lbAction
			// 
			lbAction.AutoSize = true;
			lbAction.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
			lbAction.Location = new Point(344, 11);
			lbAction.Margin = new Padding(4, 0, 4, 0);
			lbAction.Name = "lbAction";
			lbAction.Size = new Size(223, 38);
			lbAction.TabIndex = 6;
			lbAction.Text = "Add notification";
			// 
			// lbExpirationDate
			// 
			lbExpirationDate.AutoSize = true;
			lbExpirationDate.Location = new Point(196, 138);
			lbExpirationDate.Margin = new Padding(4, 0, 4, 0);
			lbExpirationDate.Name = "lbExpirationDate";
			lbExpirationDate.Size = new Size(235, 25);
			lbExpirationDate.TabIndex = 11;
			lbExpirationDate.Text = "Expiration date (dd/mm/yy):";
			// 
			// tbDescription
			// 
			tbDescription.Location = new Point(196, 258);
			tbDescription.Margin = new Padding(4, 4, 4, 4);
			tbDescription.Multiline = true;
			tbDescription.Name = "tbDescription";
			tbDescription.ScrollBars = ScrollBars.Vertical;
			tbDescription.Size = new Size(515, 155);
			tbDescription.TabIndex = 14;
			// 
			// lbDescription
			// 
			lbDescription.AutoSize = true;
			lbDescription.Location = new Point(196, 229);
			lbDescription.Margin = new Padding(4, 0, 4, 0);
			lbDescription.Name = "lbDescription";
			lbDescription.Size = new Size(106, 25);
			lbDescription.TabIndex = 13;
			lbDescription.Text = "Description:";
			// 
			// dateTimePicker_ExpirationDate
			// 
			dateTimePicker_ExpirationDate.Location = new Point(196, 166);
			dateTimePicker_ExpirationDate.Name = "dateTimePicker_ExpirationDate";
			dateTimePicker_ExpirationDate.Size = new Size(319, 31);
			dateTimePicker_ExpirationDate.TabIndex = 15;
			dateTimePicker_ExpirationDate.Value = new DateTime(2023, 5, 20, 19, 36, 48, 0);
			// 
			// AddNotifForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(915, 504);
			Controls.Add(dateTimePicker_ExpirationDate);
			Controls.Add(tbDescription);
			Controls.Add(lbDescription);
			Controls.Add(lbExpirationDate);
			Controls.Add(btnSubmit);
			Controls.Add(tbName);
			Controls.Add(btnCancel);
			Controls.Add(lbName);
			Controls.Add(lbAction);
			Margin = new Padding(4, 4, 4, 4);
			Name = "AddNotifForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "LecturerAddNotifForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnSubmit;
		private TextBox tbName;
		private Button btnCancel;
		private Label lbName;
		private Label lbAction;
		private Label lbExpirationDate;
		private TextBox tbDescription;
		private Label lbDescription;
		private DateTimePicker dateTimePicker_ExpirationDate;
	}
}