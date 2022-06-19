namespace TheBetterLimited.Views
{
    partial class DefectiveItem_Add
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
            this.tip = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.GoodsPic = new System.Windows.Forms.PictureBox();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnAddGoods = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxStatus = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.cbxSize = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.cbxCatalogue = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtGTINCode = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblGTIＮCode = new System.Windows.Forms.Label();
            this.txtPrice = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.lblCatalogue = new System.Windows.Forms.Label();
            this.txtDescription = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtGoodsName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.cbxSupplier = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsPic)).BeginInit();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
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
            this.Header.Controls.Add(this.GoodsPic);
            this.Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(272, 684);
            this.Header.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(17, 303);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(240, 110);
            this.Info.TabIndex = 5;
            this.Info.Text = "Goods are items, articles, products, or commodities that companies sell. Users ca" +
    "n add goods sold by Better Limited using this interface.";
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
            this.Title.Size = new System.Drawing.Size(123, 30);
            this.Title.TabIndex = 3;
            this.Title.Text = "Add Goods";
            // 
            // GoodsPic
            // 
            this.GoodsPic.BackColor = System.Drawing.Color.Transparent;
            this.GoodsPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoodsPic.Image = global::TheBetterLimited.Properties.Resources.photo_upload;
            this.GoodsPic.Location = new System.Drawing.Point(21, 12);
            this.GoodsPic.Name = "GoodsPic";
            this.GoodsPic.Size = new System.Drawing.Size(230, 230);
            this.GoodsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoodsPic.TabIndex = 2;
            this.GoodsPic.TabStop = false;
            this.GoodsPic.Click += new System.EventHandler(this.UserIconPic_Click);
            this.GoodsPic.MouseLeave += new System.EventHandler(this.UserIconPic_MouseLeave);
            this.GoodsPic.MouseHover += new System.EventHandler(this.UserIconPic_MouseHover);
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.btnCancel);
            this.BottomBtn.Controls.Add(this.btnAddGoods);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 620);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(492, 54);
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
            this.btnCancel.Location = new System.Drawing.Point(212, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddGoods.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddGoods.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddGoods.BorderRadius = 10;
            this.btnAddGoods.BorderSize = 0;
            this.btnAddGoods.FlatAppearance.BorderSize = 0;
            this.btnAddGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGoods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGoods.ForeColor = System.Drawing.Color.White;
            this.btnAddGoods.IsChecked = false;
            this.btnAddGoods.Location = new System.Drawing.Point(346, 6);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(128, 40);
            this.btnAddGoods.TabIndex = 6;
            this.btnAddGoods.Text = "Add Goods";
            this.btnAddGoods.TextColor = System.Drawing.Color.White;
            this.btnAddGoods.UseVisualStyleBackColor = false;
            this.btnAddGoods.Click += new System.EventHandler(this.CreateUser_Click);
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
            this.MainForm.Size = new System.Drawing.Size(512, 684);
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
            this.UserInfo.Size = new System.Drawing.Size(492, 598);
            this.UserInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxSupplier);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxStatus);
            this.panel1.Controls.Add(this.cbxSize);
            this.panel1.Controls.Add(this.cbxCatalogue);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.txtGTINCode);
            this.panel1.Controls.Add(this.lblGTIＮCode);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblGoodsName);
            this.panel1.Controls.Add(this.lblCatalogue);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.txtGoodsName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 558);
            this.panel1.TabIndex = 27;
            // 
            // cbxStatus
            // 
            this.cbxStatus.BackColor = System.Drawing.Color.White;
            this.cbxStatus.BorderColor = System.Drawing.Color.LightGray;
            this.cbxStatus.BorderRadius = 1;
            this.cbxStatus.BorderSize = 1;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Segoe UI", 12.35F);
            this.cbxStatus.ForeColor = System.Drawing.Color.Black;
            this.cbxStatus.IconColor = System.Drawing.Color.LightGray;
            this.cbxStatus.ListBackColor = System.Drawing.Color.White;
            this.cbxStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxStatus.Location = new System.Drawing.Point(161, 452);
            this.cbxStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Padding = new System.Windows.Forms.Padding(1);
            this.cbxStatus.Size = new System.Drawing.Size(307, 31);
            this.cbxStatus.TabIndex = 41;
            this.cbxStatus.Texts = "Product Status";
            this.cbxStatus.UnderlinedStyle = false;
            this.cbxStatus.Click += new System.EventHandler(this.cbxStatus_Click);
            // 
            // cbxSize
            // 
            this.cbxSize.BackColor = System.Drawing.Color.White;
            this.cbxSize.BorderColor = System.Drawing.Color.LightGray;
            this.cbxSize.BorderRadius = 1;
            this.cbxSize.BorderSize = 1;
            this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSize.Font = new System.Drawing.Font("Segoe UI", 12.35F);
            this.cbxSize.ForeColor = System.Drawing.Color.Black;
            this.cbxSize.IconColor = System.Drawing.Color.LightGray;
            this.cbxSize.ListBackColor = System.Drawing.Color.White;
            this.cbxSize.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxSize.Location = new System.Drawing.Point(161, 405);
            this.cbxSize.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Padding = new System.Windows.Forms.Padding(1);
            this.cbxSize.Size = new System.Drawing.Size(307, 31);
            this.cbxSize.TabIndex = 40;
            this.cbxSize.Texts = "Product Size";
            this.cbxSize.UnderlinedStyle = false;
            this.cbxSize.Click += new System.EventHandler(this.cbxSize_Click);
            // 
            // cbxCatalogue
            // 
            this.cbxCatalogue.BackColor = System.Drawing.Color.White;
            this.cbxCatalogue.BorderColor = System.Drawing.Color.LightGray;
            this.cbxCatalogue.BorderRadius = 1;
            this.cbxCatalogue.BorderSize = 1;
            this.cbxCatalogue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCatalogue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxCatalogue.ForeColor = System.Drawing.Color.Black;
            this.cbxCatalogue.IconColor = System.Drawing.Color.LightGray;
            this.cbxCatalogue.ListBackColor = System.Drawing.Color.White;
            this.cbxCatalogue.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxCatalogue.Location = new System.Drawing.Point(161, 72);
            this.cbxCatalogue.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxCatalogue.Name = "cbxCatalogue";
            this.cbxCatalogue.Padding = new System.Windows.Forms.Padding(1);
            this.cbxCatalogue.Size = new System.Drawing.Size(307, 31);
            this.cbxCatalogue.TabIndex = 39;
            this.cbxCatalogue.Texts = "Product Catalogue";
            this.cbxCatalogue.UnderlinedStyle = false;
            this.cbxCatalogue.Click += new System.EventHandler(this.cbxCatalogue_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(60, 457);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 21);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(67, 410);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(38, 21);
            this.lblSize.TabIndex = 32;
            this.lblSize.Text = "Size";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtGTINCode.Location = new System.Drawing.Point(161, 350);
            this.txtGTINCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGTINCode.MaxLength = 32767;
            this.txtGTINCode.Multiline = false;
            this.txtGTINCode.Name = "txtGTINCode";
            this.txtGTINCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGTINCode.PasswordChar = false;
            this.txtGTINCode.Placeholder = "Please enter the GTINCode";
            this.txtGTINCode.ReadOnly = false;
            this.txtGTINCode.Size = new System.Drawing.Size(307, 38);
            this.txtGTINCode.TabIndex = 31;
            this.txtGTINCode.TbBackColor = System.Drawing.Color.White;
            this.txtGTINCode.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtGTINCode.Texts = "Please enter the GTINCode";
            this.txtGTINCode.UnderlinedStyle = false;
            this.txtGTINCode.Click += new System.EventHandler(this.txtGTINCode_Click);
            // 
            // lblGTIＮCode
            // 
            this.lblGTIＮCode.AutoSize = true;
            this.lblGTIＮCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGTIＮCode.Location = new System.Drawing.Point(46, 359);
            this.lblGTIＮCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGTIＮCode.Name = "lblGTIＮCode";
            this.lblGTIＮCode.Size = new System.Drawing.Size(81, 21);
            this.lblGTIＮCode.TabIndex = 30;
            this.lblGTIＮCode.Text = "GTINCode";
            this.lblGTIＮCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtPrice.Location = new System.Drawing.Point(161, 295);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.Placeholder = "Please enter the price";
            this.txtPrice.ReadOnly = false;
            this.txtPrice.Size = new System.Drawing.Size(307, 38);
            this.txtPrice.TabIndex = 29;
            this.txtPrice.TbBackColor = System.Drawing.Color.White;
            this.txtPrice.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtPrice.Texts = "Please enter the price";
            this.txtPrice.UnderlinedStyle = false;
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(64, 304);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 21);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsName.Location = new System.Drawing.Point(36, 26);
            this.lblGoodsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Size = new System.Drawing.Size(101, 21);
            this.lblGoodsName.TabIndex = 3;
            this.lblGoodsName.Text = "Goods Name";
            this.lblGoodsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCatalogue
            // 
            this.lblCatalogue.AutoSize = true;
            this.lblCatalogue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogue.Location = new System.Drawing.Point(46, 77);
            this.lblCatalogue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatalogue.Name = "lblCatalogue";
            this.lblCatalogue.Size = new System.Drawing.Size(80, 21);
            this.lblCatalogue.TabIndex = 2;
            this.lblCatalogue.Text = "Catalogue";
            this.lblCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderColor = System.Drawing.Color.LightGray;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.IsError = false;
            this.txtDescription.Location = new System.Drawing.Point(161, 119);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.Placeholder = "Please enter the description";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.Size = new System.Drawing.Size(307, 159);
            this.txtDescription.TabIndex = 26;
            this.txtDescription.TbBackColor = System.Drawing.Color.White;
            this.txtDescription.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtDescription.Texts = "Please enter the description";
            this.txtDescription.UnderlinedStyle = false;
            this.txtDescription.Click += new System.EventHandler(this.txtDescription_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(42, 119);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 21);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtGoodsName.Location = new System.Drawing.Point(161, 17);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGoodsName.MaxLength = 32767;
            this.txtGoodsName.Multiline = false;
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGoodsName.PasswordChar = false;
            this.txtGoodsName.Placeholder = "Please enter the name of the goods";
            this.txtGoodsName.ReadOnly = false;
            this.txtGoodsName.Size = new System.Drawing.Size(307, 38);
            this.txtGoodsName.TabIndex = 25;
            this.txtGoodsName.TbBackColor = System.Drawing.Color.White;
            this.txtGoodsName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtGoodsName.Texts = "Please enter the name of the goods";
            this.txtGoodsName.UnderlinedStyle = false;
            this.txtGoodsName.Click += new System.EventHandler(this.txtGoodsName_Click);
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
            // cbxSupplier
            // 
            this.cbxSupplier.BackColor = System.Drawing.Color.White;
            this.cbxSupplier.BorderColor = System.Drawing.Color.LightGray;
            this.cbxSupplier.BorderRadius = 1;
            this.cbxSupplier.BorderSize = 1;
            this.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupplier.Font = new System.Drawing.Font("Segoe UI", 12.35F);
            this.cbxSupplier.ForeColor = System.Drawing.Color.Black;
            this.cbxSupplier.IconColor = System.Drawing.Color.LightGray;
            this.cbxSupplier.ListBackColor = System.Drawing.Color.White;
            this.cbxSupplier.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxSupplier.Location = new System.Drawing.Point(161, 505);
            this.cbxSupplier.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Padding = new System.Windows.Forms.Padding(1);
            this.cbxSupplier.Size = new System.Drawing.Size(307, 31);
            this.cbxSupplier.TabIndex = 43;
            this.cbxSupplier.Texts = "";
            this.cbxSupplier.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 510);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Supplier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Inventorymanagement_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(784, 684);
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Inventorymanagement_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Goods";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsPic)).EndInit();
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblCatalogue;
        private System.Windows.Forms.PictureBox GoodsPic;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private CustomizeControl.CustomizeTextbox txtDescription;
        private CustomizeControl.CustomizeTextbox txtGoodsName;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnAddGoods;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSize;
        private CustomizeControl.CustomizeTextbox txtGTINCode;
        private System.Windows.Forms.Label lblGTIＮCode;
        private CustomizeControl.CustomizeTextbox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private CustomizeControl.CustomizeComboBox cbxStatus;
        private CustomizeControl.CustomizeComboBox cbxSize;
        private CustomizeControl.CustomizeComboBox cbxCatalogue;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Label lblDescription;
        private CustomizeControl.CustomizeComboBox cbxSupplier;
        private System.Windows.Forms.Label label1;
    }
}