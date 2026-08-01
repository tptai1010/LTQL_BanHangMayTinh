namespace LinhKienMayTinh
{
    partial class frmPhieuNhapHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            dtpNgayLap = new DateTimePicker();
            txtMaPhieu = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            txtEmail = new TextBox();
            txtSDT_NCC = new TextBox();
            txtDiaChi = new TextBox();
            txtTenNCC = new TextBox();
            cbMaNCC = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox4 = new GroupBox();
            cbMaNV = new ComboBox();
            txtTenNV = new TextBox();
            txtSDT_NV = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            cbMaHH = new ComboBox();
            txtDGNhap = new TextBox();
            label17 = new Label();
            txtSLNhap = new TextBox();
            txtThanhTien = new TextBox();
            txtHangSX = new TextBox();
            label16 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtTenHH = new TextBox();
            label13 = new Label();
            label12 = new Label();
            txtTongTien_BangSo = new TextBox();
            lblTongTien_BangChu = new Label();
            label11 = new Label();
            groupBox6 = new GroupBox();
            dgvDSHangHoaNhap = new DataGridView();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnDSPhieuNhap = new Button();
            btnIn = new Button();
            btnDatLai = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSHangHoaNhap).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.MediumBlue;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1177, 321);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpNgayLap);
            groupBox3.Controls.Add(txtMaPhieu);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(15, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(561, 111);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin phiếu nhập";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Font = new Font("Microsoft Sans Serif", 10.2F);
            dtpNgayLap.Location = new Point(156, 62);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(388, 27);
            dtpNgayLap.TabIndex = 3;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtMaPhieu.Location = new Point(156, 25);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(388, 27);
            txtMaPhieu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(23, 69);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày lập phiếu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtEmail);
            groupBox5.Controls.Add(txtSDT_NCC);
            groupBox5.Controls.Add(txtDiaChi);
            groupBox5.Controls.Add(txtTenNCC);
            groupBox5.Controls.Add(cbMaNCC);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Location = new Point(593, 26);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(563, 275);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin nhà cung cấp";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtEmail.Location = new Point(167, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(379, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtSDT_NCC
            // 
            txtSDT_NCC.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSDT_NCC.Location = new Point(167, 142);
            txtSDT_NCC.Name = "txtSDT_NCC";
            txtSDT_NCC.Size = new Size(379, 27);
            txtSDT_NCC.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtDiaChi.Location = new Point(167, 101);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(379, 27);
            txtDiaChi.TabIndex = 8;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenNCC.Location = new Point(167, 62);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(379, 27);
            txtTenNCC.TabIndex = 7;
            // 
            // cbMaNCC
            // 
            cbMaNCC.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbMaNCC.FormattingEnabled = true;
            cbMaNCC.Location = new Point(167, 24);
            cbMaNCC.Name = "cbMaNCC";
            cbMaNCC.Size = new Size(379, 28);
            cbMaNCC.TabIndex = 6;
            cbMaNCC.TextChanged += cbMaNCC_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(19, 186);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 4;
            label10.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(19, 149);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 3;
            label9.Text = "Số điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(19, 108);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 2;
            label8.Text = "Địa chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(19, 69);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 1;
            label7.Text = "Tên nhà cung cấp:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(19, 32);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 0;
            label6.Text = "Mã nhà cung cấp:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbMaNV);
            groupBox4.Controls.Add(txtTenNV);
            groupBox4.Controls.Add(txtSDT_NV);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(15, 143);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(561, 158);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nhân viên";
            // 
            // cbMaNV
            // 
            cbMaNV.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbMaNV.FormattingEnabled = true;
            cbMaNV.Location = new Point(156, 24);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(388, 28);
            cbMaNV.TabIndex = 5;
            cbMaNV.TextChanged += cbMaNV_TextChanged;
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenNV.Location = new Point(156, 62);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(388, 27);
            txtTenNV.TabIndex = 3;
            // 
            // txtSDT_NV
            // 
            txtSDT_NV.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSDT_NV.Location = new Point(156, 103);
            txtSDT_NV.Name = "txtSDT_NV";
            txtSDT_NV.Size = new Size(388, 27);
            txtSDT_NV.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(27, 110);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 2;
            label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(27, 69);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(27, 32);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã nhân viên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbMaHH);
            groupBox2.Controls.Add(txtDGNhap);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(txtSLNhap);
            groupBox2.Controls.Add(txtThanhTien);
            groupBox2.Controls.Add(txtHangSX);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtTenHH);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtTongTien_BangSo);
            groupBox2.Controls.Add(lblTongTien_BangChu);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.MediumBlue;
            groupBox2.Location = new Point(12, 339);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1177, 456);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hàng hóa";
            // 
            // cbMaHH
            // 
            cbMaHH.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbMaHH.FormattingEnabled = true;
            cbMaHH.Location = new Point(136, 24);
            cbMaHH.Name = "cbMaHH";
            cbMaHH.Size = new Size(251, 28);
            cbMaHH.TabIndex = 16;
            cbMaHH.TextChanged += cbHangHoa_TextChanged;
            // 
            // txtDGNhap
            // 
            txtDGNhap.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtDGNhap.Location = new Point(934, 25);
            txtDGNhap.Name = "txtDGNhap";
            txtDGNhap.Size = new Size(222, 27);
            txtDGNhap.TabIndex = 15;
            txtDGNhap.TextChanged += txtDGNhap_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10.2F);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(813, 32);
            label17.Name = "label17";
            label17.Size = new Size(112, 20);
            label17.TabIndex = 12;
            label17.Text = "Đơn giá nhập:";
            // 
            // txtSLNhap
            // 
            txtSLNhap.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSLNhap.Location = new Point(551, 25);
            txtSLNhap.Name = "txtSLNhap";
            txtSLNhap.Size = new Size(222, 27);
            txtSLNhap.TabIndex = 11;
            txtSLNhap.TextChanged += txtSLNhap_TextChanged;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtThanhTien.Location = new Point(934, 61);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(222, 27);
            txtThanhTien.TabIndex = 14;
            // 
            // txtHangSX
            // 
            txtHangSX.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtHangSX.Location = new Point(551, 61);
            txtHangSX.Name = "txtHangSX";
            txtHangSX.Size = new Size(222, 27);
            txtHangSX.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 10.2F);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(813, 68);
            label16.Name = "label16";
            label16.Size = new Size(92, 20);
            label16.TabIndex = 13;
            label16.Text = "Thành tiền:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(430, 68);
            label14.Name = "label14";
            label14.Size = new Size(122, 20);
            label14.TabIndex = 9;
            label14.Text = "Hãng sản xuất:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.2F);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(430, 32);
            label15.Name = "label15";
            label15.Size = new Size(120, 20);
            label15.TabIndex = 8;
            label15.Text = "Số lượng nhập:";
            // 
            // txtTenHH
            // 
            txtTenHH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenHH.Location = new Point(136, 61);
            txtTenHH.Name = "txtTenHH";
            txtTenHH.Size = new Size(251, 27);
            txtTenHH.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.2F);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(15, 68);
            label13.Name = "label13";
            label13.Size = new Size(115, 20);
            label13.TabIndex = 5;
            label13.Text = "Tên hàng hóa:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(15, 32);
            label12.Name = "label12";
            label12.Size = new Size(110, 20);
            label12.TabIndex = 4;
            label12.Text = "Mã hàng hóa:";
            // 
            // txtTongTien_BangSo
            // 
            txtTongTien_BangSo.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTongTien_BangSo.Location = new Point(184, 377);
            txtTongTien_BangSo.Name = "txtTongTien_BangSo";
            txtTongTien_BangSo.Size = new Size(301, 27);
            txtTongTien_BangSo.TabIndex = 3;
            // 
            // lblTongTien_BangChu
            // 
            lblTongTien_BangChu.AutoSize = true;
            lblTongTien_BangChu.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblTongTien_BangChu.ForeColor = SystemColors.ActiveCaptionText;
            lblTongTien_BangChu.Location = new Point(15, 418);
            lblTongTien_BangChu.Name = "lblTongTien_BangChu";
            lblTongTien_BangChu.Size = new Size(168, 20);
            lblTongTien_BangChu.TabIndex = 2;
            lblTongTien_BangChu.Text = "Tổng tiền (bằng chữ):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(15, 384);
            label11.Name = "label11";
            label11.Size = new Size(159, 20);
            label11.TabIndex = 1;
            label11.Text = "Tổng tiền (bằng số):";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvDSHangHoaNhap);
            groupBox6.Location = new Point(15, 105);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1141, 263);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách hàng hóa nhập";
            // 
            // dgvDSHangHoaNhap
            // 
            dgvDSHangHoaNhap.AllowUserToAddRows = false;
            dgvDSHangHoaNhap.AllowUserToDeleteRows = false;
            dgvDSHangHoaNhap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSHangHoaNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSHangHoaNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSHangHoaNhap.Location = new Point(23, 26);
            dgvDSHangHoaNhap.MultiSelect = false;
            dgvDSHangHoaNhap.Name = "dgvDSHangHoaNhap";
            dgvDSHangHoaNhap.RowHeadersWidth = 51;
            dgvDSHangHoaNhap.Size = new Size(1101, 222);
            dgvDSHangHoaNhap.TabIndex = 0;
            dgvDSHangHoaNhap.Click += dgvDSHangHoaNhap_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.Location = new Point(12, 811);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 35);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SkyBlue;
            btnLuu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnLuu.ForeColor = SystemColors.ActiveCaptionText;
            btnLuu.Location = new Point(183, 811);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(138, 35);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = SystemColors.ActiveCaptionText;
            btnXoa.Location = new Point(359, 811);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 35);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDSPhieuNhap
            // 
            btnDSPhieuNhap.BackColor = Color.SkyBlue;
            btnDSPhieuNhap.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDSPhieuNhap.ForeColor = SystemColors.ActiveCaptionText;
            btnDSPhieuNhap.Location = new Point(707, 811);
            btnDSPhieuNhap.Name = "btnDSPhieuNhap";
            btnDSPhieuNhap.Size = new Size(138, 35);
            btnDSPhieuNhap.TabIndex = 5;
            btnDSPhieuNhap.Text = "DS phiếu ";
            btnDSPhieuNhap.UseVisualStyleBackColor = false;
            btnDSPhieuNhap.Click += btnDSPhieuNhap_Click;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.SkyBlue;
            btnIn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnIn.ForeColor = SystemColors.ActiveCaptionText;
            btnIn.Location = new Point(882, 811);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(138, 35);
            btnIn.TabIndex = 6;
            btnIn.Text = "In ";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnDatLai
            // 
            btnDatLai.BackColor = Color.SkyBlue;
            btnDatLai.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDatLai.ForeColor = SystemColors.ActiveCaptionText;
            btnDatLai.Location = new Point(535, 811);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(138, 35);
            btnDatLai.TabIndex = 7;
            btnDatLai.Text = "Đặt lại";
            btnDatLai.UseVisualStyleBackColor = false;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(1051, 811);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 35);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmPhieuNhapHang
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1212, 866);
            Controls.Add(btnThoat);
            Controls.Add(btnDatLai);
            Controls.Add(btnIn);
            Controls.Add(btnDSPhieuNhap);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPhieuNhapHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu Nhập Hàng";
            Load += frmPhieuNhapHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSHangHoaNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnDSPhieuNhap;
        private Button btnIn;
        private Button btnDatLai;
        private Button btnThoat;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Label label1;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpNgayLap;
        private TextBox txtMaPhieu;
        private TextBox txtEmail;
        private TextBox txtSDT_NCC;
        private TextBox txtDiaChi;
        private TextBox txtTenNCC;
        private ComboBox cbMaNCC;
        private TextBox txtTenNV;
        private TextBox txtSDT_NV;
        private GroupBox groupBox6;
        private Label lblTongTien_BangChu;
        private Label label11;
        private TextBox txtTongTien_BangSo;
        private TextBox txtDGNhap;
        private TextBox txtThanhTien;
        private Label label16;
        private Label label17;
        private TextBox txtSLNhap;
        private TextBox txtHangSX;
        private Label label14;
        private Label label15;
        private TextBox txtTenHH;
        private Label label13;
        private Label label12;
        private ComboBox cbMaNV;
        private ComboBox cbMaHH;
        private DataGridView dgvDSHangHoaNhap;
    }
}