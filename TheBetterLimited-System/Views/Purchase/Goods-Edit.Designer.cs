namespace TheBetterLimited.Views
{
    partial class Goods_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goods_Edit));
            this.Header = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnSave = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.UserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxStatus = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.cbxSize = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.cbxCatalogue = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtGTINCode = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblGTIＮCode = new System.Windows.Forms.Label();
            this.txtPrice = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtGoodsId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.lblCatalogue = new System.Windows.Forms.Label();
            this.lblGoodsId = new System.Windows.Forms.Label();
            this.txtDescription = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtGoodsName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.GoodsPic = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.UserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserInfoHeaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            resources.ApplyResources(this.Header, "Header");
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Info);
            this.Header.Controls.Add(this.tip);
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.GoodsPic);
            this.Header.Name = "Header";
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
            // 
            // tip
            // 
            resources.ApplyResources(this.tip, "tip");
            this.tip.Name = "tip";
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.Color.SeaGreen;
            this.Title.Name = "Title";
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
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.UserInfo);
            this.MainForm.Name = "MainForm";
            // 
            // UserInfo
            // 
            resources.ApplyResources(this.UserInfo, "UserInfo");
            this.UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.UserInfo.Controls.Add(this.panel1);
            this.UserInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.UserInfo.Name = "UserInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.cbxStatus);
            this.panel1.Controls.Add(this.cbxSize);
            this.panel1.Controls.Add(this.cbxCatalogue);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.txtGTINCode);
            this.panel1.Controls.Add(this.lblGTIＮCode);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.txtGoodsId);
            this.panel1.Controls.Add(this.lblGoodsName);
            this.panel1.Controls.Add(this.lblCatalogue);
            this.panel1.Controls.Add(this.lblGoodsId);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.txtGoodsName);
            this.panel1.Name = "panel1";
            // 
            // cbxStatus
            // 
            resources.ApplyResources(this.cbxStatus, "cbxStatus");
            this.cbxStatus.BackColor = System.Drawing.Color.White;
            this.cbxStatus.BorderColor = System.Drawing.Color.LightGray;
            this.cbxStatus.BorderRadius = 1;
            this.cbxStatus.BorderSize = 1;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cbxStatus.IconColor = System.Drawing.Color.LightGray;
            this.cbxStatus.ListBackColor = System.Drawing.Color.White;
            this.cbxStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Texts = "";
            this.cbxStatus.UnderlinedStyle = false;
            // 
            // cbxSize
            // 
            resources.ApplyResources(this.cbxSize, "cbxSize");
            this.cbxSize.BackColor = System.Drawing.Color.White;
            this.cbxSize.BorderColor = System.Drawing.Color.LightGray;
            this.cbxSize.BorderRadius = 1;
            this.cbxSize.BorderSize = 1;
            this.cbxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSize.ForeColor = System.Drawing.Color.DimGray;
            this.cbxSize.IconColor = System.Drawing.Color.LightGray;
            this.cbxSize.ListBackColor = System.Drawing.Color.White;
            this.cbxSize.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Texts = "";
            this.cbxSize.UnderlinedStyle = false;
            // 
            // cbxCatalogue
            // 
            resources.ApplyResources(this.cbxCatalogue, "cbxCatalogue");
            this.cbxCatalogue.BackColor = System.Drawing.Color.White;
            this.cbxCatalogue.BorderColor = System.Drawing.Color.LightGray;
            this.cbxCatalogue.BorderRadius = 1;
            this.cbxCatalogue.BorderSize = 1;
            this.cbxCatalogue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxCatalogue.ForeColor = System.Drawing.Color.Black;
            this.cbxCatalogue.IconColor = System.Drawing.Color.LightGray;
            this.cbxCatalogue.ListBackColor = System.Drawing.Color.White;
            this.cbxCatalogue.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxCatalogue.Name = "cbxCatalogue";
            this.cbxCatalogue.Texts = "";
            this.cbxCatalogue.UnderlinedStyle = false;
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // lblSize
            // 
            resources.ApplyResources(this.lblSize, "lblSize");
            this.lblSize.Name = "lblSize";
            // 
            // txtGTINCode
            // 
            resources.ApplyResources(this.txtGTINCode, "txtGTINCode");
            this.txtGTINCode.BackColor = System.Drawing.Color.White;
            this.txtGTINCode.BorderColor = System.Drawing.Color.LightGray;
            this.txtGTINCode.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtGTINCode.BorderRadius = 10;
            this.txtGTINCode.BorderSize = 1;
            this.txtGTINCode.ForeColor = System.Drawing.Color.Black;
            this.txtGTINCode.IsError = false;
            this.txtGTINCode.MaxLength = 32767;
            this.txtGTINCode.Multiline = false;
            this.txtGTINCode.Name = "txtGTINCode";
            this.txtGTINCode.PasswordChar = false;
            this.txtGTINCode.Placeholder = "Please enter the GTINCode";
            this.txtGTINCode.ReadOnly = false;
            this.txtGTINCode.TbBackColor = System.Drawing.Color.White;
            this.txtGTINCode.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtGTINCode.Texts = "Please enter the GTINCode";
            this.txtGTINCode.UnderlinedStyle = false;
            // 
            // lblGTIＮCode
            // 
            resources.ApplyResources(this.lblGTIＮCode, "lblGTIＮCode");
            this.lblGTIＮCode.Name = "lblGTIＮCode";
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.LightGray;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtPrice.BorderRadius = 10;
            this.txtPrice.BorderSize = 1;
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.IsError = false;
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = false;
            this.txtPrice.Placeholder = "Please enter the price";
            this.txtPrice.ReadOnly = false;
            this.txtPrice.TbBackColor = System.Drawing.Color.White;
            this.txtPrice.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtPrice.Texts = "Please enter the price";
            this.txtPrice.UnderlinedStyle = false;
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.Name = "lblPrice";
            // 
            // txtGoodsId
            // 
            resources.ApplyResources(this.txtGoodsId, "txtGoodsId");
            this.txtGoodsId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtGoodsId.BackColor = System.Drawing.Color.White;
            this.txtGoodsId.BorderColor = System.Drawing.Color.LightGray;
            this.txtGoodsId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtGoodsId.BorderRadius = 10;
            this.txtGoodsId.BorderSize = 1;
            this.txtGoodsId.ForeColor = System.Drawing.Color.Black;
            this.txtGoodsId.IsError = false;
            this.txtGoodsId.MaxLength = 5;
            this.txtGoodsId.Multiline = false;
            this.txtGoodsId.Name = "txtGoodsId";
            this.txtGoodsId.PasswordChar = false;
            this.txtGoodsId.Placeholder = "Automatically Generated";
            this.txtGoodsId.ReadOnly = true;
            this.txtGoodsId.TbBackColor = System.Drawing.Color.White;
            this.txtGoodsId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.txtGoodsId.Texts = "Automatically Generated";
            this.txtGoodsId.UnderlinedStyle = false;
            this.txtGoodsId._TextChanged += new System.EventHandler(this.StaffIDTxt__TextChanged);
            this.txtGoodsId.Click += new System.EventHandler(this.StaffIDTxt_Click);
            this.txtGoodsId.Enter += new System.EventHandler(this.StaffIDTxt_Enter);
            this.txtGoodsId.Leave += new System.EventHandler(this.StaffIDTxt_Leave);
            // 
            // lblGoodsName
            // 
            resources.ApplyResources(this.lblGoodsName, "lblGoodsName");
            this.lblGoodsName.Name = "lblGoodsName";
            // 
            // lblCatalogue
            // 
            resources.ApplyResources(this.lblCatalogue, "lblCatalogue");
            this.lblCatalogue.Name = "lblCatalogue";
            // 
            // lblGoodsId
            // 
            resources.ApplyResources(this.lblGoodsId, "lblGoodsId");
            this.lblGoodsId.Name = "lblGoodsId";
            this.lblGoodsId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderColor = System.Drawing.Color.LightGray;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.IsError = false;
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = false;
            this.txtDescription.Placeholder = "Please enter the description";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.TbBackColor = System.Drawing.Color.White;
            this.txtDescription.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtDescription.Texts = "Please enter the description";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
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
            this.txtGoodsName.Placeholder = "Please enter the name of the goods";
            this.txtGoodsName.ReadOnly = false;
            this.txtGoodsName.TbBackColor = System.Drawing.Color.White;
            this.txtGoodsName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtGoodsName.Texts = "Please enter the name of the goods";
            this.txtGoodsName.UnderlinedStyle = false;
            // 
            // UserInfoHeaderContainer
            // 
            resources.ApplyResources(this.UserInfoHeaderContainer, "UserInfoHeaderContainer");
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.GoodsInfoHeader);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            // 
            // GoodsInfoHeader
            // 
            resources.ApplyResources(this.GoodsInfoHeader, "GoodsInfoHeader");
            this.GoodsInfoHeader.Name = "GoodsInfoHeader";
            // 
            // GoodsPic
            // 
            resources.ApplyResources(this.GoodsPic, "GoodsPic");
            this.GoodsPic.BackColor = System.Drawing.Color.Transparent;
            this.GoodsPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoodsPic.Image = global::TheBetterLimited.Properties.Resources.photo_upload;
            this.GoodsPic.Name = "GoodsPic";
            this.GoodsPic.TabStop = false;
            this.GoodsPic.Click += new System.EventHandler(this.UserIconPic_Click);
            this.GoodsPic.MouseLeave += new System.EventHandler(this.UserIconPic_MouseLeave);
            this.GoodsPic.MouseHover += new System.EventHandler(this.UserIconPic_MouseHover);
            // 
            // Goods_Edit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Goods_Edit";
            this.ShowIcon = false;
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Label lblCatalogue;
        private System.Windows.Forms.Label lblGoodsId;
        private System.Windows.Forms.PictureBox GoodsPic;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Panel UserInfo;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private CustomizeControl.CustomizeTextbox txtGoodsId;
        private CustomizeControl.CustomizeTextbox txtDescription;
        private CustomizeControl.CustomizeTextbox txtGoodsName;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSize;
        private CustomizeControl.CustomizeTextbox txtGTINCode;
        private System.Windows.Forms.Label lblGTIＮCode;
        private CustomizeControl.CustomizeTextbox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private CustomizeControl.CustomizeComboBox cbxStatus;
        private CustomizeControl.CustomizeComboBox cbxSize;
        private CustomizeControl.CustomizeComboBox cbxCatalogue;
    }
}