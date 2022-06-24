namespace TheBetterLimited.Views
{
    partial class RestockRequest_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestockRequest_Add));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderItemBox = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.Panel();
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.OrderInfoBox = new System.Windows.Forms.Panel();
            this.CreatorInfoBox = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customizeTextbox1 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customizeTextbox3 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerInfo = new System.Windows.Forms.Panel();
            this.CustomerInfoBox = new System.Windows.Forms.Panel();
            this.NameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.GTINCode = new System.Windows.Forms.Label();
            this.Catalogue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.PhoneTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.goodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.OrderItemBox.SuspendLayout();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            this.panel5.SuspendLayout();
            this.BottomBtn.SuspendLayout();
            this.OrderInfoBox.SuspendLayout();
            this.CreatorInfoBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CustomerInfo.SuspendLayout();
            this.CustomerInfoBox.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderItemBox
            // 
            resources.ApplyResources(this.OrderItemBox, "OrderItemBox");
            this.OrderItemBox.BackColor = System.Drawing.Color.White;
            this.OrderItemBox.Controls.Add(this.Data);
            this.OrderItemBox.Controls.Add(this.panel5);
            this.OrderItemBox.Controls.Add(this.BottomBtn);
            this.OrderItemBox.Name = "OrderItemBox";
            // 
            // Data
            // 
            resources.ApplyResources(this.Data, "Data");
            this.Data.Controls.Add(this.OrderDataGrid);
            this.Data.Name = "Data";
            // 
            // OrderDataGrid
            // 
            resources.ApplyResources(this.OrderDataGrid, "OrderDataGrid");
            this.OrderDataGrid.AllowUserToAddRows = false;
            this.OrderDataGrid.AllowUserToOrderColumns = true;
            this.OrderDataGrid.AllowUserToResizeColumns = false;
            this.OrderDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.OrderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OrderDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsID,
            this.ID,
            this.CreatorId,
            this.delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.OrderDataGrid.EnableHeadersVisualStyles = false;
            this.OrderDataGrid.GridColor = System.Drawing.Color.White;
            this.OrderDataGrid.MultiSelect = false;
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.ReadOnly = true;
            this.OrderDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.OrderDataGrid.RowHeadersVisible = false;
            this.OrderDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OrderDataGrid.RowTemplate.Height = 30;
            this.OrderDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGrid.StandardTab = true;
            this.OrderDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellClick);
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Title);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Name = "panel5";
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.Color.Black;
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
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OrderInfoBox
            // 
            resources.ApplyResources(this.OrderInfoBox, "OrderInfoBox");
            this.OrderInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OrderInfoBox.Controls.Add(this.CreatorInfoBox);
            this.OrderInfoBox.Controls.Add(this.CustomerInfo);
            this.OrderInfoBox.Name = "OrderInfoBox";
            // 
            // CreatorInfoBox
            // 
            resources.ApplyResources(this.CreatorInfoBox, "CreatorInfoBox");
            this.CreatorInfoBox.BackColor = System.Drawing.Color.White;
            this.CreatorInfoBox.Controls.Add(this.panel1);
            this.CreatorInfoBox.Controls.Add(this.panel2);
            this.CreatorInfoBox.ForeColor = System.Drawing.Color.Black;
            this.CreatorInfoBox.Name = "CreatorInfoBox";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.customizeTextbox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customizeTextbox3);
            this.panel1.Name = "panel1";
            // 
            // customizeTextbox1
            // 
            resources.ApplyResources(this.customizeTextbox1, "customizeTextbox1");
            this.customizeTextbox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.customizeTextbox1.BackColor = System.Drawing.Color.White;
            this.customizeTextbox1.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox1.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox1.BorderRadius = 10;
            this.customizeTextbox1.BorderSize = 1;
            this.customizeTextbox1.ForeColor = System.Drawing.Color.Black;
            this.customizeTextbox1.IsError = false;
            this.customizeTextbox1.MaxLength = 5;
            this.customizeTextbox1.Multiline = false;
            this.customizeTextbox1.Name = "customizeTextbox1";
            this.customizeTextbox1.PasswordChar = false;
            this.customizeTextbox1.Placeholder = "Please enter customer name";
            this.customizeTextbox1.ReadOnly = false;
            this.customizeTextbox1.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox1.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.customizeTextbox1.Texts = "Please enter customer name";
            this.customizeTextbox1.UnderlinedStyle = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // customizeTextbox3
            // 
            resources.ApplyResources(this.customizeTextbox3, "customizeTextbox3");
            this.customizeTextbox3.BackColor = System.Drawing.Color.White;
            this.customizeTextbox3.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox3.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox3.BorderRadius = 10;
            this.customizeTextbox3.BorderSize = 1;
            this.customizeTextbox3.ForeColor = System.Drawing.Color.Black;
            this.customizeTextbox3.IsError = false;
            this.customizeTextbox3.MaxLength = 32767;
            this.customizeTextbox3.Multiline = false;
            this.customizeTextbox3.Name = "customizeTextbox3";
            this.customizeTextbox3.PasswordChar = false;
            this.customizeTextbox3.Placeholder = "Please enter customer phone";
            this.customizeTextbox3.ReadOnly = false;
            this.customizeTextbox3.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox3.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.customizeTextbox3.Texts = "Please enter customer phone";
            this.customizeTextbox3.UnderlinedStyle = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // CustomerInfo
            // 
            resources.ApplyResources(this.CustomerInfo, "CustomerInfo");
            this.CustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.CustomerInfo.Controls.Add(this.CustomerInfoBox);
            this.CustomerInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.CustomerInfo.Name = "CustomerInfo";
            // 
            // CustomerInfoBox
            // 
            resources.ApplyResources(this.CustomerInfoBox, "CustomerInfoBox");
            this.CustomerInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.CustomerInfoBox.Controls.Add(this.NameTxt);
            this.CustomerInfoBox.Controls.Add(this.GTINCode);
            this.CustomerInfoBox.Controls.Add(this.Catalogue);
            this.CustomerInfoBox.Controls.Add(this.label1);
            this.CustomerInfoBox.Controls.Add(this.AddressTxt);
            this.CustomerInfoBox.Controls.Add(this.PhoneTxt);
            this.CustomerInfoBox.Name = "CustomerInfoBox";
            // 
            // NameTxt
            // 
            resources.ApplyResources(this.NameTxt, "NameTxt");
            this.NameTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.NameTxt.BackColor = System.Drawing.Color.White;
            this.NameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.NameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.NameTxt.BorderRadius = 10;
            this.NameTxt.BorderSize = 1;
            this.NameTxt.ForeColor = System.Drawing.Color.Black;
            this.NameTxt.IsError = false;
            this.NameTxt.MaxLength = 5;
            this.NameTxt.Multiline = false;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PasswordChar = false;
            this.NameTxt.Placeholder = "";
            this.NameTxt.ReadOnly = false;
            this.NameTxt.TbBackColor = System.Drawing.Color.White;
            this.NameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.NameTxt.Texts = "";
            this.NameTxt.UnderlinedStyle = false;
            // 
            // GTINCode
            // 
            resources.ApplyResources(this.GTINCode, "GTINCode");
            this.GTINCode.Name = "GTINCode";
            // 
            // Catalogue
            // 
            resources.ApplyResources(this.Catalogue, "Catalogue");
            this.Catalogue.Name = "Catalogue";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // AddressTxt
            // 
            resources.ApplyResources(this.AddressTxt, "AddressTxt");
            this.AddressTxt.BackColor = System.Drawing.Color.White;
            this.AddressTxt.BorderColor = System.Drawing.Color.LightGray;
            this.AddressTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.AddressTxt.BorderRadius = 10;
            this.AddressTxt.BorderSize = 1;
            this.AddressTxt.ForeColor = System.Drawing.Color.Black;
            this.AddressTxt.IsError = false;
            this.AddressTxt.MaxLength = 120;
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.PasswordChar = false;
            this.AddressTxt.Placeholder = "Please enter customer address";
            this.AddressTxt.ReadOnly = false;
            this.AddressTxt.TbBackColor = System.Drawing.Color.White;
            this.AddressTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.AddressTxt.Texts = "Please enter customer address";
            this.AddressTxt.UnderlinedStyle = false;
            // 
            // PhoneTxt
            // 
            resources.ApplyResources(this.PhoneTxt, "PhoneTxt");
            this.PhoneTxt.BackColor = System.Drawing.Color.White;
            this.PhoneTxt.BorderColor = System.Drawing.Color.LightGray;
            this.PhoneTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.PhoneTxt.BorderRadius = 10;
            this.PhoneTxt.BorderSize = 1;
            this.PhoneTxt.ForeColor = System.Drawing.Color.Black;
            this.PhoneTxt.IsError = false;
            this.PhoneTxt.MaxLength = 32767;
            this.PhoneTxt.Multiline = false;
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.PasswordChar = false;
            this.PhoneTxt.Placeholder = "Please enter customer phone";
            this.PhoneTxt.ReadOnly = false;
            this.PhoneTxt.TbBackColor = System.Drawing.Color.White;
            this.PhoneTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.PhoneTxt.Texts = "Please enter customer phone";
            this.PhoneTxt.UnderlinedStyle = false;
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
            // dataGridViewImageColumn3
            // 
            resources.ApplyResources(this.dataGridViewImageColumn3, "dataGridViewImageColumn3");
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // dataGridViewImageColumn2
            // 
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn4.DataPropertyName = "install";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.dataGridViewImageColumn4, "dataGridViewImageColumn4");
            this.dataGridViewImageColumn4.Image = global::TheBetterLimited.Properties.Resources.square;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn5, "dataGridViewImageColumn5");
            this.dataGridViewImageColumn5.Image = global::TheBetterLimited.Properties.Resources.lock1;
            this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn7, "dataGridViewImageColumn7");
            this.dataGridViewImageColumn7.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.dataGridViewImageColumn7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn6, "dataGridViewImageColumn6");
            this.dataGridViewImageColumn6.Image = global::TheBetterLimited.Properties.Resources.pencil_free_icon_font;
            this.dataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            // 
            // goodsID
            // 
            this.goodsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.goodsID.DataPropertyName = "supplierGoodsStockId";
            resources.ApplyResources(this.goodsID, "goodsID");
            this.goodsID.Name = "goodsID";
            this.goodsID.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "goodsName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CreatorId
            // 
            this.CreatorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatorId.DataPropertyName = "quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CreatorId.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.CreatorId, "CreatorId");
            this.CreatorId.Name = "CreatorId";
            this.CreatorId.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Image = global::TheBetterLimited.Properties.Resources.trash24;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // RestockRequest_Add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.OrderItemBox);
            this.Controls.Add(this.OrderInfoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RestockRequest_Add";
            this.ShowIcon = false;
            this.OrderItemBox.ResumeLayout(false);
            this.Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.BottomBtn.ResumeLayout(false);
            this.OrderInfoBox.ResumeLayout(false);
            this.CreatorInfoBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CustomerInfo.ResumeLayout(false);
            this.CustomerInfoBox.ResumeLayout(false);
            this.CustomerInfoBox.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OrderItemBox;
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel OrderInfoBox;
        private System.Windows.Forms.Label GTINCode;
        private System.Windows.Forms.Label Catalogue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CustomerInfo;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private CustomizeControl.CustomizeTextbox PhoneTxt;
        private CustomizeControl.CustomizeTextbox AddressTxt;
        private System.Windows.Forms.Panel CustomerInfoBox;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CreatorInfoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Data;
        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewImageColumn isInstall;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.CustomizeTextbox customizeTextbox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomizeControl.CustomizeTextbox customizeTextbox3;
        private CustomizeControl.CustomizeTextbox NameTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatorId;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}