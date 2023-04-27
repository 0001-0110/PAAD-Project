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
            button1 = new Button();
            button2 = new Button();
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
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1027, 13);
            button1.Name = "button1";
            button1.Size = new Size(121, 59);
            button1.TabIndex = 0;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(873, 13);
            button2.Name = "button2";
            button2.Size = new Size(121, 59);
            button2.TabIndex = 1;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.ForeColor = SystemColors.ActiveCaptionText;
            lbTitle.Location = new Point(18, 25);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(54, 25);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "[Title]";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.ForeColor = SystemColors.ActiveCaptionText;
            lbAuthor.Location = new Point(56, 68);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(77, 25);
            lbAuthor.TabIndex = 3;
            lbAuthor.Text = "[Author]";
            // 
            // lbDescription
            // 
            lbDescription.BackColor = SystemColors.ControlDark;
            lbDescription.BorderStyle = BorderStyle.FixedSingle;
            lbDescription.ForeColor = SystemColors.ActiveCaptionText;
            lbDescription.Location = new Point(13, 111);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(1135, 117);
            lbDescription.TabIndex = 4;
            lbDescription.Text = "[Description]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(18, 248);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 5;
            label4.Text = "published the:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(892, 248);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 6;
            label5.Text = "expires the:";
            // 
            // lbExpirationDate
            // 
            lbExpirationDate.AutoSize = true;
            lbExpirationDate.ForeColor = SystemColors.ActiveCaptionText;
            lbExpirationDate.Location = new Point(999, 248);
            lbExpirationDate.Name = "lbExpirationDate";
            lbExpirationDate.Size = new Size(126, 25);
            lbExpirationDate.TabIndex = 7;
            lbExpirationDate.Text = "[dd/mm/yyyy]";
            // 
            // lbPublicationDate
            // 
            lbPublicationDate.AutoSize = true;
            lbPublicationDate.ForeColor = SystemColors.ActiveCaptionText;
            lbPublicationDate.Location = new Point(148, 248);
            lbPublicationDate.Name = "lbPublicationDate";
            lbPublicationDate.Size = new Size(126, 25);
            lbPublicationDate.TabIndex = 8;
            lbPublicationDate.Text = "[dd/mm/yyyy]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(32, 25);
            label2.TabIndex = 9;
            label2.Text = "by";
            // 
            // NotificationUC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(5);
            Name = "NotificationUC";
            Padding = new Padding(5);
            Size = new Size(1160, 279);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
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
