using RestaurantKuUI.SupportThings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantKuUI
{
    public partial class ManageMenuForm : Form
    {
        public ManageMenuForm()
        {
            InitializeComponent();
        }
        string filename;
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
        private void LoadData()
        {
            EmployeeRepository Repost = new EmployeeRepository();
            List<MenuInformation> GetData = Repost.MenuInfo().ToList();
            DGMenu.DataSource = GetData;
        }
        private void ManageMenuForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void InsertData()
        {
            EmployeeRepository Repost = new EmployeeRepository();
            List<MenuInformation> MenuInfo = Repost.MenuInfo().ToList();
            var checkdata = (from s in MenuInfo where s.MenuId >= 1 select s).Count();
            byte[] fileb = imgtoarray(PictureBox.Image);
           
            if (checkdata >= 1)
            {
                using (RestaurantkuContext Context = new RestaurantkuContext())
                {
                    var GetLastId = (from s in MenuInfo orderby s.MenuId descending select s).FirstOrDefault();
                    int GetMenuId = GetLastId.MenuId + 1;
                    Context.spMsMenu_Action(GetMenuId, NamaText.Text, Convert.ToInt32(HargaText.Text), fileb, PathText.Text, "insert");
                }
            }
            else
            {
                using(RestaurantkuContext Context = new RestaurantkuContext())
                {
                    int Menuid = 1;
                    Context.spMsMenu_Action(Menuid, NamaText.Text,Convert.ToInt32(HargaText.Text), fileb, PathText.Text, "insert");
                }
            }
            MessageBox.Show("Data Berhasil di Input");
        }
       
        private void BrowsePic()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = " Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                filename = opf.FileName;
                PictureBox.Image = Image.FromFile(filename);
                PathText.Text = filename;
            }
        }
        private void BrowsePicButton_Click(object sender, EventArgs e)
        {
            BrowsePic();
        }

        private void DGMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = new DataGridViewRow();
            MenuIdText.Text = DGMenu.SelectedCells[0].Value.ToString();
            NamaText.Text = DGMenu.SelectedCells[1].Value.ToString();
            HargaText.Text = DGMenu.SelectedCells[2].Value.ToString();
            PathText.Text = DGMenu.SelectedCells[4].Value.ToString();
            int Menuids = Convert.ToInt32(MenuIdText.Text);
            EmployeeRepository Repost = new EmployeeRepository();
            List<MenuInformation> MenuInfo = Repost.MenuInfo().ToList();
            var GetPict = (from s in MenuInfo where s.MenuId == Menuids select s).First();

            PictureBox.Image = arraytoimg(GetPict.photo.ToArray());


        }

        private void InsertMenuButton_Click(object sender, EventArgs e)
        {
            InsertData();
        }
    }
}
