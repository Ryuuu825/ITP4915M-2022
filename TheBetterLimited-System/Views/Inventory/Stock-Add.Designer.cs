namespace TheBetterLimited.Views
{
    partial class Stock_Add
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
            this.btnAddSupplier = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.StockInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SizeGroup = new System.Windows.Forms.Panel();
            this.roundPanel4 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.roundPanel5 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.roundPanel6 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.SearchStaffBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.staffName = new System.Windows.Forms.Label();
            this.DeptTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StaffNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtReorderLevel = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtQuantity = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtMinLimit = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblMinLimit = new System.Windows.Forms.Label();
            this.txtMaxLimit = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblMaxLimit = new System.Windows.Forms.Label();
            this.lblSupplierGoodsId = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtSupplierGoodsId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StockInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.StockInfoHeader = new System.Windows.Forms.Label();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.StockInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SizeGroup.SuspendLayout();
            this.roundPanel4.SuspendLayout();
            this.roundPanel5.SuspendLayout();
            this.roundPanel6.SuspendLayout();
            this.StockInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.btnCancel);
            this.BottomBtn.Controls.Add(this.btnAddSupplier);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 620);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(530, 54);
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
            this.btnCancel.Location = new System.Drawing.Point(261, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddSupplier.BorderRadius = 10;
            this.btnAddSupplier.BorderSize = 0;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.IsChecked = false;
            this.btnAddSupplier.Location = new System.Drawing.Point(395, 6);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(128, 40);
            this.btnAddSupplier.TabIndex = 6;
            this.btnAddSupplier.Text = "Add Stock";
            this.btnAddSupplier.TextColor = System.Drawing.Color.White;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.StockInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(550, 684);
            this.MainForm.TabIndex = 2;
            // 
            // StockInfo
            // 
            this.StockInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.StockInfo.Controls.Add(this.panel1);
            this.StockInfo.Controls.Add(this.StockInfoHeaderContainer);
            this.StockInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.StockInfo.Location = new System.Drawing.Point(10, 10);
            this.StockInfo.Name = "StockInfo";
            this.StockInfo.Size = new System.Drawing.Size(530, 605);
            this.StockInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SizeGroup);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.SearchStaffBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.staffName);
            this.panel1.Controls.Add(this.DeptTxt);
            this.panel1.Controls.Add(this.StaffNameTxt);
            this.panel1.Controls.Add(this.txtReorderLevel);
            this.panel1.Controls.Add(this.lblReorderLevel);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtMinLimit);
            this.panel1.Controls.Add(this.lblMinLimit);
            this.panel1.Controls.Add(this.txtMaxLimit);
            this.panel1.Controls.Add(this.lblMaxLimit);
            this.panel1.Controls.Add(this.lblSupplierGoodsId);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.txtSupplierGoodsId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 565);
            this.panel1.TabIndex = 27;
            // 
            // SizeGroup
            // 
            this.SizeGroup.Controls.Add(this.roundPanel4);
            this.SizeGroup.Controls.Add(this.roundPanel5);
            this.SizeGroup.Controls.Add(this.roundPanel6);
            this.SizeGroup.Location = new System.Drawing.Point(198, 237);
            this.SizeGroup.Name = "SizeGroup";
            this.SizeGroup.Size = new System.Drawing.Size(308, 33);
            this.SizeGroup.TabIndex = 52;
            // 
            // roundPanel4
            // 
            this.roundPanel4.BackColor = System.Drawing.Color.White;
            this.roundPanel4.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel4.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel4.BorderRadius = 5;
            this.roundPanel4.BorderSize = 1;
            this.roundPanel4.Controls.Add(this.label4);
            this.roundPanel4.ForeColor = System.Drawing.Color.White;
            this.roundPanel4.Location = new System.Drawing.Point(3, 5);
            this.roundPanel4.Name = "roundPanel4";
            this.roundPanel4.Size = new System.Drawing.Size(67, 25);
            this.roundPanel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(10, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Small";
            // 
            // roundPanel5
            // 
            this.roundPanel5.BackColor = System.Drawing.Color.White;
            this.roundPanel5.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel5.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel5.BorderRadius = 5;
            this.roundPanel5.BorderSize = 1;
            this.roundPanel5.Controls.Add(this.label5);
            this.roundPanel5.ForeColor = System.Drawing.Color.White;
            this.roundPanel5.Location = new System.Drawing.Point(107, 5);
            this.roundPanel5.Name = "roundPanel5";
            this.roundPanel5.Size = new System.Drawing.Size(79, 25);
            this.roundPanel5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(9, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Medium";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundPanel6
            // 
            this.roundPanel6.BackColor = System.Drawing.Color.White;
            this.roundPanel6.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel6.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel6.BorderRadius = 5;
            this.roundPanel6.BorderSize = 1;
            this.roundPanel6.Controls.Add(this.label6);
            this.roundPanel6.ForeColor = System.Drawing.Color.White;
            this.roundPanel6.Location = new System.Drawing.Point(223, 5);
            this.roundPanel6.Name = "roundPanel6";
            this.roundPanel6.Size = new System.Drawing.Size(67, 25);
            this.roundPanel6.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(12, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Large";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(82, 247);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(38, 21);
            this.lblSize.TabIndex = 51;
            this.lblSize.Text = "Size";
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
            this.SearchStaffBtn.Location = new System.Drawing.Point(474, 21);
            this.SearchStaffBtn.Name = "SearchStaffBtn";
            this.SearchStaffBtn.Size = new System.Drawing.Size(30, 30);
            this.SearchStaffBtn.TabIndex = 50;
            this.SearchStaffBtn.TextColor = System.Drawing.Color.White;
            this.SearchStaffBtn.UseVisualStyleBackColor = false;
            this.SearchStaffBtn.Click += new System.EventHandler(this.SearchStaffBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "GTINCode";
            // 
            // staffName
            // 
            this.staffName.AutoSize = true;
            this.staffName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffName.Location = new System.Drawing.Point(49, 103);
            this.staffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffName.Name = "staffName";
            this.staffName.Size = new System.Drawing.Size(101, 21);
            this.staffName.TabIndex = 44;
            this.staffName.Text = "Goods Name";
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
            this.DeptTxt.ForeColor = System.Drawing.Color.Black;
            this.DeptTxt.IsError = false;
            this.DeptTxt.Location = new System.Drawing.Point(200, 176);
            this.DeptTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeptTxt.MaxLength = 32767;
            this.DeptTxt.Multiline = false;
            this.DeptTxt.Name = "DeptTxt";
            this.DeptTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DeptTxt.PasswordChar = false;
            this.DeptTxt.Placeholder = "";
            this.DeptTxt.ReadOnly = false;
            this.DeptTxt.Size = new System.Drawing.Size(307, 38);
            this.DeptTxt.TabIndex = 48;
            this.DeptTxt.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.DeptTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.DeptTxt.Texts = "Automatic Data Entry";
            this.DeptTxt.UnderlinedStyle = false;
            // 
            // StaffNameTxt
            // 
            this.StaffNameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StaffNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StaffNameTxt.BorderRadius = 10;
            this.StaffNameTxt.BorderSize = 1;
            this.StaffNameTxt.Enabled = false;
            this.StaffNameTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameTxt.ForeColor = System.Drawing.Color.Black;
            this.StaffNameTxt.IsError = false;
            this.StaffNameTxt.Location = new System.Drawing.Point(197, 73);
            this.StaffNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StaffNameTxt.MaxLength = 32767;
            this.StaffNameTxt.Multiline = true;
            this.StaffNameTxt.Name = "StaffNameTxt";
            this.StaffNameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StaffNameTxt.PasswordChar = false;
            this.StaffNameTxt.Placeholder = "";
            this.StaffNameTxt.ReadOnly = false;
            this.StaffNameTxt.Size = new System.Drawing.Size(307, 80);
            this.StaffNameTxt.TabIndex = 47;
            this.StaffNameTxt.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StaffNameTxt.Texts = "Automatic Data Entry";
            this.StaffNameTxt.UnderlinedStyle = false;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.BackColor = System.Drawing.Color.White;
            this.txtReorderLevel.BorderColor = System.Drawing.Color.LightGray;
            this.txtReorderLevel.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtReorderLevel.BorderRadius = 10;
            this.txtReorderLevel.BorderSize = 1;
            this.txtReorderLevel.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReorderLevel.ForeColor = System.Drawing.Color.Black;
            this.txtReorderLevel.IsError = false;
            this.txtReorderLevel.Location = new System.Drawing.Point(201, 468);
            this.txtReorderLevel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtReorderLevel.MaxLength = 32767;
            this.txtReorderLevel.Multiline = false;
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReorderLevel.PasswordChar = false;
            this.txtReorderLevel.Placeholder = "Please enter the reorder level";
            this.txtReorderLevel.ReadOnly = false;
            this.txtReorderLevel.Size = new System.Drawing.Size(307, 38);
            this.txtReorderLevel.TabIndex = 43;
            this.txtReorderLevel.TbBackColor = System.Drawing.Color.White;
            this.txtReorderLevel.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtReorderLevel.Texts = "Please enter the reorder level";
            this.txtReorderLevel.UnderlinedStyle = false;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(43, 477);
            this.lblReorderLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(106, 21);
            this.lblReorderLevel.TabIndex = 42;
            this.lblReorderLevel.Text = "Reorder Level";
            this.lblReorderLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.LightGray;
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtQuantity.BorderRadius = 10;
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.IsError = false;
            this.txtQuantity.Location = new System.Drawing.Point(200, 300);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.Placeholder = "Please enter the quantity";
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.Size = new System.Drawing.Size(307, 38);
            this.txtQuantity.TabIndex = 40;
            this.txtQuantity.TbBackColor = System.Drawing.Color.White;
            this.txtQuantity.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtQuantity.Texts = "Please enter the quantity";
            this.txtQuantity.UnderlinedStyle = false;
            // 
            // txtMinLimit
            // 
            this.txtMinLimit.BackColor = System.Drawing.Color.White;
            this.txtMinLimit.BorderColor = System.Drawing.Color.LightGray;
            this.txtMinLimit.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtMinLimit.BorderRadius = 10;
            this.txtMinLimit.BorderSize = 1;
            this.txtMinLimit.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinLimit.ForeColor = System.Drawing.Color.Black;
            this.txtMinLimit.IsError = false;
            this.txtMinLimit.Location = new System.Drawing.Point(200, 412);
            this.txtMinLimit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMinLimit.MaxLength = 32767;
            this.txtMinLimit.Multiline = false;
            this.txtMinLimit.Name = "txtMinLimit";
            this.txtMinLimit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMinLimit.PasswordChar = false;
            this.txtMinLimit.Placeholder = "Please enter the minimum limit";
            this.txtMinLimit.ReadOnly = false;
            this.txtMinLimit.Size = new System.Drawing.Size(307, 38);
            this.txtMinLimit.TabIndex = 31;
            this.txtMinLimit.TbBackColor = System.Drawing.Color.White;
            this.txtMinLimit.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtMinLimit.Texts = "Please enter the minimum limit";
            this.txtMinLimit.UnderlinedStyle = false;
            // 
            // lblMinLimit
            // 
            this.lblMinLimit.AutoSize = true;
            this.lblMinLimit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinLimit.Location = new System.Drawing.Point(57, 421);
            this.lblMinLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinLimit.Name = "lblMinLimit";
            this.lblMinLimit.Size = new System.Drawing.Size(79, 21);
            this.lblMinLimit.TabIndex = 30;
            this.lblMinLimit.Text = "Min. Limit";
            this.lblMinLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxLimit
            // 
            this.txtMaxLimit.BackColor = System.Drawing.Color.White;
            this.txtMaxLimit.BorderColor = System.Drawing.Color.LightGray;
            this.txtMaxLimit.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtMaxLimit.BorderRadius = 10;
            this.txtMaxLimit.BorderSize = 1;
            this.txtMaxLimit.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxLimit.ForeColor = System.Drawing.Color.Black;
            this.txtMaxLimit.IsError = false;
            this.txtMaxLimit.Location = new System.Drawing.Point(200, 356);
            this.txtMaxLimit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMaxLimit.MaxLength = 32767;
            this.txtMaxLimit.Multiline = false;
            this.txtMaxLimit.Name = "txtMaxLimit";
            this.txtMaxLimit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaxLimit.PasswordChar = false;
            this.txtMaxLimit.Placeholder = "Please enter the maximum limit";
            this.txtMaxLimit.ReadOnly = false;
            this.txtMaxLimit.Size = new System.Drawing.Size(307, 38);
            this.txtMaxLimit.TabIndex = 29;
            this.txtMaxLimit.TbBackColor = System.Drawing.Color.White;
            this.txtMaxLimit.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtMaxLimit.Texts = "Please enter the maximum limit";
            this.txtMaxLimit.UnderlinedStyle = false;
            // 
            // lblMaxLimit
            // 
            this.lblMaxLimit.AutoSize = true;
            this.lblMaxLimit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxLimit.Location = new System.Drawing.Point(56, 365);
            this.lblMaxLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxLimit.Name = "lblMaxLimit";
            this.lblMaxLimit.Size = new System.Drawing.Size(81, 21);
            this.lblMaxLimit.TabIndex = 28;
            this.lblMaxLimit.Text = "Max. Limit";
            this.lblMaxLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupplierGoodsId
            // 
            this.lblSupplierGoodsId.AutoSize = true;
            this.lblSupplierGoodsId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierGoodsId.Location = new System.Drawing.Point(62, 26);
            this.lblSupplierGoodsId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierGoodsId.Name = "lblSupplierGoodsId";
            this.lblSupplierGoodsId.Size = new System.Drawing.Size(74, 21);
            this.lblSupplierGoodsId.TabIndex = 3;
            this.lblSupplierGoodsId.Text = "Goods ID";
            this.lblSupplierGoodsId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(61, 309);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 21);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSupplierGoodsId
            // 
            this.txtSupplierGoodsId.BackColor = System.Drawing.Color.White;
            this.txtSupplierGoodsId.BorderColor = System.Drawing.Color.LightGray;
            this.txtSupplierGoodsId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtSupplierGoodsId.BorderRadius = 10;
            this.txtSupplierGoodsId.BorderSize = 1;
            this.txtSupplierGoodsId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierGoodsId.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierGoodsId.IsError = false;
            this.txtSupplierGoodsId.Location = new System.Drawing.Point(198, 17);
            this.txtSupplierGoodsId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSupplierGoodsId.MaxLength = 32767;
            this.txtSupplierGoodsId.Multiline = false;
            this.txtSupplierGoodsId.Name = "txtSupplierGoodsId";
            this.txtSupplierGoodsId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupplierGoodsId.PasswordChar = false;
            this.txtSupplierGoodsId.Placeholder = "Automatically generated";
            this.txtSupplierGoodsId.ReadOnly = false;
            this.txtSupplierGoodsId.Size = new System.Drawing.Size(269, 38);
            this.txtSupplierGoodsId.TabIndex = 25;
            this.txtSupplierGoodsId.TbBackColor = System.Drawing.Color.White;
            this.txtSupplierGoodsId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtSupplierGoodsId.Texts = "Automatically generated";
            this.txtSupplierGoodsId.UnderlinedStyle = false;
            // 
            // StockInfoHeaderContainer
            // 
            this.StockInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.StockInfoHeaderContainer.Controls.Add(this.StockInfoHeader);
            this.StockInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.StockInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.StockInfoHeaderContainer.Name = "StockInfoHeaderContainer";
            this.StockInfoHeaderContainer.Size = new System.Drawing.Size(530, 40);
            this.StockInfoHeaderContainer.TabIndex = 20;
            // 
            // StockInfoHeader
            // 
            this.StockInfoHeader.AutoSize = true;
            this.StockInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.StockInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StockInfoHeader.Name = "StockInfoHeader";
            this.StockInfoHeader.Size = new System.Drawing.Size(175, 25);
            this.StockInfoHeader.TabIndex = 6;
            this.StockInfoHeader.Text = "Stock Information";
            // 
            // Stock_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(550, 684);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Stock_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stock";
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.StockInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SizeGroup.ResumeLayout(false);
            this.roundPanel4.ResumeLayout(false);
            this.roundPanel4.PerformLayout();
            this.roundPanel5.ResumeLayout(false);
            this.roundPanel5.PerformLayout();
            this.roundPanel6.ResumeLayout(false);
            this.roundPanel6.PerformLayout();
            this.StockInfoHeaderContainer.ResumeLayout(false);
            this.StockInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel StockInfo;
        private System.Windows.Forms.Panel StockInfoHeaderContainer;
        private System.Windows.Forms.Label StockInfoHeader;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnAddSupplier;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.CustomizeTextbox txtReorderLevel;
        private System.Windows.Forms.Label lblReorderLevel;
        private CustomizeControl.CustomizeTextbox txtQuantity;
        private CustomizeControl.CustomizeTextbox txtMinLimit;
        private System.Windows.Forms.Label lblMinLimit;
        private CustomizeControl.CustomizeTextbox txtMaxLimit;
        private System.Windows.Forms.Label lblMaxLimit;
        private System.Windows.Forms.Label lblSupplierGoodsId;
        private System.Windows.Forms.Label lblQuantity;
        private CustomizeControl.CustomizeTextbox txtSupplierGoodsId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label staffName;
        private CustomizeControl.CustomizeTextbox DeptTxt;
        private CustomizeControl.CustomizeTextbox StaffNameTxt;
        private CustomizeControl.RoundButton SearchStaffBtn;
        private System.Windows.Forms.Panel SizeGroup;
        private CustomizeControl.RoundPanel roundPanel4;
        private System.Windows.Forms.Label label4;
        private CustomizeControl.RoundPanel roundPanel5;
        private System.Windows.Forms.Label label5;
        private CustomizeControl.RoundPanel roundPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSize;
    }
}