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
    public partial class ManageEmployeeForm : Form
    {
        public ManageEmployeeForm()
        {
            InitializeComponent();
        }

        private void InsertChefData()
        {
            EmployeeRepository empRepost = new EmployeeRepository();
            EmployeeInformation EMInformation = new EmployeeInformation();
            var employeeInformation = empRepost.GetEmpData().ToList();
            List<EmployeeInformation> GetEmpData = empRepost.GetEmpData();
            var getDataifNull = (from s in GetEmpData select s);
            if (getDataifNull == null)
            {
                int ChefId = 0 + 1;
                string GetChefId = "CH0" + ChefId++;

                EmployeeInformation Information = new EmployeeInformation
                    (GetChefId,
                    EmployeeNameTextBox.Text,
                    EmployeeEmailTextBox.Text,
                    EmployeePasswordTextBox.Text,
                    EmployeeHandphoneTextBox.Text,
                    EmployeePositionValue.Text);

            }
            else
            {
                using (RestaurantkuContext Context = new RestaurantkuContext())
                {
                    var getData = (from s in GetEmpData where s.EmployeePosition == "chef" orderby s.EmployeeId descending select s).FirstOrDefault();
                    var GetEmployeeId = getData.EmployeeId;
                    string GetIdFromContext = getData.EmployeeId;
                    string SubstringGetId = GetIdFromContext.Substring(2, 2); // Substring dari index 2 untuk 2 kekanan
                    int ConvertSubstring = Convert.ToInt32(SubstringGetId);
                    int AutoIncId = ConvertSubstring++; //AutoIncId = Auto Increment Untuk Id nya
                    string ConvertString = ConvertSubstring.ToString();
                    string FinalId = "CH0" + ConvertString; //Id ynag sudah di auto incrementkan atau Id Jadinya


                    string EmployeeId = FinalId;
                    string EmployeeName = EmployeeNameTextBox.Text;
                    string EmployeeEmail = EmployeeEmailTextBox.Text;
                    string EmployeePassword = EmployeePasswordTextBox.Text;
                    string EmployeeHP = EmployeeHandphoneTextBox.Text;
                    string EmployeePosition = EmployeePositionValue.Text;

                    Context.spMsEmployee_Action(EmployeeId, EmployeeName, EmployeeEmail, EmployeePassword, EmployeeHP, EmployeePosition, "insert");

                }
            }
        }

        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            if(EmployeePositionValue.Text == "chef")
            {
                InsertChefData();
                MessageBox.Show("Data Berhasil Di Input");
                
            }
          
            
            EmployeeNameTextBox.Text = "";
            EmployeeEmailTextBox.Text = "";
            EmployeePasswordTextBox.Text = "";
            EmployeeHandphoneTextBox.Text = "";
            EmployeePositionValue.SelectedText = "";
            
        }

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            EmployeeRepository empRepost = new EmployeeRepository();
            List<EmployeeInformation> GetEmpData = empRepost.GetEmpData();
            EmpDataGrid.DataSource = GetEmpData;
           
        }
    }
}
