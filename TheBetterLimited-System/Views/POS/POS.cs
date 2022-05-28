using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;

namespace TheBetterLimited.Views
{
    public partial class POS : Form
    {
        private UserController uc = new UserController();
        private BindingSource bs = new BindingSource();
        private List<string> selecteUserId = new List<string>();
        private DialogResult choose;
        private RestResponse result;
        private bool isEditing = false;

        public POS()
        {
            InitializeComponent();
        }

        /*
         * Dom Style/Event Process
         */
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
        }


        /*
        * Dom Event Handler
        */

        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column

            selecteUserId.Clear();
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form addUser = Application.OpenForms["Usermanagement_Add"];
            if (addUser == null || addUser.IsDisposed)
            {
                Usermanagement_Add userAdd = new Usermanagement_Add();
                userAdd.Show();
                userAdd.TopLevel = true;
            }
            else
            {
                addUser.Activate();
                addUser.WindowState = FormWindowState.Normal;
            }

        }

        private void CatalogBtn_Click(object sender, EventArgs e)
        {
            ChangeCheckedBtn_Style((RoundButton)sender);
        }

        private void CatalogBtn_MouseHover(object sender, EventArgs e)
        {
            ((RoundButton)sender).BorderColor = Color.SeaGreen;
            ((RoundButton)sender).ForeColor = Color.SeaGreen;
        }

        private void ChangeCheckedBtn_Style(RoundButton sender)
        {
            sender.BorderColor = Color.SeaGreen;
            sender.ForeColor = Color.SeaGreen;
        }
        private void ResetBtn_Style(RoundButton sender)
        {
            sender.BorderColor = Color.DimGray;
            sender.ForeColor = Color.DimGray;
        }
    }
}
