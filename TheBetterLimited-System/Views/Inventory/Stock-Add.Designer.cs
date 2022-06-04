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
            this.txtReorderLevel = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtLocId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtQuantity = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtMinLimit = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblMinLimit = new System.Windows.Forms.Label();
            this.txtMaxLimit = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblMaxLimit = new System.Windows.Forms.Label();
            this.txtId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblSupplierGoodsId = new System.Windows.Forms.Label();
            this.lblLocationId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtSupplierGoodsId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StockInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.StockInfoHeader = new System.Windows.Forms.Label();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.StockInfo.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.BottomBtn.Location = new System.Drawing.Point(10, 472);
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
            this.MainForm.Size = new System.Drawing.Size(550, 536);
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
            this.StockInfo.Size = new System.Drawing.Size(530, 457);
            this.StockInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtReorderLevel);
            this.panel1.Controls.Add(this.lblReorderLevel);
            this.panel1.Controls.Add(this.txtLocId);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtMinLimit);
            this.panel1.Controls.Add(this.lblMinLimit);
            this.panel1.Controls.Add(this.txtMaxLimit);
            this.panel1.Controls.Add(this.lblMaxLimit);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblSupplierGoodsId);
            this.panel1.Controls.Add(this.lblLocationId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.txtSupplierGoodsId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 417);
            this.panel1.TabIndex = 27;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.BackColor = System.Drawing.Color.White;
            this.txtReorderLevel.BorderColor = System.Drawing.Color.LightGray;
            this.txtReorderLevel.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtReorderLevel.BorderRadius = 10;
            this.txtReorderLevel.BorderSize = 1;
            this.txtReorderLevel.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReorderLevel.ForeColor = System.Drawing.Color.LightGray;
            this.txtReorderLevel.IsError = false;
            this.txtReorderLevel.Location = new System.Drawing.Point(198, 346);
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
            this.lblReorderLevel.Location = new System.Drawing.Point(45, 355);
            this.lblReorderLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(106, 21);
            this.lblReorderLevel.TabIndex = 42;
            this.lblReorderLevel.Text = "Reorder Level";
            this.lblReorderLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLocId
            // 
            this.txtLocId.BackColor = System.Drawing.Color.White;
            this.txtLocId.BorderColor = System.Drawing.Color.LightGray;
            this.txtLocId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtLocId.BorderRadius = 10;
            this.txtLocId.BorderSize = 1;
            this.txtLocId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocId.ForeColor = System.Drawing.Color.LightGray;
            this.txtLocId.IsError = false;
            this.txtLocId.Location = new System.Drawing.Point(197, 67);
            this.txtLocId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLocId.MaxLength = 32767;
            this.txtLocId.Multiline = false;
            this.txtLocId.Name = "txtLocId";
            this.txtLocId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLocId.PasswordChar = false;
            this.txtLocId.Placeholder = "Automatically generated";
            this.txtLocId.ReadOnly = false;
            this.txtLocId.Size = new System.Drawing.Size(307, 38);
            this.txtLocId.TabIndex = 41;
            this.txtLocId.TbBackColor = System.Drawing.Color.White;
            this.txtLocId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtLocId.Texts = "Automatically generated";
            this.txtLocId.UnderlinedStyle = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.LightGray;
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtQuantity.BorderRadius = 10;
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.LightGray;
            this.txtQuantity.IsError = false;
            this.txtQuantity.Location = new System.Drawing.Point(197, 173);
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
            this.txtMinLimit.ForeColor = System.Drawing.Color.LightGray;
            this.txtMinLimit.IsError = false;
            this.txtMinLimit.Location = new System.Drawing.Point(197, 285);
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
            this.lblMinLimit.Location = new System.Drawing.Point(59, 294);
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
            this.txtMaxLimit.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaxLimit.IsError = false;
            this.txtMaxLimit.Location = new System.Drawing.Point(197, 224);
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
            this.lblMaxLimit.Location = new System.Drawing.Point(58, 233);
            this.lblMaxLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxLimit.Name = "lblMaxLimit";
            this.lblMaxLimit.Size = new System.Drawing.Size(81, 21);
            this.lblMaxLimit.TabIndex = 28;
            this.lblMaxLimit.Text = "Max. Limit";
            this.lblMaxLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.LightGray;
            this.txtId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtId.BorderRadius = 10;
            this.txtId.BorderSize = 1;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.IsError = false;
            this.txtId.Location = new System.Drawing.Point(197, 14);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtId.MaxLength = 5;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtId.PasswordChar = false;
            this.txtId.Placeholder = "Automatically Generated";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(307, 38);
            this.txtId.TabIndex = 1;
            this.txtId.TbBackColor = System.Drawing.Color.White;
            this.txtId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtId.Texts = "Automatically Generated";
            this.txtId.UnderlinedStyle = false;
            this.txtId._TextChanged += new System.EventHandler(this.StaffIDTxt__TextChanged);
            this.txtId.Click += new System.EventHandler(this.StaffIDTxt_Click);
            this.txtId.Enter += new System.EventHandler(this.StaffIDTxt_Enter);
            this.txtId.Leave += new System.EventHandler(this.StaffIDTxt_Leave);
            // 
            // lblSupplierGoodsId
            // 
            this.lblSupplierGoodsId.AutoSize = true;
            this.lblSupplierGoodsId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierGoodsId.Location = new System.Drawing.Point(30, 126);
            this.lblSupplierGoodsId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierGoodsId.Name = "lblSupplierGoodsId";
            this.lblSupplierGoodsId.Size = new System.Drawing.Size(136, 21);
            this.lblSupplierGoodsId.TabIndex = 3;
            this.lblSupplierGoodsId.Text = "Supplier Goods ID";
            this.lblSupplierGoodsId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLocationId
            // 
            this.lblLocationId.AutoSize = true;
            this.lblLocationId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationId.Location = new System.Drawing.Point(54, 76);
            this.lblLocationId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationId.Name = "lblLocationId";
            this.lblLocationId.Size = new System.Drawing.Size(88, 21);
            this.lblLocationId.TabIndex = 2;
            this.lblLocationId.Text = "Location ID";
            this.lblLocationId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(82, 23);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 21);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID*";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(63, 182);
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
            this.txtSupplierGoodsId.ForeColor = System.Drawing.Color.LightGray;
            this.txtSupplierGoodsId.IsError = false;
            this.txtSupplierGoodsId.Location = new System.Drawing.Point(197, 117);
            this.txtSupplierGoodsId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSupplierGoodsId.MaxLength = 32767;
            this.txtSupplierGoodsId.Multiline = false;
            this.txtSupplierGoodsId.Name = "txtSupplierGoodsId";
            this.txtSupplierGoodsId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupplierGoodsId.PasswordChar = false;
            this.txtSupplierGoodsId.Placeholder = "Automatically generated";
            this.txtSupplierGoodsId.ReadOnly = false;
            this.txtSupplierGoodsId.Size = new System.Drawing.Size(307, 38);
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
            this.ClientSize = new System.Drawing.Size(550, 536);
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
        private CustomizeControl.CustomizeTextbox txtLocId;
        private CustomizeControl.CustomizeTextbox txtQuantity;
        private CustomizeControl.CustomizeTextbox txtMinLimit;
        private System.Windows.Forms.Label lblMinLimit;
        private CustomizeControl.CustomizeTextbox txtMaxLimit;
        private System.Windows.Forms.Label lblMaxLimit;
        private CustomizeControl.CustomizeTextbox txtId;
        private System.Windows.Forms.Label lblSupplierGoodsId;
        private System.Windows.Forms.Label lblLocationId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblQuantity;
        private CustomizeControl.CustomizeTextbox txtSupplierGoodsId;
    }
}