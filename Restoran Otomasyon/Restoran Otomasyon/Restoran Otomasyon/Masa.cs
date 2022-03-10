using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Restoran_Otomasyon
{
    public partial class Masa : Form
    {
        public Masa()
        {
            InitializeComponent();
        }
        SQlBaglanti bgl = new SQlBaglanti();
        public static int MasaNumarasi;
        public static int masaSayisi;
        
        int doluMasaSayisi = 0;
        public static Masa anaFrm;
        public int masaNo;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                masaNo = Convert.ToInt32(listView1.SelectedItems[0].Text.Substring(0, listView1.SelectedItems[0].Text.IndexOf('.')));

            }
        }

        private void ürünleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunGoster ug = new UrunGoster();
            ug.Show();
            this.Hide();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünEkle üe = new ÜrünEkle();
            üe.Show();
            this.Hide();
        }

        private void şifreyiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDegistir sd = new SifreDegistir();
            sd.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void Masa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Siparis sp = new Siparis();
            sp.Show();
            this.Hide();
        }

        private void Masa_Load_1(object sender, EventArgs e)
        {
            anaFrm = this;

            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter ürün = new SqlDataAdapter("select * from masa", baglanti);
            ürün.Fill(dt1);
            DataTable dt2 = new DataTable();
            SqlDataAdapter masa = new SqlDataAdapter("select MasaSayisi from masa", baglanti);
            masa.Fill(dt2);
            for (int i = 0; i < int.Parse(dt2.Rows[0]["MasaSayisi"].ToString()); i++)
            {


                if (Kontroller.veriVarmi("select * from siparis where MasaNo=" + (i + 1) + " AND Hesap='True'"))
                {
                    Image myImage = Image.FromFile("DoluMasa.png");
                    ımageList1.Images.Add("DoluMasa.png", myImage);
                    // tell your ListView to use the new image list
                    listView1.LargeImageList = ımageList1;
                    // add an item
                    var listViewItem = listView1.Items.Add((i + 1) + ".Masa");
                    // and tell the item which image to use
                    listViewItem.ImageKey = "DoluMasa.png";
                    doluMasaSayisi++;
                    /*
                    listView1.Items.Add((i + 1) + ".Masa");
                    listView1.Items[i].ImageKey = "DoluMasa.png";
                    doluMasaSayisi++;*/
                }
                else
                {
                    Image myImage = Image.FromFile("BoşaMasa.png");
                    ımageList1.Images.Add("BoşaMasa.png", myImage);
                    // tell your ListView to use the new image list
                    listView1.LargeImageList = ımageList1;
                    // add an item
                    var listViewItem = listView1.Items.Add((i + 1) + ".Masa");
                    // and tell the item which image to use
                    listViewItem.ImageKey = "BoşaMasa.png";
                    /*
                    listView1.Items.Add((i + 1) + ".Masa");
                    listView1.Items[i].ImageKey ="BoşaMasa.png";
                    */
                }

            }
            masaSayisi = Convert.ToInt32(dt2.Rows[0]["MasaSayisi"].ToString());

        }
    
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MasaNumarasi = (int.Parse(listView1.SelectedIndices[0].ToString()) + 1);


                Siparis frmMasa = new Siparis();
                frmMasa.ShowDialog();
                
            }
            catch
            {

            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
