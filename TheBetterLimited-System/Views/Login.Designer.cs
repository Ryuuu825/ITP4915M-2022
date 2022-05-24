namespace TheBetterLimited.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Logo = new System.Windows.Forms.Panel();
            this.CompanyTitle1 = new System.Windows.Forms.Label();
            this.CompanyTitle0 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.loginContainer = new System.Windows.Forms.Panel();
            this.showPwd = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.username = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.ChangePassword = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.forgotPwd = new System.Windows.Forms.LinkLabel();
            this.Welcome = new System.Windows.Forms.Label();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.loginContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPwd)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Logo.Controls.Add(this.CompanyTitle1);
            this.Logo.Controls.Add(this.CompanyTitle0);
            this.Logo.Controls.Add(this.pictureBox1);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(550, 674);
            this.Logo.TabIndex = 0;
            // 
            // CompanyTitle1
            // 
            this.CompanyTitle1.AutoSize = true;
            this.CompanyTitle1.Font = new System.Drawing.Font("Segoe UI", 41.7479F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CompanyTitle1.ForeColor = System.Drawing.Color.White;
            this.CompanyTitle1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompanyTitle1.Location = new System.Drawing.Point(124, 426);
            this.CompanyTitle1.Name = "CompanyTitle1";
            this.CompanyTitle1.Size = new System.Drawing.Size(303, 92);
            this.CompanyTitle1.TabIndex = 5;
            this.CompanyTitle1.Text = "Limited.";
            // 
            // CompanyTitle0
            // 
            this.CompanyTitle0.AutoSize = true;
            this.CompanyTitle0.Font = new System.Drawing.Font("Segoe UI", 41.7479F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CompanyTitle0.ForeColor = System.Drawing.Color.SeaGreen;
            this.CompanyTitle0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompanyTitle0.Location = new System.Drawing.Point(157, 321);
            this.CompanyTitle0.Name = "CompanyTitle0";
            this.CompanyTitle0.Size = new System.Drawing.Size(236, 92);
            this.CompanyTitle0.TabIndex = 4;
            this.CompanyTitle0.Text = "Better";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheBetterLimited.Properties.Resources.logo46;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(163, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.loginContainer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(550, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(712, 674);
            this.mainPanel.TabIndex = 5;
            // 
            // loginContainer
            // 
            this.loginContainer.BackColor = System.Drawing.Color.White;
            this.loginContainer.Controls.Add(this.showPwd);
            this.loginContainer.Controls.Add(this.usernameLabel);
            this.loginContainer.Controls.Add(this.username);
            this.loginContainer.Controls.Add(this.passwordLabel);
            this.loginContainer.Controls.Add(this.password);
            this.loginContainer.Controls.Add(this.ChangePassword);
            this.loginContainer.Controls.Add(this.loginBtn);
            this.loginContainer.Controls.Add(this.forgotPwd);
            this.loginContainer.Controls.Add(this.Welcome);
            this.loginContainer.Controls.Add(this.LoginTitle);
            this.loginContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginContainer.Location = new System.Drawing.Point(0, 0);
            this.loginContainer.Margin = new System.Windows.Forms.Padding(0);
            this.loginContainer.Name = "loginContainer";
            this.loginContainer.Size = new System.Drawing.Size(712, 674);
            this.loginContainer.TabIndex = 1;
            // 
            // showPwd
            // 
            this.showPwd.BackgroundImage = global::TheBetterLimited.Properties.Resources.eye;
            this.showPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPwd.Location = new System.Drawing.Point(571, 361);
            this.showPwd.Name = "showPwd";
            this.showPwd.Size = new System.Drawing.Size(30, 30);
            this.showPwd.TabIndex = 6;
            this.showPwd.TabStop = false;
            this.showPwd.Click += new System.EventHandler(this.showPwd_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.usernameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usernameLabel.Location = new System.Drawing.Point(100, 194);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(99, 28);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BorderColor = System.Drawing.Color.LightGray;
            this.username.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.username.BorderRadius = 20;
            this.username.BorderSize = 1;
            this.username.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.username.Location = new System.Drawing.Point(100, 236);
            this.username.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.username.MaxLength = 10;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(15);
            this.username.PasswordChar = false;
            this.username.Size = new System.Drawing.Size(515, 59);
            this.username.TabIndex = 0;
            this.username.Texts = "";
            this.username.UnderlinedStyle = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.passwordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordLabel.Location = new System.Drawing.Point(100, 307);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(93, 28);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BorderColor = System.Drawing.Color.LightGray;
            this.password.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.password.BorderRadius = 20;
            this.password.BorderSize = 1;
            this.password.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.password.Location = new System.Drawing.Point(100, 347);
            this.password.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.password.MaxLength = 20;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(15);
            this.password.PasswordChar = true;
            this.password.Size = new System.Drawing.Size(515, 59);
            this.password.TabIndex = 1;
            this.password.Texts = "";
            this.password.UnderlinedStyle = false;
            // 
            // ChangePassword
            // 
            this.ChangePassword.ActiveLinkColor = System.Drawing.Color.Black;
            this.ChangePassword.AutoSize = true;
            this.ChangePassword.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.ChangePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChangePassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ChangePassword.LinkColor = System.Drawing.Color.Black;
            this.ChangePassword.Location = new System.Drawing.Point(100, 420);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(166, 28);
            this.ChangePassword.TabIndex = 2;
            this.ChangePassword.TabStop = true;
            this.ChangePassword.Text = "Change password";
            this.ChangePassword.VisitedLinkColor = System.Drawing.Color.Black;
            this.ChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangePassword_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.BorderColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.BorderRadius = 20;
            this.loginBtn.BorderSize = 0;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginBtn.Location = new System.Drawing.Point(188, 484);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(339, 50);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Sign In";
            this.loginBtn.TextColor = System.Drawing.Color.White;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // forgotPwd
            // 
            this.forgotPwd.ActiveLinkColor = System.Drawing.Color.Black;
            this.forgotPwd.AutoSize = true;
            this.forgotPwd.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.forgotPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.forgotPwd.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.forgotPwd.LinkColor = System.Drawing.Color.Black;
            this.forgotPwd.Location = new System.Drawing.Point(446, 420);
            this.forgotPwd.Name = "forgotPwd";
            this.forgotPwd.Size = new System.Drawing.Size(169, 28);
            this.forgotPwd.TabIndex = 3;
            this.forgotPwd.TabStop = true;
            this.forgotPwd.Text = "Forgot password?";
            this.forgotPwd.VisitedLinkColor = System.Drawing.Color.Black;
            this.forgotPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPwd_LinkClicked);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 14.10084F, System.Drawing.FontStyle.Bold);
            this.Welcome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Welcome.Location = new System.Drawing.Point(91, 80);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(187, 32);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "Welcome back!";
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LoginTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoginTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginTitle.Location = new System.Drawing.Point(91, 117);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(429, 54);
            this.LoginTitle.TabIndex = 0;
            this.LoginTitle.Text = "Login in your account";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 674);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better Limited (Login)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.Logo.ResumeLayout(false);
            this.Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.loginContainer.ResumeLayout(false);
            this.loginContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPwd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel loginContainer;
        private System.Windows.Forms.Label CompanyTitle1;
        private System.Windows.Forms.Label CompanyTitle0;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.LinkLabel forgotPwd;
        private CustomizeControl.RoundButton loginBtn;
        private CustomizeControl.CustomizeTextbox password;
        private CustomizeControl.CustomizeTextbox username;
        private System.Windows.Forms.LinkLabel ChangePassword;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox showPwd;
    }
}