namespace TheBetterLimited.Views
{
    partial class Stock_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Add));
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnAddSupplier = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.StockInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SizeGroup = new System.Windows.Forms.Panel();
            this.roundPanel4 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.roundPanel5 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.roundPanel6 = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.staffName = new System.Windows.Forms.Label();
            this.DeptTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StaffNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtReorderLevel = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtQuantity = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtMinLimit = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblMinLimit = new System.Windows.Forms.Label();
            this.txtMaxLimit = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblMaxLimit = new System.Windows.Forms.Label();
            this.lblSupplierGoodsId = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtSupplierGoodsId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.StockInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.StockInfoHeader = new System.Windows.Forms.Label();
            this.SearchStaffBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.StockInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SizeGroup.SuspendLayout();
            this.roundPanel4.SuspendLayout();
            this.roundPanel5.SuspendLayout();
            this.roundPanel6.SuspendLayout();
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
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.StockInfo);
            this.MainForm.Name = "MainForm";
            // 
            // StockInfo
            // 
            resources.ApplyResources(this.StockInfo, "StockInfo");
            this.StockInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.StockInfo.Controls.Add(this.panel1);
            this.StockInfo.Controls.Add(this.StockInfoHeaderContainer);
            this.StockInfo.Name = "StockInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.SizeGroup);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.SearchStaffBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.staffName);
            this.panel1.Controls.Add(this.DeptTxt);
            this.panel1.Controls.Add(this.StaffNameTxt);
            this.panel1.Controls.Add(this.txtReorderLevel);
            this.panel1.Controls.Add(this.lblReorderLevel);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtMinLimit);
            this.panel1.Controls.Add(this.lblMinLimit);
            this.panel1.Controls.Add(this.txtMaxLimit);
            this.panel1.Controls.Add(this.lblMaxLimit);
            this.panel1.Controls.Add(this.lblSupplierGoodsId);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.txtSupplierGoodsId);
            this.panel1.Name = "panel1";
            // 
            // SizeGroup
            // 
            resources.ApplyResources(this.SizeGroup, "SizeGroup");
            this.SizeGroup.Controls.Add(this.roundPanel4);
            this.SizeGroup.Controls.Add(this.roundPanel5);
            this.SizeGroup.Controls.Add(this.roundPanel6);
            this.SizeGroup.Name = "SizeGroup";
            // 
            // roundPanel4
            // 
            resources.ApplyResources(this.roundPanel4, "roundPanel4");
            this.roundPanel4.BackColor = System.Drawing.Color.White;
            this.roundPanel4.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel4.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel4.BorderRadius = 5;
            this.roundPanel4.BorderSize = 1;
            this.roundPanel4.Controls.Add(this.label4);
            this.roundPanel4.ForeColor = System.Drawing.Color.White;
            this.roundPanel4.Name = "roundPanel4";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Name = "label4";
            // 
            // roundPanel5
            // 
            resources.ApplyResources(this.roundPanel5, "roundPanel5");
            this.roundPanel5.BackColor = System.Drawing.Color.White;
            this.roundPanel5.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel5.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel5.BorderRadius = 5;
            this.roundPanel5.BorderSize = 1;
            this.roundPanel5.Controls.Add(this.label5);
            this.roundPanel5.ForeColor = System.Drawing.Color.White;
            this.roundPanel5.Name = "roundPanel5";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Name = "label5";
            // 
            // roundPanel6
            // 
            resources.ApplyResources(this.roundPanel6, "roundPanel6");
            this.roundPanel6.BackColor = System.Drawing.Color.White;
            this.roundPanel6.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel6.BorderColor = System.Drawing.Color.LightGray;
            this.roundPanel6.BorderRadius = 5;
            this.roundPanel6.BorderSize = 1;
            this.roundPanel6.Controls.Add(this.label6);
            this.roundPanel6.ForeColor = System.Drawing.Color.White;
            this.roundPanel6.Name = "roundPanel6";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Name = "label6";
            // 
            // lblSize
            // 
            resources.ApplyResources(this.lblSize, "lblSize");
            this.lblSize.Name = "lblSize";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // staffName
            // 
            resources.ApplyResources(this.staffName, "staffName");
            this.staffName.Name = "staffName";
            // 
            // DeptTxt
            // 
            resources.ApplyResources(this.DeptTxt, "DeptTxt");
            this.DeptTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeptTxt.BorderColor = System.Drawing.Color.LightGray;
            this.DeptTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.DeptTxt.BorderRadius = 10;
            this.DeptTxt.BorderSize = 1;
            this.DeptTxt.ForeColor = System.Drawing.Color.Black;
            this.DeptTxt.IsError = false;
            this.DeptTxt.MaxLength = 32767;
            this.DeptTxt.Multiline = false;
            this.DeptTxt.Name = "DeptTxt";
            this.DeptTxt.PasswordChar = false;
            this.DeptTxt.Placeholder = "";
            this.DeptTxt.ReadOnly = false;
            this.DeptTxt.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.DeptTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.DeptTxt.Texts = "Automatic Data Entry";
            this.DeptTxt.UnderlinedStyle = false;
            // 
            // StaffNameTxt
            // 
            resources.ApplyResources(this.StaffNameTxt, "StaffNameTxt");
            this.StaffNameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.StaffNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.StaffNameTxt.BorderRadius = 10;
            this.StaffNameTxt.BorderSize = 1;
            this.StaffNameTxt.ForeColor = System.Drawing.Color.Black;
            this.StaffNameTxt.IsError = false;
            this.StaffNameTxt.MaxLength = 32767;
            this.StaffNameTxt.Multiline = true;
            this.StaffNameTxt.Name = "StaffNameTxt";
            this.StaffNameTxt.PasswordChar = false;
            this.StaffNameTxt.Placeholder = "";
            this.StaffNameTxt.ReadOnly = false;
            this.StaffNameTxt.TbBackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.StaffNameTxt.Texts = "Automatic Data Entry";
            this.StaffNameTxt.UnderlinedStyle = false;
            // 
            // txtReorderLevel
            // 
            resources.ApplyResources(this.txtReorderLevel, "txtReorderLevel");
            this.txtReorderLevel.BackColor = System.Drawing.Color.White;
            this.txtReorderLevel.BorderColor = System.Drawing.Color.LightGray;
            this.txtReorderLevel.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtReorderLevel.BorderRadius = 10;
            this.txtReorderLevel.BorderSize = 1;
            this.txtReorderLevel.ForeColor = System.Drawing.Color.Black;
            this.txtReorderLevel.IsError = false;
            this.txtReorderLevel.MaxLength = 32767;
            this.txtReorderLevel.Multiline = false;
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.PasswordChar = false;
            this.txtReorderLevel.Placeholder = "Please enter the reorder level";
            this.txtReorderLevel.ReadOnly = false;
            this.txtReorderLevel.TbBackColor = System.Drawing.Color.White;
            this.txtReorderLevel.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtReorderLevel.Texts = "Please enter the reorder level";
            this.txtReorderLevel.UnderlinedStyle = false;
            // 
            // lblReorderLevel
            // 
            resources.ApplyResources(this.lblReorderLevel, "lblReorderLevel");
            this.lblReorderLevel.Name = "lblReorderLevel";
            // 
            // txtQuantity
            // 
            resources.ApplyResources(this.txtQuantity, "txtQuantity");
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.LightGray;
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtQuantity.BorderRadius = 10;
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.IsError = false;
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.Placeholder = "Please enter the quantity";
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.TbBackColor = System.Drawing.Color.White;
            this.txtQuantity.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtQuantity.Texts = "Please enter the quantity";
            this.txtQuantity.UnderlinedStyle = false;
            // 
            // txtMinLimit
            // 
            resources.ApplyResources(this.txtMinLimit, "txtMinLimit");
            this.txtMinLimit.BackColor = System.Drawing.Color.White;
            this.txtMinLimit.BorderColor = System.Drawing.Color.LightGray;
            this.txtMinLimit.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtMinLimit.BorderRadius = 10;
            this.txtMinLimit.BorderSize = 1;
            this.txtMinLimit.ForeColor = System.Drawing.Color.Black;
            this.txtMinLimit.IsError = false;
            this.txtMinLimit.MaxLength = 32767;
            this.txtMinLimit.Multiline = false;
            this.txtMinLimit.Name = "txtMinLimit";
            this.txtMinLimit.PasswordChar = false;
            this.txtMinLimit.Placeholder = "Please enter the minimum limit";
            this.txtMinLimit.ReadOnly = false;
            this.txtMinLimit.TbBackColor = System.Drawing.Color.White;
            this.txtMinLimit.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtMinLimit.Texts = "Please enter the minimum limit";
            this.txtMinLimit.UnderlinedStyle = false;
            // 
            // lblMinLimit
            // 
            resources.ApplyResources(this.lblMinLimit, "lblMinLimit");
            this.lblMinLimit.Name = "lblMinLimit";
            // 
            // txtMaxLimit
            // 
            resources.ApplyResources(this.txtMaxLimit, "txtMaxLimit");
            this.txtMaxLimit.BackColor = System.Drawing.Color.White;
            this.txtMaxLimit.BorderColor = System.Drawing.Color.LightGray;
            this.txtMaxLimit.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtMaxLimit.BorderRadius = 10;
            this.txtMaxLimit.BorderSize = 1;
            this.txtMaxLimit.ForeColor = System.Drawing.Color.Black;
            this.txtMaxLimit.IsError = false;
            this.txtMaxLimit.MaxLength = 32767;
            this.txtMaxLimit.Multiline = false;
            this.txtMaxLimit.Name = "txtMaxLimit";
            this.txtMaxLimit.PasswordChar = false;
            this.txtMaxLimit.Placeholder = "Please enter the maximum limit";
            this.txtMaxLimit.ReadOnly = false;
            this.txtMaxLimit.TbBackColor = System.Drawing.Color.White;
            this.txtMaxLimit.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtMaxLimit.Texts = "Please enter the maximum limit";
            this.txtMaxLimit.UnderlinedStyle = false;
            // 
            // lblMaxLimit
            // 
            resources.ApplyResources(this.lblMaxLimit, "lblMaxLimit");
            this.lblMaxLimit.Name = "lblMaxLimit";
            // 
            // lblSupplierGoodsId
            // 
            resources.ApplyResources(this.lblSupplierGoodsId, "lblSupplierGoodsId");
            this.lblSupplierGoodsId.Name = "lblSupplierGoodsId";
            // 
            // lblQuantity
            // 
            resources.ApplyResources(this.lblQuantity, "lblQuantity");
            this.lblQuantity.Name = "lblQuantity";
            // 
            // txtSupplierGoodsId
            // 
            resources.ApplyResources(this.txtSupplierGoodsId, "txtSupplierGoodsId");
            this.txtSupplierGoodsId.BackColor = System.Drawing.Color.White;
            this.txtSupplierGoodsId.BorderColor = System.Drawing.Color.LightGray;
            this.txtSupplierGoodsId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtSupplierGoodsId.BorderRadius = 10;
            this.txtSupplierGoodsId.BorderSize = 1;
            this.txtSupplierGoodsId.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierGoodsId.IsError = false;
            this.txtSupplierGoodsId.MaxLength = 32767;
            this.txtSupplierGoodsId.Multiline = false;
            this.txtSupplierGoodsId.Name = "txtSupplierGoodsId";
            this.txtSupplierGoodsId.PasswordChar = false;
            this.txtSupplierGoodsId.Placeholder = "Automatically generated";
            this.txtSupplierGoodsId.ReadOnly = false;
            this.txtSupplierGoodsId.TbBackColor = System.Drawing.Color.White;
            this.txtSupplierGoodsId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtSupplierGoodsId.Texts = "Automatically generated";
            this.txtSupplierGoodsId.UnderlinedStyle = false;
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
            // SearchStaffBtn
            // 
            resources.ApplyResources(this.SearchStaffBtn, "SearchStaffBtn");
            this.SearchStaffBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchStaffBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.SearchStaffBtn.BackgroundImage = global::TheBetterLimited.Properties.Resources.search;
            this.SearchStaffBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SearchStaffBtn.BorderRadius = 0;
            this.SearchStaffBtn.BorderSize = 0;
            this.SearchStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchStaffBtn.FlatAppearance.BorderSize = 0;
            this.SearchStaffBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SearchStaffBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SearchStaffBtn.ForeColor = System.Drawing.Color.White;
            this.SearchStaffBtn.IsChecked = false;
            this.SearchStaffBtn.Name = "SearchStaffBtn";
            this.SearchStaffBtn.TextColor = System.Drawing.Color.White;
            this.SearchStaffBtn.UseVisualStyleBackColor = false;
            this.SearchStaffBtn.Click += new System.EventHandler(this.SearchStaffBtn_Click);
            // 
            // Stock_Add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Stock_Add";
            this.ShowIcon = false;
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.StockInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SizeGroup.ResumeLayout(false);
            this.roundPanel4.ResumeLayout(false);
            this.roundPanel4.PerformLayout();
            this.roundPanel5.ResumeLayout(false);
            this.roundPanel5.PerformLayout();
            this.roundPanel6.ResumeLayout(false);
            this.roundPanel6.PerformLayout();
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
        private CustomizeControl.CustomizeTextbox txtReorderLevel;
        private System.Windows.Forms.Label lblReorderLevel;
        private CustomizeControl.CustomizeTextbox txtQuantity;
        private CustomizeControl.CustomizeTextbox txtMinLimit;
        private System.Windows.Forms.Label lblMinLimit;
        private CustomizeControl.CustomizeTextbox txtMaxLimit;
        private System.Windows.Forms.Label lblMaxLimit;
        private System.Windows.Forms.Label lblSupplierGoodsId;
        private System.Windows.Forms.Label lblQuantity;
        private CustomizeControl.CustomizeTextbox txtSupplierGoodsId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label staffName;
        private CustomizeControl.CustomizeTextbox DeptTxt;
        private CustomizeControl.CustomizeTextbox StaffNameTxt;
        private CustomizeControl.RoundButton SearchStaffBtn;
        private System.Windows.Forms.Panel SizeGroup;
        private CustomizeControl.RoundPanel roundPanel4;
        private System.Windows.Forms.Label label4;
        private CustomizeControl.RoundPanel roundPanel5;
        private System.Windows.Forms.Label label5;
        private CustomizeControl.RoundPanel roundPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSize;
    }
}