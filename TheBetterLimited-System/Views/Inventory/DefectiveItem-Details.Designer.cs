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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectiveItem_Details));
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.returnBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.collectBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnBack = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStatus = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStore = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblCusPhone = new System.Windows.Forms.Label();
            this.txtCollectAddress = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtCusPhone = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtCusName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblCusAddress = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDesc = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtSupTel = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSup = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblSuppler = new System.Windows.Forms.Label();
            this.txtGoodsId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.lblGoodsId = new System.Windows.Forms.Label();
            this.txtSupAddress = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblSupAddress = new System.Windows.Forms.Label();
            this.txtGoodsName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomBtn
            // 
            resources.ApplyResources(this.BottomBtn, "BottomBtn");
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.returnBtn);
            this.BottomBtn.Controls.Add(this.collectBtn);
            this.BottomBtn.Controls.Add(this.btnBack);
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Name = "BottomBtn";
            // 
            // returnBtn
            // 
            resources.ApplyResources(this.returnBtn, "returnBtn");
            this.returnBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.returnBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.returnBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.returnBtn.BorderRadius = 10;
            this.returnBtn.BorderSize = 0;
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.IsChecked = false;
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.TextColor = System.Drawing.Color.White;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnedBtn_Click);
            // 
            // collectBtn
            // 
            resources.ApplyResources(this.collectBtn, "collectBtn");
            this.collectBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.collectBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.collectBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.collectBtn.BorderRadius = 10;
            this.collectBtn.BorderSize = 0;
            this.collectBtn.FlatAppearance.BorderSize = 0;
            this.collectBtn.ForeColor = System.Drawing.Color.White;
            this.collectBtn.IsChecked = false;
            this.collectBtn.Name = "collectBtn";
            this.collectBtn.TextColor = System.Drawing.Color.White;
            this.collectBtn.UseVisualStyleBackColor = false;
            this.collectBtn.Click += new System.EventHandler(this.collectBtn_Click);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.BorderRadius = 10;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.IsChecked = false;
            this.btnBack.Name = "btnBack";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this.MainForm, "MainForm");
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.panel2);
            this.MainForm.Controls.Add(this.UserInfo);
            this.MainForm.Controls.Add(this.panel5);
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Name = "MainForm";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.txtStatus);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtQty);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtStore);
            this.panel3.Controls.Add(this.lblCusPhone);
            this.panel3.Controls.Add(this.txtCollectAddress);
            this.panel3.Controls.Add(this.txtCusPhone);
            this.panel3.Controls.Add(this.txtCusName);
            this.panel3.Controls.Add(this.lblCusAddress);
            this.panel3.Controls.Add(this.lblCusName);
            this.panel3.Name = "panel3";
            // 
            // txtStatus
            // 
            resources.ApplyResources(this.txtStatus, "txtStatus");
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.BorderColor = System.Drawing.Color.LightGray;
            this.txtStatus.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtStatus.BorderRadius = 10;
            this.txtStatus.BorderSize = 1;
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.IsError = false;
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.Multiline = false;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = false;
            this.txtStatus.Placeholder = "";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.TbBackColor = System.Drawing.Color.White;
            this.txtStatus.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.txtStatus.Texts = "";
            this.txtStatus.UnderlinedStyle = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtQty
            // 
            resources.ApplyResources(this.txtQty, "txtQty");
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.BorderColor = System.Drawing.Color.LightGray;
            this.txtQty.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtQty.BorderRadius = 10;
            this.txtQty.BorderSize = 1;
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.IsError = false;
            this.txtQty.MaxLength = 32767;
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = false;
            this.txtQty.Placeholder = "";
            this.txtQty.ReadOnly = true;
            this.txtQty.TbBackColor = System.Drawing.Color.White;
            this.txtQty.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.txtQty.Texts = "";
            this.txtQty.UnderlinedStyle = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtStore
            // 
            resources.ApplyResources(this.txtStore, "txtStore");
            this.txtStore.BackColor = System.Drawing.Color.White;
            this.txtStore.BorderColor = System.Drawing.Color.LightGray;
            this.txtStore.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtStore.BorderRadius = 10;
            this.txtStore.BorderSize = 1;
            this.txtStore.ForeColor = System.Drawing.Color.Black;
            this.txtStore.IsError = false;
            this.txtStore.MaxLength = 32767;
            this.txtStore.Multiline = false;
            this.txtStore.Name = "txtStore";
            this.txtStore.PasswordChar = false;
            this.txtStore.Placeholder = "";
            this.txtStore.ReadOnly = true;
            this.txtStore.TbBackColor = System.Drawing.Color.White;
            this.txtStore.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.txtStore.Texts = "";
            this.txtStore.UnderlinedStyle = false;
            // 
            // lblCusPhone
            // 
            resources.ApplyResources(this.lblCusPhone, "lblCusPhone");
            this.lblCusPhone.Name = "lblCusPhone";
            // 
            // txtCollectAddress
            // 
            resources.ApplyResources(this.txtCollectAddress, "txtCollectAddress");
            this.txtCollectAddress.BackColor = System.Drawing.Color.White;
            this.txtCollectAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtCollectAddress.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtCollectAddress.BorderRadius = 10;
            this.txtCollectAddress.BorderSize = 1;
            this.txtCollectAddress.ForeColor = System.Drawing.Color.Black;
            this.txtCollectAddress.IsError = false;
            this.txtCollectAddress.MaxLength = 32767;
            this.txtCollectAddress.Multiline = true;
            this.txtCollectAddress.Name = "txtCollectAddress";
            this.txtCollectAddress.PasswordChar = false;
            this.txtCollectAddress.Placeholder = "";
            this.txtCollectAddress.ReadOnly = true;
            this.txtCollectAddress.TbBackColor = System.Drawing.Color.White;
            this.txtCollectAddress.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtCollectAddress.Texts = "";
            this.txtCollectAddress.UnderlinedStyle = false;
            // 
            // txtCusPhone
            // 
            resources.ApplyResources(this.txtCusPhone, "txtCusPhone");
            this.txtCusPhone.BackColor = System.Drawing.Color.White;
            this.txtCusPhone.BorderColor = System.Drawing.Color.LightGray;
            this.txtCusPhone.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtCusPhone.BorderRadius = 10;
            this.txtCusPhone.BorderSize = 1;
            this.txtCusPhone.ForeColor = System.Drawing.Color.Black;
            this.txtCusPhone.IsError = false;
            this.txtCusPhone.MaxLength = 32767;
            this.txtCusPhone.Multiline = false;
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.PasswordChar = false;
            this.txtCusPhone.Placeholder = "";
            this.txtCusPhone.ReadOnly = true;
            this.txtCusPhone.TbBackColor = System.Drawing.Color.White;
            this.txtCusPhone.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.txtCusPhone.Texts = "";
            this.txtCusPhone.UnderlinedStyle = false;
            // 
            // txtCusName
            // 
            resources.ApplyResources(this.txtCusName, "txtCusName");
            this.txtCusName.BackColor = System.Drawing.Color.White;
            this.txtCusName.BorderColor = System.Drawing.Color.LightGray;
            this.txtCusName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtCusName.BorderRadius = 10;
            this.txtCusName.BorderSize = 1;
            this.txtCusName.ForeColor = System.Drawing.Color.Black;
            this.txtCusName.IsError = false;
            this.txtCusName.MaxLength = 32767;
            this.txtCusName.Multiline = false;
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.PasswordChar = false;
            this.txtCusName.Placeholder = "";
            this.txtCusName.ReadOnly = true;
            this.txtCusName.TbBackColor = System.Drawing.Color.White;
            this.txtCusName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.txtCusName.Texts = "";
            this.txtCusName.UnderlinedStyle = false;
            // 
            // lblCusAddress
            // 
            resources.ApplyResources(this.lblCusAddress, "lblCusAddress");
            this.lblCusAddress.Name = "lblCusAddress";
            // 
            // lblCusName
            // 
            resources.ApplyResources(this.lblCusName, "lblCusName");
            this.lblCusName.Name = "lblCusName";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Name = "panel4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
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
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.txtSupTel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSup);
            this.panel1.Controls.Add(this.lblSuppler);
            this.panel1.Controls.Add(this.txtGoodsId);
            this.panel1.Controls.Add(this.lblGoodsName);
            this.panel1.Controls.Add(this.lblGoodsId);
            this.panel1.Controls.Add(this.txtSupAddress);
            this.panel1.Controls.Add(this.lblSupAddress);
            this.panel1.Controls.Add(this.txtGoodsName);
            this.panel1.Name = "panel1";
            // 
            // txtDesc
            // 
            resources.ApplyResources(this.txtDesc, "txtDesc");
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderColor = System.Drawing.Color.LightGray;
            this.txtDesc.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtDesc.BorderRadius = 10;
            this.txtDesc.BorderSize = 1;
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.IsError = false;
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = false;
            this.txtDesc.Placeholder = "";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.TbBackColor = System.Drawing.Color.White;
            this.txtDesc.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtDesc.Texts = "";
            this.txtDesc.UnderlinedStyle = false;
            // 
            // lblDesc
            // 
            resources.ApplyResources(this.lblDesc, "lblDesc");
            this.lblDesc.Name = "lblDesc";
            // 
            // txtSupTel
            // 
            resources.ApplyResources(this.txtSupTel, "txtSupTel");
            this.txtSupTel.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtSupTel.BackColor = System.Drawing.Color.White;
            this.txtSupTel.BorderColor = System.Drawing.Color.LightGray;
            this.txtSupTel.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtSupTel.BorderRadius = 10;
            this.txtSupTel.BorderSize = 1;
            this.txtSupTel.ForeColor = System.Drawing.Color.Black;
            this.txtSupTel.IsError = false;
            this.txtSupTel.MaxLength = 5;
            this.txtSupTel.Multiline = false;
            this.txtSupTel.Name = "txtSupTel";
            this.txtSupTel.PasswordChar = false;
            this.txtSupTel.Placeholder = "";
            this.txtSupTel.ReadOnly = true;
            this.txtSupTel.TbBackColor = System.Drawing.Color.White;
            this.txtSupTel.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.txtSupTel.Texts = "";
            this.txtSupTel.UnderlinedStyle = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtSup
            // 
            resources.ApplyResources(this.txtSup, "txtSup");
            this.txtSup.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtSup.BackColor = System.Drawing.Color.White;
            this.txtSup.BorderColor = System.Drawing.Color.LightGray;
            this.txtSup.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtSup.BorderRadius = 10;
            this.txtSup.BorderSize = 1;
            this.txtSup.ForeColor = System.Drawing.Color.Black;
            this.txtSup.IsError = false;
            this.txtSup.MaxLength = 5;
            this.txtSup.Multiline = false;
            this.txtSup.Name = "txtSup";
            this.txtSup.PasswordChar = false;
            this.txtSup.Placeholder = "";
            this.txtSup.ReadOnly = true;
            this.txtSup.TbBackColor = System.Drawing.Color.White;
            this.txtSup.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.txtSup.Texts = "";
            this.txtSup.UnderlinedStyle = false;
            // 
            // lblSuppler
            // 
            resources.ApplyResources(this.lblSuppler, "lblSuppler");
            this.lblSuppler.Name = "lblSuppler";
            // 
            // txtGoodsId
            // 
            resources.ApplyResources(this.txtGoodsId, "txtGoodsId");
            this.txtGoodsId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtGoodsId.BackColor = System.Drawing.Color.White;
            this.txtGoodsId.BorderColor = System.Drawing.Color.LightGray;
            this.txtGoodsId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtGoodsId.BorderRadius = 10;
            this.txtGoodsId.BorderSize = 1;
            this.txtGoodsId.ForeColor = System.Drawing.Color.Black;
            this.txtGoodsId.IsError = false;
            this.txtGoodsId.MaxLength = 5;
            this.txtGoodsId.Multiline = false;
            this.txtGoodsId.Name = "txtGoodsId";
            this.txtGoodsId.PasswordChar = false;
            this.txtGoodsId.Placeholder = "";
            this.txtGoodsId.ReadOnly = true;
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
            resources.ApplyResources(this.lblGoodsName, "lblGoodsName");
            this.lblGoodsName.Name = "lblGoodsName";
            // 
            // lblGoodsId
            // 
            resources.ApplyResources(this.lblGoodsId, "lblGoodsId");
            this.lblGoodsId.Name = "lblGoodsId";
            this.lblGoodsId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSupAddress
            // 
            resources.ApplyResources(this.txtSupAddress, "txtSupAddress");
            this.txtSupAddress.BackColor = System.Drawing.Color.White;
            this.txtSupAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtSupAddress.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtSupAddress.BorderRadius = 10;
            this.txtSupAddress.BorderSize = 1;
            this.txtSupAddress.ForeColor = System.Drawing.Color.Black;
            this.txtSupAddress.IsError = false;
            this.txtSupAddress.MaxLength = 32767;
            this.txtSupAddress.Multiline = true;
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.PasswordChar = false;
            this.txtSupAddress.Placeholder = "";
            this.txtSupAddress.ReadOnly = true;
            this.txtSupAddress.TbBackColor = System.Drawing.Color.White;
            this.txtSupAddress.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtSupAddress.Texts = "";
            this.txtSupAddress.UnderlinedStyle = false;
            // 
            // lblSupAddress
            // 
            resources.ApplyResources(this.lblSupAddress, "lblSupAddress");
            this.lblSupAddress.Name = "lblSupAddress";
            // 
            // txtGoodsName
            // 
            resources.ApplyResources(this.txtGoodsName, "txtGoodsName");
            this.txtGoodsName.BackColor = System.Drawing.Color.White;
            this.txtGoodsName.BorderColor = System.Drawing.Color.LightGray;
            this.txtGoodsName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtGoodsName.BorderRadius = 10;
            this.txtGoodsName.BorderSize = 1;
            this.txtGoodsName.ForeColor = System.Drawing.Color.Black;
            this.txtGoodsName.IsError = false;
            this.txtGoodsName.MaxLength = 32767;
            this.txtGoodsName.Multiline = true;
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.PasswordChar = false;
            this.txtGoodsName.Placeholder = "";
            this.txtGoodsName.ReadOnly = true;
            this.txtGoodsName.TbBackColor = System.Drawing.Color.White;
            this.txtGoodsName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtGoodsName.Texts = "";
            this.txtGoodsName.UnderlinedStyle = false;
            // 
            // UserInfoHeaderContainer
            // 
            resources.ApplyResources(this.UserInfoHeaderContainer, "UserInfoHeaderContainer");
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.GoodsInfoHeader);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            // 
            // GoodsInfoHeader
            // 
            resources.ApplyResources(this.GoodsInfoHeader, "GoodsInfoHeader");
            this.GoodsInfoHeader.Name = "GoodsInfoHeader";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // DefectiveItem_Details
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DefectiveItem_Details";
            this.ShowIcon = false;
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
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
        private System.Windows.Forms.Label lblCusPhone;
        private CustomizeControl.CustomizeTextbox txtCusPhone;
        private System.Windows.Forms.Label lblCusAddress;
        private CustomizeControl.CustomizeTextbox txtCusName;
        private System.Windows.Forms.Label lblCusName;
        private CustomizeControl.CustomizeTextbox txtSup;
        private System.Windows.Forms.Label lblSuppler;
        private CustomizeControl.CustomizeTextbox txtCollectAddress;
        private CustomizeControl.CustomizeTextbox txtSupAddress;
        private System.Windows.Forms.Label lblSupAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private CustomizeControl.CustomizeTextbox txtSupTel;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label2;
        private CustomizeControl.CustomizeTextbox txtStore;
        private System.Windows.Forms.Label label3;
        private CustomizeControl.CustomizeTextbox txtQty;
        private System.Windows.Forms.Panel panel5;
        private CustomizeControl.RoundButton collectBtn;
        private CustomizeControl.RoundButton returnBtn;
        private CustomizeControl.CustomizeTextbox txtStatus;
        private System.Windows.Forms.Label label4;
        private CustomizeControl.RoundButton btnBack;
    }
}