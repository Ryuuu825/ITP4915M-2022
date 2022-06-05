﻿namespace TheBetterLimited.Views
{
    partial class Booking
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
            this.MainForm = new System.Windows.Forms.Panel();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.CustomerInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.depositTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.CusNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.GTINCode = new System.Windows.Forms.Label();
            this.Catalogue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CusAddressTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.CusPhoneTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.MainForm.SuspendLayout();
            this.BottomBtn.SuspendLayout();
            this.CustomerInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.CustomerInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 40);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(520, 360);
            this.MainForm.TabIndex = 3;
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(0, 295);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(520, 65);
            this.BottomBtn.TabIndex = 34;
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
            this.CancelBtn.Location = new System.Drawing.Point(78, 13);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(145, 40);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextColor = System.Drawing.Color.White;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.SaveBtn.Location = new System.Drawing.Point(296, 13);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(145, 40);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.CustomerInfo.Controls.Add(this.panel1);
            this.CustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(520, 360);
            this.CustomerInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.depositTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CusNameTxt);
            this.panel1.Controls.Add(this.GTINCode);
            this.panel1.Controls.Add(this.Catalogue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CusAddressTxt);
            this.panel1.Controls.Add(this.CusPhoneTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(520, 360);
            this.panel1.TabIndex = 27;
            // 
            // depositTxt
            // 
            this.depositTxt.BackColor = System.Drawing.Color.White;
            this.depositTxt.BorderColor = System.Drawing.Color.LightGray;
            this.depositTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.depositTxt.BorderRadius = 10;
            this.depositTxt.BorderSize = 1;
            this.depositTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositTxt.ForeColor = System.Drawing.Color.Black;
            this.depositTxt.IsError = false;
            this.depositTxt.Location = new System.Drawing.Point(164, 246);
            this.depositTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.depositTxt.MaxLength = 32767;
            this.depositTxt.Multiline = false;
            this.depositTxt.Name = "depositTxt";
            this.depositTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.depositTxt.PasswordChar = false;
            this.depositTxt.Placeholder = "";
            this.depositTxt.ReadOnly = true;
            this.depositTxt.Size = new System.Drawing.Size(307, 38);
            this.depositTxt.TabIndex = 27;
            this.depositTxt.TbBackColor = System.Drawing.Color.White;
            this.depositTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.depositTxt.Texts = "";
            this.depositTxt.UnderlinedStyle = false;
            this.depositTxt.Load += new System.EventHandler(this.depositTxt_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Deposit";
            // 
            // CusNameTxt
            // 
            this.CusNameTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CusNameTxt.BackColor = System.Drawing.Color.White;
            this.CusNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.CusNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.CusNameTxt.BorderRadius = 10;
            this.CusNameTxt.BorderSize = 1;
            this.CusNameTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusNameTxt.ForeColor = System.Drawing.Color.Black;
            this.CusNameTxt.IsError = false;
            this.CusNameTxt.Location = new System.Drawing.Point(164, 31);
            this.CusNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CusNameTxt.MaxLength = 5;
            this.CusNameTxt.Multiline = false;
            this.CusNameTxt.Name = "CusNameTxt";
            this.CusNameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CusNameTxt.PasswordChar = false;
            this.CusNameTxt.Placeholder = "Please enter customer name";
            this.CusNameTxt.ReadOnly = false;
            this.CusNameTxt.Size = new System.Drawing.Size(306, 38);
            this.CusNameTxt.TabIndex = 1;
            this.CusNameTxt.TbBackColor = System.Drawing.Color.White;
            this.CusNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.CusNameTxt.Texts = "Please enter customer name";
            this.CusNameTxt.UnderlinedStyle = false;
            // 
            // GTINCode
            // 
            this.GTINCode.AutoSize = true;
            this.GTINCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTINCode.Location = new System.Drawing.Point(54, 125);
            this.GTINCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GTINCode.Name = "GTINCode";
            this.GTINCode.Size = new System.Drawing.Size(66, 21);
            this.GTINCode.TabIndex = 3;
            this.GTINCode.Text = "Address";
            // 
            // Catalogue
            // 
            this.Catalogue.AutoSize = true;
            this.Catalogue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catalogue.Location = new System.Drawing.Point(57, 87);
            this.Catalogue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Catalogue.Name = "Catalogue";
            this.Catalogue.Size = new System.Drawing.Size(61, 21);
            this.Catalogue.TabIndex = 2;
            this.Catalogue.Text = "Phone*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name*";
            // 
            // CusAddressTxt
            // 
            this.CusAddressTxt.BackColor = System.Drawing.Color.White;
            this.CusAddressTxt.BorderColor = System.Drawing.Color.LightGray;
            this.CusAddressTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.CusAddressTxt.BorderRadius = 10;
            this.CusAddressTxt.BorderSize = 1;
            this.CusAddressTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusAddressTxt.ForeColor = System.Drawing.Color.Black;
            this.CusAddressTxt.IsError = false;
            this.CusAddressTxt.Location = new System.Drawing.Point(163, 125);
            this.CusAddressTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CusAddressTxt.MaxLength = 32767;
            this.CusAddressTxt.Multiline = true;
            this.CusAddressTxt.Name = "CusAddressTxt";
            this.CusAddressTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CusAddressTxt.PasswordChar = false;
            this.CusAddressTxt.Placeholder = "Please enter customer address (option)";
            this.CusAddressTxt.ReadOnly = false;
            this.CusAddressTxt.Size = new System.Drawing.Size(307, 109);
            this.CusAddressTxt.TabIndex = 3;
            this.CusAddressTxt.TbBackColor = System.Drawing.Color.White;
            this.CusAddressTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.CusAddressTxt.Texts = "Please enter customer address (option)";
            this.CusAddressTxt.UnderlinedStyle = false;
            // 
            // CusPhoneTxt
            // 
            this.CusPhoneTxt.BackColor = System.Drawing.Color.White;
            this.CusPhoneTxt.BorderColor = System.Drawing.Color.LightGray;
            this.CusPhoneTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.CusPhoneTxt.BorderRadius = 10;
            this.CusPhoneTxt.BorderSize = 1;
            this.CusPhoneTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusPhoneTxt.ForeColor = System.Drawing.Color.LightGray;
            this.CusPhoneTxt.IsError = false;
            this.CusPhoneTxt.Location = new System.Drawing.Point(163, 78);
            this.CusPhoneTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CusPhoneTxt.MaxLength = 32767;
            this.CusPhoneTxt.Multiline = false;
            this.CusPhoneTxt.Name = "CusPhoneTxt";
            this.CusPhoneTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CusPhoneTxt.PasswordChar = false;
            this.CusPhoneTxt.Placeholder = "Please enter customer phone";
            this.CusPhoneTxt.ReadOnly = true;
            this.CusPhoneTxt.Size = new System.Drawing.Size(307, 38);
            this.CusPhoneTxt.TabIndex = 2;
            this.CusPhoneTxt.TbBackColor = System.Drawing.Color.White;
            this.CusPhoneTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.CusPhoneTxt.Texts = "Please enter customer phone";
            this.CusPhoneTxt.UnderlinedStyle = false;
            // 
            // UserInfoHeaderContainer
            // 
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.GoodsInfoHeader);
            this.UserInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            this.UserInfoHeaderContainer.Size = new System.Drawing.Size(520, 40);
            this.UserInfoHeaderContainer.TabIndex = 21;
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
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(520, 400);
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.UserInfoHeaderContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Booking";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Form";
            this.MainForm.ResumeLayout(false);
            this.BottomBtn.ResumeLayout(false);
            this.CustomerInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel CustomerInfo;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.CustomizeTextbox CusNameTxt;
        private System.Windows.Forms.Label GTINCode;
        private System.Windows.Forms.Label Catalogue;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox CusAddressTxt;
        private CustomizeControl.CustomizeTextbox CusPhoneTxt;
        private System.Windows.Forms.Panel BottomBtn;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private System.Windows.Forms.Label label2;
        private CustomizeControl.CustomizeTextbox depositTxt;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
    }
}