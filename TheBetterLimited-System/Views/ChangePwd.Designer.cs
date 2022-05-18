namespace SDPTest.Views
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
            this.userName = new SDPTest.CustomizeControl.CustomizeTextbox();
            this.originalPwd = new SDPTest.CustomizeControl.CustomizeTextbox();
            this.firstNewPassword = new SDPTest.CustomizeControl.CustomizeTextbox();
            this.secondNewPassword = new SDPTest.CustomizeControl.CustomizeTextbox();
            this.chgPwdBtn = new SDPTest.CustomizeControl.RoundButton();
            this.TitleContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.changeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chgPwdTitle
            // 
            this.chgPwdTitle.AutoSize = true;
            this.chgPwdTitle.Font = new System.Drawing.Font("Segoe UI", 24.20168F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgPwdTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.chgPwdTitle.Location = new System.Drawing.Point(463, 43);
            this.chgPwdTitle.Name = "chgPwdTitle";
            this.chgPwdTitle.Size = new System.Drawing.Size(355, 54);
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
            this.TitleContainer.Name = "TitleContainer";
            this.TitleContainer.Size = new System.Drawing.Size(1280, 100);
            this.TitleContainer.TabIndex = 1;
            // 
            // picReturn
            // 
            this.picReturn.BackgroundImage = global::SDPTest.Properties.Resources._return;
            this.picReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturn.Location = new System.Drawing.Point(35, 34);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(65, 65);
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
            this.label1.Location = new System.Drawing.Point(415, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 100;
            this.label1.Text = "Staff Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(415, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 101;
            this.label2.Text = "Original Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(415, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 102;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(415, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 28);
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
            this.changeInfo.Location = new System.Drawing.Point(0, 100);
            this.changeInfo.Name = "changeInfo";
            this.changeInfo.Size = new System.Drawing.Size(1280, 620);
            this.changeInfo.TabIndex = 104;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.BorderColor = System.Drawing.Color.LightGray;
            this.userName.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.userName.BorderRadius = 20;
            this.userName.BorderSize = 1;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(415, 86);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userName.MaxLength = 10;
            this.userName.Multiline = false;
            this.userName.Name = "userName";
            this.userName.Padding = new System.Windows.Forms.Padding(15);
            this.userName.PasswordChar = false;
            this.userName.Size = new System.Drawing.Size(450, 59);
            this.userName.TabIndex = 1;
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
            this.originalPwd.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPwd.Location = new System.Drawing.Point(415, 181);
            this.originalPwd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.originalPwd.MaxLength = 20;
            this.originalPwd.Multiline = false;
            this.originalPwd.Name = "originalPwd";
            this.originalPwd.Padding = new System.Windows.Forms.Padding(15);
            this.originalPwd.PasswordChar = true;
            this.originalPwd.Size = new System.Drawing.Size(450, 59);
            this.originalPwd.TabIndex = 2;
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
            this.firstNewPassword.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNewPassword.Location = new System.Drawing.Point(415, 276);
            this.firstNewPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.firstNewPassword.MaxLength = 20;
            this.firstNewPassword.Multiline = false;
            this.firstNewPassword.Name = "firstNewPassword";
            this.firstNewPassword.Padding = new System.Windows.Forms.Padding(15);
            this.firstNewPassword.PasswordChar = true;
            this.firstNewPassword.Size = new System.Drawing.Size(450, 59);
            this.firstNewPassword.TabIndex = 3;
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
            this.secondNewPassword.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNewPassword.Location = new System.Drawing.Point(415, 371);
            this.secondNewPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.secondNewPassword.MaxLength = 20;
            this.secondNewPassword.Multiline = false;
            this.secondNewPassword.Name = "secondNewPassword";
            this.secondNewPassword.Padding = new System.Windows.Forms.Padding(15);
            this.secondNewPassword.PasswordChar = true;
            this.secondNewPassword.Size = new System.Drawing.Size(450, 59);
            this.secondNewPassword.TabIndex = 4;
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
            this.chgPwdBtn.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgPwdBtn.ForeColor = System.Drawing.Color.White;
            this.chgPwdBtn.Location = new System.Drawing.Point(526, 474);
            this.chgPwdBtn.Name = "chgPwdBtn";
            this.chgPwdBtn.Size = new System.Drawing.Size(228, 52);
            this.chgPwdBtn.TabIndex = 5;
            this.chgPwdBtn.Text = "Comfirm Change";
            this.chgPwdBtn.TextColor = System.Drawing.Color.White;
            this.chgPwdBtn.UseVisualStyleBackColor = false;
            this.chgPwdBtn.Click += new System.EventHandler(this.chgPwdBtn_Click);
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.changeInfo);
            this.Controls.Add(this.TitleContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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