using System.ComponentModel;

namespace TheBetterLimited.Views.Message
{
    partial class MessageListItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Sender = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.isRead = new TheBetterLimited.CustomizeControl.RoundPanel();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(5, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(257, 23);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.MessageListItem_Click);
            // 
            // Sender
            // 
            this.Sender.BackColor = System.Drawing.Color.Transparent;
            this.Sender.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sender.Location = new System.Drawing.Point(5, 28);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(131, 32);
            this.Sender.TabIndex = 1;
            this.Sender.Text = "From System";
            this.Sender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sender.Click += new System.EventHandler(this.MessageListItem_Click);
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Time.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Time.Location = new System.Drawing.Point(136, 28);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(126, 32);
            this.Time.TabIndex = 2;
            this.Time.Text = "20/6/2022 22:25";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Time.Click += new System.EventHandler(this.MessageListItem_Click);
            // 
            // isRead
            // 
            this.isRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(10)))), ((int)(((byte)(62)))));
            this.isRead.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(10)))), ((int)(((byte)(62)))));
            this.isRead.BorderColor = System.Drawing.Color.White;
            this.isRead.BorderRadius = 7;
            this.isRead.BorderSize = 0;
            this.isRead.ForeColor = System.Drawing.Color.White;
            this.isRead.Location = new System.Drawing.Point(239, 22);
            this.isRead.Name = "isRead";
            this.isRead.Size = new System.Drawing.Size(14, 14);
            this.isRead.TabIndex = 5;
            // 
            // MessageListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.isRead);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Sender);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Name = "MessageListItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(267, 65);
            this.Click += new System.EventHandler(this.MessageListItem_Click);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label Sender;

        private System.Windows.Forms.Label Time;

        private System.Windows.Forms.Label Title;

        #endregion
        private CustomizeControl.RoundPanel isRead;
    }
}
