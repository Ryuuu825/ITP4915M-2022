namespace TheBetterLimited.Views
{
    partial class PurchaseOrder_Details
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
            this.ApproveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.ConfirmBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.RejectBtn = new TheBetterLimited.CustomizeControl.RoundButton();
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
            this.BackBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SentBtn = new TheBetterLimited.CustomizeControl.RoundButton();
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
            this.OrderItemBox.BackColor = System.Drawing.Color.White;
            this.OrderItemBox.Controls.Add(this.Data);
            this.OrderItemBox.Controls.Add(this.panel5);
            this.OrderItemBox.Controls.Add(this.BottomBtn);
            this.OrderItemBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderItemBox.Location = new System.Drawing.Point(436, 0);
            this.OrderItemBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderItemBox.Name = "OrderItemBox";
            this.OrderItemBox.Size = new System.Drawing.Size(644, 606);
            this.OrderItemBox.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.Controls.Add(this.OrderDataGrid);
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(0, 53);
            this.Data.Margin = new System.Windows.Forms.Padding(2);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Data.Size = new System.Drawing.Size(644, 499);
            this.Data.TabIndex = 11;
            // 
            // OrderDataGrid
            // 
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
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDataGrid.ColumnHeadersHeight = 50;
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
            this.OrderDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDataGrid.EnableHeadersVisualStyles = false;
            this.OrderDataGrid.GridColor = System.Drawing.Color.White;
            this.OrderDataGrid.Location = new System.Drawing.Point(0, 2);
            this.OrderDataGrid.Margin = new System.Windows.Forms.Padding(0);
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
            this.OrderDataGrid.RowHeadersWidth = 30;
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
            this.OrderDataGrid.Size = new System.Drawing.Size(644, 497);
            this.OrderDataGrid.StandardTab = true;
            this.OrderDataGrid.TabIndex = 3;
            this.OrderDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellClick);
            this.OrderDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellEndEdit);
            this.OrderDataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.OrderDataGrid_DataError);
            this.OrderDataGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.OrderDataGrid_EditingControlShowing);
            // 
            // goodsID
            // 
            this.goodsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.goodsID.DataPropertyName = "_goodsId";
            this.goodsID.HeaderText = "Goods Ref. No";
            this.goodsID.Name = "goodsID";
            this.goodsID.ReadOnly = true;
            this.goodsID.ToolTipText = "Goods Ref. No";
            this.goodsID.Width = 106;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "goodsName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID.HeaderText = "Goods Name";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ToolTipText = "Goods Name";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "price";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle4;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 75;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity.DataPropertyName = "quantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.quantity.HeaderText = "Qty";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ToolTipText = "Quantity";
            this.quantity.Width = 68;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.delete.HeaderText = "";
            this.delete.Image = global::TheBetterLimited.Properties.Resources.trash24;
            this.delete.Name = "delete";
            this.delete.Width = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.AddBtn);
            this.panel5.Controls.Add(this.Title);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 53);
            this.panel5.TabIndex = 9;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddBtn.BorderRadius = 10;
            this.AddBtn.BorderSize = 0;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.IsChecked = false;
            this.AddBtn.Location = new System.Drawing.Point(513, 7);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(119, 40);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.TextColor = System.Drawing.Color.White;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(2, 14);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(194, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Purchase Order Item";
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.SentBtn);
            this.BottomBtn.Controls.Add(this.BackBtn);
            this.BottomBtn.Controls.Add(this.ApproveBtn);
            this.BottomBtn.Controls.Add(this.ConfirmBtn);
            this.BottomBtn.Controls.Add(this.RejectBtn);
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(0, 552);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(644, 54);
            this.BottomBtn.TabIndex = 1;
            // 
            // ApproveBtn
            // 
            this.ApproveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApproveBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.ApproveBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.ApproveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ApproveBtn.BorderRadius = 10;
            this.ApproveBtn.BorderSize = 0;
            this.ApproveBtn.FlatAppearance.BorderSize = 0;
            this.ApproveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveBtn.ForeColor = System.Drawing.Color.White;
            this.ApproveBtn.IsChecked = false;
            this.ApproveBtn.Location = new System.Drawing.Point(504, 6);
            this.ApproveBtn.Name = "ApproveBtn";
            this.ApproveBtn.Size = new System.Drawing.Size(128, 40);
            this.ApproveBtn.TabIndex = 6;
            this.ApproveBtn.Text = "Approve";
            this.ApproveBtn.TextColor = System.Drawing.Color.White;
            this.ApproveBtn.UseVisualStyleBackColor = false;
            this.ApproveBtn.Visible = false;
            this.ApproveBtn.Click += new System.EventHandler(this.ApproveBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.ConfirmBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.ConfirmBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ConfirmBtn.BorderRadius = 10;
            this.ConfirmBtn.BorderSize = 0;
            this.ConfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.IsChecked = false;
            this.ConfirmBtn.Location = new System.Drawing.Point(13, 6);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(128, 40);
            this.ConfirmBtn.TabIndex = 5;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.TextColor = System.Drawing.Color.White;
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // RejectBtn
            // 
            this.RejectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RejectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.RejectBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.RejectBtn.BorderColor = System.Drawing.Color.White;
            this.RejectBtn.BorderRadius = 10;
            this.RejectBtn.BorderSize = 0;
            this.RejectBtn.FlatAppearance.BorderSize = 0;
            this.RejectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RejectBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectBtn.ForeColor = System.Drawing.Color.White;
            this.RejectBtn.IsChecked = false;
            this.RejectBtn.Location = new System.Drawing.Point(370, 6);
            this.RejectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RejectBtn.Name = "RejectBtn";
            this.RejectBtn.Size = new System.Drawing.Size(128, 40);
            this.RejectBtn.TabIndex = 4;
            this.RejectBtn.Text = "Reject";
            this.RejectBtn.TextColor = System.Drawing.Color.White;
            this.RejectBtn.UseVisualStyleBackColor = false;
            this.RejectBtn.Visible = false;
            this.RejectBtn.Click += new System.EventHandler(this.RejectBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.CancelBtn.Location = new System.Drawing.Point(369, 6);
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
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.SaveBtn.Location = new System.Drawing.Point(503, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(128, 40);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Update";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OrderInfoBox
            // 
            this.OrderInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OrderInfoBox.Controls.Add(this.AppointmentBox);
            this.OrderInfoBox.Controls.Add(this.CustomerInfo);
            this.OrderInfoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrderInfoBox.Location = new System.Drawing.Point(0, 0);
            this.OrderInfoBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderInfoBox.Name = "OrderInfoBox";
            this.OrderInfoBox.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.OrderInfoBox.Size = new System.Drawing.Size(436, 606);
            this.OrderInfoBox.TabIndex = 2;
            // 
            // AppointmentBox
            // 
            this.AppointmentBox.BackColor = System.Drawing.Color.White;
            this.AppointmentBox.Controls.Add(this.AppointmentInfoBox);
            this.AppointmentBox.Controls.Add(this.panel2);
            this.AppointmentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointmentBox.ForeColor = System.Drawing.Color.Black;
            this.AppointmentBox.Location = new System.Drawing.Point(0, 343);
            this.AppointmentBox.Name = "AppointmentBox";
            this.AppointmentBox.Size = new System.Drawing.Size(426, 263);
            this.AppointmentBox.TabIndex = 25;
            // 
            // AppointmentInfoBox
            // 
            this.AppointmentInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AppointmentInfoBox.Controls.Add(this.cbWarehouse);
            this.AppointmentInfoBox.Controls.Add(this.GTINCode);
            this.AppointmentInfoBox.Controls.Add(this.label7);
            this.AppointmentInfoBox.Controls.Add(this.txtWHAddress);
            this.AppointmentInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointmentInfoBox.Location = new System.Drawing.Point(0, 40);
            this.AppointmentInfoBox.Name = "AppointmentInfoBox";
            this.AppointmentInfoBox.Size = new System.Drawing.Size(426, 223);
            this.AppointmentInfoBox.TabIndex = 34;
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.AutoCompleteCustomSource.AddRange(new string[] {
            "Kolwoon Warehouse"});
            this.cbWarehouse.BackColor = System.Drawing.Color.White;
            this.cbWarehouse.BorderColor = System.Drawing.Color.LightGray;
            this.cbWarehouse.BorderRadius = 1;
            this.cbWarehouse.BorderSize = 1;
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWarehouse.ForeColor = System.Drawing.Color.DimGray;
            this.cbWarehouse.IconColor = System.Drawing.Color.LightGray;
            this.cbWarehouse.Items.AddRange(new object[] {
            "Kolwoon Warehouse"});
            this.cbWarehouse.ListBackColor = System.Drawing.Color.White;
            this.cbWarehouse.ListTextColor = System.Drawing.Color.DimGray;
            this.cbWarehouse.Location = new System.Drawing.Point(167, 23);
            this.cbWarehouse.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Padding = new System.Windows.Forms.Padding(1);
            this.cbWarehouse.Size = new System.Drawing.Size(233, 31);
            this.cbWarehouse.TabIndex = 33;
            this.cbWarehouse.Texts = "Warehouse";
            this.cbWarehouse.UnderlinedStyle = false;
            this.cbWarehouse.OnSelectedIndexChanged += new System.EventHandler(this.cbWarehouse_OnSelectedIndexChanged);
            this.cbWarehouse.Click += new System.EventHandler(this.cbWarehouse_Click);
            // 
            // GTINCode
            // 
            this.GTINCode.AutoSize = true;
            this.GTINCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTINCode.Location = new System.Drawing.Point(55, 110);
            this.GTINCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GTINCode.Name = "GTINCode";
            this.GTINCode.Size = new System.Drawing.Size(66, 21);
            this.GTINCode.TabIndex = 3;
            this.GTINCode.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Warehouse";
            // 
            // txtWHAddress
            // 
            this.txtWHAddress.BackColor = System.Drawing.Color.White;
            this.txtWHAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtWHAddress.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtWHAddress.BorderRadius = 10;
            this.txtWHAddress.BorderSize = 1;
            this.txtWHAddress.Enabled = false;
            this.txtWHAddress.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWHAddress.ForeColor = System.Drawing.Color.Black;
            this.txtWHAddress.IsError = false;
            this.txtWHAddress.Location = new System.Drawing.Point(167, 66);
            this.txtWHAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWHAddress.MaxLength = 120;
            this.txtWHAddress.Multiline = true;
            this.txtWHAddress.Name = "txtWHAddress";
            this.txtWHAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtWHAddress.PasswordChar = false;
            this.txtWHAddress.Placeholder = "Automatic Generation";
            this.txtWHAddress.ReadOnly = true;
            this.txtWHAddress.Size = new System.Drawing.Size(235, 109);
            this.txtWHAddress.TabIndex = 25;
            this.txtWHAddress.TbBackColor = System.Drawing.Color.White;
            this.txtWHAddress.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtWHAddress.Texts = "Automatic Generation";
            this.txtWHAddress.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 40);
            this.panel2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Warehouse Information";
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.CustomerInfo.Controls.Add(this.CustomerInfoBox);
            this.CustomerInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.CustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.CustomerInfo.Size = new System.Drawing.Size(426, 343);
            this.CustomerInfo.TabIndex = 24;
            // 
            // CustomerInfoBox
            // 
            this.CustomerInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.CustomerInfoBox.Controls.Add(this.label4);
            this.CustomerInfoBox.Controls.Add(this.txtSupAddress);
            this.CustomerInfoBox.Controls.Add(this.cbSup);
            this.CustomerInfoBox.Controls.Add(this.label3);
            this.CustomerInfoBox.Controls.Add(this.txtTel);
            this.CustomerInfoBox.Controls.Add(this.Catalogue);
            this.CustomerInfoBox.Controls.Add(this.label1);
            this.CustomerInfoBox.Controls.Add(this.txtContact);
            this.CustomerInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerInfoBox.Location = new System.Drawing.Point(0, 40);
            this.CustomerInfoBox.Name = "CustomerInfoBox";
            this.CustomerInfoBox.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.CustomerInfoBox.Size = new System.Drawing.Size(426, 293);
            this.CustomerInfoBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Address";
            // 
            // txtSupAddress
            // 
            this.txtSupAddress.BackColor = System.Drawing.Color.White;
            this.txtSupAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtSupAddress.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtSupAddress.BorderRadius = 10;
            this.txtSupAddress.BorderSize = 1;
            this.txtSupAddress.Enabled = false;
            this.txtSupAddress.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupAddress.ForeColor = System.Drawing.Color.Black;
            this.txtSupAddress.IsError = false;
            this.txtSupAddress.Location = new System.Drawing.Point(163, 157);
            this.txtSupAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSupAddress.MaxLength = 120;
            this.txtSupAddress.Multiline = true;
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupAddress.PasswordChar = false;
            this.txtSupAddress.Placeholder = "Automatic Generation";
            this.txtSupAddress.ReadOnly = true;
            this.txtSupAddress.Size = new System.Drawing.Size(235, 109);
            this.txtSupAddress.TabIndex = 36;
            this.txtSupAddress.TbBackColor = System.Drawing.Color.White;
            this.txtSupAddress.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtSupAddress.Texts = "Automatic Generation";
            this.txtSupAddress.UnderlinedStyle = false;
            // 
            // cbSup
            // 
            this.cbSup.BackColor = System.Drawing.Color.White;
            this.cbSup.BorderColor = System.Drawing.Color.LightGray;
            this.cbSup.BorderRadius = 1;
            this.cbSup.BorderSize = 1;
            this.cbSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSup.ForeColor = System.Drawing.Color.DimGray;
            this.cbSup.IconColor = System.Drawing.Color.LightGray;
            this.cbSup.ListBackColor = System.Drawing.Color.White;
            this.cbSup.ListTextColor = System.Drawing.Color.DimGray;
            this.cbSup.Location = new System.Drawing.Point(163, 15);
            this.cbSup.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbSup.Name = "cbSup";
            this.cbSup.Padding = new System.Windows.Forms.Padding(1);
            this.cbSup.Size = new System.Drawing.Size(233, 31);
            this.cbSup.TabIndex = 34;
            this.cbSup.Texts = "Supplier";
            this.cbSup.UnderlinedStyle = false;
            this.cbSup.OnSelectedIndexChanged += new System.EventHandler(this.cbSup_OnSelectedIndexChanged);
            this.cbSup.Click += new System.EventHandler(this.cbSup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Contact";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.White;
            this.txtTel.BorderColor = System.Drawing.Color.LightGray;
            this.txtTel.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtTel.BorderRadius = 10;
            this.txtTel.BorderSize = 1;
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.IsError = false;
            this.txtTel.Location = new System.Drawing.Point(163, 107);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTel.MaxLength = 32767;
            this.txtTel.Multiline = false;
            this.txtTel.Name = "txtTel";
            this.txtTel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTel.PasswordChar = false;
            this.txtTel.Placeholder = "Automatic Generation";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(235, 38);
            this.txtTel.TabIndex = 26;
            this.txtTel.TbBackColor = System.Drawing.Color.White;
            this.txtTel.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtTel.Texts = "Automatic Generation";
            this.txtTel.UnderlinedStyle = false;
            // 
            // Catalogue
            // 
            this.Catalogue.AutoSize = true;
            this.Catalogue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catalogue.Location = new System.Drawing.Point(74, 116);
            this.Catalogue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Catalogue.Name = "Catalogue";
            this.Catalogue.Size = new System.Drawing.Size(28, 21);
            this.Catalogue.TabIndex = 2;
            this.Catalogue.Text = "Tel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.BorderColor = System.Drawing.Color.LightGray;
            this.txtContact.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtContact.BorderRadius = 10;
            this.txtContact.BorderSize = 1;
            this.txtContact.Enabled = false;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.IsError = false;
            this.txtContact.Location = new System.Drawing.Point(163, 57);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Multiline = false;
            this.txtContact.Name = "txtContact";
            this.txtContact.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContact.PasswordChar = false;
            this.txtContact.Placeholder = "Automatic Generation";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(235, 38);
            this.txtContact.TabIndex = 22;
            this.txtContact.TbBackColor = System.Drawing.Color.White;
            this.txtContact.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtContact.Texts = "Automatic Generation";
            this.txtContact.UnderlinedStyle = false;
            // 
            // UserInfoHeaderContainer
            // 
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.GoodsInfoHeader);
            this.UserInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            this.UserInfoHeaderContainer.Size = new System.Drawing.Size(426, 40);
            this.UserInfoHeaderContainer.TabIndex = 20;
            // 
            // GoodsInfoHeader
            // 
            this.GoodsInfoHeader.AutoSize = true;
            this.GoodsInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.GoodsInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoodsInfoHeader.Name = "GoodsInfoHeader";
            this.GoodsInfoHeader.Size = new System.Drawing.Size(200, 25);
            this.GoodsInfoHeader.TabIndex = 6;
            this.GoodsInfoHeader.Text = "Supplier Information";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 124;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 124;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 124;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn4.DataPropertyName = "install";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::TheBetterLimited.Properties.Resources.square;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.MinimumWidth = 6;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.ToolTipText = "Need to install?";
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.Image = global::TheBetterLimited.Properties.Resources.lock1;
            this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn5.MinimumWidth = 6;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.ToolTipText = "Lock";
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn7.HeaderText = "";
            this.dataGridViewImageColumn7.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.dataGridViewImageColumn7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn7.MinimumWidth = 6;
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.ToolTipText = "Delete";
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn6.HeaderText = "";
            this.dataGridViewImageColumn6.Image = global::TheBetterLimited.Properties.Resources.pencil_free_icon_font;
            this.dataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn6.MinimumWidth = 6;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ToolTipText = "Edit";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DimGray;
            this.BackBtn.BackgroundColor = System.Drawing.Color.DimGray;
            this.BackBtn.BorderColor = System.Drawing.Color.White;
            this.BackBtn.BorderRadius = 10;
            this.BackBtn.BorderSize = 0;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.IsChecked = false;
            this.BackBtn.Location = new System.Drawing.Point(13, 6);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(128, 40);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextColor = System.Drawing.Color.White;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Visible = false;
            this.BackBtn.Click += new System.EventHandler(this.Back_Click);
            // 
            // SentBtn
            // 
            this.SentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SentBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SentBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.SentBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SentBtn.BorderRadius = 10;
            this.SentBtn.BorderSize = 0;
            this.SentBtn.FlatAppearance.BorderSize = 0;
            this.SentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentBtn.ForeColor = System.Drawing.Color.White;
            this.SentBtn.IsChecked = false;
            this.SentBtn.Location = new System.Drawing.Point(504, 6);
            this.SentBtn.Name = "SentBtn";
            this.SentBtn.Size = new System.Drawing.Size(128, 40);
            this.SentBtn.TabIndex = 8;
            this.SentBtn.Text = "Sent";
            this.SentBtn.TextColor = System.Drawing.Color.White;
            this.SentBtn.UseVisualStyleBackColor = false;
            this.SentBtn.Visible = false;
            this.SentBtn.Click += new System.EventHandler(this.SentBtn_Click);
            // 
            // PurchaseOrder_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1080, 606);
            this.Controls.Add(this.OrderItemBox);
            this.Controls.Add(this.OrderInfoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "PurchaseOrder_Details";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Details";
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
        private CustomizeControl.RoundButton RejectBtn;
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
        private CustomizeControl.RoundButton ConfirmBtn;
        private CustomizeControl.RoundButton ApproveBtn;
        private CustomizeControl.RoundButton BackBtn;
        private CustomizeControl.RoundButton SentBtn;
    }
}