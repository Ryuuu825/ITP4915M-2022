using SDPTest.Controller;
using SDPTest.Views;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDPTest.Views
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
            var result = loginController.Login(username.Texts, password.Texts);
            if (result.Equals("ok"))
            {
                this.Dispose();
                var th = new Thread(() => Application.Run(new Main()));
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
    }
}
