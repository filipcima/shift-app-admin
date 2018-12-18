using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refit;
using RestSharp;
using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Models;
using ShiftAppAdmin.Properties;
using ShiftAppAdmin.TDG;

namespace ShiftAppAdmin
{
    public partial class LoginForm : Form
    {
        private Settings settings;

        public LoginForm()
        {
            InitializeComponent();
            settings = Properties.Settings.Default;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            AttemptLoginAsync(email, password);
        }
        /*
        private void AttemptLogin(string email, string password)
        {
            var client = RestSharpClient.Client;
            var request = new RestRequest($"people/{email}", Method.GET);
            var result = client.Execute<User>(request).Data;

            User user = result;
            
            if (user.PasswordHash == password)
            {
                administraceLabel.Text = "matches";
                settings.idUser = user.Id;
                Application.Run(new DashboardForm());
            }
            else
            {
                administraceLabel.Text = "fail";
            }
        }
        */

        private async Task AttemptLoginAsync(string email, string password)
        {
            var client = RefitClient.Service;
            var user = await new UserTDG().GetUserByIdAsync(email);
            
            if (user.PasswordHash == password)
            {
                administraceLabel.Text = "matches";
                settings.idUser = user.Id;
                settings.nameUser = $"{user.Firstname} {user.Secondname}";
                Form dashboardForm = new DashboardForm();
                this.Hide();
                dashboardForm.ShowDialog();
                this.Close();
            }
            else
            {
                administraceLabel.Text = "fail";
            }
        }
    }
}
