﻿namespace TheBetterLimited.Views
{
    partial class Appointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AppointmentDataGrid = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.Panel();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.RefreshBtn = new FontAwesome.Sharp.IconButton();
            this.Title = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Action = new System.Windows.Forms.Panel();
            this.DeliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBarTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._departmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._teamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewImageColumn();
            this.print = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGrid)).BeginInit();
            this.Header.SuspendLayout();
            this.Data.SuspendLayout();
            this.Action.SuspendLayout();
            this.SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentDataGrid
            // 
            this.AppointmentDataGrid.AllowUserToAddRows = false;
            this.AppointmentDataGrid.AllowUserToResizeColumns = false;
            this.AppointmentDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.AppointmentDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AppointmentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AppointmentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppointmentDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AppointmentDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AppointmentDataGrid.ColumnHeadersHeight = 50;
            this.AppointmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AppointmentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.id,
            this.time,
            this._departmentId,
            this.Address,
            this._teamId,
            this.Status,
            this.details,
            this.print});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.AppointmentDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointmentDataGrid.EnableHeadersVisualStyles = false;
            this.AppointmentDataGrid.GridColor = System.Drawing.Color.White;
            this.AppointmentDataGrid.Location = new System.Drawing.Point(0, 2);
            this.AppointmentDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.AppointmentDataGrid.MultiSelect = false;
            this.AppointmentDataGrid.Name = "AppointmentDataGrid";
            this.AppointmentDataGrid.ReadOnly = true;
            this.AppointmentDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AppointmentDataGrid.RowHeadersVisible = false;
            this.AppointmentDataGrid.RowHeadersWidth = 30;
            this.AppointmentDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.AppointmentDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.AppointmentDataGrid.RowTemplate.Height = 30;
            this.AppointmentDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentDataGrid.Size = new System.Drawing.Size(758, 363);
            this.AppointmentDataGrid.StandardTab = true;
            this.AppointmentDataGrid.TabIndex = 3;
            this.AppointmentDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoodsDataGrid_CellClick);
            this.AppointmentDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GoodsDataGrid_CellFormatting);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Controls.Add(this.RefreshBtn);
            this.Header.Controls.Add(this.Title);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(10, 10);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(758, 40);
            this.Header.TabIndex = 5;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseBtn.IconColor = System.Drawing.Color.Black;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.IconSize = 25;
            this.CloseBtn.Location = new System.Drawing.Point(716, 4);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(39, 36);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.RefreshBtn.IconColor = System.Drawing.Color.Black;
            this.RefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefreshBtn.IconSize = 25;
            this.RefreshBtn.Location = new System.Drawing.Point(678, 4);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(39, 36);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(2, 7);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(131, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Appointment";
            // 
            // Data
            // 
            this.Data.Controls.Add(this.AppointmentDataGrid);
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(10, 90);
            this.Data.Margin = new System.Windows.Forms.Padding(2);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Data.Size = new System.Drawing.Size(758, 365);
            this.Data.TabIndex = 8;
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
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::TheBetterLimited.Properties.Resources.square;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.MinimumWidth = 6;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.Image = global::TheBetterLimited.Properties.Resources.pencil_free_icon_font;
            this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn5.MinimumWidth = 6;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.ToolTipText = "Edit";
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn6.HeaderText = "";
            this.dataGridViewImageColumn6.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.dataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn6.MinimumWidth = 6;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ReadOnly = true;
            this.dataGridViewImageColumn6.ToolTipText = "Delete";
            // 
            // Action
            // 
            this.Action.BackColor = System.Drawing.Color.White;
            this.Action.Controls.Add(this.DeliveryDatePicker);
            this.Action.Controls.Add(this.SearchBar);
            this.Action.Dock = System.Windows.Forms.DockStyle.Top;
            this.Action.Location = new System.Drawing.Point(10, 50);
            this.Action.Margin = new System.Windows.Forms.Padding(2);
            this.Action.Name = "Action";
            this.Action.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Action.Size = new System.Drawing.Size(758, 40);
            this.Action.TabIndex = 7;
            // 
            // DeliveryDatePicker
            // 
            this.DeliveryDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryDatePicker.CalendarTitleBackColor = System.Drawing.Color.MediumSeaGreen;
            this.DeliveryDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryDatePicker.Location = new System.Drawing.Point(7, 6);
            this.DeliveryDatePicker.Name = "DeliveryDatePicker";
            this.DeliveryDatePicker.Size = new System.Drawing.Size(188, 29);
            this.DeliveryDatePicker.TabIndex = 10;
            this.DeliveryDatePicker.ValueChanged += new System.EventHandler(this.DeliveryDatePicker_ValueChanged);
            // 
            // SearchBar
            // 
            this.SearchBar.Controls.Add(this.pictureBox1);
            this.SearchBar.Controls.Add(this.SearchBarTxt);
            this.SearchBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBar.Location = new System.Drawing.Point(534, 1);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(220, 38);
            this.SearchBar.TabIndex = 10;
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
            this.SearchBarTxt.Size = new System.Drawing.Size(220, 38);
            this.SearchBarTxt.TabIndex = 9;
            this.SearchBarTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.SearchBarTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.SearchBarTxt.Texts = "Search";
            this.SearchBarTxt.UnderlinedStyle = false;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.select.HeaderText = "";
            this.select.Image = global::TheBetterLimited.Properties.Resources.square;
            this.select.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Width = 6;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Appointment ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "Appointment ID";
            this.id.Width = 144;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.ToolTipText = "Session Time";
            this.time.Width = 75;
            // 
            // _departmentId
            // 
            this._departmentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._departmentId.DataPropertyName = "OrderId";
            this._departmentId.HeaderText = "Order ID";
            this._departmentId.MinimumWidth = 6;
            this._departmentId.Name = "_departmentId";
            this._departmentId.ReadOnly = true;
            this._departmentId.ToolTipText = "Order ID";
            this._departmentId.Width = 98;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "address";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Address.DefaultCellStyle = dataGridViewCellStyle3;
            this.Address.HeaderText = "Customer Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.ToolTipText = "Customer Address";
            // 
            // _teamId
            // 
            this._teamId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._teamId.DataPropertyName = "_teamId";
            this._teamId.HeaderText = "Team ID";
            this._teamId.MinimumWidth = 6;
            this._teamId.Name = "_teamId";
            this._teamId.ReadOnly = true;
            this._teamId.ToolTipText = "Team ID";
            this._teamId.Width = 95;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.details.HeaderText = "";
            this.details.Image = global::TheBetterLimited.Properties.Resources.eye;
            this.details.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.details.MinimumWidth = 6;
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.ToolTipText = "Edit";
            this.details.Width = 6;
            // 
            // print
            // 
            this.print.HeaderText = "";
            this.print.Image = global::TheBetterLimited.Properties.Resources.print24;
            this.print.Name = "print";
            this.print.ReadOnly = true;
            this.print.ToolTipText = "Print";
            // 
            // Appointment
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
            this.Name = "Appointment";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "InventoryManagement";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGrid)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Data.ResumeLayout(false);
            this.Action.ResumeLayout(false);
            this.SearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView AppointmentDataGrid;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Title;
        private FontAwesome.Sharp.IconButton RefreshBtn;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private System.Windows.Forms.Panel Data;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.Panel Action;
        private System.Windows.Forms.Panel SearchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomizeControl.CustomizeTextbox SearchBarTxt;
        private System.Windows.Forms.DateTimePicker DeliveryDatePicker;
        private System.Windows.Forms.DataGridViewImageColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn _departmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn details;
        private System.Windows.Forms.DataGridViewImageColumn print;
    }
}