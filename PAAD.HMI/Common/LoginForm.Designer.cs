namespace PAAD_Client
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            label3 = new Label();
            btnSubmitLogin = new Button();
            lbErrorEmail = new Label();
            lbErrorPassword = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(283, 62);
            label1.Name = "label1";
            label1.Size = new Size(98, 38);
            label1.TabIndex = 0;
            label1.Text = "Log in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 196);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(36, 224);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(593, 31);
            tbEmail.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(36, 366);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(593, 31);
            tbPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 338);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.BackColor = SystemColors.Highlight;
            btnSubmitLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitLogin.ForeColor = SystemColors.ButtonHighlight;
            btnSubmitLogin.Location = new Point(262, 519);
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.Size = new Size(141, 68);
            btnSubmitLogin.TabIndex = 5;
            btnSubmitLogin.Text = "Submit";
            btnSubmitLogin.UseVisualStyleBackColor = false;
            // 
            // lbErrorEmail
            // 
            lbErrorEmail.AutoSize = true;
            lbErrorEmail.ForeColor = Color.Red;
            lbErrorEmail.Location = new Point(635, 226);
            lbErrorEmail.Name = "lbErrorEmail";
            lbErrorEmail.Size = new Size(23, 25);
            lbErrorEmail.TabIndex = 6;
            lbErrorEmail.Text = "X";
            lbErrorEmail.Visible = false;
            // 
            // lbErrorPassword
            // 
            lbErrorPassword.AutoSize = true;
            lbErrorPassword.ForeColor = Color.Red;
            lbErrorPassword.Location = new Point(635, 368);
            lbErrorPassword.Name = "lbErrorPassword";
            lbErrorPassword.Size = new Size(23, 25);
            lbErrorPassword.TabIndex = 7;
            lbErrorPassword.Text = "X";
            lbErrorPassword.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 615);
            Controls.Add(lbErrorPassword);
            Controls.Add(lbErrorEmail);
            Controls.Add(btnSubmitLogin);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Label label3;
        private Button btnSubmitLogin;
        private Label lbErrorEmail;
        private Label lbErrorPassword;
    }
}