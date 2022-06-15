namespace TheBetterLimited.Views
{
    partial class Staff_Add
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
            this.MainForm = new System.Windows.Forms.Panel();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genderBox = new System.Windows.Forms.Panel();
            this.FemaleGenderRadio = new System.Windows.Forms.RadioButton();
            this.MaleGenderRadio = new System.Windows.Forms.RadioButton();
            this.gender = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.SupplierInfoHeader = new System.Windows.Forms.Label();
            this.cbTeam = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.cbWarehouse = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.cbStore = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.cbPosition = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.txtLastName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtAge = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.cbDept = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.txtFistName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtPhone = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnAddSupplier = new TheBetterLimited.CustomizeControl.RoundButton();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.genderBox.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.btnCancel);
            this.BottomBtn.Controls.Add(this.btnAddSupplier);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 555);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(457, 54);
            this.BottomBtn.TabIndex = 1;
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.UserInfo);
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(477, 619);
            this.MainForm.TabIndex = 2;
            // 
            // UserInfo
            // 
            this.UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UserInfo.Controls.Add(this.panel1);
            this.UserInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.UserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserInfo.Location = new System.Drawing.Point(10, 10);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.UserInfo.Size = new System.Drawing.Size(457, 545);
            this.UserInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.genderBox);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.cbTeam);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbWarehouse);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbStore);
            this.panel1.Controls.Add(this.cbPosition);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.cbDept);
            this.panel1.Controls.Add(this.txtFistName);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 495);
            this.panel1.TabIndex = 27;
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.FemaleGenderRadio);
            this.genderBox.Controls.Add(this.MaleGenderRadio);
            this.genderBox.Location = new System.Drawing.Point(122, 124);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(307, 31);
            this.genderBox.TabIndex = 60;
            // 
            // FemaleGenderRadio
            // 
            this.FemaleGenderRadio.AutoSize = true;
            this.FemaleGenderRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleGenderRadio.Location = new System.Drawing.Point(185, 6);
            this.FemaleGenderRadio.Margin = new System.Windows.Forms.Padding(2);
            this.FemaleGenderRadio.Name = "FemaleGenderRadio";
            this.FemaleGenderRadio.Size = new System.Drawing.Size(63, 19);
            this.FemaleGenderRadio.TabIndex = 4;
            this.FemaleGenderRadio.Text = "Female";
            this.FemaleGenderRadio.UseVisualStyleBackColor = true;
            // 
            // MaleGenderRadio
            // 
            this.MaleGenderRadio.AutoSize = true;
            this.MaleGenderRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MaleGenderRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.MaleGenderRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleGenderRadio.Location = new System.Drawing.Point(48, 6);
            this.MaleGenderRadio.Margin = new System.Windows.Forms.Padding(2);
            this.MaleGenderRadio.Name = "MaleGenderRadio";
            this.MaleGenderRadio.Size = new System.Drawing.Size(51, 19);
            this.MaleGenderRadio.TabIndex = 3;
            this.MaleGenderRadio.Text = "Male";
            this.MaleGenderRadio.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(35, 129);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(68, 21);
            this.gender.TabIndex = 57;
            this.gender.Text = "Gender*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 444);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 55;
            this.label7.Text = "Team";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Warehouse";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Store";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Position*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Department*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Last Name*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Age*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(39, 226);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 21);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone*";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 33);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "First Name*";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserInfoHeaderContainer
            // 
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.SupplierInfoHeader);
            this.UserInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            this.UserInfoHeaderContainer.Size = new System.Drawing.Size(457, 40);
            this.UserInfoHeaderContainer.TabIndex = 20;
            // 
            // SupplierInfoHeader
            // 
            this.SupplierInfoHeader.AutoSize = true;
            this.SupplierInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.SupplierInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SupplierInfoHeader.Name = "SupplierInfoHeader";
            this.SupplierInfoHeader.Size = new System.Drawing.Size(167, 25);
            this.SupplierInfoHeader.TabIndex = 6;
            this.SupplierInfoHeader.Text = "Staff Information";
            // 
            // cbTeam
            // 
            this.cbTeam.BackColor = System.Drawing.Color.White;
            this.cbTeam.BorderColor = System.Drawing.Color.LightGray;
            this.cbTeam.BorderRadius = 1;
            this.cbTeam.BorderSize = 1;
            this.cbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeam.ForeColor = System.Drawing.Color.DimGray;
            this.cbTeam.IconColor = System.Drawing.Color.LightGray;
            this.cbTeam.ListBackColor = System.Drawing.Color.White;
            this.cbTeam.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTeam.Location = new System.Drawing.Point(122, 439);
            this.cbTeam.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Padding = new System.Windows.Forms.Padding(1);
            this.cbTeam.Size = new System.Drawing.Size(307, 31);
            this.cbTeam.TabIndex = 11;
            this.cbTeam.Texts = "Team";
            this.cbTeam.UnderlinedStyle = false;
            this.cbTeam.Click += new System.EventHandler(this.cbTeam_Click);
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.BackColor = System.Drawing.Color.White;
            this.cbWarehouse.BorderColor = System.Drawing.Color.LightGray;
            this.cbWarehouse.BorderRadius = 1;
            this.cbWarehouse.BorderSize = 1;
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWarehouse.ForeColor = System.Drawing.Color.DimGray;
            this.cbWarehouse.IconColor = System.Drawing.Color.LightGray;
            this.cbWarehouse.ListBackColor = System.Drawing.Color.White;
            this.cbWarehouse.ListTextColor = System.Drawing.Color.DimGray;
            this.cbWarehouse.Location = new System.Drawing.Point(122, 396);
            this.cbWarehouse.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Padding = new System.Windows.Forms.Padding(1);
            this.cbWarehouse.Size = new System.Drawing.Size(307, 31);
            this.cbWarehouse.TabIndex = 10;
            this.cbWarehouse.Texts = "Warehouse";
            this.cbWarehouse.UnderlinedStyle = false;
            this.cbWarehouse.Click += new System.EventHandler(this.cbWarehouse_Click);
            // 
            // cbStore
            // 
            this.cbStore.BackColor = System.Drawing.Color.White;
            this.cbStore.BorderColor = System.Drawing.Color.LightGray;
            this.cbStore.BorderRadius = 1;
            this.cbStore.BorderSize = 1;
            this.cbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStore.ForeColor = System.Drawing.Color.DimGray;
            this.cbStore.IconColor = System.Drawing.Color.LightGray;
            this.cbStore.ListBackColor = System.Drawing.Color.White;
            this.cbStore.ListTextColor = System.Drawing.Color.DimGray;
            this.cbStore.Location = new System.Drawing.Point(122, 353);
            this.cbStore.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbStore.Name = "cbStore";
            this.cbStore.Padding = new System.Windows.Forms.Padding(1);
            this.cbStore.Size = new System.Drawing.Size(307, 31);
            this.cbStore.TabIndex = 9;
            this.cbStore.Texts = "Store";
            this.cbStore.UnderlinedStyle = false;
            this.cbStore.Click += new System.EventHandler(this.cbStore_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.BackColor = System.Drawing.Color.White;
            this.cbPosition.BorderColor = System.Drawing.Color.LightGray;
            this.cbPosition.BorderRadius = 1;
            this.cbPosition.BorderSize = 1;
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.ForeColor = System.Drawing.Color.DimGray;
            this.cbPosition.IconColor = System.Drawing.Color.LightGray;
            this.cbPosition.ListBackColor = System.Drawing.Color.White;
            this.cbPosition.ListTextColor = System.Drawing.Color.DimGray;
            this.cbPosition.Location = new System.Drawing.Point(122, 310);
            this.cbPosition.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Padding = new System.Windows.Forms.Padding(1);
            this.cbPosition.Size = new System.Drawing.Size(307, 31);
            this.cbPosition.TabIndex = 8;
            this.cbPosition.Texts = "Position";
            this.cbPosition.UnderlinedStyle = false;
            this.cbPosition.OnSelectedIndexChanged += new System.EventHandler(this.cbPosition_OnSelectedIndexChanged);
            this.cbPosition.Click += new System.EventHandler(this.cbPosition_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderColor = System.Drawing.Color.LightGray;
            this.txtLastName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtLastName.BorderRadius = 10;
            this.txtLastName.BorderSize = 1;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.IsError = false;
            this.txtLastName.Location = new System.Drawing.Point(122, 74);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.Placeholder = "Please enter the last name";
            this.txtLastName.ReadOnly = false;
            this.txtLastName.Size = new System.Drawing.Size(307, 38);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TbBackColor = System.Drawing.Color.White;
            this.txtLastName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtLastName.Texts = "Please enter the last name";
            this.txtLastName.UnderlinedStyle = false;
            this.txtLastName.Click += new System.EventHandler(this.txtLastName_Click);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.BorderColor = System.Drawing.Color.LightGray;
            this.txtAge.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtAge.BorderRadius = 10;
            this.txtAge.BorderSize = 1;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.IsError = false;
            this.txtAge.Location = new System.Drawing.Point(122, 167);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAge.MaxLength = 2;
            this.txtAge.Multiline = false;
            this.txtAge.Name = "txtAge";
            this.txtAge.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAge.PasswordChar = false;
            this.txtAge.Placeholder = "Please enter the age";
            this.txtAge.ReadOnly = false;
            this.txtAge.Size = new System.Drawing.Size(307, 38);
            this.txtAge.TabIndex = 5;
            this.txtAge.TbBackColor = System.Drawing.Color.White;
            this.txtAge.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtAge.Texts = "Please enter the age";
            this.txtAge.UnderlinedStyle = false;
            this.txtAge._TextChanged += new System.EventHandler(this.txtAge__TextChanged);
            this.txtAge._Leave += new System.EventHandler(this.txtAge__Leave);
            this.txtAge.Click += new System.EventHandler(this.txtAge_Click);
            // 
            // cbDept
            // 
            this.cbDept.BackColor = System.Drawing.Color.White;
            this.cbDept.BorderColor = System.Drawing.Color.LightGray;
            this.cbDept.BorderRadius = 1;
            this.cbDept.BorderSize = 1;
            this.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDept.ForeColor = System.Drawing.Color.DimGray;
            this.cbDept.IconColor = System.Drawing.Color.LightGray;
            this.cbDept.ListBackColor = System.Drawing.Color.White;
            this.cbDept.ListTextColor = System.Drawing.Color.DimGray;
            this.cbDept.Location = new System.Drawing.Point(122, 267);
            this.cbDept.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbDept.Name = "cbDept";
            this.cbDept.Padding = new System.Windows.Forms.Padding(1);
            this.cbDept.Size = new System.Drawing.Size(307, 31);
            this.cbDept.TabIndex = 7;
            this.cbDept.Texts = "Department";
            this.cbDept.UnderlinedStyle = false;
            this.cbDept.OnSelectedIndexChanged += new System.EventHandler(this.departmentCombo_OnSelectedIndexChanged);
            this.cbDept.Click += new System.EventHandler(this.cbDept_Click);
            // 
            // txtFistName
            // 
            this.txtFistName.BackColor = System.Drawing.Color.White;
            this.txtFistName.BorderColor = System.Drawing.Color.LightGray;
            this.txtFistName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtFistName.BorderRadius = 10;
            this.txtFistName.BorderSize = 1;
            this.txtFistName.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFistName.ForeColor = System.Drawing.Color.Black;
            this.txtFistName.IsError = false;
            this.txtFistName.Location = new System.Drawing.Point(122, 24);
            this.txtFistName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFistName.MaxLength = 32767;
            this.txtFistName.Multiline = false;
            this.txtFistName.Name = "txtFistName";
            this.txtFistName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFistName.PasswordChar = false;
            this.txtFistName.Placeholder = "Please enter the first name";
            this.txtFistName.ReadOnly = false;
            this.txtFistName.Size = new System.Drawing.Size(307, 38);
            this.txtFistName.TabIndex = 1;
            this.txtFistName.TbBackColor = System.Drawing.Color.White;
            this.txtFistName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtFistName.Texts = "Please enter the first name";
            this.txtFistName.UnderlinedStyle = false;
            this.txtFistName.Click += new System.EventHandler(this.txtFistName_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.LightGray;
            this.txtPhone.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.IsError = false;
            this.txtPhone.Location = new System.Drawing.Point(122, 217);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.Placeholder = "Please enter the phone number";
            this.txtPhone.ReadOnly = false;
            this.txtPhone.Size = new System.Drawing.Size(307, 38);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TbBackColor = System.Drawing.Color.White;
            this.txtPhone.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtPhone.Texts = "Please enter the phone number";
            this.txtPhone.UnderlinedStyle = false;
            this.txtPhone._TextChanged += new System.EventHandler(this.txtPhone__TextChanged);
            this.txtPhone._Leave += new System.EventHandler(this.txtPhone__Leave);
            this.txtPhone.Click += new System.EventHandler(this.txtPhone_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(89, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddSupplier.BorderRadius = 10;
            this.btnAddSupplier.BorderSize = 0;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.IsChecked = false;
            this.btnAddSupplier.Location = new System.Drawing.Point(234, 6);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(128, 40);
            this.btnAddSupplier.TabIndex = 12;
            this.btnAddSupplier.Text = "Add Staff";
            this.btnAddSupplier.TextColor = System.Drawing.Color.White;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // Staff_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(477, 619);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Staff_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Staff";
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label SupplierInfoHeader;
        private CustomizeControl.CustomizeTextbox txtPhone;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnAddSupplier;
        private CustomizeControl.CustomizeTextbox txtFistName;
        private CustomizeControl.CustomizeComboBox cbDept;
        private CustomizeControl.CustomizeTextbox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox txtAge;
        private System.Windows.Forms.Label label3;
        private CustomizeControl.CustomizeComboBox cbPosition;
        private System.Windows.Forms.Label label4;
        private CustomizeControl.CustomizeComboBox cbTeam;
        private System.Windows.Forms.Label label7;
        private CustomizeControl.CustomizeComboBox cbWarehouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomizeControl.CustomizeComboBox cbStore;
        private System.Windows.Forms.Panel genderBox;
        private System.Windows.Forms.RadioButton FemaleGenderRadio;
        private System.Windows.Forms.RadioButton MaleGenderRadio;
        private System.Windows.Forms.Label gender;
    }
}