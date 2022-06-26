namespace TheBetterLimited.Views
{
    partial class PurchaseOrder_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrder_Create));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderItemBox = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.Panel();
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.goodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AddBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.Title = new System.Windows.Forms.Label();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.DeleteBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.OrderInfoBox = new System.Windows.Forms.Panel();
            this.AppointmentBox = new System.Windows.Forms.Panel();
            this.AppointmentInfoBox = new System.Windows.Forms.Panel();
            this.cbWarehouse = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.GTINCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWHAddress = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerInfo = new System.Windows.Forms.Panel();
            this.CustomerInfoBox = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupAddress = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.cbSup = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.Catalogue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.OrderItemBox.SuspendLayout();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            this.panel5.SuspendLayout();
            this.BottomBtn.SuspendLayout();
            this.OrderInfoBox.SuspendLayout();
            this.AppointmentBox.SuspendLayout();
            this.AppointmentInfoBox.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Price,
            this.quantity,
            this.delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.OrderDataGrid.EnableHeadersVisualStyles = false;
            this.OrderDataGrid.GridColor = System.Drawing.Color.White;
            this.OrderDataGrid.MultiSelect = false;
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.OrderDataGrid.RowHeadersVisible = false;
            this.OrderDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.OrderDataGrid.RowTemplate.Height = 30;
            this.OrderDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGrid.StandardTab = true;
            this.OrderDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellClick);
            this.OrderDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellEndEdit);
            this.OrderDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.OrderDataGrid_CellFormatting);
            this.OrderDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.OrderDataGrid_DataError);
            this.OrderDataGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.OrderDataGrid_EditingControlShowing);
            // 
            // goodsID
            // 
            this.goodsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.goodsID.DataPropertyName = "_goodsId";
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
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "price";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.Price, "Price");
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity.DataPropertyName = "quantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Image = global::TheBetterLimited.Properties.Resources.trash24;
            this.delete.Name = "delete";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.AddBtn);
            this.panel5.Controls.Add(this.Title);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Name = "panel5";
            // 
            // AddBtn
            // 
            resources.ApplyResources(this.AddBtn, "AddBtn");
            this.AddBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddBtn.BorderRadius = 10;
            this.AddBtn.BorderSize = 0;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.IsChecked = false;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.TextColor = System.Drawing.Color.White;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.BottomBtn.Controls.Add(this.DeleteBtn);
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Name = "BottomBtn";
            // 
            // DeleteBtn
            // 
            resources.ApplyResources(this.DeleteBtn, "DeleteBtn");
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DeleteBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DeleteBtn.BorderColor = System.Drawing.Color.White;
            this.DeleteBtn.BorderRadius = 10;
            this.DeleteBtn.BorderSize = 0;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.IsChecked = false;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.TextColor = System.Drawing.Color.White;
            this.DeleteBtn.UseVisualStyleBackColor = false;
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
            this.OrderInfoBox.Controls.Add(this.AppointmentBox);
            this.OrderInfoBox.Controls.Add(this.CustomerInfo);
            this.OrderInfoBox.Name = "OrderInfoBox";
            // 
            // AppointmentBox
            // 
            resources.ApplyResources(this.AppointmentBox, "AppointmentBox");
            this.AppointmentBox.BackColor = System.Drawing.Color.White;
            this.AppointmentBox.Controls.Add(this.AppointmentInfoBox);
            this.AppointmentBox.Controls.Add(this.panel2);
            this.AppointmentBox.ForeColor = System.Drawing.Color.Black;
            this.AppointmentBox.Name = "AppointmentBox";
            // 
            // AppointmentInfoBox
            // 
            resources.ApplyResources(this.AppointmentInfoBox, "AppointmentInfoBox");
            this.AppointmentInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AppointmentInfoBox.Controls.Add(this.cbWarehouse);
            this.AppointmentInfoBox.Controls.Add(this.GTINCode);
            this.AppointmentInfoBox.Controls.Add(this.label7);
            this.AppointmentInfoBox.Controls.Add(this.txtWHAddress);
            this.AppointmentInfoBox.Name = "AppointmentInfoBox";
            // 
            // cbWarehouse
            // 
            resources.ApplyResources(this.cbWarehouse, "cbWarehouse");
            this.cbWarehouse.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("cbWarehouse.AutoCompleteCustomSource")});
            this.cbWarehouse.BackColor = System.Drawing.Color.White;
            this.cbWarehouse.BorderColor = System.Drawing.Color.LightGray;
            this.cbWarehouse.BorderRadius = 1;
            this.cbWarehouse.BorderSize = 1;
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.ForeColor = System.Drawing.Color.DimGray;
            this.cbWarehouse.IconColor = System.Drawing.Color.LightGray;
            this.cbWarehouse.Items.AddRange(new object[] {
            resources.GetString("cbWarehouse.Items")});
            this.cbWarehouse.ListBackColor = System.Drawing.Color.White;
            this.cbWarehouse.ListTextColor = System.Drawing.Color.DimGray;
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Texts = "Warehouse";
            this.cbWarehouse.UnderlinedStyle = false;
            this.cbWarehouse.OnSelectedIndexChanged += new System.EventHandler(this.cbWarehouse_OnSelectedIndexChanged);
            this.cbWarehouse.Click += new System.EventHandler(this.cbWarehouse_Click);
            // 
            // GTINCode
            // 
            resources.ApplyResources(this.GTINCode, "GTINCode");
            this.GTINCode.Name = "GTINCode";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtWHAddress
            // 
            resources.ApplyResources(this.txtWHAddress, "txtWHAddress");
            this.txtWHAddress.BackColor = System.Drawing.Color.White;
            this.txtWHAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtWHAddress.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtWHAddress.BorderRadius = 10;
            this.txtWHAddress.BorderSize = 1;
            this.txtWHAddress.ForeColor = System.Drawing.Color.Black;
            this.txtWHAddress.IsError = false;
            this.txtWHAddress.MaxLength = 120;
            this.txtWHAddress.Multiline = true;
            this.txtWHAddress.Name = "txtWHAddress";
            this.txtWHAddress.PasswordChar = false;
            this.txtWHAddress.Placeholder = "Automatic Generation";
            this.txtWHAddress.ReadOnly = true;
            this.txtWHAddress.TbBackColor = System.Drawing.Color.White;
            this.txtWHAddress.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtWHAddress.Texts = "Automatic Generation";
            this.txtWHAddress.UnderlinedStyle = false;
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
            this.CustomerInfoBox.Controls.Add(this.label4);
            this.CustomerInfoBox.Controls.Add(this.txtSupAddress);
            this.CustomerInfoBox.Controls.Add(this.cbSup);
            this.CustomerInfoBox.Controls.Add(this.label3);
            this.CustomerInfoBox.Controls.Add(this.txtTel);
            this.CustomerInfoBox.Controls.Add(this.Catalogue);
            this.CustomerInfoBox.Controls.Add(this.label1);
            this.CustomerInfoBox.Controls.Add(this.txtContact);
            this.CustomerInfoBox.Name = "CustomerInfoBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            this.txtSupAddress.MaxLength = 120;
            this.txtSupAddress.Multiline = true;
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.PasswordChar = false;
            this.txtSupAddress.Placeholder = "Automatic Generation";
            this.txtSupAddress.ReadOnly = true;
            this.txtSupAddress.TbBackColor = System.Drawing.Color.White;
            this.txtSupAddress.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtSupAddress.Texts = "Automatic Generation";
            this.txtSupAddress.UnderlinedStyle = false;
            // 
            // cbSup
            // 
            resources.ApplyResources(this.cbSup, "cbSup");
            this.cbSup.BackColor = System.Drawing.Color.White;
            this.cbSup.BorderColor = System.Drawing.Color.LightGray;
            this.cbSup.BorderRadius = 1;
            this.cbSup.BorderSize = 1;
            this.cbSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSup.ForeColor = System.Drawing.Color.DimGray;
            this.cbSup.IconColor = System.Drawing.Color.LightGray;
            this.cbSup.ListBackColor = System.Drawing.Color.White;
            this.cbSup.ListTextColor = System.Drawing.Color.DimGray;
            this.cbSup.Name = "cbSup";
            this.cbSup.Texts = "Supplier";
            this.cbSup.UnderlinedStyle = false;
            this.cbSup.OnSelectedIndexChanged += new System.EventHandler(this.cbSup_OnSelectedIndexChanged);
            this.cbSup.Click += new System.EventHandler(this.cbSup_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtTel
            // 
            resources.ApplyResources(this.txtTel, "txtTel");
            this.txtTel.BackColor = System.Drawing.Color.White;
            this.txtTel.BorderColor = System.Drawing.Color.LightGray;
            this.txtTel.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtTel.BorderRadius = 10;
            this.txtTel.BorderSize = 1;
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.IsError = false;
            this.txtTel.MaxLength = 32767;
            this.txtTel.Multiline = false;
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = false;
            this.txtTel.Placeholder = "Automatic Generation";
            this.txtTel.ReadOnly = true;
            this.txtTel.TbBackColor = System.Drawing.Color.White;
            this.txtTel.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtTel.Texts = "Automatic Generation";
            this.txtTel.UnderlinedStyle = false;
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
            // txtContact
            // 
            resources.ApplyResources(this.txtContact, "txtContact");
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.BorderColor = System.Drawing.Color.LightGray;
            this.txtContact.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtContact.BorderRadius = 10;
            this.txtContact.BorderSize = 1;
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.IsError = false;
            this.txtContact.MaxLength = 32767;
            this.txtContact.Multiline = false;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = false;
            this.txtContact.Placeholder = "Automatic Generation";
            this.txtContact.ReadOnly = true;
            this.txtContact.TbBackColor = System.Drawing.Color.White;
            this.txtContact.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtContact.Texts = "Automatic Generation";
            this.txtContact.UnderlinedStyle = false;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.dataGridViewImageColumn4, "dataGridViewImageColumn4");
            this.dataGridViewImageColumn4.Image = global::TheBetterLimited.Properties.Resources.square;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.DefaultCellStyle = dataGridViewCellStyle10;
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
            // PurchaseOrder_Create
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.OrderItemBox);
            this.Controls.Add(this.OrderInfoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PurchaseOrder_Create";
            this.ShowIcon = false;
            this.OrderItemBox.ResumeLayout(false);
            this.Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.BottomBtn.ResumeLayout(false);
            this.OrderInfoBox.ResumeLayout(false);
            this.AppointmentBox.ResumeLayout(false);
            this.AppointmentInfoBox.ResumeLayout(false);
            this.AppointmentInfoBox.PerformLayout();
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
        private CustomizeControl.CustomizeTextbox txtContact;
        private CustomizeControl.CustomizeTextbox txtWHAddress;
        private System.Windows.Forms.Panel CustomerInfoBox;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel AppointmentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AppointmentInfoBox;
        private System.Windows.Forms.Panel Data;
        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private CustomizeControl.CustomizeComboBox cbWarehouse;
        private System.Windows.Forms.DataGridViewImageColumn isInstall;
        private CustomizeControl.RoundButton DeleteBtn;
        private CustomizeControl.RoundButton AddBtn;
        private System.Windows.Forms.Label label3;
        private CustomizeControl.CustomizeTextbox txtTel;
        private CustomizeControl.CustomizeComboBox cbSup;
        private System.Windows.Forms.Label label4;
        private CustomizeControl.CustomizeTextbox txtSupAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}