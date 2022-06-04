using System.ComponentModel;

namespace TheBetterLimited.CustomizeControl
{
    partial class Loading
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.Prompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(12, 50);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(334, 23);
            this.Progress.TabIndex = 0;
            // 
            // Prompt
            // 
            this.Prompt.Location = new System.Drawing.Point(12, 9);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(334, 23);
            this.Prompt.TabIndex = 1;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 82);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.Progress);
            this.Name = "Loading";
            this.Text = "Loading";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label Prompt;

        #endregion
    }
}