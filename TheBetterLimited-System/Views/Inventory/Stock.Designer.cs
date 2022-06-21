namespace TheBetterLimited.Views
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.curdAction = new System.Windows.Forms.Panel();
            this.outBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.inBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RestockBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.margin1 = new System.Windows.Forms.Panel();
            this.exportBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBarTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.Header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Panel();
            this.loadPic = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGrid)).BeginInit();
            this.Action.SuspendLayout();
            this.panel1.SuspendLayout();
            this.curdAction.SuspendLayout();
            this.SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            this.Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // StockDataGrid
            // 
            this.StockDataGrid.AllowUserToAddRows = false;
            this.StockDataGrid.AllowUserToResizeColumns = false;
            this.StockDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.StockDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StockDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StockDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.StockDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StockDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockDataGrid.ColumnHeadersHeight = 50;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.StockDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockDataGrid.EnableHeadersVisualStyles = false;
            this.StockDataGrid.GridColor = System.Drawing.Color.White;
            this.StockDataGrid.Location = new System.Drawing.Point(0, 10);
            this.StockDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.StockDataGrid.MultiSelect = false;
            this.StockDataGrid.Name = "StockDataGrid";
            this.StockDataGrid.ReadOnly = true;
            this.StockDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StockDataGrid.RowHeadersVisible = false;
            this.StockDataGrid.RowHeadersWidth = 30;
            this.StockDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.StockDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.StockDataGrid.RowTemplate.Height = 40;
            this.StockDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockDataGrid.Size = new System.Drawing.Size(544, 395);
            this.StockDataGrid.StandardTab = true;
            this.StockDataGrid.TabIndex = 3;
            this.StockDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDataGrid_CellClick);
            this.StockDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StockDataGrid_CellFormatting);
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.select.HeaderText = "";
            this.select.Image = ((System.Drawing.Image)(resources.GetObject("select.Image")));
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.select.Width = 5;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "ID";
            this.id.Width = 59;
            // 
            // locationId
            // 
            this.locationId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.locationId.DataPropertyName = "loc";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.locationId.DefaultCellStyle = dataGridViewCellStyle3;
            this.locationId.HeaderText = "Location";
            this.locationId.MinimumWidth = 6;
            this.locationId.Name = "locationId";
            this.locationId.ReadOnly = true;
            this.locationId.ToolTipText = "Location";
            this.locationId.Width = 97;
            // 
            // supplierGoodsId
            // 
            this.supplierGoodsId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierGoodsId.DataPropertyName = "goodsName";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierGoodsId.DefaultCellStyle = dataGridViewCellStyle4;
            this.supplierGoodsId.HeaderText = "Goods Name";
            this.supplierGoodsId.MinimumWidth = 6;
            this.supplierGoodsId.Name = "supplierGoodsId";
            this.supplierGoodsId.ReadOnly = true;
            this.supplierGoodsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.supplierGoodsId.ToolTipText = "Goods Name";
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.HeaderText = "Qty";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.ToolTipText = "Quantity";
            this.quantity.Width = 68;
            // 
            // maxLimit
            // 
            this.maxLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maxLimit.DataPropertyName = "MaxLimit";
            this.maxLimit.HeaderText = "Max.";
            this.maxLimit.MinimumWidth = 6;
            this.maxLimit.Name = "maxLimit";
            this.maxLimit.ReadOnly = true;
            this.maxLimit.ToolTipText = "Maximum Limit";
            this.maxLimit.Width = 75;
            // 
            // minLimit
            // 
            this.minLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.minLimit.DataPropertyName = "MinLimit";
            this.minLimit.HeaderText = "Min.";
            this.minLimit.MinimumWidth = 6;
            this.minLimit.Name = "minLimit";
            this.minLimit.ReadOnly = true;
            this.minLimit.ToolTipText = "Minimum Limit";
            this.minLimit.Width = 72;
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReorderLevel.DataPropertyName = "ReorderLevel";
            this.ReorderLevel.HeaderText = "Reorder";
            this.ReorderLevel.Name = "ReorderLevel";
            this.ReorderLevel.ReadOnly = true;
            this.ReorderLevel.ToolTipText = "Reorder level";
            this.ReorderLevel.Width = 94;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 84;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.edit.ToolTipText = "Edit";
            this.edit.Width = 16;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.ToolTipText = "Delete";
            this.delete.Width = 6;
            // 
            // Action
            // 
            this.Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Action.Controls.Add(this.panel1);
            this.Action.Dock = System.Windows.Forms.DockStyle.Left;
            this.Action.Location = new System.Drawing.Point(10, 50);
            this.Action.Margin = new System.Windows.Forms.Padding(2);
            this.Action.Name = "Action";
            this.Action.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.Action.Size = new System.Drawing.Size(214, 405);
            this.Action.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.curdAction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 395);
            this.panel1.TabIndex = 6;
            // 
            // curdAction
            // 
            this.curdAction.BackColor = System.Drawing.Color.White;
            this.curdAction.Controls.Add(this.outBtn);
            this.curdAction.Controls.Add(this.panel6);
            this.curdAction.Controls.Add(this.inBtn);
            this.curdAction.Controls.Add(this.panel5);
            this.curdAction.Controls.Add(this.RestockBtn);
            this.curdAction.Controls.Add(this.margin1);
            this.curdAction.Controls.Add(this.exportBtn);
            this.curdAction.Controls.Add(this.panel2);
            this.curdAction.Controls.Add(this.DeleteBtn);
            this.curdAction.Controls.Add(this.panel3);
            this.curdAction.Controls.Add(this.AddBtn);
            this.curdAction.Controls.Add(this.panel4);
            this.curdAction.Controls.Add(this.SearchBar);
            this.curdAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curdAction.Location = new System.Drawing.Point(0, 0);
            this.curdAction.Margin = new System.Windows.Forms.Padding(2);
            this.curdAction.Name = "curdAction";
            this.curdAction.Padding = new System.Windows.Forms.Padding(10);
            this.curdAction.Size = new System.Drawing.Size(204, 395);
            this.curdAction.TabIndex = 6;
            // 
            // outBtn
            // 
            this.outBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.outBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.outBtn.BorderColor = System.Drawing.Color.White;
            this.outBtn.BorderRadius = 10;
            this.outBtn.BorderSize = 0;
            this.outBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.outBtn.FlatAppearance.BorderSize = 0;
            this.outBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outBtn.Font = new System.Drawing.Font("Segoe UI", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outBtn.ForeColor = System.Drawing.Color.White;
            this.outBtn.IsChecked = false;
            this.outBtn.Location = new System.Drawing.Point(10, 298);
            this.outBtn.Margin = new System.Windows.Forms.Padding(2);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(184, 38);
            this.outBtn.TabIndex = 13;
            this.outBtn.Text = "Outbound";
            this.outBtn.TextColor = System.Drawing.Color.White;
            this.outBtn.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 288);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 10);
            this.panel6.TabIndex = 14;
            // 
            // inBtn
            // 
            this.inBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.inBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.inBtn.BorderColor = System.Drawing.Color.White;
            this.inBtn.BorderRadius = 10;
            this.inBtn.BorderSize = 0;
            this.inBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inBtn.FlatAppearance.BorderSize = 0;
            this.inBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inBtn.Font = new System.Drawing.Font("Segoe UI", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBtn.ForeColor = System.Drawing.Color.White;
            this.inBtn.IsChecked = false;
            this.inBtn.Location = new System.Drawing.Point(10, 250);
            this.inBtn.Margin = new System.Windows.Forms.Padding(2);
            this.inBtn.Name = "inBtn";
            this.inBtn.Size = new System.Drawing.Size(184, 38);
            this.inBtn.TabIndex = 11;
            this.inBtn.Text = "Inbound";
            this.inBtn.TextColor = System.Drawing.Color.White;
            this.inBtn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 10);
            this.panel5.TabIndex = 12;
            // 
            // RestockBtn
            // 
            this.RestockBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.RestockBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.RestockBtn.BorderColor = System.Drawing.Color.White;
            this.RestockBtn.BorderRadius = 10;
            this.RestockBtn.BorderSize = 0;
            this.RestockBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RestockBtn.FlatAppearance.BorderSize = 0;
            this.RestockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestockBtn.Font = new System.Drawing.Font("Segoe UI", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestockBtn.ForeColor = System.Drawing.Color.White;
            this.RestockBtn.IsChecked = false;
            this.RestockBtn.Location = new System.Drawing.Point(10, 202);
            this.RestockBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RestockBtn.Name = "RestockBtn";
            this.RestockBtn.Size = new System.Drawing.Size(184, 38);
            this.RestockBtn.TabIndex = 6;
            this.RestockBtn.Text = "Restock";
            this.RestockBtn.TextColor = System.Drawing.Color.White;
            this.RestockBtn.UseVisualStyleBackColor = false;
            this.RestockBtn.Click += new System.EventHandler(this.RestockBtn_Click);
            // 
            // margin1
            // 
            this.margin1.Dock = System.Windows.Forms.DockStyle.Top;
            this.margin1.Location = new System.Drawing.Point(10, 192);
            this.margin1.Name = "margin1";
            this.margin1.Size = new System.Drawing.Size(184, 10);
            this.margin1.TabIndex = 10;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.exportBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.exportBtn.BorderColor = System.Drawing.Color.White;
            this.exportBtn.BorderRadius = 10;
            this.exportBtn.BorderSize = 0;
            this.exportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.IsChecked = false;
            this.exportBtn.Location = new System.Drawing.Point(10, 154);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(184, 38);
            this.exportBtn.TabIndex = 5;
            this.exportBtn.Text = "Export";
            this.exportBtn.TextColor = System.Drawing.Color.White;
            this.exportBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 10);
            this.panel2.TabIndex = 11;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DeleteBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DeleteBtn.BorderColor = System.Drawing.Color.White;
            this.DeleteBtn.BorderRadius = 10;
            this.DeleteBtn.BorderSize = 0;
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.IsChecked = false;
            this.DeleteBtn.Location = new System.Drawing.Point(10, 106);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(184, 38);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete Selected";
            this.DeleteBtn.TextColor = System.Drawing.Color.White;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 10);
            this.panel3.TabIndex = 11;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.AddBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.AddBtn.BorderColor = System.Drawing.Color.White;
            this.AddBtn.BorderRadius = 10;
            this.AddBtn.BorderSize = 0;
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = global::TheBetterLimited.Properties.Resources.add;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.IsChecked = false;
            this.AddBtn.Location = new System.Drawing.Point(10, 58);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AddBtn.Size = new System.Drawing.Size(184, 38);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "New";
            this.AddBtn.TextColor = System.Drawing.Color.White;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 10);
            this.panel4.TabIndex = 12;
            // 
            // SearchBar
            // 
            this.SearchBar.Controls.Add(this.pictureBox1);
            this.SearchBar.Controls.Add(this.SearchBarTxt);
            this.SearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBar.Location = new System.Drawing.Point(10, 10);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(184, 38);
            this.SearchBar.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SearchBarTxt
            // 
            this.SearchBarTxt.BackColor = System.Drawing.Color.White;
            this.SearchBarTxt.BorderColor = System.Drawing.Color.LightGray;
            this.SearchBarTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.SearchBarTxt.BorderRadius = 10;
            this.SearchBarTxt.BorderSize = 1;
            this.SearchBarTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBarTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBarTxt.ForeColor = System.Drawing.Color.LightGray;
            this.SearchBarTxt.IsError = false;
            this.SearchBarTxt.Location = new System.Drawing.Point(0, 0);
            this.SearchBarTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SearchBarTxt.MaxLength = 20;
            this.SearchBarTxt.Multiline = false;
            this.SearchBarTxt.Name = "SearchBarTxt";
            this.SearchBarTxt.Padding = new System.Windows.Forms.Padding(25, 8, 8, 6);
            this.SearchBarTxt.PasswordChar = false;
            this.SearchBarTxt.Placeholder = "Search";
            this.SearchBarTxt.ReadOnly = false;
            this.SearchBarTxt.Size = new System.Drawing.Size(184, 38);
            this.SearchBarTxt.TabIndex = 9;
            this.SearchBarTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.SearchBarTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.SearchBarTxt.Texts = "Search";
            this.SearchBarTxt.UnderlinedStyle = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.button1);
            this.Header.Controls.Add(this.button2);
            this.Header.Controls.Add(this.Title);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(10, 10);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(758, 40);
            this.Header.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::TheBetterLimited.Properties.Resources.close32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(716, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 33);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::TheBetterLimited.Properties.Resources.rotate_right;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(675, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 33);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(2, 7);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(62, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Stock";
            // 
            // Data
            // 
            this.Data.Controls.Add(this.loadPic);
            this.Data.Controls.Add(this.StockDataGrid);
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(224, 50);
            this.Data.Margin = new System.Windows.Forms.Padding(2);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Data.Size = new System.Drawing.Size(544, 405);
            this.Data.TabIndex = 8;
            // 
            // loadPic
            // 
            this.loadPic.BackColor = System.Drawing.Color.White;
            this.loadPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadPic.Location = new System.Drawing.Point(0, 10);
            this.loadPic.Name = "loadPic";
            this.loadPic.Size = new System.Drawing.Size(544, 395);
            this.loadPic.TabIndex = 4;
            this.loadPic.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 124;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 124;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 124;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(778, 465);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stock";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "InventoryManagement";
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGrid)).EndInit();
            this.Action.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.curdAction.ResumeLayout(false);
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
        private System.Windows.Forms.Panel curdAction;
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
        private System.Windows.Forms.Panel margin1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel loadPic;
        private CustomizeControl.RoundButton inBtn;
        private System.Windows.Forms.Panel panel5;
        private CustomizeControl.RoundButton outBtn;
        private System.Windows.Forms.Panel panel6;
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
    }
}