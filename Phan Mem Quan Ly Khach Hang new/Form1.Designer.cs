namespace Phan_Mem_Quan_Ly_Khach_Hang_new
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkbock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_nhap_file_excel = new System.Windows.Forms.Button();
            this.btn_dong_bo = new System.Windows.Forms.Button();
            this.cb_chon_CH = new System.Windows.Forms.ComboBox();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_edit_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_edit_doanh_so = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_edit_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_edit_ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_edit_ma_khach_hang = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_tai_len = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_them_cua_hang = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_them_ngay_sinh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_them_doanh_so = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rich_them_gichu = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_them_code = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_them_phone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_them_ten = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_them_ma_khach_hang = new System.Windows.Forms.TextBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhsotichluyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codechDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachhangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_sap_xep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbock,
            this.iDDataGridViewTextBoxColumn,
            this.makhDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.doanhsotichluyDataGridViewTextBoxColumn,
            this.codechDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khachhangBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(251, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(697, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkbock
            // 
            this.checkbock.HeaderText = "Edit";
            this.checkbock.Name = "checkbock";
            this.checkbock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkbock.Width = 30;
            // 
            // btn_nhap_file_excel
            // 
            this.btn_nhap_file_excel.Location = new System.Drawing.Point(8, 8);
            this.btn_nhap_file_excel.Name = "btn_nhap_file_excel";
            this.btn_nhap_file_excel.Size = new System.Drawing.Size(113, 32);
            this.btn_nhap_file_excel.TabIndex = 1;
            this.btn_nhap_file_excel.Text = "Nhập File";
            this.btn_nhap_file_excel.UseVisualStyleBackColor = true;
            this.btn_nhap_file_excel.Click += new System.EventHandler(this.btn_nhap_file_excel_Click);
            // 
            // btn_dong_bo
            // 
            this.btn_dong_bo.Location = new System.Drawing.Point(252, 8);
            this.btn_dong_bo.Name = "btn_dong_bo";
            this.btn_dong_bo.Size = new System.Drawing.Size(103, 32);
            this.btn_dong_bo.TabIndex = 2;
            this.btn_dong_bo.Text = "Đồng Bộ";
            this.btn_dong_bo.UseVisualStyleBackColor = true;
            this.btn_dong_bo.Click += new System.EventHandler(this.btn_dong_bo_Click);
            // 
            // cb_chon_CH
            // 
            this.cb_chon_CH.FormattingEnabled = true;
            this.cb_chon_CH.Items.AddRange(new object[] {
            "ALL",
            "Phan Văn Trị",
            "Cống Quỳnh",
            "Phạm Văn Bạch",
            "Lê Văn Khương",
            "Lê Văn Sỹ"});
            this.cb_chon_CH.Location = new System.Drawing.Point(460, 15);
            this.cb_chon_CH.Name = "cb_chon_CH";
            this.cb_chon_CH.Size = new System.Drawing.Size(121, 21);
            this.cb_chon_CH.TabIndex = 3;
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(361, 8);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(93, 32);
            this.btn_xem.TabIndex = 4;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(121, 281);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(95, 27);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_edit_code);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_edit_doanh_so);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_edit_phone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_edit_ten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_edit_ma_khach_hang);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 317);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ghi Chú :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 189);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(207, 66);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Code";
            // 
            // txt_edit_code
            // 
            this.txt_edit_code.Location = new System.Drawing.Point(77, 145);
            this.txt_edit_code.Name = "txt_edit_code";
            this.txt_edit_code.Size = new System.Drawing.Size(145, 20);
            this.txt_edit_code.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doanh số";
            // 
            // txt_edit_doanh_so
            // 
            this.txt_edit_doanh_so.Location = new System.Drawing.Point(77, 112);
            this.txt_edit_doanh_so.Name = "txt_edit_doanh_so";
            this.txt_edit_doanh_so.Size = new System.Drawing.Size(145, 20);
            this.txt_edit_doanh_so.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // txt_edit_phone
            // 
            this.txt_edit_phone.Location = new System.Drawing.Point(77, 79);
            this.txt_edit_phone.Name = "txt_edit_phone";
            this.txt_edit_phone.Size = new System.Drawing.Size(145, 20);
            this.txt_edit_phone.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên";
            // 
            // txt_edit_ten
            // 
            this.txt_edit_ten.Location = new System.Drawing.Point(44, 46);
            this.txt_edit_ten.Name = "txt_edit_ten";
            this.txt_edit_ten.Size = new System.Drawing.Size(178, 20);
            this.txt_edit_ten.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // txt_edit_ma_khach_hang
            // 
            this.txt_edit_ma_khach_hang.Location = new System.Drawing.Point(103, 13);
            this.txt_edit_ma_khach_hang.Name = "txt_edit_ma_khach_hang";
            this.txt_edit_ma_khach_hang.Size = new System.Drawing.Size(119, 20);
            this.txt_edit_ma_khach_hang.TabIndex = 1;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(17, 281);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(82, 27);
            this.btn_sua.TabIndex = 0;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_tai_len
            // 
            this.btn_tai_len.Location = new System.Drawing.Point(133, 8);
            this.btn_tai_len.Name = "btn_tai_len";
            this.btn_tai_len.Size = new System.Drawing.Size(113, 32);
            this.btn_tai_len.TabIndex = 7;
            this.btn_tai_len.Text = "Tải Lên";
            this.btn_tai_len.UseVisualStyleBackColor = true;
            this.btn_tai_len.Click += new System.EventHandler(this.btn_tai_len_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(82, 333);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(82, 27);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_them_cua_hang);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_them_ngay_sinh);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_them_doanh_so);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rich_them_gichu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_them_code);
            this.groupBox2.Controls.Add(this.Code);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_them_phone);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_them_ten);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_them_ma_khach_hang);
            this.groupBox2.Location = new System.Drawing.Point(954, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 379);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // cb_them_cua_hang
            // 
            this.cb_them_cua_hang.FormattingEnabled = true;
            this.cb_them_cua_hang.Items.AddRange(new object[] {
            "Phan Văn Trị",
            "Cống Quỳnh",
            "Phạm Văn Bạch",
            "Lê Văn Khương",
            "Lê Văn Sỹ"});
            this.cb_them_cua_hang.Location = new System.Drawing.Point(82, 173);
            this.cb_them_cua_hang.Name = "cb_them_cua_hang";
            this.cb_them_cua_hang.Size = new System.Drawing.Size(145, 21);
            this.cb_them_cua_hang.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Ngày Sinh";
            // 
            // txt_them_ngay_sinh
            // 
            this.txt_them_ngay_sinh.Location = new System.Drawing.Point(82, 109);
            this.txt_them_ngay_sinh.Name = "txt_them_ngay_sinh";
            this.txt_them_ngay_sinh.Size = new System.Drawing.Size(145, 20);
            this.txt_them_ngay_sinh.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Doanh số";
            // 
            // txt_them_doanh_so
            // 
            this.txt_them_doanh_so.Location = new System.Drawing.Point(82, 141);
            this.txt_them_doanh_so.Name = "txt_them_doanh_so";
            this.txt_them_doanh_so.Size = new System.Drawing.Size(145, 20);
            this.txt_them_doanh_so.TabIndex = 19;
            this.txt_them_doanh_so.TextChanged += new System.EventHandler(this.txt_them_doanh_so_TextChanged);
            this.txt_them_doanh_so.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_them_doanh_so_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ghi Chú :";
            // 
            // rich_them_gichu
            // 
            this.rich_them_gichu.Location = new System.Drawing.Point(20, 251);
            this.rich_them_gichu.Name = "rich_them_gichu";
            this.rich_them_gichu.Size = new System.Drawing.Size(207, 66);
            this.rich_them_gichu.TabIndex = 15;
            this.rich_them_gichu.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Code";
            // 
            // txt_them_code
            // 
            this.txt_them_code.Location = new System.Drawing.Point(82, 206);
            this.txt_them_code.Name = "txt_them_code";
            this.txt_them_code.Size = new System.Drawing.Size(145, 20);
            this.txt_them_code.TabIndex = 11;
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(17, 183);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(55, 13);
            this.Code.TabIndex = 10;
            this.Code.Text = "Cửa Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Phone";
            // 
            // txt_them_phone
            // 
            this.txt_them_phone.Location = new System.Drawing.Point(77, 77);
            this.txt_them_phone.Name = "txt_them_phone";
            this.txt_them_phone.Size = new System.Drawing.Size(150, 20);
            this.txt_them_phone.TabIndex = 7;
            this.txt_them_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_them_phone_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tên";
            // 
            // txt_them_ten
            // 
            this.txt_them_ten.Location = new System.Drawing.Point(49, 45);
            this.txt_them_ten.Name = "txt_them_ten";
            this.txt_them_ten.Size = new System.Drawing.Size(178, 20);
            this.txt_them_ten.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mã Khách Hàng";
            // 
            // txt_them_ma_khach_hang
            // 
            this.txt_them_ma_khach_hang.Location = new System.Drawing.Point(108, 13);
            this.txt_them_ma_khach_hang.Name = "txt_them_ma_khach_hang";
            this.txt_them_ma_khach_hang.Size = new System.Drawing.Size(119, 20);
            this.txt_them_ma_khach_hang.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // makhDataGridViewTextBoxColumn
            // 
            this.makhDataGridViewTextBoxColumn.DataPropertyName = "ma_kh";
            this.makhDataGridViewTextBoxColumn.HeaderText = "Mã Khách Hàng";
            this.makhDataGridViewTextBoxColumn.Name = "makhDataGridViewTextBoxColumn";
            this.makhDataGridViewTextBoxColumn.Width = 140;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "Ngay_Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // doanhsotichluyDataGridViewTextBoxColumn
            // 
            this.doanhsotichluyDataGridViewTextBoxColumn.DataPropertyName = "doanh_so_tich_luy";
            this.doanhsotichluyDataGridViewTextBoxColumn.HeaderText = "Doanh Số Tích Lũy";
            this.doanhsotichluyDataGridViewTextBoxColumn.Name = "doanhsotichluyDataGridViewTextBoxColumn";
            this.doanhsotichluyDataGridViewTextBoxColumn.Width = 140;
            // 
            // codechDataGridViewTextBoxColumn
            // 
            this.codechDataGridViewTextBoxColumn.DataPropertyName = "code_ch";
            this.codechDataGridViewTextBoxColumn.HeaderText = "Cửa Hàng";
            this.codechDataGridViewTextBoxColumn.Name = "codechDataGridViewTextBoxColumn";
            this.codechDataGridViewTextBoxColumn.Width = 80;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "CODE";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // khachhangBindingSource1
            // 
            this.khachhangBindingSource1.DataSource = typeof(Phan_Mem_Quan_Ly_Khach_Hang_new.khach_hang);
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataSource = typeof(Phan_Mem_Quan_Ly_Khach_Hang_new.khach_hang);
            // 
            // btn_sap_xep
            // 
            this.btn_sap_xep.Location = new System.Drawing.Point(907, 48);
            this.btn_sap_xep.Name = "btn_sap_xep";
            this.btn_sap_xep.Size = new System.Drawing.Size(32, 17);
            this.btn_sap_xep.TabIndex = 18;
            this.btn_sap_xep.UseVisualStyleBackColor = true;
            this.btn_sap_xep.Click += new System.EventHandler(this.btn_sap_xep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 463);
            this.Controls.Add(this.btn_sap_xep);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_tai_len);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.cb_chon_CH);
            this.Controls.Add(this.btn_dong_bo);
            this.Controls.Add(this.btn_nhap_file_excel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_nhap_file_excel;
        private System.Windows.Forms.Button btn_dong_bo;
        private System.Windows.Forms.ComboBox cb_chon_CH;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewButtonColumn checkbock;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanhsotichluyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codechDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_edit_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_edit_doanh_so;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_edit_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_edit_ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_edit_ma_khach_hang;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_tai_len;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_them_ngay_sinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_them_doanh_so;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rich_them_gichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_them_code;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_them_phone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_them_ten;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_them_ma_khach_hang;
        private System.Windows.Forms.ComboBox cb_them_cua_hang;
        private System.Windows.Forms.BindingSource khachhangBindingSource1;
        private System.Windows.Forms.Button btn_sap_xep;
    }
}

