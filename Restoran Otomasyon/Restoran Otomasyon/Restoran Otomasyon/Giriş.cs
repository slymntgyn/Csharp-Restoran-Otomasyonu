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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            PictureBox1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminGirisi ad = new AdminGirisi();
            ad.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PersonelGirisi pg = new PersonelGirisi();
            pg.Show();
            this.Hide();
        }

        private void Giriş_Load(object sender, EventArgs e)
        {


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hakkında hk = new Hakkında();
            hk.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
