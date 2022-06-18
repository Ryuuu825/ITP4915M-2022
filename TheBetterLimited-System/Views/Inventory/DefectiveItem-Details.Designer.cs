namespace TheBetterLimited.Views
{
    partial class DefectiveItem_Details
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
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnSave = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCusPhone = new System.Windows.Forms.Label();
            this.txtGTINCode = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblCusAddress = new System.Windows.Forms.Label();
            this.txtPrice = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblCusName = new System.Windows.Forms.Label();
            this.txtGoodsId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.lblGoodsId = new System.Windows.Forms.Label();
            this.txtGoodsName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.lblSupAddress = new System.Windows.Forms.Label();
            this.txtSupAddress = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtCusAddress = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.customizeTextbox1 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblSuppler = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customizeTextbox2 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.customizeTextbox3 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.btnCancel);
            this.BottomBtn.Controls.Add(this.btnSave);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 515);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(851, 54);
            this.BottomBtn.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(182)))), ((int)(((byte)(99)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IsChecked = false;
            this.btnCancel.Location = new System.Drawing.Point(290, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IsChecked = false;
            this.btnSave.Location = new System.Drawing.Point(485, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.panel2);
            this.MainForm.Controls.Add(this.UserInfo);
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(871, 579);
            this.MainForm.TabIndex = 2;
            // 
            // UserInfo
            // 
            this.UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.UserInfo.Controls.Add(this.panel1);
            this.UserInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.UserInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserInfo.Location = new System.Drawing.Point(10, 10);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(446, 505);
            this.UserInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customizeTextbox3);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.customizeTextbox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.customizeTextbox1);
            this.panel1.Controls.Add(this.lblSuppler);
            this.panel1.Controls.Add(this.txtGoodsId);
            this.panel1.Controls.Add(this.lblGoodsName);
            this.panel1.Controls.Add(this.lblGoodsId);
            this.panel1.Controls.Add(this.txtSupAddress);
            this.panel1.Controls.Add(this.lblSupAddress);
            this.panel1.Controls.Add(this.txtGoodsName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 465);
            this.panel1.TabIndex = 27;
            // 
            // lblCusPhone
            // 
            this.lblCusPhone.AutoSize = true;
            this.lblCusPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusPhone.Location = new System.Drawing.Point(20, 77);
            this.lblCusPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusPhone.Name = "lblCusPhone";
            this.lblCusPhone.Size = new System.Drawing.Size(126, 21);
            this.lblCusPhone.TabIndex = 32;
            this.lblCusPhone.Text = "Customer Phone";
            this.lblCusPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGTINCode
            // 
            this.txtGTINCode.BackColor = System.Drawing.Color.White;
            this.txtGTINCode.BorderColor = System.Drawing.Color.LightGray;
            this.txtGTINCode.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtGTINCode.BorderRadius = 10;
            this.txtGTINCode.BorderSize = 1;
            this.txtGTINCode.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTINCode.ForeColor = System.Drawing.Color.Black;
            this.txtGTINCode.IsError = false;
            this.txtGTINCode.Location = new System.Drawing.Point(167, 68);
            this.txtGTINCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGTINCode.MaxLength = 32767;
            this.txtGTINCode.Multiline = false;
            this.txtGTINCode.Name = "txtGTINCode";
            this.txtGTINCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGTINCode.PasswordChar = false;
            this.txtGTINCode.Placeholder = "";
            this.txtGTINCode.ReadOnly = false;
            this.txtGTINCode.Size = new System.Drawing.Size(203, 38);
            this.txtGTINCode.TabIndex = 31;
            this.txtGTINCode.TbBackColor = System.Drawing.Color.White;
            this.txtGTINCode.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtGTINCode.Texts = "";
            this.txtGTINCode.UnderlinedStyle = false;
            // 
            // lblCusAddress
            // 
            this.lblCusAddress.AutoSize = true;
            this.lblCusAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusAddress.Location = new System.Drawing.Point(14, 186);
            this.lblCusAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusAddress.Name = "lblCusAddress";
            this.lblCusAddress.Size = new System.Drawing.Size(139, 21);
            this.lblCusAddress.TabIndex = 30;
            this.lblCusAddress.Text = "Collection Address";
            this.lblCusAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.LightGray;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtPrice.BorderRadius = 10;
            this.txtPrice.BorderSize = 1;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.IsError = false;
            this.txtPrice.Location = new System.Drawing.Point(167, 17);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.Placeholder = "";
            this.txtPrice.ReadOnly = false;
            this.txtPrice.Size = new System.Drawing.Size(203, 38);
            this.txtPrice.TabIndex = 29;
            this.txtPrice.TbBackColor = System.Drawing.Color.White;
            this.txtPrice.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.Location = new System.Drawing.Point(21, 26);
            this.lblCusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(124, 21);
            this.lblCusName.TabIndex = 28;
            this.lblCusName.Text = "Customer Name";
            this.lblCusName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGoodsId
            // 
            this.txtGoodsId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtGoodsId.BackColor = System.Drawing.Color.White;
            this.txtGoodsId.BorderColor = System.Drawing.Color.LightGray;
            this.txtGoodsId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtGoodsId.BorderRadius = 10;
            this.txtGoodsId.BorderSize = 1;
            this.txtGoodsId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsId.ForeColor = System.Drawing.Color.Black;
            this.txtGoodsId.IsError = false;
            this.txtGoodsId.Location = new System.Drawing.Point(144, 17);
            this.txtGoodsId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGoodsId.MaxLength = 5;
            this.txtGoodsId.Multiline = false;
            this.txtGoodsId.Name = "txtGoodsId";
            this.txtGoodsId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGoodsId.PasswordChar = false;
            this.txtGoodsId.Placeholder = "";
            this.txtGoodsId.ReadOnly = true;
            this.txtGoodsId.Size = new System.Drawing.Size(274, 38);
            this.txtGoodsId.TabIndex = 1;
            this.txtGoodsId.TbBackColor = System.Drawing.Color.White;
            this.txtGoodsId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.txtGoodsId.Texts = "";
            this.txtGoodsId.UnderlinedStyle = false;
            this.txtGoodsId._TextChanged += new System.EventHandler(this.StaffIDTxt__TextChanged);
            this.txtGoodsId.Click += new System.EventHandler(this.StaffIDTxt_Click);
            this.txtGoodsId.Enter += new System.EventHandler(this.StaffIDTxt_Enter);
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsName.Location = new System.Drawing.Point(24, 96);
            this.lblGoodsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Size = new System.Drawing.Size(101, 21);
            this.lblGoodsName.TabIndex = 3;
            this.lblGoodsName.Text = "Goods Name";
            this.lblGoodsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoodsId
            // 
            this.lblGoodsId.AutoSize = true;
            this.lblGoodsId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsId.Location = new System.Drawing.Point(37, 26);
            this.lblGoodsId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsId.Name = "lblGoodsId";
            this.lblGoodsId.Size = new System.Drawing.Size(74, 21);
            this.lblGoodsId.TabIndex = 1;
            this.lblGoodsId.Text = "Goods ID";
            this.lblGoodsId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGoodsId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.BackColor = System.Drawing.Color.White;
            this.txtGoodsName.BorderColor = System.Drawing.Color.LightGray;
            this.txtGoodsName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtGoodsName.BorderRadius = 10;
            this.txtGoodsName.BorderSize = 1;
            this.txtGoodsName.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsName.ForeColor = System.Drawing.Color.Black;
            this.txtGoodsName.IsError = false;
            this.txtGoodsName.Location = new System.Drawing.Point(144, 68);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGoodsName.MaxLength = 32767;
            this.txtGoodsName.Multiline = true;
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGoodsName.PasswordChar = false;
            this.txtGoodsName.Placeholder = "";
            this.txtGoodsName.ReadOnly = false;
            this.txtGoodsName.Size = new System.Drawing.Size(274, 76);
            this.txtGoodsName.TabIndex = 25;
            this.txtGoodsName.TbBackColor = System.Drawing.Color.White;
            this.txtGoodsName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtGoodsName.Texts = "";
            this.txtGoodsName.UnderlinedStyle = false;
            // 
            // UserInfoHeaderContainer
            // 
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.GoodsInfoHeader);
            this.UserInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            this.UserInfoHeaderContainer.Size = new System.Drawing.Size(446, 40);
            this.UserInfoHeaderContainer.TabIndex = 20;
            // 
            // GoodsInfoHeader
            // 
            this.GoodsInfoHeader.AutoSize = true;
            this.GoodsInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.GoodsInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoodsInfoHeader.Name = "GoodsInfoHeader";
            this.GoodsInfoHeader.Size = new System.Drawing.Size(227, 25);
            this.GoodsInfoHeader.TabIndex = 6;
            this.GoodsInfoHeader.Text = "Defect Item Information";
            // 
            // lblSupAddress
            // 
            this.lblSupAddress.AutoSize = true;
            this.lblSupAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupAddress.Location = new System.Drawing.Point(10, 281);
            this.lblSupAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupAddress.Name = "lblSupAddress";
            this.lblSupAddress.Size = new System.Drawing.Size(68, 42);
            this.lblSupAddress.TabIndex = 4;
            this.lblSupAddress.Text = "Supplier\r\nAddress";
            this.lblSupAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSupAddress
            // 
            this.txtSupAddress.BackColor = System.Drawing.Color.White;
            this.txtSupAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtSupAddress.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtSupAddress.BorderRadius = 10;
            this.txtSupAddress.BorderSize = 1;
            this.txtSupAddress.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupAddress.ForeColor = System.Drawing.Color.Black;
            this.txtSupAddress.IsError = false;
            this.txtSupAddress.Location = new System.Drawing.Point(144, 257);
            this.txtSupAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSupAddress.MaxLength = 32767;
            this.txtSupAddress.Multiline = true;
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupAddress.PasswordChar = false;
            this.txtSupAddress.Placeholder = "";
            this.txtSupAddress.ReadOnly = false;
            this.txtSupAddress.Size = new System.Drawing.Size(274, 91);
            this.txtSupAddress.TabIndex = 26;
            this.txtSupAddress.TbBackColor = System.Drawing.Color.White;
            this.txtSupAddress.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtSupAddress.Texts = "";
            this.txtSupAddress.UnderlinedStyle = false;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.BackColor = System.Drawing.Color.White;
            this.txtCusAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtCusAddress.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtCusAddress.BorderRadius = 10;
            this.txtCusAddress.BorderSize = 1;
            this.txtCusAddress.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusAddress.ForeColor = System.Drawing.Color.Black;
            this.txtCusAddress.IsError = false;
            this.txtCusAddress.Location = new System.Drawing.Point(167, 118);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCusAddress.MaxLength = 32767;
            this.txtCusAddress.Multiline = true;
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCusAddress.PasswordChar = false;
            this.txtCusAddress.Placeholder = "";
            this.txtCusAddress.ReadOnly = false;
            this.txtCusAddress.Size = new System.Drawing.Size(203, 157);
            this.txtCusAddress.TabIndex = 33;
            this.txtCusAddress.TbBackColor = System.Drawing.Color.White;
            this.txtCusAddress.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtCusAddress.Texts = "";
            this.txtCusAddress.UnderlinedStyle = false;
            // 
            // customizeTextbox1
            // 
            this.customizeTextbox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.customizeTextbox1.BackColor = System.Drawing.Color.White;
            this.customizeTextbox1.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox1.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox1.BorderRadius = 10;
            this.customizeTextbox1.BorderSize = 1;
            this.customizeTextbox1.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox1.ForeColor = System.Drawing.Color.Black;
            this.customizeTextbox1.IsError = false;
            this.customizeTextbox1.Location = new System.Drawing.Point(144, 157);
            this.customizeTextbox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox1.MaxLength = 5;
            this.customizeTextbox1.Multiline = false;
            this.customizeTextbox1.Name = "customizeTextbox1";
            this.customizeTextbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox1.PasswordChar = false;
            this.customizeTextbox1.Placeholder = "";
            this.customizeTextbox1.ReadOnly = true;
            this.customizeTextbox1.Size = new System.Drawing.Size(274, 38);
            this.customizeTextbox1.TabIndex = 34;
            this.customizeTextbox1.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox1.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.customizeTextbox1.Texts = "";
            this.customizeTextbox1.UnderlinedStyle = false;
            // 
            // lblSuppler
            // 
            this.lblSuppler.AutoSize = true;
            this.lblSuppler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppler.Location = new System.Drawing.Point(40, 166);
            this.lblSuppler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuppler.Name = "lblSuppler";
            this.lblSuppler.Size = new System.Drawing.Size(68, 21);
            this.lblSuppler.TabIndex = 35;
            this.lblSuppler.Text = "Supplier";
            this.lblSuppler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(456, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(405, 505);
            this.panel2.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 40);
            this.panel4.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Collection Information";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCusPhone);
            this.panel3.Controls.Add(this.txtCusAddress);
            this.panel3.Controls.Add(this.txtGTINCode);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.lblCusAddress);
            this.panel3.Controls.Add(this.lblCusName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 465);
            this.panel3.TabIndex = 27;
            // 
            // customizeTextbox2
            // 
            this.customizeTextbox2.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.customizeTextbox2.BackColor = System.Drawing.Color.White;
            this.customizeTextbox2.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox2.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox2.BorderRadius = 10;
            this.customizeTextbox2.BorderSize = 1;
            this.customizeTextbox2.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox2.ForeColor = System.Drawing.Color.Black;
            this.customizeTextbox2.IsError = false;
            this.customizeTextbox2.Location = new System.Drawing.Point(144, 207);
            this.customizeTextbox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox2.MaxLength = 5;
            this.customizeTextbox2.Multiline = false;
            this.customizeTextbox2.Name = "customizeTextbox2";
            this.customizeTextbox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox2.PasswordChar = false;
            this.customizeTextbox2.Placeholder = "";
            this.customizeTextbox2.ReadOnly = true;
            this.customizeTextbox2.Size = new System.Drawing.Size(274, 38);
            this.customizeTextbox2.TabIndex = 36;
            this.customizeTextbox2.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox2.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.customizeTextbox2.Texts = "";
            this.customizeTextbox2.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customizeTextbox3
            // 
            this.customizeTextbox3.BackColor = System.Drawing.Color.White;
            this.customizeTextbox3.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox3.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox3.BorderRadius = 10;
            this.customizeTextbox3.BorderSize = 1;
            this.customizeTextbox3.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox3.ForeColor = System.Drawing.Color.Black;
            this.customizeTextbox3.IsError = false;
            this.customizeTextbox3.Location = new System.Drawing.Point(144, 361);
            this.customizeTextbox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox3.MaxLength = 32767;
            this.customizeTextbox3.Multiline = true;
            this.customizeTextbox3.Name = "customizeTextbox3";
            this.customizeTextbox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox3.PasswordChar = false;
            this.customizeTextbox3.Placeholder = "";
            this.customizeTextbox3.ReadOnly = false;
            this.customizeTextbox3.Size = new System.Drawing.Size(274, 91);
            this.customizeTextbox3.TabIndex = 39;
            this.customizeTextbox3.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox3.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.customizeTextbox3.Texts = "";
            this.customizeTextbox3.UnderlinedStyle = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(30, 385);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(89, 42);
            this.lblDesc.TabIndex = 38;
            this.lblDesc.Text = "Defect\r\nDescription";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefectiveItem_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(871, 579);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "DefectiveItem_Details";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defect Item Details";
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Label lblGoodsId;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private CustomizeControl.CustomizeTextbox txtGoodsId;
        private CustomizeControl.CustomizeTextbox txtGoodsName;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnSave;
        private System.Windows.Forms.Label lblCusPhone;
        private CustomizeControl.CustomizeTextbox txtGTINCode;
        private System.Windows.Forms.Label lblCusAddress;
        private CustomizeControl.CustomizeTextbox txtPrice;
        private System.Windows.Forms.Label lblCusName;
        private CustomizeControl.CustomizeTextbox customizeTextbox1;
        private System.Windows.Forms.Label lblSuppler;
        private CustomizeControl.CustomizeTextbox txtCusAddress;
        private CustomizeControl.CustomizeTextbox txtSupAddress;
        private System.Windows.Forms.Label lblSupAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private CustomizeControl.CustomizeTextbox customizeTextbox2;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox customizeTextbox3;
        private System.Windows.Forms.Label lblDesc;
    }
}