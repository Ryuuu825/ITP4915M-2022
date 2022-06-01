namespace TheBetterLimited.Views
{
    partial class OrderDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Header = new System.Windows.Forms.Panel();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.CustomerInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StaffIDTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.GTINCode = new System.Windows.Forms.Label();
            this.Catalogue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeptTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.Size = new System.Windows.Forms.Label();
            this.StaffNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.customizeTextbox1 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customizeTextbox3 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Data = new System.Windows.Forms.Panel();
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.RefreshBtn = new FontAwesome.Sharp.IconButton();
            this.Title = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DeleteBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customizeTextbox2 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customizeTextbox4 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.Header.SuspendLayout();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.CustomerInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Data);
            this.Header.Controls.Add(this.panel5);
            this.Header.Controls.Add(this.BottomBtn);
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Location = new System.Drawing.Point(436, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(721, 620);
            this.Header.TabIndex = 0;
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.DeleteBtn);
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(0, 566);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(721, 54);
            this.BottomBtn.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Silver;
            this.CancelBtn.BackgroundColor = System.Drawing.Color.Silver;
            this.CancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CancelBtn.BorderRadius = 10;
            this.CancelBtn.BorderSize = 0;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(182)))), ((int)(((byte)(99)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.IsChecked = false;
            this.CancelBtn.Location = new System.Drawing.Point(446, 6);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(128, 40);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextColor = System.Drawing.Color.White;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SaveBtn.BorderRadius = 10;
            this.SaveBtn.BorderSize = 0;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.IsChecked = false;
            this.SaveBtn.Location = new System.Drawing.Point(580, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(128, 40);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Add To Cart";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.panel3);
            this.MainForm.Controls.Add(this.CustomerInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MainForm.Size = new System.Drawing.Size(436, 620);
            this.MainForm.TabIndex = 2;
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.CustomerInfo.Controls.Add(this.panel1);
            this.CustomerInfo.Controls.Add(this.Size);
            this.CustomerInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.CustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerInfo.Location = new System.Drawing.Point(10, 0);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.CustomerInfo.Size = new System.Drawing.Size(416, 286);
            this.CustomerInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.StaffIDTxt);
            this.panel1.Controls.Add(this.GTINCode);
            this.panel1.Controls.Add(this.Catalogue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DeptTxt);
            this.panel1.Controls.Add(this.StaffNameTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(416, 236);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 40);
            this.panel2.TabIndex = 33;
            // 
            // StaffIDTxt
            // 
            this.StaffIDTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.StaffIDTxt.BackColor = System.Drawing.Color.White;
            this.StaffIDTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StaffIDTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StaffIDTxt.BorderRadius = 10;
            this.StaffIDTxt.BorderSize = 1;
            this.StaffIDTxt.Enabled = false;
            this.StaffIDTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIDTxt.ForeColor = System.Drawing.Color.Black;
            this.StaffIDTxt.IsError = false;
            this.StaffIDTxt.Location = new System.Drawing.Point(164, 11);
            this.StaffIDTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StaffIDTxt.MaxLength = 5;
            this.StaffIDTxt.Multiline = false;
            this.StaffIDTxt.Name = "StaffIDTxt";
            this.StaffIDTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StaffIDTxt.PasswordChar = false;
            this.StaffIDTxt.Placeholder = "";
            this.StaffIDTxt.ReadOnly = false;
            this.StaffIDTxt.Size = new System.Drawing.Size(234, 38);
            this.StaffIDTxt.TabIndex = 24;
            this.StaffIDTxt.TbBackColor = System.Drawing.Color.White;
            this.StaffIDTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StaffIDTxt.Texts = "";
            this.StaffIDTxt.UnderlinedStyle = false;
            // 
            // GTINCode
            // 
            this.GTINCode.AutoSize = true;
            this.GTINCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTINCode.Location = new System.Drawing.Point(21, 105);
            this.GTINCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GTINCode.Name = "GTINCode";
            this.GTINCode.Size = new System.Drawing.Size(127, 21);
            this.GTINCode.TabIndex = 3;
            this.GTINCode.Text = "Delivery Address";
            // 
            // Catalogue
            // 
            this.Catalogue.AutoSize = true;
            this.Catalogue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catalogue.Location = new System.Drawing.Point(57, 67);
            this.Catalogue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Catalogue.Name = "Catalogue";
            this.Catalogue.Size = new System.Drawing.Size(54, 21);
            this.Catalogue.TabIndex = 2;
            this.Catalogue.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeptTxt
            // 
            this.DeptTxt.BackColor = System.Drawing.Color.White;
            this.DeptTxt.BorderColor = System.Drawing.Color.LightGray;
            this.DeptTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.DeptTxt.BorderRadius = 10;
            this.DeptTxt.BorderSize = 1;
            this.DeptTxt.Enabled = false;
            this.DeptTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptTxt.ForeColor = System.Drawing.Color.Black;
            this.DeptTxt.IsError = false;
            this.DeptTxt.Location = new System.Drawing.Point(163, 105);
            this.DeptTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeptTxt.MaxLength = 32767;
            this.DeptTxt.Multiline = true;
            this.DeptTxt.Name = "DeptTxt";
            this.DeptTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DeptTxt.PasswordChar = false;
            this.DeptTxt.Placeholder = "";
            this.DeptTxt.ReadOnly = false;
            this.DeptTxt.Size = new System.Drawing.Size(235, 109);
            this.DeptTxt.TabIndex = 25;
            this.DeptTxt.TbBackColor = System.Drawing.Color.White;
            this.DeptTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.DeptTxt.Texts = "";
            this.DeptTxt.UnderlinedStyle = false;
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.Location = new System.Drawing.Point(47, 500);
            this.Size.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(38, 21);
            this.Size.TabIndex = 9;
            this.Size.Text = "Size";
            // 
            // StaffNameTxt
            // 
            this.StaffNameTxt.BackColor = System.Drawing.Color.White;
            this.StaffNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StaffNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StaffNameTxt.BorderRadius = 10;
            this.StaffNameTxt.BorderSize = 1;
            this.StaffNameTxt.Enabled = false;
            this.StaffNameTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameTxt.ForeColor = System.Drawing.Color.LightGray;
            this.StaffNameTxt.IsError = false;
            this.StaffNameTxt.Location = new System.Drawing.Point(163, 58);
            this.StaffNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StaffNameTxt.MaxLength = 32767;
            this.StaffNameTxt.Multiline = false;
            this.StaffNameTxt.Name = "StaffNameTxt";
            this.StaffNameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StaffNameTxt.PasswordChar = false;
            this.StaffNameTxt.Placeholder = "";
            this.StaffNameTxt.ReadOnly = true;
            this.StaffNameTxt.Size = new System.Drawing.Size(235, 38);
            this.StaffNameTxt.TabIndex = 22;
            this.StaffNameTxt.TbBackColor = System.Drawing.Color.White;
            this.StaffNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StaffNameTxt.Texts = "";
            this.StaffNameTxt.UnderlinedStyle = false;
            // 
            // UserInfoHeaderContainer
            // 
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.GoodsInfoHeader);
            this.UserInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            this.UserInfoHeaderContainer.Size = new System.Drawing.Size(416, 40);
            this.UserInfoHeaderContainer.TabIndex = 20;
            // 
            // GoodsInfoHeader
            // 
            this.GoodsInfoHeader.AutoSize = true;
            this.GoodsInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.GoodsInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoodsInfoHeader.Name = "GoodsInfoHeader";
            this.GoodsInfoHeader.Size = new System.Drawing.Size(211, 25);
            this.GoodsInfoHeader.TabIndex = 6;
            this.GoodsInfoHeader.Text = "Customer Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 334);
            this.panel3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Appointment";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.customizeTextbox2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.customizeTextbox4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.customizeTextbox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.customizeTextbox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 294);
            this.panel4.TabIndex = 34;
            // 
            // customizeTextbox1
            // 
            this.customizeTextbox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.customizeTextbox1.BackColor = System.Drawing.Color.White;
            this.customizeTextbox1.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox1.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox1.BorderRadius = 10;
            this.customizeTextbox1.BorderSize = 1;
            this.customizeTextbox1.Enabled = false;
            this.customizeTextbox1.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox1.ForeColor = System.Drawing.Color.Black;
            this.customizeTextbox1.IsError = false;
            this.customizeTextbox1.Location = new System.Drawing.Point(164, 35);
            this.customizeTextbox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox1.MaxLength = 5;
            this.customizeTextbox1.Multiline = false;
            this.customizeTextbox1.Name = "customizeTextbox1";
            this.customizeTextbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox1.PasswordChar = false;
            this.customizeTextbox1.Placeholder = "";
            this.customizeTextbox1.ReadOnly = false;
            this.customizeTextbox1.Size = new System.Drawing.Size(234, 38);
            this.customizeTextbox1.TabIndex = 24;
            this.customizeTextbox1.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox1.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.customizeTextbox1.Texts = "";
            this.customizeTextbox1.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Session";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            // 
            // customizeTextbox3
            // 
            this.customizeTextbox3.BackColor = System.Drawing.Color.White;
            this.customizeTextbox3.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox3.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox3.BorderRadius = 10;
            this.customizeTextbox3.BorderSize = 1;
            this.customizeTextbox3.Enabled = false;
            this.customizeTextbox3.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox3.ForeColor = System.Drawing.Color.LightGray;
            this.customizeTextbox3.IsError = false;
            this.customizeTextbox3.Location = new System.Drawing.Point(163, 82);
            this.customizeTextbox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox3.MaxLength = 32767;
            this.customizeTextbox3.Multiline = false;
            this.customizeTextbox3.Name = "customizeTextbox3";
            this.customizeTextbox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox3.PasswordChar = false;
            this.customizeTextbox3.Placeholder = "";
            this.customizeTextbox3.ReadOnly = true;
            this.customizeTextbox3.Size = new System.Drawing.Size(235, 38);
            this.customizeTextbox3.TabIndex = 22;
            this.customizeTextbox3.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox3.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.customizeTextbox3.Texts = "";
            this.customizeTextbox3.UnderlinedStyle = false;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn7.HeaderText = "";
            this.dataGridViewImageColumn7.Image = global::TheBetterLimited.Properties.Resources.trash;
            this.dataGridViewImageColumn7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn7.MinimumWidth = 6;
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.ToolTipText = "Delete";
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.Image = global::TheBetterLimited.Properties.Resources.lock1;
            this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn5.MinimumWidth = 6;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ToolTipText = "Lock";
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::TheBetterLimited.Properties.Resources.square;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.MinimumWidth = 6;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 124;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 124;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 124;
            // 
            // Data
            // 
            this.Data.Controls.Add(this.OrderDataGrid);
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(0, 40);
            this.Data.Margin = new System.Windows.Forms.Padding(2);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Data.Size = new System.Drawing.Size(721, 526);
            this.Data.TabIndex = 11;
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.AllowUserToAddRows = false;
            this.OrderDataGrid.AllowUserToOrderColumns = true;
            this.OrderDataGrid.AllowUserToResizeColumns = false;
            this.OrderDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.OrderDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.OrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OrderDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.OrderDataGrid.ColumnHeadersHeight = 50;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.ID,
            this.CreatorId,
            this.OperatorId,
            this.CreateAt,
            this.UpdateAt,
            this.TotalAmount,
            this.Paid,
            this.edit,
            this.delete});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.DefaultCellStyle = dataGridViewCellStyle22;
            this.OrderDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDataGrid.EnableHeadersVisualStyles = false;
            this.OrderDataGrid.GridColor = System.Drawing.Color.White;
            this.OrderDataGrid.Location = new System.Drawing.Point(0, 2);
            this.OrderDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.OrderDataGrid.MultiSelect = false;
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.ReadOnly = true;
            this.OrderDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.OrderDataGrid.RowHeadersVisible = false;
            this.OrderDataGrid.RowHeadersWidth = 30;
            this.OrderDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle24.NullValue = null;
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.OrderDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.OrderDataGrid.RowTemplate.Height = 30;
            this.OrderDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGrid.Size = new System.Drawing.Size(721, 524);
            this.OrderDataGrid.StandardTab = true;
            this.OrderDataGrid.TabIndex = 3;
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
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "id";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle21;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ToolTipText = "User ID";
            this.ID.Width = 59;
            // 
            // CreatorId
            // 
            this.CreatorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatorId.DataPropertyName = "_creatorId";
            this.CreatorId.HeaderText = "Creator Id";
            this.CreatorId.MinimumWidth = 6;
            this.CreatorId.Name = "CreatorId";
            this.CreatorId.ReadOnly = true;
            this.CreatorId.ToolTipText = "Creator\'s staff ID of the order";
            this.CreatorId.Width = 107;
            // 
            // OperatorId
            // 
            this.OperatorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OperatorId.DataPropertyName = "_operatorId ";
            this.OperatorId.HeaderText = "Operator Id ";
            this.OperatorId.MinimumWidth = 6;
            this.OperatorId.Name = "OperatorId";
            this.OperatorId.ReadOnly = true;
            this.OperatorId.ToolTipText = "Operator\'s staff ID of the order";
            this.OperatorId.Width = 121;
            // 
            // CreateAt
            // 
            this.CreateAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateAt.DataPropertyName = "createAt";
            this.CreateAt.HeaderText = "CreateAt";
            this.CreateAt.MinimumWidth = 6;
            this.CreateAt.Name = "CreateAt";
            this.CreateAt.ReadOnly = true;
            this.CreateAt.ToolTipText = "Create Time";
            // 
            // UpdateAt
            // 
            this.UpdateAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UpdateAt.DataPropertyName = "updateAt";
            this.UpdateAt.HeaderText = "UpdateAt";
            this.UpdateAt.MinimumWidth = 6;
            this.UpdateAt.Name = "UpdateAt";
            this.UpdateAt.ReadOnly = true;
            this.UpdateAt.ToolTipText = "Update Time";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalAmount.DataPropertyName = "totalAmount";
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.ToolTipText = "Remark of Account";
            // 
            // Paid
            // 
            this.Paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Paid.DataPropertyName = "paid";
            this.Paid.HeaderText = "Paid";
            this.Paid.Name = "Paid";
            this.Paid.ReadOnly = true;
            this.Paid.Width = 72;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.edit.HeaderText = "";
            this.edit.Image = global::TheBetterLimited.Properties.Resources.eye;
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.ToolTipText = "Details";
            this.edit.Width = 6;
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
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseBtn.IconColor = System.Drawing.Color.Black;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.IconSize = 25;
            this.CloseBtn.Location = new System.Drawing.Point(679, 4);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(39, 36);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.UseVisualStyleBackColor = true;
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
            this.RefreshBtn.Location = new System.Drawing.Point(641, 4);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(39, 36);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(2, 7);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(108, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "SalesOrder";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.CloseBtn);
            this.panel5.Controls.Add(this.RefreshBtn);
            this.panel5.Controls.Add(this.Title);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(721, 40);
            this.panel5.TabIndex = 9;
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
            this.DeleteBtn.IsChecked = false;
            this.DeleteBtn.Location = new System.Drawing.Point(12, 7);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(114, 38);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete Seleted";
            this.DeleteBtn.TextColor = System.Drawing.Color.White;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn6.HeaderText = "";
            this.dataGridViewImageColumn6.Image = global::TheBetterLimited.Properties.Resources.pencil_free_icon_font;
            this.dataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn6.MinimumWidth = 6;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ToolTipText = "Edit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delivery";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Installation";
            // 
            // customizeTextbox2
            // 
            this.customizeTextbox2.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.customizeTextbox2.BackColor = System.Drawing.Color.White;
            this.customizeTextbox2.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox2.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox2.BorderRadius = 10;
            this.customizeTextbox2.BorderSize = 1;
            this.customizeTextbox2.Enabled = false;
            this.customizeTextbox2.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox2.ForeColor = System.Drawing.Color.Black;
            this.customizeTextbox2.IsError = false;
            this.customizeTextbox2.Location = new System.Drawing.Point(163, 172);
            this.customizeTextbox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox2.MaxLength = 5;
            this.customizeTextbox2.Multiline = false;
            this.customizeTextbox2.Name = "customizeTextbox2";
            this.customizeTextbox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox2.PasswordChar = false;
            this.customizeTextbox2.Placeholder = "";
            this.customizeTextbox2.ReadOnly = false;
            this.customizeTextbox2.Size = new System.Drawing.Size(234, 38);
            this.customizeTextbox2.TabIndex = 29;
            this.customizeTextbox2.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox2.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.customizeTextbox2.Texts = "";
            this.customizeTextbox2.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Session";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Date";
            // 
            // customizeTextbox4
            // 
            this.customizeTextbox4.BackColor = System.Drawing.Color.White;
            this.customizeTextbox4.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox4.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox4.BorderRadius = 10;
            this.customizeTextbox4.BorderSize = 1;
            this.customizeTextbox4.Enabled = false;
            this.customizeTextbox4.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox4.ForeColor = System.Drawing.Color.LightGray;
            this.customizeTextbox4.IsError = false;
            this.customizeTextbox4.Location = new System.Drawing.Point(162, 219);
            this.customizeTextbox4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox4.MaxLength = 32767;
            this.customizeTextbox4.Multiline = false;
            this.customizeTextbox4.Name = "customizeTextbox4";
            this.customizeTextbox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox4.PasswordChar = false;
            this.customizeTextbox4.Placeholder = "";
            this.customizeTextbox4.ReadOnly = true;
            this.customizeTextbox4.Size = new System.Drawing.Size(235, 38);
            this.customizeTextbox4.TabIndex = 28;
            this.customizeTextbox4.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox4.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.customizeTextbox4.Texts = "";
            this.customizeTextbox4.UnderlinedStyle = false;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1157, 620);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "OrderDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.Usermanagement_Edit_Load);
            this.Header.ResumeLayout(false);
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.CustomerInfo.ResumeLayout(false);
            this.CustomerInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Label GTINCode;
        private System.Windows.Forms.Label Catalogue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CustomerInfo;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private CustomizeControl.CustomizeTextbox StaffNameTxt;
        private CustomizeControl.CustomizeTextbox StaffIDTxt;
        private System.Windows.Forms.Label Size;
        private CustomizeControl.CustomizeTextbox DeptTxt;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private CustomizeControl.CustomizeTextbox customizeTextbox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomizeControl.CustomizeTextbox customizeTextbox3;
        private System.Windows.Forms.Panel Data;
        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.DataGridViewImageColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private FontAwesome.Sharp.IconButton RefreshBtn;
        private System.Windows.Forms.Label Title;
        private CustomizeControl.RoundButton DeleteBtn;
        private CustomizeControl.CustomizeTextbox customizeTextbox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CustomizeControl.CustomizeTextbox customizeTextbox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
    }
}