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
    public partial class PersonelGirisi : Form
    {
        public PersonelGirisi()
        {
            InitializeComponent();
        }
        SQlBaglanti bgl = new SQlBaglanti();
        public static string kulAdi;
        public static string sifre;
        public static bool durum;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hakkında hk = new Hakkında();
            hk.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminGirisi ag = new AdminGirisi();
            ag.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu ekran zaten açık", "Uyarı");
        }

        private void PersonelGirisi_Load(object sender, EventArgs e)
        {

        }

        private void GirisButon_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (TCTextBox.Text != "" && SifreTextBox.Text != "")
            {
                try
                {

                    baglanti.Open();
                    string sql = "select * from personel where tc=@kadi and Sifre=@sifre";
                    SqlParameter prm1 = new SqlParameter("@kadi", TCTextBox.Text);
                    SqlParameter prm2 = new SqlParameter("@sifre", SifreTextBox.Text);

                    SqlCommand komut = new SqlCommand(sql, baglanti);
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        kulAdi = TCTextBox.Text;
                        sifre = SifreTextBox.Text;
                        Masa ms = new Masa();
                        ms.Show();

                        this.Hide(); // bu formu gizledik
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya Şifre hatalı lütfen tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız !!!", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
