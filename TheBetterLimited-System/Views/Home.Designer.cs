namespace TheBetterLimited.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Action = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.SearchBarTxt = new TheBetterLimited.CustomizeControl.CustomizeTextbox();
            this.curdAction = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.RefreshBtn = new FontAwesome.Sharp.IconButton();
            this.Action.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchBar.SuspendLayout();
            this.Header.SuspendLayout();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Action
            // 
            this.Action.BackColor = System.Drawing.Color.White;
            this.Action.Controls.Add(this.panel1);
            this.Action.Dock = System.Windows.Forms.DockStyle.Top;
            this.Action.Location = new System.Drawing.Point(0, 40);
            this.Action.Margin = new System.Windows.Forms.Padding(2);
            this.Action.Name = "Action";
            this.Action.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Action.Size = new System.Drawing.Size(778, 44);
            this.Action.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchBar);
            this.panel1.Controls.Add(this.curdAction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 38);
            this.panel1.TabIndex = 6;
            // 
            // SearchBar
            // 
            this.SearchBar.Controls.Add(this.pictureBox1);
            this.SearchBar.Controls.Add(this.SearchBarTxt);
            this.SearchBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBar.Location = new System.Drawing.Point(550, 0);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(220, 38);
            this.SearchBar.TabIndex = 9;
            // 
            // SearchBarTxt
            // 
            this.SearchBarTxt.BackColor = System.Drawing.Color.White;
            this.SearchBarTxt.BorderColor = System.Drawing.Color.LightGray;
            this.SearchBarTxt.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.SearchBarTxt.BorderRadius = 10;
            this.SearchBarTxt.BorderSize = 1;
            this.SearchBarTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBarTxt.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBarTxt.ForeColor = System.Drawing.Color.LightGray;
            this.SearchBarTxt.IsError = false;
            this.SearchBarTxt.Location = new System.Drawing.Point(0, 0);
            this.SearchBarTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SearchBarTxt.MaxLength = 20;
            this.SearchBarTxt.Multiline = true;
            this.SearchBarTxt.Name = "SearchBarTxt";
            this.SearchBarTxt.Padding = new System.Windows.Forms.Padding(22, 8, 8, 6);
            this.SearchBarTxt.PasswordChar = false;
            this.SearchBarTxt.Placeholder = "Search by Keywords";
            this.SearchBarTxt.ReadOnly = false;
            this.SearchBarTxt.Size = new System.Drawing.Size(220, 38);
            this.SearchBarTxt.TabIndex = 9;
            this.SearchBarTxt.TbBackColor = System.Drawing.SystemColors.Window;
            this.SearchBarTxt.TextAlign = TheBetterLimited.CustomizeControl.CustomizeTextbox.TextAlignEnum.Left;
            this.SearchBarTxt.Texts = "Search by Keywords";
            this.SearchBarTxt.UnderlinedStyle = false;
            this.SearchBarTxt._TextChanged += new System.EventHandler(this.SearchBarTxt__TextChanged);
            // 
            // curdAction
            // 
            this.curdAction.Dock = System.Windows.Forms.DockStyle.Left;
            this.curdAction.Location = new System.Drawing.Point(0, 0);
            this.curdAction.Margin = new System.Windows.Forms.Padding(2);
            this.curdAction.Name = "curdAction";
            this.curdAction.Size = new System.Drawing.Size(773, 38);
            this.curdAction.TabIndex = 6;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Controls.Add(this.RefreshBtn);
            this.Header.Controls.Add(this.Title);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(778, 40);
            this.Header.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 13.91597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(2, 7);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(66, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Home";
            // 
            // Data
            // 
            this.Data.Controls.Add(this.splitContainer1);
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(0, 84);
            this.Data.Margin = new System.Windows.Forms.Padding(2);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Data.Size = new System.Drawing.Size(778, 381);
            this.Data.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(778, 379);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.DimGray;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 124;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 124;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 124;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::TheBetterLimited.Properties.Resources.rRkznp;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(509, 379);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 20);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseBtn.IconColor = System.Drawing.Color.Black;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.IconSize = 25;
            this.CloseBtn.Location = new System.Drawing.Point(736, 4);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(39, 36);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.RefreshBtn.IconColor = System.Drawing.Color.Black;
            this.RefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefreshBtn.IconSize = 25;
            this.RefreshBtn.Location = new System.Drawing.Point(698, 4);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(39, 36);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(778, 465);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "UserManagement";
            this.Action.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SearchBar.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Data.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Action;
        private FontAwesome.Sharp.IconButton RefreshBtn;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private System.Windows.Forms.Panel Data;
        private System.Windows.Forms.Panel curdAction;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SearchBar;
        private CustomizeControl.CustomizeTextbox SearchBarTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}