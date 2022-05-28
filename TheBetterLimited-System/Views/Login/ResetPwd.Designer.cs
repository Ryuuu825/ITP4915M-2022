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
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staffNoTip = new System.Windows.Forms.ToolTip(this.components);
            this.changeInfo = new System.Windows.Forms.Panel();
            this.userName = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.email = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.chgPwdBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.TitleContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.changeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chgPwdTitle
            // 
            this.chgPwdTitle.AutoSize = true;
            this.chgPwdTitle.BackColor = System.Drawing.Color.Transparent;
            this.chgPwdTitle.Font = new System.Drawing.Font("Segoe UI", 24.20168F, System.Drawing.FontStyle.Bold);
            this.chgPwdTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.chgPwdTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chgPwdTitle.Location = new System.Drawing.Point(355, 34);
            this.chgPwdTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chgPwdTitle.Name = "chgPwdTitle";
            this.chgPwdTitle.Size = new System.Drawing.Size(260, 45);
            this.chgPwdTitle.TabIndex = 1000;
            this.chgPwdTitle.Text = "Reset Password";
            this.chgPwdTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleContainer
            // 
            this.TitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TitleContainer.Controls.Add(this.picReturn);
            this.TitleContainer.Controls.Add(this.chgPwdTitle);
            this.TitleContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleContainer.Location = new System.Drawing.Point(0, 0);
            this.TitleContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitleContainer.Name = "TitleContainer";
            this.TitleContainer.Size = new System.Drawing.Size(946, 80);
            this.TitleContainer.TabIndex = 1;
            // 
            // picReturn
            // 
            this.picReturn.BackgroundImage = global::TheBetterLimited.Properties.Resources._return;
            this.picReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picReturn.InitialImage = global::TheBetterLimited.Properties.Resources._return;
            this.picReturn.Location = new System.Drawing.Point(26, 28);
            this.picReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(49, 52);
            this.picReturn.TabIndex = 1002;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(318, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 100;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(318, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 101;
            this.label2.Text = "Email Address";
            // 
            // staffNoTip
            // 
            this.staffNoTip.ToolTipTitle = "Staff Number";
            // 
            // changeInfo
            // 
            this.changeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.changeInfo.Controls.Add(this.label1);
            this.changeInfo.Controls.Add(this.userName);
            this.changeInfo.Controls.Add(this.label2);
            this.changeInfo.Controls.Add(this.email);
            this.changeInfo.Controls.Add(this.chgPwdBtn);
            this.changeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeInfo.Location = new System.Drawing.Point(0, 80);
            this.changeInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeInfo.Name = "changeInfo";
            this.changeInfo.Size = new System.Drawing.Size(946, 459);
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
            this.userName.Location = new System.Drawing.Point(318, 113);
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
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.White;
            this.email.BorderColor = System.Drawing.Color.LightGray;
            this.email.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.email.BorderRadius = 20;
            this.email.BorderSize = 1;
            this.email.Font = new System.Drawing.Font("Segoe UI", 12.10084F);
            this.email.IsError = false;
            this.email.Location = new System.Drawing.Point(318, 194);
            this.email.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.email.MaxLength = 30;
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.email.PasswordChar = false;
            this.email.Placeholder = "";
            this.email.ReadOnly = false;
            this.email.Size = new System.Drawing.Size(338, 48);
            this.email.TabIndex = 2;
            this.email.TbBackColor = System.Drawing.SystemColors.Window;
            this.email.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.email.Texts = "";
            this.email.UnderlinedStyle = false;
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
            this.chgPwdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chgPwdBtn.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold);
            this.chgPwdBtn.ForeColor = System.Drawing.Color.White;
            this.chgPwdBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chgPwdBtn.Location = new System.Drawing.Point(401, 281);
            this.chgPwdBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chgPwdBtn.Name = "chgPwdBtn";
            this.chgPwdBtn.Size = new System.Drawing.Size(171, 42);
            this.chgPwdBtn.TabIndex = 5;
            this.chgPwdBtn.Text = "Comfirm Reset";
            this.chgPwdBtn.TextColor = System.Drawing.Color.White;
            this.chgPwdBtn.UseVisualStyleBackColor = false;
            this.chgPwdBtn.Click += new System.EventHandler(this.chgPwdBtn_Click);
            // 
            // ResetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 539);
            this.Controls.Add(this.changeInfo);
            this.Controls.Add(this.TitleContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ResetPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better Limited (Reset Password)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResetPwd_KeyDown);
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
        private CustomizeControl.CustomizeTextbox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomizeControl.RoundButton chgPwdBtn;
        private System.Windows.Forms.ToolTip staffNoTip;
        private System.Windows.Forms.Panel changeInfo;
        private System.Windows.Forms.PictureBox picReturn;
    }
}