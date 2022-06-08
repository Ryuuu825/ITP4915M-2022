namespace TheBetterLimited.Views
{
    partial class Receipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.MainForm = new System.Windows.Forms.Panel();
            this.OrderItemDataGrid = new System.Windows.Forms.DataGridView();
            this.goodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDisplay = new System.Windows.Forms.DataGridViewImageColumn();
            this.isInstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.CustomerInfo = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.installDate = new System.Windows.Forms.Label();
            this.deliveryDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deliveryAddress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.PaymentInfo = new System.Windows.Forms.Panel();
            this.line3 = new System.Windows.Forms.Panel();
            this.paymentMethod = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.depositTxt = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.line4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.StoreInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Panel();
            this.transcationDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.storeAddress = new System.Windows.Forms.Label();
            this.storeId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salesId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.printDate = new System.Windows.Forms.Label();
            this.HeaderContainer = new System.Windows.Forms.Panel();
            this.orderId = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.PictureBox();
            this.CompanyInfo = new System.Windows.Forms.Panel();
            this.CompanyTitle1 = new System.Windows.Forms.Label();
            this.CompanyTitle0 = new System.Windows.Forms.Label();
            this.CompanyIcon = new System.Windows.Forms.PictureBox();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemDataGrid)).BeginInit();
            this.CustomerInfo.SuspendLayout();
            this.PaymentInfo.SuspendLayout();
            this.Footer.SuspendLayout();
            this.StoreInfo.SuspendLayout();
            this.HeaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).BeginInit();
            this.CompanyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.White;
            this.MainForm.Controls.Add(this.OrderItemDataGrid);
            this.MainForm.Controls.Add(this.CustomerInfo);
            this.MainForm.Controls.Add(this.PaymentInfo);
            this.MainForm.Controls.Add(this.Footer);
            this.MainForm.Controls.Add(this.StoreInfo);
            this.MainForm.Controls.Add(this.HeaderContainer);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(0);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(1040, 916);
            this.MainForm.TabIndex = 2;
            // 
            // OrderItemDataGrid
            // 
            this.OrderItemDataGrid.AllowUserToAddRows = false;
            this.OrderItemDataGrid.AllowUserToOrderColumns = true;
            this.OrderItemDataGrid.AllowUserToResizeColumns = false;
            this.OrderItemDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.OrderItemDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderItemDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderItemDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderItemDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.OrderItemDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderItemDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderItemDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderItemDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderItemDataGrid.ColumnHeadersHeight = 50;
            this.OrderItemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderItemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsID,
            this.goodsName,
            this.price,
            this.qty,
            this.amount,
            this.isDisplay,
            this.isInstall});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderItemDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.OrderItemDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderItemDataGrid.EnableHeadersVisualStyles = false;
            this.OrderItemDataGrid.GridColor = System.Drawing.Color.White;
            this.OrderItemDataGrid.Location = new System.Drawing.Point(0, 404);
            this.OrderItemDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.OrderItemDataGrid.MultiSelect = false;
            this.OrderItemDataGrid.Name = "OrderItemDataGrid";
            this.OrderItemDataGrid.ReadOnly = true;
            this.OrderItemDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderItemDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.OrderItemDataGrid.RowHeadersVisible = false;
            this.OrderItemDataGrid.RowHeadersWidth = 30;
            this.OrderItemDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrderItemDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.OrderItemDataGrid.RowTemplate.Height = 30;
            this.OrderItemDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderItemDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderItemDataGrid.Size = new System.Drawing.Size(1040, 352);
            this.OrderItemDataGrid.StandardTab = true;
            this.OrderItemDataGrid.TabIndex = 34;
            this.OrderItemDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.OrderItemDataGrid_CellFormatting);
            // 
            // goodsID
            // 
            this.goodsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.goodsID.DataPropertyName = "goodsId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.goodsID.DefaultCellStyle = dataGridViewCellStyle3;
            this.goodsID.HeaderText = "識別編號 ID No.";
            this.goodsID.Name = "goodsID";
            this.goodsID.ReadOnly = true;
            this.goodsID.ToolTipText = "Goods ID";
            this.goodsID.Width = 107;
            // 
            // goodsName
            // 
            this.goodsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodsName.DataPropertyName = "goodsName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsName.DefaultCellStyle = dataGridViewCellStyle4;
            this.goodsName.HeaderText = "貨品 Product";
            this.goodsName.MinimumWidth = 6;
            this.goodsName.Name = "goodsName";
            this.goodsName.ReadOnly = true;
            this.goodsName.ToolTipText = "Goods Name";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle5;
            this.price.HeaderText = "單價 Unit Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.ToolTipText = "Unit Price";
            this.price.Width = 119;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.DataPropertyName = "qty";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qty.DefaultCellStyle = dataGridViewCellStyle6;
            this.qty.HeaderText = "數量 Qty";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.ToolTipText = "Quantity";
            this.qty.Width = 70;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amount.DataPropertyName = "amount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle7;
            this.amount.HeaderText = "金額 Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.ToolTipText = "Sub amount";
            this.amount.Width = 110;
            // 
            // isDisplay
            // 
            this.isDisplay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isDisplay.HeaderText = "展示商品 Display Item";
            this.isDisplay.Image = global::TheBetterLimited.Properties.Resources.square24;
            this.isDisplay.MinimumWidth = 6;
            this.isDisplay.Name = "isDisplay";
            this.isDisplay.ReadOnly = true;
            this.isDisplay.ToolTipText = "Is display item?";
            this.isDisplay.Width = 114;
            // 
            // isInstall
            // 
            this.isInstall.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isInstall.DataPropertyName = "isInstall";
            this.isInstall.HeaderText = "是否安裝 Need Install";
            this.isInstall.Image = global::TheBetterLimited.Properties.Resources.square24;
            this.isInstall.Name = "isInstall";
            this.isInstall.ReadOnly = true;
            this.isInstall.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isInstall.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isInstall.Width = 124;
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.Controls.Add(this.line2);
            this.CustomerInfo.Controls.Add(this.label16);
            this.CustomerInfo.Controls.Add(this.installDate);
            this.CustomerInfo.Controls.Add(this.deliveryDate);
            this.CustomerInfo.Controls.Add(this.label9);
            this.CustomerInfo.Controls.Add(this.deliveryAddress);
            this.CustomerInfo.Controls.Add(this.label7);
            this.CustomerInfo.Controls.Add(this.label6);
            this.CustomerInfo.Controls.Add(this.cusName);
            this.CustomerInfo.Controls.Add(this.tel);
            this.CustomerInfo.Controls.Add(this.label8);
            this.CustomerInfo.Controls.Add(this.label12);
            this.CustomerInfo.Controls.Add(this.area);
            this.CustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerInfo.ForeColor = System.Drawing.Color.Black;
            this.CustomerInfo.Location = new System.Drawing.Point(0, 274);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(1040, 130);
            this.CustomerInfo.TabIndex = 0;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.DimGray;
            this.line2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line2.Location = new System.Drawing.Point(0, 129);
            this.line2.Margin = new System.Windows.Forms.Padding(0);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(1040, 1);
            this.line2.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(15, 97);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(330, 17);
            this.label16.TabIndex = 58;
            this.label16.Text = "預計安裝日期與時間 Expect Delivery Date & Time:";
            this.label16.UseMnemonic = false;
            // 
            // installDate
            // 
            this.installDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installDate.ForeColor = System.Drawing.Color.Black;
            this.installDate.Location = new System.Drawing.Point(403, 97);
            this.installDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.installDate.Name = "installDate";
            this.installDate.Size = new System.Drawing.Size(611, 17);
            this.installDate.TabIndex = 59;
            this.installDate.Text = "#install date & time";
            this.installDate.UseMnemonic = false;
            // 
            // deliveryDate
            // 
            this.deliveryDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDate.Location = new System.Drawing.Point(403, 71);
            this.deliveryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Size = new System.Drawing.Size(611, 17);
            this.deliveryDate.TabIndex = 43;
            this.deliveryDate.Text = "#delivery date & time";
            this.deliveryDate.UseMnemonic = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "預計送貨日期與時間 Expect Delivery Date & Time:";
            this.label9.UseMnemonic = false;
            // 
            // deliveryAddress
            // 
            this.deliveryAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryAddress.Location = new System.Drawing.Point(229, 39);
            this.deliveryAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deliveryAddress.Name = "deliveryAddress";
            this.deliveryAddress.Size = new System.Drawing.Size(786, 17);
            this.deliveryAddress.TabIndex = 42;
            this.deliveryAddress.Text = "#delivery address";
            this.deliveryAddress.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "送貨地址 Delivery Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "顧客姓名 Customer Name:";
            // 
            // cusName
            // 
            this.cusName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.Location = new System.Drawing.Point(229, 8);
            this.cusName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(206, 17);
            this.cusName.TabIndex = 40;
            this.cusName.Text = "#customer name";
            // 
            // tel
            // 
            this.tel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.Location = new System.Drawing.Point(561, 8);
            this.tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(194, 17);
            this.tel.TabIndex = 41;
            this.tel.Text = "#phone no";
            this.tel.UseMnemonic = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(490, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "電話 Tel:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(763, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 44;
            this.label12.Text = "地區 Area:";
            // 
            // area
            // 
            this.area.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.Location = new System.Drawing.Point(853, 8);
            this.area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(162, 17);
            this.area.TabIndex = 45;
            this.area.Text = "#area";
            this.area.UseMnemonic = false;
            // 
            // PaymentInfo
            // 
            this.PaymentInfo.BackColor = System.Drawing.Color.White;
            this.PaymentInfo.Controls.Add(this.line3);
            this.PaymentInfo.Controls.Add(this.paymentMethod);
            this.PaymentInfo.Controls.Add(this.label19);
            this.PaymentInfo.Controls.Add(this.final);
            this.PaymentInfo.Controls.Add(this.label15);
            this.PaymentInfo.Controls.Add(this.depositTxt);
            this.PaymentInfo.Controls.Add(this.label17);
            this.PaymentInfo.Controls.Add(this.paid);
            this.PaymentInfo.Controls.Add(this.label14);
            this.PaymentInfo.Controls.Add(this.totalAmount);
            this.PaymentInfo.Controls.Add(this.label13);
            this.PaymentInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaymentInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentInfo.ForeColor = System.Drawing.Color.Black;
            this.PaymentInfo.Location = new System.Drawing.Point(0, 756);
            this.PaymentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.PaymentInfo.Name = "PaymentInfo";
            this.PaymentInfo.Size = new System.Drawing.Size(1040, 111);
            this.PaymentInfo.TabIndex = 24;
            this.PaymentInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.UserInfo_Paint);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.DimGray;
            this.line3.Dock = System.Windows.Forms.DockStyle.Top;
            this.line3.Location = new System.Drawing.Point(0, 0);
            this.line3.Margin = new System.Windows.Forms.Padding(0);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(1040, 1);
            this.line3.TabIndex = 30;
            // 
            // paymentMethod
            // 
            this.paymentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethod.Location = new System.Drawing.Point(173, 62);
            this.paymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(154, 24);
            this.paymentMethod.TabIndex = 57;
            this.paymentMethod.Text = "#paymentMethod";
            this.paymentMethod.UseMnemonic = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 62);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 17);
            this.label19.TabIndex = 56;
            this.label19.Text = "付款方式 Paid By:";
            // 
            // final
            // 
            this.final.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final.Location = new System.Drawing.Point(812, 62);
            this.final.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(205, 40);
            this.final.TabIndex = 55;
            this.final.Text = "#paid";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(661, 62);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 17);
            this.label15.TabIndex = 54;
            this.label15.Text = "尾款 Final Payment:";
            // 
            // depositTxt
            // 
            this.depositTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositTxt.Location = new System.Drawing.Point(154, 12);
            this.depositTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depositTxt.Name = "depositTxt";
            this.depositTxt.Size = new System.Drawing.Size(177, 40);
            this.depositTxt.TabIndex = 52;
            this.depositTxt.Text = "#deposit";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 12);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 17);
            this.label17.TabIndex = 51;
            this.label17.Text = "Deposit 所需訂金:";
            // 
            // paid
            // 
            this.paid.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid.Location = new System.Drawing.Point(844, 12);
            this.paid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(174, 40);
            this.paid.TabIndex = 50;
            this.paid.Text = "#paid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(752, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 49;
            this.label14.Text = "已付 Paid:";
            // 
            // totalAmount
            // 
            this.totalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(520, 12);
            this.totalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(226, 40);
            this.totalAmount.TabIndex = 48;
            this.totalAmount.Text = "#total amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(360, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Total Amount 總額:";
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.line4);
            this.Footer.Controls.Add(this.label18);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 867);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(1040, 49);
            this.Footer.TabIndex = 58;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.DimGray;
            this.line4.Dock = System.Windows.Forms.DockStyle.Top;
            this.line4.Location = new System.Drawing.Point(0, 0);
            this.line4.Margin = new System.Windows.Forms.Padding(0);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(1040, 1);
            this.line4.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(367, 10);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(307, 30);
            this.label18.TabIndex = 53;
            this.label18.Text = "Thank You For Your Purchase!";
            // 
            // StoreInfo
            // 
            this.StoreInfo.Controls.Add(this.panel1);
            this.StoreInfo.Controls.Add(this.label11);
            this.StoreInfo.Controls.Add(this.label20);
            this.StoreInfo.Controls.Add(this.line1);
            this.StoreInfo.Controls.Add(this.transcationDate);
            this.StoreInfo.Controls.Add(this.label5);
            this.StoreInfo.Controls.Add(this.label4);
            this.StoreInfo.Controls.Add(this.storeAddress);
            this.StoreInfo.Controls.Add(this.storeId);
            this.StoreInfo.Controls.Add(this.label2);
            this.StoreInfo.Controls.Add(this.label3);
            this.StoreInfo.Controls.Add(this.salesId);
            this.StoreInfo.Controls.Add(this.label1);
            this.StoreInfo.Controls.Add(this.label10);
            this.StoreInfo.Controls.Add(this.printDate);
            this.StoreInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.StoreInfo.ForeColor = System.Drawing.Color.Black;
            this.StoreInfo.Location = new System.Drawing.Point(0, 130);
            this.StoreInfo.Name = "StoreInfo";
            this.StoreInfo.Size = new System.Drawing.Size(1040, 144);
            this.StoreInfo.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 1);
            this.panel1.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(801, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "852-32115699";
            this.label11.UseMnemonic = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(730, 50);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 17);
            this.label20.TabIndex = 49;
            this.label20.Text = "電話 Tel:";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Gray;
            this.line1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line1.Location = new System.Drawing.Point(0, 143);
            this.line1.Margin = new System.Windows.Forms.Padding(0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1040, 1);
            this.line1.TabIndex = 28;
            // 
            // transcationDate
            // 
            this.transcationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transcationDate.ForeColor = System.Drawing.Color.Black;
            this.transcationDate.Location = new System.Drawing.Point(229, 100);
            this.transcationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transcationDate.Name = "transcationDate";
            this.transcationDate.Size = new System.Drawing.Size(766, 24);
            this.transcationDate.TabIndex = 39;
            this.transcationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transcationDate.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "交易日期 Transcation Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "分店地址 Store Address: ";
            // 
            // storeAddress
            // 
            this.storeAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeAddress.ForeColor = System.Drawing.Color.Black;
            this.storeAddress.Location = new System.Drawing.Point(216, 74);
            this.storeAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storeAddress.Name = "storeAddress";
            this.storeAddress.Size = new System.Drawing.Size(786, 24);
            this.storeAddress.TabIndex = 38;
            this.storeAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // storeId
            // 
            this.storeId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeId.ForeColor = System.Drawing.Color.Black;
            this.storeId.Location = new System.Drawing.Point(170, 48);
            this.storeId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storeId.Name = "storeId";
            this.storeId.Size = new System.Drawing.Size(210, 21);
            this.storeId.TabIndex = 36;
            this.storeId.Text = "#storeId";
            this.storeId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "分店編號 Store ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(388, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "銷售員 Sales: ";
            // 
            // salesId
            // 
            this.salesId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesId.ForeColor = System.Drawing.Color.Black;
            this.salesId.Location = new System.Drawing.Point(504, 46);
            this.salesId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesId.Name = "salesId";
            this.salesId.Size = new System.Drawing.Size(218, 24);
            this.salesId.TabIndex = 37;
            this.salesId.Text = "#salesId";
            this.salesId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "Receipt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(642, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "列印日期 Print Date:";
            // 
            // printDate
            // 
            this.printDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDate.ForeColor = System.Drawing.Color.Black;
            this.printDate.Location = new System.Drawing.Point(814, 3);
            this.printDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printDate.Name = "printDate";
            this.printDate.Size = new System.Drawing.Size(208, 17);
            this.printDate.TabIndex = 47;
            this.printDate.Text = "#print date";
            this.printDate.UseMnemonic = false;
            // 
            // HeaderContainer
            // 
            this.HeaderContainer.BackColor = System.Drawing.Color.White;
            this.HeaderContainer.Controls.Add(this.orderId);
            this.HeaderContainer.Controls.Add(this.barcode);
            this.HeaderContainer.Controls.Add(this.CompanyInfo);
            this.HeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.HeaderContainer.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderContainer.Name = "HeaderContainer";
            this.HeaderContainer.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.HeaderContainer.Size = new System.Drawing.Size(1040, 130);
            this.HeaderContainer.TabIndex = 20;
            // 
            // orderId
            // 
            this.orderId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId.Location = new System.Drawing.Point(758, 106);
            this.orderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(247, 23);
            this.orderId.TabIndex = 48;
            this.orderId.Text = "#order Id";
            this.orderId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.orderId.UseMnemonic = false;
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(736, 11);
            this.barcode.Margin = new System.Windows.Forms.Padding(4);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(289, 95);
            this.barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.barcode.TabIndex = 2;
            this.barcode.TabStop = false;
            // 
            // CompanyInfo
            // 
            this.CompanyInfo.Controls.Add(this.CompanyTitle1);
            this.CompanyInfo.Controls.Add(this.CompanyTitle0);
            this.CompanyInfo.Controls.Add(this.CompanyIcon);
            this.CompanyInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.CompanyInfo.Location = new System.Drawing.Point(18, 0);
            this.CompanyInfo.Margin = new System.Windows.Forms.Padding(0);
            this.CompanyInfo.Name = "CompanyInfo";
            this.CompanyInfo.Size = new System.Drawing.Size(234, 130);
            this.CompanyInfo.TabIndex = 1;
            // 
            // CompanyTitle1
            // 
            this.CompanyTitle1.AutoSize = true;
            this.CompanyTitle1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTitle1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompanyTitle1.Location = new System.Drawing.Point(117, 75);
            this.CompanyTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyTitle1.Name = "CompanyTitle1";
            this.CompanyTitle1.Size = new System.Drawing.Size(87, 28);
            this.CompanyTitle1.TabIndex = 3;
            this.CompanyTitle1.Text = "Limited.";
            // 
            // CompanyTitle0
            // 
            this.CompanyTitle0.AutoSize = true;
            this.CompanyTitle0.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTitle0.ForeColor = System.Drawing.Color.SeaGreen;
            this.CompanyTitle0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompanyTitle0.Location = new System.Drawing.Point(128, 30);
            this.CompanyTitle0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyTitle0.Name = "CompanyTitle0";
            this.CompanyTitle0.Size = new System.Drawing.Size(69, 28);
            this.CompanyTitle0.TabIndex = 2;
            this.CompanyTitle0.Text = "Better";
            // 
            // CompanyIcon
            // 
            this.CompanyIcon.Image = global::TheBetterLimited.Properties.Resources.logo46;
            this.CompanyIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompanyIcon.Location = new System.Drawing.Point(0, 7);
            this.CompanyIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CompanyIcon.Name = "CompanyIcon";
            this.CompanyIcon.Size = new System.Drawing.Size(110, 116);
            this.CompanyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompanyIcon.TabIndex = 0;
            this.CompanyIcon.TabStop = false;
            // 
            // printDocument2
            // 
            this.printDocument2.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument2_EndPrint);
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "展示商品 Display Item";
            this.dataGridViewImageColumn1.Image = global::TheBetterLimited.Properties.Resources.check24;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Is display item?";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1040, 916);
            this.Controls.Add(this.MainForm);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Receipt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.MainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemDataGrid)).EndInit();
            this.CustomerInfo.ResumeLayout(false);
            this.CustomerInfo.PerformLayout();
            this.PaymentInfo.ResumeLayout(false);
            this.PaymentInfo.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.StoreInfo.ResumeLayout(false);
            this.StoreInfo.PerformLayout();
            this.HeaderContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).EndInit();
            this.CompanyInfo.ResumeLayout(false);
            this.CompanyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel PaymentInfo;
        private System.Windows.Forms.Panel HeaderContainer;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel CompanyInfo;
        private System.Windows.Forms.Label CompanyTitle1;
        private System.Windows.Forms.Label CompanyTitle0;
        private System.Windows.Forms.PictureBox CompanyIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox barcode;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView OrderItemDataGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label transcationDate;
        private System.Windows.Forms.Label storeAddress;
        private System.Windows.Forms.Label salesId;
        private System.Windows.Forms.Label storeId;
        private System.Windows.Forms.Label cusName;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label deliveryAddress;
        private System.Windows.Forms.Label deliveryDate;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Label printDate;
        private System.Windows.Forms.Label depositTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label paid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label final;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label paymentMethod;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel line4;
        private System.Windows.Forms.Label orderId;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label installDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewImageColumn isDisplay;
        private System.Windows.Forms.DataGridViewImageColumn isInstall;
        private System.Windows.Forms.Panel CustomerInfo;
        private System.Windows.Forms.Panel StoreInfo;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
    }
}