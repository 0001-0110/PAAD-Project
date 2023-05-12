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
            label1.Location = new Point(281, 26);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // lbAction
            // 
            lbAction.AutoSize = true;
            lbAction.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbAction.Location = new Point(184, 25);
            lbAction.Name = "lbAction";
            lbAction.Size = new Size(141, 25);
            lbAction.TabIndex = 1;
            lbAction.Text = "[Action] course";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(46, 117);
            lbName.Name = "lbName";
            lbName.Size = new Size(55, 21);
            lbName.TabIndex = 2;
            lbName.Text = "Name:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(334, 252);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 45);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // tbName
            // 
            tbName.Location = new Point(46, 152);
            tbName.Name = "tbName";
            tbName.Size = new Size(464, 29);
            tbName.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.Highlight;
            btnSubmit.DialogResult = DialogResult.OK;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(63, 252);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(161, 45);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 351);
            Controls.Add(btnSubmit);
            Controls.Add(tbName);
            Controls.Add(btnCancel);
            Controls.Add(lbName);
            Controls.Add(lbAction);
            Controls.Add(label1);
            Name = "AddCourseForm";
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