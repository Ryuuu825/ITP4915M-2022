namespace TheBetterLimited.Views
{
    partial class RestockRequest_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestockRequest_Edit));
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnSave = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.RestockRequestInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStatus = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCreatorId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtStoreId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblOperatorId = new System.Windows.Forms.Label();
            this.lblCreatorId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblStoreId = new System.Windows.Forms.Label();
            this.txtOperatorId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.RestockRequestInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.RestockRequestInfoHeader = new System.Windows.Forms.Label();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.RestockRequestInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.RestockRequestInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomBtn
            // 
            resources.ApplyResources(this.BottomBtn, "BottomBtn");
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.btnCancel);
            this.BottomBtn.Controls.Add(this.btnSave);
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Name = "BottomBtn";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(182)))), ((int)(((byte)(99)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IsChecked = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IsChecked = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this.MainForm, "MainForm");
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.RestockRequestInfo);
            this.MainForm.Name = "MainForm";
            // 
            // RestockRequestInfo
            // 
            resources.ApplyResources(this.RestockRequestInfo, "RestockRequestInfo");
            this.RestockRequestInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.RestockRequestInfo.Controls.Add(this.panel1);
            this.RestockRequestInfo.Controls.Add(this.RestockRequestInfoHeaderContainer);
            this.RestockRequestInfo.Name = "RestockRequestInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtCreatorId);
            this.panel1.Controls.Add(this.txtStoreId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblOperatorId);
            this.panel1.Controls.Add(this.lblCreatorId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblStoreId);
            this.panel1.Controls.Add(this.txtOperatorId);
            this.panel1.Name = "panel1";
            // 
            // txtStatus
            // 
            resources.ApplyResources(this.txtStatus, "txtStatus");
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.BorderColor = System.Drawing.Color.LightGray;
            this.txtStatus.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtStatus.BorderRadius = 10;
            this.txtStatus.BorderSize = 1;
            this.txtStatus.ForeColor = System.Drawing.Color.LightGray;
            this.txtStatus.IsError = false;
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.Multiline = false;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = false;
            this.txtStatus.Placeholder = "Please enter the reorder level";
            this.txtStatus.ReadOnly = false;
            this.txtStatus.TbBackColor = System.Drawing.Color.White;
            this.txtStatus.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtStatus.Texts = "Please enter the reorder level";
            this.txtStatus.UnderlinedStyle = false;
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // txtCreatorId
            // 
            resources.ApplyResources(this.txtCreatorId, "txtCreatorId");
            this.txtCreatorId.BackColor = System.Drawing.Color.White;
            this.txtCreatorId.BorderColor = System.Drawing.Color.LightGray;
            this.txtCreatorId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtCreatorId.BorderRadius = 10;
            this.txtCreatorId.BorderSize = 1;
            this.txtCreatorId.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCreatorId.ForeColor = System.Drawing.Color.LightGray;
            this.txtCreatorId.IsError = false;
            this.txtCreatorId.MaxLength = 32767;
            this.txtCreatorId.Multiline = false;
            this.txtCreatorId.Name = "txtCreatorId";
            this.txtCreatorId.PasswordChar = false;
            this.txtCreatorId.Placeholder = "Automatically generated";
            this.txtCreatorId.ReadOnly = false;
            this.txtCreatorId.TbBackColor = System.Drawing.Color.White;
            this.txtCreatorId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtCreatorId.Texts = "Automatically generated";
            this.txtCreatorId.UnderlinedStyle = false;
            // 
            // txtStoreId
            // 
            resources.ApplyResources(this.txtStoreId, "txtStoreId");
            this.txtStoreId.BackColor = System.Drawing.Color.White;
            this.txtStoreId.BorderColor = System.Drawing.Color.LightGray;
            this.txtStoreId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtStoreId.BorderRadius = 10;
            this.txtStoreId.BorderSize = 1;
            this.txtStoreId.ForeColor = System.Drawing.Color.LightGray;
            this.txtStoreId.IsError = false;
            this.txtStoreId.MaxLength = 32767;
            this.txtStoreId.Multiline = false;
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.PasswordChar = false;
            this.txtStoreId.Placeholder = "Please enter the quantity";
            this.txtStoreId.ReadOnly = false;
            this.txtStoreId.TbBackColor = System.Drawing.Color.White;
            this.txtStoreId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtStoreId.Texts = "Please enter the quantity";
            this.txtStoreId.UnderlinedStyle = false;
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.LightGray;
            this.txtId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtId.BorderRadius = 10;
            this.txtId.BorderSize = 1;
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.IsError = false;
            this.txtId.MaxLength = 5;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = false;
            this.txtId.Placeholder = "Automatically Generated";
            this.txtId.ReadOnly = true;
            this.txtId.TbBackColor = System.Drawing.Color.White;
            this.txtId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtId.Texts = "Automatically Generated";
            this.txtId.UnderlinedStyle = false;
            this.txtId._TextChanged += new System.EventHandler(this.StaffIDTxt__TextChanged);
            this.txtId.Click += new System.EventHandler(this.StaffIDTxt_Click);
            this.txtId.Enter += new System.EventHandler(this.StaffIDTxt_Enter);
            this.txtId.Leave += new System.EventHandler(this.StaffIDTxt_Leave);
            // 
            // lblOperatorId
            // 
            resources.ApplyResources(this.lblOperatorId, "lblOperatorId");
            this.lblOperatorId.Name = "lblOperatorId";
            // 
            // lblCreatorId
            // 
            resources.ApplyResources(this.lblCreatorId, "lblCreatorId");
            this.lblCreatorId.Name = "lblCreatorId";
            // 
            // lblId
            // 
            resources.ApplyResources(this.lblId, "lblId");
            this.lblId.Name = "lblId";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStoreId
            // 
            resources.ApplyResources(this.lblStoreId, "lblStoreId");
            this.lblStoreId.Name = "lblStoreId";
            // 
            // txtOperatorId
            // 
            resources.ApplyResources(this.txtOperatorId, "txtOperatorId");
            this.txtOperatorId.BackColor = System.Drawing.Color.White;
            this.txtOperatorId.BorderColor = System.Drawing.Color.LightGray;
            this.txtOperatorId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtOperatorId.BorderRadius = 10;
            this.txtOperatorId.BorderSize = 1;
            this.txtOperatorId.ForeColor = System.Drawing.Color.LightGray;
            this.txtOperatorId.IsError = false;
            this.txtOperatorId.MaxLength = 32767;
            this.txtOperatorId.Multiline = false;
            this.txtOperatorId.Name = "txtOperatorId";
            this.txtOperatorId.PasswordChar = false;
            this.txtOperatorId.Placeholder = "Automatically generated";
            this.txtOperatorId.ReadOnly = false;
            this.txtOperatorId.TbBackColor = System.Drawing.Color.White;
            this.txtOperatorId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtOperatorId.Texts = "Automatically generated";
            this.txtOperatorId.UnderlinedStyle = false;
            // 
            // RestockRequestInfoHeaderContainer
            // 
            resources.ApplyResources(this.RestockRequestInfoHeaderContainer, "RestockRequestInfoHeaderContainer");
            this.RestockRequestInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.RestockRequestInfoHeaderContainer.Controls.Add(this.RestockRequestInfoHeader);
            this.RestockRequestInfoHeaderContainer.Name = "RestockRequestInfoHeaderContainer";
            // 
            // RestockRequestInfoHeader
            // 
            resources.ApplyResources(this.RestockRequestInfoHeader, "RestockRequestInfoHeader");
            this.RestockRequestInfoHeader.Name = "RestockRequestInfoHeader";
            // 
            // RestockRequest_Edit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RestockRequest_Edit";
            this.ShowIcon = false;
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.RestockRequestInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RestockRequestInfoHeaderContainer.ResumeLayout(false);
            this.RestockRequestInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel RestockRequestInfo;
        private System.Windows.Forms.Panel RestockRequestInfoHeaderContainer;
        private System.Windows.Forms.Label RestockRequestInfoHeader;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnSave;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.CustomizeTextbox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private TheBetterLimited.CustomizeControl.CustomizeTextbox txtCreatorId;
        private CustomizeControl.CustomizeTextbox txtStoreId;
        private CustomizeControl.CustomizeTextbox txtId;
        private System.Windows.Forms.Label lblOperatorId;
        private System.Windows.Forms.Label lblCreatorId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblStoreId;
        private CustomizeControl.CustomizeTextbox txtOperatorId;
    }
}