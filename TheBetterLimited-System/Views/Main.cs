using TheBetterLimited.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using TheBetterLimited.Views.Message;
using TheBetterLimited.Utils;
using System.Globalization;
using System.Resources;

namespace TheBetterLimited.Views
{
    public partial class Main : Form
    {
        private bool sidebarExpand = true;
        private bool subSidebarExpand = false;
        private Form activeForm = null;
        private UserController uc = new UserController();
        private string position = String.Empty;
        private MessageDelegate Delegate;
        private static ResourceManager rm;
        public Main()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            rm = new ResourceManager("Main", typeof(Main).Assembly);

            CultureInfo culture = CultureInfo.CreateSpecificCulture(MultiLanguage.DefaultLanguage);

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            InitializeComponent();
            Delegate = new MessageDelegate(() => { }, 5000, () => { }, testing);
            /*
             * TODO: maybe the thread is not the same so it become extreme lag
            Delegate.prompt.BalloonTipClicked += (s, args) =>
            {
                this.OpenMsgForm();
            };
            */
            this.FormClosing += (s, e) => { Delegate.Stop(); };
        }


        private void Main_Load(object sender, EventArgs e)
        {
            MultiLanguage.LoadLanguage(this, typeof(Main));
            dropMenu.Controls.Remove(enBtn);
            dropMenu.Controls.Remove(zhBtn);
            dropMenu.Hide();
            txtUsername.Text = GlobalsData.currentUser["displayName"];
            txtJobTitle.Text = GlobalsData.currentUser["position"];
            var reg = @"(?=[A-Z])";
            var longPosition = Regex.Split(GlobalsData.currentUser["position"].ToString(), reg);
            var value = "";
            foreach (var item in longPosition)
            {
                value = item;
            }
            position = value;
            Bitmap bitmap = uc.GetUserIcon();
            if (bitmap != null)
            {
                UserIcon.Image = bitmap;
            }
            else
            {
                UserIcon.Image = Properties.Resources.portrait_free_icon_font;
            }
            Menu_Init();
            openChildForm(new Home());
            change_MenuButton_style(HomeBtn);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //Set the Minimum and Maximum size of the sidebar
            if (sidebarExpand)
            {
                sidebar.Width -= 50;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 50;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void subSidebarTimer_Tick(object sender, EventArgs e)
        {
            //Set the Minimum and Maximum size of the subSidebar
            if (subSidebarExpand)
            {
                subSidebar.Width -= 50;
                if (subSidebar.Width <= subSidebar.MinimumSize.Width)
                {
                    subSidebarExpand = false;
                    subSidebarTimer.Stop();
                }
                for (int i = 0; i < subSidebar.Controls.Count; i++)
                {
                    subSidebar.Controls[i].Hide();
                }
            }
            else
            {
                subSidebar.Width += 50;
                if (subSidebar.Width >= 200)
                {
                    subSidebarExpand = true;
                    subSidebarTimer.Stop();
                }
            }
        }

        // Change the navigation button style
        private void change_MenuButton_style(object sender)
        {
            foreach (Control ctl in sidebar.Controls)
            {
                if (ctl.Controls[0].BackColor == Color.SeaGreen)
                {
                    ctl.Controls[0].BackColor = Color.Transparent;
                    break;
                }
            }
            Control btn = (Control)sender;
            btn.BackColor = Color.SeaGreen;
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
            subSidebarTimer.Start();
            GoodsContainer.Show();
            SupplierContainer.Show();
            PurchaseGoodsContainer.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
            openChildForm(new Home());
            if (subSidebarExpand)
            {
                subSidebarTimer.Start();
            }
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
            StockContainer.Show();
            var dept = GlobalsData.currentUser["department"];
            if (dept.Equals("Admin") || dept.Equals("Inventory") || dept.Equals("Purchase"))
            {
                RestockContainer.Show();
            }
            if (dept.Equals("Sales") && position.Equals("Manager"))
            {
                RestockContainer.Show();
            }
            if (dept.Equals("Admin") || dept.Equals("Sales") || dept.Equals("Inventory") || dept.Equals("Accounting"))
            {
                DefectItemContainer.Show();
            }
            subSidebarTimer.Start();
        }

        private void Workman_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
            /*AppointmentContainer.Show();
            subSidebarTimer.Start();*/
            openChildForm(new Appointment());
            if (subSidebarExpand)
            {
                subSidebarTimer.Start();
            }
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
            subSidebarTimer.Start();
        }
        private void Setting_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
            subSidebarTimer.Start();
        }

        private void User_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
            StaffContainer.Show();
            AccountContainer.Show();
            subSidebarTimer.Start();
        }
        private void POS_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            change_MenuButton_style(sender);
            openChildForm(new POS());
            if (subSidebarExpand)
            {
                subSidebarTimer.Start();
            }
        }

        private void Menu_Init()
        {
            for (int i = 2; i < sidebar.Controls.Count - 1; i++)
            {
                sidebar.Controls[i].Hide();
            }
            switch (GlobalsData.currentUser["department"])
            {
                case "Admin":
                    for (int i = 2; i < sidebar.Controls.Count - 1; i++)
                    {
                        sidebar.Controls[i].Show();
                    }
                    break;
                case "Sales":
                    POSContainer.Show();
                    InventoryContainer.Show();
                    break;
                case "Inventory":
                    InventoryContainer.Show();
                    WorkmanContainer.Show();
                    break;
                case "Purchase":
                    InventoryContainer.Show();
                    PurchaseContainer.Show();
                    break;
                case "Accounting":
                    AccountingContainer.Show();
                    InventoryContainer.Show();
                    PurchaseContainer.Show();
                    break;
                case "Technical":
                    WorkmanContainer.Show();
                    break;
            }
            switch (position)
            {
                case "Manager":
                    UserContainer.Show();
                    break;
            }
        }

        private void UserInformation_Click(object sender, EventArgs e)
        {
            dropMenu.Visible = dropMenu.Visible == true ? false : true;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Delegate.Stop();
            GlobalsData.currentUser.Clear();
            var th = new Thread(() => Application.Run(new Login()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openChildForm(Form child)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }
            activeForm = child;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.mainBox.Controls.Add(child);
            this.mainBox.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void GoodsBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Goods());
            subSidebarTimer.Start();
        }

        //Draw a circle icon
        private Image CutEllipse(Image img, Rectangle rec, Size size)
        {
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (TextureBrush br = new TextureBrush(img, System.Drawing.Drawing2D.WrapMode.Clamp, rec))
                {
                    br.ScaleTransform(bitmap.Width / (float)rec.Width, bitmap.Height / (float)rec.Height);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(br, new Rectangle(Point.Empty, size));
                }
            }
            return bitmap;
        }

        private void UserIcon_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(UserIcon.ClientRectangle);
            Region region = new Region(gp);
            UserIcon.Region = region;
            Pen pen = new Pen(Color.FromArgb(64, 64, 64), 1);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, gp);
            gp.Dispose();
            region.Dispose();
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
            subSidebarTimer.Start();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Stock());
            subSidebarTimer.Start();
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new POManagement());
            subSidebarTimer.Start();
        }

        private void restockRequestBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new RestockRequest());
            subSidebarTimer.Start();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff());
            subSidebarTimer.Start();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new UserManagement());
            subSidebarTimer.Start();
        }

        private void DefectItemBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new DefectiveItem());
            subSidebarTimer.Start();
        }

        private void MessageBtn_Click(object sender, EventArgs e)
        {
            dropMenu.Visible = dropMenu.Visible == true ? false : true;
            Message.Message msg = new Message.Message();
            msg.FormClosing += (s, ea) => this.Delegate.Start();
            msg.Show();
            this.Delegate.Stop();
        }

        private bool subBtnShowed = false;
        private void LangBtn_Click(object sender, EventArgs e)
        {
            if (!subBtnShowed)
            {
                dropMenu.Controls.Remove(SignOutBtn);
                dropMenu.Controls.Add(enBtn);
                dropMenu.Controls.Add(zhBtn);
                dropMenu.Controls.Add(SignOutBtn);
            }
            else
            {
                dropMenu.Controls.Remove(enBtn);
                dropMenu.Controls.Remove(zhBtn);
            }
            subBtnShowed = subBtnShowed == true ? false : true;
        }

        private void dropMenu_ControlRemoved(object sender, ControlEventArgs e)
        {
            dropMenu.Height = dropMenu.Controls.Count * 50;
        }

        private void dropMenu_ControlAdded(object sender, ControlEventArgs e)
        {
            dropMenu.Height = dropMenu.Controls.Count * 50;
        }

        private void LoadAll(Form form)
        {
            if (form.Name == "Main")
            {
                MultiLanguage.LoadLanguage(form, typeof(Main));
            }
            else if (form.Name == "Home")
            {
                MultiLanguage.LoadLanguage(form, typeof(Home));
            }
            else if (form.Name == "Staff")
            {
                MultiLanguage.LoadLanguage(form, typeof(Staff));
            }
            else if (form.Name == "Staff_Edit")
            {
                MultiLanguage.LoadLanguage(form, typeof(Staff_Edit));
            }
            else if (form.Name == "Staff_Add")
            {
                MultiLanguage.LoadLanguage(form, typeof(Staff_Add));
            }
            else if (form.Name == "Usermanagement_Edit")
            {
                MultiLanguage.LoadLanguage(form, typeof(Usermanagement_Edit));
            }
            else if (form.Name == "Usermanagement_Add")
            {
                MultiLanguage.LoadLanguage(form, typeof(Usermanagement_Add));
            }
            else if (form.Name == "UserManagement")
            {
                MultiLanguage.LoadLanguage(form, typeof(UserManagement));
            }
        }

        private void enBtn_Click(object sender, EventArgs e)
        {
            if(MultiLanguage.DefaultLanguage == "en-HK")
            {
                MessageBox.Show("Current system language is English, you don't need to change");
                return;
            }
            DialogResult result = MessageBox.Show("更换系统语言需要重新登入系统, \n请问是否进行更换?", "提醒", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MultiLanguage.SetDefaultLanguage("en-HK");
                this.Dispose();
                this.Delegate.Stop();
                GlobalsData.currentUser.Clear();
                var th = new Thread(() => Application.Run(new Login()));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void zhBtn_Click(object sender, EventArgs e)
        {
            if (MultiLanguage.DefaultLanguage == "zh-CN")
            {
                MessageBox.Show("当前系统语言为简体中文，\n你不需要进行更换。");
                return;
            }
            DialogResult result = MessageBox.Show("Change language will re-login the system, \nAre you sure to change the system language?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MultiLanguage.SetDefaultLanguage("zh-CN");
                this.Dispose();
                this.Delegate.Stop();
                GlobalsData.currentUser.Clear();
                var th = new Thread(() => Application.Run(new Login()));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
    }
}
