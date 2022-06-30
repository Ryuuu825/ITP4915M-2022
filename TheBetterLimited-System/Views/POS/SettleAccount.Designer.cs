namespace TheBetterLimited.Views
{
    partial class SettleAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettleAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainForm = new System.Windows.Forms.Panel();
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.PaymentInfo = new System.Windows.Forms.Panel();
            this.deposit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.books = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.line4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.StoreInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.storename = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.storeId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salesId = new System.Windows.Forms.Label();
            this.HeaderContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.printDate = new System.Windows.Forms.Label();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewImageColumn();
            this.MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            this.PaymentInfo.SuspendLayout();
            this.Footer.SuspendLayout();
            this.StoreInfo.SuspendLayout();
            this.HeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            resources.ApplyResources(this.MainForm, "MainForm");
            this.MainForm.BackColor = System.Drawing.Color.White;
            this.MainForm.Controls.Add(this.OrderDataGrid);
            this.MainForm.Controls.Add(this.PaymentInfo);
            this.MainForm.Controls.Add(this.Footer);
            this.MainForm.Controls.Add(this.StoreInfo);
            this.MainForm.Controls.Add(this.HeaderContainer);
            this.MainForm.Name = "MainForm";
            // 
            // OrderDataGrid
            // 
            resources.ApplyResources(this.OrderDataGrid, "OrderDataGrid");
            this.OrderDataGrid.AllowUserToAddRows = false;
            this.OrderDataGrid.AllowUserToOrderColumns = true;
            this.OrderDataGrid.AllowUserToResizeColumns = false;
            this.OrderDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.OrderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.OrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OrderDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.OrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.id,
            this.CreateAt,
            this.dataGridViewTextBoxColumn2,
            this.qty,
            this.Payment,
            this.status,
            this.details});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.DefaultCellStyle = dataGridViewCellStyle16;
            this.OrderDataGrid.EnableHeadersVisualStyles = false;
            this.OrderDataGrid.GridColor = System.Drawing.Color.White;
            this.OrderDataGrid.MultiSelect = false;
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.ReadOnly = true;
            this.OrderDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.OrderDataGrid.RowHeadersVisible = false;
            this.OrderDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.NullValue = null;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.OrderDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.OrderDataGrid.RowTemplate.Height = 40;
            this.OrderDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGrid.StandardTab = true;
            this.OrderDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellClick);
            // 
            // PaymentInfo
            // 
            resources.ApplyResources(this.PaymentInfo, "PaymentInfo");
            this.PaymentInfo.BackColor = System.Drawing.Color.White;
            this.PaymentInfo.Controls.Add(this.deposit);
            this.PaymentInfo.Controls.Add(this.label8);
            this.PaymentInfo.Controls.Add(this.books);
            this.PaymentInfo.Controls.Add(this.count);
            this.PaymentInfo.Controls.Add(this.label7);
            this.PaymentInfo.Controls.Add(this.line3);
            this.PaymentInfo.Controls.Add(this.label19);
            this.PaymentInfo.Controls.Add(this.orders);
            this.PaymentInfo.Controls.Add(this.label17);
            this.PaymentInfo.Controls.Add(this.totalAmount);
            this.PaymentInfo.Controls.Add(this.label13);
            this.PaymentInfo.ForeColor = System.Drawing.Color.Black;
            this.PaymentInfo.Name = "PaymentInfo";
            // 
            // deposit
            // 
            resources.ApplyResources(this.deposit, "deposit");
            this.deposit.Name = "deposit";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // books
            // 
            resources.ApplyResources(this.books, "books");
            this.books.Name = "books";
            // 
            // count
            // 
            resources.ApplyResources(this.count, "count");
            this.count.Name = "count";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // line3
            // 
            resources.ApplyResources(this.line3, "line3");
            this.line3.BackColor = System.Drawing.Color.DimGray;
            this.line3.Name = "line3";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // orders
            // 
            resources.ApplyResources(this.orders, "orders");
            this.orders.Name = "orders";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
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
            resources.ApplyResources(this.Footer, "Footer");
            this.Footer.Controls.Add(this.line4);
            this.Footer.Controls.Add(this.label18);
            this.Footer.Name = "Footer";
            // 
            // line4
            // 
            resources.ApplyResources(this.line4, "line4");
            this.line4.BackColor = System.Drawing.Color.DimGray;
            this.line4.Name = "line4";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // StoreInfo
            // 
            resources.ApplyResources(this.StoreInfo, "StoreInfo");
            this.StoreInfo.Controls.Add(this.label6);
            this.StoreInfo.Controls.Add(this.name);
            this.StoreInfo.Controls.Add(this.storename);
            this.StoreInfo.Controls.Add(this.label5);
            this.StoreInfo.Controls.Add(this.panel1);
            this.StoreInfo.Controls.Add(this.storeId);
            this.StoreInfo.Controls.Add(this.label2);
            this.StoreInfo.Controls.Add(this.label3);
            this.StoreInfo.Controls.Add(this.salesId);
            this.StoreInfo.ForeColor = System.Drawing.Color.Black;
            this.StoreInfo.Name = "StoreInfo";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Name = "name";
            // 
            // storename
            // 
            resources.ApplyResources(this.storename, "storename");
            this.storename.ForeColor = System.Drawing.Color.Black;
            this.storename.Name = "storename";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Name = "panel1";
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
            // HeaderContainer
            // 
            resources.ApplyResources(this.HeaderContainer, "HeaderContainer");
            this.HeaderContainer.BackColor = System.Drawing.Color.White;
            this.HeaderContainer.Controls.Add(this.label1);
            this.HeaderContainer.Controls.Add(this.label10);
            this.HeaderContainer.Controls.Add(this.printDate);
            this.HeaderContainer.Name = "HeaderContainer";
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
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.select, "select");
            this.select.Image = global::TheBetterLimited.Properties.Resources.square24;
            this.select.Name = "select";
            this.select.ReadOnly = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "orderID";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.id.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // CreateAt
            // 
            this.CreateAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateAt.DataPropertyName = "createAt";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CreateAt.DefaultCellStyle = dataGridViewCellStyle13;
            resources.ApplyResources(this.CreateAt, "CreateAt");
            this.CreateAt.Name = "CreateAt";
            this.CreateAt.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "total";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            resources.ApplyResources(this.qty, "qty");
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "payment";
            resources.ApplyResources(this.Payment, "Payment");
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.status.DefaultCellStyle = dataGridViewCellStyle15;
            resources.ApplyResources(this.status, "status");
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.details, "details");
            this.details.Image = global::TheBetterLimited.Properties.Resources.eye24;
            this.details.Name = "details";
            this.details.ReadOnly = true;
            // 
            // SettleAccount
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettleAccount";
            this.ShowIcon = false;
            this.MainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            this.PaymentInfo.ResumeLayout(false);
            this.PaymentInfo.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.StoreInfo.ResumeLayout(false);
            this.StoreInfo.PerformLayout();
            this.HeaderContainer.ResumeLayout(false);
            this.HeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel PaymentInfo;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label salesId;
        private System.Windows.Forms.Label storeId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Label printDate;
        private System.Windows.Forms.Label orders;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel line4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel StoreInfo;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel HeaderContainer;
        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label storename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label books;
        private System.Windows.Forms.Label deposit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewImageColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn details;
    }
}