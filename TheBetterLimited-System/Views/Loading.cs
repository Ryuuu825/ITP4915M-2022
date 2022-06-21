using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class Loading : Form
    {
        public event Action OnExit;
        Timer timer = new Timer();
        int i = 1;

        public Loading()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Start();
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (i <= 3) {
                waitPoint.Text += ".";
                i++;
            }
            else
            {
                waitPoint.Text = ".";
                i = 1;
            }
        }
    }
}
