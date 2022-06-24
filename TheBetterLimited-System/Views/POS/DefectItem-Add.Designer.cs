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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectItem_Add));
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnAddSupplier = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.StockInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtExchange = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.cbExchange = new System.Windows.Forms.CheckBox();
            this.txtRefund = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.cbRefund = new System.Windows.Forms.CheckBox();
            this.lblOption = new System.Windows.Forms.Label();
            this.txtDesc = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.StockInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.StockInfoHeader = new System.Windows.Forms.Label();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.StockInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StockInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAddSupplier.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this.MainForm, "MainForm");
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.StockInfo);
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Name = "MainForm";
            // 
            // StockInfo
            // 
            resources.ApplyResources(this.StockInfo, "StockInfo");
            this.StockInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.StockInfo.Controls.Add(this.panel1);
            this.StockInfo.Controls.Add(this.StockInfoHeaderContainer);
            this.StockInfo.Name = "StockInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.txtExchange);
            this.panel1.Controls.Add(this.cbExchange);
            this.panel1.Controls.Add(this.txtRefund);
            this.panel1.Controls.Add(this.cbRefund);
            this.panel1.Controls.Add(this.lblOption);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Name = "panel1";
            // 
            // txtExchange
            // 
            resources.ApplyResources(this.txtExchange, "txtExchange");
            this.txtExchange.BackColor = System.Drawing.Color.White;
            this.txtExchange.BorderColor = System.Drawing.Color.LightGray;
            this.txtExchange.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtExchange.BorderRadius = 10;
            this.txtExchange.BorderSize = 1;
            this.txtExchange.ForeColor = System.Drawing.Color.Black;
            this.txtExchange.IsError = false;
            this.txtExchange.MaxLength = 32767;
            this.txtExchange.Multiline = false;
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.PasswordChar = false;
            this.txtExchange.Placeholder = "Please enter the quantity";
            this.txtExchange.ReadOnly = false;
            this.txtExchange.TbBackColor = System.Drawing.Color.White;
            this.txtExchange.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtExchange.Texts = "Please enter the quantity";
            this.txtExchange.UnderlinedStyle = false;
            // 
            // cbExchange
            // 
            resources.ApplyResources(this.cbExchange, "cbExchange");
            this.cbExchange.Name = "cbExchange";
            this.cbExchange.UseVisualStyleBackColor = true;
            this.cbExchange.CheckedChanged += new System.EventHandler(this.cbExchange_CheckedChanged);
            // 
            // txtRefund
            // 
            resources.ApplyResources(this.txtRefund, "txtRefund");
            this.txtRefund.BackColor = System.Drawing.Color.White;
            this.txtRefund.BorderColor = System.Drawing.Color.LightGray;
            this.txtRefund.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtRefund.BorderRadius = 10;
            this.txtRefund.BorderSize = 1;
            this.txtRefund.ForeColor = System.Drawing.Color.Black;
            this.txtRefund.IsError = false;
            this.txtRefund.MaxLength = 32767;
            this.txtRefund.Multiline = false;
            this.txtRefund.Name = "txtRefund";
            this.txtRefund.PasswordChar = false;
            this.txtRefund.Placeholder = "Please enter the quantity";
            this.txtRefund.ReadOnly = false;
            this.txtRefund.TbBackColor = System.Drawing.Color.White;
            this.txtRefund.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtRefund.Texts = "Please enter the quantity";
            this.txtRefund.UnderlinedStyle = false;
            // 
            // cbRefund
            // 
            resources.ApplyResources(this.cbRefund, "cbRefund");
            this.cbRefund.Name = "cbRefund";
            this.cbRefund.UseVisualStyleBackColor = true;
            this.cbRefund.CheckedChanged += new System.EventHandler(this.cbRefund_CheckedChanged);
            // 
            // lblOption
            // 
            resources.ApplyResources(this.lblOption, "lblOption");
            this.lblOption.Name = "lblOption";
            // 
            // txtDesc
            // 
            resources.ApplyResources(this.txtDesc, "txtDesc");
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderColor = System.Drawing.Color.LightGray;
            this.txtDesc.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtDesc.BorderRadius = 10;
            this.txtDesc.BorderSize = 1;
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.IsError = false;
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = false;
            this.txtDesc.Placeholder = "Please describe the damage of the product";
            this.txtDesc.ReadOnly = false;
            this.txtDesc.TbBackColor = System.Drawing.Color.White;
            this.txtDesc.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtDesc.Texts = "Please describe the damage of the product";
            this.txtDesc.UnderlinedStyle = false;
            this.txtDesc.Click += new System.EventHandler(this.txtDesc_Click);
            // 
            // lblQuantity
            // 
            resources.ApplyResources(this.lblQuantity, "lblQuantity");
            this.lblQuantity.Name = "lblQuantity";
            // 
            // StockInfoHeaderContainer
            // 
            resources.ApplyResources(this.StockInfoHeaderContainer, "StockInfoHeaderContainer");
            this.StockInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.StockInfoHeaderContainer.Controls.Add(this.StockInfoHeader);
            this.StockInfoHeaderContainer.Name = "StockInfoHeaderContainer";
            // 
            // StockInfoHeader
            // 
            resources.ApplyResources(this.StockInfoHeader, "StockInfoHeader");
            this.StockInfoHeader.Name = "StockInfoHeader";
            // 
            // DefectItem_Add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DefectItem_Add";
            this.ShowIcon = false;
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