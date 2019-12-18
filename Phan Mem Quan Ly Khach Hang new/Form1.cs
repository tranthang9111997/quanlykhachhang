using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly_Khach_Hang_new
{
    public partial class Form1 : Form
    {
        BindingList<khach_hang> list = new BindingList<khach_hang>();
        BindingList<khach_hang> list_dongbo_tren_datagriwview = new BindingList<khach_hang>();
      // List <khach_hang> list_dongbo_tren_datagriwview = new List<khach_hang>();
        MySqlConnection conn = DBUtils.GetDBConnection();
        void enabled_txt(bool a )
        {
            txt_them_code.Enabled = a;
            txt_them_ma_khach_hang.Enabled = a;
            txt_them_ten.Enabled = a;
            txt_them_phone.Enabled = a;
            txt_them_ngay_sinh.Enabled = a;
            txt_them_doanh_so.Enabled = a;
            cb_them_cua_hang.Enabled = a;
            btn_xoa_server.Enabled = a;
            btn_sua.Enabled = a;
            // txt_them_code
            rich_them_gichu.Enabled = a;
        }
        void design_form()
        {
            groupBox1.Enabled = false;
         

        }
        public Form1()
        {
            InitializeComponent();
            Button b = new Button();
            b.Click += new EventHandler(btn_xem_Click);
            ketnoi();
        }
        string tieude = "Quản Lý Khách Hàng                                                                          ";
        void ketnoi()
        {  try
            {
                conn.Open(); this.Text = tieude+"Ket Noi Thanh Cong";
            } catch
            {
                MessageBox.Show("Ket Khong Thanh Cong");
            }
        }
        private void openconnect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void closeconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }      
        public Boolean exedata(string cmd)
        {
            openconnect();
            Boolean check = false;
            MySqlCommand sc = new MySqlCommand(cmd, conn);
            try
            {
                sc.ExecuteNonQuery();
           
            check = true;
           
              
            }
            catch (Exception)
            {
                check = false;
            }
            closeconnect();
            return check;
        }
        public DataTable readdata(string cmd)
        {
            openconnect();
            DataTable da = new DataTable();
            try
            {
                MySqlCommand sc = new MySqlCommand(cmd, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            closeconnect();
            return da;
        }
        DataTable table_dulieu = new DataTable();
        void xem_theo_ch(string ch)
        {
            string s = "";
            string sql = "";
            if (ch== "Phan Văn Trị")
            {
                s = "PVT";
            }else if(ch== "Cống Quỳnh")
            {
                s = "CQ";
            }
            else if(ch== "Phạm Văn Bạch")
            {
                s = "PVB";
            }
            else if(ch== "Lê Văn Khương")
            {
                s = "LVK";
            }
            else if(ch== "Lê Văn Sỹ")
            {
                s = "LVS";
            }
            else if (ch == "ALL")
            {
                s = "1";
            }
            if (s == "1")
            {
                 sql = "SELECT * FROM `Khach_Hang` WHERE 1";
            } else
            {
                 sql = "SELECT * FROM `Khach_Hang` WHERE Khach_Hang.code_ch='" + s + "'";
            }
           
            string sap_xep_id = "SET @'var_name' = 0;UPDATE `Khach_Hang` SET ID = (@'var_name' := @'var_name' +1);ALTER TABLE `Khach_Hang` AUTO_INCREMENT = 1";
            exedata(sap_xep_id);
            table_dulieu = readdata(sql);
            dataGridView1.DataSource = table_dulieu;
        }
        void them_dong_bo()
        {
           // exedata("DELETE FROM `Khach_Hang`");
            
            foreach (khach_hang a in list_dongbo_tren_datagriwview)
            {

                string k = "INSERT INTO `Khach_Hang` (`ID`,`Ma_KH`, `Ten`, `Phone`, `Ngay_sinh`, `Doanh_so_tich_luy`, `code_ch`, `code`, `note`) VALUES ('" + a.ID + "','" + a.ma_kh + "', '" + a.Ten + "', '" + a.Phone + "', '" + a.Ngay_Sinh + "', '" + a.doanh_so_tich_luy + "',  '" + a.code_ch + "','" + a.code + "', '" + a.note + "')";
                exedata(k);


            }
            this.Text = tieude + "Xong";
        }
        void tai_len()
        {
          //  exedata("DELETE FROM `Khach_Hang`");

            foreach (khach_hang a in list_dongbo_tren_datagriwview)
            {

                string k = "INSERT INTO `Khach_Hang` (`ID`,`Ma_KH`, `Ten`, `Phone`, `Ngay_sinh`, `Doanh_so_tich_luy`, `code_ch`, `code`, `note`) VALUES ('" + a.ID + "','" + a.ma_kh + "', '" + a.Ten + "', '" + a.Phone + "', '" + a.Ngay_Sinh + "', '" + a.doanh_so_tich_luy + "',  '" + a.code_ch + "','" + a.code + "', '" + a.note + "')";
                exedata(k);


            }
            this.Text = tieude + "Xong";
        }

        private void btn_nhap_file_excel_Click(object sender, EventArgs e)
        {
            btn_nhap_file_excel.Enabled = false;
            
            khach_hang a = new khach_hang();
            if (cb_chon_CH.Text == "")
            {
                MessageBox.Show("Chưa Chọn Cửa Hàng");
            }
            else
            {
                list = a.nhapdoanhsach(cb_chon_CH.Text);

                dataGridView1.DataSource = list;

                dataGridView1.Refresh();
            }
            btn_nhap_file_excel.Enabled = true;

        }

        private void btn_dong_bo_Click(object sender, EventArgs e)
        {
            xuly_tabale_vao_khach_hang();
            them_dong_bo();
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            enabled_txt(false);
            
            string s = cb_chon_CH.Text;
            if (s == "")
            {
                MessageBox.Show("chưa chọn cửa hàng");
            }
            else
            {
                xem_theo_ch(s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            design_form();
            enabled_txt(false);
           
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
           
        }

        private void inserdata(MySqlConnection conn, string sql)
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        }
        void xoa_colum_datagriwview()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            xoa_colum_datagriwview();
            txt_edit_ma_khach_hang.ResetText();
            txt_edit_ten.ResetText();
            txt_edit_phone.ResetText();
            txt_edit_doanh_so.ResetText();
            richTextBox1.ResetText();
            xuly_tabale_vao_khach_hang();
        }
        
        void xuly_tabale_vao_khach_hang()
        {
            BindingList<khach_hang> list_new = new BindingList<khach_hang>();
            foreach(DataGridViewRow a in dataGridView1.Rows)
            {
                khach_hang akh = new khach_hang();
                akh.ID = (int)a.Cells[1].Value;
                akh.Ten = a.Cells[3].Value.ToString();
                akh.ma_kh= a.Cells[2].Value.ToString();
                akh.Ngay_Sinh = a.Cells[4].Value.ToString();
                akh.Phone = a.Cells[5].Value.ToString();
                akh.doanh_so_tich_luy = a.Cells[6].Value.ToString();
                akh.code_ch = a.Cells[7].Value.ToString();
                akh.note = a.Cells[8].Value.ToString();
                akh.code = a.Cells[9].Value.ToString();
                list_new.Add(akh);
            }
            list_dongbo_tren_datagriwview = list_new;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
      e.RowIndex >= 0)
            {
                groupBox1.Enabled = true;
                enabled_txt(true);

                txt_them_ma_khach_hang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_them_ten.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_them_phone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_them_doanh_so.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_them_ngay_sinh.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_them_code.Text= dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                rich_them_gichu.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                string s = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                if (s == "PVT")
                {
                    cb_them_cua_hang.SelectedIndex = 0;
                }
                else if (s == "CQ")
                {
                    cb_them_cua_hang.SelectedIndex = 1;
                }
                else if (s == "PVB")
                {
                    cb_them_cua_hang.SelectedIndex = 2;
                }
                else if (s == "LVK")
                {
                    cb_them_cua_hang.SelectedIndex = 3;
                }
                else if (s == "LVS")
                {
                    cb_them_cua_hang.SelectedIndex = 4;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            xuly_tabale_vao_khach_hang();
        }

        private void btn_tai_len_Click(object sender, EventArgs e)
        {
            tai_len();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_them_ma_khach_hang.Enabled == false)
            {
                enabled_txt(true);
                btn_sua.Enabled = false;
                btn_xoa_server.Enabled = false;
            }
            else
            {
                if (txt_them_ma_khach_hang.Text == "" || txt_them_ten.Text == "" || cb_them_cua_hang.Text == "" || txt_them_doanh_so.Text == "" || txt_them_phone.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    string s = "";
                    if (cb_them_cua_hang.Text == "Phan Văn Trị")
                    {
                        s = "PVT";
                    }
                    else if (cb_them_cua_hang.Text == "Cống Quỳnh")
                    {
                        s = "CQ";
                    }
                    else if (cb_them_cua_hang.Text == "Phạm Văn Bạch")
                    {
                        s = "PVB";
                    }
                    else if (cb_them_cua_hang.Text == "Lê Văn Khương")
                    {
                        s = "LVK";
                    }
                    else if (cb_them_cua_hang.Text == "Lê Văn Sỹ")
                    {
                        s = "LVS";
                    }
                    khach_hang kh1 = new khach_hang();
                    Random a = new Random();
                    kh1.ma_kh = txt_them_ma_khach_hang.Text;
                    kh1.Ten = txt_them_ten.Text;
                    kh1.Ngay_Sinh = txt_them_ngay_sinh.Text;
                    kh1.code = txt_them_code.Text;
                    kh1.code_ch = s;
                    kh1.doanh_so_tich_luy = txt_them_doanh_so.Text;
                    kh1.note = rich_them_gichu.Text;
                    kh1.Phone = txt_them_phone.Text;
                    kh1.ID = a.Next(200, 300);
                    string sql = "INSERT INTO `Khach_Hang`(`Ma_KH`, `Ten`, `Phone`, `Ngay_sinh`, `Doanh_so_tich_luy`, `code_ch`, `note`, `code`) VALUES ('" + txt_them_ma_khach_hang.Text + "','" + txt_them_ten.Text + "','" + txt_them_phone.Text + "','" + txt_them_ngay_sinh.Text + "','" + txt_them_doanh_so.Text + "','" + s + "','" + rich_them_gichu.Text + "','" + txt_them_code.Text + "')";
                    if (exedata(sql))
                    {
                        MessageBox.Show("Thanh Cong");
                    }
                    else
                    {
                        MessageBox.Show("That Bai");
                    }
                    //      xuly_tabale_vao_khach_hang();
                    //     list_dongbo_tren_datagriwview.Add(kh1);
                    //   dataGridView1.DataSource = list_dongbo_tren_datagriwview;

                }
            }
            
        
        }

        private void txt_them_doanh_so_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_them_doanh_so_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_them_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        void hoanvi(DataGridViewRow a, DataGridViewRow b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        //
        int sord(string s1,string s2)
        {
            s1 = s1.Replace(",", "");
            s2 = s2.Replace(",", "");
            int ss1 = Convert.ToInt32(s1);
            int ss2 = Convert.ToInt32(s2);
            if (ss1 > ss2)
            {
                return 0;
            }
            else
            {
               return 1;
            }
        }
        void xap_xep_datagriview()
        {
           // btn_sap_xep.Enabled = false;
            List<string> thutu = new List<string>();
            for(int i=0;i< dataGridView1.RowCount-1; i++)
            {
                for(int j=i+1;j<dataGridView1.RowCount;j++){
                   
                    if (sord(dataGridView1.Rows[i].Cells[6].Value.ToString(), dataGridView1.Rows[j].Cells[6].Value.ToString()) == 1)
                    {
                        //     DataRow a=dataGridView1.newr
                        
                        //  DataRow rowsnew = 
                        DataGridViewRow dr = new DataGridViewRow();
                        DataGridViewRow dgvDelRow = dataGridView1.Rows[i];
                        DataGridViewRow dgvDelRow1 = dataGridView1.Rows[j];
                        dataGridView1.Rows.Remove(dgvDelRow);
                        dataGridView1.Rows.Remove(dgvDelRow1);
                        dgvDelRow.CreateCells(dataGridView1);
                        dgvDelRow1.CreateCells(dataGridView1);
                        
                        dataGridView1.Rows.Insert(i+1, dgvDelRow1);
                        dataGridView1.Rows.Insert(j+1, dgvDelRow);
                        // hoanvi(dgvDelRow, dgvDelRow1);
                        //   dataGridView1.Rows.Remove(dgvDelRow);
                        //  dataGridView1.Rows.Remove(dgvDelRow1);

                    }
                    
                }
                
            }
            dataGridView1.Refresh();
         //   btn_sap_xep.Enabled = true;
        }
        private void btn_sap_xep_Click(object sender, EventArgs e)
        {
            //  xap_xep_datagriview();
            DataGridView dgv = dataGridView1;
            try
            {
                int totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                // get index of the column for the selected cell
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex + 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void btn_xoa_server_Click(object sender, EventArgs e)
        {
            //   string sql1 = "DELETE FROM `Khach_Hang` WHERE `Ma_KH`='CUS.TG40063.00045'";
            DialogResult result = MessageBox.Show("Khách Hàng :"+txt_them_ten.Text, "Bạn Muốn Xóa ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            switch (result)
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Đóng messagebox nè");
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.No:
                    MessageBox.Show("NO");
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("Cái mới của yes");
                    break;
                default:
                    break;
            }
            string sql = "DELETE FROM `Khach_Hang` WHERE `Ma_KH`='" + txt_them_ma_khach_hang.Text + "'";
            if (exedata(sql))
            {
                MessageBox.Show("Thanh Cong");

               btn_xem.Click += new EventHandler(btn_xem_Click);
              //  EventArgs ee = new EventArgs();
                btn_xem_Click(btn_xem, e);


            }
            else
            {
                MessageBox.Show("That Bai");
            }
        }
        void button_them_sua_xoa(bool a)
        {
            btn_them.Enabled = a;
            btn_sua.Enabled = a;
            btn_xoa.Enabled = a;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            button_them_sua_xoa(true);
            btn_cancel.Enabled = false;
        }
    }
}
