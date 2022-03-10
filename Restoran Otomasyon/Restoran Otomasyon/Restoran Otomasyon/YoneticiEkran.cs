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
    public partial class YoneticiEkran : Form
    {
        public YoneticiEkran()
        {
            InitializeComponent();
        }
        SQlBaglanti bgl = new SQlBaglanti();
        private void LogoPicture_Click(object sender, EventArgs e)
        {

        }

        private void PersonelEkleButon_Click(object sender, EventArgs e)
        {
            PersonelEkle pe = new PersonelEkle();
            pe.Show();
            this.Hide();
        }

        private void SatışlarButon_Click(object sender, EventArgs e)
        {
            SatislariGoruntule stg = new SatislariGoruntule();
            stg.Show();
            this.Hide();
        }

        private void YoneticiEkran_Load(object sender, EventArgs e)
        {
            
        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
