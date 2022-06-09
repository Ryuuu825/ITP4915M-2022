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

    public partial class Appointment_Arrange : Form
    {
        public double totalAmount { get; set; }
        private double deposit;

        public Appointment_Arrange()
        {
            InitializeComponent();
            
        }


        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (TeamIDCombo.SelectedIndex < 0)
            {
                TeamIDCombo.BorderColor = Color.Red;
                return;
            }
            var teamId = TeamIDCombo.Items.ToString();
        }

        private void TeamIDCombo_Click(object sender, EventArgs e)
        {
            TeamIDCombo.BorderColor = Color.LightGray;
        }
    }
}
