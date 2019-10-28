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

        private void LoadDataGrid()
        {
            EmployeeRepository empRepost = new EmployeeRepository();
            List<EmployeeInformation> GetEmpData = empRepost.GetEmpData().ToList();
            EmpDataGrid.AutoGenerateColumns = false;
            EmpDataGrid.DataSource = GetEmpData;
        }
        #region Inserting Chef Data
        private void InsertChefData()
        {
            string EmployeeName = EmployeeNameTextBox.Text;
            string EmployeeEmail = EmployeeEmailTextBox.Text.ToLower();
            string EmployeePassword = EmployeePasswordTextBox.Text;
            string EmployeeHandphone = EmployeeHandphoneTextBox.Text;
            string EmployeePosition = EmployeePositionValue.Text.ToLower();
            EmployeeRepository empRepost = new EmployeeRepository();
            List<EmployeeInformation> GetEmpData = empRepost.GetEmpData();
            var getDataifNull = (from s in GetEmpData where s.EmployeePosition == "chef" select s).Count();
            #region Create Chef Data if chef data never created before
            if (getDataifNull == 0)
            {
                using (RestaurantkuContext context = new RestaurantkuContext())
                {
                    int ChefId = 0 + 1;
                    string GetChefId = "CH0" + ChefId++;

                    string EmployeeId = GetChefId;
                    context.spMsEmployee_Action(EmployeeId, EmployeeName, EmployeeEmail, EmployeePassword, EmployeeHandphone, EmployeePosition, "insert");
                    context.SaveChanges();
                }
            }
            #endregion
            #region Create chef data if chef data has been created before
            else
            {
                using (RestaurantkuContext Context = new RestaurantkuContext())
                {
                    var getData = (from s in GetEmpData where s.EmployeePosition == "chef" orderby s.EmployeeId descending select s).FirstOrDefault();
                    string GetIdFromContext = getData.EmployeeId;
                    string SubstringGetId = GetIdFromContext.Substring(2, 2); // Substring dari index 2 untuk 2 kekanan
                    int ConvertSubstring = Convert.ToInt32(SubstringGetId);
                    int AutoIncId = ConvertSubstring++; //AutoIncId = Auto Increment Untuk Id nya
                    string ConvertString = ConvertSubstring.ToString();
                    string FinalId = "CH0" + ConvertString; //Id ynag sudah di auto incrementkan atau Id Jadinya
                    string EmployeeId = FinalId; 

                    Context.spMsEmployee_Action(EmployeeId, EmployeeName, EmployeeEmail, EmployeePassword, EmployeeHandphone, EmployeePosition, "insert");
                    Context.SaveChanges();

                }
            }
            #endregion
        }
        #endregion

        #region Inserting Cashier Data
        private void InsertCashierData()
        {
            string EmployeeName = EmployeeNameTextBox.Text;
            string EmployeeEmail = EmployeeEmailTextBox.Text.ToLower();
            string EmployeePassword = EmployeePasswordTextBox.Text;
            string EmployeeHandphone = EmployeeHandphoneTextBox.Text;
            string EmployeePosition = EmployeePositionValue.Text.ToLower();
            EmployeeRepository EmpRepost = new EmployeeRepository();
            List<EmployeeInformation> EmployeeInformation = EmpRepost.GetEmpData();
            var CheckId = (from s in EmployeeInformation where s.EmployeePosition == "cashier" select s).Count();

            using (RestaurantkuContext Context = new RestaurantkuContext())
            {

                if (CheckId == 0)
                {

                    #region Inserting Cashier Id if Cashier Data never created before
                    int CashierId = 1;
                    string GetCashierId = "CA0" + CashierId;
                    Context.spMsEmployee_Action(
                        GetCashierId,
                       EmployeeName,
                       EmployeeEmail,
                       EmployeePassword,
                       EmployeeHandphone,
                       EmployeePosition,
                       "insert");

                    Context.SaveChanges();
                    #endregion
                }
                else
                {

                    #region Inserting Cashier Id if Cashier Data has been created Before
                    var GetData = (from s in EmployeeInformation where s.EmployeePosition == "cashier" orderby s.EmployeeId descending select s).First();
                    string GetId = GetData.EmployeeId;
                    string SubstringId = GetId.Substring(2, 2);
                    int ConvertId = Convert.ToInt32(SubstringId);
                    int aic = ConvertId++;
                    string ConvertToString = ConvertId.ToString();
                    string FinalId = "CA0" + ConvertToString;

                    Context.spMsEmployee_Action(FinalId,
                        EmployeeName,
                        EmployeeEmail,
                        EmployeePassword,
                        EmployeeHandphone,
                        EmployeePosition,
                        "insert");
                    Context.SaveChanges();
                    #endregion
                }
            }
        }
        #endregion

        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            string Name = EmployeeNameTextBox.Text;
            string Email = EmployeeEmailTextBox.Text;
            string Password = EmployeePasswordTextBox.Text;
            string HandPhone = EmployeeHandphoneTextBox.Text;

            if(Name.Length != 0 && Email.Length != 0 && Password.Length != 0 && HandPhone.Length != 0)
            {
                if (EmployeePositionValue.Text == "chef")
                {
                    InsertChefData();
                    MessageBox.Show("Data Berhasil Di Input");
                }
                else {
                    InsertCashierData();
                    MessageBox.Show("Data Berhasil Di Input");
                }

                    LoadDataGrid();
                    EmployeeNameTextBox.Text = "";
                    EmployeeEmailTextBox.Text = "";
                    EmployeePasswordTextBox.Text = "";
                    EmployeeHandphoneTextBox.Text = "";
                    EmployeePositionValue.SelectedText = "";
                
            }
            else
            {
                MessageBox.Show("Semua Data Wajib Di isi");
            }
        } 
                  

        private void EmpPostCmb()
        {
            #region combobox dictionary
            SortedDictionary<int, string> EmpPos = new SortedDictionary<int, string>()
            {
                {1,"cashier" },
                {2,"chef" }
            };
            EmployeePositionValue.DataSource = new BindingSource(EmpPos, null);
            EmployeePositionValue.DisplayMember = "Value";
            EmployeePositionValue.ValueMember = "Key";
            #endregion
        }

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            EmpPostCmb();
        }

        private void EmployeePasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(EmployeePasswordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Kata Sandi Harus Diisi");
                EmployeePasswordTextBox.Focus();
            }
            else
            {
                if(EmployeePasswordTextBox.Text.Length < 8)
                {
                    MessageBox.Show("Kata Sandi minimal 8 Digit");
                    EmployeePasswordTextBox.Focus();

                }
            }
        }

        private void EmployeeHandphoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char al = e.KeyChar;
            if(!Char.IsDigit(al) && al != 8 && al != 46)
            {
                e.Handled = true;
            }
            if (al == Convert.ToChar(1)) {
                TextBox txt = sender as TextBox;
                txt.SelectAll();
                e.Handled = true;
                    }
                       }

        private void EmployeeHandphoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(EmployeeHandphoneTextBox.Text.Length == 0)
            {
                MessageBox.Show("Nomor Handphone Wajib Diisi");
                EmployeeHandphoneTextBox.Focus();
            }
            else
            {
                if(EmployeeHandphoneTextBox.Text.Length > 14)
                {
                    MessageBox.Show("Nomor Handphone Tidak Boleh lebih dari 14 Digits");
                    EmployeeHandphoneTextBox.Focus();
                }
            }
        }

        private void EmployeeEmailTextBox_Validated(object sender, EventArgs e)
        {
            if(EmployeeEmailTextBox.Text.Length == 0)
            {
                MessageBox.Show("Email Wajib Di isi");
                EmployeeEmailTextBox.Focus();
            }
        }

        private void EmpDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                EmployeeRepository EmpRep = new EmployeeRepository();
                List<EmployeeInformation> Information = EmpRep.GetEmpData();
                DataGridViewRow Row = this.EmpDataGrid.Rows[e.RowIndex];
                EmployeeIdTextBox.Text = Row.Cells["ColId"].Value.ToString();
                EmployeeNameTextBox.Text = Row.Cells["ColName"].Value.ToString();
                EmployeeEmailTextBox.Text = Row.Cells["ColEmail"].Value.ToString();
                EmployeePasswordTextBox.Text = Row.Cells["ColPassword"].Value.ToString();
                EmployeeHandphoneTextBox.Text = Row.Cells["ColHP"].Value.ToString();
                EmployeePositionValue.Text = Row.Cells["ColPosition"].Value.ToString();

        }
        private void UpdateEmpData()
        {
            using (RestaurantkuContext Context = new RestaurantkuContext())
            {
                string EmployeeId = EmployeeIdTextBox.Text.Trim();
                string EmployeeName = EmployeeNameTextBox.Text;
                string EmployeeEmail = EmployeeEmailTextBox.Text.ToLower();
                string EmployeePassword = EmployeePasswordTextBox.Text;
                string EmployeeHandphone = EmployeeHandphoneTextBox.Text;
                string EmployeePosition = EmployeePositionValue.Text.ToLower();

                Context.spMsEmployee_Action(EmployeeId, EmployeeName, EmployeeEmail, EmployeePassword, EmployeeHandphone, EmployeePosition, "update");
                Context.SaveChanges();
            }
            
        }

        private void CariEmployee()
        {
            EmployeeRepository EmpRep = new EmployeeRepository();
            List<EmployeeInformation> GetRepost = EmpRep.GetEmpData().ToList();

            var GetData = (from s in GetRepost where s.EmployeeId == EmployeeIdTextBox.Text select s).First();
            EmployeeEmailTextBox.Text = GetData.EmployeeEmail;
            EmployeeNameTextBox.Text = GetData.EmployeeName;
            EmployeePasswordTextBox.Text = GetData.EmployeePassword;
            EmployeePositionValue.Text = GetData.EmployeePosition;
            EmployeeHandphoneTextBox.Text = GetData.EmployeeeHandPhone;

            MessageBox.Show("Data Berhasil Di Perbaharui");
          

        }

        private void CariDataButton_Click(object sender, EventArgs e)
        {
            CariEmployee();
            
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            using(RestaurantkuContext Context = new RestaurantkuContext())
            {
                Context.spMsEmployee_Action(EmployeeIdTextBox.Text, null, null, null, null, null, "delete");
            }
            MessageBox.Show("Data sukses Di Hapus");
            LoadDataGrid();
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            UpdateEmpData();
            LoadDataGrid();
            MessageBox.Show("Data Berhasil Di Perbaharui");
        }

        private void EmpDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeRepository EmpRep = new EmployeeRepository();
            List<EmployeeInformation> Information = EmpRep.GetEmpData();
            DataGridViewRow Row = this.EmpDataGrid.Rows[e.RowIndex];
            EmployeeIdTextBox.Text = Row.Cells["ColId"].Value.ToString();
            EmployeeNameTextBox.Text = Row.Cells["ColName"].Value.ToString();
            EmployeeEmailTextBox.Text = Row.Cells["ColEmail"].Value.ToString();
            EmployeePasswordTextBox.Text = Row.Cells["ColPassword"].Value.ToString();
            EmployeeHandphoneTextBox.Text = Row.Cells["ColNumber"].Value.ToString();
            EmployeePositionValue.Text = Row.Cells["ColPosition"].Value.ToString();
        }
    }
        }
    

