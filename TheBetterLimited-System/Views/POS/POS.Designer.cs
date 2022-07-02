namespace TheBetterLimited.Views
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.menuTitle = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.SearchBarTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.ProductContainer = new System.Windows.Forms.Panel();
            this.loadPic = new System.Windows.Forms.Panel();
            this.ProductInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.line = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.POSActionGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.settleAccBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CatalogueCombox = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.CartContainer = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CartItemGrid = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewImageColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus = new System.Windows.Forms.DataGridViewImageColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Header = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.DiscountContainer = new System.Windows.Forms.Panel();
            this.DiscountValue = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalAmountTxt = new System.Windows.Forms.Label();
            this.AmountTitle = new System.Windows.Forms.Label();
            this.OrderBtnGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.PayBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.ClearBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            this.ProductContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.POSActionGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.CartContainer.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartItemGrid)).BeginInit();
            this.Header.SuspendLayout();
            this.DiscountContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.OrderBtnGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.Controls.Add(this.menuTitle);
            this.SearchBar.Controls.Add(this.searchBtn);
            this.SearchBar.Controls.Add(this.SearchBarTxt);
            resources.ApplyResources(this.SearchBar, "SearchBar");
            this.SearchBar.Name = "SearchBar";
            // 
            // menuTitle
            // 
            resources.ApplyResources(this.menuTitle, "menuTitle");
            this.menuTitle.ForeColor = System.Drawing.Color.Black;
            this.menuTitle.Name = "menuTitle";
            // 
            // searchBtn
            // 
            resources.ApplyResources(this.searchBtn, "searchBtn");
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchBarTxt
            // 
            resources.ApplyResources(this.SearchBarTxt, "SearchBarTxt");
            this.SearchBarTxt.BackColor = System.Drawing.Color.White;
            this.SearchBarTxt.BorderColor = System.Drawing.Color.LightGray;
            this.SearchBarTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.SearchBarTxt.BorderRadius = 10;
            this.SearchBarTxt.BorderSize = 1;
            this.SearchBarTxt.ForeColor = System.Drawing.Color.Black;
            this.SearchBarTxt.IsError = false;
            this.SearchBarTxt.MaxLength = 20;
            this.SearchBarTxt.Multiline = false;
            this.SearchBarTxt.Name = "SearchBarTxt";
            this.SearchBarTxt.PasswordChar = false;
            this.SearchBarTxt.Placeholder = "Search by Keywords";
            this.SearchBarTxt.ReadOnly = false;
            this.SearchBarTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.SearchBarTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.SearchBarTxt.Texts = "Search by Keywords";
            this.SearchBarTxt.UnderlinedStyle = false;
            // 
            // ProductContainer
            // 
            this.ProductContainer.Controls.Add(this.loadPic);
            this.ProductContainer.Controls.Add(this.ProductInfoContainer);
            this.ProductContainer.Controls.Add(this.line);
            this.ProductContainer.Controls.Add(this.panel1);
            this.ProductContainer.Controls.Add(this.panel4);
            resources.ApplyResources(this.ProductContainer, "ProductContainer");
            this.ProductContainer.Name = "ProductContainer";
            // 
            // loadPic
            // 
            this.loadPic.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.loadPic, "loadPic");
            this.loadPic.Name = "loadPic";
            // 
            // ProductInfoContainer
            // 
            resources.ApplyResources(this.ProductInfoContainer, "ProductInfoContainer");
            this.ProductInfoContainer.BackColor = System.Drawing.Color.White;
            this.ProductInfoContainer.Name = "ProductInfoContainer";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.line, "line");
            this.line.Name = "line";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.POSActionGroup);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // POSActionGroup
            // 
            resources.ApplyResources(this.POSActionGroup, "POSActionGroup");
            this.POSActionGroup.BackColor = System.Drawing.Color.White;
            this.POSActionGroup.Controls.Add(this.OrderBtn);
            this.POSActionGroup.Controls.Add(this.settleAccBtn);
            this.POSActionGroup.Name = "POSActionGroup";
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OrderBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OrderBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.OrderBtn.BorderRadius = 5;
            this.OrderBtn.BorderSize = 2;
            this.OrderBtn.FlatAppearance.BorderSize = 0;
            this.OrderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.OrderBtn, "OrderBtn");
            this.OrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.OrderBtn.IsChecked = false;
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            this.OrderBtn.MouseLeave += new System.EventHandler(this.OrderBtn_MouseLeave);
            this.OrderBtn.MouseHover += new System.EventHandler(this.OrderBtn_MouseHover);
            // 
            // settleAccBtn
            // 
            this.settleAccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.settleAccBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.settleAccBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.settleAccBtn.BorderRadius = 5;
            this.settleAccBtn.BorderSize = 2;
            this.settleAccBtn.FlatAppearance.BorderSize = 0;
            this.settleAccBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.settleAccBtn, "settleAccBtn");
            this.settleAccBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.settleAccBtn.IsChecked = false;
            this.settleAccBtn.Name = "settleAccBtn";
            this.settleAccBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.settleAccBtn.UseVisualStyleBackColor = false;
            this.settleAccBtn.Click += new System.EventHandler(this.settleAccBtn_Click);
            this.settleAccBtn.MouseLeave += new System.EventHandler(this.settleAccBtn_MouseLeave);
            this.settleAccBtn.MouseHover += new System.EventHandler(this.settleAccBtn_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.SearchBar);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CatalogueCombox);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // CatalogueCombox
            // 
            this.CatalogueCombox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CatalogueCombox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CatalogueCombox.BackColor = System.Drawing.Color.White;
            this.CatalogueCombox.BorderColor = System.Drawing.Color.LightGray;
            this.CatalogueCombox.BorderRadius = 0;
            this.CatalogueCombox.BorderSize = 1;
            this.CatalogueCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CatalogueCombox, "CatalogueCombox");
            this.CatalogueCombox.ForeColor = System.Drawing.Color.SeaGreen;
            this.CatalogueCombox.IconColor = System.Drawing.Color.SeaGreen;
            this.CatalogueCombox.ListBackColor = System.Drawing.Color.White;
            this.CatalogueCombox.ListTextColor = System.Drawing.Color.DimGray;
            this.CatalogueCombox.Name = "CatalogueCombox";
            this.CatalogueCombox.Texts = "Catalogue";
            this.CatalogueCombox.UnderlinedStyle = false;
            this.CatalogueCombox.OnSelectedIndexChanged += new System.EventHandler(this.CatalogueCombox_OnSelectedIndexChanged);
            this.CatalogueCombox.Load += new System.EventHandler(this.CatalogueCombox_Load);
            // 
            // CartContainer
            // 
            this.CartContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.CartContainer.Controls.Add(this.panel7);
            this.CartContainer.Controls.Add(this.Header);
            this.CartContainer.Controls.Add(this.DiscountContainer);
            this.CartContainer.Controls.Add(this.panel2);
            this.CartContainer.Controls.Add(this.OrderBtnGroup);
            resources.ApplyResources(this.CartContainer, "CartContainer");
            this.CartContainer.Name = "CartContainer";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.CartItemGrid);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // CartItemGrid
            // 
            this.CartItemGrid.AllowUserToAddRows = false;
            this.CartItemGrid.AllowUserToOrderColumns = true;
            this.CartItemGrid.AllowUserToResizeColumns = false;
            this.CartItemGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CartItemGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CartItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartItemGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CartItemGrid.BackgroundColor = System.Drawing.Color.White;
            this.CartItemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CartItemGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CartItemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartItemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.CartItemGrid, "CartItemGrid");
            this.CartItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CartItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.sub,
            this.qty,
            this.plus,
            this.price,
            this.remarks,
            this.delete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartItemGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.CartItemGrid.EnableHeadersVisualStyles = false;
            this.CartItemGrid.GridColor = System.Drawing.Color.White;
            this.CartItemGrid.MultiSelect = false;
            this.CartItemGrid.Name = "CartItemGrid";
            this.CartItemGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartItemGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CartItemGrid.RowHeadersVisible = false;
            this.CartItemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.CartItemGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.CartItemGrid.RowTemplate.Height = 30;
            this.CartItemGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CartItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartItemGrid.StandardTab = true;
            this.CartItemGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartItemGrid_CellClick);
            this.CartItemGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGrid_CellEndEdit);
            this.CartItemGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.OrderDataGrid_DataError);
            this.CartItemGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.OrderDataGrid_EditingControlShowing);
            // 
            // userName
            // 
            this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userName.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userName.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.userName, "userName");
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sub
            // 
            this.sub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.sub, "sub");
            this.sub.Image = global::TheBetterLimited.Properties.Resources.minus;
            this.sub.Name = "sub";
            this.sub.ReadOnly = true;
            this.sub.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.DataPropertyName = "quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.qty.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.qty, "qty");
            this.qty.Name = "qty";
            // 
            // plus
            // 
            this.plus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.plus, "plus");
            this.plus.Image = global::TheBetterLimited.Properties.Resources.plus24;
            this.plus.Name = "plus";
            this.plus.ReadOnly = true;
            this.plus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // remarks
            // 
            this.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarks.DataPropertyName = "remark";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.remarks.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.remarks, "remarks");
            this.remarks.MaxInputLength = 50;
            this.remarks.Name = "remarks";
            this.remarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Image = global::TheBetterLimited.Properties.Resources.trash24;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Title);
            resources.ApplyResources(this.Header, "Header");
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Name = "Header";
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Name = "Title";
            // 
            // DiscountContainer
            // 
            this.DiscountContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DiscountContainer.Controls.Add(this.DiscountValue);
            this.DiscountContainer.Controls.Add(this.DiscountLabel);
            resources.ApplyResources(this.DiscountContainer, "DiscountContainer");
            this.DiscountContainer.Name = "DiscountContainer";
            // 
            // DiscountValue
            // 
            this.DiscountValue.BackColor = System.Drawing.Color.White;
            this.DiscountValue.BorderColor = System.Drawing.Color.Gainsboro;
            this.DiscountValue.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.DiscountValue.BorderRadius = 5;
            this.DiscountValue.BorderSize = 1;
            resources.ApplyResources(this.DiscountValue, "DiscountValue");
            this.DiscountValue.ForeColor = System.Drawing.Color.Gray;
            this.DiscountValue.IsError = false;
            this.DiscountValue.MaxLength = 3;
            this.DiscountValue.Multiline = false;
            this.DiscountValue.Name = "DiscountValue";
            this.DiscountValue.PasswordChar = false;
            this.DiscountValue.Placeholder = "0";
            this.DiscountValue.ReadOnly = false;
            this.DiscountValue.TbBackColor = System.Drawing.SystemColors.Window;
            this.DiscountValue.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.DiscountValue.Texts = "0";
            this.DiscountValue.UnderlinedStyle = false;
            this.DiscountValue._TextChanged += new System.EventHandler(this.DiscountValue__TextChanged);
            this.DiscountValue._Leave += new System.EventHandler(this.DiscountValue__Leave);
            // 
            // DiscountLabel
            // 
            resources.ApplyResources(this.DiscountLabel, "DiscountLabel");
            this.DiscountLabel.ForeColor = System.Drawing.Color.Gray;
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TotalAmountTxt);
            this.panel2.Controls.Add(this.AmountTitle);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // TotalAmountTxt
            // 
            resources.ApplyResources(this.TotalAmountTxt, "TotalAmountTxt");
            this.TotalAmountTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.TotalAmountTxt.Name = "TotalAmountTxt";
            this.TotalAmountTxt.UseMnemonic = false;
            // 
            // AmountTitle
            // 
            resources.ApplyResources(this.AmountTitle, "AmountTitle");
            this.AmountTitle.ForeColor = System.Drawing.Color.Black;
            this.AmountTitle.Name = "AmountTitle";
            this.AmountTitle.UseMnemonic = false;
            // 
            // OrderBtnGroup
            // 
            this.OrderBtnGroup.BackColor = System.Drawing.Color.White;
            this.OrderBtnGroup.Controls.Add(this.PayBtn);
            this.OrderBtnGroup.Controls.Add(this.ClearBtn);
            resources.ApplyResources(this.OrderBtnGroup, "OrderBtnGroup");
            this.OrderBtnGroup.Name = "OrderBtnGroup";
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.PayBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.PayBtn.BorderColor = System.Drawing.Color.Empty;
            this.PayBtn.BorderRadius = 5;
            this.PayBtn.BorderSize = 1;
            this.PayBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.PayBtn, "PayBtn");
            this.PayBtn.ForeColor = System.Drawing.Color.White;
            this.PayBtn.IsChecked = false;
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.TextColor = System.Drawing.Color.White;
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClearBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClearBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClearBtn.BorderRadius = 5;
            this.ClearBtn.BorderSize = 2;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            resources.ApplyResources(this.ClearBtn, "ClearBtn");
            this.ClearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClearBtn.IsChecked = false;
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            this.ClearBtn.MouseLeave += new System.EventHandler(this.CancelBtn_MouseLeave);
            this.ClearBtn.MouseHover += new System.EventHandler(this.CancelBtn_MouseHover);
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
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn4.DataPropertyName = "status";
            resources.ApplyResources(this.dataGridViewImageColumn4, "dataGridViewImageColumn4");
            this.dataGridViewImageColumn4.Image = global::TheBetterLimited.Properties.Resources.add_up;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn5.DataPropertyName = "status";
            resources.ApplyResources(this.dataGridViewImageColumn5, "dataGridViewImageColumn5");
            this.dataGridViewImageColumn5.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn6, "dataGridViewImageColumn6");
            this.dataGridViewImageColumn6.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ReadOnly = true;
            // 
            // POS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.ProductContainer);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.CartContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POS";
            this.SearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            this.ProductContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.POSActionGroup.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.CartContainer.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartItemGrid)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.DiscountContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.OrderBtnGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.Panel SearchBar;
        private CustomizeControl.CustomizeTextbox SearchBarTxt;
        private System.Windows.Forms.Panel ProductContainer;
        private System.Windows.Forms.FlowLayoutPanel OrderBtnGroup;
        private System.Windows.Forms.Panel CartContainer;
        private System.Windows.Forms.FlowLayoutPanel POSActionGroup;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView CartItemGrid;
        private CustomizeControl.RoundButton ClearBtn;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel DiscountContainer;
        private CustomizeControl.RoundButton PayBtn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.Label DiscountLabel;
        private CustomizeControl.CustomizeTextbox DiscountValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AmountTitle;
        private System.Windows.Forms.Label TotalAmountTxt;
        private CustomizeControl.RoundButton OrderBtn;
        private CustomizeControl.RoundButton settleAccBtn;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private CustomizeControl.CustomizeComboBox CatalogueCombox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.FlowLayoutPanel ProductInfoContainer;
        private System.Windows.Forms.Panel loadPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewImageColumn sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewImageColumn plus;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}