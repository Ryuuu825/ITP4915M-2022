namespace TheBetterLimited.Views
{
    partial class RestockRequest_Add
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
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnAddRestockRequest = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.RestockRequestInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStatus = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCreatorId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.Info = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.txtStoreId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblOperateTime = new System.Windows.Forms.Label();
            this.lblCreateTime = new System.Windows.Forms.Label();
            this.txtId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblOperatorId = new System.Windows.Forms.Label();
            this.lblCreatorId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblStoreId = new System.Windows.Forms.Label();
            this.txtOperatorId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.RestockRequestInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.RestockRequestInfoHeader = new System.Windows.Forms.Label();
            this.dtpCreateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpOperateTime = new System.Windows.Forms.DateTimePicker();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.RestockRequestInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.RestockRequestInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.btnCancel);
            this.BottomBtn.Controls.Add(this.btnAddRestockRequest);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 472);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(764, 54);
            this.BottomBtn.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(182)))), ((int)(((byte)(99)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IsChecked = false;
            this.btnCancel.Location = new System.Drawing.Point(478, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // btnAddRestockRequest
            // 
            this.btnAddRestockRequest.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddRestockRequest.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddRestockRequest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddRestockRequest.BorderRadius = 10;
            this.btnAddRestockRequest.BorderSize = 0;
            this.btnAddRestockRequest.FlatAppearance.BorderSize = 0;
            this.btnAddRestockRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRestockRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRestockRequest.ForeColor = System.Drawing.Color.White;
            this.btnAddRestockRequest.IsChecked = false;
            this.btnAddRestockRequest.Location = new System.Drawing.Point(623, 6);
            this.btnAddRestockRequest.Name = "btnAddRestockRequest";
            this.btnAddRestockRequest.Size = new System.Drawing.Size(128, 40);
            this.btnAddRestockRequest.TabIndex = 6;
            this.btnAddRestockRequest.Text = "Create";
            this.btnAddRestockRequest.TextColor = System.Drawing.Color.White;
            this.btnAddRestockRequest.UseVisualStyleBackColor = false;
            this.btnAddRestockRequest.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.RestockRequestInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(784, 536);
            this.MainForm.TabIndex = 2;
            // 
            // RestockRequestInfo
            // 
            this.RestockRequestInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RestockRequestInfo.Controls.Add(this.panel1);
            this.RestockRequestInfo.Controls.Add(this.RestockRequestInfoHeaderContainer);
            this.RestockRequestInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.RestockRequestInfo.Location = new System.Drawing.Point(10, 10);
            this.RestockRequestInfo.Name = "RestockRequestInfo";
            this.RestockRequestInfo.Size = new System.Drawing.Size(764, 457);
            this.RestockRequestInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpOperateTime);
            this.panel1.Controls.Add(this.dtpCreateTime);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtCreatorId);
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.txtStoreId);
            this.panel1.Controls.Add(this.lblOperateTime);
            this.panel1.Controls.Add(this.lblCreateTime);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblOperatorId);
            this.panel1.Controls.Add(this.lblCreatorId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblStoreId);
            this.panel1.Controls.Add(this.txtOperatorId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 417);
            this.panel1.TabIndex = 27;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.BorderColor = System.Drawing.Color.LightGray;
            this.txtStatus.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtStatus.BorderRadius = 10;
            this.txtStatus.BorderSize = 1;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.LightGray;
            this.txtStatus.IsError = false;
            this.txtStatus.Location = new System.Drawing.Point(198, 346);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.Multiline = false;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStatus.PasswordChar = false;
            this.txtStatus.Placeholder = "Please enter the reorder level";
            this.txtStatus.ReadOnly = false;
            this.txtStatus.Size = new System.Drawing.Size(307, 38);
            this.txtStatus.TabIndex = 43;
            this.txtStatus.TbBackColor = System.Drawing.Color.White;
            this.txtStatus.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtStatus.Texts = "Please enter the reorder level";
            this.txtStatus.UnderlinedStyle = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(72, 355);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 21);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCreatorId
            // 
            this.txtCreatorId.BackColor = System.Drawing.Color.White;
            this.txtCreatorId.BorderColor = System.Drawing.Color.LightGray;
            this.txtCreatorId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtCreatorId.BorderRadius = 10;
            this.txtCreatorId.BorderSize = 1;
            this.txtCreatorId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatorId.ForeColor = System.Drawing.Color.LightGray;
            this.txtCreatorId.IsError = false;
            this.txtCreatorId.Location = new System.Drawing.Point(197, 67);
            this.txtCreatorId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCreatorId.MaxLength = 32767;
            this.txtCreatorId.Multiline = false;
            this.txtCreatorId.Name = "txtCreatorId";
            this.txtCreatorId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCreatorId.PasswordChar = false;
            this.txtCreatorId.Placeholder = "Automatically generated";
            this.txtCreatorId.ReadOnly = false;
            this.txtCreatorId.Size = new System.Drawing.Size(307, 38);
            this.txtCreatorId.TabIndex = 41;
            this.txtCreatorId.TbBackColor = System.Drawing.Color.White;
            this.txtCreatorId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtCreatorId.Texts = "Automatically generated";
            this.txtCreatorId.UnderlinedStyle = false;
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(521, 44);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(240, 76);
            this.Info.TabIndex = 5;
            this.Info.Text = "Restock Request is required when your stock is below restock level for restocking" +
    " purpose";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.SeaGreen;
            this.Title.Location = new System.Drawing.Point(521, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(241, 30);
            this.Title.TabIndex = 3;
            this.Title.Text = "Create Restock Request";
            // 
            // txtStoreId
            // 
            this.txtStoreId.BackColor = System.Drawing.Color.White;
            this.txtStoreId.BorderColor = System.Drawing.Color.LightGray;
            this.txtStoreId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtStoreId.BorderRadius = 10;
            this.txtStoreId.BorderSize = 1;
            this.txtStoreId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreId.ForeColor = System.Drawing.Color.LightGray;
            this.txtStoreId.IsError = false;
            this.txtStoreId.Location = new System.Drawing.Point(197, 173);
            this.txtStoreId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStoreId.MaxLength = 32767;
            this.txtStoreId.Multiline = false;
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStoreId.PasswordChar = false;
            this.txtStoreId.Placeholder = "Please enter the quantity";
            this.txtStoreId.ReadOnly = false;
            this.txtStoreId.Size = new System.Drawing.Size(307, 38);
            this.txtStoreId.TabIndex = 40;
            this.txtStoreId.TbBackColor = System.Drawing.Color.White;
            this.txtStoreId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtStoreId.Texts = "Please enter the quantity";
            this.txtStoreId.UnderlinedStyle = false;
            // 
            // lblOperateTime
            // 
            this.lblOperateTime.AutoSize = true;
            this.lblOperateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperateTime.Location = new System.Drawing.Point(46, 294);
            this.lblOperateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperateTime.Name = "lblOperateTime";
            this.lblOperateTime.Size = new System.Drawing.Size(104, 21);
            this.lblOperateTime.TabIndex = 30;
            this.lblOperateTime.Text = "Operate Time";
            this.lblOperateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.AutoSize = true;
            this.lblCreateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTime.Location = new System.Drawing.Point(52, 233);
            this.lblCreateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.Size = new System.Drawing.Size(93, 21);
            this.lblCreateTime.TabIndex = 28;
            this.lblCreateTime.Text = "Create Time";
            this.lblCreateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.LightGray;
            this.txtId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtId.BorderRadius = 10;
            this.txtId.BorderSize = 1;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.IsError = false;
            this.txtId.Location = new System.Drawing.Point(197, 14);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtId.MaxLength = 5;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtId.PasswordChar = false;
            this.txtId.Placeholder = "Automatically Generated";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(307, 38);
            this.txtId.TabIndex = 1;
            this.txtId.TbBackColor = System.Drawing.Color.White;
            this.txtId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtId.Texts = "Automatically Generated";
            this.txtId.UnderlinedStyle = false;
            this.txtId._TextChanged += new System.EventHandler(this.StaffIDTxt__TextChanged);
            this.txtId.Click += new System.EventHandler(this.StaffIDTxt_Click);
            this.txtId.Enter += new System.EventHandler(this.StaffIDTxt_Enter);
            this.txtId.Leave += new System.EventHandler(this.StaffIDTxt_Leave);
            // 
            // lblOperatorId
            // 
            this.lblOperatorId.AutoSize = true;
            this.lblOperatorId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorId.Location = new System.Drawing.Point(52, 126);
            this.lblOperatorId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperatorId.Name = "lblOperatorId";
            this.lblOperatorId.Size = new System.Drawing.Size(92, 21);
            this.lblOperatorId.TabIndex = 3;
            this.lblOperatorId.Text = "Operator ID";
            this.lblOperatorId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreatorId
            // 
            this.lblCreatorId.AutoSize = true;
            this.lblCreatorId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatorId.Location = new System.Drawing.Point(58, 76);
            this.lblCreatorId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatorId.Name = "lblCreatorId";
            this.lblCreatorId.Size = new System.Drawing.Size(80, 21);
            this.lblCreatorId.TabIndex = 2;
            this.lblCreatorId.Text = "Creater ID";
            this.lblCreatorId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(82, 23);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 21);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID*";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStoreId
            // 
            this.lblStoreId.AutoSize = true;
            this.lblStoreId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreId.Location = new System.Drawing.Point(66, 182);
            this.lblStoreId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreId.Name = "lblStoreId";
            this.lblStoreId.Size = new System.Drawing.Size(65, 21);
            this.lblStoreId.TabIndex = 4;
            this.lblStoreId.Text = "Store ID";
            this.lblStoreId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOperatorId
            // 
            this.txtOperatorId.BackColor = System.Drawing.Color.White;
            this.txtOperatorId.BorderColor = System.Drawing.Color.LightGray;
            this.txtOperatorId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtOperatorId.BorderRadius = 10;
            this.txtOperatorId.BorderSize = 1;
            this.txtOperatorId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperatorId.ForeColor = System.Drawing.Color.LightGray;
            this.txtOperatorId.IsError = false;
            this.txtOperatorId.Location = new System.Drawing.Point(197, 117);
            this.txtOperatorId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtOperatorId.MaxLength = 32767;
            this.txtOperatorId.Multiline = false;
            this.txtOperatorId.Name = "txtOperatorId";
            this.txtOperatorId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtOperatorId.PasswordChar = false;
            this.txtOperatorId.Placeholder = "Automatically generated";
            this.txtOperatorId.ReadOnly = false;
            this.txtOperatorId.Size = new System.Drawing.Size(307, 38);
            this.txtOperatorId.TabIndex = 25;
            this.txtOperatorId.TbBackColor = System.Drawing.Color.White;
            this.txtOperatorId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtOperatorId.Texts = "Automatically generated";
            this.txtOperatorId.UnderlinedStyle = false;
            // 
            // RestockRequestInfoHeaderContainer
            // 
            this.RestockRequestInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.RestockRequestInfoHeaderContainer.Controls.Add(this.RestockRequestInfoHeader);
            this.RestockRequestInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.RestockRequestInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.RestockRequestInfoHeaderContainer.Name = "RestockRequestInfoHeaderContainer";
            this.RestockRequestInfoHeaderContainer.Size = new System.Drawing.Size(764, 40);
            this.RestockRequestInfoHeaderContainer.TabIndex = 20;
            // 
            // RestockRequestInfoHeader
            // 
            this.RestockRequestInfoHeader.AutoSize = true;
            this.RestockRequestInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestockRequestInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.RestockRequestInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RestockRequestInfoHeader.Name = "RestockRequestInfoHeader";
            this.RestockRequestInfoHeader.Size = new System.Drawing.Size(196, 25);
            this.RestockRequestInfoHeader.TabIndex = 6;
            this.RestockRequestInfoHeader.Text = "Request Information";
            // 
            // dtpCreateTime
            // 
            this.dtpCreateTime.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpCreateTime.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpCreateTime.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpCreateTime.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpCreateTime.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtpCreateTime.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.dtpCreateTime.Location = new System.Drawing.Point(198, 224);
            this.dtpCreateTime.MinimumSize = new System.Drawing.Size(307, 38);
            this.dtpCreateTime.Name = "dtpCreateTime";
            this.dtpCreateTime.Size = new System.Drawing.Size(307, 38);
            this.dtpCreateTime.TabIndex = 44;
            this.dtpCreateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpOperateTime
            // 
            this.dtpOperateTime.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpOperateTime.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpOperateTime.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpOperateTime.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpOperateTime.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtpOperateTime.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.dtpOperateTime.Location = new System.Drawing.Point(198, 285);
            this.dtpOperateTime.MinimumSize = new System.Drawing.Size(307, 38);
            this.dtpOperateTime.Name = "dtpOperateTime";
            this.dtpOperateTime.Size = new System.Drawing.Size(307, 38);
            this.dtpOperateTime.TabIndex = 45;
            // 
            // RestockRequest_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(784, 536);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "RestockRequest_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Restock Request";
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.RestockRequestInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RestockRequestInfoHeaderContainer.ResumeLayout(false);
            this.RestockRequestInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel RestockRequestInfo;
        private System.Windows.Forms.Panel RestockRequestInfoHeaderContainer;
        private System.Windows.Forms.Label RestockRequestInfoHeader;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnAddRestockRequest;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.CustomizeTextbox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private CustomizeControl.CustomizeTextbox txtCreatorId;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Title;
        private CustomizeControl.CustomizeTextbox txtStoreId;
        private System.Windows.Forms.Label lblOperateTime;
        private System.Windows.Forms.Label lblCreateTime;
        private CustomizeControl.CustomizeTextbox txtId;
        private System.Windows.Forms.Label lblOperatorId;
        private System.Windows.Forms.Label lblCreatorId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblStoreId;
        private CustomizeControl.CustomizeTextbox txtOperatorId;
        private System.Windows.Forms.DateTimePicker dtpCreateTime;
        private System.Windows.Forms.DateTimePicker dtpOperateTime;
    }
}