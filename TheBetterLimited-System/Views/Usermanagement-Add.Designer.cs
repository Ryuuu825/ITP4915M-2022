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
            this.MainForm = new System.Windows.Forms.Panel();
            this.AccountInfo = new System.Windows.Forms.Panel();
            this.AccountInfoContainer = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PwdStrengthBar = new System.Windows.Forms.Panel();
            this.Fair = new System.Windows.Forms.Panel();
            this.Strongly = new System.Windows.Forms.Panel();
            this.Weak = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.AccountHeaderContainer = new System.Windows.Forms.Panel();
            this.AccountHeader = new System.Windows.Forms.Label();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.staffName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.MaleGenderRadio = new System.Windows.Forms.RadioButton();
            this.FemaleGenderRadio = new System.Windows.Forms.RadioButton();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.UserInfoHeader = new System.Windows.Forms.Label();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.CreateUser = new TheBetterLimited.CustomizeControl.RoundButton();
            this.customizeTextbox1 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.customizeTextbox6 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.userNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.pwdTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.SearchStaffBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.StaffIDTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.PositionTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.DeptTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StaffNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPic)).BeginInit();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.AccountInfo.SuspendLayout();
            this.AccountInfoContainer.SuspendLayout();
            this.PwdStrengthBar.SuspendLayout();
            this.AccountHeaderContainer.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Info);
            this.Header.Controls.Add(this.tip);
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.UserIconPic);
            this.Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(272, 600);
            this.Header.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(17, 303);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(240, 84);
            this.Info.TabIndex = 5;
            this.Info.Text = "Users belong to one organisation\r\nand can log in and use Better \r\nLimited System " +
    "either using a \r\nusername and password.";
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip.Location = new System.Drawing.Point(84, 245);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(167, 15);
            this.tip.TabIndex = 4;
            this.tip.Text = "Click image to upload photo";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.SeaGreen;
            this.Title.Location = new System.Drawing.Point(16, 273);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(103, 30);
            this.Title.TabIndex = 3;
            this.Title.Text = "Add User";
            // 
            // UserIconPic
            // 
            this.UserIconPic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserIconPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserIconPic.Image = ((System.Drawing.Image)(resources.GetObject("UserIconPic.Image")));
            this.UserIconPic.Location = new System.Drawing.Point(21, 12);
            this.UserIconPic.Name = "UserIconPic";
            this.UserIconPic.Size = new System.Drawing.Size(230, 230);
            this.UserIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIconPic.TabIndex = 2;
            this.UserIconPic.TabStop = false;
            this.UserIconPic.Click += new System.EventHandler(this.UserIconPic_Click);
            this.UserIconPic.MouseLeave += new System.EventHandler(this.UserIconPic_MouseLeave);
            this.UserIconPic.MouseHover += new System.EventHandler(this.UserIconPic_MouseHover);
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.CreateUser);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 536);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(492, 54);
            this.BottomBtn.TabIndex = 1;
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.AccountInfo);
            this.MainForm.Controls.Add(this.UserInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(272, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(512, 600);
            this.MainForm.TabIndex = 2;
            // 
            // AccountInfo
            // 
            this.AccountInfo.BackColor = System.Drawing.Color.Transparent;
            this.AccountInfo.Controls.Add(this.AccountInfoContainer);
            this.AccountInfo.Controls.Add(this.AccountHeaderContainer);
            this.AccountInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountInfo.Location = new System.Drawing.Point(10, 271);
            this.AccountInfo.Name = "AccountInfo";
            this.AccountInfo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.AccountInfo.Size = new System.Drawing.Size(492, 319);
            this.AccountInfo.TabIndex = 25;
            // 
            // AccountInfoContainer
            // 
            this.AccountInfoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AccountInfoContainer.Controls.Add(this.Email);
            this.AccountInfoContainer.Controls.Add(this.customizeTextbox1);
            this.AccountInfoContainer.Controls.Add(this.label6);
            this.AccountInfoContainer.Controls.Add(this.label5);
            this.AccountInfoContainer.Controls.Add(this.customizeTextbox6);
            this.AccountInfoContainer.Controls.Add(this.PwdStrengthBar);
            this.AccountInfoContainer.Controls.Add(this.password);
            this.AccountInfoContainer.Controls.Add(this.userName);
            this.AccountInfoContainer.Controls.Add(this.userNameTxt);
            this.AccountInfoContainer.Controls.Add(this.pwdTxt);
            this.AccountInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountInfoContainer.Location = new System.Drawing.Point(0, 50);
            this.AccountInfoContainer.Name = "AccountInfoContainer";
            this.AccountInfoContainer.Size = new System.Drawing.Size(492, 269);
            this.AccountInfoContainer.TabIndex = 25;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(17, 175);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(115, 21);
            this.Email.TabIndex = 28;
            this.Email.Text = "Email Address*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Password Strength";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password Again*";
            // 
            // PwdStrengthBar
            // 
            this.PwdStrengthBar.Controls.Add(this.Fair);
            this.PwdStrengthBar.Controls.Add(this.Strongly);
            this.PwdStrengthBar.Controls.Add(this.Weak);
            this.PwdStrengthBar.Location = new System.Drawing.Point(168, 144);
            this.PwdStrengthBar.Name = "PwdStrengthBar";
            this.PwdStrengthBar.Size = new System.Drawing.Size(306, 15);
            this.PwdStrengthBar.TabIndex = 24;
            // 
            // Fair
            // 
            this.Fair.BackColor = System.Drawing.Color.Gold;
            this.Fair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fair.Location = new System.Drawing.Point(102, 0);
            this.Fair.Name = "Fair";
            this.Fair.Size = new System.Drawing.Size(102, 15);
            this.Fair.TabIndex = 1;
            // 
            // Strongly
            // 
            this.Strongly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(183)))), ((int)(((byte)(84)))));
            this.Strongly.Dock = System.Windows.Forms.DockStyle.Right;
            this.Strongly.Location = new System.Drawing.Point(204, 0);
            this.Strongly.Name = "Strongly";
            this.Strongly.Size = new System.Drawing.Size(102, 15);
            this.Strongly.TabIndex = 1;
            // 
            // Weak
            // 
            this.Weak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(30)))), ((int)(((byte)(72)))));
            this.Weak.Dock = System.Windows.Forms.DockStyle.Left;
            this.Weak.Location = new System.Drawing.Point(0, 0);
            this.Weak.Name = "Weak";
            this.Weak.Size = new System.Drawing.Size(102, 15);
            this.Weak.TabIndex = 0;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(39, 61);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(83, 21);
            this.password.TabIndex = 7;
            this.password.Text = "Password*";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(37, 18);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(88, 21);
            this.userName.TabIndex = 6;
            this.userName.Text = "Username*";
            // 
            // AccountHeaderContainer
            // 
            this.AccountHeaderContainer.BackColor = System.Drawing.Color.White;
            this.AccountHeaderContainer.Controls.Add(this.AccountHeader);
            this.AccountHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountHeaderContainer.Location = new System.Drawing.Point(0, 10);
            this.AccountHeaderContainer.Name = "AccountHeaderContainer";
            this.AccountHeaderContainer.Size = new System.Drawing.Size(492, 40);
            this.AccountHeaderContainer.TabIndex = 24;
            // 
            // AccountHeader
            // 
            this.AccountHeader.AutoSize = true;
            this.AccountHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountHeader.Location = new System.Drawing.Point(3, 7);
            this.AccountHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccountHeader.Name = "AccountHeader";
            this.AccountHeader.Size = new System.Drawing.Size(86, 25);
            this.AccountHeader.TabIndex = 5;
            this.AccountHeader.Text = "Account";
            // 
            // UserInfo
            // 
            this.UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.UserInfo.Controls.Add(this.panel1);
            this.UserInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.UserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfo.Location = new System.Drawing.Point(10, 10);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(492, 261);
            this.UserInfo.TabIndex = 24;
            // 
            // panel1
            // 
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 221);
            this.panel1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department";
            // 
            // staffName
            // 
            this.staffName.AutoSize = true;
            this.staffName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffName.Location = new System.Drawing.Point(38, 61);
            this.staffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffName.Name = "staffName";
            this.staffName.Size = new System.Drawing.Size(87, 21);
            this.staffName.TabIndex = 2;
            this.staffName.Text = "Staff Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff ID*";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(49, 147);
            this.position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(65, 21);
            this.position.TabIndex = 4;
            this.position.Text = "Position";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(51, 182);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(61, 21);
            this.gender.TabIndex = 9;
            this.gender.Text = "Gender";
            // 
            // MaleGenderRadio
            // 
            this.MaleGenderRadio.AutoSize = true;
            this.MaleGenderRadio.Enabled = false;
            this.MaleGenderRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MaleGenderRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.MaleGenderRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleGenderRadio.Location = new System.Drawing.Point(168, 183);
            this.MaleGenderRadio.Margin = new System.Windows.Forms.Padding(2);
            this.MaleGenderRadio.Name = "MaleGenderRadio";
            this.MaleGenderRadio.Size = new System.Drawing.Size(51, 19);
            this.MaleGenderRadio.TabIndex = 18;
            this.MaleGenderRadio.Text = "Male";
            this.MaleGenderRadio.UseVisualStyleBackColor = true;
            // 
            // FemaleGenderRadio
            // 
            this.FemaleGenderRadio.AutoSize = true;
            this.FemaleGenderRadio.Enabled = false;
            this.FemaleGenderRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleGenderRadio.Location = new System.Drawing.Point(275, 183);
            this.FemaleGenderRadio.Margin = new System.Windows.Forms.Padding(2);
            this.FemaleGenderRadio.Name = "FemaleGenderRadio";
            this.FemaleGenderRadio.Size = new System.Drawing.Size(63, 19);
            this.FemaleGenderRadio.TabIndex = 19;
            this.FemaleGenderRadio.Text = "Female";
            this.FemaleGenderRadio.UseVisualStyleBackColor = true;
            // 
            // UserInfoHeaderContainer
            // 
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.UserInfoHeader);
            this.UserInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            this.UserInfoHeaderContainer.Size = new System.Drawing.Size(492, 40);
            this.UserInfoHeaderContainer.TabIndex = 20;
            // 
            // UserInfoHeader
            // 
            this.UserInfoHeader.AutoSize = true;
            this.UserInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.UserInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserInfoHeader.Name = "UserInfoHeader";
            this.UserInfoHeader.Size = new System.Drawing.Size(165, 25);
            this.UserInfoHeader.TabIndex = 6;
            this.UserInfoHeader.Text = "User Information";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Silver;
            this.CancelBtn.BackgroundColor = System.Drawing.Color.Silver;
            this.CancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CancelBtn.BorderRadius = 10;
            this.CancelBtn.BorderSize = 0;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(182)))), ((int)(((byte)(99)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(212, 6);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(128, 40);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextColor = System.Drawing.Color.White;
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // CreateUser
            // 
            this.CreateUser.BackColor = System.Drawing.Color.SeaGreen;
            this.CreateUser.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.CreateUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateUser.BorderRadius = 10;
            this.CreateUser.BorderSize = 0;
            this.CreateUser.FlatAppearance.BorderSize = 0;
            this.CreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUser.ForeColor = System.Drawing.Color.White;
            this.CreateUser.Location = new System.Drawing.Point(346, 6);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(128, 40);
            this.CreateUser.TabIndex = 0;
            this.CreateUser.Text = "Create User";
            this.CreateUser.TextColor = System.Drawing.Color.White;
            this.CreateUser.UseVisualStyleBackColor = false;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // customizeTextbox1
            // 
            this.customizeTextbox1.BackColor = System.Drawing.Color.White;
            this.customizeTextbox1.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox1.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox1.BorderRadius = 10;
            this.customizeTextbox1.BorderSize = 1;
            this.customizeTextbox1.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox1.ForeColor = System.Drawing.Color.LightGray;
            this.customizeTextbox1.Location = new System.Drawing.Point(166, 168);
            this.customizeTextbox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox1.MaxLength = 20;
            this.customizeTextbox1.Multiline = true;
            this.customizeTextbox1.Name = "customizeTextbox1";
            this.customizeTextbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox1.PasswordChar = false;
            this.customizeTextbox1.Size = new System.Drawing.Size(308, 35);
            this.customizeTextbox1.TabIndex = 29;
            this.customizeTextbox1.Texts = "Please input email address";
            this.customizeTextbox1.UnderlinedStyle = false;
            // 
            // customizeTextbox6
            // 
            this.customizeTextbox6.BackColor = System.Drawing.Color.White;
            this.customizeTextbox6.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox6.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox6.BorderRadius = 10;
            this.customizeTextbox6.BorderSize = 1;
            this.customizeTextbox6.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox6.ForeColor = System.Drawing.Color.LightGray;
            this.customizeTextbox6.Location = new System.Drawing.Point(166, 97);
            this.customizeTextbox6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox6.MaxLength = 20;
            this.customizeTextbox6.Multiline = true;
            this.customizeTextbox6.Name = "customizeTextbox6";
            this.customizeTextbox6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox6.PasswordChar = false;
            this.customizeTextbox6.Size = new System.Drawing.Size(308, 35);
            this.customizeTextbox6.TabIndex = 26;
            this.customizeTextbox6.Texts = "Please input password again";
            this.customizeTextbox6.UnderlinedStyle = false;
            // 
            // userNameTxt
            // 
            this.userNameTxt.BackColor = System.Drawing.Color.White;
            this.userNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.userNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.userNameTxt.BorderRadius = 10;
            this.userNameTxt.BorderSize = 1;
            this.userNameTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.ForeColor = System.Drawing.Color.LightGray;
            this.userNameTxt.Location = new System.Drawing.Point(167, 11);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userNameTxt.MaxLength = 20;
            this.userNameTxt.Multiline = true;
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userNameTxt.PasswordChar = true;
            this.userNameTxt.Size = new System.Drawing.Size(308, 35);
            this.userNameTxt.TabIndex = 23;
            this.userNameTxt.Texts = "Please input user name";
            this.userNameTxt.UnderlinedStyle = false;
            // 
            // pwdTxt
            // 
            this.pwdTxt.BackColor = System.Drawing.Color.White;
            this.pwdTxt.BorderColor = System.Drawing.Color.LightGray;
            this.pwdTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.pwdTxt.BorderRadius = 10;
            this.pwdTxt.BorderSize = 1;
            this.pwdTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTxt.ForeColor = System.Drawing.Color.LightGray;
            this.pwdTxt.Location = new System.Drawing.Point(167, 54);
            this.pwdTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pwdTxt.MaxLength = 20;
            this.pwdTxt.Multiline = true;
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.pwdTxt.PasswordChar = false;
            this.pwdTxt.Size = new System.Drawing.Size(308, 35);
            this.pwdTxt.TabIndex = 22;
            this.pwdTxt.Texts = "Please input password";
            this.pwdTxt.UnderlinedStyle = false;
            // 
            // SearchStaffBtn
            // 
            this.SearchStaffBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchStaffBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.SearchStaffBtn.BackgroundImage = global::TheBetterLimited.Properties.Resources.search;
            this.SearchStaffBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchStaffBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SearchStaffBtn.BorderRadius = 0;
            this.SearchStaffBtn.BorderSize = 0;
            this.SearchStaffBtn.FlatAppearance.BorderSize = 0;
            this.SearchStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchStaffBtn.ForeColor = System.Drawing.Color.White;
            this.SearchStaffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchStaffBtn.Location = new System.Drawing.Point(445, 13);
            this.SearchStaffBtn.Name = "SearchStaffBtn";
            this.SearchStaffBtn.Size = new System.Drawing.Size(30, 30);
            this.SearchStaffBtn.TabIndex = 27;
            this.SearchStaffBtn.TextColor = System.Drawing.Color.White;
            this.SearchStaffBtn.UseVisualStyleBackColor = false;
            this.SearchStaffBtn.Click += new System.EventHandler(this.SearchStaffBtn_Click);
            // 
            // StaffIDTxt
            // 
            this.StaffIDTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.StaffIDTxt.BackColor = System.Drawing.Color.White;
            this.StaffIDTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StaffIDTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StaffIDTxt.BorderRadius = 10;
            this.StaffIDTxt.BorderSize = 1;
            this.StaffIDTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIDTxt.ForeColor = System.Drawing.Color.LightGray;
            this.StaffIDTxt.Location = new System.Drawing.Point(168, 11);
            this.StaffIDTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StaffIDTxt.MaxLength = 5;
            this.StaffIDTxt.Multiline = true;
            this.StaffIDTxt.Name = "StaffIDTxt";
            this.StaffIDTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StaffIDTxt.PasswordChar = false;
            this.StaffIDTxt.Size = new System.Drawing.Size(274, 35);
            this.StaffIDTxt.TabIndex = 24;
            this.StaffIDTxt.Texts = "Please input staff ID";
            this.StaffIDTxt.UnderlinedStyle = false;
            this.StaffIDTxt.Enter += new System.EventHandler(this.StaffIDTxt_Enter);
            this.StaffIDTxt.Leave += new System.EventHandler(this.StaffIDTxt_Leave);
            // 
            // PositionTxt
            // 
            this.PositionTxt.BackColor = System.Drawing.Color.White;
            this.PositionTxt.BorderColor = System.Drawing.Color.LightGray;
            this.PositionTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.PositionTxt.BorderRadius = 10;
            this.PositionTxt.BorderSize = 1;
            this.PositionTxt.Enabled = false;
            this.PositionTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionTxt.ForeColor = System.Drawing.Color.LightGray;
            this.PositionTxt.Location = new System.Drawing.Point(168, 140);
            this.PositionTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PositionTxt.MaxLength = 32767;
            this.PositionTxt.Multiline = true;
            this.PositionTxt.Name = "PositionTxt";
            this.PositionTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PositionTxt.PasswordChar = false;
            this.PositionTxt.Size = new System.Drawing.Size(307, 35);
            this.PositionTxt.TabIndex = 26;
            this.PositionTxt.Texts = "Cannot be inputted";
            this.PositionTxt.UnderlinedStyle = false;
            // 
            // DeptTxt
            // 
            this.DeptTxt.BackColor = System.Drawing.Color.White;
            this.DeptTxt.BorderColor = System.Drawing.Color.LightGray;
            this.DeptTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.DeptTxt.BorderRadius = 10;
            this.DeptTxt.BorderSize = 1;
            this.DeptTxt.Enabled = false;
            this.DeptTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptTxt.ForeColor = System.Drawing.Color.LightGray;
            this.DeptTxt.Location = new System.Drawing.Point(168, 97);
            this.DeptTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeptTxt.MaxLength = 32767;
            this.DeptTxt.Multiline = true;
            this.DeptTxt.Name = "DeptTxt";
            this.DeptTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DeptTxt.PasswordChar = false;
            this.DeptTxt.Size = new System.Drawing.Size(307, 35);
            this.DeptTxt.TabIndex = 25;
            this.DeptTxt.Texts = "Cannot be inputted";
            this.DeptTxt.UnderlinedStyle = false;
            // 
            // StaffNameTxt
            // 
            this.StaffNameTxt.BackColor = System.Drawing.Color.White;
            this.StaffNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StaffNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StaffNameTxt.BorderRadius = 10;
            this.StaffNameTxt.BorderSize = 1;
            this.StaffNameTxt.Enabled = false;
            this.StaffNameTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameTxt.ForeColor = System.Drawing.Color.LightGray;
            this.StaffNameTxt.Location = new System.Drawing.Point(168, 54);
            this.StaffNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StaffNameTxt.MaxLength = 32767;
            this.StaffNameTxt.Multiline = true;
            this.StaffNameTxt.Name = "StaffNameTxt";
            this.StaffNameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StaffNameTxt.PasswordChar = false;
            this.StaffNameTxt.Size = new System.Drawing.Size(307, 35);
            this.StaffNameTxt.TabIndex = 22;
            this.StaffNameTxt.Texts = "Cannot be inputted";
            this.StaffNameTxt.UnderlinedStyle = false;
            // 
            // Usermanagement_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(784, 600);
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Usermanagement_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Usermanagement_Add_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPic)).EndInit();
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.AccountInfo.ResumeLayout(false);
            this.AccountInfoContainer.ResumeLayout(false);
            this.AccountInfoContainer.PerformLayout();
            this.PwdStrengthBar.ResumeLayout(false);
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
        private CustomizeControl.CustomizeTextbox customizeTextbox6;
        private System.Windows.Forms.Panel PwdStrengthBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Weak;
        private System.Windows.Forms.Panel Strongly;
        private System.Windows.Forms.Panel Fair;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton CreateUser;
        private CustomizeControl.RoundButton SearchStaffBtn;
        private System.Windows.Forms.Label Email;
        private CustomizeControl.CustomizeTextbox customizeTextbox1;
    }
}