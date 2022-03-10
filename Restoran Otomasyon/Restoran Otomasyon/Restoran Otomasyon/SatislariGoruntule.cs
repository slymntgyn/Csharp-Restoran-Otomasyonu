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
    public partial class SatislariGoruntule : Form
    {
        public SatislariGoruntule()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LogoPicture_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            YoneticiEkran ye = new YoneticiEkran();
            ye.Show();
            this.Hide();
        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SatislariGoruntule_Load(object sender, EventArgs e)
        {
            SQlBaglanti bgl = new SQlBaglanti();
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter ürün = new SqlDataAdapter("SELECT siparis.MasaNo AS[Masa Numarası], Hesap.Tarih, Hesap.tutar, Hesap.HesapNo, Hesap.SiparisNo FROM siparis INNER JOIN Hesap ON siparis.SiparisNo = Hesap.SiparisNo", baglanti);

            ürün.Fill(dt1);
            SatislarDataGrid.DataSource = dt1;

            SatislarDataGrid.Columns[3].Visible = false;
            SatislarDataGrid.Columns[4].Visible = false;
            baglanti.Close();


            /* DateTimeBaslangic.Format = DateTimePickerFormat.Custom;
            DateTimeBaslangic.CustomFormat = "yyyy-mm-dd";

            DateTimeBitis.Format = DateTimePickerFormat.Custom;
            DateTimeBitis.CustomFormat = "yyyy-mm-dd";
            */
            DateTimeBaslangic.Value = DateTime.Now;
            DateTimeBitis.Value = DateTime.Now;
            
        }

        private void SatislarDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DateTimeBaslangic_ValueChanged(object sender, EventArgs e)
        {
            
           if (MasaNoTextBox.Text == "")
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                baglanti.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter ürün = new SqlDataAdapter("SELECT siparis.MasaNo AS[Masa Numarası], Hesap.Tarih, Hesap.tutar, Hesap.HesapNo, Hesap.SiparisNo FROM siparis INNER JOIN Hesap ON siparis.SiparisNo = Hesap.SiparisNo where Tarih between @dt1 and @dt2", baglanti);
                ürün.SelectCommand.Parameters.Add("@dt1", SqlDbType.Date).Value = DateTimeBaslangic.Value;
                ürün.SelectCommand.Parameters.Add("@dt2", SqlDbType.Date).Value = DateTimeBitis.Value;
                ürün.Fill(dt1);
                
                SatislarDataGrid.DataSource = dt1;
                baglanti.Close();
            }
            else
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                baglanti.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter ürün = new SqlDataAdapter("SELECT siparis.MasaNo AS masano, Hesap.Tarih, Hesap.tutar, Hesap.HesapNo, Hesap.SiparisNo FROM siparis INNER JOIN Hesap ON siparis.SiparisNo = Hesap.SiparisNo where masano = @masano and Tarih between @dt1 and @dt2 ", baglanti);
                ürün.SelectCommand.Parameters.Add("@dt1", SqlDbType.Date).Value = DateTimeBaslangic.Value;
                ürün.SelectCommand.Parameters.Add("@dt2", SqlDbType.Date).Value = DateTimeBitis.Value;
                ürün.SelectCommand.Parameters.Add("@masano", SqlDbType.Int).Value = MasaNoTextBox.Text;
                ürün.Fill(dt1);
                
                SatislarDataGrid.DataSource = dt1;
                baglanti.Close();
            }
            
        }

        private void DateTimeBitis_ValueChanged(object sender, EventArgs e)
        {
            if (MasaNoTextBox.Text == "")
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                baglanti.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter ürün = new SqlDataAdapter("SELECT siparis.MasaNo AS[Masa Numarası], Hesap.Tarih, Hesap.tutar, Hesap.HesapNo, Hesap.SiparisNo FROM siparis INNER JOIN Hesap ON siparis.SiparisNo = Hesap.SiparisNo where Tarih between @dt1 and @dt2", baglanti);
                ürün.SelectCommand.Parameters.Add("@dt1", SqlDbType.Date).Value = DateTimeBaslangic.Value;
                ürün.SelectCommand.Parameters.Add("@dt2", SqlDbType.Date).Value = DateTimeBitis.Value;
                ürün.Fill(dt1);

                SatislarDataGrid.DataSource = dt1;
                baglanti.Close();
            }
            else
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                baglanti.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter ürün = new SqlDataAdapter("SELECT siparis.MasaNo AS masano, Hesap.Tarih, Hesap.tutar, Hesap.HesapNo, Hesap.SiparisNo FROM siparis INNER JOIN Hesap ON siparis.SiparisNo = Hesap.SiparisNo where masano = @masano and Tarih between @dt1 and @dt2 ", baglanti);
                ürün.SelectCommand.Parameters.Add("@dt1", SqlDbType.Date).Value = DateTimeBaslangic.Value;
                ürün.SelectCommand.Parameters.Add("@dt2", SqlDbType.Date).Value = DateTimeBitis.Value;
                ürün.SelectCommand.Parameters.Add("@masano", SqlDbType.Int).Value = MasaNoTextBox.Text;
                ürün.Fill(dt1);

                SatislarDataGrid.DataSource = dt1;
                baglanti.Close();
            }
        }

        private void MasaNoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MasaNoTextBox.Text == "")
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                baglanti.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter ürün = new SqlDataAdapter("SELECT siparis.MasaNo AS[Masa Numarası], Hesap.Tarih, Hesap.tutar, Hesap.HesapNo, Hesap.SiparisNo FROM siparis INNER JOIN Hesap ON siparis.SiparisNo = Hesap.SiparisNo where Tarih between @dt1 and @dt2", baglanti);
                ürün.SelectCommand.Parameters.Add("@dt1", SqlDbType.Date).Value = DateTimeBaslangic.Value;
                ürün.SelectCommand.Parameters.Add("@dt2", SqlDbType.Date).Value = DateTimeBitis.Value;
                ürün.Fill(dt1);

                SatislarDataGrid.DataSource = dt1;
                baglanti.Close();
            }
            else
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                baglanti.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter ürün = new SqlDataAdapter("SELECT siparis.MasaNo AS masano, Hesap.Tarih, Hesap.tutar, Hesap.HesapNo, Hesap.SiparisNo FROM siparis INNER JOIN Hesap ON siparis.SiparisNo = Hesap.SiparisNo where masano = @masano and Tarih between @dt1 and @dt2 ", baglanti);
                ürün.SelectCommand.Parameters.Add("@dt1", SqlDbType.Date).Value = DateTimeBaslangic.Value;
                ürün.SelectCommand.Parameters.Add("@dt2", SqlDbType.Date).Value = DateTimeBitis.Value;
                ürün.SelectCommand.Parameters.Add("@masano", SqlDbType.Int).Value = MasaNoTextBox.Text;
                ürün.Fill(dt1);

                SatislarDataGrid.DataSource = dt1;
                baglanti.Close();
            }
        }
    }
}
