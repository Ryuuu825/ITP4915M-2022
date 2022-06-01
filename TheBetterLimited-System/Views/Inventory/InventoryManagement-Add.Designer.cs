namespace TheBetterLimited.Views
{
    partial class Inventorymanagement_Add
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
            this.UserIconPic = new System.Windows.Forms.PictureBox();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.CreateUser = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchStaffBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.GoodsIdTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.lblCatalogue = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.PositionTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.DeptTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.customizeTextbox1 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.customizeTextbox2 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblGTIＮCode = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPic)).BeginInit();
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
            this.Header.Controls.Add(this.UserIconPic);
            this.Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(272, 571);
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
            // UserIconPic
            // 
            this.UserIconPic.BackColor = System.Drawing.Color.Transparent;
            this.UserIconPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserIconPic.Image = global::TheBetterLimited.Properties.Resources.photo_upload;
            this.UserIconPic.Location = new System.Drawing.Point(21, 12);
            this.UserIconPic.Name = "UserIconPic";
            this.UserIconPic.Size = new System.Drawing.Size(230, 230);
            this.UserIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIconPic.TabIndex = 2;
            this.UserIconPic.TabStop = false;
            this.UserIconPic.Click += new System.EventHandler(this.UserIconPic_Click);
            this.UserIconPic.Paint += new System.Windows.Forms.PaintEventHandler(this.UserIconPic_Paint);
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
            this.BottomBtn.Location = new System.Drawing.Point(10, 507);
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
            this.CreateUser.IsChecked = false;
            this.CreateUser.Location = new System.Drawing.Point(346, 6);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(128, 40);
            this.CreateUser.TabIndex = 6;
            this.CreateUser.Text = "Create User";
            this.CreateUser.TextColor = System.Drawing.Color.White;
            this.CreateUser.UseVisualStyleBackColor = false;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
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
            this.MainForm.Size = new System.Drawing.Size(512, 571);
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
            this.UserInfo.Size = new System.Drawing.Size(492, 482);
            this.UserInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.customizeTextbox2);
            this.panel1.Controls.Add(this.lblGTIＮCode);
            this.panel1.Controls.Add(this.customizeTextbox1);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.SearchStaffBtn);
            this.panel1.Controls.Add(this.GoodsIdTxt);
            this.panel1.Controls.Add(this.lblGoodsName);
            this.panel1.Controls.Add(this.lblCatalogue);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.PositionTxt);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.DeptTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 442);
            this.panel1.TabIndex = 27;
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
            this.SearchStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchStaffBtn.FlatAppearance.BorderSize = 0;
            this.SearchStaffBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SearchStaffBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SearchStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchStaffBtn.ForeColor = System.Drawing.Color.White;
            this.SearchStaffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchStaffBtn.IsChecked = false;
            this.SearchStaffBtn.Location = new System.Drawing.Point(442, 20);
            this.SearchStaffBtn.Name = "SearchStaffBtn";
            this.SearchStaffBtn.Size = new System.Drawing.Size(30, 30);
            this.SearchStaffBtn.TabIndex = 27;
            this.SearchStaffBtn.TextColor = System.Drawing.Color.White;
            this.SearchStaffBtn.UseVisualStyleBackColor = false;
            this.SearchStaffBtn.Click += new System.EventHandler(this.SearchStaffBtn_Click);
            // 
            // GoodsIdTxt
            // 
            this.GoodsIdTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.GoodsIdTxt.BackColor = System.Drawing.Color.White;
            this.GoodsIdTxt.BorderColor = System.Drawing.Color.LightGray;
            this.GoodsIdTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.GoodsIdTxt.BorderRadius = 10;
            this.GoodsIdTxt.BorderSize = 1;
            this.GoodsIdTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsIdTxt.ForeColor = System.Drawing.Color.Black;
            this.GoodsIdTxt.IsError = false;
            this.GoodsIdTxt.Location = new System.Drawing.Point(161, 13);
            this.GoodsIdTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GoodsIdTxt.MaxLength = 5;
            this.GoodsIdTxt.Multiline = false;
            this.GoodsIdTxt.Name = "GoodsIdTxt";
            this.GoodsIdTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.GoodsIdTxt.PasswordChar = false;
            this.GoodsIdTxt.Placeholder = "Automatically Generated";
            this.GoodsIdTxt.ReadOnly = true;
            this.GoodsIdTxt.Size = new System.Drawing.Size(274, 38);
            this.GoodsIdTxt.TabIndex = 1;
            this.GoodsIdTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.GoodsIdTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.GoodsIdTxt.Texts = "Automatically Generated";
            this.GoodsIdTxt.UnderlinedStyle = false;
            this.GoodsIdTxt._TextChanged += new System.EventHandler(this.StaffIDTxt__TextChanged);
            this.GoodsIdTxt.Click += new System.EventHandler(this.StaffIDTxt_Click);
            this.GoodsIdTxt.Enter += new System.EventHandler(this.StaffIDTxt_Enter);
            this.GoodsIdTxt.Leave += new System.EventHandler(this.StaffIDTxt_Leave);
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsName.Location = new System.Drawing.Point(35, 116);
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
            this.lblCatalogue.Location = new System.Drawing.Point(37, 70);
            this.lblCatalogue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatalogue.Name = "lblCatalogue";
            this.lblCatalogue.Size = new System.Drawing.Size(80, 21);
            this.lblCatalogue.TabIndex = 2;
            this.lblCatalogue.Text = "Catalogue";
            this.lblCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(36, 13);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(81, 21);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Goods ID*";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // PositionTxt
            // 
            this.PositionTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PositionTxt.BorderColor = System.Drawing.Color.LightGray;
            this.PositionTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.PositionTxt.BorderRadius = 10;
            this.PositionTxt.BorderSize = 1;
            this.PositionTxt.Enabled = false;
            this.PositionTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionTxt.ForeColor = System.Drawing.Color.LightGray;
            this.PositionTxt.IsError = false;
            this.PositionTxt.Location = new System.Drawing.Point(161, 172);
            this.PositionTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PositionTxt.MaxLength = 32767;
            this.PositionTxt.Multiline = false;
            this.PositionTxt.Name = "PositionTxt";
            this.PositionTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PositionTxt.PasswordChar = false;
            this.PositionTxt.Placeholder = "Please enter the description";
            this.PositionTxt.ReadOnly = false;
            this.PositionTxt.Size = new System.Drawing.Size(307, 38);
            this.PositionTxt.TabIndex = 26;
            this.PositionTxt.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.PositionTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.PositionTxt.Texts = "Please enter the description";
            this.PositionTxt.UnderlinedStyle = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(35, 172);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 21);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeptTxt
            // 
            this.DeptTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeptTxt.BorderColor = System.Drawing.Color.LightGray;
            this.DeptTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.DeptTxt.BorderRadius = 10;
            this.DeptTxt.BorderSize = 1;
            this.DeptTxt.Enabled = false;
            this.DeptTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptTxt.ForeColor = System.Drawing.Color.LightGray;
            this.DeptTxt.IsError = false;
            this.DeptTxt.Location = new System.Drawing.Point(161, 116);
            this.DeptTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeptTxt.MaxLength = 32767;
            this.DeptTxt.Multiline = false;
            this.DeptTxt.Name = "DeptTxt";
            this.DeptTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DeptTxt.PasswordChar = false;
            this.DeptTxt.Placeholder = "Please enter the name of the goods";
            this.DeptTxt.ReadOnly = false;
            this.DeptTxt.Size = new System.Drawing.Size(307, 38);
            this.DeptTxt.TabIndex = 25;
            this.DeptTxt.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.DeptTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.DeptTxt.Texts = "Please enter the name of the goods";
            this.DeptTxt.UnderlinedStyle = false;
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
            // customizeTextbox1
            // 
            this.customizeTextbox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customizeTextbox1.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox1.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox1.BorderRadius = 10;
            this.customizeTextbox1.BorderSize = 1;
            this.customizeTextbox1.Enabled = false;
            this.customizeTextbox1.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox1.ForeColor = System.Drawing.Color.LightGray;
            this.customizeTextbox1.IsError = false;
            this.customizeTextbox1.Location = new System.Drawing.Point(161, 223);
            this.customizeTextbox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox1.MaxLength = 32767;
            this.customizeTextbox1.Multiline = false;
            this.customizeTextbox1.Name = "customizeTextbox1";
            this.customizeTextbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox1.PasswordChar = false;
            this.customizeTextbox1.Placeholder = "Please enter the price";
            this.customizeTextbox1.ReadOnly = false;
            this.customizeTextbox1.Size = new System.Drawing.Size(307, 38);
            this.customizeTextbox1.TabIndex = 29;
            this.customizeTextbox1.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.customizeTextbox1.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.customizeTextbox1.Texts = "Please enter the price";
            this.customizeTextbox1.UnderlinedStyle = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(35, 223);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 21);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customizeTextbox2
            // 
            this.customizeTextbox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customizeTextbox2.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox2.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox2.BorderRadius = 10;
            this.customizeTextbox2.BorderSize = 1;
            this.customizeTextbox2.Enabled = false;
            this.customizeTextbox2.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox2.ForeColor = System.Drawing.Color.LightGray;
            this.customizeTextbox2.IsError = false;
            this.customizeTextbox2.Location = new System.Drawing.Point(161, 273);
            this.customizeTextbox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox2.MaxLength = 32767;
            this.customizeTextbox2.Multiline = false;
            this.customizeTextbox2.Name = "customizeTextbox2";
            this.customizeTextbox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox2.PasswordChar = false;
            this.customizeTextbox2.Placeholder = "Automatically Generated";
            this.customizeTextbox2.ReadOnly = false;
            this.customizeTextbox2.Size = new System.Drawing.Size(307, 38);
            this.customizeTextbox2.TabIndex = 31;
            this.customizeTextbox2.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.customizeTextbox2.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.customizeTextbox2.Texts = "Automatically Generated";
            this.customizeTextbox2.UnderlinedStyle = false;
            // 
            // lblGTIＮCode
            // 
            this.lblGTIＮCode.AutoSize = true;
            this.lblGTIＮCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGTIＮCode.Location = new System.Drawing.Point(35, 273);
            this.lblGTIＮCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGTIＮCode.Name = "lblGTIＮCode";
            this.lblGTIＮCode.Size = new System.Drawing.Size(81, 21);
            this.lblGTIＮCode.TabIndex = 30;
            this.lblGTIＮCode.Text = "GTINCode";
            this.lblGTIＮCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(35, 329);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(38, 21);
            this.lblSize.TabIndex = 32;
            this.lblSize.Text = "Size";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(35, 373);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 21);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("PMingLiU", 12.10084F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 24);
            this.comboBox1.TabIndex = 36;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("PMingLiU", 12.10084F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(161, 330);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(307, 24);
            this.comboBox2.TabIndex = 37;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("PMingLiU", 12.10084F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(161, 374);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(307, 24);
            this.comboBox3.TabIndex = 38;
            // 
            // Inventorymanagement_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(784, 571);
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Inventorymanagement_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPic)).EndInit();
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
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Label lblCatalogue;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox UserIconPic;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private CustomizeControl.CustomizeTextbox GoodsIdTxt;
        private CustomizeControl.CustomizeTextbox PositionTxt;
        private CustomizeControl.CustomizeTextbox DeptTxt;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton CreateUser;
        private CustomizeControl.RoundButton SearchStaffBtn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSize;
        private CustomizeControl.CustomizeTextbox customizeTextbox2;
        private System.Windows.Forms.Label lblGTIＮCode;
        private CustomizeControl.CustomizeTextbox customizeTextbox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}