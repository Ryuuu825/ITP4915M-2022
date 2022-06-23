namespace TheBetterLimited.Views
{
    partial class Staff_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Edit));
            this.MainForm = new System.Windows.Forms.Panel();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genderBox = new System.Windows.Forms.Panel();
            this.FemaleGenderRadio = new System.Windows.Forms.RadioButton();
            this.MaleGenderRadio = new System.Windows.Forms.RadioButton();
            this.gender = new System.Windows.Forms.Label();
            this.cbTeam = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbWarehouse = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStore = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.cbPosition = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.cbDept = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.txtFistName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhone = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.SupplierInfoHeader = new System.Windows.Forms.Label();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnAddSupplier = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.genderBox.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            this.BottomBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            resources.ApplyResources(this.MainForm, "MainForm");
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.UserInfo);
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Name = "MainForm";
            // 
            // UserInfo
            // 
            resources.ApplyResources(this.UserInfo, "UserInfo");
            this.UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UserInfo.Controls.Add(this.panel1);
            this.UserInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.UserInfo.Name = "UserInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
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
            this.panel1.Name = "panel1";
            // 
            // genderBox
            // 
            resources.ApplyResources(this.genderBox, "genderBox");
            this.genderBox.Controls.Add(this.FemaleGenderRadio);
            this.genderBox.Controls.Add(this.MaleGenderRadio);
            this.genderBox.Name = "genderBox";
            // 
            // FemaleGenderRadio
            // 
            resources.ApplyResources(this.FemaleGenderRadio, "FemaleGenderRadio");
            this.FemaleGenderRadio.Name = "FemaleGenderRadio";
            this.FemaleGenderRadio.UseVisualStyleBackColor = true;
            // 
            // MaleGenderRadio
            // 
            resources.ApplyResources(this.MaleGenderRadio, "MaleGenderRadio");
            this.MaleGenderRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MaleGenderRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.MaleGenderRadio.Name = "MaleGenderRadio";
            this.MaleGenderRadio.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            resources.ApplyResources(this.gender, "gender");
            this.gender.Name = "gender";
            // 
            // cbTeam
            // 
            resources.ApplyResources(this.cbTeam, "cbTeam");
            this.cbTeam.BackColor = System.Drawing.Color.White;
            this.cbTeam.BorderColor = System.Drawing.Color.LightGray;
            this.cbTeam.BorderRadius = 1;
            this.cbTeam.BorderSize = 1;
            this.cbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeam.ForeColor = System.Drawing.Color.DimGray;
            this.cbTeam.IconColor = System.Drawing.Color.LightGray;
            this.cbTeam.ListBackColor = System.Drawing.Color.White;
            this.cbTeam.ListTextColor = System.Drawing.Color.DimGray;
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Texts = "Team";
            this.cbTeam.UnderlinedStyle = false;
            this.cbTeam.Click += new System.EventHandler(this.cbTeam_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cbWarehouse
            // 
            resources.ApplyResources(this.cbWarehouse, "cbWarehouse");
            this.cbWarehouse.BackColor = System.Drawing.Color.White;
            this.cbWarehouse.BorderColor = System.Drawing.Color.LightGray;
            this.cbWarehouse.BorderRadius = 1;
            this.cbWarehouse.BorderSize = 1;
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.ForeColor = System.Drawing.Color.DimGray;
            this.cbWarehouse.IconColor = System.Drawing.Color.LightGray;
            this.cbWarehouse.ListBackColor = System.Drawing.Color.White;
            this.cbWarehouse.ListTextColor = System.Drawing.Color.DimGray;
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Texts = "Warehouse";
            this.cbWarehouse.UnderlinedStyle = false;
            this.cbWarehouse.Click += new System.EventHandler(this.cbWarehouse_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cbStore
            // 
            resources.ApplyResources(this.cbStore, "cbStore");
            this.cbStore.BackColor = System.Drawing.Color.White;
            this.cbStore.BorderColor = System.Drawing.Color.LightGray;
            this.cbStore.BorderRadius = 1;
            this.cbStore.BorderSize = 1;
            this.cbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStore.ForeColor = System.Drawing.Color.DimGray;
            this.cbStore.IconColor = System.Drawing.Color.LightGray;
            this.cbStore.ListBackColor = System.Drawing.Color.White;
            this.cbStore.ListTextColor = System.Drawing.Color.DimGray;
            this.cbStore.Name = "cbStore";
            this.cbStore.Texts = "Store";
            this.cbStore.UnderlinedStyle = false;
            this.cbStore.Click += new System.EventHandler(this.cbStore_Click);
            // 
            // cbPosition
            // 
            resources.ApplyResources(this.cbPosition, "cbPosition");
            this.cbPosition.BackColor = System.Drawing.Color.White;
            this.cbPosition.BorderColor = System.Drawing.Color.LightGray;
            this.cbPosition.BorderRadius = 1;
            this.cbPosition.BorderSize = 1;
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.ForeColor = System.Drawing.Color.DimGray;
            this.cbPosition.IconColor = System.Drawing.Color.LightGray;
            this.cbPosition.ListBackColor = System.Drawing.Color.White;
            this.cbPosition.ListTextColor = System.Drawing.Color.DimGray;
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Texts = "Position";
            this.cbPosition.UnderlinedStyle = false;
            this.cbPosition.OnSelectedIndexChanged += new System.EventHandler(this.cbPosition_OnSelectedIndexChanged);
            this.cbPosition.Click += new System.EventHandler(this.cbPosition_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderColor = System.Drawing.Color.LightGray;
            this.txtLastName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtLastName.BorderRadius = 10;
            this.txtLastName.BorderSize = 1;
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.IsError = false;
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = false;
            this.txtLastName.Placeholder = "Please enter the last name";
            this.txtLastName.ReadOnly = false;
            this.txtLastName.TbBackColor = System.Drawing.Color.White;
            this.txtLastName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtLastName.Texts = "Please enter the last name";
            this.txtLastName.UnderlinedStyle = false;
            this.txtLastName.Click += new System.EventHandler(this.txtLastName_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtAge
            // 
            resources.ApplyResources(this.txtAge, "txtAge");
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.BorderColor = System.Drawing.Color.LightGray;
            this.txtAge.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtAge.BorderRadius = 10;
            this.txtAge.BorderSize = 1;
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.IsError = false;
            this.txtAge.MaxLength = 2;
            this.txtAge.Multiline = false;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = false;
            this.txtAge.Placeholder = "Please enter the age";
            this.txtAge.ReadOnly = false;
            this.txtAge.TbBackColor = System.Drawing.Color.White;
            this.txtAge.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtAge.Texts = "Please enter the age";
            this.txtAge.UnderlinedStyle = false;
            this.txtAge._Leave += new System.EventHandler(this.txtAge__Leave);
            this.txtAge.Click += new System.EventHandler(this.txtAge_Click);
            // 
            // cbDept
            // 
            resources.ApplyResources(this.cbDept, "cbDept");
            this.cbDept.BackColor = System.Drawing.Color.White;
            this.cbDept.BorderColor = System.Drawing.Color.LightGray;
            this.cbDept.BorderRadius = 1;
            this.cbDept.BorderSize = 1;
            this.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDept.ForeColor = System.Drawing.Color.DimGray;
            this.cbDept.IconColor = System.Drawing.Color.LightGray;
            this.cbDept.ListBackColor = System.Drawing.Color.White;
            this.cbDept.ListTextColor = System.Drawing.Color.DimGray;
            this.cbDept.Name = "cbDept";
            this.cbDept.Texts = "Department";
            this.cbDept.UnderlinedStyle = false;
            this.cbDept.OnSelectedIndexChanged += new System.EventHandler(this.departmentCombo_OnSelectedIndexChanged);
            this.cbDept.Click += new System.EventHandler(this.cbDept_Click);
            // 
            // txtFistName
            // 
            resources.ApplyResources(this.txtFistName, "txtFistName");
            this.txtFistName.BackColor = System.Drawing.Color.White;
            this.txtFistName.BorderColor = System.Drawing.Color.LightGray;
            this.txtFistName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtFistName.BorderRadius = 10;
            this.txtFistName.BorderSize = 1;
            this.txtFistName.ForeColor = System.Drawing.Color.Black;
            this.txtFistName.IsError = false;
            this.txtFistName.MaxLength = 32767;
            this.txtFistName.Multiline = false;
            this.txtFistName.Name = "txtFistName";
            this.txtFistName.PasswordChar = false;
            this.txtFistName.Placeholder = "Please enter the first name";
            this.txtFistName.ReadOnly = false;
            this.txtFistName.TbBackColor = System.Drawing.Color.White;
            this.txtFistName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtFistName.Texts = "Please enter the first name";
            this.txtFistName.UnderlinedStyle = false;
            this.txtFistName.Click += new System.EventHandler(this.txtFistName_Click);
            // 
            // lblPhone
            // 
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.Name = "lblPhone";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.LightGray;
            this.txtPhone.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.IsError = false;
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = false;
            this.txtPhone.Placeholder = "Please enter the phone number";
            this.txtPhone.ReadOnly = false;
            this.txtPhone.TbBackColor = System.Drawing.Color.White;
            this.txtPhone.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtPhone.Texts = "Please enter the phone number";
            this.txtPhone.UnderlinedStyle = false;
            this.txtPhone._Leave += new System.EventHandler(this.txtPhone__Leave);
            this.txtPhone.Click += new System.EventHandler(this.txtPhone_Click);
            // 
            // UserInfoHeaderContainer
            // 
            resources.ApplyResources(this.UserInfoHeaderContainer, "UserInfoHeaderContainer");
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.SupplierInfoHeader);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            // 
            // SupplierInfoHeader
            // 
            resources.ApplyResources(this.SupplierInfoHeader, "SupplierInfoHeader");
            this.SupplierInfoHeader.Name = "SupplierInfoHeader";
            // 
            // BottomBtn
            // 
            resources.ApplyResources(this.BottomBtn, "BottomBtn");
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.btnCancel);
            this.BottomBtn.Controls.Add(this.btnAddSupplier);
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Name = "BottomBtn";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(182)))), ((int)(((byte)(99)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IsChecked = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // btnAddSupplier
            // 
            resources.ApplyResources(this.btnAddSupplier, "btnAddSupplier");
            this.btnAddSupplier.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddSupplier.BorderRadius = 10;
            this.btnAddSupplier.BorderSize = 0;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.IsChecked = false;
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.TextColor = System.Drawing.Color.White;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // Staff_Edit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Staff_Edit";
            this.ShowIcon = false;
            this.MainForm.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.BottomBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel genderBox;
        private System.Windows.Forms.RadioButton FemaleGenderRadio;
        private System.Windows.Forms.RadioButton MaleGenderRadio;
        private System.Windows.Forms.Label gender;
        private CustomizeControl.CustomizeComboBox cbTeam;
        private System.Windows.Forms.Label label7;
        private CustomizeControl.CustomizeComboBox cbWarehouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomizeControl.CustomizeComboBox cbStore;
        private CustomizeControl.CustomizeComboBox cbPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomizeControl.CustomizeTextbox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox txtAge;
        private CustomizeControl.CustomizeComboBox cbDept;
        private CustomizeControl.CustomizeTextbox txtFistName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private CustomizeControl.CustomizeTextbox txtPhone;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label SupplierInfoHeader;
        private System.Windows.Forms.Panel BottomBtn;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnAddSupplier;
    }
}