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
using System.IO;

namespace RestaurantKuUI
{
    public partial class OrderForm : Form
    {
        string MenuId, Price, Urut;
        DataTable DTable = new DataTable();
        RestaurantkuContext Context = new RestaurantkuContext();
        public OrderForm()
        {
            InitializeComponent();
            DataDG2();
        }
        private void TotalHarga()
        {
            int sumTotal = 0;
          for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sumTotal += Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value);
            }
            TotalHargaLabel.Text = sumTotal.ToString();
        }
        private void loaddata()
        {
            EmployeeRepository repost = new EmployeeRepository();
            List<MenuInformation> Info = repost.MenuInfo().ToList();
            this.MakananDataGrid.DataSource = Info;
        }
        public Image arraytoimg(byte[] bytearrayin)
        {
            MemoryStream ms = new MemoryStream(bytearrayin);
            Image img = Image.FromStream(ms);
            return img;
        }
        public byte[] imgtoarray(System.Drawing.Image imagein)
        {
            MemoryStream ms = new MemoryStream();
            imagein.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        private void CariButton_Click(object sender, EventArgs e)
        {

        }

        #region Tambah Data
        private void Addclick()
        {

            if (MenuMakananTextBox.Text =="" || HargaMakananTextBox.Text == "" || QtyMakananTextBox.Text == "" )
            {
                MessageBox.Show("Pilihlah Data yang akan di Order");
            }
            else
            {
                int Total = Convert.ToInt32(HargaMakananTextBox.Text) * Convert.ToInt32(QtyMakananTextBox.Text);
                DTable.Rows.Add(MenuId,MenuMakananTextBox.Text, QtyMakananTextBox.Text, Price, Total);
                this.dataGridView2.DataSource = DTable;
            }
            TotalHarga();
            Bersih();
        }
        #endregion

        private void OrderForm_Load(object sender, EventArgs e)
        {
            loaddata();
        }

    private void DeleteDG()
        {
            if (dataGridView2.Rows.Count > 1)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                dataGridView2.DataSource = DTable;
            }
            TotalHarga();
        }
        private void Bersih()
        {
            HargaMakananTextBox.Text = "";
            MenuMakananTextBox.Text = "";
            QtyMakananTextBox.Text = "";
        }
        private void AutoId()
        {
            using (RestaurantkuContext Context = new RestaurantkuContext())
            {
                string Getdate;
                EmployeeRepository repost = new EmployeeRepository();
                List<HeaderOrderInformation> Info = repost.HeaderInfo().ToList();
                var CheckData = (from s in Info where s.orderid >= 1 select s).Count();
                Info = Info.OrderByDescending(x => x.orderid).ToList();
                if(CheckData >= 1)
                {
                    
                        var GetMaxid = Convert.ToInt64(Info.Max(s => s.orderid).ToString()) + 1;
                        string autostr = "0000" + GetMaxid;
                        Urut = DateTime.Now.ToString("yyyyMMdd") + autostr;
                    
                }
                else
                {
                    Urut = DateTime.Now.ToString("yyyyMMdd") + "0001";
                }

            }
        }
        private void SaveHeader()
        {
            EmployeeRepository Repost = new EmployeeRepository();
            List<HeaderOrderInformation> HoInfo = Repost.HeaderInfo().ToList();

            using(RestaurantkuContext Context = new RestaurantkuContext())
            {
                ////Context.spMsHeadOrder_Action(Urut,RestaurantKuLoginForm.getid,)
            }
        }
    
        private void AddDataButton_Click(object sender, EventArgs e)
        {
            Addclick();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteDG();
        }

        private void PaymentProcessButton_Click(object sender, EventArgs e)
        {
            AutoId();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MakananDataGrid.DataSource = Context.msmenus.Where(x => x.name.Contains(textBox1.Text)).ToList();
                MakananDataGrid_CellContentClick(MakananDataGrid, new DataGridViewCellEventArgs(MakananDataGrid.CurrentCell.ColumnIndex, MakananDataGrid.CurrentRow.Index));
            }
            catch { }

        }

        private void MakananDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = this.MakananDataGrid.Rows[e.RowIndex];
            MenuId = Row.Cells["ColMId"].Value.ToString();
            MenuMakananTextBox.Text = Row.Cells["ColName"].Value.ToString();
            Price = Row.Cells["ColPrice"].Value.ToString();
            HargaMakananTextBox.Text = Row.Cells["ColPrice"].Value.ToString();
            EmployeeRepository repost = new EmployeeRepository();
            List<MenuInformation> Info = repost.MenuInfo().ToList();
            var GetPhoto = (from s in Info where s.MenuId == Convert.ToInt32(MenuId) select s).First();
            MakananPB.Image = arraytoimg(GetPhoto.photo.ToArray());

        }
        private void DataDG2()
        {
            DTable.Columns.Add("Id");
            DTable.Columns.Add("Menu");
            DTable.Columns.Add("Qty");
            DTable.Columns.Add("Price");
            DTable.Columns.Add("Total");
            dataGridView2.DataSource = DTable;

        }
    }
}
