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
    public partial class ManageMemberForm : Form
    {
        public ManageMemberForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            EmployeeRepository Repost = new EmployeeRepository();
            List<MemberInformation> GetData = Repost.MemberInfo().ToList();
            this.DataGridM.DataSource = GetData;

        }

        private void InsertMember()
        {
            
            string Name = MemberNameText.Text;
            string Email = MemberEmailText.Text;
            string Password = MemberPasswordText.Text;
            string JoinDates = JoinDateTime.Value.ToString();
            string CellNumber = CellNumberText.Text;
            string Address = AddressText.Text;
            EmployeeRepository Repost = new EmployeeRepository();
            List<MemberInformation> MemberInfo = Repost.MemberInfo().ToList();
            DateTime JoinMemberTime = JoinDateTime.Value;
            //DateTime.Parse(JoinDateTime.Value.ToString("dd/mm/yyyy"))
            var getMemberId = (from s in MemberInfo where s.MemberId >= 1 select s).Count();
            if(getMemberId >=1 )
            {
                using ( RestaurantkuContext Context = new RestaurantkuContext())
                {
                    var GetLastId = (from s in MemberInfo orderby s.MemberId descending select s).FirstOrDefault();
                    int MemberId = GetLastId.MemberId + 1;
                    Context.spMsMember_Action(MemberId, Name, MemberEmailText.Text, CellNumber, JoinMemberTime, Password, null, null, null, Address, null, "insert");
                    Context.SaveChanges();
                }
            }
            else {
                using (RestaurantkuContext Context = new RestaurantkuContext())
                {
                    int MemberId = 1;
                    Context.spMsMember_Action(MemberId,Name,MemberEmailText.Text,CellNumber,JoinMemberTime,Password,null,null,null,Address,null,"insert");
                }
            }
        }
        private void UpdateMember()
        {
            DateTime JoinMemberTime = JoinDateTime.Value;
            using (RestaurantkuContext Context = new RestaurantkuContext())
            {
                int Memberid = Convert.ToInt32(MemberIdTextBox.Text);
                Context.spMsMember_Action(
                    Convert.ToInt32( MemberIdTextBox.Text), 
                    Name,
                    MemberEmailText.Text, 
                    CellNumberText.Text, 
                    JoinMemberTime, 
                    MemberPasswordText.Text, 
                    null, null, null, 
                    AddressText.Text,
                    null, "insert");
                Context.SaveChanges();
            }

            MessageBox.Show("Data Berhasil Di Perbaharui");
            LoadData();
        }
        private void ManageMemberForm_Load(object sender, EventArgs e)
        {
            this.LoadData();
        
        }

        private void memberInformationBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DataGridM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var repost = new EmployeeRepository();
                List<MemberInformation> GetData = repost.MemberInfo().ToList();
                DataGridViewRow row = this.DataGridM.Rows[e.RowIndex];
                if (e.RowIndex > 0)
                {
                    MemberIdTextBox.Text = row.Cells["ColId"].Value.ToString();
                    MemberNameText.Text = row.Cells["ColName"].Value.ToString();
                    MemberEmailText.Text = row.Cells["ColEmail"].Value.ToString();
                    MemberPasswordText.Text = row.Cells["ColPassword"].Value.ToString();
                    JoinDateTime.Text = row.Cells["ColDate"].Value.ToString();
                    CellNumberText.Text = row.Cells["ColNumber"].Value.ToString();
                    AddressText.Text = row.Cells["ColAdd"].Value.ToString();
                }
            }
            catch { }
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            UpdateMember();
        }

        private void JoinDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeleteMember()
        {
            using(RestaurantkuContext Context = new RestaurantkuContext())
            {
                Context.spMsMember_Action(Convert.ToInt32(MemberIdTextBox.Text),null, null, null, null, null, null, null, null, null, null, "delete");
                Context.SaveChanges();

            }
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            
        }

        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            InsertMember();
            MessageBox.Show("Data Berhasil Di Masukkan");
        }

        private void DataGridM_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var repost = new EmployeeRepository();
                List<MemberInformation> GetData = repost.MemberInfo().ToList();
                DataGridViewRow row = this.DataGridM.Rows[e.RowIndex];
                foreach (DataGridViewColumn col in this.DataGridM.Columns)
                {
                    if (e.RowIndex > 0)
                    {
                        string DateGet = row.Cells["ColJoin"].Value.ToString();
                        MemberIdTextBox.Text = row.Cells["ColId"].Value.ToString();
                        MemberNameText.Text = row.Cells["ColName"].Value.ToString();
                        MemberEmailText.Text = row.Cells["ColEmail"].Value.ToString();
                        MemberPasswordText.Text = row.Cells["ColPassword"].Value.ToString();
                        JoinDateTime.Text = row.Cells["ColJoin"].Value.ToString();
                        CellNumberText.Text = row.Cells["ColHP"].Value.ToString();
                        AddressText.Text = row.Cells["ColAddress"].Value.ToString();

                    }
                }
            }
            catch { }
            }
        }
    }

