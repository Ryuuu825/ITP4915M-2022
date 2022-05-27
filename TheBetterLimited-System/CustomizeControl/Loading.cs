using System;
using System.Windows.Forms;

namespace TheBetterLimited.CustomizeControl
{
    public partial class Loading : Form
    {
        public event Action OnClose;
        public Loading()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            OnClose += () =>
            {
                this.Prompt.Text = "Finish";
                this.Progress.Value = 100;
                this.Close();
                this.Dispose();
            };
        }

        public void End()
        {
            this.OnClose.Invoke();
        }

        public void Update(string message, int progress)
        {
            this.Prompt.Text = message;
            this.Progress.Value = progress == 0 ? 0 : progress % 100;
        }
    }
}