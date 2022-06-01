namespace TheBetterLimited.Views
{
    partial class GoodsDetails
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
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SizeRadioPanel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Remark = new System.Windows.Forms.Label();
            this.GoodsIDTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.DescriptionTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.GTINCode = new System.Windows.Forms.Label();
            this.StatusRadioGroup = new System.Windows.Forms.Panel();
            this.LockStatusRadio = new System.Windows.Forms.RadioButton();
            this.NormalStatusRadio = new System.Windows.Forms.RadioButton();
            this.Status = new System.Windows.Forms.Label();
            this.Catalogue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PriceTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StockLevelTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.Price = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.GTINCodeTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StockTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.Location = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.LocTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.CatalogueTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPic)).BeginInit();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SizeRadioPanel.SuspendLayout();
            this.StatusRadioGroup.SuspendLayout();
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
            this.Header.Size = new System.Drawing.Size(272, 620);
            this.Header.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(17, 303);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(147, 21);
            this.Info.TabIndex = 5;
            this.Info.Text = "Goods name details";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.SeaGreen;
            this.Title.Location = new System.Drawing.Point(16, 273);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(148, 30);
            this.Title.TabIndex = 3;
            this.Title.Text = "Goods Details";
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
            this.BottomBtn.Location = new System.Drawing.Point(10, 556);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(492, 54);
            this.BottomBtn.TabIndex = 1;
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
            this.CancelBtn.IsChecked = false;
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
            this.SaveBtn.IsChecked = false;
            this.SaveBtn.Location = new System.Drawing.Point(346, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(128, 40);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Add To Cart";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.UserInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(272, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(512, 620);
            this.MainForm.TabIndex = 2;
            // 
            // UserInfo
            // 
            this.UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.UserInfo.Controls.Add(this.panel1);
            this.UserInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.UserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfo.Location = new System.Drawing.Point(10, 10);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(492, 546);
            this.UserInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SizeRadioPanel);
            this.panel1.Controls.Add(this.Remark);
            this.panel1.Controls.Add(this.GoodsIDTxt);
            this.panel1.Controls.Add(this.DescriptionTxt);
            this.panel1.Controls.Add(this.GTINCode);
            this.panel1.Controls.Add(this.StatusRadioGroup);
            this.panel1.Controls.Add(this.Status);
            this.panel1.Controls.Add(this.Catalogue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.PriceTxt);
            this.panel1.Controls.Add(this.StockLevelTxt);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.GTINCodeTxt);
            this.panel1.Controls.Add(this.StockTxt);
            this.panel1.Controls.Add(this.Location);
            this.panel1.Controls.Add(this.Size);
            this.panel1.Controls.Add(this.LocTxt);
            this.panel1.Controls.Add(this.CatalogueTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 506);
            this.panel1.TabIndex = 27;
            // 
            // SizeRadioPanel
            // 
            this.SizeRadioPanel.Controls.Add(this.radioButton1);
            this.SizeRadioPanel.Controls.Add(this.radioButton2);
            this.SizeRadioPanel.Enabled = false;
            this.SizeRadioPanel.Location = new System.Drawing.Point(166, 199);
            this.SizeRadioPanel.Name = "SizeRadioPanel";
            this.SizeRadioPanel.Size = new System.Drawing.Size(308, 25);
            this.SizeRadioPanel.TabIndex = 33;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(111, 4);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 19);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.Text = "Locked";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1, 4);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 19);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.Text = "Normal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Remark
            // 
            this.Remark.AutoSize = true;
            this.Remark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remark.Location = new System.Drawing.Point(41, 420);
            this.Remark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Remark.Name = "Remark";
            this.Remark.Size = new System.Drawing.Size(89, 21);
            this.Remark.TabIndex = 31;
            this.Remark.Text = "Description";
            // 
            // GoodsIDTxt
            // 
            this.GoodsIDTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.GoodsIDTxt.BackColor = System.Drawing.Color.White;
            this.GoodsIDTxt.BorderColor = System.Drawing.Color.LightGray;
            this.GoodsIDTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.GoodsIDTxt.BorderRadius = 10;
            this.GoodsIDTxt.BorderSize = 1;
            this.GoodsIDTxt.Enabled = false;
            this.GoodsIDTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsIDTxt.ForeColor = System.Drawing.Color.Black;
            this.GoodsIDTxt.IsError = false;
            this.GoodsIDTxt.Location = new System.Drawing.Point(168, 11);
            this.GoodsIDTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GoodsIDTxt.MaxLength = 5;
            this.GoodsIDTxt.Multiline = false;
            this.GoodsIDTxt.Name = "GoodsIDTxt";
            this.GoodsIDTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.GoodsIDTxt.PasswordChar = false;
            this.GoodsIDTxt.Placeholder = "";
            this.GoodsIDTxt.ReadOnly = false;
            this.GoodsIDTxt.Size = new System.Drawing.Size(306, 38);
            this.GoodsIDTxt.TabIndex = 24;
            this.GoodsIDTxt.TbBackColor = System.Drawing.Color.White;
            this.GoodsIDTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.GoodsIDTxt.Texts = "";
            this.GoodsIDTxt.UnderlinedStyle = false;
            this.GoodsIDTxt.Load += new System.EventHandler(this.GoodsIDTxt_Load);
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.BackColor = System.Drawing.Color.White;
            this.DescriptionTxt.BorderColor = System.Drawing.Color.LightGray;
            this.DescriptionTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.DescriptionTxt.BorderRadius = 10;
            this.DescriptionTxt.BorderSize = 1;
            this.DescriptionTxt.Enabled = false;
            this.DescriptionTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTxt.ForeColor = System.Drawing.Color.Black;
            this.DescriptionTxt.IsError = false;
            this.DescriptionTxt.Location = new System.Drawing.Point(166, 420);
            this.DescriptionTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DescriptionTxt.MaxLength = 200;
            this.DescriptionTxt.Multiline = true;
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DescriptionTxt.PasswordChar = false;
            this.DescriptionTxt.Placeholder = "";
            this.DescriptionTxt.ReadOnly = false;
            this.DescriptionTxt.Size = new System.Drawing.Size(308, 75);
            this.DescriptionTxt.TabIndex = 32;
            this.DescriptionTxt.TbBackColor = System.Drawing.Color.White;
            this.DescriptionTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.DescriptionTxt.Texts = "";
            this.DescriptionTxt.UnderlinedStyle = false;
            // 
            // GTINCode
            // 
            this.GTINCode.AutoSize = true;
            this.GTINCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTINCode.Location = new System.Drawing.Point(43, 112);
            this.GTINCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GTINCode.Name = "GTINCode";
            this.GTINCode.Size = new System.Drawing.Size(85, 21);
            this.GTINCode.TabIndex = 3;
            this.GTINCode.Text = "GTIN Code";
            // 
            // StatusRadioGroup
            // 
            this.StatusRadioGroup.Controls.Add(this.radioButton3);
            this.StatusRadioGroup.Controls.Add(this.LockStatusRadio);
            this.StatusRadioGroup.Controls.Add(this.NormalStatusRadio);
            this.StatusRadioGroup.Enabled = false;
            this.StatusRadioGroup.Location = new System.Drawing.Point(166, 383);
            this.StatusRadioGroup.Name = "StatusRadioGroup";
            this.StatusRadioGroup.Size = new System.Drawing.Size(308, 25);
            this.StatusRadioGroup.TabIndex = 30;
            // 
            // LockStatusRadio
            // 
            this.LockStatusRadio.AutoSize = true;
            this.LockStatusRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockStatusRadio.Location = new System.Drawing.Point(103, 4);
            this.LockStatusRadio.Margin = new System.Windows.Forms.Padding(2);
            this.LockStatusRadio.Name = "LockStatusRadio";
            this.LockStatusRadio.Size = new System.Drawing.Size(76, 19);
            this.LockStatusRadio.TabIndex = 29;
            this.LockStatusRadio.Text = "PhaseOut";
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
            this.NormalStatusRadio.Size = new System.Drawing.Size(60, 19);
            this.NormalStatusRadio.TabIndex = 28;
            this.NormalStatusRadio.Text = "Selling";
            this.NormalStatusRadio.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(56, 385);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(59, 21);
            this.Status.TabIndex = 28;
            this.Status.Text = "Status*";
            // 
            // Catalogue
            // 
            this.Catalogue.AutoSize = true;
            this.Catalogue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catalogue.Location = new System.Drawing.Point(45, 65);
            this.Catalogue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Catalogue.Name = "Catalogue";
            this.Catalogue.Size = new System.Drawing.Size(80, 21);
            this.Catalogue.TabIndex = 2;
            this.Catalogue.Text = "Catalogue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Goods ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(42, 342);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(87, 21);
            this.Email.TabIndex = 28;
            this.Email.Text = "Stock Level";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // PriceTxt
            // 
            this.PriceTxt.BackColor = System.Drawing.Color.White;
            this.PriceTxt.BorderColor = System.Drawing.Color.LightGray;
            this.PriceTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.PriceTxt.BorderRadius = 10;
            this.PriceTxt.BorderSize = 1;
            this.PriceTxt.Enabled = false;
            this.PriceTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTxt.ForeColor = System.Drawing.Color.LightGray;
            this.PriceTxt.IsError = false;
            this.PriceTxt.Location = new System.Drawing.Point(167, 152);
            this.PriceTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PriceTxt.MaxLength = 32767;
            this.PriceTxt.Multiline = false;
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PriceTxt.PasswordChar = false;
            this.PriceTxt.Placeholder = "";
            this.PriceTxt.ReadOnly = false;
            this.PriceTxt.Size = new System.Drawing.Size(307, 38);
            this.PriceTxt.TabIndex = 26;
            this.PriceTxt.TbBackColor = System.Drawing.Color.White;
            this.PriceTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.PriceTxt.Texts = "";
            this.PriceTxt.UnderlinedStyle = false;
            // 
            // StockLevelTxt
            // 
            this.StockLevelTxt.BackColor = System.Drawing.Color.White;
            this.StockLevelTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StockLevelTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StockLevelTxt.BorderRadius = 10;
            this.StockLevelTxt.BorderSize = 1;
            this.StockLevelTxt.Enabled = false;
            this.StockLevelTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLevelTxt.ForeColor = System.Drawing.Color.Black;
            this.StockLevelTxt.IsError = false;
            this.StockLevelTxt.Location = new System.Drawing.Point(166, 333);
            this.StockLevelTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StockLevelTxt.MaxLength = 20;
            this.StockLevelTxt.Multiline = false;
            this.StockLevelTxt.Name = "StockLevelTxt";
            this.StockLevelTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StockLevelTxt.PasswordChar = false;
            this.StockLevelTxt.Placeholder = "";
            this.StockLevelTxt.ReadOnly = false;
            this.StockLevelTxt.Size = new System.Drawing.Size(308, 38);
            this.StockLevelTxt.TabIndex = 29;
            this.StockLevelTxt.TbBackColor = System.Drawing.Color.White;
            this.StockLevelTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StockLevelTxt.Texts = "";
            this.StockLevelTxt.UnderlinedStyle = false;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(63, 159);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 21);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(62, 292);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(47, 21);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "Stock";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // GTINCodeTxt
            // 
            this.GTINCodeTxt.BackColor = System.Drawing.Color.White;
            this.GTINCodeTxt.BorderColor = System.Drawing.Color.LightGray;
            this.GTINCodeTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.GTINCodeTxt.BorderRadius = 10;
            this.GTINCodeTxt.BorderSize = 1;
            this.GTINCodeTxt.Enabled = false;
            this.GTINCodeTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTINCodeTxt.ForeColor = System.Drawing.Color.Black;
            this.GTINCodeTxt.IsError = false;
            this.GTINCodeTxt.Location = new System.Drawing.Point(167, 105);
            this.GTINCodeTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GTINCodeTxt.MaxLength = 32767;
            this.GTINCodeTxt.Multiline = false;
            this.GTINCodeTxt.Name = "GTINCodeTxt";
            this.GTINCodeTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.GTINCodeTxt.PasswordChar = false;
            this.GTINCodeTxt.Placeholder = "";
            this.GTINCodeTxt.ReadOnly = false;
            this.GTINCodeTxt.Size = new System.Drawing.Size(307, 38);
            this.GTINCodeTxt.TabIndex = 25;
            this.GTINCodeTxt.TbBackColor = System.Drawing.Color.White;
            this.GTINCodeTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.GTINCodeTxt.Texts = "";
            this.GTINCodeTxt.UnderlinedStyle = false;
            // 
            // StockTxt
            // 
            this.StockTxt.BackColor = System.Drawing.Color.White;
            this.StockTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StockTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StockTxt.BorderRadius = 10;
            this.StockTxt.BorderSize = 1;
            this.StockTxt.Enabled = false;
            this.StockTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTxt.ForeColor = System.Drawing.Color.Black;
            this.StockTxt.IsError = false;
            this.StockTxt.Location = new System.Drawing.Point(166, 283);
            this.StockTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StockTxt.MaxLength = 20;
            this.StockTxt.Multiline = false;
            this.StockTxt.Name = "StockTxt";
            this.StockTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StockTxt.PasswordChar = false;
            this.StockTxt.Placeholder = "";
            this.StockTxt.ReadOnly = false;
            this.StockTxt.Size = new System.Drawing.Size(308, 38);
            this.StockTxt.TabIndex = 22;
            this.StockTxt.TbBackColor = System.Drawing.Color.White;
            this.StockTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StockTxt.Texts = "";
            this.StockTxt.UnderlinedStyle = false;
            this.StockTxt.Enter += new System.EventHandler(this.UserNameTxt_Enter);
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.Location = new System.Drawing.Point(51, 243);
            this.Location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(69, 21);
            this.Location.TabIndex = 6;
            this.Location.Text = "Location";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.Location = new System.Drawing.Point(66, 201);
            this.Size.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(38, 21);
            this.Size.TabIndex = 9;
            this.Size.Text = "Size";
            // 
            // LocTxt
            // 
            this.LocTxt.BackColor = System.Drawing.Color.White;
            this.LocTxt.BorderColor = System.Drawing.Color.LightGray;
            this.LocTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.LocTxt.BorderRadius = 10;
            this.LocTxt.BorderSize = 1;
            this.LocTxt.Enabled = false;
            this.LocTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocTxt.ForeColor = System.Drawing.Color.LightGray;
            this.LocTxt.IsError = false;
            this.LocTxt.Location = new System.Drawing.Point(166, 236);
            this.LocTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LocTxt.MaxLength = 20;
            this.LocTxt.Multiline = false;
            this.LocTxt.Name = "LocTxt";
            this.LocTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.LocTxt.PasswordChar = false;
            this.LocTxt.Placeholder = "";
            this.LocTxt.ReadOnly = false;
            this.LocTxt.Size = new System.Drawing.Size(308, 38);
            this.LocTxt.TabIndex = 23;
            this.LocTxt.TbBackColor = System.Drawing.Color.White;
            this.LocTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.LocTxt.Texts = "";
            this.LocTxt.UnderlinedStyle = false;
            // 
            // CatalogueTxt
            // 
            this.CatalogueTxt.BackColor = System.Drawing.Color.White;
            this.CatalogueTxt.BorderColor = System.Drawing.Color.LightGray;
            this.CatalogueTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.CatalogueTxt.BorderRadius = 10;
            this.CatalogueTxt.BorderSize = 1;
            this.CatalogueTxt.Enabled = false;
            this.CatalogueTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatalogueTxt.ForeColor = System.Drawing.Color.LightGray;
            this.CatalogueTxt.IsError = false;
            this.CatalogueTxt.Location = new System.Drawing.Point(167, 58);
            this.CatalogueTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CatalogueTxt.MaxLength = 32767;
            this.CatalogueTxt.Multiline = false;
            this.CatalogueTxt.Name = "CatalogueTxt";
            this.CatalogueTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CatalogueTxt.PasswordChar = false;
            this.CatalogueTxt.Placeholder = "";
            this.CatalogueTxt.ReadOnly = true;
            this.CatalogueTxt.Size = new System.Drawing.Size(307, 38);
            this.CatalogueTxt.TabIndex = 22;
            this.CatalogueTxt.TbBackColor = System.Drawing.Color.White;
            this.CatalogueTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.CatalogueTxt.Texts = "";
            this.CatalogueTxt.UnderlinedStyle = false;
            // 
            // UserInfoHeaderContainer
            // 
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.GoodsInfoHeader);
            this.UserInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            this.UserInfoHeaderContainer.Size = new System.Drawing.Size(492, 40);
            this.UserInfoHeaderContainer.TabIndex = 20;
            // 
            // GoodsInfoHeader
            // 
            this.GoodsInfoHeader.AutoSize = true;
            this.GoodsInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.GoodsInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoodsInfoHeader.Name = "GoodsInfoHeader";
            this.GoodsInfoHeader.Size = new System.Drawing.Size(183, 25);
            this.GoodsInfoHeader.TabIndex = 6;
            this.GoodsInfoHeader.Text = "Goods Information";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(221, 4);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 19);
            this.radioButton3.TabIndex = 30;
            this.radioButton3.Text = "StopSelling";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // GoodsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(784, 620);
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "GoodsDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods Details";
            this.Load += new System.EventHandler(this.Usermanagement_Edit_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPic)).EndInit();
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SizeRadioPanel.ResumeLayout(false);
            this.SizeRadioPanel.PerformLayout();
            this.StatusRadioGroup.ResumeLayout(false);
            this.StatusRadioGroup.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label GTINCode;
        private System.Windows.Forms.Label Catalogue;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox LocTxt;
        private System.Windows.Forms.PictureBox UserIconPic;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private CustomizeControl.CustomizeTextbox CatalogueTxt;
        private CustomizeControl.CustomizeTextbox GoodsIDTxt;
        private System.Windows.Forms.Label Size;
        private CustomizeControl.CustomizeTextbox PriceTxt;
        private CustomizeControl.CustomizeTextbox GTINCodeTxt;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private System.Windows.Forms.Label Email;
        private CustomizeControl.CustomizeTextbox StockLevelTxt;
        private System.Windows.Forms.Label UserName;
        private CustomizeControl.CustomizeTextbox StockTxt;
        private System.Windows.Forms.RadioButton NormalStatusRadio;
        private System.Windows.Forms.RadioButton LockStatusRadio;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Panel StatusRadioGroup;
        private System.Windows.Forms.Label Remark;
        private CustomizeControl.CustomizeTextbox DescriptionTxt;
        private System.Windows.Forms.Panel SizeRadioPanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}