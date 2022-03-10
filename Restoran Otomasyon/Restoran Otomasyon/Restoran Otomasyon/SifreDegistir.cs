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
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }
        SQlBaglanti bgl = new SQlBaglanti();
        private void SifreDegistir_Load(object sender, EventArgs e)
        {

        }

        private void ChangeButon_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (EskiTextBox.Text != "" && SifreTextBox.Text != "" && tekrar.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE personel Set Sifre=@sifre where tc=@did";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@did", PersonelGirisi.kulAdi);
                    
                    komut.Parameters.AddWithValue("@sifre", SifreTextBox.Text);
                    if (PersonelGirisi.sifre == EskiTextBox.Text)
                    {
                        if (SifreTextBox.Text == tekrar.Text)
                        {
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Admin başarı ile Güncellenmiştir.");

                            baglanti.Close();
                            SifreTextBox.Clear();
                            tekrar.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen şifreleri aynı giriniz", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eski şifrenizi yanlış girdiniz", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButon_Click(object sender, EventArgs e)
        {
            Masa ms = new Masa();
            ms.Show();
            this.Hide();
        }
    }
}
