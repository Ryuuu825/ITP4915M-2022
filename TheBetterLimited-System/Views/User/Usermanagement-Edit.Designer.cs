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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usermanagement_Edit));
            this.Header = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.UserIconPic = new System.Windows.Forms.PictureBox();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.AccountInfo = new System.Windows.Forms.Panel();
            this.AccountInfoContainer = new System.Windows.Forms.Panel();
            this.Remark = new System.Windows.Forms.Label();
            this.RemarkTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StatusRadioGroup = new System.Windows.Forms.Panel();
            this.LockStatusRadio = new System.Windows.Forms.RadioButton();
            this.NormalStatusRadio = new System.Windows.Forms.RadioButton();
            this.Status = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.EmailTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserName = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.UserIdTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
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
            this.StatusRadioGroup.SuspendLayout();
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
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.UserIconPic);
            this.Header.Name = "Header";
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
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
            this.UserIconPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserIconPic.Image = global::TheBetterLimited.Properties.Resources._default;
            this.UserIconPic.Name = "UserIconPic";
            this.UserIconPic.TabStop = false;
            this.UserIconPic.Paint += new System.Windows.Forms.PaintEventHandler(this.UserIconPic_Paint);
            // 
            // BottomBtn
            // 
            resources.ApplyResources(this.BottomBtn, "BottomBtn");
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
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
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SaveBtn.BorderRadius = 10;
            this.SaveBtn.BorderSize = 0;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.IsChecked = false;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.AccountInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.AccountInfo.Controls.Add(this.AccountInfoContainer);
            this.AccountInfo.Controls.Add(this.AccountHeaderContainer);
            this.AccountInfo.Name = "AccountInfo";
            // 
            // AccountInfoContainer
            // 
            resources.ApplyResources(this.AccountInfoContainer, "AccountInfoContainer");
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
            this.AccountInfoContainer.Name = "AccountInfoContainer";
            // 
            // Remark
            // 
            resources.ApplyResources(this.Remark, "Remark");
            this.Remark.Name = "Remark";
            // 
            // RemarkTxt
            // 
            resources.ApplyResources(this.RemarkTxt, "RemarkTxt");
            this.RemarkTxt.BackColor = System.Drawing.Color.White;
            this.RemarkTxt.BorderColor = System.Drawing.Color.LightGray;
            this.RemarkTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.RemarkTxt.BorderRadius = 10;
            this.RemarkTxt.BorderSize = 1;
            this.RemarkTxt.ForeColor = System.Drawing.Color.Black;
            this.RemarkTxt.IsError = false;
            this.RemarkTxt.MaxLength = 20;
            this.RemarkTxt.Multiline = false;
            this.RemarkTxt.Name = "RemarkTxt";
            this.RemarkTxt.PasswordChar = false;
            this.RemarkTxt.Placeholder = "Please input remark";
            this.RemarkTxt.ReadOnly = false;
            this.RemarkTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.RemarkTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.RemarkTxt.Texts = "";
            this.RemarkTxt.UnderlinedStyle = false;
            // 
            // StatusRadioGroup
            // 
            resources.ApplyResources(this.StatusRadioGroup, "StatusRadioGroup");
            this.StatusRadioGroup.Controls.Add(this.LockStatusRadio);
            this.StatusRadioGroup.Controls.Add(this.NormalStatusRadio);
            this.StatusRadioGroup.Name = "StatusRadioGroup";
            // 
            // LockStatusRadio
            // 
            resources.ApplyResources(this.LockStatusRadio, "LockStatusRadio");
            this.LockStatusRadio.Name = "LockStatusRadio";
            this.LockStatusRadio.UseVisualStyleBackColor = true;
            // 
            // NormalStatusRadio
            // 
            resources.ApplyResources(this.NormalStatusRadio, "NormalStatusRadio");
            this.NormalStatusRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NormalStatusRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.NormalStatusRadio.Name = "NormalStatusRadio";
            this.NormalStatusRadio.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            // 
            // Email
            // 
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // EmailTxt
            // 
            resources.ApplyResources(this.EmailTxt, "EmailTxt");
            this.EmailTxt.BackColor = System.Drawing.Color.White;
            this.EmailTxt.BorderColor = System.Drawing.Color.LightGray;
            this.EmailTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.EmailTxt.BorderRadius = 10;
            this.EmailTxt.BorderSize = 1;
            this.EmailTxt.ForeColor = System.Drawing.Color.Black;
            this.EmailTxt.IsError = false;
            this.EmailTxt.MaxLength = 20;
            this.EmailTxt.Multiline = false;
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.PasswordChar = false;
            this.EmailTxt.Placeholder = "Please input email address";
            this.EmailTxt.ReadOnly = false;
            this.EmailTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.EmailTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.EmailTxt.Texts = "";
            this.EmailTxt.UnderlinedStyle = false;
            // 
            // UserName
            // 
            resources.ApplyResources(this.UserName, "UserName");
            this.UserName.Name = "UserName";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // UserID
            // 
            resources.ApplyResources(this.UserID, "UserID");
            this.UserID.Name = "UserID";
            // 
            // UserIdTxt
            // 
            resources.ApplyResources(this.UserIdTxt, "UserIdTxt");
            this.UserIdTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserIdTxt.BorderColor = System.Drawing.Color.LightGray;
            this.UserIdTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.UserIdTxt.BorderRadius = 10;
            this.UserIdTxt.BorderSize = 1;
            this.UserIdTxt.ForeColor = System.Drawing.Color.LightGray;
            this.UserIdTxt.IsError = false;
            this.UserIdTxt.MaxLength = 20;
            this.UserIdTxt.Multiline = false;
            this.UserIdTxt.Name = "UserIdTxt";
            this.UserIdTxt.PasswordChar = false;
            this.UserIdTxt.Placeholder = "Automatic Data Entry";
            this.UserIdTxt.ReadOnly = false;
            this.UserIdTxt.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.UserIdTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.UserIdTxt.Texts = "Automatic Data Entry";
            this.UserIdTxt.UnderlinedStyle = false;
            // 
            // UserNameTxt
            // 
            resources.ApplyResources(this.UserNameTxt, "UserNameTxt");
            this.UserNameTxt.BackColor = System.Drawing.Color.White;
            this.UserNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.UserNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.UserNameTxt.BorderRadius = 10;
            this.UserNameTxt.BorderSize = 1;
            this.UserNameTxt.ForeColor = System.Drawing.Color.Black;
            this.UserNameTxt.IsError = false;
            this.UserNameTxt.MaxLength = 20;
            this.UserNameTxt.Multiline = false;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.PasswordChar = false;
            this.UserNameTxt.Placeholder = "Please input user name";
            this.UserNameTxt.ReadOnly = false;
            this.UserNameTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.UserNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.UserNameTxt.Texts = "";
            this.UserNameTxt.UnderlinedStyle = false;
            this.UserNameTxt.Enter += new System.EventHandler(this.UserNameTxt_Enter);
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
            this.StaffIDTxt.Placeholder = "Please input staff ID";
            this.StaffIDTxt.ReadOnly = false;
            this.StaffIDTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.StaffIDTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.StaffIDTxt.Texts = "";
            this.StaffIDTxt.UnderlinedStyle = false;
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
            this.PositionTxt.Placeholder = "Automatic Data Entry";
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
            this.DeptTxt.Placeholder = "Automatic Data Entry";
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
            this.StaffNameTxt.Placeholder = "Automatic Data Entry";
            this.StaffNameTxt.ReadOnly = true;
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
            // Usermanagement_Edit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Usermanagement_Edit";
            this.ShowIcon = false;
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