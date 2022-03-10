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
    public partial class GrupEkle : Form
    {
        public GrupEkle()
        {
            InitializeComponent();
        }
        SQlBaglanti bgl = new SQlBaglanti();
        void grup()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            /* ComboBoxları*/
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from UrunGrubu", baglanti);
            da.Fill(dt);
            ProductGroupComboBox.ValueMember = "UrunGrubu";
            ProductGroupComboBox.DisplayMember = "Adi";
            ProductGroupComboBox.DataSource = dt;

            baglanti.Close();
        }
        private void GrupEkle_Load(object sender, EventArgs e)
        {
            grup();
        }

        private void GEkleButon_Click(object sender, EventArgs e)
        {
            this.Refresh();
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            
            if (GrupAdi.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "Insert into UrunGrubu (Adi) Values( @adi)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@adi", GrupAdi.Text);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni admin başarı ile eklenmiştir.");
                    grup();
                    
                    baglanti.Close();
                    GrupAdi.Clear();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir hata gerçekleşti lütfen tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Boş giriş yapılmaz");
            }
        }

        private void UpdateButon_Click(object sender, EventArgs e)
        {
            this.Refresh();
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (GroupNameTextBox.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE UrunGrubu Set Adi=@adi where UrunGrubu=@urungrubu";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@UrunGrubu", ProductGroupComboBox.SelectedValue);
                    komut.Parameters.AddWithValue("@adi", GroupNameTextBox.Text);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Grup başarı ile Güncellenmiştir.");
                    

                    baglanti.Close();
                    grup();
                    GroupNameTextBox.Clear();


                }
                catch (Exception)
                {

                    MessageBox.Show("Bir hata gerçekleşti lütfen tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Boş giriş yapılmaz");
                baglanti.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ÜrünEkle üe = new ÜrünEkle();
            üe.Show();
            this.Hide();
        }
    }
}

