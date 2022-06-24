namespace TheBetterLimited.Views
{
    partial class DefectUpdateOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectUpdateOption));
            this.MainForm = new System.Windows.Forms.Panel();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.ConfirmBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.CustomerInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnedOption = new TheBetterLimited.CustomizeControl.PendingOptionPicBox();
            this.collectedOption = new TheBetterLimited.CustomizeControl.PendingOptionPicBox();
            this.UserInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
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
            this.BottomBtn.Controls.Add(this.ConfirmBtn);
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
            // 
            // ConfirmBtn
            // 
            resources.ApplyResources(this.ConfirmBtn, "ConfirmBtn");
            this.ConfirmBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.ConfirmBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.ConfirmBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ConfirmBtn.BorderRadius = 10;
            this.ConfirmBtn.BorderSize = 0;
            this.ConfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.IsChecked = false;
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.TextColor = System.Drawing.Color.White;
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
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
            this.panel1.Controls.Add(this.returnedOption);
            this.panel1.Controls.Add(this.collectedOption);
            this.panel1.Name = "panel1";
            // 
            // returnedOption
            // 
            resources.ApplyResources(this.returnedOption, "returnedOption");
            this.returnedOption.BackColor = System.Drawing.Color.Transparent;
            this.returnedOption.BorderColor = System.Drawing.Color.LightGray;
            this.returnedOption.BorderRadius = 0;
            this.returnedOption.BorderSelectedColor = System.Drawing.Color.SeaGreen;
            this.returnedOption.BorderSize = 2;
            this.returnedOption.Image = global::TheBetterLimited.Properties.Resources.delivery_truck;
            this.returnedOption.IsSelected = false;
            this.returnedOption.Name = "returnedOption";
            this.returnedOption.Title = "Returned";
            this.returnedOption.PicInfoClicked += new System.EventHandler(this.returnedOption_Click);
            // 
            // collectedOption
            // 
            resources.ApplyResources(this.collectedOption, "collectedOption");
            this.collectedOption.BackColor = System.Drawing.Color.Transparent;
            this.collectedOption.BorderColor = System.Drawing.Color.LightGray;
            this.collectedOption.BorderRadius = 0;
            this.collectedOption.BorderSelectedColor = System.Drawing.Color.SeaGreen;
            this.collectedOption.BorderSize = 2;
            this.collectedOption.Image = global::TheBetterLimited.Properties.Resources.package;
            this.collectedOption.IsSelected = false;
            this.collectedOption.Name = "collectedOption";
            this.collectedOption.Title = "Collected";
            this.collectedOption.PicInfoClicked += new System.EventHandler(this.collectedOption_Click);
            // 
            // UserInfoHeaderContainer
            // 
            resources.ApplyResources(this.UserInfoHeaderContainer, "UserInfoHeaderContainer");
            this.UserInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.UserInfoHeaderContainer.Controls.Add(this.Title);
            this.UserInfoHeaderContainer.Name = "UserInfoHeaderContainer";
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            // 
            // DefectUpdateOption
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DefectUpdateOption";
            this.ShowIcon = false;
            this.MainForm.ResumeLayout(false);
            this.BottomBtn.ResumeLayout(false);
            this.CustomerInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.UserInfoHeaderContainer.ResumeLayout(false);
            this.UserInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel CustomerInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel UserInfoHeaderContainer;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel BottomBtn;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton ConfirmBtn;
        private CustomizeControl.PendingOptionPicBox returnedOption;
        private CustomizeControl.PendingOptionPicBox collectedOption;
    }
}