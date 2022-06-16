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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderItemBox = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.Panel();
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.goodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.NameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
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
            this.OrderItemBox.BackColor = System.Drawing.Color.White;
            this.OrderItemBox.Controls.Add(this.Data);
            this.OrderItemBox.Controls.Add(this.panel5);
            this.OrderItemBox.Controls.Add(this.BottomBtn);
            this.OrderItemBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderItemBox.Location = new System.Drawing.Point(436, 0);
            this.OrderItemBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderItemBox.Name = "OrderItemBox";
            this.OrderItemBox.Size = new System.Drawing.Size(550, 533);
            this.OrderItemBox.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.Controls.Add(this.OrderDataGrid);
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(0, 40);
            this.Data.Margin = new System.Windows.Forms.Padding(2);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Data.Size = new System.Drawing.Size(550, 439);
            this.Data.TabIndex = 11;
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.AllowUserToAddRows = false;
            this.OrderDataGrid.AllowUserToOrderColumns = true;
            this.OrderDataGrid.AllowUserToResizeColumns = false;
            this.OrderDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.OrderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.OrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OrderDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.OrderDataGrid.ColumnHeadersHeight = 50;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsID,
            this.ID,
            this.CreatorId,
            this.delete});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.DefaultCellStyle = dataGridViewCellStyle13;
            this.OrderDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDataGrid.EnableHeadersVisualStyles = false;
            this.OrderDataGrid.GridColor = System.Drawing.Color.White;
            this.OrderDataGrid.Location = new System.Drawing.Point(0, 2);
            this.OrderDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.OrderDataGrid.MultiSelect = false;
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.ReadOnly = true;
            this.OrderDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.OrderDataGrid.RowHeadersVisible = false;
            this.OrderDataGrid.RowHeadersWidth = 30;
            this.OrderDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.NullValue = null;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.OrderDataGrid.RowTemplate.Height = 30;
            this.OrderDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGrid.Size = new System.Drawing.Size(550, 437);
            this.OrderDataGrid.StandardTab = true;
            this.OrderDataGrid.TabIndex = 3;
            this.OrderDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellClick);
            // 
            // goodsID
            // 
            this.goodsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.goodsID.DataPropertyName = "supplierGoodsStockId";
            this.goodsID.HeaderText = "GTIN Code";
            this.goodsID.Name = "goodsID";
            this.goodsID.ReadOnly = true;
            this.goodsID.ToolTipText = "Goods GTIN Code";
            this.goodsID.Width = 111;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "goodsName";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.DefaultCellStyle = dataGridViewCellStyle11;
            this.ID.HeaderText = "Goods Name";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ToolTipText = "Goods Name";
            // 
            // CreatorId
            // 
            this.CreatorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatorId.DataPropertyName = "quantity";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CreatorId.DefaultCellStyle = dataGridViewCellStyle12;
            this.CreatorId.HeaderText = "Qty";
            this.CreatorId.MinimumWidth = 6;
            this.CreatorId.Name = "CreatorId";
            this.CreatorId.ReadOnly = true;
            this.CreatorId.ToolTipText = "Quantity";
            this.CreatorId.Width = 68;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.delete.HeaderText = "";
            this.delete.Image = global::TheBetterLimited.Properties.Resources.trash24;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.ToolTipText = "Delete";
            this.delete.Width = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Title);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(550, 40);
            this.panel5.TabIndex = 9;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(2, 7);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(126, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Restock Item";
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(0, 479);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(550, 54);
            this.BottomBtn.TabIndex = 1;
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
            this.CancelBtn.Location = new System.Drawing.Point(275, 6);
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
            this.SaveBtn.Location = new System.Drawing.Point(409, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(128, 40);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Comfirm";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OrderInfoBox
            // 
            this.OrderInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OrderInfoBox.Controls.Add(this.CreatorInfoBox);
            this.OrderInfoBox.Controls.Add(this.CustomerInfo);
            this.OrderInfoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrderInfoBox.Location = new System.Drawing.Point(0, 0);
            this.OrderInfoBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderInfoBox.Name = "OrderInfoBox";
            this.OrderInfoBox.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.OrderInfoBox.Size = new System.Drawing.Size(436, 533);
            this.OrderInfoBox.TabIndex = 2;
            // 
            // CreatorInfoBox
            // 
            this.CreatorInfoBox.BackColor = System.Drawing.Color.White;
            this.CreatorInfoBox.Controls.Add(this.panel1);
            this.CreatorInfoBox.Controls.Add(this.panel2);
            this.CreatorInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatorInfoBox.ForeColor = System.Drawing.Color.Black;
            this.CreatorInfoBox.Location = new System.Drawing.Point(0, 343);
            this.CreatorInfoBox.Name = "CreatorInfoBox";
            this.CreatorInfoBox.Size = new System.Drawing.Size(426, 190);
            this.CreatorInfoBox.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.customizeTextbox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customizeTextbox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(426, 150);
            this.panel1.TabIndex = 35;
            // 
            // customizeTextbox1
            // 
            this.customizeTextbox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.customizeTextbox1.BackColor = System.Drawing.Color.White;
            this.customizeTextbox1.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox1.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox1.BorderRadius = 10;
            this.customizeTextbox1.BorderSize = 1;
            this.customizeTextbox1.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox1.ForeColor = System.Drawing.Color.Black;
            this.customizeTextbox1.IsError = false;
            this.customizeTextbox1.Location = new System.Drawing.Point(164, 31);
            this.customizeTextbox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox1.MaxLength = 5;
            this.customizeTextbox1.Multiline = false;
            this.customizeTextbox1.Name = "customizeTextbox1";
            this.customizeTextbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox1.PasswordChar = false;
            this.customizeTextbox1.Placeholder = "Please enter customer name";
            this.customizeTextbox1.ReadOnly = false;
            this.customizeTextbox1.Size = new System.Drawing.Size(234, 38);
            this.customizeTextbox1.TabIndex = 24;
            this.customizeTextbox1.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox1.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.customizeTextbox1.Texts = "Please enter customer name";
            this.customizeTextbox1.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Staff ID";
            // 
            // customizeTextbox3
            // 
            this.customizeTextbox3.BackColor = System.Drawing.Color.White;
            this.customizeTextbox3.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox3.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox3.BorderRadius = 10;
            this.customizeTextbox3.BorderSize = 1;
            this.customizeTextbox3.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox3.ForeColor = System.Drawing.Color.Black;
            this.customizeTextbox3.IsError = false;
            this.customizeTextbox3.Location = new System.Drawing.Point(163, 78);
            this.customizeTextbox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox3.MaxLength = 32767;
            this.customizeTextbox3.Multiline = false;
            this.customizeTextbox3.Name = "customizeTextbox3";
            this.customizeTextbox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox3.PasswordChar = false;
            this.customizeTextbox3.Placeholder = "Please enter customer phone";
            this.customizeTextbox3.ReadOnly = false;
            this.customizeTextbox3.Size = new System.Drawing.Size(235, 38);
            this.customizeTextbox3.TabIndex = 22;
            this.customizeTextbox3.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox3.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.customizeTextbox3.Texts = "Please enter customer phone";
            this.customizeTextbox3.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Enabled = false;
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
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Creator Information";
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
            this.CustomerInfoBox.Controls.Add(this.NameTxt);
            this.CustomerInfoBox.Controls.Add(this.GTINCode);
            this.CustomerInfoBox.Controls.Add(this.Catalogue);
            this.CustomerInfoBox.Controls.Add(this.label1);
            this.CustomerInfoBox.Controls.Add(this.AddressTxt);
            this.CustomerInfoBox.Controls.Add(this.PhoneTxt);
            this.CustomerInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerInfoBox.Location = new System.Drawing.Point(0, 40);
            this.CustomerInfoBox.Name = "CustomerInfoBox";
            this.CustomerInfoBox.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.CustomerInfoBox.Size = new System.Drawing.Size(426, 293);
            this.CustomerInfoBox.TabIndex = 27;
            // 
            // GTINCode
            // 
            this.GTINCode.AutoSize = true;
            this.GTINCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTINCode.Location = new System.Drawing.Point(54, 105);
            this.GTINCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GTINCode.Name = "GTINCode";
            this.GTINCode.Size = new System.Drawing.Size(66, 21);
            this.GTINCode.TabIndex = 3;
            this.GTINCode.Text = "Address";
            // 
            // Catalogue
            // 
            this.Catalogue.AutoSize = true;
            this.Catalogue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catalogue.Location = new System.Drawing.Point(61, 67);
            this.Catalogue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Catalogue.Name = "Catalogue";
            this.Catalogue.Size = new System.Drawing.Size(52, 21);
            this.Catalogue.TabIndex = 2;
            this.Catalogue.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department";
            // 
            // AddressTxt
            // 
            this.AddressTxt.BackColor = System.Drawing.Color.White;
            this.AddressTxt.BorderColor = System.Drawing.Color.LightGray;
            this.AddressTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.AddressTxt.BorderRadius = 10;
            this.AddressTxt.BorderSize = 1;
            this.AddressTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxt.ForeColor = System.Drawing.Color.Black;
            this.AddressTxt.IsError = false;
            this.AddressTxt.Location = new System.Drawing.Point(163, 105);
            this.AddressTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddressTxt.MaxLength = 120;
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.AddressTxt.PasswordChar = false;
            this.AddressTxt.Placeholder = "Please enter customer address";
            this.AddressTxt.ReadOnly = false;
            this.AddressTxt.Size = new System.Drawing.Size(235, 172);
            this.AddressTxt.TabIndex = 25;
            this.AddressTxt.TbBackColor = System.Drawing.Color.White;
            this.AddressTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.AddressTxt.Texts = "Please enter customer address";
            this.AddressTxt.UnderlinedStyle = false;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.BackColor = System.Drawing.Color.White;
            this.PhoneTxt.BorderColor = System.Drawing.Color.LightGray;
            this.PhoneTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.PhoneTxt.BorderRadius = 10;
            this.PhoneTxt.BorderSize = 1;
            this.PhoneTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxt.ForeColor = System.Drawing.Color.Black;
            this.PhoneTxt.IsError = false;
            this.PhoneTxt.Location = new System.Drawing.Point(163, 58);
            this.PhoneTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PhoneTxt.MaxLength = 32767;
            this.PhoneTxt.Multiline = false;
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PhoneTxt.PasswordChar = false;
            this.PhoneTxt.Placeholder = "Please enter customer phone";
            this.PhoneTxt.ReadOnly = false;
            this.PhoneTxt.Size = new System.Drawing.Size(235, 38);
            this.PhoneTxt.TabIndex = 22;
            this.PhoneTxt.TbBackColor = System.Drawing.Color.White;
            this.PhoneTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.PhoneTxt.Texts = "Please enter customer phone";
            this.PhoneTxt.UnderlinedStyle = false;
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
            this.GoodsInfoHeader.Size = new System.Drawing.Size(309, 25);
            this.GoodsInfoHeader.TabIndex = 6;
            this.GoodsInfoHeader.Text = "Request Department Information";
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.DefaultCellStyle = dataGridViewCellStyle16;
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
            // NameTxt
            // 
            this.NameTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.NameTxt.BackColor = System.Drawing.Color.White;
            this.NameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.NameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.NameTxt.BorderRadius = 10;
            this.NameTxt.BorderSize = 1;
            this.NameTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.ForeColor = System.Drawing.Color.Black;
            this.NameTxt.IsError = false;
            this.NameTxt.Location = new System.Drawing.Point(164, 11);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NameTxt.MaxLength = 5;
            this.NameTxt.Multiline = false;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NameTxt.PasswordChar = false;
            this.NameTxt.Placeholder = "";
            this.NameTxt.ReadOnly = false;
            this.NameTxt.Size = new System.Drawing.Size(234, 38);
            this.NameTxt.TabIndex = 24;
            this.NameTxt.TbBackColor = System.Drawing.Color.White;
            this.NameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.NameTxt.Texts = "";
            this.NameTxt.UnderlinedStyle = false;
            // 
            // RestockRequest_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(986, 533);
            this.Controls.Add(this.OrderItemBox);
            this.Controls.Add(this.OrderInfoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "RestockRequest_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restock Request";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatorId;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.CustomizeTextbox customizeTextbox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomizeControl.CustomizeTextbox customizeTextbox3;
        private CustomizeControl.CustomizeTextbox NameTxt;
    }
}