namespace PAAD_Client.Common
{
    partial class NotificationUC
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
            btnDelete = new Button();
            btnEdit = new Button();
            lbTitle = new Label();
            lbAuthor = new Label();
            lbDescription = new Label();
            label4 = new Label();
            label5 = new Label();
            lbExpirationDate = new Label();
            lbPublicationDate = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(924, 11);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 50);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Highlight;
            btnEdit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(786, 11);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(109, 50);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.ForeColor = SystemColors.ActiveCaptionText;
            lbTitle.Location = new Point(16, 21);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(49, 21);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "[Title]";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.ForeColor = SystemColors.ActiveCaptionText;
            lbAuthor.Location = new Point(50, 57);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(68, 21);
            lbAuthor.TabIndex = 3;
            lbAuthor.Text = "[Author]";
            // 
            // lbDescription
            // 
            lbDescription.BackColor = SystemColors.ControlDark;
            lbDescription.BorderStyle = BorderStyle.FixedSingle;
            lbDescription.ForeColor = SystemColors.ActiveCaptionText;
            lbDescription.Location = new Point(12, 93);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(1022, 99);
            lbDescription.TabIndex = 4;
            lbDescription.Text = "[Description]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(16, 208);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 5;
            label4.Text = "published the:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(803, 208);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 6;
            label5.Text = "expires the:";
            // 
            // lbExpirationDate
            // 
            lbExpirationDate.AutoSize = true;
            lbExpirationDate.ForeColor = SystemColors.ActiveCaptionText;
            lbExpirationDate.Location = new Point(899, 208);
            lbExpirationDate.Name = "lbExpirationDate";
            lbExpirationDate.Size = new Size(110, 21);
            lbExpirationDate.TabIndex = 7;
            lbExpirationDate.Text = "[dd/mm/yyyy]";
            // 
            // lbPublicationDate
            // 
            lbPublicationDate.AutoSize = true;
            lbPublicationDate.ForeColor = SystemColors.ActiveCaptionText;
            lbPublicationDate.Location = new Point(133, 208);
            lbPublicationDate.Name = "lbPublicationDate";
            lbPublicationDate.Size = new Size(110, 21);
            lbPublicationDate.TabIndex = 8;
            lbPublicationDate.Text = "[dd/mm/yyyy]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(16, 57);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 9;
            label2.Text = "by";
            // 
            // NotificationUC
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(label2);
            Controls.Add(lbPublicationDate);
            Controls.Add(lbExpirationDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbDescription);
            Controls.Add(lbAuthor);
            Controls.Add(lbTitle);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Margin = new Padding(4, 4, 4, 4);
            Name = "NotificationUC";
            Padding = new Padding(4, 4, 4, 4);
            Size = new Size(1044, 234);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnEdit;
        private Label lbTitle;
        private Label lbAuthor;
        private Label lbDescription;
        private Label label4;
        private Label label5;
        private Label lbExpirationDate;
        private Label lbPublicationDate;
        private Label label2;
    }
}
