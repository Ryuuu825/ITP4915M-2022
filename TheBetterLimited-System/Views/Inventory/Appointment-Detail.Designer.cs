namespace TheBetterLimited.Views
{
    partial class Appointment_Add
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
            this.MainForm = new System.Windows.Forms.Panel();
            this.AppointmentInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            this.lblSessionId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTeamId = new System.Windows.Forms.Label();
            this.AppointmentInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.AppointmentInfoHeader = new System.Windows.Forms.Label();
            this.txtSessionId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtDepartmentId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.txtTeamId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.MainForm.SuspendLayout();
            this.AppointmentInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AppointmentInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.AppointmentInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(474, 305);
            this.MainForm.TabIndex = 2;
            // 
            // AppointmentInfo
            // 
            this.AppointmentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AppointmentInfo.Controls.Add(this.panel1);
            this.AppointmentInfo.Controls.Add(this.AppointmentInfoHeaderContainer);
            this.AppointmentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppointmentInfo.Location = new System.Drawing.Point(10, 10);
            this.AppointmentInfo.Name = "AppointmentInfo";
            this.AppointmentInfo.Size = new System.Drawing.Size(454, 289);
            this.AppointmentInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTeamId);
            this.panel1.Controls.Add(this.txtDepartmentId);
            this.panel1.Controls.Add(this.txtSessionId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblDepartmentId);
            this.panel1.Controls.Add(this.lblSessionId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblTeamId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 249);
            this.panel1.TabIndex = 27;
            // 
            // txtId
            // 
            this.txtId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.LightGray;
            this.txtId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtId.BorderRadius = 10;
            this.txtId.BorderSize = 1;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.IsError = false;
            this.txtId.Location = new System.Drawing.Point(213, 24);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtId.MaxLength = 5;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtId.PasswordChar = false;
            this.txtId.Placeholder = "Automatically Generated";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(229, 38);
            this.txtId.TabIndex = 44;
            this.txtId.TbBackColor = System.Drawing.Color.White;
            this.txtId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtId.Texts = "Automatically Generated";
            this.txtId.UnderlinedStyle = false;
            // 
            // lblDepartmentId
            // 
            this.lblDepartmentId.AutoSize = true;
            this.lblDepartmentId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentId.Location = new System.Drawing.Point(42, 136);
            this.lblDepartmentId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartmentId.Name = "lblDepartmentId";
            this.lblDepartmentId.Size = new System.Drawing.Size(112, 21);
            this.lblDepartmentId.TabIndex = 3;
            this.lblDepartmentId.Text = "Department ID";
            this.lblDepartmentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSessionId
            // 
            this.lblSessionId.AutoSize = true;
            this.lblSessionId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionId.Location = new System.Drawing.Point(57, 83);
            this.lblSessionId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSessionId.Name = "lblSessionId";
            this.lblSessionId.Size = new System.Drawing.Size(82, 21);
            this.lblSessionId.TabIndex = 2;
            this.lblSessionId.Text = "Session ID";
            this.lblSessionId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(82, 33);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 21);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID*";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTeamId
            // 
            this.lblTeamId.AutoSize = true;
            this.lblTeamId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamId.Location = new System.Drawing.Point(66, 192);
            this.lblTeamId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamId.Name = "lblTeamId";
            this.lblTeamId.Size = new System.Drawing.Size(65, 21);
            this.lblTeamId.TabIndex = 4;
            this.lblTeamId.Text = "Team ID";
            this.lblTeamId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppointmentInfoHeaderContainer
            // 
            this.AppointmentInfoHeaderContainer.BackColor = System.Drawing.Color.White;
            this.AppointmentInfoHeaderContainer.Controls.Add(this.AppointmentInfoHeader);
            this.AppointmentInfoHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppointmentInfoHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.AppointmentInfoHeaderContainer.Name = "AppointmentInfoHeaderContainer";
            this.AppointmentInfoHeaderContainer.Size = new System.Drawing.Size(454, 40);
            this.AppointmentInfoHeaderContainer.TabIndex = 20;
            // 
            // AppointmentInfoHeader
            // 
            this.AppointmentInfoHeader.AutoSize = true;
            this.AppointmentInfoHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentInfoHeader.Location = new System.Drawing.Point(3, 7);
            this.AppointmentInfoHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppointmentInfoHeader.Name = "AppointmentInfoHeader";
            this.AppointmentInfoHeader.Size = new System.Drawing.Size(243, 25);
            this.AppointmentInfoHeader.TabIndex = 6;
            this.AppointmentInfoHeader.Text = "Appointment information";
            // 
            // txtSessionId
            // 
            this.txtSessionId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtSessionId.BackColor = System.Drawing.Color.White;
            this.txtSessionId.BorderColor = System.Drawing.Color.LightGray;
            this.txtSessionId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtSessionId.BorderRadius = 10;
            this.txtSessionId.BorderSize = 1;
            this.txtSessionId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSessionId.ForeColor = System.Drawing.Color.Black;
            this.txtSessionId.IsError = false;
            this.txtSessionId.Location = new System.Drawing.Point(213, 74);
            this.txtSessionId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSessionId.MaxLength = 5;
            this.txtSessionId.Multiline = false;
            this.txtSessionId.Name = "txtSessionId";
            this.txtSessionId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSessionId.PasswordChar = false;
            this.txtSessionId.Placeholder = "Automatically Generated";
            this.txtSessionId.ReadOnly = true;
            this.txtSessionId.Size = new System.Drawing.Size(229, 38);
            this.txtSessionId.TabIndex = 45;
            this.txtSessionId.TbBackColor = System.Drawing.Color.White;
            this.txtSessionId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtSessionId.Texts = "Automatically Generated";
            this.txtSessionId.UnderlinedStyle = false;
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtDepartmentId.BackColor = System.Drawing.Color.White;
            this.txtDepartmentId.BorderColor = System.Drawing.Color.LightGray;
            this.txtDepartmentId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtDepartmentId.BorderRadius = 10;
            this.txtDepartmentId.BorderSize = 1;
            this.txtDepartmentId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentId.ForeColor = System.Drawing.Color.Black;
            this.txtDepartmentId.IsError = false;
            this.txtDepartmentId.Location = new System.Drawing.Point(213, 127);
            this.txtDepartmentId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDepartmentId.MaxLength = 5;
            this.txtDepartmentId.Multiline = false;
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDepartmentId.PasswordChar = false;
            this.txtDepartmentId.Placeholder = "Automatically Generated";
            this.txtDepartmentId.ReadOnly = true;
            this.txtDepartmentId.Size = new System.Drawing.Size(229, 38);
            this.txtDepartmentId.TabIndex = 46;
            this.txtDepartmentId.TbBackColor = System.Drawing.Color.White;
            this.txtDepartmentId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtDepartmentId.Texts = "Automatically Generated";
            this.txtDepartmentId.UnderlinedStyle = false;
            // 
            // txtTeamId
            // 
            this.txtTeamId.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtTeamId.BackColor = System.Drawing.Color.White;
            this.txtTeamId.BorderColor = System.Drawing.Color.LightGray;
            this.txtTeamId.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.txtTeamId.BorderRadius = 10;
            this.txtTeamId.BorderSize = 1;
            this.txtTeamId.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamId.ForeColor = System.Drawing.Color.Black;
            this.txtTeamId.IsError = false;
            this.txtTeamId.Location = new System.Drawing.Point(213, 183);
            this.txtTeamId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTeamId.MaxLength = 5;
            this.txtTeamId.Multiline = false;
            this.txtTeamId.Name = "txtTeamId";
            this.txtTeamId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTeamId.PasswordChar = false;
            this.txtTeamId.Placeholder = "Automatically Generated";
            this.txtTeamId.ReadOnly = true;
            this.txtTeamId.Size = new System.Drawing.Size(229, 38);
            this.txtTeamId.TabIndex = 47;
            this.txtTeamId.TbBackColor = System.Drawing.Color.White;
            this.txtTeamId.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.txtTeamId.Texts = "Automatically Generated";
            this.txtTeamId.UnderlinedStyle = false;
            // 
            // Appointment_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(474, 305);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Appointment_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Detail";
            this.MainForm.ResumeLayout(false);
            this.AppointmentInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AppointmentInfoHeaderContainer.ResumeLayout(false);
            this.AppointmentInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel AppointmentInfo;
        private System.Windows.Forms.Panel AppointmentInfoHeaderContainer;
        private System.Windows.Forms.Label AppointmentInfoHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDepartmentId;
        private System.Windows.Forms.Label lblSessionId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTeamId;
        private CustomizeControl.CustomizeTextbox txtId;
        private CustomizeControl.CustomizeTextbox txtTeamId;
        private CustomizeControl.CustomizeTextbox txtDepartmentId;
        private CustomizeControl.CustomizeTextbox txtSessionId;
    }
}