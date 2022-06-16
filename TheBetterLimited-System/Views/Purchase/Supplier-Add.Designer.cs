﻿namespace TheBetterLimited.Views
{
    partial class Supplier_Add
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
            this.btnAddSupplier = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSupplierName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtContact = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtAddress = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtPhone = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.SupplierInfoHeader = new System.Windows.Forms.Label();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.BottomBtn.Location = new System.Drawing.Point(10, 348);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(457, 54);
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
            this.btnCancel.Location = new System.Drawing.Point(149, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 1;
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
            this.btnAddSupplier.Location = new System.Drawing.Point(294, 6);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(128, 40);
            this.btnAddSupplier.TabIndex = 6;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.TextColor = System.Drawing.Color.White;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.UserInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(477, 412);
            this.MainForm.TabIndex = 2;
            // 
            // UserInfo
            // 
            this.UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.UserInfo.Controls.Add(this.panel1);
            this.UserInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.UserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfo.Location = new System.Drawing.Point(10, 10);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(457, 395);
            this.UserInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSupplierName);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 355);
            this.panel1.TabIndex = 27;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.Color.White;
            this.txtSupplierName.BorderColor = System.Drawing.Color.LightGray;
            this.txtSupplierName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtSupplierName.BorderRadius = 10;
            this.txtSupplierName.BorderSize = 1;
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierName.IsError = false;
            this.txtSupplierName.Location = new System.Drawing.Point(122, 24);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSupplierName.MaxLength = 32767;
            this.txtSupplierName.Multiline = false;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupplierName.PasswordChar = false;
            this.txtSupplierName.Placeholder = "Please enter the name of the supplier";
            this.txtSupplierName.ReadOnly = false;
            this.txtSupplierName.Size = new System.Drawing.Size(307, 38);
            this.txtSupplierName.TabIndex = 41;
            this.txtSupplierName.TbBackColor = System.Drawing.Color.White;
            this.txtSupplierName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtSupplierName.Texts = "Please enter the name of the supplier";
            this.txtSupplierName.UnderlinedStyle = false;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.BorderColor = System.Drawing.Color.LightGray;
            this.txtContact.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtContact.BorderRadius = 10;
            this.txtContact.BorderSize = 1;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.IsError = false;
            this.txtContact.Location = new System.Drawing.Point(122, 130);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Multiline = false;
            this.txtContact.Name = "txtContact";
            this.txtContact.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContact.PasswordChar = false;
            this.txtContact.Placeholder = "Please enter the contact";
            this.txtContact.ReadOnly = false;
            this.txtContact.Size = new System.Drawing.Size(307, 38);
            this.txtContact.TabIndex = 40;
            this.txtContact.TbBackColor = System.Drawing.Color.White;
            this.txtContact.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtContact.Texts = "Please enter the contact";
            this.txtContact.UnderlinedStyle = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.LightGray;
            this.txtAddress.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.BorderSize = 1;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.IsError = false;
            this.txtAddress.Location = new System.Drawing.Point(122, 242);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.Placeholder = "Please enter the address";
            this.txtAddress.ReadOnly = false;
            this.txtAddress.Size = new System.Drawing.Size(307, 38);
            this.txtAddress.TabIndex = 31;
            this.txtAddress.TbBackColor = System.Drawing.Color.White;
            this.txtAddress.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtAddress.Texts = "Please enter the address";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(21, 251);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 21);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.LightGray;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.IsError = false;
            this.txtEmail.Location = new System.Drawing.Point(122, 181);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Placeholder = "Please enter the email";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(307, 38);
            this.txtEmail.TabIndex = 29;
            this.txtEmail.TbBackColor = System.Drawing.Color.White;
            this.txtEmail.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtEmail.Texts = "Please enter the email";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(30, 190);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 21);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(27, 83);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(54, 21);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(28, 33);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name*";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(23, 139);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(63, 21);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtPhone.Location = new System.Drawing.Point(122, 74);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.Placeholder = "Please enter the phone number";
            this.txtPhone.ReadOnly = false;
            this.txtPhone.Size = new System.Drawing.Size(307, 38);
            this.txtPhone.TabIndex = 25;
            this.txtPhone.TbBackColor = System.Drawing.Color.White;
            this.txtPhone.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtPhone.Texts = "Please enter the phone number";
            this.txtPhone.UnderlinedStyle = false;
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
            this.SupplierInfoHeader.Size = new System.Drawing.Size(200, 25);
            this.SupplierInfoHeader.TabIndex = 6;
            this.SupplierInfoHeader.Text = "Supplier Information";
            // 
            // Supplier_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(477, 412);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Supplier_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Supplier";
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label SupplierInfoHeader;
        private CustomizeControl.CustomizeTextbox txtPhone;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnAddSupplier;
        private CustomizeControl.CustomizeTextbox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private CustomizeControl.CustomizeTextbox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private CustomizeControl.CustomizeTextbox txtContact;
        private CustomizeControl.CustomizeTextbox txtSupplierName;
    }
}