using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Revenue : Form
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
        private DataTable dt = new DataTable();
        private List<DataTemplate> dataTemplates = new List<DataTemplate>();

        public Revenue()
        {
            InitializeComponent();
            InitialzeDataTable();
            timeCombo.SelectedIndex = 0;
            typeCombo.SelectedIndex = 1;
            GetOrder();
            ResourceManager rm = new ResourceManager(typeof(Home));
            InitPieChart();
            InitGrowthChart();
        }

        private void InitGrowthChart()
        {
            profitPie.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            profitPie.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            profitPie.Series["S1"].Points.Clear();
            for (int i = 0; i < dataTemplates.Count; i++)
            {
                if (typeCombo.SelectedIndex == 0)
                {
                    profitPie.Series["S1"].Points.AddXY(dataTemplates[i].Date, dataTemplates[i].orders);
                }
                else if (typeCombo.SelectedIndex == 1)
                {
                    profitPie.Series["S1"].Points.AddXY(dataTemplates[i].Date, dataTemplates[i].revenue);
                }
                //var dayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(i).ToString("M");
            }
        }

        private void InitPieChart()
        {
            Random random = new Random();
            var h1 = random.Next(100);
            var h2 = 100- h1;
            goodsPie.Series["S1"].Points.Clear();
            goodsPie.Series["S1"].Points.AddXY("H01", h1);
            goodsPie.Series["S1"].Points.AddXY("H02", h2);
            goodsPie.Series["S1"].IsValueShownAsLabel = true;
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
        public event Action OnExit;
        private void GetDateOrder()
        {
            for (int i = 0; i < DateTime.Today.Day; i++)
            {
                var dayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(i).ToString("yyyy-MM-dd");
                JArray os = JArray.Parse(cbSO.GetByQueryString("createdAt:" + dayOfMonth).Content);
                orders.Add(os.Count + 1);
            }
        }

        private void timeCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            dataTemplates.Clear();
            dt.Clear();
            if (timeCombo.SelectedIndex == 0)
            {
                TodayData();
            }
            if (timeCombo.SelectedIndex == 1)
            {
                MonthlyData();
            }
            if (timeCombo.SelectedIndex == 2)
            {
                YearData();
            }
            InitGrowthChart();
            InitPieChart();
        }

        private void InitialzeDataTable()
        {
            dt.Columns.Add("date");
            dt.Columns.Add("orders");
            dt.Columns.Add("revenue");
        }

        private void TodayData()
        {
            var today = new DateTime().ToString("yyyy-MM-dd");
            Random random = new Random();
            for (int i = 0; i < 12; i += 2)
            {
                DataRow row = dt.NewRow();
                var date = (9 + i).ToString("00") + ":00 - " + (9 + i + 2).ToString("00") + ":00";
                var orders = random.Next(10) + 1;
                var revenue = random.Next(50000) + 100;
                row["date"] = date;
                row["orders"] = orders;
                row["revenue"] = String.Format("{0:C2}", revenue);
                dataTemplates.Add(new DataTemplate(date, orders, revenue));
                dt.Rows.Add(row);
            }
            bs.DataSource = dt;
            DataGrid.DataSource = bs;
        }
        /*JArray os = JArray.Parse(cbSO.GetByQueryString("createdAt:" + today).Content);
        orders.Add(os.Count);
        }*/

        private void MonthlyData()
        {
            var today = DateTime.Today.Day;
            Console.WriteLine(today);
            Random random = new Random();
            for (int i = 0; i < today; i++)
            {
                DataRow row = dt.NewRow();
                var date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddDays(i).ToString("M");
                var orders = random.Next(50) + 10;
                var revenue = random.Next(20000) + 5000;
                row["date"] = date;
                row["orders"] = orders;
                row["revenue"] = String.Format("{0:C2}", revenue);
                dataTemplates.Add(new DataTemplate(date, orders, revenue));
                dt.Rows.Add(row);
            }
            bs.DataSource = dt;
            DataGrid.DataSource = bs;
        }

        private void YearData()
        {
            var today = new DateTime().ToString("yyyy-MM-dd");
            Random random = new Random();
            for (int i = 1; i <= 12; i++)
            {
                DataRow row = dt.NewRow();
                var date = DateTime.Today.Year + " - " + i.ToString("00");
                var orders = random.Next(300) + 100;
                var revenue = random.Next(100000) + 20000;
                row["date"] = date;
                row["orders"] = orders;
                row["revenue"] = String.Format("{0:C2}", revenue);
                dataTemplates.Add(new DataTemplate(date, orders, revenue));
                dt.Rows.Add(row);
            }
            bs.DataSource = dt;
            DataGrid.DataSource = bs;
        }

        class DataTemplate
        {
            public DataTemplate(string date, int orders, int revenue)
            {
                Date = date;
                this.orders = orders;
                this.revenue = revenue;
            }

            public string Date { get; set; }
            public int orders { get; set; }
            public int revenue { get; set; }

        }

        private void typeCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            InitGrowthChart();
        }

        private void Revenue_Resize(object sender, EventArgs e)
        {
            growthBox.Height = this.Height / 2;
        }
    }
}
