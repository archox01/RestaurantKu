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
namespace RestaurantKuUI.WindowsForm

{
    public partial class DialogPembeli : Form
    {
       
        public DialogPembeli()
        {
            InitializeComponent();
        }
        RestaurantkuContext Context = new RestaurantkuContext();
        DataTable DTable = new DataTable();
        public static string id_member;
        public  string getid()
        {
            return id_member;
        }
        private void DataTable()
        {
            DTable.Columns.Add("Id");
            DTable.Columns.Add("Menu");
            DTable.Columns.Add("Qty");
            DTable.Columns.Add("Price");
            DTable.Columns.Add("Total");
            dataGridView1.DataSource = DTable;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            EmployeeRepository Repost = new EmployeeRepository();
            List<MemberInformation> Info = Repost.MemberInfo().ToList();
            var query = (from s in Info select s);
            
        }



        private void TB_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Context.msmembers.Where(x => x.name.Contains(TB.Text) || x.email.Contains(TB.Text)).ToList(); 
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewrow = dataGridView1.SelectedRows[0];
            id_member = viewrow.Cells[0].ToString();
            this.Close();
        }

        private void DialogPembeli_Load(object sender, EventArgs e)
        {
            EmployeeRepository Repost = new EmployeeRepository();
            List<MemberInformation> Info = Repost.MemberInfo();
            var GetData = (from s in Info select s).ToList();
            dataGridView1.DataSource = GetData;
        }
    }
   
}
;