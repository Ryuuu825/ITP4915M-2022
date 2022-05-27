namespace TheBetterLimited.Views
{
    partial class Usermanagement_Edit
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
            this.Header = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.UserIconPic = new System.Windows.Forms.PictureBox();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.MainForm = new System.Windows.Forms.Panel();
            this.AccountInfo = new System.Windows.Forms.Panel();
            this.AccountInfoContainer = new System.Windows.Forms.Panel();
            this.Remark = new System.Windows.Forms.Label();
            this.StatusRadioGroup = new System.Windows.Forms.Panel();
            this.LockStatusRadio = new System.Windows.Forms.RadioButton();
            this.NormalStatusRadio = new System.Windows.Forms.RadioButton();
            this.Status = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
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
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.RemarkTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.EmailTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserIdTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
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
            this.StatusRadioGroup.SuspendLayout();
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
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.UserIconPic);
            this.Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(272, 639);
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
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.SeaGreen;
            this.Title.Location = new System.Drawing.Point(16, 273);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 30);
            this.Title.TabIndex = 3;
            this.Title.Text = "Edit User";
            // 
            // UserIconPic
            // 
            this.UserIconPic.BackColor = System.Drawing.Color.Transparent;
            this.UserIconPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserIconPic.Image = global::TheBetterLimited.Properties.Resources._default;
            this.UserIconPic.Location = new System.Drawing.Point(21, 12);
            this.UserIconPic.Name = "UserIconPic";
            this.UserIconPic.Size = new System.Drawing.Size(230, 230);
            this.UserIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIconPic.TabIndex = 2;
            this.UserIconPic.TabStop = false;
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 575);
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
            this.MainForm.Size = new System.Drawing.Size(512, 639);
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
            this.AccountInfo.Size = new System.Drawing.Size(492, 358);
            this.AccountInfo.TabIndex = 25;
            // 
            // AccountInfoContainer
            // 
            this.AccountInfoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AccountInfoContainer.Controls.Add(this.Remark);
            this.AccountInfoContainer.Controls.Add(this.RemarkTxt);
            this.AccountInfoContainer.Controls.Add(this.StatusRadioGroup);
            this.AccountInfoContainer.Controls.Add(this.Status);
            this.AccountInfoContainer.Controls.Add(this.Email);
            this.AccountInfoContainer.Controls.Add(this.EmailTxt);
            this.AccountInfoContainer.Controls.Add(this.UserName);
            this.AccountInfoContainer.Controls.Add(this.UserID);
            this.AccountInfoContainer.Controls.Add(this.UserIdTxt);
            this.AccountInfoContainer.Controls.Add(this.UserNameTxt);
            this.AccountInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountInfoContainer.Location = new System.Drawing.Point(0, 50);
            this.AccountInfoContainer.Name = "AccountInfoContainer";
            this.AccountInfoContainer.Size = new System.Drawing.Size(492, 308);
            this.AccountInfoContainer.TabIndex = 25;
            // 
            // Remark
            // 
            this.Remark.AutoSize = true;
            this.Remark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remark.Location = new System.Drawing.Point(45, 178);
            this.Remark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Remark.Name = "Remark";
            this.Remark.Size = new System.Drawing.Size(64, 21);
            this.Remark.TabIndex = 31;
            this.Remark.Text = "Remark";
            // 
            // StatusRadioGroup
            // 
            this.StatusRadioGroup.Controls.Add(this.LockStatusRadio);
            this.StatusRadioGroup.Controls.Add(this.NormalStatusRadio);
            this.StatusRadioGroup.Location = new System.Drawing.Point(166, 138);
            this.StatusRadioGroup.Name = "StatusRadioGroup";
            this.StatusRadioGroup.Size = new System.Drawing.Size(308, 25);
            this.StatusRadioGroup.TabIndex = 30;
            // 
            // LockStatusRadio
            // 
            this.LockStatusRadio.AutoSize = true;
            this.LockStatusRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockStatusRadio.Location = new System.Drawing.Point(111, 4);
            this.LockStatusRadio.Margin = new System.Windows.Forms.Padding(2);
            this.LockStatusRadio.Name = "LockStatusRadio";
            this.LockStatusRadio.Size = new System.Drawing.Size(63, 19);
            this.LockStatusRadio.TabIndex = 29;
            this.LockStatusRadio.Text = "Locked";
            this.LockStatusRadio.UseVisualStyleBackColor = true;
            // 
            // NormalStatusRadio
            // 
            this.NormalStatusRadio.AutoSize = true;
            this.NormalStatusRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NormalStatusRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.NormalStatusRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalStatusRadio.Location = new System.Drawing.Point(1, 4);
            this.NormalStatusRadio.Margin = new System.Windows.Forms.Padding(2);
            this.NormalStatusRadio.Name = "NormalStatusRadio";
            this.NormalStatusRadio.Size = new System.Drawing.Size(65, 19);
            this.NormalStatusRadio.TabIndex = 28;
            this.NormalStatusRadio.Text = "Normal";
            this.NormalStatusRadio.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(48, 140);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(59, 21);
            this.Status.TabIndex = 28;
            this.Status.Text = "Status*";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(24, 104);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(115, 21);
            this.Email.TabIndex = 28;
            this.Email.Text = "Email Address*";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(34, 61);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(95, 21);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "User Name*";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.Location = new System.Drawing.Point(51, 18);
            this.UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(61, 21);
            this.UserID.TabIndex = 6;
            this.UserID.Text = "User ID";
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SaveBtn.BorderRadius = 10;
            this.SaveBtn.BorderSize = 0;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(346, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(128, 40);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RemarkTxt
            // 
            this.RemarkTxt.BackColor = System.Drawing.Color.White;
            this.RemarkTxt.BorderColor = System.Drawing.Color.LightGray;
            this.RemarkTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.RemarkTxt.BorderRadius = 10;
            this.RemarkTxt.BorderSize = 1;
            this.RemarkTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemarkTxt.ForeColor = System.Drawing.Color.Black;
            this.RemarkTxt.IsError = false;
            this.RemarkTxt.Location = new System.Drawing.Point(166, 171);
            this.RemarkTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemarkTxt.MaxLength = 20;
            this.RemarkTxt.Multiline = true;
            this.RemarkTxt.Name = "RemarkTxt";
            this.RemarkTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RemarkTxt.PasswordChar = false;
            this.RemarkTxt.Placeholder = "Please input remark";
            this.RemarkTxt.ReadOnly = false;
            this.RemarkTxt.Size = new System.Drawing.Size(308, 75);
            this.RemarkTxt.TabIndex = 32;
            this.RemarkTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.RemarkTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.RemarkTxt.Texts = "";
            this.RemarkTxt.UnderlinedStyle = false;
            // 
            // EmailTxt
            // 
            this.EmailTxt.BackColor = System.Drawing.Color.White;
            this.EmailTxt.BorderColor = System.Drawing.Color.LightGray;
            this.EmailTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.EmailTxt.BorderRadius = 10;
            this.EmailTxt.BorderSize = 1;
            this.EmailTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.ForeColor = System.Drawing.Color.Black;
            this.EmailTxt.IsError = false;
            this.EmailTxt.Location = new System.Drawing.Point(166, 97);
            this.EmailTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EmailTxt.MaxLength = 20;
            this.EmailTxt.Multiline = false;
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EmailTxt.PasswordChar = false;
            this.EmailTxt.Placeholder = "Please input email address";
            this.EmailTxt.ReadOnly = false;
            this.EmailTxt.Size = new System.Drawing.Size(308, 38);
            this.EmailTxt.TabIndex = 29;
            this.EmailTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.EmailTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.EmailTxt.Texts = "";
            this.EmailTxt.UnderlinedStyle = false;
            // 
            // UserIdTxt
            // 
            this.UserIdTxt.BackColor = System.Drawing.Color.White;
            this.UserIdTxt.BorderColor = System.Drawing.Color.LightGray;
            this.UserIdTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.UserIdTxt.BorderRadius = 10;
            this.UserIdTxt.BorderSize = 1;
            this.UserIdTxt.Enabled = false;
            this.UserIdTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdTxt.ForeColor = System.Drawing.Color.LightGray;
            this.UserIdTxt.IsError = false;
            this.UserIdTxt.Location = new System.Drawing.Point(167, 11);
            this.UserIdTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserIdTxt.MaxLength = 20;
            this.UserIdTxt.Multiline = true;
            this.UserIdTxt.Name = "UserIdTxt";
            this.UserIdTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.UserIdTxt.PasswordChar = false;
            this.UserIdTxt.Placeholder = "Cannot be inputted";
            this.UserIdTxt.ReadOnly = false;
            this.UserIdTxt.Size = new System.Drawing.Size(308, 35);
            this.UserIdTxt.TabIndex = 23;
            this.UserIdTxt.TbBackColor = System.Drawing.Color.White;
            this.UserIdTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.UserIdTxt.Texts = "Cannot be inputted";
            this.UserIdTxt.UnderlinedStyle = false;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BackColor = System.Drawing.Color.White;
            this.UserNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.UserNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.UserNameTxt.BorderRadius = 10;
            this.UserNameTxt.BorderSize = 1;
            this.UserNameTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.ForeColor = System.Drawing.Color.Black;
            this.UserNameTxt.IsError = false;
            this.UserNameTxt.Location = new System.Drawing.Point(167, 54);
            this.UserNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserNameTxt.MaxLength = 20;
            this.UserNameTxt.Multiline = false;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.UserNameTxt.PasswordChar = false;
            this.UserNameTxt.Placeholder = "Please input user name";
            this.UserNameTxt.ReadOnly = false;
            this.UserNameTxt.Size = new System.Drawing.Size(308, 38);
            this.UserNameTxt.TabIndex = 22;
            this.UserNameTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.UserNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.UserNameTxt.Texts = "";
            this.UserNameTxt.UnderlinedStyle = false;
            this.UserNameTxt.Enter += new System.EventHandler(this.UserNameTxt_Enter);
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
            this.SearchStaffBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SearchStaffBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
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
            this.StaffIDTxt.ForeColor = System.Drawing.Color.Black;
            this.StaffIDTxt.IsError = false;
            this.StaffIDTxt.Location = new System.Drawing.Point(168, 11);
            this.StaffIDTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StaffIDTxt.MaxLength = 5;
            this.StaffIDTxt.Multiline = true;
            this.StaffIDTxt.Name = "StaffIDTxt";
            this.StaffIDTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StaffIDTxt.PasswordChar = false;
            this.StaffIDTxt.Placeholder = "Please input staff ID";
            this.StaffIDTxt.ReadOnly = false;
            this.StaffIDTxt.Size = new System.Drawing.Size(274, 35);
            this.StaffIDTxt.TabIndex = 24;
            this.StaffIDTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.StaffIDTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.StaffIDTxt.Texts = "";
            this.StaffIDTxt.UnderlinedStyle = false;
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
            this.PositionTxt.IsError = false;
            this.PositionTxt.Location = new System.Drawing.Point(168, 140);
            this.PositionTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PositionTxt.MaxLength = 32767;
            this.PositionTxt.Multiline = true;
            this.PositionTxt.Name = "PositionTxt";
            this.PositionTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PositionTxt.PasswordChar = false;
            this.PositionTxt.Placeholder = "Cannot be inputted";
            this.PositionTxt.ReadOnly = false;
            this.PositionTxt.Size = new System.Drawing.Size(307, 35);
            this.PositionTxt.TabIndex = 26;
            this.PositionTxt.TbBackColor = System.Drawing.Color.White;
            this.PositionTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
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
            this.DeptTxt.IsError = false;
            this.DeptTxt.Location = new System.Drawing.Point(168, 97);
            this.DeptTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeptTxt.MaxLength = 32767;
            this.DeptTxt.Multiline = true;
            this.DeptTxt.Name = "DeptTxt";
            this.DeptTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DeptTxt.PasswordChar = false;
            this.DeptTxt.Placeholder = "Cannot be inputted";
            this.DeptTxt.ReadOnly = false;
            this.DeptTxt.Size = new System.Drawing.Size(307, 35);
            this.DeptTxt.TabIndex = 25;
            this.DeptTxt.TbBackColor = System.Drawing.Color.White;
            this.DeptTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
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
            this.StaffNameTxt.IsError = false;
            this.StaffNameTxt.Location = new System.Drawing.Point(168, 54);
            this.StaffNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StaffNameTxt.MaxLength = 32767;
            this.StaffNameTxt.Multiline = true;
            this.StaffNameTxt.Name = "StaffNameTxt";
            this.StaffNameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StaffNameTxt.PasswordChar = false;
            this.StaffNameTxt.Placeholder = "Cannot be inputted";
            this.StaffNameTxt.ReadOnly = true;
            this.StaffNameTxt.Size = new System.Drawing.Size(307, 35);
            this.StaffNameTxt.TabIndex = 22;
            this.StaffNameTxt.TbBackColor = System.Drawing.Color.White;
            this.StaffNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StaffNameTxt.Texts = "Cannot be inputted";
            this.StaffNameTxt.UnderlinedStyle = false;
            // 
            // Usermanagement_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(784, 639);
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Usermanagement_Edit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.Usermanagement_Edit_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPic)).EndInit();
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.AccountInfo.ResumeLayout(false);
            this.AccountInfoContainer.ResumeLayout(false);
            this.AccountInfoContainer.PerformLayout();
            this.StatusRadioGroup.ResumeLayout(false);
            this.StatusRadioGroup.PerformLayout();
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
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label AccountHeader;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label staffName;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox UserIdTxt;
        private System.Windows.Forms.PictureBox UserIconPic;
        private System.Windows.Forms.Label Title;
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
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private CustomizeControl.RoundButton SearchStaffBtn;
        private System.Windows.Forms.Label Email;
        private CustomizeControl.CustomizeTextbox EmailTxt;
        private System.Windows.Forms.Label UserName;
        private CustomizeControl.CustomizeTextbox UserNameTxt;
        private System.Windows.Forms.RadioButton NormalStatusRadio;
        private System.Windows.Forms.RadioButton LockStatusRadio;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Panel StatusRadioGroup;
        private System.Windows.Forms.Label Remark;
        private CustomizeControl.CustomizeTextbox RemarkTxt;
    }
}