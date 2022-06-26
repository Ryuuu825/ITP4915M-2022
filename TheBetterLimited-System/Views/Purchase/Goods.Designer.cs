namespace TheBetterLimited.Views
{
    partial class Goods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goods));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GoodsDataGrid = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBarTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.curdAction = new System.Windows.Forms.Panel();
            this.exportBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.DeleteBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.AddBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.Header = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Panel();
            this.loadPic = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTINCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGrid)).BeginInit();
            this.Action.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.curdAction.SuspendLayout();
            this.Header.SuspendLayout();
            this.Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoodsDataGrid
            // 
            resources.ApplyResources(this.GoodsDataGrid, "GoodsDataGrid");
            this.GoodsDataGrid.AllowUserToAddRows = false;
            this.GoodsDataGrid.AllowUserToResizeColumns = false;
            this.GoodsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.GoodsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.GoodsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GoodsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GoodsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.GoodsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GoodsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GoodsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GoodsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GoodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GoodsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.id,
            this.catalogue,
            this.name,
            this.price,
            this.gTINCode,
            this.Size,
            this.Status,
            this.edit,
            this.delete});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GoodsDataGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.GoodsDataGrid.EnableHeadersVisualStyles = false;
            this.GoodsDataGrid.GridColor = System.Drawing.Color.White;
            this.GoodsDataGrid.MultiSelect = false;
            this.GoodsDataGrid.Name = "GoodsDataGrid";
            this.GoodsDataGrid.ReadOnly = true;
            this.GoodsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GoodsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GoodsDataGrid.RowHeadersVisible = false;
            this.GoodsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.GoodsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.GoodsDataGrid.RowTemplate.Height = 30;
            this.GoodsDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GoodsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GoodsDataGrid.StandardTab = true;
            this.GoodsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoodsDataGrid_CellClick);
            this.GoodsDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GoodsDataGrid_CellFormatting);
            // 
            // Action
            // 
            resources.ApplyResources(this.Action, "Action");
            this.Action.BackColor = System.Drawing.Color.White;
            this.Action.Controls.Add(this.panel1);
            this.Action.Name = "Action";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.SearchBar);
            this.panel1.Controls.Add(this.curdAction);
            this.panel1.Name = "panel1";
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
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // curdAction
            // 
            resources.ApplyResources(this.curdAction, "curdAction");
            this.curdAction.Controls.Add(this.exportBtn);
            this.curdAction.Controls.Add(this.DeleteBtn);
            this.curdAction.Controls.Add(this.AddBtn);
            this.curdAction.Name = "curdAction";
            this.curdAction.Paint += new System.Windows.Forms.PaintEventHandler(this.curdAction_Paint);
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
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
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
            // Header
            // 
            resources.ApplyResources(this.Header, "Header");
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.closeBtn);
            this.Header.Controls.Add(this.RefreshBtn);
            this.Header.Controls.Add(this.Title);
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Name = "Header";
            // 
            // closeBtn
            // 
            resources.ApplyResources(this.closeBtn, "closeBtn");
            this.closeBtn.BackgroundImage = global::TheBetterLimited.Properties.Resources.close32;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RefreshBtn
            // 
            resources.ApplyResources(this.RefreshBtn, "RefreshBtn");
            this.RefreshBtn.BackgroundImage = global::TheBetterLimited.Properties.Resources.rotate_right;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
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
            this.Data.Controls.Add(this.GoodsDataGrid);
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
            this.dataGridViewImageColumn4.Image = global::TheBetterLimited.Properties.Resources.square24;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn5, "dataGridViewImageColumn5");
            this.dataGridViewImageColumn5.Image = global::TheBetterLimited.Properties.Resources.pencil;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn6, "dataGridViewImageColumn6");
            this.dataGridViewImageColumn6.Image = global::TheBetterLimited.Properties.Resources.trash24;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ReadOnly = true;
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
            this.id.DataPropertyName = "Id";
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // catalogue
            // 
            this.catalogue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.catalogue.DataPropertyName = "Catalogue";
            resources.ApplyResources(this.catalogue, "catalogue");
            this.catalogue.Name = "catalogue";
            this.catalogue.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.name.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.DataPropertyName = "Price";
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // gTINCode
            // 
            this.gTINCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gTINCode.DataPropertyName = "GTINCode";
            resources.ApplyResources(this.gTINCode, "gTINCode");
            this.gTINCode.Name = "gTINCode";
            this.gTINCode.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Size.DataPropertyName = "Size";
            resources.ApplyResources(this.Size, "Size");
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.edit, "edit");
            this.edit.Image = global::TheBetterLimited.Properties.Resources.pencil;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Image = global::TheBetterLimited.Properties.Resources.trash24;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // Goods
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Goods";
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGrid)).EndInit();
            this.Action.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.curdAction.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GoodsDataGrid;
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
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Panel loadPic;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewImageColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogue;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTINCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}