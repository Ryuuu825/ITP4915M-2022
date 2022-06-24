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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
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
            this.PhoneTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
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
            resources.ApplyResources(this.MainForm, "MainForm");
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.CustomerInfo);
            this.MainForm.Name = "MainForm";
            // 
            // BottomBtn
            // 
            resources.ApplyResources(this.BottomBtn, "BottomBtn");
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Name = "BottomBtn";
            // 
            // CancelBtn
            // 
            resources.ApplyResources(this.CancelBtn, "CancelBtn");
            this.CancelBtn.BackColor = System.Drawing.Color.Silver;
            this.CancelBtn.BackgroundColor = System.Drawing.Color.Silver;
            this.CancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CancelBtn.BorderRadius = 10;
            this.CancelBtn.BorderSize = 0;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(182)))), ((int)(((byte)(99)))));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.IsChecked = false;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.TextColor = System.Drawing.Color.White;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SaveBtn.BorderRadius = 10;
            this.SaveBtn.BorderSize = 0;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.IsChecked = false;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CustomerInfo
            // 
            resources.ApplyResources(this.CustomerInfo, "CustomerInfo");
            this.CustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.CustomerInfo.Controls.Add(this.panel1);
            this.CustomerInfo.Name = "CustomerInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.depositTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CusNameTxt);
            this.panel1.Controls.Add(this.GTINCode);
            this.panel1.Controls.Add(this.Catalogue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CusAddressTxt);
            this.panel1.Controls.Add(this.PhoneTxt);
            this.panel1.Name = "panel1";
            // 
            // depositTxt
            // 
            resources.ApplyResources(this.depositTxt, "depositTxt");
            this.depositTxt.BackColor = System.Drawing.Color.White;
            this.depositTxt.BorderColor = System.Drawing.Color.LightGray;
            this.depositTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.depositTxt.BorderRadius = 10;
            this.depositTxt.BorderSize = 1;
            this.depositTxt.ForeColor = System.Drawing.Color.Black;
            this.depositTxt.IsError = false;
            this.depositTxt.MaxLength = 32767;
            this.depositTxt.Multiline = false;
            this.depositTxt.Name = "depositTxt";
            this.depositTxt.PasswordChar = false;
            this.depositTxt.Placeholder = "";
            this.depositTxt.ReadOnly = true;
            this.depositTxt.TbBackColor = System.Drawing.Color.White;
            this.depositTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Center;
            this.depositTxt.Texts = "";
            this.depositTxt.UnderlinedStyle = false;
            this.depositTxt.Load += new System.EventHandler(this.depositTxt_Load);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CusNameTxt
            // 
            resources.ApplyResources(this.CusNameTxt, "CusNameTxt");
            this.CusNameTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CusNameTxt.BackColor = System.Drawing.Color.White;
            this.CusNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.CusNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.CusNameTxt.BorderRadius = 10;
            this.CusNameTxt.BorderSize = 1;
            this.CusNameTxt.ForeColor = System.Drawing.Color.Black;
            this.CusNameTxt.IsError = false;
            this.CusNameTxt.MaxLength = 30;
            this.CusNameTxt.Multiline = false;
            this.CusNameTxt.Name = "CusNameTxt";
            this.CusNameTxt.PasswordChar = false;
            this.CusNameTxt.Placeholder = "Please enter customer name";
            this.CusNameTxt.ReadOnly = false;
            this.CusNameTxt.TbBackColor = System.Drawing.Color.White;
            this.CusNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.CusNameTxt.Texts = "Please enter customer name";
            this.CusNameTxt.UnderlinedStyle = false;
            this.CusNameTxt.Click += new System.EventHandler(this.CusNameTxt_Click);
            // 
            // GTINCode
            // 
            resources.ApplyResources(this.GTINCode, "GTINCode");
            this.GTINCode.Name = "GTINCode";
            // 
            // Catalogue
            // 
            resources.ApplyResources(this.Catalogue, "Catalogue");
            this.Catalogue.Name = "Catalogue";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // CusAddressTxt
            // 
            resources.ApplyResources(this.CusAddressTxt, "CusAddressTxt");
            this.CusAddressTxt.BackColor = System.Drawing.Color.White;
            this.CusAddressTxt.BorderColor = System.Drawing.Color.LightGray;
            this.CusAddressTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.CusAddressTxt.BorderRadius = 10;
            this.CusAddressTxt.BorderSize = 1;
            this.CusAddressTxt.ForeColor = System.Drawing.Color.Black;
            this.CusAddressTxt.IsError = false;
            this.CusAddressTxt.MaxLength = 120;
            this.CusAddressTxt.Multiline = true;
            this.CusAddressTxt.Name = "CusAddressTxt";
            this.CusAddressTxt.PasswordChar = false;
            this.CusAddressTxt.Placeholder = "Please enter customer address (option)";
            this.CusAddressTxt.ReadOnly = false;
            this.CusAddressTxt.TbBackColor = System.Drawing.Color.White;
            this.CusAddressTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.CusAddressTxt.Texts = "Please enter customer address (option)";
            this.CusAddressTxt.UnderlinedStyle = false;
            this.CusAddressTxt.Click += new System.EventHandler(this.CusAddressTxt_Click);
            // 
            // PhoneTxt
            // 
            resources.ApplyResources(this.PhoneTxt, "PhoneTxt");
            this.PhoneTxt.BackColor = System.Drawing.Color.White;
            this.PhoneTxt.BorderColor = System.Drawing.Color.LightGray;
            this.PhoneTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.PhoneTxt.BorderRadius = 10;
            this.PhoneTxt.BorderSize = 1;
            this.PhoneTxt.ForeColor = System.Drawing.Color.Black;
            this.PhoneTxt.IsError = false;
            this.PhoneTxt.MaxLength = 30;
            this.PhoneTxt.Multiline = false;
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.PasswordChar = false;
            this.PhoneTxt.Placeholder = "Please enter customer phone";
            this.PhoneTxt.ReadOnly = false;
            this.PhoneTxt.TbBackColor = System.Drawing.Color.White;
            this.PhoneTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.PhoneTxt.Texts = "Please enter customer phone";
            this.PhoneTxt.UnderlinedStyle = false;
            this.PhoneTxt._TextChanged += new System.EventHandler(this.PhoneTxt__TextChanged);
            this.PhoneTxt._Leave += new System.EventHandler(this.PhoneTxt__Leave);
            this.PhoneTxt.Click += new System.EventHandler(this.CusPhoneTxt_Click);
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
            // Booking
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.UserInfoHeaderContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Booking";
            this.ShowIcon = false;
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
        private CustomizeControl.CustomizeTextbox PhoneTxt;
        private System.Windows.Forms.Panel BottomBtn;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private System.Windows.Forms.Label label2;
        private CustomizeControl.CustomizeTextbox depositTxt;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
    }
}