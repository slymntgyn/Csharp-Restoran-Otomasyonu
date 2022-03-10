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
    public partial class Hakkında : Form
    {
        public Hakkında()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu ekran zaten açık", "Uyarı");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PersonelGirisi pg = new PersonelGirisi();
            pg.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminGirisi ag = new AdminGirisi();
            ag.Show();
            this.Hide();
        }

        private void Hakkında_Load(object sender, EventArgs e)
        {

        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
