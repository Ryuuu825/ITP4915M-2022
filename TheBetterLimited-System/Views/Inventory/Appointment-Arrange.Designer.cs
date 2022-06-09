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
            this.MainForm = new System.Windows.Forms.Panel();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.ComfirmBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.CustomerInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeamIDCombo = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.Catalogue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CusPhoneTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
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
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.CustomerInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 40);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(421, 205);
            this.MainForm.TabIndex = 3;
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.ComfirmBtn);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(0, 140);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(421, 65);
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
            this.CancelBtn.Location = new System.Drawing.Point(78, 13);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(119, 40);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextColor = System.Drawing.Color.White;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ComfirmBtn
            // 
            this.ComfirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComfirmBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.ComfirmBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.ComfirmBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ComfirmBtn.BorderRadius = 10;
            this.ComfirmBtn.BorderSize = 0;
            this.ComfirmBtn.FlatAppearance.BorderSize = 0;
            this.ComfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComfirmBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ComfirmBtn.IsChecked = false;
            this.ComfirmBtn.Location = new System.Drawing.Point(231, 13);
            this.ComfirmBtn.Name = "ComfirmBtn";
            this.ComfirmBtn.Size = new System.Drawing.Size(117, 40);
            this.ComfirmBtn.TabIndex = 0;
            this.ComfirmBtn.Text = "Comfirm";
            this.ComfirmBtn.TextColor = System.Drawing.Color.White;
            this.ComfirmBtn.UseVisualStyleBackColor = false;
            this.ComfirmBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.CustomerInfo.Controls.Add(this.panel1);
            this.CustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(421, 205);
            this.CustomerInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.TeamIDCombo);
            this.panel1.Controls.Add(this.Catalogue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CusPhoneTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(421, 205);
            this.panel1.TabIndex = 27;
            // 
            // TeamIDCombo
            // 
            this.TeamIDCombo.BackColor = System.Drawing.Color.White;
            this.TeamIDCombo.BorderColor = System.Drawing.Color.LightGray;
            this.TeamIDCombo.BorderRadius = 1;
            this.TeamIDCombo.BorderSize = 1;
            this.TeamIDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamIDCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamIDCombo.ForeColor = System.Drawing.Color.DimGray;
            this.TeamIDCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TeamIDCombo.ListBackColor = System.Drawing.Color.White;
            this.TeamIDCombo.ListTextColor = System.Drawing.Color.DimGray;
            this.TeamIDCombo.Location = new System.Drawing.Point(158, 31);
            this.TeamIDCombo.MinimumSize = new System.Drawing.Size(200, 30);
            this.TeamIDCombo.Name = "TeamIDCombo";
            this.TeamIDCombo.Padding = new System.Windows.Forms.Padding(1);
            this.TeamIDCombo.Size = new System.Drawing.Size(234, 31);
            this.TeamIDCombo.TabIndex = 1;
            this.TeamIDCombo.Texts = "Team ID";
            this.TeamIDCombo.UnderlinedStyle = false;
            this.TeamIDCombo.Click += new System.EventHandler(this.TeamIDCombo_Click);
            // 
            // Catalogue
            // 
            this.Catalogue.AutoSize = true;
            this.Catalogue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catalogue.Location = new System.Drawing.Point(29, 87);
            this.Catalogue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Catalogue.Name = "Catalogue";
            this.Catalogue.Size = new System.Drawing.Size(97, 21);
            this.Catalogue.TabIndex = 2;
            this.Catalogue.Text = "Team Leader";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team ID*";
            // 
            // CusPhoneTxt
            // 
            this.CusPhoneTxt.BackColor = System.Drawing.Color.White;
            this.CusPhoneTxt.BorderColor = System.Drawing.Color.LightGray;
            this.CusPhoneTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.CusPhoneTxt.BorderRadius = 10;
            this.CusPhoneTxt.BorderSize = 1;
            this.CusPhoneTxt.Enabled = false;
            this.CusPhoneTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusPhoneTxt.ForeColor = System.Drawing.Color.Black;
            this.CusPhoneTxt.IsError = false;
            this.CusPhoneTxt.Location = new System.Drawing.Point(158, 78);
            this.CusPhoneTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CusPhoneTxt.MaxLength = 30;
            this.CusPhoneTxt.Multiline = false;
            this.CusPhoneTxt.Name = "CusPhoneTxt";
            this.CusPhoneTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CusPhoneTxt.PasswordChar = false;
            this.CusPhoneTxt.Placeholder = "Auto generation";
            this.CusPhoneTxt.ReadOnly = true;
            this.CusPhoneTxt.Size = new System.Drawing.Size(237, 38);
            this.CusPhoneTxt.TabIndex = 2;
            this.CusPhoneTxt.TbBackColor = System.Drawing.Color.White;
            this.CusPhoneTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.CusPhoneTxt.Texts = "Auto generation";
            this.CusPhoneTxt.UnderlinedStyle = false;
            // 
            // UserInfoHeaderContainer
            // 
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.TeamHeader);
            this.UserInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            this.UserInfoHeaderContainer.Size = new System.Drawing.Size(421, 40);
            this.UserInfoHeaderContainer.TabIndex = 21;
            // 
            // TeamHeader
            // 
            this.TeamHeader.AutoSize = true;
            this.TeamHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamHeader.Location = new System.Drawing.Point(3, 7);
            this.TeamHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeamHeader.Name = "TeamHeader";
            this.TeamHeader.Size = new System.Drawing.Size(128, 25);
            this.TeamHeader.TabIndex = 6;
            this.TeamHeader.Text = "Choose Team";
            // 
            // Appointment_Arrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(421, 245);
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.UserInfoHeaderContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Appointment_Arrange";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrange Appointment";
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
        private CustomizeControl.CustomizeTextbox CusPhoneTxt;
        private System.Windows.Forms.Panel BottomBtn;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton ComfirmBtn;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label TeamHeader;
        private CustomizeControl.CustomizeComboBox TeamIDCombo;
    }
}