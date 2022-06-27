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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
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
            resources.ApplyResources(this.MainForm, "MainForm");
            this.MainForm.Name = "MainForm";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderItemDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.OrderItemDataGrid, "OrderItemDataGrid");
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
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderItemDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.OrderItemDataGrid.EnableHeadersVisualStyles = false;
            this.OrderItemDataGrid.GridColor = System.Drawing.Color.White;
            this.OrderItemDataGrid.MultiSelect = false;
            this.OrderItemDataGrid.Name = "OrderItemDataGrid";
            this.OrderItemDataGrid.ReadOnly = true;
            this.OrderItemDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderItemDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.OrderItemDataGrid.RowHeadersVisible = false;
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
            this.OrderItemDataGrid.StandardTab = true;
            // 
            // goodsID
            // 
            this.goodsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.goodsID.DataPropertyName = "goodsId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.goodsID.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.goodsID, "goodsID");
            this.goodsID.Name = "goodsID";
            this.goodsID.ReadOnly = true;
            // 
            // goodsName
            // 
            this.goodsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodsName.DataPropertyName = "goodsName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsName.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.goodsName, "goodsName");
            this.goodsName.Name = "goodsName";
            this.goodsName.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.DataPropertyName = "qty";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qty.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.qty, "qty");
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amount.DataPropertyName = "amount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.amount, "amount");
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // isDisplay
            // 
            this.isDisplay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.isDisplay, "isDisplay");
            this.isDisplay.Image = global::TheBetterLimited.Properties.Resources.square24;
            this.isDisplay.Name = "isDisplay";
            this.isDisplay.ReadOnly = true;
            // 
            // isInstall
            // 
            this.isInstall.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isInstall.DataPropertyName = "isInstall";
            resources.ApplyResources(this.isInstall, "isInstall");
            this.isInstall.Image = global::TheBetterLimited.Properties.Resources.square24;
            this.isInstall.Name = "isInstall";
            this.isInstall.ReadOnly = true;
            this.isInstall.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isInstall.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            resources.ApplyResources(this.CustomerInfo, "CustomerInfo");
            this.CustomerInfo.ForeColor = System.Drawing.Color.Black;
            this.CustomerInfo.Name = "CustomerInfo";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.line2, "line2");
            this.line2.Name = "line2";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Name = "label16";
            this.label16.UseMnemonic = false;
            // 
            // installDate
            // 
            resources.ApplyResources(this.installDate, "installDate");
            this.installDate.ForeColor = System.Drawing.Color.Black;
            this.installDate.Name = "installDate";
            this.installDate.UseMnemonic = false;
            // 
            // deliveryDate
            // 
            resources.ApplyResources(this.deliveryDate, "deliveryDate");
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.UseMnemonic = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.UseMnemonic = false;
            // 
            // deliveryAddress
            // 
            resources.ApplyResources(this.deliveryAddress, "deliveryAddress");
            this.deliveryAddress.Name = "deliveryAddress";
            this.deliveryAddress.UseMnemonic = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cusName
            // 
            resources.ApplyResources(this.cusName, "cusName");
            this.cusName.Name = "cusName";
            // 
            // tel
            // 
            resources.ApplyResources(this.tel, "tel");
            this.tel.Name = "tel";
            this.tel.UseMnemonic = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // area
            // 
            resources.ApplyResources(this.area, "area");
            this.area.Name = "area";
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
            resources.ApplyResources(this.PaymentInfo, "PaymentInfo");
            this.PaymentInfo.ForeColor = System.Drawing.Color.Black;
            this.PaymentInfo.Name = "PaymentInfo";
            this.PaymentInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.UserInfo_Paint);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.line3, "line3");
            this.line3.Name = "line3";
            // 
            // paymentMethod
            // 
            resources.ApplyResources(this.paymentMethod, "paymentMethod");
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.UseMnemonic = false;
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // final
            // 
            resources.ApplyResources(this.final, "final");
            this.final.Name = "final";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // depositTxt
            // 
            resources.ApplyResources(this.depositTxt, "depositTxt");
            this.depositTxt.Name = "depositTxt";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // paid
            // 
            resources.ApplyResources(this.paid, "paid");
            this.paid.Name = "paid";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // totalAmount
            // 
            resources.ApplyResources(this.totalAmount, "totalAmount");
            this.totalAmount.Name = "totalAmount";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.line4);
            this.Footer.Controls.Add(this.label18);
            resources.ApplyResources(this.Footer, "Footer");
            this.Footer.Name = "Footer";
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.line4, "line4");
            this.line4.Name = "line4";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
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
            resources.ApplyResources(this.StoreInfo, "StoreInfo");
            this.StoreInfo.ForeColor = System.Drawing.Color.Black;
            this.StoreInfo.Name = "StoreInfo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.label11.UseMnemonic = false;
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.line1, "line1");
            this.line1.Name = "line1";
            // 
            // transcationDate
            // 
            resources.ApplyResources(this.transcationDate, "transcationDate");
            this.transcationDate.ForeColor = System.Drawing.Color.Black;
            this.transcationDate.Name = "transcationDate";
            this.transcationDate.UseMnemonic = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // storeAddress
            // 
            resources.ApplyResources(this.storeAddress, "storeAddress");
            this.storeAddress.ForeColor = System.Drawing.Color.Black;
            this.storeAddress.Name = "storeAddress";
            // 
            // storeId
            // 
            resources.ApplyResources(this.storeId, "storeId");
            this.storeId.ForeColor = System.Drawing.Color.Black;
            this.storeId.Name = "storeId";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // salesId
            // 
            resources.ApplyResources(this.salesId, "salesId");
            this.salesId.ForeColor = System.Drawing.Color.Black;
            this.salesId.Name = "salesId";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Name = "label10";
            // 
            // printDate
            // 
            resources.ApplyResources(this.printDate, "printDate");
            this.printDate.ForeColor = System.Drawing.Color.Black;
            this.printDate.Name = "printDate";
            this.printDate.UseMnemonic = false;
            // 
            // HeaderContainer
            // 
            this.HeaderContainer.BackColor = System.Drawing.Color.White;
            this.HeaderContainer.Controls.Add(this.orderId);
            this.HeaderContainer.Controls.Add(this.barcode);
            this.HeaderContainer.Controls.Add(this.CompanyInfo);
            resources.ApplyResources(this.HeaderContainer, "HeaderContainer");
            this.HeaderContainer.Name = "HeaderContainer";
            // 
            // orderId
            // 
            resources.ApplyResources(this.orderId, "orderId");
            this.orderId.Name = "orderId";
            this.orderId.UseMnemonic = false;
            // 
            // barcode
            // 
            resources.ApplyResources(this.barcode, "barcode");
            this.barcode.Name = "barcode";
            this.barcode.TabStop = false;
            // 
            // CompanyInfo
            // 
            this.CompanyInfo.Controls.Add(this.CompanyTitle1);
            this.CompanyInfo.Controls.Add(this.CompanyTitle0);
            this.CompanyInfo.Controls.Add(this.CompanyIcon);
            resources.ApplyResources(this.CompanyInfo, "CompanyInfo");
            this.CompanyInfo.Name = "CompanyInfo";
            // 
            // CompanyTitle1
            // 
            resources.ApplyResources(this.CompanyTitle1, "CompanyTitle1");
            this.CompanyTitle1.Name = "CompanyTitle1";
            // 
            // CompanyTitle0
            // 
            resources.ApplyResources(this.CompanyTitle0, "CompanyTitle0");
            this.CompanyTitle0.ForeColor = System.Drawing.Color.SeaGreen;
            this.CompanyTitle0.Name = "CompanyTitle0";
            // 
            // CompanyIcon
            // 
            this.CompanyIcon.Image = global::TheBetterLimited.Properties.Resources.logo46;
            resources.ApplyResources(this.CompanyIcon, "CompanyIcon");
            this.CompanyIcon.Name = "CompanyIcon";
            this.CompanyIcon.TabStop = false;
            // 
            // printDocument2
            // 
            this.printDocument2.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument2_EndPrint);
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::TheBetterLimited.Properties.Resources.check24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn2.DataPropertyName = "isInstall";
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = global::TheBetterLimited.Properties.Resources.square24;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Receipt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Receipt";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Panel CustomerInfo;
        private System.Windows.Forms.Panel StoreInfo;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewImageColumn isDisplay;
        private System.Windows.Forms.DataGridViewImageColumn isInstall;
    }
}