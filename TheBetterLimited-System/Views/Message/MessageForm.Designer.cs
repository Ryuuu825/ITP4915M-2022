namespace TheBetterLimited.Views.Message
{
    partial class MessageForm
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
            this.contentBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.MessageContent = new System.Windows.Forms.FlowLayoutPanel();
            this.MsgInput = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.SendBtn = new TheBetterLimited.CustomizeControl.RoundButton();
            this.senderName = new System.Windows.Forms.Label();
            this.newMessage = new TheBetterLimited.CustomizeControl.RoundButton();
            this.icon = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // contentBoard
            // 
            this.contentBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentBoard.Location = new System.Drawing.Point(12, 58);
            this.contentBoard.Name = "contentBoard";
            this.contentBoard.Size = new System.Drawing.Size(231, 392);
            this.contentBoard.TabIndex = 0;
            // 
            // MessageContent
            // 
            this.MessageContent.Location = new System.Drawing.Point(257, 58);
            this.MessageContent.Name = "MessageContent";
            this.MessageContent.Size = new System.Drawing.Size(591, 339);
            this.MessageContent.TabIndex = 1;
            this.MessageContent.Visible = false;
            // 
            // MsgInput
            // 
            this.MsgInput.BackColor = System.Drawing.Color.Transparent;
            this.MsgInput.BorderColor = System.Drawing.Color.LightGray;
            this.MsgInput.BorderFocusColor = System.Drawing.Color.Black;
            this.MsgInput.BorderRadius = 0;
            this.MsgInput.BorderSize = 1;
            this.MsgInput.Enabled = false;
            this.MsgInput.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgInput.IsError = false;
            this.MsgInput.Location = new System.Drawing.Point(300, 406);
            this.MsgInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MsgInput.MaxLength = 30;
            this.MsgInput.Multiline = true;
            this.MsgInput.Name = "MsgInput";
            this.MsgInput.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.MsgInput.PasswordChar = false;
            this.MsgInput.Placeholder = "";
            this.MsgInput.ReadOnly = false;
            this.MsgInput.Size = new System.Drawing.Size(465, 43);
            this.MsgInput.TabIndex = 2;
            this.MsgInput.TbBackColor = System.Drawing.SystemColors.Window;
            this.MsgInput.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.MsgInput.Texts = "";
            this.MsgInput.UnderlinedStyle = false;
            this.MsgInput.Visible = false;
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SendBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.SendBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SendBtn.BorderRadius = 20;
            this.SendBtn.BorderSize = 0;
            this.SendBtn.Enabled = false;
            this.SendBtn.FlatAppearance.BorderSize = 0;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.ForeColor = System.Drawing.Color.White;
            this.SendBtn.IsChecked = false;
            this.SendBtn.Location = new System.Drawing.Point(772, 406);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(76, 43);
            this.SendBtn.TabIndex = 3;
            this.SendBtn.Text = "send";
            this.SendBtn.TextColor = System.Drawing.Color.White;
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Visible = false;
            // 
            // senderName
            // 
            this.senderName.Enabled = false;
            this.senderName.Font = new System.Drawing.Font("Segoe UI Black", 9.75F);
            this.senderName.Location = new System.Drawing.Point(330, 12);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(435, 43);
            this.senderName.TabIndex = 52;
            this.senderName.Text = "Sender";
            this.senderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.senderName.Visible = false;
            // 
            // newMessage
            // 
            this.newMessage.BackColor = System.Drawing.Color.SeaGreen;
            this.newMessage.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.newMessage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.newMessage.BorderRadius = 20;
            this.newMessage.BorderSize = 0;
            this.newMessage.FlatAppearance.BorderSize = 0;
            this.newMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMessage.ForeColor = System.Drawing.Color.White;
            this.newMessage.IsChecked = false;
            this.newMessage.Location = new System.Drawing.Point(12, 12);
            this.newMessage.Name = "newMessage";
            this.newMessage.Size = new System.Drawing.Size(115, 37);
            this.newMessage.TabIndex = 53;
            this.newMessage.Text = "new";
            this.newMessage.TextColor = System.Drawing.Color.White;
            this.newMessage.UseVisualStyleBackColor = false;
            // 
            // icon
            // 
            this.icon.Enabled = false;
            this.icon.Image = global::TheBetterLimited.Properties.Resources.woman;
            this.icon.Location = new System.Drawing.Point(264, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(40, 40);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 51;
            this.icon.TabStop = false;
            this.icon.Visible = false;
            // 
            // add
            // 
            this.add.BackgroundImage = global::TheBetterLimited.Properties.Resources.plus24;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add.Enabled = false;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(264, 413);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(36, 32);
            this.add.TabIndex = 50;
            this.add.UseVisualStyleBackColor = true;
            this.add.Visible = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 462);
            this.Controls.Add(this.newMessage);
            this.Controls.Add(this.senderName);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.add);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.MsgInput);
            this.Controls.Add(this.MessageContent);
            this.Controls.Add(this.contentBoard);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contentBoard;
        private System.Windows.Forms.FlowLayoutPanel MessageContent;
        private CustomizeControl.CustomizeTextbox MsgInput;
        private CustomizeControl.RoundButton SendBtn;
        private System.Windows.Forms.PictureBox icon;
        private CustomizeControl.RoundButton newMessage;
        private System.Windows.Forms.Label senderName;
        private System.Windows.Forms.Button add;
    }
}