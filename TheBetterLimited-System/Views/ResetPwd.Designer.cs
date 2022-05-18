namespace SDPTest.Views
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
            this.userName = new SDPTest.CustomizeControl.CustomizeTextbox();
            this.email = new SDPTest.CustomizeControl.CustomizeTextbox();
            this.chgPwdBtn = new SDPTest.CustomizeControl.RoundButton();
            this.TitleContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.changeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chgPwdTitle
            // 
            this.chgPwdTitle.AutoSize = true;
            this.chgPwdTitle.BackColor = System.Drawing.Color.Transparent;
            this.chgPwdTitle.Font = new System.Drawing.Font("Segoe UI", 24.20168F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgPwdTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.chgPwdTitle.Location = new System.Drawing.Point(473, 43);
            this.chgPwdTitle.Name = "chgPwdTitle";
            this.chgPwdTitle.Size = new System.Drawing.Size(316, 54);
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
            this.TitleContainer.Name = "TitleContainer";
            this.TitleContainer.Size = new System.Drawing.Size(1262, 100);
            this.TitleContainer.TabIndex = 1;
            // 
            // picReturn
            // 
            this.picReturn.BackgroundImage = global::SDPTest.Properties.Resources._return;
            this.picReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturn.InitialImage = global::SDPTest.Properties.Resources._return;
            this.picReturn.Location = new System.Drawing.Point(35, 32);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(65, 65);
            this.picReturn.TabIndex = 1002;
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
            this.label1.Location = new System.Drawing.Point(424, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 100;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(424, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
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
            this.changeInfo.Location = new System.Drawing.Point(0, 100);
            this.changeInfo.Name = "changeInfo";
            this.changeInfo.Size = new System.Drawing.Size(1262, 574);
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
            this.userName.Location = new System.Drawing.Point(424, 141);
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
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.White;
            this.email.BorderColor = System.Drawing.Color.LightGray;
            this.email.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.email.BorderRadius = 20;
            this.email.BorderSize = 1;
            this.email.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(424, 242);
            this.email.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.email.MaxLength = 30;
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(15);
            this.email.PasswordChar = false;
            this.email.Size = new System.Drawing.Size(450, 59);
            this.email.TabIndex = 2;
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
            this.chgPwdBtn.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgPwdBtn.ForeColor = System.Drawing.Color.White;
            this.chgPwdBtn.Location = new System.Drawing.Point(535, 351);
            this.chgPwdBtn.Name = "chgPwdBtn";
            this.chgPwdBtn.Size = new System.Drawing.Size(228, 52);
            this.chgPwdBtn.TabIndex = 5;
            this.chgPwdBtn.Text = "Comfirm Reset";
            this.chgPwdBtn.TextColor = System.Drawing.Color.White;
            this.chgPwdBtn.UseVisualStyleBackColor = false;
            this.chgPwdBtn.Click += new System.EventHandler(this.chgPwdBtn_Click);
            // 
            // ResetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 674);
            this.Controls.Add(this.changeInfo);
            this.Controls.Add(this.TitleContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better Limited (Reset Password)";
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