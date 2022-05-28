namespace TheBetterLimited.Views
{
    partial class ChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePwd));
            this.chgPwdTitle = new System.Windows.Forms.Label();
            this.TitleContainer = new System.Windows.Forms.Panel();
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffNoTip = new System.Windows.Forms.ToolTip(this.components);
            this.changeInfo = new System.Windows.Forms.Panel();
            this.userName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.originalPwd = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.firstNewPassword = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.secondNewPassword = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.chgPwdBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.TitleContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.changeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chgPwdTitle
            // 
            this.chgPwdTitle.AutoSize = true;
            this.chgPwdTitle.Font = new System.Drawing.Font("Segoe UI", 24.20168F, System.Drawing.FontStyle.Bold);
            this.chgPwdTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.chgPwdTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chgPwdTitle.Location = new System.Drawing.Point(347, 34);
            this.chgPwdTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chgPwdTitle.Name = "chgPwdTitle";
            this.chgPwdTitle.Size = new System.Drawing.Size(292, 45);
            this.chgPwdTitle.TabIndex = 1000;
            this.chgPwdTitle.Text = "Change Password";
            this.chgPwdTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleContainer
            // 
            this.TitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TitleContainer.Controls.Add(this.picReturn);
            this.TitleContainer.Controls.Add(this.chgPwdTitle);
            this.TitleContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleContainer.Location = new System.Drawing.Point(0, 0);
            this.TitleContainer.Margin = new System.Windows.Forms.Padding(2);
            this.TitleContainer.Name = "TitleContainer";
            this.TitleContainer.Size = new System.Drawing.Size(960, 80);
            this.TitleContainer.TabIndex = 1;
            // 
            // picReturn
            // 
            this.picReturn.BackgroundImage = global::TheBetterLimited.Properties.Resources._return;
            this.picReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picReturn.Location = new System.Drawing.Point(26, 27);
            this.picReturn.Margin = new System.Windows.Forms.Padding(2);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(49, 52);
            this.picReturn.TabIndex = 1001;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            this.picReturn.MouseLeave += new System.EventHandler(this.picReturn_MouseLeave);
            this.picReturn.MouseHover += new System.EventHandler(this.picReturn_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(311, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 100;
            this.label1.Text = "Staff Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(311, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 101;
            this.label2.Text = "Original Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(311, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 102;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(311, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 103;
            this.label4.Text = "New Password Again";
            // 
            // staffNoTip
            // 
            this.staffNoTip.ToolTipTitle = "Staff Number";
            this.staffNoTip.Popup += new System.Windows.Forms.PopupEventHandler(this.staffNoTip_Popup);
            // 
            // changeInfo
            // 
            this.changeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.changeInfo.Controls.Add(this.label1);
            this.changeInfo.Controls.Add(this.userName);
            this.changeInfo.Controls.Add(this.label2);
            this.changeInfo.Controls.Add(this.originalPwd);
            this.changeInfo.Controls.Add(this.label3);
            this.changeInfo.Controls.Add(this.firstNewPassword);
            this.changeInfo.Controls.Add(this.label4);
            this.changeInfo.Controls.Add(this.secondNewPassword);
            this.changeInfo.Controls.Add(this.chgPwdBtn);
            this.changeInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.changeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeInfo.Location = new System.Drawing.Point(0, 80);
            this.changeInfo.Margin = new System.Windows.Forms.Padding(2);
            this.changeInfo.Name = "changeInfo";
            this.changeInfo.Size = new System.Drawing.Size(960, 496);
            this.changeInfo.TabIndex = 104;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.BorderColor = System.Drawing.Color.LightGray;
            this.userName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.userName.BorderRadius = 20;
            this.userName.BorderSize = 1;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.userName.IsError = false;
            this.userName.Location = new System.Drawing.Point(311, 69);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.userName.MaxLength = 10;
            this.userName.Multiline = false;
            this.userName.Name = "userName";
            this.userName.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.userName.PasswordChar = false;
            this.userName.Placeholder = "";
            this.userName.ReadOnly = false;
            this.userName.Size = new System.Drawing.Size(338, 48);
            this.userName.TabIndex = 1;
            this.userName.TbBackColor = System.Drawing.SystemColors.Window;
            this.userName.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.userName.Texts = "";
            this.userName.UnderlinedStyle = false;
            this.userName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.displayTip);
            // 
            // originalPwd
            // 
            this.originalPwd.BackColor = System.Drawing.Color.White;
            this.originalPwd.BorderColor = System.Drawing.Color.LightGray;
            this.originalPwd.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.originalPwd.BorderRadius = 20;
            this.originalPwd.BorderSize = 1;
            this.originalPwd.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.originalPwd.IsError = false;
            this.originalPwd.Location = new System.Drawing.Point(311, 145);
            this.originalPwd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.originalPwd.MaxLength = 20;
            this.originalPwd.Multiline = false;
            this.originalPwd.Name = "originalPwd";
            this.originalPwd.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.originalPwd.PasswordChar = true;
            this.originalPwd.Placeholder = "";
            this.originalPwd.ReadOnly = false;
            this.originalPwd.Size = new System.Drawing.Size(338, 48);
            this.originalPwd.TabIndex = 2;
            this.originalPwd.TbBackColor = System.Drawing.SystemColors.Window;
            this.originalPwd.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.originalPwd.Texts = "";
            this.originalPwd.UnderlinedStyle = false;
            // 
            // firstNewPassword
            // 
            this.firstNewPassword.BackColor = System.Drawing.Color.White;
            this.firstNewPassword.BorderColor = System.Drawing.Color.LightGray;
            this.firstNewPassword.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.firstNewPassword.BorderRadius = 20;
            this.firstNewPassword.BorderSize = 1;
            this.firstNewPassword.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.firstNewPassword.IsError = false;
            this.firstNewPassword.Location = new System.Drawing.Point(311, 221);
            this.firstNewPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.firstNewPassword.MaxLength = 20;
            this.firstNewPassword.Multiline = false;
            this.firstNewPassword.Name = "firstNewPassword";
            this.firstNewPassword.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.firstNewPassword.PasswordChar = true;
            this.firstNewPassword.Placeholder = "";
            this.firstNewPassword.ReadOnly = false;
            this.firstNewPassword.Size = new System.Drawing.Size(338, 48);
            this.firstNewPassword.TabIndex = 3;
            this.firstNewPassword.TbBackColor = System.Drawing.SystemColors.Window;
            this.firstNewPassword.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.firstNewPassword.Texts = "";
            this.firstNewPassword.UnderlinedStyle = false;
            // 
            // secondNewPassword
            // 
            this.secondNewPassword.BackColor = System.Drawing.Color.White;
            this.secondNewPassword.BorderColor = System.Drawing.Color.LightGray;
            this.secondNewPassword.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.secondNewPassword.BorderRadius = 20;
            this.secondNewPassword.BorderSize = 1;
            this.secondNewPassword.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.secondNewPassword.IsError = false;
            this.secondNewPassword.Location = new System.Drawing.Point(311, 297);
            this.secondNewPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.secondNewPassword.MaxLength = 20;
            this.secondNewPassword.Multiline = false;
            this.secondNewPassword.Name = "secondNewPassword";
            this.secondNewPassword.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.secondNewPassword.PasswordChar = true;
            this.secondNewPassword.Placeholder = "";
            this.secondNewPassword.ReadOnly = false;
            this.secondNewPassword.Size = new System.Drawing.Size(338, 48);
            this.secondNewPassword.TabIndex = 4;
            this.secondNewPassword.TbBackColor = System.Drawing.SystemColors.Window;
            this.secondNewPassword.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.secondNewPassword.Texts = "";
            this.secondNewPassword.UnderlinedStyle = false;
            // 
            // chgPwdBtn
            // 
            this.chgPwdBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.chgPwdBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.chgPwdBtn.BorderColor = System.Drawing.Color.Transparent;
            this.chgPwdBtn.BorderRadius = 20;
            this.chgPwdBtn.BorderSize = 0;
            this.chgPwdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chgPwdBtn.FlatAppearance.BorderSize = 0;
            this.chgPwdBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.chgPwdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(147)))), ((int)(((byte)(29)))));
            this.chgPwdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chgPwdBtn.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold);
            this.chgPwdBtn.ForeColor = System.Drawing.Color.White;
            this.chgPwdBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chgPwdBtn.Location = new System.Drawing.Point(394, 379);
            this.chgPwdBtn.Margin = new System.Windows.Forms.Padding(2);
            this.chgPwdBtn.Name = "chgPwdBtn";
            this.chgPwdBtn.Size = new System.Drawing.Size(171, 42);
            this.chgPwdBtn.TabIndex = 5;
            this.chgPwdBtn.Text = "Comfirm Change";
            this.chgPwdBtn.TextColor = System.Drawing.Color.White;
            this.chgPwdBtn.UseVisualStyleBackColor = false;
            this.chgPwdBtn.Click += new System.EventHandler(this.chgPwdBtn_Click);
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 576);
            this.Controls.Add(this.changeInfo);
            this.Controls.Add(this.TitleContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better Limited (Change Password)";
            this.TitleContainer.ResumeLayout(false);
            this.TitleContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            this.changeInfo.ResumeLayout(false);
            this.changeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label chgPwdTitle;
        private System.Windows.Forms.Panel TitleContainer;
        private CustomizeControl.CustomizeTextbox userName;
        private CustomizeControl.CustomizeTextbox originalPwd;
        private CustomizeControl.CustomizeTextbox firstNewPassword;
        private CustomizeControl.CustomizeTextbox secondNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomizeControl.RoundButton chgPwdBtn;
        private System.Windows.Forms.ToolTip staffNoTip;
        private System.Windows.Forms.Panel changeInfo;
        private System.Windows.Forms.PictureBox picReturn;
    }
}