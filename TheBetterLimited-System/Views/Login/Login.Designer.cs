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
            this.Logo.Size = new System.Drawing.Size(412, 539);
            this.Logo.TabIndex = 0;
            // 
            // CompanyTitle1
            // 
            this.CompanyTitle1.AutoSize = true;
            this.CompanyTitle1.Font = new System.Drawing.Font("Segoe UI", 41.7479F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CompanyTitle1.ForeColor = System.Drawing.Color.White;
            this.CompanyTitle1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompanyTitle1.Location = new System.Drawing.Point(93, 341);
            this.CompanyTitle1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyTitle1.Name = "CompanyTitle1";
            this.CompanyTitle1.Size = new System.Drawing.Size(246, 74);
            this.CompanyTitle1.TabIndex = 5;
            this.CompanyTitle1.Text = "Limited.";
            // 
            // CompanyTitle0
            // 
            this.CompanyTitle0.AutoSize = true;
            this.CompanyTitle0.Font = new System.Drawing.Font("Segoe UI", 41.7479F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CompanyTitle0.ForeColor = System.Drawing.Color.SeaGreen;
            this.CompanyTitle0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompanyTitle0.Location = new System.Drawing.Point(118, 257);
            this.CompanyTitle0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyTitle0.Name = "CompanyTitle0";
            this.CompanyTitle0.Size = new System.Drawing.Size(190, 74);
            this.CompanyTitle0.TabIndex = 4;
            this.CompanyTitle0.Text = "Better";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheBetterLimited.Properties.Resources.logo46;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(122, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.loginContainer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(412, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(534, 539);
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
            this.loginContainer.Controls.Add(this.loginBtn);
            this.loginContainer.Controls.Add(this.forgotPwd);
            this.loginContainer.Controls.Add(this.Welcome);
            this.loginContainer.Controls.Add(this.LoginTitle);
            this.loginContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginContainer.Location = new System.Drawing.Point(0, 0);
            this.loginContainer.Margin = new System.Windows.Forms.Padding(0);
            this.loginContainer.Name = "loginContainer";
            this.loginContainer.Size = new System.Drawing.Size(534, 539);
            this.loginContainer.TabIndex = 1;
            // 
            // showPwd
            // 
            this.showPwd.BackgroundImage = global::TheBetterLimited.Properties.Resources.eye;
            this.showPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPwd.Location = new System.Drawing.Point(428, 289);
            this.showPwd.Margin = new System.Windows.Forms.Padding(2);
            this.showPwd.Name = "showPwd";
            this.showPwd.Size = new System.Drawing.Size(22, 24);
            this.showPwd.TabIndex = 6;
            this.showPwd.TabStop = false;
            this.showPwd.Click += new System.EventHandler(this.showPwd_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.usernameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usernameLabel.Location = new System.Drawing.Point(75, 155);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 23);
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
            this.username.IsError = false;
            this.username.Location = new System.Drawing.Point(75, 189);
            this.username.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.username.MaxLength = 20;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.username.PasswordChar = false;
            this.username.Placeholder = "Plese input user name";
            this.username.ReadOnly = false;
            this.username.Size = new System.Drawing.Size(386, 48);
            this.username.TabIndex = 0;
            this.username.TbBackColor = System.Drawing.SystemColors.Window;
            this.username.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.username.Texts = "Plese input user name";
            this.username.UnderlinedStyle = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.passwordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordLabel.Location = new System.Drawing.Point(75, 246);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 23);
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
            this.password.IsError = false;
            this.password.Location = new System.Drawing.Point(75, 278);
            this.password.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.password.MaxLength = 20;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.password.PasswordChar = true;
            this.password.Placeholder = "Please input your password";
            this.password.ReadOnly = false;
            this.password.Size = new System.Drawing.Size(386, 48);
            this.password.TabIndex = 1;
            this.password.TbBackColor = System.Drawing.SystemColors.Window;
            this.password.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.password.Texts = "Please input your password";
            this.password.UnderlinedStyle = false;
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
            this.loginBtn.IsChecked = false;
            this.loginBtn.Location = new System.Drawing.Point(141, 387);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(254, 40);
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
            this.forgotPwd.Location = new System.Drawing.Point(317, 336);
            this.forgotPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forgotPwd.Name = "forgotPwd";
            this.forgotPwd.Size = new System.Drawing.Size(144, 23);
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
            this.Welcome.Location = new System.Drawing.Point(68, 64);
            this.Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(146, 25);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "Welcome back!";
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LoginTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoginTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginTitle.Location = new System.Drawing.Point(68, 94);
            this.LoginTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(345, 45);
            this.LoginTitle.TabIndex = 0;
            this.LoginTitle.Text = "Login in your account";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(946, 539);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox showPwd;
    }
}