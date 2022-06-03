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
            this.BottomBtn = new System.Windows.Forms.Panel();
            this.btnCancel = new TheBetterLimited.CustomizeControl.RoundButton();
            this.btnAddAppointment = new TheBetterLimited.CustomizeControl.RoundButton();
            this.MainForm = new System.Windows.Forms.Panel();
            this.AppointmentInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxSessionId = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.cbxDepartmentId = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.cbxTeamId = new TheBetterLimited.CustomizeControl.CustomizeComboBox();
            this.Info = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            this.lblSessionId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTeamId = new System.Windows.Forms.Label();
            this.AppointmentInfoHeaderContainer = new System.Windows.Forms.Panel();
            this.AppointmentInfoHeader = new System.Windows.Forms.Label();
            this.txtId = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.BottomBtn.SuspendLayout();
            this.MainForm.SuspendLayout();
            this.AppointmentInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AppointmentInfoHeaderContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomBtn
            // 
            this.BottomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BottomBtn.Controls.Add(this.btnCancel);
            this.BottomBtn.Controls.Add(this.btnAddAppointment);
            this.BottomBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomBtn.Location = new System.Drawing.Point(10, 303);
            this.BottomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBtn.Name = "BottomBtn";
            this.BottomBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.BottomBtn.Size = new System.Drawing.Size(764, 54);
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
            this.btnCancel.Location = new System.Drawing.Point(478, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddAppointment.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAddAppointment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddAppointment.BorderRadius = 10;
            this.btnAddAppointment.BorderSize = 0;
            this.btnAddAppointment.FlatAppearance.BorderSize = 0;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.IsChecked = false;
            this.btnAddAppointment.Location = new System.Drawing.Point(623, 6);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(128, 40);
            this.btnAddAppointment.TabIndex = 6;
            this.btnAddAppointment.Text = "Add ";
            this.btnAddAppointment.TextColor = System.Drawing.Color.White;
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainForm.Controls.Add(this.BottomBtn);
            this.MainForm.Controls.Add(this.AppointmentInfo);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Margin = new System.Windows.Forms.Padding(2);
            this.MainForm.Name = "MainForm";
            this.MainForm.Padding = new System.Windows.Forms.Padding(10);
            this.MainForm.Size = new System.Drawing.Size(784, 367);
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
            this.AppointmentInfo.Size = new System.Drawing.Size(764, 289);
            this.AppointmentInfo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.cbxSessionId);
            this.panel1.Controls.Add(this.cbxDepartmentId);
            this.panel1.Controls.Add(this.cbxTeamId);
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.lblDepartmentId);
            this.panel1.Controls.Add(this.lblSessionId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblTeamId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 249);
            this.panel1.TabIndex = 27;
            // 
            // cbxSessionId
            // 
            this.cbxSessionId.BackColor = System.Drawing.Color.White;
            this.cbxSessionId.BorderColor = System.Drawing.Color.LightGray;
            this.cbxSessionId.BorderRadius = 1;
            this.cbxSessionId.BorderSize = 1;
            this.cbxSessionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxSessionId.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.cbxSessionId.ForeColor = System.Drawing.Color.DimGray;
            this.cbxSessionId.IconColor = System.Drawing.Color.Black;
            this.cbxSessionId.ListBackColor = System.Drawing.Color.White;
            this.cbxSessionId.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxSessionId.Location = new System.Drawing.Point(213, 78);
            this.cbxSessionId.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxSessionId.Name = "cbxSessionId";
            this.cbxSessionId.Padding = new System.Windows.Forms.Padding(1);
            this.cbxSessionId.Size = new System.Drawing.Size(229, 30);
            this.cbxSessionId.TabIndex = 43;
            this.cbxSessionId.Texts = "";
            this.cbxSessionId.UnderlinedStyle = false;
            // 
            // cbxDepartmentId
            // 
            this.cbxDepartmentId.BackColor = System.Drawing.Color.White;
            this.cbxDepartmentId.BorderColor = System.Drawing.Color.LightGray;
            this.cbxDepartmentId.BorderRadius = 1;
            this.cbxDepartmentId.BorderSize = 1;
            this.cbxDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxDepartmentId.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.cbxDepartmentId.ForeColor = System.Drawing.Color.DimGray;
            this.cbxDepartmentId.IconColor = System.Drawing.Color.Black;
            this.cbxDepartmentId.ListBackColor = System.Drawing.Color.White;
            this.cbxDepartmentId.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxDepartmentId.Location = new System.Drawing.Point(213, 131);
            this.cbxDepartmentId.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxDepartmentId.Name = "cbxDepartmentId";
            this.cbxDepartmentId.Padding = new System.Windows.Forms.Padding(1);
            this.cbxDepartmentId.Size = new System.Drawing.Size(229, 30);
            this.cbxDepartmentId.TabIndex = 42;
            this.cbxDepartmentId.Texts = "";
            this.cbxDepartmentId.UnderlinedStyle = false;
            // 
            // cbxTeamId
            // 
            this.cbxTeamId.BackColor = System.Drawing.Color.White;
            this.cbxTeamId.BorderColor = System.Drawing.Color.LightGray;
            this.cbxTeamId.BorderRadius = 1;
            this.cbxTeamId.BorderSize = 1;
            this.cbxTeamId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxTeamId.Font = new System.Drawing.Font("PMingLiU", 10F);
            this.cbxTeamId.ForeColor = System.Drawing.Color.DimGray;
            this.cbxTeamId.IconColor = System.Drawing.Color.Black;
            this.cbxTeamId.ListBackColor = System.Drawing.Color.White;
            this.cbxTeamId.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxTeamId.Location = new System.Drawing.Point(213, 187);
            this.cbxTeamId.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxTeamId.Name = "cbxTeamId";
            this.cbxTeamId.Padding = new System.Windows.Forms.Padding(1);
            this.cbxTeamId.Size = new System.Drawing.Size(229, 30);
            this.cbxTeamId.TabIndex = 41;
            this.cbxTeamId.Texts = "";
            this.cbxTeamId.UnderlinedStyle = false;
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(511, 45);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(240, 110);
            this.Info.TabIndex = 5;
            this.Info.Text = "Appintment is the act of officially choosing someone for a job, or the job itself" +
    ". Here the someone usually is the workman.";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.SeaGreen;
            this.Title.Location = new System.Drawing.Point(511, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(192, 30);
            this.Title.TabIndex = 3;
            this.Title.Text = "Add Appointment";
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
            this.AppointmentInfoHeaderContainer.Size = new System.Drawing.Size(764, 40);
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
            // Appointment_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(784, 367);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Appointment_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.BottomBtn.ResumeLayout(false);
            this.MainForm.ResumeLayout(false);
            this.AppointmentInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AppointmentInfoHeaderContainer.ResumeLayout(false);
            this.AppointmentInfoHeaderContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomBtn;
        private System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel AppointmentInfo;
        private System.Windows.Forms.Panel AppointmentInfoHeaderContainer;
        private System.Windows.Forms.Label AppointmentInfoHeader;
        private CustomizeControl.RoundButton btnCancel;
        private CustomizeControl.RoundButton btnAddAppointment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lblDepartmentId;
        private System.Windows.Forms.Label lblSessionId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTeamId;
        private CustomizeControl.CustomizeComboBox cbxSessionId;
        private CustomizeControl.CustomizeComboBox cbxDepartmentId;
        private CustomizeControl.CustomizeComboBox cbxTeamId;
        private CustomizeControl.CustomizeTextbox txtId;
    }
}