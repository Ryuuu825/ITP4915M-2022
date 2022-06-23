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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.loginContainer = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.forgotPwd = new System.Windows.Forms.LinkLabel();
            this.Welcome = new System.Windows.Forms.Label();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showPwd = new System.Windows.Forms.PictureBox();
            this.username = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.password = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.loginBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.Logo.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.loginContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPwd)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Logo.Controls.Add(this.CompanyTitle1);
            this.Logo.Controls.Add(this.CompanyTitle0);
            this.Logo.Controls.Add(this.pictureBox1);
            this.Logo.Name = "Logo";
            // 
            // CompanyTitle1
            // 
            resources.ApplyResources(this.CompanyTitle1, "CompanyTitle1");
            this.CompanyTitle1.ForeColor = System.Drawing.Color.White;
            this.CompanyTitle1.Name = "CompanyTitle1";
            // 
            // CompanyTitle0
            // 
            resources.ApplyResources(this.CompanyTitle0, "CompanyTitle0");
            this.CompanyTitle0.ForeColor = System.Drawing.Color.SeaGreen;
            this.CompanyTitle0.Name = "CompanyTitle0";
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Controls.Add(this.loginContainer);
            this.mainPanel.Name = "mainPanel";
            // 
            // loginContainer
            // 
            resources.ApplyResources(this.loginContainer, "loginContainer");
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
            this.loginContainer.Name = "loginContainer";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // forgotPwd
            // 
            resources.ApplyResources(this.forgotPwd, "forgotPwd");
            this.forgotPwd.ActiveLinkColor = System.Drawing.Color.Black;
            this.forgotPwd.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.forgotPwd.LinkColor = System.Drawing.Color.Black;
            this.forgotPwd.Name = "forgotPwd";
            this.forgotPwd.TabStop = true;
            this.forgotPwd.VisitedLinkColor = System.Drawing.Color.Black;
            this.forgotPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPwd_LinkClicked);
            // 
            // Welcome
            // 
            resources.ApplyResources(this.Welcome, "Welcome");
            this.Welcome.Name = "Welcome";
            // 
            // LoginTitle
            // 
            resources.ApplyResources(this.LoginTitle, "LoginTitle");
            this.LoginTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoginTitle.Name = "LoginTitle";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackgroundImage = global::TheBetterLimited.Properties.Resources.logo46;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // showPwd
            // 
            resources.ApplyResources(this.showPwd, "showPwd");
            this.showPwd.BackgroundImage = global::TheBetterLimited.Properties.Resources.eye;
            this.showPwd.Name = "showPwd";
            this.showPwd.TabStop = false;
            this.showPwd.Click += new System.EventHandler(this.showPwd_Click);
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BorderColor = System.Drawing.Color.LightGray;
            this.username.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.username.BorderRadius = 20;
            this.username.BorderSize = 1;
            this.username.IsError = false;
            this.username.MaxLength = 20;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.PasswordChar = false;
            this.username.Placeholder = "Plese input user name";
            this.username.ReadOnly = false;
            this.username.TbBackColor = System.Drawing.SystemColors.Window;
            this.username.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.username.Texts = "Plese input user name";
            this.username.UnderlinedStyle = false;
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BorderColor = System.Drawing.Color.LightGray;
            this.password.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.password.BorderRadius = 20;
            this.password.BorderSize = 1;
            this.password.IsError = false;
            this.password.MaxLength = 20;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.PasswordChar = true;
            this.password.Placeholder = "Please input your password";
            this.password.ReadOnly = false;
            this.password.TbBackColor = System.Drawing.SystemColors.Window;
            this.password.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.password.Texts = "Please input your password";
            this.password.UnderlinedStyle = false;
            // 
            // loginBtn
            // 
            resources.ApplyResources(this.loginBtn, "loginBtn");
            this.loginBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.BorderColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.BorderRadius = 20;
            this.loginBtn.BorderSize = 0;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.IsChecked = false;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.TextColor = System.Drawing.Color.White;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.Logo.ResumeLayout(false);
            this.Logo.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.loginContainer.ResumeLayout(false);
            this.loginContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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