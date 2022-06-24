namespace TheBetterLimited.Views
{
    partial class Appointment_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment_Add));
            this.MainForm = new System.Windows.Forms.Panel();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.InstallSessionCombo = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.DeliverySessionCombo = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.InstallDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.GTINCode = new System.Windows.Forms.Label();
            this.Catalogue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.PhoneTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.GoodsInfoHeader = new System.Windows.Forms.Label();
            this.MainForm.SuspendLayout();
            this.BottomBtn.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.MainForm.Controls.Add(this.panel3);
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
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click_1);
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
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.InstallSessionCombo);
            this.panel4.Controls.Add(this.DeliverySessionCombo);
            this.panel4.Controls.Add(this.InstallDatePicker);
            this.panel4.Controls.Add(this.DeliveryDatePicker);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Name = "panel4";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Name = "panel5";
            // 
            // InstallSessionCombo
            // 
            resources.ApplyResources(this.InstallSessionCombo, "InstallSessionCombo");
            this.InstallSessionCombo.BackColor = System.Drawing.Color.White;
            this.InstallSessionCombo.BorderColor = System.Drawing.Color.LightGray;
            this.InstallSessionCombo.BorderRadius = 1;
            this.InstallSessionCombo.BorderSize = 1;
            this.InstallSessionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstallSessionCombo.ForeColor = System.Drawing.Color.DimGray;
            this.InstallSessionCombo.IconColor = System.Drawing.Color.LightGray;
            this.InstallSessionCombo.ListBackColor = System.Drawing.Color.White;
            this.InstallSessionCombo.ListTextColor = System.Drawing.Color.DimGray;
            this.InstallSessionCombo.Name = "InstallSessionCombo";
            this.InstallSessionCombo.Texts = "Installation Session";
            this.InstallSessionCombo.UnderlinedStyle = false;
            this.InstallSessionCombo.OnSelectedIndexChanged += new System.EventHandler(this.InstallSessionCombo_OnSelectedIndexChanged);
            // 
            // DeliverySessionCombo
            // 
            resources.ApplyResources(this.DeliverySessionCombo, "DeliverySessionCombo");
            this.DeliverySessionCombo.BackColor = System.Drawing.Color.White;
            this.DeliverySessionCombo.BorderColor = System.Drawing.Color.LightGray;
            this.DeliverySessionCombo.BorderRadius = 1;
            this.DeliverySessionCombo.BorderSize = 1;
            this.DeliverySessionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliverySessionCombo.ForeColor = System.Drawing.Color.DimGray;
            this.DeliverySessionCombo.IconColor = System.Drawing.Color.LightGray;
            this.DeliverySessionCombo.ListBackColor = System.Drawing.Color.White;
            this.DeliverySessionCombo.ListTextColor = System.Drawing.Color.DimGray;
            this.DeliverySessionCombo.Name = "DeliverySessionCombo";
            this.DeliverySessionCombo.Texts = "Delivery Session";
            this.DeliverySessionCombo.UnderlinedStyle = false;
            this.DeliverySessionCombo.OnSelectedIndexChanged += new System.EventHandler(this.DeliverySessionCombo_OnSelectedIndexChanged);
            // 
            // InstallDatePicker
            // 
            resources.ApplyResources(this.InstallDatePicker, "InstallDatePicker");
            this.InstallDatePicker.Name = "InstallDatePicker";
            this.InstallDatePicker.ValueChanged += new System.EventHandler(this.InstallDatePicker_ValueChanged);
            // 
            // DeliveryDatePicker
            // 
            resources.ApplyResources(this.DeliveryDatePicker, "DeliveryDatePicker");
            this.DeliveryDatePicker.CalendarTitleBackColor = System.Drawing.Color.MediumSeaGreen;
            this.DeliveryDatePicker.Name = "DeliveryDatePicker";
            this.DeliveryDatePicker.ValueChanged += new System.EventHandler(this.DeliveryDatePicker_ValueChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CustomerInfo
            // 
            resources.ApplyResources(this.CustomerInfo, "CustomerInfo");
            this.CustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.CustomerInfo.Controls.Add(this.panel1);
            this.CustomerInfo.Controls.Add(this.UserInfoHeaderContainer);
            this.CustomerInfo.Name = "CustomerInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.NameTxt);
            this.panel1.Controls.Add(this.GTINCode);
            this.panel1.Controls.Add(this.Catalogue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddressTxt);
            this.panel1.Controls.Add(this.PhoneTxt);
            this.panel1.Name = "panel1";
            // 
            // NameTxt
            // 
            resources.ApplyResources(this.NameTxt, "NameTxt");
            this.NameTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.NameTxt.BackColor = System.Drawing.Color.White;
            this.NameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.NameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.NameTxt.BorderRadius = 10;
            this.NameTxt.BorderSize = 1;
            this.NameTxt.ForeColor = System.Drawing.Color.Black;
            this.NameTxt.IsError = false;
            this.NameTxt.MaxLength = 20;
            this.NameTxt.Multiline = false;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PasswordChar = false;
            this.NameTxt.Placeholder = "Please enter customer name";
            this.NameTxt.ReadOnly = false;
            this.NameTxt.TbBackColor = System.Drawing.Color.White;
            this.NameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.NameTxt.Texts = "Please enter customer name";
            this.NameTxt.UnderlinedStyle = false;
            this.NameTxt.Click += new System.EventHandler(this.NameTxt_Click);
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
            // AddressTxt
            // 
            resources.ApplyResources(this.AddressTxt, "AddressTxt");
            this.AddressTxt.BackColor = System.Drawing.Color.White;
            this.AddressTxt.BorderColor = System.Drawing.Color.LightGray;
            this.AddressTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.AddressTxt.BorderRadius = 10;
            this.AddressTxt.BorderSize = 1;
            this.AddressTxt.ForeColor = System.Drawing.Color.Black;
            this.AddressTxt.IsError = false;
            this.AddressTxt.MaxLength = 32767;
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.PasswordChar = false;
            this.AddressTxt.Placeholder = "Plase enter delivery address";
            this.AddressTxt.ReadOnly = false;
            this.AddressTxt.TbBackColor = System.Drawing.Color.White;
            this.AddressTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.AddressTxt.Texts = "Plase enter delivery address";
            this.AddressTxt.UnderlinedStyle = false;
            this.AddressTxt.Click += new System.EventHandler(this.AddressTxt_Click);
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
            this.PhoneTxt.MaxLength = 11;
            this.PhoneTxt.Multiline = false;
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.PasswordChar = false;
            this.PhoneTxt.Placeholder = "Please enter customer phone number";
            this.PhoneTxt.ReadOnly = false;
            this.PhoneTxt.TbBackColor = System.Drawing.Color.White;
            this.PhoneTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.PhoneTxt.Texts = "Please enter customer phone number";
            this.PhoneTxt.UnderlinedStyle = false;
            this.PhoneTxt._TextChanged += new System.EventHandler(this.PhoneTxt__TextChanged);
            this.PhoneTxt._Leave += new System.EventHandler(this.PhoneTxt__Leave);
            this.PhoneTxt.Click += new System.EventHandler(this.PhoneTxt_Click);
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
            // Appointment_Add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Appointment_Add";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Appointment_Add_Load);
            this.MainForm.ResumeLayout(false);
            this.BottomBtn.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CustomerInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private CustomizeControl.CustomizeComboBox InstallSessionCombo;
        private CustomizeControl.CustomizeComboBox DeliverySessionCombo;
        private System.Windows.Forms.DateTimePicker InstallDatePicker;
        private System.Windows.Forms.DateTimePicker DeliveryDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel CustomerInfo;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.CustomizeTextbox NameTxt;
        private System.Windows.Forms.Label GTINCode;
        private System.Windows.Forms.Label Catalogue;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox AddressTxt;
        private CustomizeControl.CustomizeTextbox PhoneTxt;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label GoodsInfoHeader;
        private System.Windows.Forms.Panel BottomBtn;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
    }
}