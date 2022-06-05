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
            this.IconPic = new System.Windows.Forms.PictureBox();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SizeRadioGroup = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.GoodsIDTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.DescriptionTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblGTINCode = new System.Windows.Forms.Label();
            this.StatusRadioGroup = new System.Windows.Forms.Panel();
            this.sellRadio = new System.Windows.Forms.RadioButton();
            this.phaseOutRadio = new System.Windows.Forms.RadioButton();
            this.stopSellRadio = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCatalogue = new System.Windows.Forms.Label();
            this.labGoodsID = new System.Windows.Forms.Label();
            this.lblStockLevel = new System.Windows.Forms.Label();
            this.PriceTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StockLevelTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.GTINCodeTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StockTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.LocTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.CatalogueTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic)).BeginInit();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SizeRadioGroup.SuspendLayout();
            this.StatusRadioGroup.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Info);
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.IconPic);
            this.Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(272, 671);
            this.Header.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(17, 303);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(234, 169);
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
            // IconPic
            // 
            this.IconPic.BackColor = System.Drawing.Color.Transparent;
            this.IconPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.IconPic.Image = global::TheBetterLimited.Properties.Resources._default;
            this.IconPic.Location = new System.Drawing.Point(21, 12);
            this.IconPic.Name = "IconPic";
            this.IconPic.Size = new System.Drawing.Size(230, 230);
            this.IconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPic.TabIndex = 2;
            this.IconPic.TabStop = false;
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 607);
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
            this.SaveBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.MainForm.Size = new System.Drawing.Size(512, 671);
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
            this.UserInfo.Size = new System.Drawing.Size(492, 592);
            this.UserInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SizeRadioGroup);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.GoodsIDTxt);
            this.panel1.Controls.Add(this.DescriptionTxt);
            this.panel1.Controls.Add(this.lblGTINCode);
            this.panel1.Controls.Add(this.StatusRadioGroup);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblCatalogue);
            this.panel1.Controls.Add(this.labGoodsID);
            this.panel1.Controls.Add(this.lblStockLevel);
            this.panel1.Controls.Add(this.PriceTxt);
            this.panel1.Controls.Add(this.StockLevelTxt);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.GTINCodeTxt);
            this.panel1.Controls.Add(this.StockTxt);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.LocTxt);
            this.panel1.Controls.Add(this.CatalogueTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 552);
            this.panel1.TabIndex = 27;
            // 
            // SizeRadioGroup
            // 
            this.SizeRadioGroup.Controls.Add(this.radioButton1);
            this.SizeRadioGroup.Controls.Add(this.radioButton2);
            this.SizeRadioGroup.Controls.Add(this.radioButton4);
            this.SizeRadioGroup.Enabled = false;
            this.SizeRadioGroup.Location = new System.Drawing.Point(166, 199);
            this.SizeRadioGroup.Name = "SizeRadioGroup";
            this.SizeRadioGroup.Size = new System.Drawing.Size(308, 25);
            this.SizeRadioGroup.TabIndex = 33;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(221, 4);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 19);
            this.radioButton4.TabIndex = 30;
            this.radioButton4.Text = "Large";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(103, 4);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 19);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.Text = "Medium";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1, 4);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 19);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.Text = "Small";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(41, 420);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 21);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Description";
            // 
            // GoodsIDTxt
            // 
            this.GoodsIDTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.GoodsIDTxt.BackColor = System.Drawing.Color.White;
            this.GoodsIDTxt.BorderColor = System.Drawing.Color.LightGray;
            this.GoodsIDTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.GoodsIDTxt.BorderRadius = 10;
            this.GoodsIDTxt.BorderSize = 1;
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
            this.GoodsIDTxt.ReadOnly = true;
            this.GoodsIDTxt.Size = new System.Drawing.Size(306, 38);
            this.GoodsIDTxt.TabIndex = 24;
            this.GoodsIDTxt.TbBackColor = System.Drawing.Color.White;
            this.GoodsIDTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.GoodsIDTxt.Texts = "";
            this.GoodsIDTxt.UnderlinedStyle = false;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.AutoScroll = true;
            this.DescriptionTxt.BackColor = System.Drawing.Color.White;
            this.DescriptionTxt.BorderColor = System.Drawing.Color.LightGray;
            this.DescriptionTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.DescriptionTxt.BorderRadius = 10;
            this.DescriptionTxt.BorderSize = 1;
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
            this.DescriptionTxt.ReadOnly = true;
            this.DescriptionTxt.Size = new System.Drawing.Size(308, 126);
            this.DescriptionTxt.TabIndex = 32;
            this.DescriptionTxt.TbBackColor = System.Drawing.Color.White;
            this.DescriptionTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.DescriptionTxt.Texts = "";
            this.DescriptionTxt.UnderlinedStyle = false;
            // 
            // lblGTINCode
            // 
            this.lblGTINCode.AutoSize = true;
            this.lblGTINCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGTINCode.Location = new System.Drawing.Point(43, 112);
            this.lblGTINCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGTINCode.Name = "lblGTINCode";
            this.lblGTINCode.Size = new System.Drawing.Size(85, 21);
            this.lblGTINCode.TabIndex = 3;
            this.lblGTINCode.Text = "GTIN Code";
            // 
            // StatusRadioGroup
            // 
            this.StatusRadioGroup.Controls.Add(this.sellRadio);
            this.StatusRadioGroup.Controls.Add(this.phaseOutRadio);
            this.StatusRadioGroup.Controls.Add(this.stopSellRadio);
            this.StatusRadioGroup.Enabled = false;
            this.StatusRadioGroup.Location = new System.Drawing.Point(166, 383);
            this.StatusRadioGroup.Name = "StatusRadioGroup";
            this.StatusRadioGroup.Size = new System.Drawing.Size(308, 25);
            this.StatusRadioGroup.TabIndex = 30;
            // 
            // sellRadio
            // 
            this.sellRadio.AutoSize = true;
            this.sellRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sellRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.sellRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellRadio.Location = new System.Drawing.Point(1, 4);
            this.sellRadio.Margin = new System.Windows.Forms.Padding(2);
            this.sellRadio.Name = "sellRadio";
            this.sellRadio.Size = new System.Drawing.Size(61, 19);
            this.sellRadio.TabIndex = 28;
            this.sellRadio.Text = "Selling";
            this.sellRadio.UseVisualStyleBackColor = true;
            // 
            // phaseOutRadio
            // 
            this.phaseOutRadio.AutoSize = true;
            this.phaseOutRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phaseOutRadio.Location = new System.Drawing.Point(103, 4);
            this.phaseOutRadio.Margin = new System.Windows.Forms.Padding(2);
            this.phaseOutRadio.Name = "phaseOutRadio";
            this.phaseOutRadio.Size = new System.Drawing.Size(76, 19);
            this.phaseOutRadio.TabIndex = 29;
            this.phaseOutRadio.Text = "PhaseOut";
            this.phaseOutRadio.UseVisualStyleBackColor = true;
            // 
            // stopSellRadio
            // 
            this.stopSellRadio.AutoSize = true;
            this.stopSellRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopSellRadio.Location = new System.Drawing.Point(221, 4);
            this.stopSellRadio.Margin = new System.Windows.Forms.Padding(2);
            this.stopSellRadio.Name = "stopSellRadio";
            this.stopSellRadio.Size = new System.Drawing.Size(86, 19);
            this.stopSellRadio.TabIndex = 30;
            this.stopSellRadio.Text = "StopSelling";
            this.stopSellRadio.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(56, 385);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 21);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // lblCatalogue
            // 
            this.lblCatalogue.AutoSize = true;
            this.lblCatalogue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogue.Location = new System.Drawing.Point(45, 65);
            this.lblCatalogue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatalogue.Name = "lblCatalogue";
            this.lblCatalogue.Size = new System.Drawing.Size(80, 21);
            this.lblCatalogue.TabIndex = 2;
            this.lblCatalogue.Text = "Catalogue";
            // 
            // labGoodsID
            // 
            this.labGoodsID.AutoSize = true;
            this.labGoodsID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGoodsID.Location = new System.Drawing.Point(48, 18);
            this.labGoodsID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGoodsID.Name = "labGoodsID";
            this.labGoodsID.Size = new System.Drawing.Size(74, 21);
            this.labGoodsID.TabIndex = 1;
            this.labGoodsID.Text = "Goods ID";
            // 
            // lblStockLevel
            // 
            this.lblStockLevel.AutoSize = true;
            this.lblStockLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockLevel.Location = new System.Drawing.Point(42, 342);
            this.lblStockLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockLevel.Name = "lblStockLevel";
            this.lblStockLevel.Size = new System.Drawing.Size(87, 21);
            this.lblStockLevel.TabIndex = 28;
            this.lblStockLevel.Text = "Stock Level";
            // 
            // PriceTxt
            // 
            this.PriceTxt.BackColor = System.Drawing.Color.White;
            this.PriceTxt.BorderColor = System.Drawing.Color.LightGray;
            this.PriceTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.PriceTxt.BorderRadius = 10;
            this.PriceTxt.BorderSize = 1;
            this.PriceTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTxt.ForeColor = System.Drawing.Color.Black;
            this.PriceTxt.IsError = false;
            this.PriceTxt.Location = new System.Drawing.Point(167, 152);
            this.PriceTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PriceTxt.MaxLength = 32767;
            this.PriceTxt.Multiline = false;
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PriceTxt.PasswordChar = false;
            this.PriceTxt.Placeholder = "";
            this.PriceTxt.ReadOnly = true;
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
            this.StockLevelTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLevelTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.StockLevelTxt.IsError = false;
            this.StockLevelTxt.Location = new System.Drawing.Point(166, 333);
            this.StockLevelTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StockLevelTxt.MaxLength = 20;
            this.StockLevelTxt.Multiline = false;
            this.StockLevelTxt.Name = "StockLevelTxt";
            this.StockLevelTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StockLevelTxt.PasswordChar = false;
            this.StockLevelTxt.Placeholder = "";
            this.StockLevelTxt.ReadOnly = true;
            this.StockLevelTxt.Size = new System.Drawing.Size(308, 36);
            this.StockLevelTxt.TabIndex = 29;
            this.StockLevelTxt.TbBackColor = System.Drawing.Color.White;
            this.StockLevelTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StockLevelTxt.Texts = "";
            this.StockLevelTxt.UnderlinedStyle = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(63, 159);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 21);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(33, 292);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(111, 21);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Stock Quantity";
            // 
            // GTINCodeTxt
            // 
            this.GTINCodeTxt.BackColor = System.Drawing.Color.White;
            this.GTINCodeTxt.BorderColor = System.Drawing.Color.LightGray;
            this.GTINCodeTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.GTINCodeTxt.BorderRadius = 10;
            this.GTINCodeTxt.BorderSize = 1;
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
            this.GTINCodeTxt.ReadOnly = true;
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
            this.StockTxt.ReadOnly = true;
            this.StockTxt.Size = new System.Drawing.Size(308, 38);
            this.StockTxt.TabIndex = 22;
            this.StockTxt.TbBackColor = System.Drawing.Color.White;
            this.StockTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StockTxt.Texts = "";
            this.StockTxt.UnderlinedStyle = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(54, 245);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 21);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(66, 201);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(38, 21);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Size";
            // 
            // LocTxt
            // 
            this.LocTxt.BackColor = System.Drawing.Color.White;
            this.LocTxt.BorderColor = System.Drawing.Color.LightGray;
            this.LocTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.LocTxt.BorderRadius = 10;
            this.LocTxt.BorderSize = 1;
            this.LocTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocTxt.ForeColor = System.Drawing.Color.Black;
            this.LocTxt.IsError = false;
            this.LocTxt.Location = new System.Drawing.Point(166, 236);
            this.LocTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LocTxt.MaxLength = 20;
            this.LocTxt.Multiline = false;
            this.LocTxt.Name = "LocTxt";
            this.LocTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.LocTxt.PasswordChar = false;
            this.LocTxt.Placeholder = "";
            this.LocTxt.ReadOnly = true;
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
            this.CatalogueTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatalogueTxt.ForeColor = System.Drawing.Color.Black;
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
            // GoodsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(784, 671);
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
            this.Load += new System.EventHandler(this.GoodsDetails_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic)).EndInit();
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SizeRadioGroup.ResumeLayout(false);
            this.SizeRadioGroup.PerformLayout();
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
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGTINCode;
        private System.Windows.Forms.Label lblCatalogue;
        private System.Windows.Forms.Label labGoodsID;
        private CustomizeControl.CustomizeTextbox LocTxt;
        private System.Windows.Forms.PictureBox IconPic;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private CustomizeControl.CustomizeTextbox CatalogueTxt;
        private CustomizeControl.CustomizeTextbox GoodsIDTxt;
        private System.Windows.Forms.Label lblSize;
        private CustomizeControl.CustomizeTextbox PriceTxt;
        private CustomizeControl.CustomizeTextbox GTINCodeTxt;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private System.Windows.Forms.Label lblStockLevel;
        private CustomizeControl.CustomizeTextbox StockLevelTxt;
        private System.Windows.Forms.Label lblUserName;
        private CustomizeControl.CustomizeTextbox StockTxt;
        private System.Windows.Forms.RadioButton sellRadio;
        private System.Windows.Forms.RadioButton phaseOutRadio;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel StatusRadioGroup;
        private System.Windows.Forms.Label lblDescription;
        private CustomizeControl.CustomizeTextbox DescriptionTxt;
        private System.Windows.Forms.Panel SizeRadioGroup;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton stopSellRadio;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}