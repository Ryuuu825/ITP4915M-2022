namespace TheBetterLimited.Views
{
    partial class Appointment_Arrange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment_Arrange));
            this.MainForm = new System.Windows.Forms.Panel();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.ComfirmBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.CustomerInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeamIDCombo = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.Catalogue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamNameTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.TeamHeader = new System.Windows.Forms.Label();
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
            this.BottomBtn.Controls.Add(this.ComfirmBtn);
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
            // ComfirmBtn
            // 
            resources.ApplyResources(this.ComfirmBtn, "ComfirmBtn");
            this.ComfirmBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.ComfirmBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.ComfirmBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ComfirmBtn.BorderRadius = 10;
            this.ComfirmBtn.BorderSize = 0;
            this.ComfirmBtn.FlatAppearance.BorderSize = 0;
            this.ComfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ComfirmBtn.IsChecked = false;
            this.ComfirmBtn.Name = "ComfirmBtn";
            this.ComfirmBtn.TextColor = System.Drawing.Color.White;
            this.ComfirmBtn.UseVisualStyleBackColor = false;
            this.ComfirmBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.panel1.Controls.Add(this.TeamIDCombo);
            this.panel1.Controls.Add(this.Catalogue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TeamNameTxt);
            this.panel1.Name = "panel1";
            // 
            // TeamIDCombo
            // 
            resources.ApplyResources(this.TeamIDCombo, "TeamIDCombo");
            this.TeamIDCombo.BackColor = System.Drawing.Color.White;
            this.TeamIDCombo.BorderColor = System.Drawing.Color.LightGray;
            this.TeamIDCombo.BorderRadius = 1;
            this.TeamIDCombo.BorderSize = 1;
            this.TeamIDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamIDCombo.ForeColor = System.Drawing.Color.DimGray;
            this.TeamIDCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TeamIDCombo.ListBackColor = System.Drawing.Color.White;
            this.TeamIDCombo.ListTextColor = System.Drawing.Color.DimGray;
            this.TeamIDCombo.Name = "TeamIDCombo";
            this.TeamIDCombo.Texts = "Team ID";
            this.TeamIDCombo.UnderlinedStyle = false;
            this.TeamIDCombo.OnSelectedIndexChanged += new System.EventHandler(this.TeamIDCombo_OnSelectedIndexChanged);
            this.TeamIDCombo.Click += new System.EventHandler(this.TeamIDCombo_Click);
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
            // TeamNameTxt
            // 
            resources.ApplyResources(this.TeamNameTxt, "TeamNameTxt");
            this.TeamNameTxt.BackColor = System.Drawing.Color.White;
            this.TeamNameTxt.BorderColor = System.Drawing.Color.LightGray;
            this.TeamNameTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.TeamNameTxt.BorderRadius = 10;
            this.TeamNameTxt.BorderSize = 1;
            this.TeamNameTxt.ForeColor = System.Drawing.Color.Black;
            this.TeamNameTxt.IsError = false;
            this.TeamNameTxt.MaxLength = 30;
            this.TeamNameTxt.Multiline = false;
            this.TeamNameTxt.Name = "TeamNameTxt";
            this.TeamNameTxt.PasswordChar = false;
            this.TeamNameTxt.Placeholder = "Auto generation";
            this.TeamNameTxt.ReadOnly = true;
            this.TeamNameTxt.TbBackColor = System.Drawing.Color.White;
            this.TeamNameTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.TeamNameTxt.Texts = "Auto generation";
            this.TeamNameTxt.UnderlinedStyle = false;
            // 
            // UserInfoHeaderContainer
            // 
            resources.ApplyResources(this.UserInfoHeaderContainer, "UserInfoHeaderContainer");
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.TeamHeader);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            // 
            // TeamHeader
            // 
            resources.ApplyResources(this.TeamHeader, "TeamHeader");
            this.TeamHeader.Name = "TeamHeader";
            // 
            // Appointment_Arrange
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.UserInfoHeaderContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Appointment_Arrange";
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
        private System.Windows.Forms.Label Catalogue;
        private System.Windows.Forms.Label label1;
        private CustomizeControl.CustomizeTextbox TeamNameTxt;
        private System.Windows.Forms.Panel BottomBtn;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton ComfirmBtn;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label TeamHeader;
        private CustomizeControl.CustomizeComboBox TeamIDCombo;
    }
}