using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantKuUI.SupportThings;

namespace RestaurantKuUI
{
    public partial class RestaurantKuLoginForm : Form
    {
        public RestaurantKuLoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using(RestaurantkuContext Context = new RestaurantkuContext())
            {
                EmployeeRepository Repost = new EmployeeRepository();
                List<EmployeeInformation> EmpInformation = Repost.GetEmpData();
                try { 
                var GetEmp = (from a in EmpInformation where a.EmployeeEmail == EmailTextBoxValue.Text select a).First();
                string Name = GetEmp.EmployeeName;
                string EmailText = EmailTextBoxValue.Text;
                string PasswordText = PasswordTextBoxValue.Text;
                string EmpEmail = GetEmp.EmployeeEmail;
                string EmpPassword = GetEmp.EmployeePassword;

                if (EmpEmail == EmailText )
                {
                    // Membuat Huruf pertama Menjadi Kapital
                    Name = Name[0].ToString().ToUpper() + Name.Substring(1, Name.Length - 1); 
                    var verif = (from a in EmpInformation where a.EmployeeEmail == EmailText select a).First();
                    string EmpPost = verif.EmployeePosition;
                    if (EmpPost == "cashier" && EmpPassword == PasswordText)
                    {
                        CashierNavigationForm Cashier = new CashierNavigationForm();
                        Cashier.CashierName = Name;
                        Cashier.Show();
                        this.Hide();
                    }
                    if(EmpPost == "admin" && EmpPassword == PasswordText)
                    {
                        AdminNavigationForm Admin = new AdminNavigationForm();
                        Admin.AdminName = Name;
                        Admin.Show();
                        this.Hide();
                    }
                    if(EmpPost == "chef" && EmpPassword == PasswordText)
                    {
                        ChefNavigationForm chef = new ChefNavigationForm();
                        chef.ChefName = Name;
                        chef.Show();
                        this.Hide();
                    }
                    MessageBox.Show("Login Berhasil");
                }
                else
                {
                    MessageBox.Show("Periksa Kembali Email atau Password anda ");
                }
                }
                catch(Exception a) { MessageBox.Show("Data Salah, Mohon Periksa Kembali"); }

            }
        }
    }
}
