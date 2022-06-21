namespace TheBetterLimited.Views.Message
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.label1 = new System.Windows.Forms.Label();
            this.MessageList = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.senderText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.isUnreadOnly = new System.Windows.Forms.CheckBox();
            this.prompt = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageList
            // 
            this.MessageList.AutoScroll = true;
            this.MessageList.Location = new System.Drawing.Point(12, 65);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(277, 411);
            this.MessageList.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F);
            this.label2.Location = new System.Drawing.Point(318, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sender:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // senderText
            // 
            this.senderText.Enabled = false;
            this.senderText.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.senderText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.senderText.Location = new System.Drawing.Point(397, 84);
            this.senderText.Multiline = true;
            this.senderText.Name = "senderText";
            this.senderText.Size = new System.Drawing.Size(319, 46);
            this.senderText.TabIndex = 6;
            this.senderText.Text = "dfsafsdf";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(397, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 46);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "A title";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F);
            this.label3.Location = new System.Drawing.Point(318, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "Title";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(397, 212);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 264);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Please update the system";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9.75F);
            this.label4.Location = new System.Drawing.Point(318, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 43);
            this.label4.TabIndex = 9;
            this.label4.Text = "Content";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // isUnreadOnly
            // 
            this.isUnreadOnly.AutoSize = true;
            this.isUnreadOnly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.isUnreadOnly.Location = new System.Drawing.Point(12, 490);
            this.isUnreadOnly.Name = "isUnreadOnly";
            this.isUnreadOnly.Size = new System.Drawing.Size(139, 19);
            this.isUnreadOnly.TabIndex = 11;
            this.isUnreadOnly.Text = "Unread message only";
            this.isUnreadOnly.UseVisualStyleBackColor = true;
            this.isUnreadOnly.CheckedChanged += new System.EventHandler(this.isUnreadOnly_CheckedChanged);
            // 
            // prompt
            // 
            this.prompt.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.prompt.BalloonTipText = "sdfasfsf";
            this.prompt.BalloonTipTitle = "sdfsdfsf";
            this.prompt.Icon = ((System.Drawing.Icon)(resources.GetObject("prompt.Icon")));
            this.prompt.Text = "notifyIcon1";
            this.prompt.Visible = true;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 524);
            this.Controls.Add(this.isUnreadOnly);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.senderText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MessageList);
            this.Controls.Add(this.label1);
            this.Name = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel MessageList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senderText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Timer;

        #endregion

        private System.Windows.Forms.CheckBox isUnreadOnly;
        private System.Windows.Forms.NotifyIcon prompt;
    }
}