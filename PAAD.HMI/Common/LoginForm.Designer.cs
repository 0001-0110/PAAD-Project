namespace PAAD.HMI.Common
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
            lbTitle = new Label();
            lbEmail = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            lbPassword = new Label();
            btnSubmitLogin = new Button();
            lbError = new Label();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(255, 52);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(68, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Log in";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(32, 165);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(51, 21);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(32, 188);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(534, 29);
            tbEmail.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(32, 307);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(534, 29);
            tbPassword.TabIndex = 4;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(32, 284);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(79, 21);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password:";
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.BackColor = SystemColors.Highlight;
            btnSubmitLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitLogin.ForeColor = SystemColors.ButtonHighlight;
            btnSubmitLogin.Location = new Point(236, 436);
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.Size = new Size(127, 57);
            btnSubmitLogin.TabIndex = 5;
            btnSubmitLogin.Text = "Submit";
            btnSubmitLogin.UseVisualStyleBackColor = false;
            btnSubmitLogin.MouseClick += btnSubmitLogin_MouseClick;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.ForeColor = Color.Red;
            lbError.Location = new Point(32, 118);
            lbError.Name = "lbError";
            lbError.Size = new Size(237, 21);
            lbError.TabIndex = 7;
            lbError.Text = "Invalid email adress or password";
            lbError.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 517);
            Controls.Add(lbError);
            Controls.Add(btnSubmitLogin);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(tbEmail);
            Controls.Add(lbEmail);
            Controls.Add(lbTitle);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbEmail;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Label lbPassword;
        private Button btnSubmitLogin;
        private Label lbErrorEmail;
        private Label lbError;
    }
}
