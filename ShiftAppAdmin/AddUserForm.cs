using ShiftAppAdmin.APIClient;
using ShiftAppAdmin.Models;
using ShiftAppAdmin.TDG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftAppAdmin
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void createNewUserButton_Click(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;

            User user = new User
            {
                Secondname = newUserSecondNameTextBox.Text,
                Role = "basic_user",
                Firstname = newUserFirstNameTextBox.Text,
                Mail = newUserEmailTextBox.Text,
                PasswordHash = newUserPasswordTextBox.Text,
                IdSuperiorUser = settings.idUser,
            };
            new UserTDG().AddUserAsync(user);
            this.Hide();
        }
    }
}
