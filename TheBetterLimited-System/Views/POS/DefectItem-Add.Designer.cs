namespace TheBetterLimited.Views
{
    partial class DefectItem_Add
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
            this.StockInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.StockInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.StockInfoHeader = new System.Windows.Forms.Label();
            this.lblOption = new System.Windows.Forms.Label();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnAddSupplier = new TheBetterLimited.CustomizeControl.RoundButton();
            this.txtDesc = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.cbRefund = new System.Windows.Forms.CheckBox();
            this.txtRefund = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtExchange = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.cbExchange = new System.Windows.Forms.CheckBox();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.StockInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StockInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.btnCancel);
            this.BottomBtn.Controls.Add(this.btnAddSupplier);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 365);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(467, 54);
            this.BottomBtn.TabIndex = 1;
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.StockInfo);
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(487, 429);
            this.MainForm.TabIndex = 2;
            // 
            // StockInfo
            // 
            this.StockInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.StockInfo.Controls.Add(this.panel1);
            this.StockInfo.Controls.Add(this.StockInfoHeaderContainer);
            this.StockInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockInfo.Location = new System.Drawing.Point(10, 10);
            this.StockInfo.Name = "StockInfo";
            this.StockInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.StockInfo.Size = new System.Drawing.Size(467, 355);
            this.StockInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.txtExchange);
            this.panel1.Controls.Add(this.cbExchange);
            this.panel1.Controls.Add(this.txtRefund);
            this.panel1.Controls.Add(this.cbRefund);
            this.panel1.Controls.Add(this.lblOption);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 305);
            this.panel1.TabIndex = 27;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(32, 210);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(89, 21);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Description";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StockInfoHeaderContainer
            // 
            this.StockInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.StockInfoHeaderContainer.Controls.Add(this.StockInfoHeader);
            this.StockInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.StockInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.StockInfoHeaderContainer.Name = "StockInfoHeaderContainer";
            this.StockInfoHeaderContainer.Size = new System.Drawing.Size(467, 40);
            this.StockInfoHeaderContainer.TabIndex = 20;
            // 
            // StockInfoHeader
            // 
            this.StockInfoHeader.AutoSize = true;
            this.StockInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.StockInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StockInfoHeader.Name = "StockInfoHeader";
            this.StockInfoHeader.Size = new System.Drawing.Size(243, 25);
            this.StockInfoHeader.TabIndex = 6;
            this.StockInfoHeader.Text = "Defetive Item Information";
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.Location = new System.Drawing.Point(32, 18);
            this.lblOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(87, 21);
            this.lblOption.TabIndex = 44;
            this.lblOption.Text = "Operation";
            this.lblOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnCancel.Location = new System.Drawing.Point(86, 6);
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
            this.btnAddSupplier.Location = new System.Drawing.Point(253, 6);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(128, 40);
            this.btnAddSupplier.TabIndex = 6;
            this.btnAddSupplier.Text = "Comfirm";
            this.btnAddSupplier.TextColor = System.Drawing.Color.White;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderColor = System.Drawing.Color.LightGray;
            this.txtDesc.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtDesc.BorderRadius = 10;
            this.txtDesc.BorderSize = 1;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.IsError = false;
            this.txtDesc.Location = new System.Drawing.Point(153, 156);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDesc.PasswordChar = false;
            this.txtDesc.Placeholder = "Please describe the damage of the product";
            this.txtDesc.ReadOnly = false;
            this.txtDesc.Size = new System.Drawing.Size(275, 128);
            this.txtDesc.TabIndex = 40;
            this.txtDesc.TbBackColor = System.Drawing.Color.White;
            this.txtDesc.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtDesc.Texts = "Please describe the damage of the product";
            this.txtDesc.UnderlinedStyle = false;
            this.txtDesc.Click += new System.EventHandler(this.txtDesc_Click);
            // 
            // cbRefund
            // 
            this.cbRefund.AutoSize = true;
            this.cbRefund.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRefund.Location = new System.Drawing.Point(33, 63);
            this.cbRefund.Name = "cbRefund";
            this.cbRefund.Size = new System.Drawing.Size(79, 25);
            this.cbRefund.TabIndex = 45;
            this.cbRefund.Text = "Refund";
            this.cbRefund.UseVisualStyleBackColor = true;
            this.cbRefund.CheckedChanged += new System.EventHandler(this.cbRefund_CheckedChanged);
            // 
            // txtRefund
            // 
            this.txtRefund.BackColor = System.Drawing.Color.White;
            this.txtRefund.BorderColor = System.Drawing.Color.LightGray;
            this.txtRefund.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtRefund.BorderRadius = 10;
            this.txtRefund.BorderSize = 1;
            this.txtRefund.Enabled = false;
            this.txtRefund.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefund.ForeColor = System.Drawing.Color.Black;
            this.txtRefund.IsError = false;
            this.txtRefund.Location = new System.Drawing.Point(153, 56);
            this.txtRefund.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtRefund.MaxLength = 32767;
            this.txtRefund.Multiline = false;
            this.txtRefund.Name = "txtRefund";
            this.txtRefund.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRefund.PasswordChar = false;
            this.txtRefund.Placeholder = "Please enter the quantity";
            this.txtRefund.ReadOnly = false;
            this.txtRefund.Size = new System.Drawing.Size(275, 38);
            this.txtRefund.TabIndex = 46;
            this.txtRefund.TbBackColor = System.Drawing.Color.White;
            this.txtRefund.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtRefund.Texts = "Please enter the quantity";
            this.txtRefund.UnderlinedStyle = false;
            // 
            // txtExchange
            // 
            this.txtExchange.BackColor = System.Drawing.Color.White;
            this.txtExchange.BorderColor = System.Drawing.Color.LightGray;
            this.txtExchange.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtExchange.BorderRadius = 10;
            this.txtExchange.BorderSize = 1;
            this.txtExchange.Enabled = false;
            this.txtExchange.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExchange.ForeColor = System.Drawing.Color.Black;
            this.txtExchange.IsError = false;
            this.txtExchange.Location = new System.Drawing.Point(153, 106);
            this.txtExchange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtExchange.MaxLength = 32767;
            this.txtExchange.Multiline = false;
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtExchange.PasswordChar = false;
            this.txtExchange.Placeholder = "Please enter the quantity";
            this.txtExchange.ReadOnly = false;
            this.txtExchange.Size = new System.Drawing.Size(275, 38);
            this.txtExchange.TabIndex = 48;
            this.txtExchange.TbBackColor = System.Drawing.Color.White;
            this.txtExchange.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtExchange.Texts = "Please enter the quantity";
            this.txtExchange.UnderlinedStyle = false;
            // 
            // cbExchange
            // 
            this.cbExchange.AutoSize = true;
            this.cbExchange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExchange.Location = new System.Drawing.Point(33, 113);
            this.cbExchange.Name = "cbExchange";
            this.cbExchange.Size = new System.Drawing.Size(94, 25);
            this.cbExchange.TabIndex = 47;
            this.cbExchange.Text = "Exchange";
            this.cbExchange.UseVisualStyleBackColor = true;
            this.cbExchange.CheckedChanged += new System.EventHandler(this.cbExchange_CheckedChanged);
            // 
            // DefectItem_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(487, 429);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "DefectItem_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Defect Item";
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.StockInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StockInfoHeaderContainer.ResumeLayout(false);
            this.StockInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel StockInfo;
        private System.Windows.Forms.Panel StockInfoHeaderContainer;
        private System.Windows.Forms.Label StockInfoHeader;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnAddSupplier;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.CustomizeTextbox txtDesc;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.CheckBox cbRefund;
        private CustomizeControl.CustomizeTextbox txtExchange;
        private System.Windows.Forms.CheckBox cbExchange;
        private CustomizeControl.CustomizeTextbox txtRefund;
    }
}