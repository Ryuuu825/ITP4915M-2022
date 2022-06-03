namespace TheBetterLimited.Views
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
            this.StaffIDTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.GTINCode = new System.Windows.Forms.Label();
            this.Catalogue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeptTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StaffNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customizeTextbox1 = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
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
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(520, 457);
            this.MainForm.TabIndex = 3;
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(0, 403);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(520, 54);
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
            this.CancelBtn.Location = new System.Drawing.Point(86, 6);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(145, 40);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextColor = System.Drawing.Color.White;
            this.CancelBtn.UseVisualStyleBackColor = false;
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
            this.SaveBtn.Location = new System.Drawing.Point(285, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(145, 40);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.CustomerInfo.Controls.Add(this.panel1);
            this.CustomerInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.CustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(520, 457);
            this.CustomerInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.customizeTextbox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StaffIDTxt);
            this.panel1.Controls.Add(this.GTINCode);
            this.panel1.Controls.Add(this.Catalogue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DeptTxt);
            this.panel1.Controls.Add(this.StaffNameTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(520, 417);
            this.panel1.TabIndex = 27;
            // 
            // StaffIDTxt
            // 
            this.StaffIDTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.StaffIDTxt.BackColor = System.Drawing.Color.White;
            this.StaffIDTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StaffIDTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StaffIDTxt.BorderRadius = 10;
            this.StaffIDTxt.BorderSize = 1;
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
            this.StaffIDTxt.Size = new System.Drawing.Size(306, 38);
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
            this.GTINCode.Location = new System.Drawing.Point(51, 105);
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
            // 
            // DeptTxt
            // 
            this.DeptTxt.BackColor = System.Drawing.Color.White;
            this.DeptTxt.BorderColor = System.Drawing.Color.LightGray;
            this.DeptTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.DeptTxt.BorderRadius = 10;
            this.DeptTxt.BorderSize = 1;
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
            this.DeptTxt.Size = new System.Drawing.Size(307, 109);
            this.DeptTxt.TabIndex = 25;
            this.DeptTxt.TbBackColor = System.Drawing.Color.White;
            this.DeptTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.DeptTxt.Texts = "";
            this.DeptTxt.UnderlinedStyle = false;
            // 
            // StaffNameTxt
            // 
            this.StaffNameTxt.BackColor = System.Drawing.Color.White;
            this.StaffNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StaffNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StaffNameTxt.BorderRadius = 10;
            this.StaffNameTxt.BorderSize = 1;
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
            this.StaffNameTxt.Size = new System.Drawing.Size(307, 38);
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
            this.UserInfoHeaderContainer.Size = new System.Drawing.Size(520, 40);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Deposit";
            // 
            // customizeTextbox1
            // 
            this.customizeTextbox1.BackColor = System.Drawing.Color.White;
            this.customizeTextbox1.BorderColor = System.Drawing.Color.LightGray;
            this.customizeTextbox1.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.customizeTextbox1.BorderRadius = 10;
            this.customizeTextbox1.BorderSize = 1;
            this.customizeTextbox1.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizeTextbox1.ForeColor = System.Drawing.Color.LightGray;
            this.customizeTextbox1.IsError = false;
            this.customizeTextbox1.Location = new System.Drawing.Point(164, 226);
            this.customizeTextbox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customizeTextbox1.MaxLength = 32767;
            this.customizeTextbox1.Multiline = false;
            this.customizeTextbox1.Name = "customizeTextbox1";
            this.customizeTextbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customizeTextbox1.PasswordChar = false;
            this.customizeTextbox1.Placeholder = "";
            this.customizeTextbox1.ReadOnly = true;
            this.customizeTextbox1.Size = new System.Drawing.Size(307, 38);
            this.customizeTextbox1.TabIndex = 27;
            this.customizeTextbox1.TbBackColor = System.Drawing.Color.White;
            this.customizeTextbox1.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.customizeTextbox1.Texts = "";
            this.customizeTextbox1.UnderlinedStyle = false;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(520, 457);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Booking";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Information";
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
        private CustomizeControl.CustomizeTextbox StaffIDTxt;
        private System.Windows.Forms.Label GTINCode;
        private System.Windows.Forms.Label Catalogue;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox DeptTxt;
        private CustomizeControl.CustomizeTextbox StaffNameTxt;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private System.Windows.Forms.Panel BottomBtn;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private System.Windows.Forms.Label label2;
        private CustomizeControl.CustomizeTextbox customizeTextbox1;
    }
}