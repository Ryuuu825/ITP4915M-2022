namespace TheBetterLimited.CustomizeControl
{
    partial class RoundComboBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbList
            // 
            this.cmbList.FormattingEnabled = true;
            this.cmbList.ItemHeight = 12;
            this.cmbList.Location = new System.Drawing.Point(11, 11);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(263, 20);
            this.cmbList.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Black;
            this.lblText.Location = new System.Drawing.Point(5, 2);
            this.lblText.Name = "lblText";
            this.lblText.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblText.Size = new System.Drawing.Size(269, 36);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "lblText";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIcon
            // 
            this.btnIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIcon.FlatAppearance.BorderSize = 0;
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.Location = new System.Drawing.Point(251, 6);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Padding = new System.Windows.Forms.Padding(5);
            this.btnIcon.Size = new System.Drawing.Size(28, 28);
            this.btnIcon.TabIndex = 2;
            this.btnIcon.UseVisualStyleBackColor = true;
            // 
            // RoundComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.cmbList);
            this.Name = "RoundComboBox";
            this.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Size = new System.Drawing.Size(279, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnIcon;
    }
}
