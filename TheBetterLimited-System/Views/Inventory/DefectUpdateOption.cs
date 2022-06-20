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
    public partial class DefectUpdateOption : Form
    {
        private DefectItemController cbDefect = new DefectItemController("DefectItem");
        public List<string> ids { get; set; }

        public DefectUpdateOption()
        {
            InitializeComponent();
        }


        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            RestResponse result = null;
            string error = "";
            if (collectedOption.IsSelected)
            {
                foreach (var itemId in ids)
                {
                    result = cbDefect.Update(new { id = itemId, status = 1 });
                    if (result.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        error += result.ErrorMessage + "\n";
                    }
                }
                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(result.ErrorMessage);
                }
                else
                {
                    MessageBox.Show("Defect Item(s) Updated!");
                    this.OnExit.Invoke();
                    this.Close();
                    this.Dispose();
                }
            }
            else if (returnedOption.IsSelected)
            {
                foreach (var itemId in ids)
                {
                    result = cbDefect.Update(new { id = itemId, status = 2 });
                    if (result.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        error += result.ErrorMessage + "\n";
                    }
                }
                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(result.ErrorMessage);
                }else
                {
                    MessageBox.Show("Defect Item(s) Updated!");
                    this.OnExit.Invoke();
                    this.Close();
                    this.Dispose();
                }
            }
        }

        private void returnedOption_Click(object sender, EventArgs e)
        {
            collectedOption.IsSelected = false;
        }

        private void collectedOption_Click(object sender, EventArgs e)
        {
            returnedOption.IsSelected = false;
        }
    }
}
