using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Phan_Mem_Quan_Ly_Khach_Hang_new
{
   
        public class khach_hang
        {
        public int ID { get; set; }
            public string ma_kh { get; set; }
            public string Ten { get; set; }
            // public string  { get; set; }
            public string Ngay_Sinh { get; set; }
            public string Phone { get; set; }
            public string doanh_so_tich_luy { get; set; }
            public string code_ch { get; set; }
        public string note { get; set; }
        public string code { get; set; }

            public BindingList<khach_hang> nhapdoanhsach(string ch)
            {
            BindingList<khach_hang> list_kh = new BindingList<khach_hang>();
                OpenFileDialog open = new OpenFileDialog();
            open.Filter = "(*.*)|*.*";//"(*.xlsx)|*.xlsx|(*.xls)|(*.xls)";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    String link = open.FileName;
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(link);
                Excel._Worksheet workSheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = workSheet.UsedRange;
                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                int j = 1;
                for (int i = 10; i <= rowCount; i++)
                        {
                    
                            try
                            {
                        
                        int tichluy = (int)xlRange.Cells[i, 41].Value;
                        if (tichluy > 3000000)
                        {

                            khach_hang kh = new khach_hang();
                            kh.ID = j;
                        kh.ma_kh = xlRange.Cells[i,2].Value.ToString();
                        kh.Ten = xlRange.Cells[i, 4].Value.ToString() + " " + xlRange.Cells[i, 3].Value.ToString();
                        kh.Ngay_Sinh = xlRange.Cells[i, 6].Value.ToString();
                        //10 //41
                        kh.Phone = xlRange.Cells[i, 10].Value.ToString();
                            string s = "";
                            if (ch == "Phan Văn Trị")
                            {
                                s = "PVT";
                            }
                            else if (ch == "Cống Quỳnh")
                            {
                                s = "CQ";
                            }
                            else if (ch == "Phạm Văn Bạch")
                            {
                                s = "PVB";
                            }
                            else if (ch == "Lê Văn Khương")
                            {
                                s = "LVK";
                            }
                            else if (ch == "Lê Văn Sỹ")
                            {
                                s = "LVS";
                            }
                            kh.code_ch = s;
                            string doanhso = string.Format("{0:#,##0}", (int)xlRange.Cells[i, 41].Value);
                            kh.doanh_so_tich_luy = doanhso;
                            kh.code = "";
                            kh.note = "";
                            list_kh.Add(kh);
                            j++;
                        }
                        
                    }
                            catch { }
                            

                        }

                    
                  
                }

                return list_kh;
            }
            public void dongbo()
            {
                
            }
        }
    
}
