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
            this.titleText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contentText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.isUnreadOnly = new System.Windows.Forms.CheckBox();
            this.prompt = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MessageList
            // 
            resources.ApplyResources(this.MessageList, "MessageList");
            this.MessageList.Name = "MessageList";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // senderText
            // 
            resources.ApplyResources(this.senderText, "senderText");
            this.senderText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.senderText.Name = "senderText";
            // 
            // titleText
            // 
            resources.ApplyResources(this.titleText, "titleText");
            this.titleText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.titleText.Name = "titleText";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // contentText
            // 
            resources.ApplyResources(this.contentText, "contentText");
            this.contentText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.contentText.Name = "contentText";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // isUnreadOnly
            // 
            resources.ApplyResources(this.isUnreadOnly, "isUnreadOnly");
            this.isUnreadOnly.Name = "isUnreadOnly";
            this.isUnreadOnly.UseVisualStyleBackColor = true;
            this.isUnreadOnly.CheckedChanged += new System.EventHandler(this.isUnreadOnly_CheckedChanged);
            // 
            // prompt
            // 
            this.prompt.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.prompt, "prompt");
            // 
            // Message
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.isUnreadOnly);
            this.Controls.Add(this.contentText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.senderText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MessageList);
            this.Controls.Add(this.label1);
            this.Name = "Message";
            this.Load += new System.EventHandler(this.Message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel MessageList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senderText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contentText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Timer;

        #endregion

        private System.Windows.Forms.CheckBox isUnreadOnly;
        private System.Windows.Forms.NotifyIcon prompt;
    }
}