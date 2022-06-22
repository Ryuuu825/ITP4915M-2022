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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.resendBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.resendTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Msg
            // 
            resources.ApplyResources(this.Msg, "Msg");
            this.Msg.BackColor = System.Drawing.Color.Transparent;
            this.Msg.ForeColor = System.Drawing.Color.Black;
            this.Msg.Name = "Msg";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.resendBtn);
            this.panel1.Name = "panel1";
            // 
            // backBtn
            // 
            resources.ApplyResources(this.backBtn, "backBtn");
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(147)))), ((int)(((byte)(29)))));
            this.backBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(147)))), ((int)(((byte)(29)))));
            this.backBtn.BorderColor = System.Drawing.Color.Empty;
            this.backBtn.BorderRadius = 20;
            this.backBtn.BorderSize = 0;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.IsChecked = false;
            this.backBtn.Name = "backBtn";
            this.backBtn.TextColor = System.Drawing.Color.White;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // resendBtn
            // 
            resources.ApplyResources(this.resendBtn, "resendBtn");
            this.resendBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.resendBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.resendBtn.BorderColor = System.Drawing.Color.Empty;
            this.resendBtn.BorderRadius = 20;
            this.resendBtn.BorderSize = 0;
            this.resendBtn.FlatAppearance.BorderSize = 0;
            this.resendBtn.ForeColor = System.Drawing.Color.White;
            this.resendBtn.IsChecked = false;
            this.resendBtn.Name = "resendBtn";
            this.resendBtn.TextColor = System.Drawing.Color.White;
            this.resendBtn.UseVisualStyleBackColor = false;
            this.resendBtn.Click += new System.EventHandler(this.resendBtn_Click);
            // 
            // resendTimer
            // 
            this.resendTimer.Interval = 1000;
            this.resendTimer.Tick += new System.EventHandler(this.resendTimer_Tick);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackgroundImage = global::TheBetterLimited.Properties.Resources.email;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ResetPwdResult
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ResetPwdResult";
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