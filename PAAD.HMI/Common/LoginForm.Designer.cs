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
            lbError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 0;
            label1.Text = "Log in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 157);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(29, 179);
            tbEmail.Margin = new Padding(2, 2, 2, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(475, 27);
            tbEmail.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(29, 293);
            tbPassword.Margin = new Padding(2, 2, 2, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(475, 27);
            tbPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 270);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.BackColor = SystemColors.Highlight;
            btnSubmitLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitLogin.ForeColor = SystemColors.ButtonHighlight;
            btnSubmitLogin.Location = new Point(210, 415);
            btnSubmitLogin.Margin = new Padding(2, 2, 2, 2);
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.Size = new Size(113, 54);
            btnSubmitLogin.TabIndex = 5;
            btnSubmitLogin.Text = "Submit";
            btnSubmitLogin.UseVisualStyleBackColor = false;
            btnSubmitLogin.MouseClick += btnSubmitLogin_MouseClick;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.ForeColor = Color.Red;
            lbError.Location = new Point(29, 113);
            lbError.Margin = new Padding(2, 0, 2, 0);
            lbError.Name = "lbError";
            lbError.Size = new Size(225, 20);
            lbError.TabIndex = 7;
            lbError.Text = "Invalid email adress or password";
            lbError.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 492);
            Controls.Add(lbError);
            Controls.Add(btnSubmitLogin);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
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
        private Label lbError;
    }
}