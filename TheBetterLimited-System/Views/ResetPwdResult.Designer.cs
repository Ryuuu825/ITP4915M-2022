namespace TheBetterLimited.Views
{
    partial class ResetPwdResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPwdResult));
            this.Msg = new System.Windows.Forms.Label();
            this.resendBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.backBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resendTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Msg
            // 
            this.Msg.BackColor = System.Drawing.Color.Transparent;
            this.Msg.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Msg.ForeColor = System.Drawing.Color.Black;
            this.Msg.Location = new System.Drawing.Point(136, 324);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(991, 138);
            this.Msg.TabIndex = 1;
            this.Msg.Text = "An email for resetting your password has been sent to your email address.\r\nPlease" +
    " finish the following steps by the received email. \r\nThank you!";
            this.Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resendBtn
            // 
            this.resendBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.resendBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.resendBtn.BorderColor = System.Drawing.Color.Empty;
            this.resendBtn.BorderRadius = 20;
            this.resendBtn.BorderSize = 0;
            this.resendBtn.FlatAppearance.BorderSize = 0;
            this.resendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resendBtn.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resendBtn.ForeColor = System.Drawing.Color.White;
            this.resendBtn.Location = new System.Drawing.Point(367, 495);
            this.resendBtn.Name = "resendBtn";
            this.resendBtn.Size = new System.Drawing.Size(222, 50);
            this.resendBtn.TabIndex = 0;
            this.resendBtn.Text = "Resend Email";
            this.resendBtn.TextColor = System.Drawing.Color.White;
            this.resendBtn.UseVisualStyleBackColor = false;
            this.resendBtn.Click += new System.EventHandler(this.resendBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(147)))), ((int)(((byte)(29)))));
            this.backBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(147)))), ((int)(((byte)(29)))));
            this.backBtn.BorderColor = System.Drawing.Color.Empty;
            this.backBtn.BorderRadius = 20;
            this.backBtn.BorderSize = 0;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(671, 495);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(222, 50);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Sign In";
            this.backBtn.TextColor = System.Drawing.Color.White;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.resendBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 674);
            this.panel1.TabIndex = 3;
            // 
            // resendTimer
            // 
            this.resendTimer.Interval = 1000;
            this.resendTimer.Tick += new System.EventHandler(this.resendTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheBetterLimited.Properties.Resources.email;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(553, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ResetPwdResult
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1262, 674);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPwdResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password Result";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Msg;
        private CustomizeControl.RoundButton resendBtn;
        private CustomizeControl.RoundButton backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer resendTimer;
    }
}