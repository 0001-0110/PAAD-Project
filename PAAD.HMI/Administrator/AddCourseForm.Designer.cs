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
            label3 = new Label();
            btnCancel = new Button();
            textBox1 = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(312, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 0;
            // 
            // lbAction
            // 
            lbAction.AutoSize = true;
            lbAction.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbAction.Location = new Point(204, 30);
            lbAction.Name = "lbAction";
            lbAction.Size = new Size(208, 38);
            lbAction.TabIndex = 1;
            lbAction.Text = "[Action] course";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 139);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(371, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(179, 53);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(515, 31);
            textBox1.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.Highlight;
            btnSubmit.DialogResult = DialogResult.OK;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(70, 300);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(179, 53);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 418);
            Controls.Add(btnSubmit);
            Controls.Add(textBox1);
            Controls.Add(btnCancel);
            Controls.Add(label3);
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
        private Label label3;
        private Button btnCancel;
        private TextBox textBox1;
        private Button btnSubmit;
    }
}