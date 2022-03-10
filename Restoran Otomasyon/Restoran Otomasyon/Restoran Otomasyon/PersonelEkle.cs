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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        SQlBaglanti bgl = new SQlBaglanti();
        SqlConnection con;

        private int _PersonelId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _Sifre;
        private string _TCNo;
        private bool _Durum;
        private int _tipi;

        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public string PersonelSifre { get => _Sifre; set => _Sifre = value; }
        public string PersonelTCNo { get => _TCNo; set => _TCNo = value; }
        public bool Durum { get => _Durum; set => _Durum = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        //public int Tipi { get => _tipi; set => _tipi = value; }
        private void text_temizle()
        {
            TCTextBox.Clear();
            SifreTextBox.Clear();
            AdiTextBox.Clear();
            SoyAdiTextBox.Clear();
        }
        void Ekle(string PersonelTCNo, string PersonelSifre, String PersonelAd, string PersonelSoyad)
        {
            int sonuc = 0;
            SqlConnection con1 = new SqlConnection(bgl.adres);
            con1.Open();
            //using (con = SqlConnection())
            // {
            try
            {
                string sql = "insert into personel (tc, Sifre, Adi, Soyadi) values(@TCNo,@sifre,@adi,@soyadi)";
                SqlCommand command = new SqlCommand(sql, con1);
                command.Parameters.AddWithValue("@TCNo", PersonelTCNo);
                command.Parameters.AddWithValue("@sifre", PersonelSifre);
                command.Parameters.AddWithValue("@adi", PersonelAd);
                command.Parameters.AddWithValue("@soyadi", PersonelSoyad);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con1.Close();
            }
            //Formlar.ye.Show();
        }

        void Sil(string PersonelTCNo)
        {
            int sonuc = 0;
            SqlConnection con1 = new SqlConnection(bgl.adres);
            

            try
            {
                con1.Open();
                string sql = "DELETE from personel where tc = @PersonelTCNo";
                SqlCommand command = new SqlCommand(sql, con1);
                command.Parameters.AddWithValue("@PersonelTCNo", PersonelTCNo);

                sonuc = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con1.Close();
            }
        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {

        }

        private void SatisButon_Click(object sender, EventArgs e)
        {
            SatislariGoruntule stg = new SatislariGoruntule();
            stg.Show();
            this.Hide();
        }

        private void EkleButon_Click(object sender, EventArgs e)
        {
            if (TCTextBox.Text == "" || SifreTextBox.Text == "" || AdiTextBox.Text == "" || SoyAdiTextBox.Text == "")
            {
                MessageBox.Show("Eksik Veri Girdiniz! ");
            }
            else
            {
                Ekle(TCTextBox.Text, SifreTextBox.Text, AdiTextBox.Text, SoyAdiTextBox.Text);
                MessageBox.Show("Personel eklendi");
                text_temizle();
                //Formlar.ye.Show();
            }
        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Sil(siltext.Text);
            MessageBox.Show("Personel Silindi");
            siltext.Clear();
        }
    }
}
