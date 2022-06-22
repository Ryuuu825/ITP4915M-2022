namespace TheBetterLimited.Views
{
    partial class Usermanagement_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usermanagement_Add));
            this.Header = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.UserIconPic = new System.Windows.Forms.PictureBox();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.CreateUser = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.AccountInfo = new System.Windows.Forms.Panel();
            this.AccountInfoContainer = new System.Windows.Forms.Panel();
            this.showPwd = new System.Windows.Forms.PictureBox();
            this.DoubleCheckCorrect = new System.Windows.Forms.PictureBox();
            this.PwdCorrect = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StrengthCircle3 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.StrengthCircle2 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.StrengthCircle1 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.Email = new System.Windows.Forms.Label();
            this.emailTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.pwdTxt2 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.password = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.pwdTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.AccountHeaderContainer = new System.Windows.Forms.Panel();
            this.AccountHeader = new System.Windows.Forms.Label();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchStaffBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.StaffIDTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.staffName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PositionTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.position = new System.Windows.Forms.Label();
            this.DeptTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.gender = new System.Windows.Forms.Label();
            this.StaffNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.MaleGenderRadio = new System.Windows.Forms.RadioButton();
            this.FemaleGenderRadio = new System.Windows.Forms.RadioButton();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.UserInfoHeader = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPic)).BeginInit();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.AccountInfo.SuspendLayout();
            this.AccountInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleCheckCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PwdCorrect)).BeginInit();
            this.panel2.SuspendLayout();
            this.AccountHeaderContainer.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            resources.ApplyResources(this.Header, "Header");
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Info);
            this.Header.Controls.Add(this.tip);
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.UserIconPic);
            this.Header.Name = "Header";
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
            // 
            // tip
            // 
            resources.ApplyResources(this.tip, "tip");
            this.tip.Name = "tip";
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.Color.SeaGreen;
            this.Title.Name = "Title";
            // 
            // UserIconPic
            // 
            resources.ApplyResources(this.UserIconPic, "UserIconPic");
            this.UserIconPic.BackColor = System.Drawing.Color.Transparent;
            this.UserIconPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserIconPic.Image = global::TheBetterLimited.Properties.Resources._default;
            this.UserIconPic.Name = "UserIconPic";
            this.UserIconPic.TabStop = false;
            this.UserIconPic.Click += new System.EventHandler(this.UserIconPic_Click);
            this.UserIconPic.Paint += new System.Windows.Forms.PaintEventHandler(this.UserIconPic_Paint);
            this.UserIconPic.MouseLeave += new System.EventHandler(this.UserIconPic_MouseLeave);
            this.UserIconPic.MouseHover += new System.EventHandler(this.UserIconPic_MouseHover);
            // 
            // BottomBtn
            // 
            resources.ApplyResources(this.BottomBtn, "BottomBtn");
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.CreateUser);
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Name = "BottomBtn";
            // 
            // CancelBtn
            // 
            resources.ApplyResources(this.CancelBtn, "CancelBtn");
            this.CancelBtn.BackColor = System.Drawing.Color.Silver;
            this.CancelBtn.BackgroundColor = System.Drawing.Color.Silver;
            this.CancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CancelBtn.BorderRadius = 10;
            this.CancelBtn.BorderSize = 0;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(182)))), ((int)(((byte)(99)))));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.IsChecked = false;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.TextColor = System.Drawing.Color.White;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateUser
            // 
            resources.ApplyResources(this.CreateUser, "CreateUser");
            this.CreateUser.BackColor = System.Drawing.Color.SeaGreen;
            this.CreateUser.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.CreateUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateUser.BorderRadius = 10;
            this.CreateUser.BorderSize = 0;
            this.CreateUser.FlatAppearance.BorderSize = 0;
            this.CreateUser.ForeColor = System.Drawing.Color.White;
            this.CreateUser.IsChecked = false;
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.TextColor = System.Drawing.Color.White;
            this.CreateUser.UseVisualStyleBackColor = false;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this.MainForm, "MainForm");
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.AccountInfo);
            this.MainForm.Controls.Add(this.UserInfo);
            this.MainForm.Name = "MainForm";
            // 
            // AccountInfo
            // 
            resources.ApplyResources(this.AccountInfo, "AccountInfo");
            this.AccountInfo.BackColor = System.Drawing.Color.Transparent;
            this.AccountInfo.Controls.Add(this.AccountInfoContainer);
            this.AccountInfo.Controls.Add(this.AccountHeaderContainer);
            this.AccountInfo.Name = "AccountInfo";
            // 
            // AccountInfoContainer
            // 
            resources.ApplyResources(this.AccountInfoContainer, "AccountInfoContainer");
            this.AccountInfoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AccountInfoContainer.Controls.Add(this.showPwd);
            this.AccountInfoContainer.Controls.Add(this.DoubleCheckCorrect);
            this.AccountInfoContainer.Controls.Add(this.PwdCorrect);
            this.AccountInfoContainer.Controls.Add(this.panel2);
            this.AccountInfoContainer.Controls.Add(this.Email);
            this.AccountInfoContainer.Controls.Add(this.emailTxt);
            this.AccountInfoContainer.Controls.Add(this.label5);
            this.AccountInfoContainer.Controls.Add(this.pwdTxt2);
            this.AccountInfoContainer.Controls.Add(this.password);
            this.AccountInfoContainer.Controls.Add(this.userName);
            this.AccountInfoContainer.Controls.Add(this.userNameTxt);
            this.AccountInfoContainer.Controls.Add(this.pwdTxt);
            this.AccountInfoContainer.Name = "AccountInfoContainer";
            // 
            // showPwd
            // 
            resources.ApplyResources(this.showPwd, "showPwd");
            this.showPwd.BackgroundImage = global::TheBetterLimited.Properties.Resources.eye;
            this.showPwd.Name = "showPwd";
            this.showPwd.TabStop = false;
            this.showPwd.Click += new System.EventHandler(this.showPwd_Click);
            // 
            // DoubleCheckCorrect
            // 
            resources.ApplyResources(this.DoubleCheckCorrect, "DoubleCheckCorrect");
            this.DoubleCheckCorrect.BackgroundImage = global::TheBetterLimited.Properties.Resources.corret;
            this.DoubleCheckCorrect.Name = "DoubleCheckCorrect";
            this.DoubleCheckCorrect.TabStop = false;
            // 
            // PwdCorrect
            // 
            resources.ApplyResources(this.PwdCorrect, "PwdCorrect");
            this.PwdCorrect.BackgroundImage = global::TheBetterLimited.Properties.Resources.corret;
            this.PwdCorrect.Name = "PwdCorrect";
            this.PwdCorrect.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.StrengthCircle3);
            this.panel2.Controls.Add(this.StrengthCircle2);
            this.panel2.Controls.Add(this.StrengthCircle1);
            this.panel2.Name = "panel2";
            // 
            // StrengthCircle3
            // 
            resources.ApplyResources(this.StrengthCircle3, "StrengthCircle3");
            this.StrengthCircle3.BackColor = System.Drawing.Color.LightGray;
            this.StrengthCircle3.BackgroundColor = System.Drawing.Color.LightGray;
            this.StrengthCircle3.BorderColor = System.Drawing.Color.DimGray;
            this.StrengthCircle3.BorderRadius = 6;
            this.StrengthCircle3.BorderSize = 0;
            this.StrengthCircle3.ForeColor = System.Drawing.Color.White;
            this.StrengthCircle3.Name = "StrengthCircle3";
            // 
            // StrengthCircle2
            // 
            resources.ApplyResources(this.StrengthCircle2, "StrengthCircle2");
            this.StrengthCircle2.BackColor = System.Drawing.Color.LightGray;
            this.StrengthCircle2.BackgroundColor = System.Drawing.Color.LightGray;
            this.StrengthCircle2.BorderColor = System.Drawing.Color.DimGray;
            this.StrengthCircle2.BorderRadius = 6;
            this.StrengthCircle2.BorderSize = 0;
            this.StrengthCircle2.ForeColor = System.Drawing.Color.White;
            this.StrengthCircle2.Name = "StrengthCircle2";
            // 
            // StrengthCircle1
            // 
            resources.ApplyResources(this.StrengthCircle1, "StrengthCircle1");
            this.StrengthCircle1.BackColor = System.Drawing.Color.LightGray;
            this.StrengthCircle1.BackgroundColor = System.Drawing.Color.LightGray;
            this.StrengthCircle1.BorderColor = System.Drawing.Color.DimGray;
            this.StrengthCircle1.BorderRadius = 6;
            this.StrengthCircle1.BorderSize = 0;
            this.StrengthCircle1.ForeColor = System.Drawing.Color.White;
            this.StrengthCircle1.Name = "StrengthCircle1";
            // 
            // Email
            // 
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // emailTxt
            // 
            resources.ApplyResources(this.emailTxt, "emailTxt");
            this.emailTxt.BackColor = System.Drawing.Color.White;
            this.emailTxt.BorderColor = System.Drawing.Color.LightGray;
            this.emailTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.emailTxt.BorderRadius = 10;
            this.emailTxt.BorderSize = 1;
            this.emailTxt.ForeColor = System.Drawing.Color.Black;
            this.emailTxt.IsError = false;
            this.emailTxt.MaxLength = 20;
            this.emailTxt.Multiline = false;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = false;
            this.emailTxt.Placeholder = "Please enter email address";
            this.emailTxt.ReadOnly = false;
            this.emailTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.emailTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.emailTxt.Texts = "Please enter email address";
            this.emailTxt.UnderlinedStyle = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pwdTxt2
            // 
            resources.ApplyResources(this.pwdTxt2, "pwdTxt2");
            this.pwdTxt2.BackColor = System.Drawing.Color.White;
            this.pwdTxt2.BorderColor = System.Drawing.Color.LightGray;
            this.pwdTxt2.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.pwdTxt2.BorderRadius = 10;
            this.pwdTxt2.BorderSize = 1;
            this.pwdTxt2.ForeColor = System.Drawing.Color.Black;
            this.pwdTxt2.IsError = false;
            this.pwdTxt2.MaxLength = 20;
            this.pwdTxt2.Multiline = false;
            this.pwdTxt2.Name = "pwdTxt2";
            this.pwdTxt2.PasswordChar = true;
            this.pwdTxt2.Placeholder = "Please enter password again";
            this.pwdTxt2.ReadOnly = false;
            this.pwdTxt2.TbBackColor = System.Drawing.Color.White;
            this.pwdTxt2.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.pwdTxt2.Texts = "Please enter password again";
            this.pwdTxt2.UnderlinedStyle = false;
            this.pwdTxt2._Leave += new System.EventHandler(this.pwdTxt2_Leave);
            this.pwdTxt2.Click += new System.EventHandler(this.pwdTxt2_Click);
            this.pwdTxt2.Enter += new System.EventHandler(this.pwdTxt2_Enter);
            this.pwdTxt2.Leave += new System.EventHandler(this.pwdTxt2_Leave);
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // userName
            // 
            resources.ApplyResources(this.userName, "userName");
            this.userName.Name = "userName";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // userNameTxt
            // 
            resources.ApplyResources(this.userNameTxt, "userNameTxt");
            this.userNameTxt.BackColor = System.Drawing.Color.White;
            this.userNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.userNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.userNameTxt.BorderRadius = 10;
            this.userNameTxt.BorderSize = 1;
            this.userNameTxt.ForeColor = System.Drawing.Color.Black;
            this.userNameTxt.IsError = false;
            this.userNameTxt.MaxLength = 20;
            this.userNameTxt.Multiline = false;
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.PasswordChar = false;
            this.userNameTxt.Placeholder = "Please enter user name";
            this.userNameTxt.ReadOnly = false;
            this.userNameTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.userNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.userNameTxt.Texts = "Please enter user name";
            this.userNameTxt.UnderlinedStyle = false;
            this.userNameTxt.Click += new System.EventHandler(this.userNameTxt_Click);
            this.userNameTxt.Enter += new System.EventHandler(this.userNameTxt_Enter);
            // 
            // pwdTxt
            // 
            resources.ApplyResources(this.pwdTxt, "pwdTxt");
            this.pwdTxt.BackColor = System.Drawing.Color.White;
            this.pwdTxt.BorderColor = System.Drawing.Color.LightGray;
            this.pwdTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.pwdTxt.BorderRadius = 10;
            this.pwdTxt.BorderSize = 1;
            this.pwdTxt.ForeColor = System.Drawing.Color.Black;
            this.pwdTxt.IsError = false;
            this.pwdTxt.MaxLength = 20;
            this.pwdTxt.Multiline = false;
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = true;
            this.pwdTxt.Placeholder = "Please enter password";
            this.pwdTxt.ReadOnly = false;
            this.pwdTxt.TbBackColor = System.Drawing.Color.White;
            this.pwdTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.pwdTxt.Texts = "Please enter password";
            this.pwdTxt.UnderlinedStyle = false;
            this.pwdTxt._TextChanged += new System.EventHandler(this.pwdTxt__TextChanged);
            this.pwdTxt._Enter += new System.EventHandler(this.pwdTxt_Enter);
            this.pwdTxt.Click += new System.EventHandler(this.pwdTxt_Click);
            this.pwdTxt.Enter += new System.EventHandler(this.pwdTxt_Enter);
            // 
            // AccountHeaderContainer
            // 
            resources.ApplyResources(this.AccountHeaderContainer, "AccountHeaderContainer");
            this.AccountHeaderContainer.BackColor = System.Drawing.Color.White;
            this.AccountHeaderContainer.Controls.Add(this.AccountHeader);
            this.AccountHeaderContainer.Name = "AccountHeaderContainer";
            // 
            // AccountHeader
            // 
            resources.ApplyResources(this.AccountHeader, "AccountHeader");
            this.AccountHeader.Name = "AccountHeader";
            // 
            // UserInfo
            // 
            resources.ApplyResources(this.UserInfo, "UserInfo");
            this.UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.UserInfo.Controls.Add(this.panel1);
            this.UserInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.UserInfo.Name = "UserInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.SearchStaffBtn);
            this.panel1.Controls.Add(this.StaffIDTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.staffName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PositionTxt);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.DeptTxt);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.StaffNameTxt);
            this.panel1.Controls.Add(this.MaleGenderRadio);
            this.panel1.Controls.Add(this.FemaleGenderRadio);
            this.panel1.Name = "panel1";
            // 
            // SearchStaffBtn
            // 
            resources.ApplyResources(this.SearchStaffBtn, "SearchStaffBtn");
            this.SearchStaffBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchStaffBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.SearchStaffBtn.BackgroundImage = global::TheBetterLimited.Properties.Resources.search;
            this.SearchStaffBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SearchStaffBtn.BorderRadius = 0;
            this.SearchStaffBtn.BorderSize = 0;
            this.SearchStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchStaffBtn.FlatAppearance.BorderSize = 0;
            this.SearchStaffBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SearchStaffBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SearchStaffBtn.ForeColor = System.Drawing.Color.White;
            this.SearchStaffBtn.IsChecked = false;
            this.SearchStaffBtn.Name = "SearchStaffBtn";
            this.SearchStaffBtn.TextColor = System.Drawing.Color.White;
            this.SearchStaffBtn.UseVisualStyleBackColor = false;
            this.SearchStaffBtn.Click += new System.EventHandler(this.SearchStaffBtn_Click);
            // 
            // StaffIDTxt
            // 
            resources.ApplyResources(this.StaffIDTxt, "StaffIDTxt");
            this.StaffIDTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.StaffIDTxt.BackColor = System.Drawing.Color.White;
            this.StaffIDTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StaffIDTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StaffIDTxt.BorderRadius = 10;
            this.StaffIDTxt.BorderSize = 1;
            this.StaffIDTxt.ForeColor = System.Drawing.Color.Black;
            this.StaffIDTxt.IsError = false;
            this.StaffIDTxt.MaxLength = 5;
            this.StaffIDTxt.Multiline = false;
            this.StaffIDTxt.Name = "StaffIDTxt";
            this.StaffIDTxt.PasswordChar = false;
            this.StaffIDTxt.Placeholder = "Please enter staff ID";
            this.StaffIDTxt.ReadOnly = false;
            this.StaffIDTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.StaffIDTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.StaffIDTxt.Texts = "Please enter staff ID";
            this.StaffIDTxt.UnderlinedStyle = false;
            this.StaffIDTxt._TextChanged += new System.EventHandler(this.StaffIDTxt__TextChanged);
            this.StaffIDTxt.Click += new System.EventHandler(this.StaffIDTxt_Click);
            this.StaffIDTxt.Enter += new System.EventHandler(this.StaffIDTxt_Enter);
            this.StaffIDTxt.Leave += new System.EventHandler(this.StaffIDTxt_Leave);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // staffName
            // 
            resources.ApplyResources(this.staffName, "staffName");
            this.staffName.Name = "staffName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PositionTxt
            // 
            resources.ApplyResources(this.PositionTxt, "PositionTxt");
            this.PositionTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PositionTxt.BorderColor = System.Drawing.Color.LightGray;
            this.PositionTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.PositionTxt.BorderRadius = 10;
            this.PositionTxt.BorderSize = 1;
            this.PositionTxt.ForeColor = System.Drawing.Color.LightGray;
            this.PositionTxt.IsError = false;
            this.PositionTxt.MaxLength = 32767;
            this.PositionTxt.Multiline = false;
            this.PositionTxt.Name = "PositionTxt";
            this.PositionTxt.PasswordChar = false;
            this.PositionTxt.Placeholder = "";
            this.PositionTxt.ReadOnly = false;
            this.PositionTxt.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.PositionTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.PositionTxt.Texts = "Automatic Data Entry";
            this.PositionTxt.UnderlinedStyle = false;
            // 
            // position
            // 
            resources.ApplyResources(this.position, "position");
            this.position.Name = "position";
            // 
            // DeptTxt
            // 
            resources.ApplyResources(this.DeptTxt, "DeptTxt");
            this.DeptTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeptTxt.BorderColor = System.Drawing.Color.LightGray;
            this.DeptTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.DeptTxt.BorderRadius = 10;
            this.DeptTxt.BorderSize = 1;
            this.DeptTxt.ForeColor = System.Drawing.Color.LightGray;
            this.DeptTxt.IsError = false;
            this.DeptTxt.MaxLength = 32767;
            this.DeptTxt.Multiline = false;
            this.DeptTxt.Name = "DeptTxt";
            this.DeptTxt.PasswordChar = false;
            this.DeptTxt.Placeholder = "";
            this.DeptTxt.ReadOnly = false;
            this.DeptTxt.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.DeptTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.DeptTxt.Texts = "Automatic Data Entry";
            this.DeptTxt.UnderlinedStyle = false;
            // 
            // gender
            // 
            resources.ApplyResources(this.gender, "gender");
            this.gender.Name = "gender";
            // 
            // StaffNameTxt
            // 
            resources.ApplyResources(this.StaffNameTxt, "StaffNameTxt");
            this.StaffNameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StaffNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StaffNameTxt.BorderRadius = 10;
            this.StaffNameTxt.BorderSize = 1;
            this.StaffNameTxt.ForeColor = System.Drawing.Color.LightGray;
            this.StaffNameTxt.IsError = false;
            this.StaffNameTxt.MaxLength = 32767;
            this.StaffNameTxt.Multiline = false;
            this.StaffNameTxt.Name = "StaffNameTxt";
            this.StaffNameTxt.PasswordChar = false;
            this.StaffNameTxt.Placeholder = "";
            this.StaffNameTxt.ReadOnly = false;
            this.StaffNameTxt.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StaffNameTxt.Texts = "Automatic Data Entry";
            this.StaffNameTxt.UnderlinedStyle = false;
            // 
            // MaleGenderRadio
            // 
            resources.ApplyResources(this.MaleGenderRadio, "MaleGenderRadio");
            this.MaleGenderRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MaleGenderRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.MaleGenderRadio.Name = "MaleGenderRadio";
            this.MaleGenderRadio.UseVisualStyleBackColor = true;
            // 
            // FemaleGenderRadio
            // 
            resources.ApplyResources(this.FemaleGenderRadio, "FemaleGenderRadio");
            this.FemaleGenderRadio.Name = "FemaleGenderRadio";
            this.FemaleGenderRadio.UseVisualStyleBackColor = true;
            // 
            // UserInfoHeaderContainer
            // 
            resources.ApplyResources(this.UserInfoHeaderContainer, "UserInfoHeaderContainer");
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.UserInfoHeader);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            // 
            // UserInfoHeader
            // 
            resources.ApplyResources(this.UserInfoHeader, "UserInfoHeader");
            this.UserInfoHeader.Name = "UserInfoHeader";
            // 
            // Usermanagement_Add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Usermanagement_Add";
            this.ShowIcon = false;
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPic)).EndInit();
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.AccountInfo.ResumeLayout(false);
            this.AccountInfoContainer.ResumeLayout(false);
            this.AccountInfoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleCheckCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PwdCorrect)).EndInit();
            this.panel2.ResumeLayout(false);
            this.AccountHeaderContainer.ResumeLayout(false);
            this.AccountHeaderContainer.PerformLayout();
            this.UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label AccountHeader;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label staffName;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox userNameTxt;
        private CustomizeControl.CustomizeTextbox pwdTxt;
        private System.Windows.Forms.PictureBox UserIconPic;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Panel AccountInfo;
        private System.Windows.Forms.Panel AccountHeaderContainer;
        private System.Windows.Forms.Panel AccountInfoContainer;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label UserInfoHeader;
        private CustomizeControl.CustomizeTextbox StaffNameTxt;
        private CustomizeControl.CustomizeTextbox StaffIDTxt;
        private System.Windows.Forms.RadioButton FemaleGenderRadio;
        private System.Windows.Forms.RadioButton MaleGenderRadio;
        private System.Windows.Forms.Label gender;
        private CustomizeControl.CustomizeTextbox PositionTxt;
        private CustomizeControl.CustomizeTextbox DeptTxt;
        private System.Windows.Forms.Label label5;
        private CustomizeControl.CustomizeTextbox pwdTxt2;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton CreateUser;
        private CustomizeControl.RoundButton SearchStaffBtn;
        private System.Windows.Forms.Label Email;
        private CustomizeControl.CustomizeTextbox emailTxt;
        private System.Windows.Forms.Panel panel2;
        private CustomizeControl.RoundPanel StrengthCircle3;
        private CustomizeControl.RoundPanel StrengthCircle2;
        private CustomizeControl.RoundPanel StrengthCircle1;
        private System.Windows.Forms.PictureBox PwdCorrect;
        private System.Windows.Forms.PictureBox DoubleCheckCorrect;
        private System.Windows.Forms.PictureBox showPwd;
    }
}