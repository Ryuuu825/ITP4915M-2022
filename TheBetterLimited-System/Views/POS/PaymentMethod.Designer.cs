namespace TheBetterLimited.Views
{
    partial class PaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethod));
            this.PaymentMethodBox = new System.Windows.Forms.FlowLayoutPanel();
            this.paymentPicBox1 = new TheBetterLimited.CustomizeControl.PaymentPicBox();
            this.paymentPicBox2 = new TheBetterLimited.CustomizeControl.PaymentPicBox();
            this.paymentPicBox3 = new TheBetterLimited.CustomizeControl.PaymentPicBox();
            this.paymentPicBox4 = new TheBetterLimited.CustomizeControl.PaymentPicBox();
            this.paymentPicBox5 = new TheBetterLimited.CustomizeControl.PaymentPicBox();
            this.paymentPicBox6 = new TheBetterLimited.CustomizeControl.PaymentPicBox();
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.CancelBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.SaveBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.PaymentMethodBox.SuspendLayout();
            this.BottomBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaymentMethodBox
            // 
            resources.ApplyResources(this.PaymentMethodBox, "PaymentMethodBox");
            this.PaymentMethodBox.Controls.Add(this.paymentPicBox1);
            this.PaymentMethodBox.Controls.Add(this.paymentPicBox2);
            this.PaymentMethodBox.Controls.Add(this.paymentPicBox3);
            this.PaymentMethodBox.Controls.Add(this.paymentPicBox4);
            this.PaymentMethodBox.Controls.Add(this.paymentPicBox5);
            this.PaymentMethodBox.Controls.Add(this.paymentPicBox6);
            this.PaymentMethodBox.Name = "PaymentMethodBox";
            // 
            // paymentPicBox1
            // 
            resources.ApplyResources(this.paymentPicBox1, "paymentPicBox1");
            this.paymentPicBox1.BackColor = System.Drawing.Color.Transparent;
            this.paymentPicBox1.BorderColor = System.Drawing.Color.LightGray;
            this.paymentPicBox1.BorderRadius = 0;
            this.paymentPicBox1.BorderSelectedColor = System.Drawing.Color.SeaGreen;
            this.paymentPicBox1.BorderSize = 2;
            this.paymentPicBox1.Image = global::TheBetterLimited.Properties.Resources.cash;
            this.paymentPicBox1.IsSelected = true;
            this.paymentPicBox1.Name = "paymentPicBox1";
            this.paymentPicBox1.Title = "Cash";
            this.paymentPicBox1.PicInfoClicked += new System.EventHandler(this.paymentPicBox_Click);
            // 
            // paymentPicBox2
            // 
            resources.ApplyResources(this.paymentPicBox2, "paymentPicBox2");
            this.paymentPicBox2.BackColor = System.Drawing.Color.Transparent;
            this.paymentPicBox2.BorderColor = System.Drawing.Color.LightGray;
            this.paymentPicBox2.BorderRadius = 0;
            this.paymentPicBox2.BorderSelectedColor = System.Drawing.Color.SeaGreen;
            this.paymentPicBox2.BorderSize = 2;
            this.paymentPicBox2.Image = global::TheBetterLimited.Properties.Resources.visa;
            this.paymentPicBox2.IsSelected = false;
            this.paymentPicBox2.Name = "paymentPicBox2";
            this.paymentPicBox2.Title = "Visa";
            this.paymentPicBox2.PicInfoClicked += new System.EventHandler(this.paymentPicBox_Click);
            // 
            // paymentPicBox3
            // 
            resources.ApplyResources(this.paymentPicBox3, "paymentPicBox3");
            this.paymentPicBox3.BackColor = System.Drawing.Color.Transparent;
            this.paymentPicBox3.BorderColor = System.Drawing.Color.LightGray;
            this.paymentPicBox3.BorderRadius = 0;
            this.paymentPicBox3.BorderSelectedColor = System.Drawing.Color.SeaGreen;
            this.paymentPicBox3.BorderSize = 2;
            this.paymentPicBox3.Image = global::TheBetterLimited.Properties.Resources.master;
            this.paymentPicBox3.IsSelected = false;
            this.paymentPicBox3.Name = "paymentPicBox3";
            this.paymentPicBox3.Title = "MasterCard";
            this.paymentPicBox3.PicInfoClicked += new System.EventHandler(this.paymentPicBox_Click);
            // 
            // paymentPicBox4
            // 
            resources.ApplyResources(this.paymentPicBox4, "paymentPicBox4");
            this.paymentPicBox4.BackColor = System.Drawing.Color.Transparent;
            this.paymentPicBox4.BorderColor = System.Drawing.Color.LightGray;
            this.paymentPicBox4.BorderRadius = 0;
            this.paymentPicBox4.BorderSelectedColor = System.Drawing.Color.SeaGreen;
            this.paymentPicBox4.BorderSize = 2;
            this.paymentPicBox4.Image = global::TheBetterLimited.Properties.Resources.apple;
            this.paymentPicBox4.IsSelected = false;
            this.paymentPicBox4.Name = "paymentPicBox4";
            this.paymentPicBox4.Title = "Apple Pay";
            this.paymentPicBox4.PicInfoClicked += new System.EventHandler(this.paymentPicBox_Click);
            // 
            // paymentPicBox5
            // 
            resources.ApplyResources(this.paymentPicBox5, "paymentPicBox5");
            this.paymentPicBox5.BackColor = System.Drawing.Color.Transparent;
            this.paymentPicBox5.BorderColor = System.Drawing.Color.LightGray;
            this.paymentPicBox5.BorderRadius = 0;
            this.paymentPicBox5.BorderSelectedColor = System.Drawing.Color.SeaGreen;
            this.paymentPicBox5.BorderSize = 2;
            this.paymentPicBox5.Image = global::TheBetterLimited.Properties.Resources.google;
            this.paymentPicBox5.IsSelected = false;
            this.paymentPicBox5.Name = "paymentPicBox5";
            this.paymentPicBox5.Title = "Google Pay";
            this.paymentPicBox5.PicInfoClicked += new System.EventHandler(this.paymentPicBox_Click);
            // 
            // paymentPicBox6
            // 
            resources.ApplyResources(this.paymentPicBox6, "paymentPicBox6");
            this.paymentPicBox6.BackColor = System.Drawing.Color.Transparent;
            this.paymentPicBox6.BorderColor = System.Drawing.Color.LightGray;
            this.paymentPicBox6.BorderRadius = 0;
            this.paymentPicBox6.BorderSelectedColor = System.Drawing.Color.SeaGreen;
            this.paymentPicBox6.BorderSize = 2;
            this.paymentPicBox6.Image = global::TheBetterLimited.Properties.Resources.unknown;
            this.paymentPicBox6.IsSelected = false;
            this.paymentPicBox6.Name = "paymentPicBox6";
            this.paymentPicBox6.Title = "Alipay";
            this.paymentPicBox6.PicInfoClicked += new System.EventHandler(this.paymentPicBox_Click);
            // 
            // BottomBtn
            // 
            resources.ApplyResources(this.BottomBtn, "BottomBtn");
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.CancelBtn);
            this.BottomBtn.Controls.Add(this.SaveBtn);
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
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SaveBtn.BorderRadius = 10;
            this.SaveBtn.BorderSize = 0;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.IsChecked = false;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PaymentMethod
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.PaymentMethodBox);
            this.Controls.Add(this.BottomBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PaymentMethod";
            this.ShowIcon = false;
            this.PaymentMethodBox.ResumeLayout(false);
            this.BottomBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PaymentMethodBox;
        private System.Windows.Forms.Panel BottomBtn;
        private CustomizeControl.RoundButton CancelBtn;
        private CustomizeControl.RoundButton SaveBtn;
        private CustomizeControl.PaymentPicBox paymentPicBox1;
        private CustomizeControl.PaymentPicBox paymentPicBox2;
        private CustomizeControl.PaymentPicBox paymentPicBox3;
        private CustomizeControl.PaymentPicBox paymentPicBox4;
        private CustomizeControl.PaymentPicBox paymentPicBox5;
        private CustomizeControl.PaymentPicBox paymentPicBox6;
    }
}