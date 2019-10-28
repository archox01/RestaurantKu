using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantKuUI
{
    public partial class AdminNavigationForm : Form
    {
        public string AdminName { get; set; }
        public AdminNavigationForm()
        {
            InitializeComponent();
        }

        private void WelcomeAdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdminNameLabelValue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            RestaurantKuLoginForm Login = new RestaurantKuLoginForm();
            Login.Show();
            this.Hide();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm Change = new ChangePasswordForm();
            Change.Show();
        }

        private void AdminProfileButton_Click(object sender, EventArgs e)
        {

        }
        private void AdminNavigationForm_Load(object sender, EventArgs e)
        {
            AdminNameLabelValue.Text = AdminName;
        }

        private void ManageEmployeeButton_Click(object sender, EventArgs e)
        {
            ManageEmployeeForm ManageEmp = new ManageEmployeeForm();
            ManageEmp.Show();
        }

        private void ManageMenuButton_Click(object sender, EventArgs e)
        {
            ManageMenuForm Menu = new ManageMenuForm();
            Menu.Show();
        }

        private void ManageMemberButton_Click(object sender, EventArgs e)
        {
            ManageMemberForm Member = new ManageMemberForm();
            Member.Show();
        }

    }
}
