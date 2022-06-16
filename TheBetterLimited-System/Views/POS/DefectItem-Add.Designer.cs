namespace TheBetterLimited.Views
{
    partial class DefectItem_Add
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
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnAddSupplier = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.StockInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDesc = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.StockInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.StockInfoHeader = new System.Windows.Forms.Label();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.StockInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StockInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.btnCancel);
            this.BottomBtn.Controls.Add(this.btnAddSupplier);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 220);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(467, 54);
            this.BottomBtn.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(182)))), ((int)(((byte)(99)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IsChecked = false;
            this.btnCancel.Location = new System.Drawing.Point(86, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddSupplier.BorderRadius = 10;
            this.btnAddSupplier.BorderSize = 0;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.IsChecked = false;
            this.btnAddSupplier.Location = new System.Drawing.Point(253, 6);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(128, 40);
            this.btnAddSupplier.TabIndex = 6;
            this.btnAddSupplier.Text = "Comfirm";
            this.btnAddSupplier.TextColor = System.Drawing.Color.White;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.StockInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(487, 284);
            this.MainForm.TabIndex = 2;
            // 
            // StockInfo
            // 
            this.StockInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.StockInfo.Controls.Add(this.panel1);
            this.StockInfo.Controls.Add(this.StockInfoHeaderContainer);
            this.StockInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.StockInfo.Location = new System.Drawing.Point(10, 10);
            this.StockInfo.Name = "StockInfo";
            this.StockInfo.Size = new System.Drawing.Size(467, 249);
            this.StockInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 209);
            this.panel1.TabIndex = 27;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderColor = System.Drawing.Color.LightGray;
            this.txtDesc.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtDesc.BorderRadius = 10;
            this.txtDesc.BorderSize = 1;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.IsError = false;
            this.txtDesc.Location = new System.Drawing.Point(154, 21);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDesc.PasswordChar = false;
            this.txtDesc.Placeholder = "Please describe the damage of the product";
            this.txtDesc.ReadOnly = false;
            this.txtDesc.Size = new System.Drawing.Size(275, 128);
            this.txtDesc.TabIndex = 40;
            this.txtDesc.TbBackColor = System.Drawing.Color.White;
            this.txtDesc.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtDesc.Texts = "Please describe the damage of the product";
            this.txtDesc.UnderlinedStyle = false;
            this.txtDesc.Click += new System.EventHandler(this.txtDesc_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(33, 30);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(89, 21);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Description";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StockInfoHeaderContainer
            // 
            this.StockInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.StockInfoHeaderContainer.Controls.Add(this.StockInfoHeader);
            this.StockInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.StockInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.StockInfoHeaderContainer.Name = "StockInfoHeaderContainer";
            this.StockInfoHeaderContainer.Size = new System.Drawing.Size(467, 40);
            this.StockInfoHeaderContainer.TabIndex = 20;
            // 
            // StockInfoHeader
            // 
            this.StockInfoHeader.AutoSize = true;
            this.StockInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.StockInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StockInfoHeader.Name = "StockInfoHeader";
            this.StockInfoHeader.Size = new System.Drawing.Size(243, 25);
            this.StockInfoHeader.TabIndex = 6;
            this.StockInfoHeader.Text = "Defetive Item Information";
            // 
            // DefectItem_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(487, 284);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "DefectItem_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Defect Item";
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.StockInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StockInfoHeaderContainer.ResumeLayout(false);
            this.StockInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel StockInfo;
        private System.Windows.Forms.Panel StockInfoHeaderContainer;
        private System.Windows.Forms.Label StockInfoHeader;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnAddSupplier;
        private System.Windows.Forms.Panel panel1;
        private CustomizeControl.CustomizeTextbox txtDesc;
        private System.Windows.Forms.Label lblQuantity;
    }
}