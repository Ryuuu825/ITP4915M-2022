﻿namespace TheBetterLimited.Views
{
    partial class Setting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.UserDataGrid = new System.Windows.Forms.DataGridView();
            this.Seleted = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._StaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Action = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBarTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.curdAction = new System.Windows.Forms.Panel();
            this.UnlockBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.LockBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.DeleteBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.AddBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.Header = new System.Windows.Forms.Panel();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.RefreshBtn = new FontAwesome.Sharp.IconButton();
            this.Title = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).BeginInit();
            this.Action.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.curdAction.SuspendLayout();
            this.Header.SuspendLayout();
            this.Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDataGrid
            // 
            this.UserDataGrid.AllowUserToAddRows = false;
            this.UserDataGrid.AllowUserToOrderColumns = true;
            this.UserDataGrid.AllowUserToResizeColumns = false;
            this.UserDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.UserDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.UserDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserDataGrid.ColumnHeadersHeight = 50;
            this.UserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UserDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleted,
            this.id,
            this.userName,
            this.staffName,
            this.emailAddress,
            this.status,
            this._StaffId,
            this.remarks,
            this.edit,
            this.delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDataGrid.EnableHeadersVisualStyles = false;
            this.UserDataGrid.GridColor = System.Drawing.Color.White;
            this.UserDataGrid.Location = new System.Drawing.Point(0, 2);
            this.UserDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.UserDataGrid.Name = "UserDataGrid";
            this.UserDataGrid.ReadOnly = true;
            this.UserDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserDataGrid.RowHeadersVisible = false;
            this.UserDataGrid.RowHeadersWidth = 30;
            this.UserDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.UserDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UserDataGrid.RowTemplate.Height = 30;
            this.UserDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGrid.Size = new System.Drawing.Size(778, 379);
            this.UserDataGrid.TabIndex = 3;
            this.UserDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGrid_CellClick);
            this.UserDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.UserDataGrid_CellFormatting);
            // 
            // Seleted
            // 
            this.Seleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Seleted.HeaderText = "";
            this.Seleted.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Seleted.MinimumWidth = 6;
            this.Seleted.Name = "Seleted";
            this.Seleted.ReadOnly = true;
            this.Seleted.ToolTipText = "Select";
            this.Seleted.Width = 6;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "User ID";
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "User Name";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.ToolTipText = "User Name";
            // 
            // staffName
            // 
            this.staffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.staffName.DataPropertyName = "staffName";
            this.staffName.HeaderText = "Staff Name";
            this.staffName.MinimumWidth = 6;
            this.staffName.Name = "staffName";
            this.staffName.ReadOnly = true;
            this.staffName.ToolTipText = "Staff Name";
            this.staffName.Width = 113;
            // 
            // emailAddress
            // 
            this.emailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailAddress.DataPropertyName = "emailAddress";
            this.emailAddress.HeaderText = "Email Address";
            this.emailAddress.MinimumWidth = 6;
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.ReadOnly = true;
            this.emailAddress.ToolTipText = "Email Address";
            this.emailAddress.Width = 131;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.ToolTipText = "Account Status";
            // 
            // _StaffId
            // 
            this._StaffId.DataPropertyName = "_StaffId";
            this._StaffId.HeaderText = "Staff ID";
            this._StaffId.MinimumWidth = 6;
            this._StaffId.Name = "_StaffId";
            this._StaffId.ReadOnly = true;
            this._StaffId.ToolTipText = "Staff ID";
            // 
            // remarks
            // 
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "Remark";
            this.remarks.MinimumWidth = 6;
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            this.remarks.ToolTipText = "Remark of Account";
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = global::TheBetterLimited.Properties.Resources.pencil_free_icon_font;
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.ToolTipText = "Edit";
            this.edit.Width = 16;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.delete.HeaderText = "";
            this.delete.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.ToolTipText = "Delete";
            this.delete.Width = 6;
            // 
            // Action
            // 
            this.Action.BackColor = System.Drawing.Color.White;
            this.Action.Controls.Add(this.panel1);
            this.Action.Dock = System.Windows.Forms.DockStyle.Top;
            this.Action.Location = new System.Drawing.Point(0, 40);
            this.Action.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Action.Name = "Action";
            this.Action.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Action.Size = new System.Drawing.Size(778, 44);
            this.Action.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchBar);
            this.panel1.Controls.Add(this.curdAction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 38);
            this.panel1.TabIndex = 6;
            // 
            // SearchBar
            // 
            this.SearchBar.Controls.Add(this.pictureBox1);
            this.SearchBar.Controls.Add(this.SearchBarTxt);
            this.SearchBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBar.Location = new System.Drawing.Point(550, 0);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(220, 38);
            this.SearchBar.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.SearchBarTxt.Location = new System.Drawing.Point(0, 0);
            this.SearchBarTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SearchBarTxt.MaxLength = 20;
            this.SearchBarTxt.Multiline = true;
            this.SearchBarTxt.Name = "SearchBarTxt";
            this.SearchBarTxt.Padding = new System.Windows.Forms.Padding(22, 8, 8, 6);
            this.SearchBarTxt.PasswordChar = false;
            this.SearchBarTxt.Size = new System.Drawing.Size(220, 38);
            this.SearchBarTxt.TabIndex = 9;
            this.SearchBarTxt.Texts = "Search";
            this.SearchBarTxt.UnderlinedStyle = false;
            this.SearchBarTxt._TextChanged += new System.EventHandler(this.SearchBarTxt__TextChanged);
            this.SearchBarTxt.Enter += new System.EventHandler(this.SearchBarTxt_Enter);
            this.SearchBarTxt.Leave += new System.EventHandler(this.SearchBarTxt_Leave);
            // 
            // curdAction
            // 
            this.curdAction.Controls.Add(this.UnlockBtn);
            this.curdAction.Controls.Add(this.LockBtn);
            this.curdAction.Controls.Add(this.DeleteBtn);
            this.curdAction.Controls.Add(this.AddBtn);
            this.curdAction.Dock = System.Windows.Forms.DockStyle.Left;
            this.curdAction.Location = new System.Drawing.Point(0, 0);
            this.curdAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.curdAction.Name = "curdAction";
            this.curdAction.Size = new System.Drawing.Size(773, 38);
            this.curdAction.TabIndex = 6;
            // 
            // UnlockBtn
            // 
            this.UnlockBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.UnlockBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.UnlockBtn.BorderColor = System.Drawing.Color.White;
            this.UnlockBtn.BorderRadius = 10;
            this.UnlockBtn.BorderSize = 0;
            this.UnlockBtn.FlatAppearance.BorderSize = 0;
            this.UnlockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnlockBtn.Font = new System.Drawing.Font("Segoe UI", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockBtn.ForeColor = System.Drawing.Color.White;
            this.UnlockBtn.Location = new System.Drawing.Point(292, 0);
            this.UnlockBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UnlockBtn.Name = "UnlockBtn";
            this.UnlockBtn.Size = new System.Drawing.Size(80, 38);
            this.UnlockBtn.TabIndex = 6;
            this.UnlockBtn.Text = "Unlock";
            this.UnlockBtn.TextColor = System.Drawing.Color.White;
            this.UnlockBtn.UseVisualStyleBackColor = false;
            this.UnlockBtn.Click += new System.EventHandler(this.UnlockBtn_Click);
            // 
            // LockBtn
            // 
            this.LockBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.LockBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.LockBtn.BorderColor = System.Drawing.Color.White;
            this.LockBtn.BorderRadius = 10;
            this.LockBtn.BorderSize = 0;
            this.LockBtn.FlatAppearance.BorderSize = 0;
            this.LockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LockBtn.Font = new System.Drawing.Font("Segoe UI", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockBtn.ForeColor = System.Drawing.Color.White;
            this.LockBtn.Location = new System.Drawing.Point(208, 0);
            this.LockBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LockBtn.Name = "LockBtn";
            this.LockBtn.Size = new System.Drawing.Size(80, 38);
            this.LockBtn.TabIndex = 5;
            this.LockBtn.Text = "Lock";
            this.LockBtn.TextColor = System.Drawing.Color.White;
            this.LockBtn.UseVisualStyleBackColor = false;
            this.LockBtn.Click += new System.EventHandler(this.LockBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DeleteBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DeleteBtn.BorderColor = System.Drawing.Color.White;
            this.DeleteBtn.BorderRadius = 10;
            this.DeleteBtn.BorderSize = 0;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(95, 0);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(108, 38);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete Seleted";
            this.DeleteBtn.TextColor = System.Drawing.Color.White;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.AddBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.AddBtn.BorderColor = System.Drawing.Color.White;
            this.AddBtn.BorderRadius = 10;
            this.AddBtn.BorderSize = 0;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = global::TheBetterLimited.Properties.Resources.add;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(1, 0);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AddBtn.Size = new System.Drawing.Size(90, 38);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "      New";
            this.AddBtn.TextColor = System.Drawing.Color.White;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Controls.Add(this.RefreshBtn);
            this.Header.Controls.Add(this.Title);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(778, 40);
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
            this.CloseBtn.Location = new System.Drawing.Point(736, 4);
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
            this.RefreshBtn.Location = new System.Drawing.Point(698, 4);
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
            this.Title.Text = "User Account";
            // 
            // Data
            // 
            this.Data.Controls.Add(this.UserDataGrid);
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(0, 84);
            this.Data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Data.Size = new System.Drawing.Size(778, 381);
            this.Data.TabIndex = 8;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn1.HeaderText = "Details";
            this.dataGridViewImageColumn1.Image = global::TheBetterLimited.Properties.Resources.pencil_free_icon_font;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.ToolTipText = "Edit";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.ToolTipText = "Delete";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.ToolTipText = "Delete";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(778, 465);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Setting";
            this.Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView UserDataGrid;
        private CustomizeControl.RoundButton DeleteBtn;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Action;
        private FontAwesome.Sharp.IconButton RefreshBtn;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private System.Windows.Forms.Panel Data;
        private System.Windows.Forms.Panel curdAction;
        private CustomizeControl.RoundButton LockBtn;
        private CustomizeControl.RoundButton AddBtn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SearchBar;
        private CustomizeControl.CustomizeTextbox SearchBarTxt;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton UnlockBtn;
        private System.Windows.Forms.DataGridViewImageColumn Seleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn _StaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}