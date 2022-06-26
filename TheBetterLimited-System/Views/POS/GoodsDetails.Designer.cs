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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsDetails));
            this.Header = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SizeGroup = new System.Windows.Forms.Panel();
            this.roundPanel4 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.roundPanel5 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.roundPanel6 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.GoodsIDTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.DescriptionTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblGTINCode = new System.Windows.Forms.Label();
            this.StatusGroup = new System.Windows.Forms.Panel();
            this.roundPanel1 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundPanel2 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.roundPanel3 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.IconPic = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SizeGroup.SuspendLayout();
            this.roundPanel4.SuspendLayout();
            this.roundPanel5.SuspendLayout();
            this.roundPanel6.SuspendLayout();
            this.StatusGroup.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            resources.ApplyResources(this.Header, "Header");
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Info);
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.IconPic);
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
            this.SaveBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this.MainForm, "MainForm");
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.UserInfo);
            this.MainForm.Name = "MainForm";
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
            this.panel1.Controls.Add(this.SizeGroup);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.GoodsIDTxt);
            this.panel1.Controls.Add(this.DescriptionTxt);
            this.panel1.Controls.Add(this.lblGTINCode);
            this.panel1.Controls.Add(this.StatusGroup);
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
            this.panel1.Name = "panel1";
            // 
            // SizeGroup
            // 
            resources.ApplyResources(this.SizeGroup, "SizeGroup");
            this.SizeGroup.Controls.Add(this.roundPanel4);
            this.SizeGroup.Controls.Add(this.roundPanel5);
            this.SizeGroup.Controls.Add(this.roundPanel6);
            this.SizeGroup.Name = "SizeGroup";
            // 
            // roundPanel4
            // 
            resources.ApplyResources(this.roundPanel4, "roundPanel4");
            this.roundPanel4.BackColor = System.Drawing.Color.White;
            this.roundPanel4.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel4.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel4.BorderRadius = 5;
            this.roundPanel4.BorderSize = 1;
            this.roundPanel4.Controls.Add(this.label4);
            this.roundPanel4.ForeColor = System.Drawing.Color.White;
            this.roundPanel4.Name = "roundPanel4";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Name = "label4";
            // 
            // roundPanel5
            // 
            resources.ApplyResources(this.roundPanel5, "roundPanel5");
            this.roundPanel5.BackColor = System.Drawing.Color.White;
            this.roundPanel5.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel5.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel5.BorderRadius = 5;
            this.roundPanel5.BorderSize = 1;
            this.roundPanel5.Controls.Add(this.label5);
            this.roundPanel5.ForeColor = System.Drawing.Color.White;
            this.roundPanel5.Name = "roundPanel5";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Name = "label5";
            // 
            // roundPanel6
            // 
            resources.ApplyResources(this.roundPanel6, "roundPanel6");
            this.roundPanel6.BackColor = System.Drawing.Color.White;
            this.roundPanel6.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel6.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel6.BorderRadius = 5;
            this.roundPanel6.BorderSize = 1;
            this.roundPanel6.Controls.Add(this.label6);
            this.roundPanel6.ForeColor = System.Drawing.Color.White;
            this.roundPanel6.Name = "roundPanel6";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Name = "label6";
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
            // 
            // GoodsIDTxt
            // 
            resources.ApplyResources(this.GoodsIDTxt, "GoodsIDTxt");
            this.GoodsIDTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.GoodsIDTxt.BackColor = System.Drawing.Color.White;
            this.GoodsIDTxt.BorderColor = System.Drawing.Color.LightGray;
            this.GoodsIDTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.GoodsIDTxt.BorderRadius = 10;
            this.GoodsIDTxt.BorderSize = 1;
            this.GoodsIDTxt.ForeColor = System.Drawing.Color.Black;
            this.GoodsIDTxt.IsError = false;
            this.GoodsIDTxt.MaxLength = 5;
            this.GoodsIDTxt.Multiline = false;
            this.GoodsIDTxt.Name = "GoodsIDTxt";
            this.GoodsIDTxt.PasswordChar = false;
            this.GoodsIDTxt.Placeholder = "";
            this.GoodsIDTxt.ReadOnly = true;
            this.GoodsIDTxt.TbBackColor = System.Drawing.Color.White;
            this.GoodsIDTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.GoodsIDTxt.Texts = "";
            this.GoodsIDTxt.UnderlinedStyle = false;
            // 
            // DescriptionTxt
            // 
            resources.ApplyResources(this.DescriptionTxt, "DescriptionTxt");
            this.DescriptionTxt.BackColor = System.Drawing.Color.White;
            this.DescriptionTxt.BorderColor = System.Drawing.Color.LightGray;
            this.DescriptionTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.DescriptionTxt.BorderRadius = 10;
            this.DescriptionTxt.BorderSize = 1;
            this.DescriptionTxt.ForeColor = System.Drawing.Color.Black;
            this.DescriptionTxt.IsError = false;
            this.DescriptionTxt.MaxLength = 200;
            this.DescriptionTxt.Multiline = true;
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.PasswordChar = false;
            this.DescriptionTxt.Placeholder = "";
            this.DescriptionTxt.ReadOnly = true;
            this.DescriptionTxt.TbBackColor = System.Drawing.Color.White;
            this.DescriptionTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.DescriptionTxt.Texts = "";
            this.DescriptionTxt.UnderlinedStyle = false;
            // 
            // lblGTINCode
            // 
            resources.ApplyResources(this.lblGTINCode, "lblGTINCode");
            this.lblGTINCode.Name = "lblGTINCode";
            // 
            // StatusGroup
            // 
            resources.ApplyResources(this.StatusGroup, "StatusGroup");
            this.StatusGroup.Controls.Add(this.roundPanel1);
            this.StatusGroup.Controls.Add(this.roundPanel2);
            this.StatusGroup.Controls.Add(this.roundPanel3);
            this.StatusGroup.Name = "StatusGroup";
            // 
            // roundPanel1
            // 
            resources.ApplyResources(this.roundPanel1, "roundPanel1");
            this.roundPanel1.BackColor = System.Drawing.Color.White;
            this.roundPanel1.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel1.BorderRadius = 5;
            this.roundPanel1.BorderSize = 1;
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.ForeColor = System.Drawing.Color.White;
            this.roundPanel1.Name = "roundPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Name = "label1";
            // 
            // roundPanel2
            // 
            resources.ApplyResources(this.roundPanel2, "roundPanel2");
            this.roundPanel2.BackColor = System.Drawing.Color.White;
            this.roundPanel2.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel2.BorderRadius = 5;
            this.roundPanel2.BorderSize = 1;
            this.roundPanel2.Controls.Add(this.label2);
            this.roundPanel2.ForeColor = System.Drawing.Color.White;
            this.roundPanel2.Name = "roundPanel2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Name = "label2";
            // 
            // roundPanel3
            // 
            resources.ApplyResources(this.roundPanel3, "roundPanel3");
            this.roundPanel3.BackColor = System.Drawing.Color.White;
            this.roundPanel3.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel3.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel3.BorderRadius = 5;
            this.roundPanel3.BorderSize = 1;
            this.roundPanel3.Controls.Add(this.label3);
            this.roundPanel3.ForeColor = System.Drawing.Color.White;
            this.roundPanel3.Name = "roundPanel3";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Name = "label3";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // lblCatalogue
            // 
            resources.ApplyResources(this.lblCatalogue, "lblCatalogue");
            this.lblCatalogue.Name = "lblCatalogue";
            // 
            // labGoodsID
            // 
            resources.ApplyResources(this.labGoodsID, "labGoodsID");
            this.labGoodsID.Name = "labGoodsID";
            // 
            // lblStockLevel
            // 
            resources.ApplyResources(this.lblStockLevel, "lblStockLevel");
            this.lblStockLevel.Name = "lblStockLevel";
            // 
            // PriceTxt
            // 
            resources.ApplyResources(this.PriceTxt, "PriceTxt");
            this.PriceTxt.BackColor = System.Drawing.Color.White;
            this.PriceTxt.BorderColor = System.Drawing.Color.LightGray;
            this.PriceTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.PriceTxt.BorderRadius = 10;
            this.PriceTxt.BorderSize = 1;
            this.PriceTxt.ForeColor = System.Drawing.Color.Black;
            this.PriceTxt.IsError = false;
            this.PriceTxt.MaxLength = 32767;
            this.PriceTxt.Multiline = false;
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.PasswordChar = false;
            this.PriceTxt.Placeholder = "";
            this.PriceTxt.ReadOnly = true;
            this.PriceTxt.TbBackColor = System.Drawing.Color.White;
            this.PriceTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.PriceTxt.Texts = "";
            this.PriceTxt.UnderlinedStyle = false;
            // 
            // StockLevelTxt
            // 
            resources.ApplyResources(this.StockLevelTxt, "StockLevelTxt");
            this.StockLevelTxt.BackColor = System.Drawing.Color.White;
            this.StockLevelTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StockLevelTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StockLevelTxt.BorderRadius = 10;
            this.StockLevelTxt.BorderSize = 1;
            this.StockLevelTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.StockLevelTxt.IsError = false;
            this.StockLevelTxt.MaxLength = 20;
            this.StockLevelTxt.Multiline = false;
            this.StockLevelTxt.Name = "StockLevelTxt";
            this.StockLevelTxt.PasswordChar = false;
            this.StockLevelTxt.Placeholder = "";
            this.StockLevelTxt.ReadOnly = true;
            this.StockLevelTxt.TbBackColor = System.Drawing.Color.White;
            this.StockLevelTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StockLevelTxt.Texts = "";
            this.StockLevelTxt.UnderlinedStyle = false;
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.Name = "lblPrice";
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // GTINCodeTxt
            // 
            resources.ApplyResources(this.GTINCodeTxt, "GTINCodeTxt");
            this.GTINCodeTxt.BackColor = System.Drawing.Color.White;
            this.GTINCodeTxt.BorderColor = System.Drawing.Color.LightGray;
            this.GTINCodeTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.GTINCodeTxt.BorderRadius = 10;
            this.GTINCodeTxt.BorderSize = 1;
            this.GTINCodeTxt.ForeColor = System.Drawing.Color.Black;
            this.GTINCodeTxt.IsError = false;
            this.GTINCodeTxt.MaxLength = 32767;
            this.GTINCodeTxt.Multiline = false;
            this.GTINCodeTxt.Name = "GTINCodeTxt";
            this.GTINCodeTxt.PasswordChar = false;
            this.GTINCodeTxt.Placeholder = "";
            this.GTINCodeTxt.ReadOnly = true;
            this.GTINCodeTxt.TbBackColor = System.Drawing.Color.White;
            this.GTINCodeTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.GTINCodeTxt.Texts = "";
            this.GTINCodeTxt.UnderlinedStyle = false;
            // 
            // StockTxt
            // 
            resources.ApplyResources(this.StockTxt, "StockTxt");
            this.StockTxt.BackColor = System.Drawing.Color.White;
            this.StockTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StockTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StockTxt.BorderRadius = 10;
            this.StockTxt.BorderSize = 1;
            this.StockTxt.ForeColor = System.Drawing.Color.Black;
            this.StockTxt.IsError = false;
            this.StockTxt.MaxLength = 20;
            this.StockTxt.Multiline = false;
            this.StockTxt.Name = "StockTxt";
            this.StockTxt.PasswordChar = false;
            this.StockTxt.Placeholder = "";
            this.StockTxt.ReadOnly = true;
            this.StockTxt.TbBackColor = System.Drawing.Color.White;
            this.StockTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StockTxt.Texts = "";
            this.StockTxt.UnderlinedStyle = false;
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.lblLocation.Name = "lblLocation";
            // 
            // lblSize
            // 
            resources.ApplyResources(this.lblSize, "lblSize");
            this.lblSize.Name = "lblSize";
            // 
            // LocTxt
            // 
            resources.ApplyResources(this.LocTxt, "LocTxt");
            this.LocTxt.BackColor = System.Drawing.Color.White;
            this.LocTxt.BorderColor = System.Drawing.Color.LightGray;
            this.LocTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.LocTxt.BorderRadius = 10;
            this.LocTxt.BorderSize = 1;
            this.LocTxt.ForeColor = System.Drawing.Color.Black;
            this.LocTxt.IsError = false;
            this.LocTxt.MaxLength = 20;
            this.LocTxt.Multiline = false;
            this.LocTxt.Name = "LocTxt";
            this.LocTxt.PasswordChar = false;
            this.LocTxt.Placeholder = "";
            this.LocTxt.ReadOnly = true;
            this.LocTxt.TbBackColor = System.Drawing.Color.White;
            this.LocTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.LocTxt.Texts = "";
            this.LocTxt.UnderlinedStyle = false;
            // 
            // CatalogueTxt
            // 
            resources.ApplyResources(this.CatalogueTxt, "CatalogueTxt");
            this.CatalogueTxt.BackColor = System.Drawing.Color.White;
            this.CatalogueTxt.BorderColor = System.Drawing.Color.LightGray;
            this.CatalogueTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.CatalogueTxt.BorderRadius = 10;
            this.CatalogueTxt.BorderSize = 1;
            this.CatalogueTxt.ForeColor = System.Drawing.Color.Black;
            this.CatalogueTxt.IsError = false;
            this.CatalogueTxt.MaxLength = 32767;
            this.CatalogueTxt.Multiline = false;
            this.CatalogueTxt.Name = "CatalogueTxt";
            this.CatalogueTxt.PasswordChar = false;
            this.CatalogueTxt.Placeholder = "";
            this.CatalogueTxt.ReadOnly = true;
            this.CatalogueTxt.TbBackColor = System.Drawing.Color.White;
            this.CatalogueTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.CatalogueTxt.Texts = "";
            this.CatalogueTxt.UnderlinedStyle = false;
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
            // IconPic
            // 
            resources.ApplyResources(this.IconPic, "IconPic");
            this.IconPic.BackColor = System.Drawing.Color.Transparent;
            this.IconPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.IconPic.Image = global::TheBetterLimited.Properties.Resources._default;
            this.IconPic.Name = "IconPic";
            this.IconPic.TabStop = false;
            // 
            // GoodsDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GoodsDetails";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.GoodsDetails_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SizeGroup.ResumeLayout(false);
            this.roundPanel4.ResumeLayout(false);
            this.roundPanel4.PerformLayout();
            this.roundPanel5.ResumeLayout(false);
            this.roundPanel5.PerformLayout();
            this.roundPanel6.ResumeLayout(false);
            this.roundPanel6.PerformLayout();
            this.StatusGroup.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic)).EndInit();
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel StatusGroup;
        private System.Windows.Forms.Label lblDescription;
        private CustomizeControl.CustomizeTextbox DescriptionTxt;
        private CustomizeControl.RoundPanel roundPanel1;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.RoundPanel roundPanel3;
        private System.Windows.Forms.Label label3;
        private CustomizeControl.RoundPanel roundPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SizeGroup;
        private CustomizeControl.RoundPanel roundPanel4;
        private System.Windows.Forms.Label label4;
        private CustomizeControl.RoundPanel roundPanel5;
        private System.Windows.Forms.Label label5;
        private CustomizeControl.RoundPanel roundPanel6;
        private System.Windows.Forms.Label label6;
    }
}