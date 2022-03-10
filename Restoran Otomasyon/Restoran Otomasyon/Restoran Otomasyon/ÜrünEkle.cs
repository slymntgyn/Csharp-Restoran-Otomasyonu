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
using excel;
namespace Restoran_Otomasyon
{
    public partial class ÜrünEkle : Form
    {
        public ÜrünEkle()
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ÜrünEkle_Load(object sender, EventArgs e)
        {
            this.Refresh();
            grup();
        }

        private void GEkleButon_Click(object sender, EventArgs e)
        {
            GrupEkle ge = new GrupEkle();
            ge.Show();
            this.Hide();
        }

        private void WiewButon_Click(object sender, EventArgs e)
        {
            UrunGoster ug = new UrunGoster();
            ug.Show();
            this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ÜekleButon_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (Ürünadi.Text != "" && fiyatTextBox.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "Insert into ürün ( Adi,Fiyati,UrunGrupNo,ResimYolu) Values( @adi, @fiyati,@ugno,@resimy)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@adi", Ürünadi.Text);
                    komut.Parameters.AddWithValue("@fiyati", fiyatTextBox.Text);
                    komut.Parameters.AddWithValue("@ugno", ProductGroupComboBox.SelectedValue);
                    komut.Parameters.AddWithValue("@resimy", dosy);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ürün başarılı bir şekilde eklenmiştir.");
                    baglanti.Close();
                    
                }
                catch (Exception )
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
        public string dosy;
        private void İmageAddButon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            dosy = dosyayolu;
            pictureBox2.ImageLocation = dosyayolu;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Masa ms = new Masa();
            ms.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            Class1.aktar(Ürünadi.Text, fiyatTextBox.Text, ProductGroupComboBox.Text, dosy);
        }
    }
}
