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
using TheBetterLimited.Utils;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{

    public partial class Appointment_Arrange : Form
    {
        public string appointmentId { get; set; }
        public List<string> appointmentIds { get; set; }
        private ControllerBase cbAppointment = new ControllerBase("Appointment");
        private RestResponse response = new RestResponse();

        public Appointment_Arrange()
        {
            InitializeComponent();
            if(GlobalsData.currentUser["department"] == "Inventory")
            {
                foreach (int item in Enum.GetValues(typeof(TeamEnum)))
                {
                    if(item > 300 && item < 400)
                        TeamIDCombo.Items.Add(item.ToString());
                }
            }
            else if (GlobalsData.currentUser["department"] == "Technical")
            {
                foreach (int item in Enum.GetValues(typeof(TeamEnum)))
                {
                    if (item > 700 && item < 800)
                        TeamIDCombo.Items.Add(item.ToString());
                }
            }
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
            try
            {
                if (appointmentIds!= null && appointmentIds.Count > 0)
                {
                    foreach (var item in appointmentIds)
                    {
                        object update = new { attribute = "_teamId", value = TeamIDCombo.SelectedItem };
                        List<object> list = new List<object>();
                        list.Add(update);
                        response = cbAppointment.Update(item, list);
                    }
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Appointments are arranged to {TeamIDCombo.SelectedItem}.");
                        this.Close();
                        this.Dispose();
                        this.OnExit.Invoke();
                    }
                }
                else
                {
                    object update = new { attribute = "_teamId", value = TeamIDCombo.SelectedItem };
                    List<object> list = new List<object>();
                    list.Add(update);
                    response = cbAppointment.Update(appointmentId, list);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Appointment is arranged to {TeamIDCombo.SelectedItem}.");
                        this.Close();
                        this.Dispose();
                        this.OnExit.Invoke();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TeamIDCombo_Click(object sender, EventArgs e)
        {
            TeamIDCombo.BorderColor = Color.LightGray;
        }

        private void TeamIDCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            TeamNameTxt.Texts = EnumExtensions.Description((TeamEnum)(Convert.ToInt32(TeamIDCombo.SelectedItem)));
        }
    }
}
