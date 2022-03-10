using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace excel
{
    public class Class1
    {
        public static void aktar(string urunadi, string urunfiyatı, string urungrup, string urunresimyolu)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            try
            {

                Microsoft.Office.Interop.Excel.Range uruna =
                    (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + 0, StartCol + 0];
                Microsoft.Office.Interop.Excel.Range urunfi =
                    (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + 0, StartCol + 1];
                Microsoft.Office.Interop.Excel.Range urungr =
                    (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + 0, StartCol + 2];
                Microsoft.Office.Interop.Excel.Range urunresyol =
                    (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + 0, StartCol + 3];
                uruna.Value2 = "Ürünün Adi" == null ? "" : "Ürünün Adi";
                urunfi.Value2 = "Ürünün Fiyatı" == null ? "" : "Ürünün Fiyatı";
                urungr.Value2 = "Ürünün Grubu" == null ? "" : "Ürünün Grubu";
                urunresyol.Value2 = "ürünün Resim Yolu" == null ? "" : "ürünün Resim Yolu";
                uruna.Select();
                urunfi.Select();
                urungr.Select();
                urunresyol.Select();

                /*//////////////////////////////////////////////////////////////////////////////*/
                Microsoft.Office.Interop.Excel.Range myRange =
                    (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + 1, StartCol + 0];
                Microsoft.Office.Interop.Excel.Range myRange1 =
                    (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + 1, StartCol + 1];
                Microsoft.Office.Interop.Excel.Range myRange2 =
                    (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + 1, StartCol + 2];
                Microsoft.Office.Interop.Excel.Range myRange3 =
                    (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + 1, StartCol + 3];
                myRange.Value2 = urunadi == null ? "" : urunadi;
                myRange1.Value2 = urunfiyatı == null ? "" : urunfiyatı;
                myRange2.Value2 = urungrup == null ? "" : urungrup;
                myRange3.Value2 = urunresimyolu == null ? "" : urunresimyolu;
                myRange.Select();
                myRange1.Select();
                myRange2.Select();
                myRange3.Select();
            }
            catch
            {
                ;
            }
        }
    }
}
