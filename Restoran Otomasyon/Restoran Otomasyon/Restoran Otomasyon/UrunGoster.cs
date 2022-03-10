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
using System.IO;

namespace Restoran_Otomasyon
{
    public partial class UrunGoster : Form
    {
        public UrunGoster()
        {
            InitializeComponent();
        }
        SQlBaglanti bgl = new SQlBaglanti();
        private void listele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter ürün = new SqlDataAdapter("select * from ürün", baglanti);
            ürün.Fill(dt1);
            DataTable dt2 = new DataTable();
            SqlDataAdapter grup = new SqlDataAdapter("select * from UrunGrubu", baglanti);
            grup.Fill(dt2);

            for (int groupIndex = 0; groupIndex < dt2.Rows.Count; ++groupIndex)
            {
                //grubları listviewe ekliyor
                this.listView1.Groups.Add(dt2.Rows[groupIndex]["UrunGrubu"].ToString(), dt2.Rows[groupIndex]["Adi"].ToString());

                for (int urunIndex = 0; urunIndex < dt1.Rows.Count; ++urunIndex)
                {
                    if (dt1.Rows[urunIndex]["UrunGrupNo"].ToString() == dt2.Rows[groupIndex]["UrunGrubu"].ToString())
                    {



                        if (File.Exists(dt1.Rows[urunIndex]["ResimYolu"].ToString()))//resimyolunda resim var mı diye kontrol ediyoruz
                        {
                            Image myImage = Image.FromFile(dt1.Rows[urunIndex]["ResimYolu"].ToString());//resimi alıyoruz
                            ımageList1.Images.Add(dt1.Rows[urunIndex]["UrunNo"].ToString(), myImage);//resmi imageliste ekliyoruz
                            ListViewItem item = new ListViewItem(dt1.Rows[urunIndex]["Adi"].ToString() + "\n" + dt1.Rows[urunIndex]["Fiyati"].ToString() + " ₺",
                                dt1.Rows[urunIndex]["UrunNo"].ToString(), this.listView1.Groups[groupIndex]);//Ürünü,resmi,grubu bağlıyoruz
                            this.listView1.Items.Insert(0, item);//ürünü ekliyor
                            this.listView1.Groups[groupIndex].Items.Insert(0, item);//ürünü gruba ekliyor
                        }
                        else //resimyolunda resim yoksa imagekey yinede ürünNo dan oluşturulur. imagekeyden de ürün bilgilerini çekeceğiz.
                        {
                            ListViewItem item = new ListViewItem(dt1.Rows[urunIndex]["Adi"].ToString(), dt1.Rows[urunIndex]["UrunNo"].ToString(),
                            this.listView1.Groups[groupIndex]);//Ürünü,resmi,grubu bağlıyoruz
                            this.listView1.Items.Insert(0, item);//ürünü ekliyor
                            this.listView1.Groups[groupIndex].Items.Insert(0, item);//ürünü gruba ekliyor
                        }

                    }

                }
            }
            baglanti.Close();
        }
        private void UrunGoster_Load(object sender, EventArgs e)
        {
            //urunGoster();
            
            listele();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Masa ms = new Masa();
            ms.Show();
            this.Hide();
        }
    }
}
