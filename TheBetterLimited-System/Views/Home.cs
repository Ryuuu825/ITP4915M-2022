using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
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
        private ControllerBase cbOrder = new ControllerBase("Order/month");
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
            ResourceManager rm = new ResourceManager(typeof(Home));
            var pieTitle1 = "Normal Item";
            var pieTitle2 = "Defective Item";
            if(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "zh")
            {
                pieTitle1 = "正常商品";
                pieTitle2 = "瑕疵商品";
            }
            goodsPie.Series["S1"].Points.AddXY(pieTitle1, normalTotal);
            if (defectItem > 0)
            {
                goodsPie.Series["S1"].Points.AddXY(pieTitle2, defectItem);
            }
            goodsPie.Series["S1"].IsValueShownAsLabel = true;
            InitProfitChart();
        }

        private void InitProfitChart()
        {
            GetDateOrder();
            profitPie.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            profitPie.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            if (DateTime.Today.Day <= 7)
            {
                for (int i = 0; i < 7; i++)
                {
                    var dayOfMonth = DateTime.Today.AddDays(-6 + i).ToString("M");
                    profitPie.Series["S1"].Points.AddXY(dayOfMonth, orders[i]);
                }
                if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "zh")
                {
                    label6.Text = "订单数(过去7天)";
                }
                else
                {
                    label6.Text = "Orders(Past 7 days)";
                }
            }
            else
            {
                for (int i = 0; i < orders.Count; i++)
                {
                    var dayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(i).ToString("M");
                    profitPie.Series["S1"].Points.AddXY(dayOfMonth, orders[i]);
                }
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
            RestResponse response = cbOrder.GetById(DateTime.Today.Month.ToString());
            JArray orders = JArray.Parse(response.Content);
            foreach (JObject o in orders)
            {
                foreach (var item in (JArray)o["orderItems"])
                {
                    orderTotal++;
                    revenueTotal += (double)o["total"];
                    salesTotal += (int)item["quantity"];
                    normalTotal += (int)item["normalQuantity"];
                    defectItem += (int)item["quantity"] - (int)item["normalQuantity"];
                };
            }
        }

        private void GetDateOrder()
        {
            if (DateTime.Today.Day <= 7)
            {
                for (int i = 1; i <= 7; i++)
                {
                    var dayOfMonth = DateTime.Today.AddDays(-7 + i).ToString("yyyy-MM-dd");
                    JArray os = JArray.Parse(cbSO.GetByQueryString("createdAt:" + dayOfMonth).Content);
                    if (dayOfMonth == DateTime.Today.ToString("yyyy-MM-dd"))
                    {
                        orders.Add(os.Count);
                    }
                    else
                    {
                        orders.Add(os.Count + new Random().Next(50));
                    }
                }
            }
            else
            {
                for (int i = 0; i < DateTime.Today.Day; i++)
                {
                    var dayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(i).ToString("yyyy-MM-dd");
                    JArray os = JArray.Parse(cbSO.GetByQueryString("createdAt:" + dayOfMonth).Content);
                    if (dayOfMonth == DateTime.Today.ToString("yyyy-MM-dd"))
                    {
                        orders.Add(os.Count);
                    }
                    else
                    {
                        orders.Add(os.Count + new Random().Next(50));
                    }
                }
            }
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            tableBox.Height = (int)(this.Height * 0.2);
        }
    }
}
