using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restoran_Otomasyon
{
    class Kontroller
    {
        SQlBaglanti bgl = new SQlBaglanti();
        public static bool veriVarmi(string sql)
        {
            SQlBaglanti bgl = new SQlBaglanti();
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql,baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                return true;
                baglanti.Close();
            }
            else
            {
                
                return false;
                baglanti.Close();
            }
        }
        public static bool siparisUrunTemizle(object siparisNo)
        {
            
            try
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                SqlCommand sil = new SqlCommand("delete from siparisürün where SiparisNo=@siparisNo",baglanti);
                
                
                sil.Parameters.Add("@siparisNo", System.Data.SqlDbType.Int).Value = siparisNo;
                sil.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
        }//SiparisUrun tablosunda siparisNo ile silme işlemi yapar
        public static bool siparisUrunEkle(object siparisNo, object urunNo, object urunAdet)
        {
            
            try
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                SqlCommand  cmd = new SqlCommand("insert into siparisürün (SiparisNo,UrunNo,UrunAdet) values (@siparisNo,@urunNo,@urunAdet)", baglanti);


               
                cmd.Parameters.Add("@siparisNo", System.Data.SqlDbType.Int).Value = siparisNo;
                cmd.Parameters.Add("@urunNo", System.Data.SqlDbType.Int).Value = urunNo;
                cmd.Parameters.Add("@urunAdet", System.Data.SqlDbType.Int).Value = urunAdet;
                baglanti.Open();
                cmd.ExecuteNonQuery();
                return true;
                baglanti.Close();
            }
            catch
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                return false;
                baglanti.Close();
            }
        }//SiparisUrun tablosuna ekleme yapar
        public static bool siparisEkle(object masaNo)//Siparis tablosuna siparisleri ekliyor
        {
           

            try
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                SqlCommand cmd = new SqlCommand("insert into siparis (MasaNo,Hesap) values (@masano,@true)", baglanti);
                cmd.Parameters.Add("@masano", System.Data.SqlDbType.Int).Value = masaNo;
                Boolean a = true;
                cmd.Parameters.Add("@true", System.Data.SqlDbType.Bit).Value = a;
                baglanti.Open();
                cmd.ExecuteNonQuery();

                return true;
                baglanti.Close();
            }
            catch (Exception )
            {
                
                return false;
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                baglanti.Close();

            }

        }
        public static bool hesapOde(object siparisNo, object tutar)
        {
            

            try
            {
                SQlBaglanti bgl = new SQlBaglanti();
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update siparis set Hesap='False' where SiparisNo=" + siparisNo + " ", baglanti);

                
                cmd.ExecuteNonQuery();
                SqlCommand Hesap = new SqlCommand("insert into Hesap (SiparisNo,tutar,Tarih) values (@siparisNo,@tutar,@tarih)", baglanti);
               
                Hesap.Parameters.Add("@siparisNo", System.Data.SqlDbType.Int).Value = siparisNo;
                
                Hesap.Parameters.Add("@tutar", System.Data.SqlDbType.Money).Value = tutar;
                Hesap.Parameters.Add("@tarih", DateTime.Now);
                Hesap.ExecuteNonQuery();
                 
                
                baglanti.Close();
                return true;
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }
        }
        public static void txtParaKontrol(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            // text'e sadece sayıların girmesi,geri silme tuşu(ascii kodu:08),virgül(ascii kodu:44) karakterinin girilmesini sağlar.
            //del tuşununda aktif olmasını isterseniz del ascıı kodu:127

            //
            {
                e.Handled = true;
            }
            
        }

    }
}
