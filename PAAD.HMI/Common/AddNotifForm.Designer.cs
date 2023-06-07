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
            components = new System.ComponentModel.Container();
            btnSubmit = new Button();
            tbName = new TextBox();
            btnCancel = new Button();
            lbName = new Label();
            lbAction = new Label();
            lbExpirationDate = new Label();
            tbDescription = new TextBox();
            lbDescription = new Label();
            dateTimePicker_ExpirationDate = new DateTimePicker();
            errorProvider_Name = new ErrorProvider(components);
            errorProvider_Date = new ErrorProvider(components);
            errorProvider_Description = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider_Name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Date).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Description).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.Highlight;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(171, 349);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(143, 43);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(157, 60);
            tbName.Name = "tbName";
            tbName.Size = new Size(413, 27);
            tbName.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(412, 349);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 43);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(157, 37);
            lbName.Name = "lbName";
            lbName.Size = new Size(52, 20);
            lbName.TabIndex = 7;
            lbName.Text = "Name:";
            // 
            // lbAction
            // 
            lbAction.AutoSize = true;
            lbAction.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbAction.Location = new Point(275, 9);
            lbAction.Name = "lbAction";
            lbAction.Size = new Size(189, 32);
            lbAction.TabIndex = 6;
            lbAction.Text = "Add notification";
            // 
            // lbExpirationDate
            // 
            lbExpirationDate.AutoSize = true;
            lbExpirationDate.Location = new Point(157, 110);
            lbExpirationDate.Name = "lbExpirationDate";
            lbExpirationDate.Size = new Size(197, 20);
            lbExpirationDate.TabIndex = 11;
            lbExpirationDate.Text = "Expiration date (dd/mm/yy):";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(157, 206);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(413, 125);
            tbDescription.TabIndex = 14;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(157, 183);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(88, 20);
            lbDescription.TabIndex = 13;
            lbDescription.Text = "Description:";
            // 
            // dateTimePicker_ExpirationDate
            // 
            dateTimePicker_ExpirationDate.Location = new Point(157, 133);
            dateTimePicker_ExpirationDate.Margin = new Padding(2);
            dateTimePicker_ExpirationDate.Name = "dateTimePicker_ExpirationDate";
            dateTimePicker_ExpirationDate.Size = new Size(256, 27);
            dateTimePicker_ExpirationDate.TabIndex = 15;
            dateTimePicker_ExpirationDate.Value = new DateTime(2023, 5, 20, 19, 36, 48, 0);
            // 
            // errorProvider_Name
            // 
            errorProvider_Name.ContainerControl = this;
            // 
            // errorProvider_Date
            // 
            errorProvider_Date.ContainerControl = this;
            // 
            // errorProvider_Description
            // 
            errorProvider_Description.ContainerControl = this;
            // 
            // AddNotifForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 403);
            Controls.Add(dateTimePicker_ExpirationDate);
            Controls.Add(tbDescription);
            Controls.Add(lbDescription);
            Controls.Add(lbExpirationDate);
            Controls.Add(btnSubmit);
            Controls.Add(tbName);
            Controls.Add(btnCancel);
            Controls.Add(lbName);
            Controls.Add(lbAction);
            Name = "AddNotifForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LecturerAddNotifForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider_Name).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Date).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Description).EndInit();
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
        private ErrorProvider errorProvider_Name;
        private ErrorProvider errorProvider_Date;
        private ErrorProvider errorProvider_Description;
    }
}