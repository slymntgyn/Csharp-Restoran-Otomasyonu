using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restoran_Otomasyon
{
    class SQlBaglanti
    {
        public string adres = System.IO.File.ReadAllText(@"C:\baglantiadresi2.txt");
    }
    
}
