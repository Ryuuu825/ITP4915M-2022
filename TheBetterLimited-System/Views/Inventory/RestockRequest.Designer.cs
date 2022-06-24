namespace TheBetterLimited.Views
{
    partial class RestockRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestockRequest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RestockRequestDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._createrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._operatorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._storeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.SearchBarTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.curdAction = new System.Windows.Forms.Panel();
            this.exportBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.DeleteBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.Header = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.closeBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RestockRequestDataGrid)).BeginInit();
            this.Action.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchBar.SuspendLayout();
            this.curdAction.SuspendLayout();
            this.Header.SuspendLayout();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RestockRequestDataGrid
            // 
            resources.ApplyResources(this.RestockRequestDataGrid, "RestockRequestDataGrid");
            this.RestockRequestDataGrid.AllowUserToAddRows = false;
            this.RestockRequestDataGrid.AllowUserToResizeColumns = false;
            this.RestockRequestDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.RestockRequestDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.RestockRequestDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RestockRequestDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RestockRequestDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RestockRequestDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RestockRequestDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RestockRequestDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.RestockRequestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RestockRequestDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.id,
            this._createrId,
            this._operatorId,
            this._storeId,
            this.createTime,
            this.operateTime,
            this.Status,
            this.edit,
            this.delete});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RestockRequestDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.RestockRequestDataGrid.EnableHeadersVisualStyles = false;
            this.RestockRequestDataGrid.GridColor = System.Drawing.Color.White;
            this.RestockRequestDataGrid.MultiSelect = false;
            this.RestockRequestDataGrid.Name = "RestockRequestDataGrid";
            this.RestockRequestDataGrid.ReadOnly = true;
            this.RestockRequestDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RestockRequestDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.RestockRequestDataGrid.RowHeadersVisible = false;
            this.RestockRequestDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.RestockRequestDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.RestockRequestDataGrid.RowTemplate.Height = 30;
            this.RestockRequestDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RestockRequestDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RestockRequestDataGrid.StandardTab = true;
            this.RestockRequestDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoodsDataGrid_CellClick);
            this.RestockRequestDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GoodsDataGrid_CellFormatting);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "Id";
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // _createrId
            // 
            this._createrId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._createrId.DataPropertyName = "_createrId";
            resources.ApplyResources(this._createrId, "_createrId");
            this._createrId.Name = "_createrId";
            this._createrId.ReadOnly = true;
            // 
            // _operatorId
            // 
            this._operatorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._operatorId.DataPropertyName = "_operatorId";
            resources.ApplyResources(this._operatorId, "_operatorId");
            this._operatorId.Name = "_operatorId";
            this._operatorId.ReadOnly = true;
            // 
            // _storeId
            // 
            this._storeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._storeId.DataPropertyName = "_storeId";
            resources.ApplyResources(this._storeId, "_storeId");
            this._storeId.Name = "_storeId";
            this._storeId.ReadOnly = true;
            // 
            // createTime
            // 
            this.createTime.DataPropertyName = "createTime";
            resources.ApplyResources(this.createTime, "createTime");
            this.createTime.Name = "createTime";
            this.createTime.ReadOnly = true;
            // 
            // operateTime
            // 
            this.operateTime.DataPropertyName = "operateTime";
            resources.ApplyResources(this.operateTime, "operateTime");
            this.operateTime.Name = "operateTime";
            this.operateTime.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
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
            this.SearchBarTxt.Placeholder = "";
            this.SearchBarTxt.ReadOnly = false;
            this.SearchBarTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.SearchBarTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.SearchBarTxt.Texts = "Search";
            this.SearchBarTxt.UnderlinedStyle = false;
            this.SearchBarTxt._TextChanged += new System.EventHandler(this.SearchBarTxt__TextChanged);
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
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Name = "Title";
            // 
            // Data
            // 
            resources.ApplyResources(this.Data, "Data");
            this.Data.Controls.Add(this.RestockRequestDataGrid);
            this.Data.Name = "Data";
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
            this.dataGridViewImageColumn4.Image = global::TheBetterLimited.Properties.Resources.square;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn5, "dataGridViewImageColumn5");
            this.dataGridViewImageColumn5.Image = global::TheBetterLimited.Properties.Resources.pencil_free_icon_font;
            this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn6, "dataGridViewImageColumn6");
            this.dataGridViewImageColumn6.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.dataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ReadOnly = true;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.select, "select");
            this.select.Image = global::TheBetterLimited.Properties.Resources.square;
            this.select.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.select.Name = "select";
            this.select.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.edit, "edit");
            this.edit.Image = global::TheBetterLimited.Properties.Resources.pencil_free_icon_font;
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
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
            // RestockRequest
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestockRequest";
            ((System.ComponentModel.ISupportInitialize)(this.RestockRequestDataGrid)).EndInit();
            this.Action.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SearchBar.ResumeLayout(false);
            this.curdAction.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView RestockRequestDataGrid;
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
        private System.Windows.Forms.DataGridViewImageColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _createrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn _operatorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn _storeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn operateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
    }
}