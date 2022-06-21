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
            this.isRead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.isRead)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(15, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 23);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // Sender
            // 
            this.Sender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sender.Location = new System.Drawing.Point(15, 45);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(100, 13);
            this.Sender.TabIndex = 1;
            this.Sender.Text = "From System";
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Time.Location = new System.Drawing.Point(121, 45);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(125, 13);
            this.Time.TabIndex = 2;
            this.Time.Text = "20/6/2022 22:25";
            // 
            // isRead
            // 
            this.isRead.Image = global::TheBetterLimited.Properties.Resources.square24;
            this.isRead.Location = new System.Drawing.Point(234, 17);
            this.isRead.Name = "isRead";
            this.isRead.Size = new System.Drawing.Size(24, 25);
            this.isRead.TabIndex = 3;
            this.isRead.TabStop = false;
            // 
            // MessageListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.isRead);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Sender);
            this.Controls.Add(this.Title);
            this.Name = "MessageListItem";
            this.Size = new System.Drawing.Size(261, 65);
            ((System.ComponentModel.ISupportInitialize)(this.isRead)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label Sender;

        private System.Windows.Forms.Label Time;

        private System.Windows.Forms.Label Title;

        #endregion

        private System.Windows.Forms.PictureBox isRead;
    }
}
