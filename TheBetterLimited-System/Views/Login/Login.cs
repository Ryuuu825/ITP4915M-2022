using TheBetterLimited.Controller;
using TheBetterLimited.Views;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBetterLimited.CustomizeControl;

namespace TheBetterLimited.Views
{
    public partial class Login : Form
    {
        private LoginController loginController = new LoginController();
        public Login()
        {
            InitializeComponent();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            username.Focus();
        }
        private void passwordLabel_Click(object sender, EventArgs e)
        {
            password.Focus();
        }

        [STAThread]
        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoadMain();
        }

        private void LoadMain()
        {
            int i = 1;
            foreach (Control ctl in loginContainer.Controls)
            {

                if (ctl is CustomizeTextbox)
                {
                    if (((CustomizeTextbox)ctl).Texts.Length == 0)
                    {
                        var lable = loginContainer.Controls[i - 1].Text;
                        var str = "Sorry! \nPlease enter " + lable + ".";
                        MessageBox.Show(str, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ctl.Focus();
                        return;
                    };
                    i += 2;
                }
            }

            /**
             * Request login
             */
            var result = loginController.Login(username.Texts, password.Texts);
            if (result.Equals("ok"))
            {
                this.Dispose();
                Main main = new Main();
                main.TopLevel = true;
                var th = new Thread(() => Application.Run(main));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else if (result != null)
            {
                var str = result;
                MessageBox.Show(str, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgotPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ResetPwd resetPwd = new ResetPwd();
            resetPwd.ShowDialog();
        }

        private void ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChangePwd changePwd = new ChangePwd();
            changePwd.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadMain();
            }
        }

        private void showPwd_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar)
            {
                showPwd.BackgroundImage = Properties.Resources.eye_crossed;
            }
            else
            {
                showPwd.BackgroundImage = Properties.Resources.eye;
            }
            password.PasswordChar = password.PasswordChar == true ? false : true;
        }
    }
}
