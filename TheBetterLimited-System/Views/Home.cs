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
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class Home : Form
    {
        private ControllerBase cbOrder = new ControllerBase("Order");
        private ControllerBase cbSO = new ControllerBase("SalesOrder");
        private BindingSource bs = new BindingSource();
        private List<string> selecteUserId = new List<string>();
        private DialogResult choose;
        private RestResponse result;
        private bool isEditing = false;
        private int orderTotal = 0;
        private int salesTotal = 0;
        private int normalTotal = 0;
        private double revenueTotal = 0.0;
        private int completedOrder = 0;
        private int bookingOrder = 0;
        private int defectItem = 0;
        private double refundOrder = 0.0;
        private List<int> orders = new List<int>();

        public Home()
        {
            InitializeComponent();
            GetOrder();
            lblCom.Text = orderTotal.ToString();
            lblSales.Text = salesTotal.ToString();
            lblRevenue.Text = String.Format("{0:C2}", revenueTotal);
            lblProfit.Text = String.Format("{0:C2}", revenueTotal * 0.32);
            goodsPie.Series["S1"].Points.AddXY("Normal Item", normalTotal);
            if (defectItem > 0)
            {
                goodsPie.Series["S1"].Points.AddXY("Defective Item", defectItem);
            }
            goodsPie.Series["S1"].IsValueShownAsLabel = true;
            InitProfitChart();
        }

        private void InitProfitChart()
        {
            GetDateOrder();
            profitPie.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            profitPie.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            for (int i = 0; i < orders.Count; i++)
            {
                profitPie.Series["S1"].Points.AddXY(DateTime.Today.AddDays(-30+i).ToString("M"), orders[i]);
            }
        }

        /*
         * Dom Style/Event Process
         */

        /*
        * Dom Event Handler
        */

        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column
        }

        private void GetOrder()
        {
            RestResponse response = cbOrder.GetAll();
            JArray orders = JArray.Parse(response.Content);
            foreach (JObject o in orders)
            {
                if (o["status"].ToString().Equals("Completed"))
                {
                    orderTotal++;
                    revenueTotal += (double)o["total"];
                }
                foreach (var item in (JArray)o["orderItems"])
                {
                    salesTotal += (int)item["quantity"];
                    normalTotal += (int)item["normalQuantity"];
                    defectItem += (int)item["quantity"] - (int)item["normalQuantity"];
                };
            }
        }

        private void GetDateOrder()
        {
            for(int i=0; i < DateTime.Today.Day; i++)
            {
                var dayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(i).ToString("yyyy-MM-dd");
                JArray os = JArray.Parse(cbSO.GetByQueryString("createdAt:" + dayOfMonth).Content);
                orders.Add(os.Count+1);
            }
        }
    }
}
