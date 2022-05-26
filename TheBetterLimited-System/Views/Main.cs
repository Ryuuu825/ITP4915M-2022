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

namespace TheBetterLimited.Views
{
    public partial class Main : Form
    {
        private bool sidebarExpand = true;
        private bool subSidebarExpand;
        private Form activeForm = null;
        private UserController uc = new UserController();
        public Main()
        {
            InitializeComponent();
        }

        private void InitializeUserInfo()
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //Set the Minimum and Maximum size of the sidebar
            if (sidebarExpand)
            {
                sidebar.Width -= 50;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 50;
                if (sidebar.Width == sidebar.MaximumSize.Width)
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
                if (subSidebar.Width == subSidebar.MinimumSize.Width)
                {
                    subSidebarExpand = false;
                    subSidebarTimer.Stop();
                }
            }
            else
            {
                subSidebar.Width += 50;
                if (subSidebar.Width == subSidebar.MaximumSize.Width)
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
        }

        private void Home_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
            subSidebarTimer.Start();
        }

        private void Workman_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
            subSidebarTimer.Start();
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
            openChildForm(new UserManagement());
        }
        private void POS_Click(object sender, EventArgs e)
        {
            change_MenuButton_style(sender);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtUsername.Text = GlobalsData.currentUser["displayName"];
            txtJobTitle.Text = GlobalsData.currentUser["position"];
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(UserIcon.ClientRectangle);
            Region region = new Region(gp);
            UserIcon.Region = region;
            Bitmap bitmap = uc.InitUserIcon();
            if (bitmap == null)
            {
                UserIcon.Image = bitmap;
            }
            else
            {
                UserIcon.Image = Properties.Resources.portrait_free_icon_font;
            }
            gp.Dispose();
            region.Dispose();
            Menu_Init();
        }

        private void Menu_Init()
        {
            for (int i = 3; i < sidebar.Controls.Count - 1; i++)
            {
                sidebar.Controls[i].Hide();
            }
            switch (GlobalsData.currentUser["position"])
            {
                case "Admin":
                    for (int i = 3; i < sidebar.Controls.Count - 1; i++)
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
                    break;
            }
        }

        private void UserInformation_Click(object sender, EventArgs e)
        {
            user_droplist.Visible = user_droplist.Visible == true ? false : true;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            openChildForm(new InventoryManagement());
        }
    }
}
