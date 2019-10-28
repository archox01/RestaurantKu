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
    public partial class ChefNavigationForm : Form
    {
        public ChefNavigationForm()
        {
            InitializeComponent();
        }
        public string ChefName { get; set; }

        private void ChefNavigationForm_Load(object sender, EventArgs e)
        {
            ChefNameLabelValue.Text = ChefName;
        }

        private void ChefProfileButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ViewOrderFormButton_Click(object sender, EventArgs e)
        {
            ViewOrderForm View = new ViewOrderForm();
            View.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm Change = new ChangePasswordForm();
            Change.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            RestaurantKuLoginForm Login = new RestaurantKuLoginForm();
            this.Hide();
            Login.Show();
        }
    }
}
