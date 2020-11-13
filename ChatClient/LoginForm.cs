using ChatClient.Utils;
using ChatCommonLib.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var user = ApiRestUtils.Auth(LoginInput.Text, PasswordInput.Text);

            if (user != null)
            {
                OpenMainForm(user);
            }
        }

        private void OpenMainForm(User user)
        {
            MainForm mainForm = new MainForm(user);
            mainForm.Show();
            this.Hide();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
