namespace TheBetterLimited.Views
{
    partial class Stock_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Edit));
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnSave = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.StockInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.txtGoodsName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtReorderLevel = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtLocId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtQuantity = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtMinLimit = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblMinLimit = new System.Windows.Forms.Label();
            this.txtMaxLimit = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblMaxLimit = new System.Windows.Forms.Label();
            this.txtId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblSupplierGoodsId = new System.Windows.Forms.Label();
            this.lblLocationId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtSupplierGoodsId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
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
            this.BottomBtn.Controls.Add(this.btnSave);
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
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IsChecked = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.CreateUser_Click);
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
            this.StockInfo.BackColor = System.Drawing.Color.Transparent;
            this.StockInfo.Controls.Add(this.panel1);
            this.StockInfo.Controls.Add(this.StockInfoHeaderContainer);
            this.StockInfo.Name = "StockInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.subBtn);
            this.panel1.Controls.Add(this.plusBtn);
            this.panel1.Controls.Add(this.lblGoodsName);
            this.panel1.Controls.Add(this.txtGoodsName);
            this.panel1.Controls.Add(this.txtReorderLevel);
            this.panel1.Controls.Add(this.lblReorderLevel);
            this.panel1.Controls.Add(this.txtLocId);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtMinLimit);
            this.panel1.Controls.Add(this.lblMinLimit);
            this.panel1.Controls.Add(this.txtMaxLimit);
            this.panel1.Controls.Add(this.lblMaxLimit);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblSupplierGoodsId);
            this.panel1.Controls.Add(this.lblLocationId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.txtSupplierGoodsId);
            this.panel1.Name = "panel1";
            // 
            // subBtn
            // 
            resources.ApplyResources(this.subBtn, "subBtn");
            this.subBtn.BackgroundImage = global::TheBetterLimited.Properties.Resources.minus;
            this.subBtn.FlatAppearance.BorderSize = 0;
            this.subBtn.Name = "subBtn";
            this.subBtn.UseVisualStyleBackColor = true;
            // 
            // plusBtn
            // 
            resources.ApplyResources(this.plusBtn, "plusBtn");
            this.plusBtn.BackgroundImage = global::TheBetterLimited.Properties.Resources.plus24;
            this.plusBtn.FlatAppearance.BorderSize = 0;
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.UseVisualStyleBackColor = true;
            // 
            // lblGoodsName
            // 
            resources.ApplyResources(this.lblGoodsName, "lblGoodsName");
            this.lblGoodsName.Name = "lblGoodsName";
            // 
            // txtGoodsName
            // 
            resources.ApplyResources(this.txtGoodsName, "txtGoodsName");
            this.txtGoodsName.BackColor = System.Drawing.Color.White;
            this.txtGoodsName.BorderColor = System.Drawing.Color.LightGray;
            this.txtGoodsName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtGoodsName.BorderRadius = 10;
            this.txtGoodsName.BorderSize = 1;
            this.txtGoodsName.ForeColor = System.Drawing.Color.Black;
            this.txtGoodsName.IsError = false;
            this.txtGoodsName.MaxLength = 32767;
            this.txtGoodsName.Multiline = true;
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.PasswordChar = false;
            this.txtGoodsName.Placeholder = "Automatically generated";
            this.txtGoodsName.ReadOnly = true;
            this.txtGoodsName.TbBackColor = System.Drawing.Color.White;
            this.txtGoodsName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtGoodsName.Texts = "Automatically generated";
            this.txtGoodsName.UnderlinedStyle = false;
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
            // txtLocId
            // 
            resources.ApplyResources(this.txtLocId, "txtLocId");
            this.txtLocId.BackColor = System.Drawing.Color.White;
            this.txtLocId.BorderColor = System.Drawing.Color.LightGray;
            this.txtLocId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtLocId.BorderRadius = 10;
            this.txtLocId.BorderSize = 1;
            this.txtLocId.ForeColor = System.Drawing.Color.Black;
            this.txtLocId.IsError = false;
            this.txtLocId.MaxLength = 32767;
            this.txtLocId.Multiline = false;
            this.txtLocId.Name = "txtLocId";
            this.txtLocId.PasswordChar = false;
            this.txtLocId.Placeholder = "Automatically generated";
            this.txtLocId.ReadOnly = true;
            this.txtLocId.TbBackColor = System.Drawing.Color.White;
            this.txtLocId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtLocId.Texts = "Automatically generated";
            this.txtLocId.UnderlinedStyle = false;
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
            this.txtQuantity.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
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
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.LightGray;
            this.txtId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtId.BorderRadius = 10;
            this.txtId.BorderSize = 1;
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.IsError = false;
            this.txtId.MaxLength = 5;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = false;
            this.txtId.Placeholder = "Automatically Generated";
            this.txtId.ReadOnly = true;
            this.txtId.TbBackColor = System.Drawing.Color.White;
            this.txtId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtId.Texts = "Automatically Generated";
            this.txtId.UnderlinedStyle = false;
            this.txtId._TextChanged += new System.EventHandler(this.StaffIDTxt__TextChanged);
            this.txtId.Click += new System.EventHandler(this.StaffIDTxt_Click);
            this.txtId.Enter += new System.EventHandler(this.StaffIDTxt_Enter);
            this.txtId.Leave += new System.EventHandler(this.StaffIDTxt_Leave);
            // 
            // lblSupplierGoodsId
            // 
            resources.ApplyResources(this.lblSupplierGoodsId, "lblSupplierGoodsId");
            this.lblSupplierGoodsId.Name = "lblSupplierGoodsId";
            // 
            // lblLocationId
            // 
            resources.ApplyResources(this.lblLocationId, "lblLocationId");
            this.lblLocationId.Name = "lblLocationId";
            // 
            // lblId
            // 
            resources.ApplyResources(this.lblId, "lblId");
            this.lblId.Name = "lblId";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
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
            this.txtSupplierGoodsId.ReadOnly = true;
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
            // Stock_Edit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Stock_Edit";
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
        private CustomizeControl.RoundButton btnSave;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.CustomizeTextbox txtReorderLevel;
        private System.Windows.Forms.Label lblReorderLevel;
        private CustomizeControl.CustomizeTextbox txtLocId;
        private CustomizeControl.CustomizeTextbox txtQuantity;
        private CustomizeControl.CustomizeTextbox txtMinLimit;
        private System.Windows.Forms.Label lblMinLimit;
        private CustomizeControl.CustomizeTextbox txtMaxLimit;
        private System.Windows.Forms.Label lblMaxLimit;
        private CustomizeControl.CustomizeTextbox txtId;
        private System.Windows.Forms.Label lblSupplierGoodsId;
        private System.Windows.Forms.Label lblLocationId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblQuantity;
        private CustomizeControl.CustomizeTextbox txtSupplierGoodsId;
        private System.Windows.Forms.Label lblGoodsName;
        private CustomizeControl.CustomizeTextbox txtGoodsName;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button subBtn;
    }
}