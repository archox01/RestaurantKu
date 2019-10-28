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
    public partial class CashierNavigationForm : Form
    {
        public CashierNavigationForm()
        {
            InitializeComponent();
        }

        public string CashierName { get; set; }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            PaymentForm Payment = new PaymentForm();
            this.Show();
        }

        private void OrderFormButton_Click(object sender, EventArgs e)
        {
            OrderForm Order = new OrderForm();
            Order.Show();
        }

        private void CashierProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm Change = new ChangePasswordForm();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            RestaurantKuLoginForm Login = new RestaurantKuLoginForm();
            Login.Show();
        }

        private void CashierNavigationForm_Load(object sender, EventArgs e)
        {
            CashierNameLabelValue.Text = CashierName;
        }

    }
}
