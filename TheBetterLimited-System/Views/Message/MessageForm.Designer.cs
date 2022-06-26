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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
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
            resources.ApplyResources(this.contentBoard, "contentBoard");
            this.contentBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentBoard.Name = "contentBoard";
            // 
            // MessageContent
            // 
            resources.ApplyResources(this.MessageContent, "MessageContent");
            this.MessageContent.Name = "MessageContent";
            // 
            // MsgInput
            // 
            resources.ApplyResources(this.MsgInput, "MsgInput");
            this.MsgInput.BackColor = System.Drawing.Color.Transparent;
            this.MsgInput.BorderColor = System.Drawing.Color.LightGray;
            this.MsgInput.BorderFocusColor = System.Drawing.Color.Black;
            this.MsgInput.BorderRadius = 0;
            this.MsgInput.BorderSize = 1;
            this.MsgInput.IsError = false;
            this.MsgInput.MaxLength = 30;
            this.MsgInput.Multiline = true;
            this.MsgInput.Name = "MsgInput";
            this.MsgInput.PasswordChar = false;
            this.MsgInput.Placeholder = "";
            this.MsgInput.ReadOnly = false;
            this.MsgInput.TbBackColor = System.Drawing.SystemColors.Window;
            this.MsgInput.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.MsgInput.Texts = "";
            this.MsgInput.UnderlinedStyle = false;
            // 
            // SendBtn
            // 
            resources.ApplyResources(this.SendBtn, "SendBtn");
            this.SendBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.SendBtn.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.SendBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SendBtn.BorderRadius = 20;
            this.SendBtn.BorderSize = 0;
            this.SendBtn.FlatAppearance.BorderSize = 0;
            this.SendBtn.ForeColor = System.Drawing.Color.White;
            this.SendBtn.IsChecked = false;
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.TextColor = System.Drawing.Color.White;
            this.SendBtn.UseVisualStyleBackColor = false;
            // 
            // senderName
            // 
            resources.ApplyResources(this.senderName, "senderName");
            this.senderName.Name = "senderName";
            // 
            // newMessage
            // 
            resources.ApplyResources(this.newMessage, "newMessage");
            this.newMessage.BackColor = System.Drawing.Color.SeaGreen;
            this.newMessage.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.newMessage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.newMessage.BorderRadius = 20;
            this.newMessage.BorderSize = 0;
            this.newMessage.FlatAppearance.BorderSize = 0;
            this.newMessage.ForeColor = System.Drawing.Color.White;
            this.newMessage.IsChecked = false;
            this.newMessage.Name = "newMessage";
            this.newMessage.TextColor = System.Drawing.Color.White;
            this.newMessage.UseVisualStyleBackColor = false;
            // 
            // icon
            // 
            resources.ApplyResources(this.icon, "icon");
            this.icon.Image = global::TheBetterLimited.Properties.Resources.woman;
            this.icon.Name = "icon";
            this.icon.TabStop = false;
            // 
            // add
            // 
            resources.ApplyResources(this.add, "add");
            this.add.BackgroundImage = global::TheBetterLimited.Properties.Resources.plus24;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.Name = "add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // MessageForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newMessage);
            this.Controls.Add(this.senderName);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.add);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.MsgInput);
            this.Controls.Add(this.MessageContent);
            this.Controls.Add(this.contentBoard);
            this.Name = "MessageForm";
            this.ShowIcon = false;
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