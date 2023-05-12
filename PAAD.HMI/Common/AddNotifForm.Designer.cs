namespace PAAD.HMI.Lecturer
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
            tbExpirationDate = new TextBox();
            lbExpirationDate = new Label();
            tbDescription = new TextBox();
            lbDescription = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.Highlight;
            btnSubmit.DialogResult = DialogResult.OK;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(192, 366);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(161, 45);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // tbName
            // 
            tbName.Location = new Point(177, 63);
            tbName.Name = "tbName";
            tbName.Size = new Size(464, 29);
            tbName.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(463, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 45);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(177, 39);
            lbName.Name = "lbName";
            lbName.Size = new Size(55, 21);
            lbName.TabIndex = 7;
            lbName.Text = "Name:";
            // 
            // lbAction
            // 
            lbAction.AutoSize = true;
            lbAction.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbAction.Location = new Point(309, 9);
            lbAction.Name = "lbAction";
            lbAction.Size = new Size(184, 25);
            lbAction.TabIndex = 6;
            lbAction.Text = "[Action] notification";
            // 
            // tbExpirationDate
            // 
            tbExpirationDate.Location = new Point(177, 139);
            tbExpirationDate.Name = "tbExpirationDate";
            tbExpirationDate.Size = new Size(464, 29);
            tbExpirationDate.TabIndex = 12;
            // 
            // lbExpirationDate
            // 
            lbExpirationDate.AutoSize = true;
            lbExpirationDate.Location = new Point(177, 115);
            lbExpirationDate.Name = "lbExpirationDate";
            lbExpirationDate.Size = new Size(204, 21);
            lbExpirationDate.TabIndex = 11;
            lbExpirationDate.Text = "Expiration date (dd/mm/yy):";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(177, 216);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(464, 131);
            tbDescription.TabIndex = 14;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(177, 192);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(92, 21);
            lbDescription.TabIndex = 13;
            lbDescription.Text = "Description:";
            // 
            // AddNotifForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 423);
            Controls.Add(tbDescription);
            Controls.Add(lbDescription);
            Controls.Add(tbExpirationDate);
            Controls.Add(lbExpirationDate);
            Controls.Add(btnSubmit);
            Controls.Add(tbName);
            Controls.Add(btnCancel);
            Controls.Add(lbName);
            Controls.Add(lbAction);
            Name = "AddNotifForm";
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
        private TextBox tbExpirationDate;
        private Label lbExpirationDate;
        private TextBox tbDescription;
        private Label lbDescription;
    }
}