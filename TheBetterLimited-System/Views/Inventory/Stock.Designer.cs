﻿namespace TheBetterLimited.Views
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StockDataGrid = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierGoodsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Action = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActionBox = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBarTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.locCombo = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.AddBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.DeleteBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.exportBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.RestockBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.inBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.outBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.Header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Panel();
            this.loadPic = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGrid)).BeginInit();
            this.Action.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ActionBox.SuspendLayout();
            this.SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            this.Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // StockDataGrid
            // 
            resources.ApplyResources(this.StockDataGrid, "StockDataGrid");
            this.StockDataGrid.AllowUserToAddRows = false;
            this.StockDataGrid.AllowUserToResizeColumns = false;
            this.StockDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.StockDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StockDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.StockDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StockDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.StockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StockDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.id,
            this.locationId,
            this.supplierGoodsId,
            this.quantity,
            this.maxLimit,
            this.minLimit,
            this.ReorderLevel,
            this.Status,
            this.edit,
            this.delete});
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDataGrid.DefaultCellStyle = dataGridViewCellStyle34;
            this.StockDataGrid.EnableHeadersVisualStyles = false;
            this.StockDataGrid.GridColor = System.Drawing.Color.White;
            this.StockDataGrid.MultiSelect = false;
            this.StockDataGrid.Name = "StockDataGrid";
            this.StockDataGrid.ReadOnly = true;
            this.StockDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.StockDataGrid.RowHeadersVisible = false;
            this.StockDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle36.NullValue = null;
            dataGridViewCellStyle36.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            this.StockDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.StockDataGrid.RowTemplate.Height = 40;
            this.StockDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockDataGrid.StandardTab = true;
            this.StockDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDataGrid_CellClick);
            this.StockDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StockDataGrid_CellFormatting);
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.select, "select");
            this.select.Image = ((System.Drawing.Image)(resources.GetObject("select.Image")));
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "Id";
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // locationId
            // 
            this.locationId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.locationId.DataPropertyName = "loc";
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.locationId.DefaultCellStyle = dataGridViewCellStyle27;
            resources.ApplyResources(this.locationId, "locationId");
            this.locationId.Name = "locationId";
            this.locationId.ReadOnly = true;
            // 
            // supplierGoodsId
            // 
            this.supplierGoodsId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierGoodsId.DataPropertyName = "goodsName";
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierGoodsId.DefaultCellStyle = dataGridViewCellStyle28;
            resources.ApplyResources(this.supplierGoodsId, "supplierGoodsId");
            this.supplierGoodsId.Name = "supplierGoodsId";
            this.supplierGoodsId.ReadOnly = true;
            this.supplierGoodsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle29;
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // maxLimit
            // 
            this.maxLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maxLimit.DataPropertyName = "MaxLimit";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.maxLimit.DefaultCellStyle = dataGridViewCellStyle30;
            resources.ApplyResources(this.maxLimit, "maxLimit");
            this.maxLimit.Name = "maxLimit";
            this.maxLimit.ReadOnly = true;
            // 
            // minLimit
            // 
            this.minLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.minLimit.DataPropertyName = "MinLimit";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.minLimit.DefaultCellStyle = dataGridViewCellStyle31;
            resources.ApplyResources(this.minLimit, "minLimit");
            this.minLimit.Name = "minLimit";
            this.minLimit.ReadOnly = true;
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReorderLevel.DataPropertyName = "ReorderLevel";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ReorderLevel.DefaultCellStyle = dataGridViewCellStyle32;
            resources.ApplyResources(this.ReorderLevel, "ReorderLevel");
            this.ReorderLevel.Name = "ReorderLevel";
            this.ReorderLevel.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Status.DefaultCellStyle = dataGridViewCellStyle33;
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.edit, "edit");
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Action
            // 
            resources.ApplyResources(this.Action, "Action");
            this.Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Action.Controls.Add(this.panel1);
            this.Action.Name = "Action";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.ActionBox);
            this.panel1.Name = "panel1";
            // 
            // ActionBox
            // 
            resources.ApplyResources(this.ActionBox, "ActionBox");
            this.ActionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ActionBox.Controls.Add(this.SearchBar);
            this.ActionBox.Controls.Add(this.locCombo);
            this.ActionBox.Controls.Add(this.AddBtn);
            this.ActionBox.Controls.Add(this.DeleteBtn);
            this.ActionBox.Controls.Add(this.exportBtn);
            this.ActionBox.Controls.Add(this.RestockBtn);
            this.ActionBox.Controls.Add(this.inBtn);
            this.ActionBox.Controls.Add(this.outBtn);
            this.ActionBox.Name = "ActionBox";
            // 
            // SearchBar
            // 
            resources.ApplyResources(this.SearchBar, "SearchBar");
            this.SearchBar.Controls.Add(this.pictureBox1);
            this.SearchBar.Controls.Add(this.SearchBarTxt);
            this.SearchBar.Name = "SearchBar";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SearchBarTxt
            // 
            resources.ApplyResources(this.SearchBarTxt, "SearchBarTxt");
            this.SearchBarTxt.BackColor = System.Drawing.Color.White;
            this.SearchBarTxt.BorderColor = System.Drawing.Color.LightGray;
            this.SearchBarTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.SearchBarTxt.BorderRadius = 10;
            this.SearchBarTxt.BorderSize = 1;
            this.SearchBarTxt.ForeColor = System.Drawing.Color.LightGray;
            this.SearchBarTxt.IsError = false;
            this.SearchBarTxt.MaxLength = 20;
            this.SearchBarTxt.Multiline = false;
            this.SearchBarTxt.Name = "SearchBarTxt";
            this.SearchBarTxt.PasswordChar = false;
            this.SearchBarTxt.Placeholder = "Search";
            this.SearchBarTxt.ReadOnly = false;
            this.SearchBarTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.SearchBarTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.SearchBarTxt.Texts = "Search";
            this.SearchBarTxt.UnderlinedStyle = false;
            // 
            // locCombo
            // 
            resources.ApplyResources(this.locCombo, "locCombo");
            this.locCombo.BackColor = System.Drawing.Color.White;
            this.locCombo.BorderColor = System.Drawing.Color.LightGray;
            this.locCombo.BorderRadius = 1;
            this.locCombo.BorderSize = 1;
            this.locCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locCombo.ForeColor = System.Drawing.Color.DimGray;
            this.locCombo.IconColor = System.Drawing.Color.LightGray;
            this.locCombo.Items.AddRange(new object[] {
            resources.GetString("locCombo.Items"),
            resources.GetString("locCombo.Items1"),
            resources.GetString("locCombo.Items2"),
            resources.GetString("locCombo.Items3")});
            this.locCombo.ListBackColor = System.Drawing.Color.White;
            this.locCombo.ListTextColor = System.Drawing.Color.DimGray;
            this.locCombo.Name = "locCombo";
            this.locCombo.Texts = "";
            this.locCombo.UnderlinedStyle = false;
            this.locCombo.OnSelectedIndexChanged += new System.EventHandler(this.loc_OnSelectedIndexChanged);
            // 
            // AddBtn
            // 
            resources.ApplyResources(this.AddBtn, "AddBtn");
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.AddBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.AddBtn.BorderColor = System.Drawing.Color.White;
            this.AddBtn.BorderRadius = 10;
            this.AddBtn.BorderSize = 0;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = global::TheBetterLimited.Properties.Resources.add;
            this.AddBtn.IsChecked = false;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.TextColor = System.Drawing.Color.White;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // exportBtn
            // 
            resources.ApplyResources(this.exportBtn, "exportBtn");
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.exportBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.exportBtn.BorderColor = System.Drawing.Color.White;
            this.exportBtn.BorderRadius = 10;
            this.exportBtn.BorderSize = 0;
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.IsChecked = false;
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.TextColor = System.Drawing.Color.White;
            this.exportBtn.UseVisualStyleBackColor = false;
            // 
            // RestockBtn
            // 
            resources.ApplyResources(this.RestockBtn, "RestockBtn");
            this.RestockBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.RestockBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.RestockBtn.BorderColor = System.Drawing.Color.White;
            this.RestockBtn.BorderRadius = 10;
            this.RestockBtn.BorderSize = 0;
            this.RestockBtn.FlatAppearance.BorderSize = 0;
            this.RestockBtn.ForeColor = System.Drawing.Color.White;
            this.RestockBtn.IsChecked = false;
            this.RestockBtn.Name = "RestockBtn";
            this.RestockBtn.TextColor = System.Drawing.Color.White;
            this.RestockBtn.UseVisualStyleBackColor = false;
            this.RestockBtn.Click += new System.EventHandler(this.RestockBtn_Click);
            // 
            // inBtn
            // 
            resources.ApplyResources(this.inBtn, "inBtn");
            this.inBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.inBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.inBtn.BorderColor = System.Drawing.Color.White;
            this.inBtn.BorderRadius = 10;
            this.inBtn.BorderSize = 0;
            this.inBtn.FlatAppearance.BorderSize = 0;
            this.inBtn.ForeColor = System.Drawing.Color.White;
            this.inBtn.IsChecked = false;
            this.inBtn.Name = "inBtn";
            this.inBtn.TextColor = System.Drawing.Color.White;
            this.inBtn.UseVisualStyleBackColor = false;
            this.inBtn.Click += new System.EventHandler(this.inBtn_Click);
            // 
            // outBtn
            // 
            resources.ApplyResources(this.outBtn, "outBtn");
            this.outBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.outBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.outBtn.BorderColor = System.Drawing.Color.White;
            this.outBtn.BorderRadius = 10;
            this.outBtn.BorderSize = 0;
            this.outBtn.FlatAppearance.BorderSize = 0;
            this.outBtn.ForeColor = System.Drawing.Color.White;
            this.outBtn.IsChecked = false;
            this.outBtn.Name = "outBtn";
            this.outBtn.TextColor = System.Drawing.Color.White;
            this.outBtn.UseVisualStyleBackColor = false;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // Header
            // 
            resources.ApplyResources(this.Header, "Header");
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.button1);
            this.Header.Controls.Add(this.button2);
            this.Header.Controls.Add(this.Title);
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Name = "Header";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = global::TheBetterLimited.Properties.Resources.close32;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackgroundImage = global::TheBetterLimited.Properties.Resources.rotate_right;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Name = "Title";
            // 
            // Data
            // 
            resources.ApplyResources(this.Data, "Data");
            this.Data.Controls.Add(this.StockDataGrid);
            this.Data.Controls.Add(this.loadPic);
            this.Data.Name = "Data";
            // 
            // loadPic
            // 
            resources.ApplyResources(this.loadPic, "loadPic");
            this.loadPic.BackColor = System.Drawing.Color.White;
            this.loadPic.Name = "loadPic";
            // 
            // dataGridViewImageColumn1
            // 
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            resources.ApplyResources(this.dataGridViewImageColumn3, "dataGridViewImageColumn3");
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn4, "dataGridViewImageColumn4");
            this.dataGridViewImageColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn4.Image")));
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.dataGridViewImageColumn5, "dataGridViewImageColumn5");
            this.dataGridViewImageColumn5.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn5.Image")));
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn6, "dataGridViewImageColumn6");
            this.dataGridViewImageColumn6.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn6.Image")));
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ReadOnly = true;
            this.dataGridViewImageColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Stock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGrid)).EndInit();
            this.Action.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ActionBox.ResumeLayout(false);
            this.SearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView StockDataGrid;
        private CustomizeControl.RoundButton DeleteBtn;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Action;
        private System.Windows.Forms.Panel Data;
        private CustomizeControl.RoundButton AddBtn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SearchBar;
        private CustomizeControl.CustomizeTextbox SearchBarTxt;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton exportBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private CustomizeControl.RoundButton RestockBtn;
        private System.Windows.Forms.Panel loadPic;
        private CustomizeControl.RoundButton inBtn;
        private CustomizeControl.RoundButton outBtn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewImageColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierGoodsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn minLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.FlowLayoutPanel ActionBox;
        private CustomizeControl.CustomizeComboBox locCombo;
    }
}