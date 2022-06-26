namespace TheBetterLimited.Views
{
    partial class SendMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMessageForm));
            this.MainForm = new System.Windows.Forms.Panel();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.CustomerInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiverList = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.receiverName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxType = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GTINCode = new System.Windows.Forms.Label();
            this.Catalogue = new System.Windows.Forms.Label();
            this.CusAddressTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.PhoneTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.plusBtn = new System.Windows.Forms.Button();
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
            this.BottomBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.BottomBtn_Paint);
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
            this.panel1.Controls.Add(this.receiverList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.receiverName);
            this.panel1.Controls.Add(this.plusBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.GTINCode);
            this.panel1.Controls.Add(this.Catalogue);
            this.panel1.Controls.Add(this.CusAddressTxt);
            this.panel1.Controls.Add(this.PhoneTxt);
            this.panel1.Name = "panel1";
            // 
            // receiverList
            // 
            resources.ApplyResources(this.receiverList, "receiverList");
            this.receiverList.Name = "receiverList";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // receiverName
            // 
            resources.ApplyResources(this.receiverName, "receiverName");
            this.receiverName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.receiverName.BackColor = System.Drawing.Color.White;
            this.receiverName.BorderColor = System.Drawing.Color.LightGray;
            this.receiverName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.receiverName.BorderRadius = 10;
            this.receiverName.BorderSize = 1;
            this.receiverName.ForeColor = System.Drawing.Color.Black;
            this.receiverName.IsError = false;
            this.receiverName.MaxLength = 30;
            this.receiverName.Multiline = false;
            this.receiverName.Name = "receiverName";
            this.receiverName.PasswordChar = false;
            this.receiverName.Placeholder = "Send to ...";
            this.receiverName.ReadOnly = false;
            this.receiverName.TbBackColor = System.Drawing.Color.White;
            this.receiverName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.receiverName.Texts = "Send to ...";
            this.receiverName.UnderlinedStyle = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbxType
            // 
            resources.ApplyResources(this.cbxType, "cbxType");
            this.cbxType.BackColor = System.Drawing.Color.White;
            this.cbxType.BorderColor = System.Drawing.Color.LightGray;
            this.cbxType.BorderRadius = 1;
            this.cbxType.BorderSize = 1;
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.ForeColor = System.Drawing.Color.Black;
            this.cbxType.IconColor = System.Drawing.Color.LightGray;
            this.cbxType.ListBackColor = System.Drawing.Color.White;
            this.cbxType.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxType.Name = "cbxType";
            this.cbxType.Texts = "";
            this.cbxType.UnderlinedStyle = false;
            this.cbxType.OnSelectedIndexChanged += new System.EventHandler(this.cbxType_OnSelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            this.CusAddressTxt.Placeholder = "Content...";
            this.CusAddressTxt.ReadOnly = false;
            this.CusAddressTxt.TbBackColor = System.Drawing.Color.White;
            this.CusAddressTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.CusAddressTxt.Texts = "Content...";
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
            this.PhoneTxt.Placeholder = "Title...";
            this.PhoneTxt.ReadOnly = false;
            this.PhoneTxt.TbBackColor = System.Drawing.Color.White;
            this.PhoneTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.PhoneTxt.Texts = "Title...";
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
            // plusBtn
            // 
            resources.ApplyResources(this.plusBtn, "plusBtn");
            this.plusBtn.BackgroundImage = global::TheBetterLimited.Properties.Resources.plus24;
            this.plusBtn.FlatAppearance.BorderSize = 0;
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // SendMessageForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.UserInfoHeaderContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SendMessageForm";
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
        private System.Windows.Forms.Label GTINCode;
        private System.Windows.Forms.Label Catalogue;
        private CustomizeControl.CustomizeTextbox CusAddressTxt;
        private CustomizeControl.CustomizeTextbox PhoneTxt;
        private System.Windows.Forms.Panel BottomBtn;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private CustomizeControl.CustomizeComboBox cbxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CustomizeControl.CustomizeTextbox receiverName;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.RichTextBox receiverList;
    }
}