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
        public static string getid()
        {
            return id_member;
        }
 

        private void TB_TextChanged(object sender, EventArgs e)
        {
            EmployeeRepository Repost = new EmployeeRepository();
            List<MemberInformation> info = Repost.MemberInfo().ToList();
            //dataGridView1.DataSource = Context.msmembers.Where(x => x.name.Contains(TB.Text) || x.email.Contains(TB.Text)).ToList(); 
            dataGridView1.DataSource = info.Where(x => x.MemberName.Contains(TB.Text) || x.MemberEmail.Contains(TB.Text)).ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewrow = dataGridView1.SelectedRows[0];
            id_member = viewrow.Cells[0].ToString();
            this.Close();
        }

        private void LoadData()
        {
            EmployeeRepository Repost = new EmployeeRepository();
            List<MemberInformation> Info = Repost.MemberInfo();
            var GetData = (from s in Info select s).ToList();
            dataGridView1.DataSource = GetData;
        }
        private void DialogPembeli_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TB_Leave(object sender, EventArgs e)
        {
            if(TB.Text == "")
            {
                TB.Text = "Masukkan Email / Nama";
                TB.ForeColor = Color.Silver;
            }
          
        }

        private void TB_Enter(object sender, EventArgs e)
        {
            if(TB.Text == "Masukkan Email / Nama")
            {
                TB.Text = "";
                TB.ForeColor = Color.Black;
            }
           
        }
    }
   
}
;