namespace TheBetterLimited.Views
{
    partial class ResetPwd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPwd));
            this.chgPwdTitle = new System.Windows.Forms.Label();
            this.TitleContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staffNoTip = new System.Windows.Forms.ToolTip(this.components);
            this.changeInfo = new System.Windows.Forms.Panel();
            this.userName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.email = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.chgPwdBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.TitleContainer.SuspendLayout();
            this.changeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // chgPwdTitle
            // 
            resources.ApplyResources(this.chgPwdTitle, "chgPwdTitle");
            this.chgPwdTitle.BackColor = System.Drawing.Color.Transparent;
            this.chgPwdTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.chgPwdTitle.Name = "chgPwdTitle";
            this.staffNoTip.SetToolTip(this.chgPwdTitle, resources.GetString("chgPwdTitle.ToolTip"));
            // 
            // TitleContainer
            // 
            resources.ApplyResources(this.TitleContainer, "TitleContainer");
            this.TitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TitleContainer.Controls.Add(this.picReturn);
            this.TitleContainer.Controls.Add(this.chgPwdTitle);
            this.TitleContainer.Name = "TitleContainer";
            this.staffNoTip.SetToolTip(this.TitleContainer, resources.GetString("TitleContainer.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            this.staffNoTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            this.staffNoTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // staffNoTip
            // 
            this.staffNoTip.ToolTipTitle = "Staff Number";
            // 
            // changeInfo
            // 
            resources.ApplyResources(this.changeInfo, "changeInfo");
            this.changeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.changeInfo.Controls.Add(this.label1);
            this.changeInfo.Controls.Add(this.userName);
            this.changeInfo.Controls.Add(this.label2);
            this.changeInfo.Controls.Add(this.email);
            this.changeInfo.Controls.Add(this.chgPwdBtn);
            this.changeInfo.Name = "changeInfo";
            this.staffNoTip.SetToolTip(this.changeInfo, resources.GetString("changeInfo.ToolTip"));
            // 
            // userName
            // 
            resources.ApplyResources(this.userName, "userName");
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.BorderColor = System.Drawing.Color.LightGray;
            this.userName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.userName.BorderRadius = 20;
            this.userName.BorderSize = 1;
            this.userName.IsError = false;
            this.userName.MaxLength = 10;
            this.userName.Multiline = false;
            this.userName.Name = "userName";
            this.userName.PasswordChar = false;
            this.userName.Placeholder = "";
            this.userName.ReadOnly = false;
            this.userName.TbBackColor = System.Drawing.SystemColors.Window;
            this.userName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.userName.Texts = "";
            this.staffNoTip.SetToolTip(this.userName, resources.GetString("userName.ToolTip"));
            this.userName.UnderlinedStyle = false;
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.BackColor = System.Drawing.Color.White;
            this.email.BorderColor = System.Drawing.Color.LightGray;
            this.email.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.email.BorderRadius = 20;
            this.email.BorderSize = 1;
            this.email.IsError = false;
            this.email.MaxLength = 30;
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.PasswordChar = false;
            this.email.Placeholder = "";
            this.email.ReadOnly = false;
            this.email.TbBackColor = System.Drawing.SystemColors.Window;
            this.email.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.email.Texts = "";
            this.staffNoTip.SetToolTip(this.email, resources.GetString("email.ToolTip"));
            this.email.UnderlinedStyle = false;
            // 
            // chgPwdBtn
            // 
            resources.ApplyResources(this.chgPwdBtn, "chgPwdBtn");
            this.chgPwdBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.chgPwdBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.chgPwdBtn.BorderColor = System.Drawing.Color.Transparent;
            this.chgPwdBtn.BorderRadius = 20;
            this.chgPwdBtn.BorderSize = 0;
            this.chgPwdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chgPwdBtn.FlatAppearance.BorderSize = 0;
            this.chgPwdBtn.ForeColor = System.Drawing.Color.White;
            this.chgPwdBtn.IsChecked = false;
            this.chgPwdBtn.Name = "chgPwdBtn";
            this.chgPwdBtn.TextColor = System.Drawing.Color.White;
            this.staffNoTip.SetToolTip(this.chgPwdBtn, resources.GetString("chgPwdBtn.ToolTip"));
            this.chgPwdBtn.UseVisualStyleBackColor = false;
            this.chgPwdBtn.Click += new System.EventHandler(this.chgPwdBtn_Click);
            // 
            // picReturn
            // 
            resources.ApplyResources(this.picReturn, "picReturn");
            this.picReturn.BackgroundImage = global::TheBetterLimited.Properties.Resources._return;
            this.picReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturn.InitialImage = global::TheBetterLimited.Properties.Resources._return;
            this.picReturn.Name = "picReturn";
            this.picReturn.TabStop = false;
            this.staffNoTip.SetToolTip(this.picReturn, resources.GetString("picReturn.ToolTip"));
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // ResetPwd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.changeInfo);
            this.Controls.Add(this.TitleContainer);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ResetPwd";
            this.staffNoTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResetPwd_KeyDown);
            this.TitleContainer.ResumeLayout(false);
            this.TitleContainer.PerformLayout();
            this.changeInfo.ResumeLayout(false);
            this.changeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label chgPwdTitle;
        private System.Windows.Forms.Panel TitleContainer;
        private CustomizeControl.CustomizeTextbox userName;
        private CustomizeControl.CustomizeTextbox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomizeControl.RoundButton chgPwdBtn;
        private System.Windows.Forms.ToolTip staffNoTip;
        private System.Windows.Forms.Panel changeInfo;
        private System.Windows.Forms.PictureBox picReturn;
    }
}