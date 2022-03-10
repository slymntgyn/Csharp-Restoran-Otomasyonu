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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
            
        }
        int masaNo;
        
        SQlBaglanti bgl = new SQlBaglanti();
        private void siparisleriKaydet()
        {
            if (listView1.Items.Count > 0)
            {
                if (Kontroller.veriVarmi("select * from siparis where MasaNo=" + masaNo + " AND Hesap='True'"))
                {
                    int siparisNo = Siparis.siparisNoGetir(masaNo);

                    
                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (item.Group == listView1.Groups[0])
                            {
                                if (!Kontroller.veriVarmi("select UrunNo from siparisürün where UrunNo=" + item.ImageKey + " AND SiparisNo=" + siparisNo + ""))
                                //Ürün bir defa eklendiyse bir daha eklemiyor bunun kontrolü
                                {

                                    int urunAdeti = 0;
                                    for (int i = 0; i < listView1.Groups[0].Items.Count; i++)
                                    {
                                        if (item.ImageKey == listView1.Groups[0].Items[i].ImageKey)
                                        {
                                            urunAdeti++;
                                            //eklenen ürün birden fazla ise sayısını buluyoruz
                                        }
                                    }
                                    if (Kontroller.siparisUrunEkle(siparisNo, item.ImageKey, urunAdeti))
                                    {
                                        //Ürünü ekliyor
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ürünler eklenirken hata!");
                                    }
                                }

                            }
                            else
                            {

                            }

                        }


                    
                }
                else
                {
                    if (Kontroller.siparisEkle(masaNo))
                    {
                        int siparisNo = Siparis.siparisNoGetir(masaNo);
                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (item.Group == listView1.Groups[0])
                            {
                                if (!Kontroller.veriVarmi("select UrunNo from siparisürün where UrunNo=" + item.ImageKey + " AND SiparisNo=" + siparisNo + ""))
                                //Ürün bir defa eklendiyse bir daha eklemiyor bunun kontrolü
                                {

                                    int urunAdeti = 0;
                                    for (int i = 0; i < listView1.Groups[0].Items.Count; i++)
                                    {
                                        if (item.ImageKey == listView1.Groups[0].Items[i].ImageKey)
                                        {
                                            urunAdeti++;
                                            //eklenen ürün birden fazla ise sayısını buluyoruz
                                        }
                                    }
                                    if (Kontroller.siparisUrunEkle(siparisNo, item.ImageKey, urunAdeti) ==true)
                                    {
                                        //Ürünü ekliyor
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ürünler eklenirken hata!");
                                    }
                                }

                            }


                        }
                    }
                    else
                    {
                        MessageBox.Show("Siparisler eklenirken hata meydana geldi.");
                    }

                }
            }
        }
        
        public static int siparisNoGetir(object masaNo)
        {
            SQlBaglanti bgl = new SQlBaglanti();
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            
            DataTable dt1 = new DataTable();
            SqlDataAdapter ürün = new SqlDataAdapter("select SiparisNo from siparis where MasaNo=" + masaNo + "AND Hesap='True'", baglanti);
            ürün.Fill(dt1);
            
            if (dt1.Rows.Count > 0)
            {

                int siparisNo = Convert.ToInt32(dt1.Rows[0][0].ToString());//yeni açılan masanın siparis numarasını aldık

                return siparisNo;
                
            }
            else
            {
                return -1;
                
            }
            
        }
        private void ürüngöster()
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
                this.listView2.Groups.Add(dt2.Rows[groupIndex]["UrunGrubu"].ToString(), dt2.Rows[groupIndex]["Adi"].ToString());

                for (int urunIndex = 0; urunIndex < dt1.Rows.Count; ++urunIndex)
                {
                    if (dt1.Rows[urunIndex]["UrunGrupNo"].ToString() == dt2.Rows[groupIndex]["UrunGrubu"].ToString())
                    {



                        if (File.Exists(dt1.Rows[urunIndex]["ResimYolu"].ToString()))//resimyolunda resim var mı diye kontrol ediyoruz
                        {
                            Image myImage = Image.FromFile(dt1.Rows[urunIndex]["ResimYolu"].ToString());//resimi alıyoruz
                            ımageList1.Images.Add(dt1.Rows[urunIndex]["UrunNo"].ToString(), myImage);//resmi imageliste ekliyoruz
                            ListViewItem item = new ListViewItem(dt1.Rows[urunIndex]["Adi"].ToString() + "-" + dt1.Rows[urunIndex]["Fiyati"].ToString() + " ₺",
                                dt1.Rows[urunIndex]["UrunNo"].ToString(), this.listView2.Groups[groupIndex]);//Ürünü,resmi,grubu bağlıyoruz
                            this.listView2.Items.Insert(0, item);//ürünü ekliyor
                            this.listView2.Groups[groupIndex].Items.Insert(0, item);//ürünü gruba ekliyor
                        }
                        else //resimyolunda resim yoksa imagekey yinede ürünNo dan oluşturulur. imagekeyden de ürün bilgilerini çekeceğiz.
                        {
                            ListViewItem item = new ListViewItem(dt1.Rows[urunIndex]["Adi"].ToString(), dt1.Rows[urunIndex]["UrunNo"].ToString(),
                            this.listView2.Groups[groupIndex]);//Ürünü,resmi,grubu bağlıyoruz
                            this.listView2.Items.Insert(0, item);//ürünü ekliyor
                            //this.listView2.Groups[groupIndex].Items.Insert(0, item);//ürünü gruba ekliyor
                        }

                    }

                }
            }
            baglanti.Close();
        }
        private int masanogetir(object masaNo)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            DataTable dt1 = new DataTable();
            SqlDataAdapter ürün = new SqlDataAdapter("select SiparisNo from siparis where MasaNo=" + masaNo + " AND Hesap='True'", baglanti);
            ürün.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                int siparisNo = Convert.ToInt32(dt1.Rows[0][0].ToString());//yeni açılan masanın siparis numarasını aldık
                return siparisNo;
            }
            else
            {
                return -1;
            }
        }
        private static bool veriVarmi(string sql)
        {
            SQlBaglanti bgl = new SQlBaglanti();
            SqlConnection baglanti = new SqlConnection(bgl.adres);
           
            baglanti.Open();
            string sorgu = sql;
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
           
            
            
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            baglanti.Close();
        }
        private void sepetürüngetir(object masaNo)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);

            try
            {
                int siparisNo = Siparis.siparisNoGetir(masaNo);
                if (veriVarmi("select * from siparisürün where SiparisNo=" + siparisNo + ""))
                {
                   
                    baglanti.Open();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter ürün = new SqlDataAdapter("select ürün.UrunNo as UrunNo,siparisürün.UrunAdet as UrunAdet,ürün.Adi as Adi,ürün.Fiyati as Fiyati,ürün.ResimYolu as ResimYolu from siparisürün inner join ürün on siparisürün.UrunNo=ürün.UrunNo where siparisürün.SiparisNo=" + siparisNo + "", baglanti);
                    ürün.Fill(dt1);
                    
                    for (int urunIndex = 0; urunIndex < dt1.Rows.Count; ++urunIndex)
                    {
                        for (int i = 0; i < Convert.ToInt32(dt1.Rows[urunIndex]["UrunAdet"].ToString()); i++)
                        {
                            if (File.Exists(dt1.Rows[urunIndex]["ResimYolu"].ToString()))//resimyolunda resim var mı diye kontrol ediyoruz
                            {
                                Image myImage = Image.FromFile(dt1.Rows[urunIndex]["ResimYolu"].ToString());//resimi alıyoruz
                                ımageList1.Images.Add(dt1.Rows[urunIndex]["UrunNo"].ToString(), myImage);//resmi imageliste ekliyoruz
                                ListViewItem item = new ListViewItem(dt1.Rows[urunIndex]["Adi"].ToString() + "-" + dt1.Rows[urunIndex]["Fiyati"].ToString() + " ₺",
                                    dt1.Rows[urunIndex]["UrunNo"].ToString(), this.listView2.Groups[0]);//Ürünü,resmi,grubu bağlıyoruz
                                this.listView1.Items.Insert(0, item);//ürünü ekliyor
                                this.listView1.Groups[0].Items.Insert(0, item);//ürünü gruba ekliyor
                                
                                double fiyati = Convert.ToDouble(item.Text.Substring(item.Text.IndexOf('-') + 1, item.Text.LastIndexOf(' ') - item.Text.LastIndexOf('-')));
                                TotalTextBox.Text = (Convert.ToDouble(TotalTextBox.Text) + fiyati).ToString();

                            }
                            else //resimyolunda resim yoksa imagekey yinede ürünNo dan oluşturulur. imagekeyden de ürün bilgilerini çekeceğiz.
                            {
                                ListViewItem item = new ListViewItem(dt1.Rows[urunIndex]["Adi"].ToString() + "-" + dt1.Rows[urunIndex]["Fiyati"].ToString() + " ₺",dt1.Rows[urunIndex]["UrunNo"].ToString(),
                                this.listView1.Groups[0]);//Ürünü,resmi,grubu bağlıyoruz
                                this.listView1.Items.Insert(0, item);//ürünü ekliyor
                                this.listView1.Groups[0].Items.Insert(0, item);//ürünü gruba ekliyor
                                double fiyati = Convert.ToDouble(item.Text.Substring(item.Text.IndexOf('-') + 1, item.Text.LastIndexOf(' ') - item.Text.LastIndexOf('-')));
                                TotalTextBox.Text = (Convert.ToDouble(TotalTextBox.Text) + fiyati).ToString();
                            }
                        }


                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Siparis_Load(object sender, EventArgs e)
        {

            this.Text = "Masa " + Masa.MasaNumarasi.ToString();
            masaNo = Convert.ToInt32(this.Text.Substring(Convert.ToInt32(this.Text.IndexOf(' '))));
            groupBox2.Visible = true;
            ürüngöster();
            

            //grubları listviewe ekliyor
            this.listView1.Groups.Add("0", "Ürünler");
            int siparisNo = Siparis.siparisNoGetir(masaNo);
            if (siparisNo != -1)
            {
                sepetUrunGoster();
            }
        }
        
        private void sepetUrunGoster()
        {
            SQlBaglanti bgl = new SQlBaglanti();
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            try
            {
                 int siparisNo =siparisNoGetir(masaNo);
                if (Kontroller.veriVarmi("select * from siparisürün where SiparisNo=" + siparisNo + ""))
                {
                    
                    baglanti.Open();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter ürün = new SqlDataAdapter("select ürün.UrunNo as UrunNo,siparisürün.UrunAdet as UrunAdet,ürün.Adi as Adi,ürün.Fiyati as Fiyati,ürün.ResimYolu as ResimYolu from siparisürün inner join ürün on siparisürün.UrunNo=ürün.UrunNo where siparisürün.SiparisNo=" + siparisNo + "", baglanti);
                    ürün.Fill(dt1);
                    
                    for (int urunIndex = 0; urunIndex < dt1.Rows.Count; ++urunIndex)
                    {
                        for (int i = 0; i < Convert.ToInt32(dt1.Rows[urunIndex]["UrunAdet"].ToString()); i++)
                        {
                            if (File.Exists(dt1.Rows[urunIndex]["ResimYolu"].ToString()))//resimyolunda resim var mı diye kontrol ediyoruz
                            {
                                Image myImage = Image.FromFile(dt1.Rows[urunIndex]["ResimYolu"].ToString());//resimi alıyoruz
                                ımageList1.Images.Add(dt1.Rows[urunIndex]["UrunNo"].ToString(), myImage);//resmi imageliste ekliyoruz
                                ListViewItem item = new ListViewItem(dt1.Rows[urunIndex]["Adi"].ToString() + "-" + dt1.Rows[urunIndex]["Fiyati"].ToString() + " ₺",
                                    dt1.Rows[urunIndex]["UrunNo"].ToString(), this.listView2.Groups[0]);//Ürünü,resmi,grubu bağlıyoruz
                                this.listView1.Items.Insert(0, item);//ürünü ekliyor
                                this.listView1.Groups[0].Items.Insert(0, item);//ürünü gruba ekliyor
                                double fiyati = Convert.ToDouble(item.Text.Substring(item.Text.IndexOf('-') + 1, item.Text.LastIndexOf(' ') - item.Text.LastIndexOf('-')));
                                TotalTextBox.Text = (Convert.ToDouble(TotalTextBox.Text) +fiyati).ToString();
                            }
                            else //resimyolunda resim yoksa imagekey yinede ürünNo dan oluşturulur. imagekeyden de ürün bilgilerini çekeceğiz.
                            {
                                ListViewItem item = new ListViewItem(dt1.Rows[urunIndex]["Adi"].ToString() + "-" + dt1.Rows[urunIndex]["Fiyati"].ToString() + " ₺", dt1.Rows[urunIndex]["UrunNo"].ToString(),
                                this.listView1.Groups[0]);//Ürünü,resmi,grubu bağlıyoruz
                                this.listView1.Items.Insert(0, item);//ürünü ekliyor
                                this.listView1.Groups[0].Items.Insert(0, item);//ürünü gruba ekliyor
                                double fiyati = Convert.ToDouble(item.Text.Substring(item.Text.IndexOf('-') + 1, item.Text.LastIndexOf(' ') - item.Text.LastIndexOf('-')));
                                TotalTextBox.Text = (Convert.ToDouble(TotalTextBox.Text) + fiyati).ToString();
                            }
                        }


                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem seciliItem in listView1.SelectedItems)
            {
                double fiyati = Convert.ToDouble(seciliItem.Text.Substring(seciliItem.Text.IndexOf('-') + 1, seciliItem.Text.LastIndexOf(',') - seciliItem.Text.LastIndexOf('-')));
                TotalTextBox.Text = (Convert.ToDouble(TotalTextBox.Text) - fiyati).ToString();
                listView1.Items[seciliItem.Index].Remove();
            }
        }

        private void çıkar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem seciliItem in listView1.SelectedItems)
            {
                double fiyati = Convert.ToDouble(seciliItem.Text.Substring(seciliItem.Text.IndexOf('-') + 1, seciliItem.Text.LastIndexOf(' ') - seciliItem.Text.LastIndexOf('-')));
                TotalTextBox.Text = (Convert.ToDouble(TotalTextBox.Text) - fiyati).ToString();
                listView1.Items[seciliItem.Index].Remove();
            }
        }

        private void BackButon_Click(object sender, EventArgs e)
        {
            
            this.Hide();
           
        }

        private void ApplicationExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Siparis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                siparisleriKaydet();
                if (Masa.anaFrm.listView1.Items[masaNo - 1].ImageKey == "BoşaMasa.png")
                {
                    Masa.anaFrm.listView1.Items[masaNo - 1].ImageKey = "DoluMasa.png";//Masayı dolu gösteriyoruz

                }

            }
            
            
            //Masa.anaFrm.listView1_SelectedIndexChanged(null, null);
        }
        
        private void HesabıÖde_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
               
                if (MessageBox.Show("Hesabı Ödemek İstiyor Musunuz?", "Hesap Öde", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    

                    siparisleriKaydet();
                    int siparisNo = Siparis.siparisNoGetir(masaNo);
                    if (Kontroller.hesapOde(siparisNo,TotalTextBox.Text))
                    {
                        



                    }
                    if (Masa.anaFrm.listView1.Items[masaNo - 1].ImageKey == "DoluMasa.png")
                    {
                        Masa.anaFrm.listView1.Items[masaNo - 1].ImageKey = "BoşaMasa.png";
                        //int doluMasa = Convert.ToInt32(frmAna.anaFrm.lblMasaDurum.Text.Substring(0, frmAna.anaFrm.lblMasaDurum.Text.IndexOf('/')));
                        //if (doluMasa > 0)
                        //{
                        //    frmAna.anaFrm.lblMasaDurum.Text = (doluMasa - 1).ToString() + "/" + frmAna.masaSayisi.ToString();
                        //    frmAna.anaFrm.prgMasaDurumu.Value -= 1;
                        //}


                    }
                    listView1.Items.Clear();


                }
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                foreach (ListViewItem seciliItem in listView2.SelectedItems)
                {
                    
                    double fiyati = Convert.ToDouble(seciliItem.Text.Substring(seciliItem.Text.IndexOf('-') +1, seciliItem.Text.LastIndexOf(' ') - seciliItem.Text.LastIndexOf('-')));
                    TotalTextBox.Text = (Convert.ToDouble(TotalTextBox.Text) + fiyati).ToString();

                    ListViewItem item = new ListViewItem(listView2.Items[seciliItem.Index].Text, listView2.Items[seciliItem.Index].ImageKey, this.listView1.Groups[0]);//Ürünü,resmi,grubu bağlıyoruz

                    this.listView1.Items.Insert(0, item);//ürünü ekliyor
                                                        // this.listView1.Groups[0].Items.Insert(0, item);//ürünü gruba ekliyor

                    listView2.SelectedItems[0].Selected = false;
                    
                }
            }
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void GiweMoneyTextBox_TextChanged(object sender, EventArgs e)
        {

            if (GiweMoneyTextBox.Text != "")
            {
                ParaÜstüTextBox.Text = (Convert.ToDouble(GiweMoneyTextBox.Text) - Convert.ToDouble(TotalTextBox.Text)).ToString();
            }
            else
            {
                ParaÜstüTextBox.Text = "0";
            }
        }

        private void GiweMoneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GiweMoneyTextBox.Text.IndexOf(',') != -1)
            {
                if (e.KeyChar == (char)44)
                {
                    e.Handled = true;
                }
            }
            Kontroller.txtParaKontrol(e);
        }

        private void ParaÜstüTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ekle_DoubleClick(object sender, EventArgs e)
        {
            
        }

       
    }
}
