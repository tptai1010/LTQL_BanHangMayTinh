namespace LinhKienMayTinh
{
    partial class frmHoaDon
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
            groupBox4 = new GroupBox();
            txtTenNV = new TextBox();
            txtSDT_NV = new TextBox();
            label5 = new Label();
            cbMaNV = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            txtTenKH = new TextBox();
            txtTongTienDaMua = new TextBox();
            txtLoaiKH = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT_KH = new TextBox();
            cbMaKH = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtMaHD = new TextBox();
            dtpNgayLapHD = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            txtChietKhau = new TextBox();
            label19 = new Label();
            txtTongTien_BangSo = new TextBox();
            txtThanhTien = new TextBox();
            txtDGBan = new TextBox();
            txtHangSX = new TextBox();
            txtSoLuongMua = new TextBox();
            txtTenHH = new TextBox();
            cbMaHH = new ComboBox();
            lblTongTien_BangChu = new Label();
            label18 = new Label();
            groupBox6 = new GroupBox();
            dgvDSHangHoaMua = new DataGridView();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnDSHoaDon = new Button();
            btnInHD = new Button();
            btnThoat = new Button();
            btnDatLai = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSHangHoaMua).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.MediumBlue;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1177, 321);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTenNV);
            groupBox4.Controls.Add(txtSDT_NV);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(cbMaNV);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(15, 143);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(561, 155);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nhân viên bán hàng";
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenNV.Location = new Point(166, 67);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(377, 27);
            txtTenNV.TabIndex = 4;
            // 
            // txtSDT_NV
            // 
            txtSDT_NV.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSDT_NV.Location = new Point(166, 106);
            txtSDT_NV.Name = "txtSDT_NV";
            txtSDT_NV.Size = new Size(377, 27);
            txtSDT_NV.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(18, 113);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 2;
            label5.Text = "SDT nhân viên:";
            // 
            // cbMaNV
            // 
            cbMaNV.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbMaNV.FormattingEnabled = true;
            cbMaNV.Location = new Point(166, 27);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(377, 28);
            cbMaNV.TabIndex = 3;
            cbMaNV.TextChanged += cbMaNV_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(18, 74);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(18, 35);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã nhân viên:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTenKH);
            groupBox3.Controls.Add(txtTongTienDaMua);
            groupBox3.Controls.Add(txtLoaiKH);
            groupBox3.Controls.Add(txtDiaChi);
            groupBox3.Controls.Add(txtSDT_KH);
            groupBox3.Controls.Add(cbMaKH);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox3.ForeColor = SystemColors.ActiveCaptionText;
            groupBox3.Location = new Point(597, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(561, 272);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenKH.Location = new Point(171, 67);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(373, 27);
            txtTenKH.TabIndex = 10;
            // 
            // txtTongTienDaMua
            // 
            txtTongTienDaMua.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTongTienDaMua.Location = new Point(171, 223);
            txtTongTienDaMua.Name = "txtTongTienDaMua";
            txtTongTienDaMua.Size = new Size(373, 27);
            txtTongTienDaMua.TabIndex = 9;
            // 
            // txtLoaiKH
            // 
            txtLoaiKH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtLoaiKH.Location = new Point(171, 184);
            txtLoaiKH.Name = "txtLoaiKH";
            txtLoaiKH.Size = new Size(373, 27);
            txtLoaiKH.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtDiaChi.Location = new Point(171, 149);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(373, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtSDT_KH
            // 
            txtSDT_KH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSDT_KH.Location = new Point(171, 110);
            txtSDT_KH.Name = "txtSDT_KH";
            txtSDT_KH.Size = new Size(373, 27);
            txtSDT_KH.TabIndex = 6;
            // 
            // cbMaKH
            // 
            cbMaKH.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbMaKH.FormattingEnabled = true;
            cbMaKH.Location = new Point(171, 27);
            cbMaKH.Name = "cbMaKH";
            cbMaKH.Size = new Size(373, 28);
            cbMaKH.TabIndex = 4;
            cbMaKH.TextChanged += cbMaKH_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F);
            label11.Location = new Point(29, 230);
            label11.Name = "label11";
            label11.Size = new Size(143, 20);
            label11.TabIndex = 5;
            label11.Text = "Tổng tiền đã mua:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F);
            label10.Location = new Point(29, 191);
            label10.Name = "label10";
            label10.Size = new Size(136, 20);
            label10.TabIndex = 4;
            label10.Text = "Loại khách hàng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F);
            label9.Location = new Point(29, 152);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 3;
            label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F);
            label8.Location = new Point(29, 117);
            label8.Name = "label8";
            label8.Size = new Size(138, 20);
            label8.TabIndex = 2;
            label8.Text = "SDT khách hàng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.Location = new Point(29, 74);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 1;
            label7.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(29, 35);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 0;
            label6.Text = "Mã khách hàng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMaHD);
            groupBox2.Controls.Add(dtpNgayLapHD);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(15, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 111);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn";
            // 
            // txtMaHD
            // 
            txtMaHD.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtMaHD.Location = new Point(166, 28);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(377, 27);
            txtMaHD.TabIndex = 3;
            // 
            // dtpNgayLapHD
            // 
            dtpNgayLapHD.Font = new Font("Microsoft Sans Serif", 10.2F);
            dtpNgayLapHD.Location = new Point(167, 67);
            dtpNgayLapHD.Name = "dtpNgayLapHD";
            dtpNgayLapHD.Size = new Size(376, 27);
            dtpNgayLapHD.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(18, 74);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày lập hóa đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(18, 35);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtChietKhau);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(txtTongTien_BangSo);
            groupBox5.Controls.Add(txtThanhTien);
            groupBox5.Controls.Add(txtDGBan);
            groupBox5.Controls.Add(txtHangSX);
            groupBox5.Controls.Add(txtSoLuongMua);
            groupBox5.Controls.Add(txtTenHH);
            groupBox5.Controls.Add(cbMaHH);
            groupBox5.Controls.Add(lblTongTien_BangChu);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox5.ForeColor = Color.MediumBlue;
            groupBox5.Location = new Point(12, 339);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1177, 502);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chi tiết hóa đơn";
            // 
            // txtChietKhau
            // 
            txtChietKhau.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtChietKhau.ForeColor = SystemColors.ActiveCaptionText;
            txtChietKhau.Location = new Point(102, 385);
            txtChietKhau.Name = "txtChietKhau";
            txtChietKhau.Size = new Size(190, 27);
            txtChietKhau.TabIndex = 15;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(15, 392);
            label19.Name = "label19";
            label19.Size = new Size(81, 20);
            label19.TabIndex = 14;
            label19.Text = "Giảm giá:";
            // 
            // txtTongTien_BangSo
            // 
            txtTongTien_BangSo.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTongTien_BangSo.ForeColor = SystemColors.ActiveCaptionText;
            txtTongTien_BangSo.Location = new Point(196, 420);
            txtTongTien_BangSo.Name = "txtTongTien_BangSo";
            txtTongTien_BangSo.Size = new Size(326, 27);
            txtTongTien_BangSo.TabIndex = 13;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtThanhTien.ForeColor = SystemColors.ActiveCaptionText;
            txtThanhTien.Location = new Point(907, 63);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(234, 27);
            txtThanhTien.TabIndex = 12;
            // 
            // txtDGBan
            // 
            txtDGBan.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtDGBan.ForeColor = SystemColors.ActiveCaptionText;
            txtDGBan.Location = new Point(907, 24);
            txtDGBan.Name = "txtDGBan";
            txtDGBan.Size = new Size(234, 27);
            txtDGBan.TabIndex = 11;
            // 
            // txtHangSX
            // 
            txtHangSX.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtHangSX.ForeColor = SystemColors.ActiveCaptionText;
            txtHangSX.Location = new Point(528, 63);
            txtHangSX.Name = "txtHangSX";
            txtHangSX.Size = new Size(234, 27);
            txtHangSX.TabIndex = 10;
            // 
            // txtSoLuongMua
            // 
            txtSoLuongMua.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSoLuongMua.ForeColor = SystemColors.ActiveCaptionText;
            txtSoLuongMua.Location = new Point(528, 24);
            txtSoLuongMua.Name = "txtSoLuongMua";
            txtSoLuongMua.Size = new Size(234, 27);
            txtSoLuongMua.TabIndex = 9;
            txtSoLuongMua.TextChanged += txtSoLuong_TextChanged;
            // 
            // txtTenHH
            // 
            txtTenHH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenHH.ForeColor = SystemColors.ActiveCaptionText;
            txtTenHH.Location = new Point(131, 63);
            txtTenHH.Name = "txtTenHH";
            txtTenHH.Size = new Size(234, 27);
            txtTenHH.TabIndex = 6;
            // 
            // cbMaHH
            // 
            cbMaHH.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbMaHH.ForeColor = SystemColors.ActiveCaptionText;
            cbMaHH.FormattingEnabled = true;
            cbMaHH.Location = new Point(131, 24);
            cbMaHH.Name = "cbMaHH";
            cbMaHH.Size = new Size(234, 28);
            cbMaHH.TabIndex = 6;
            cbMaHH.TextChanged += cbMaHH_TextChanged;
            // 
            // lblTongTien_BangChu
            // 
            lblTongTien_BangChu.AutoSize = true;
            lblTongTien_BangChu.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblTongTien_BangChu.ForeColor = SystemColors.ActiveCaptionText;
            lblTongTien_BangChu.Location = new Point(15, 462);
            lblTongTien_BangChu.Name = "lblTongTien_BangChu";
            lblTongTien_BangChu.Size = new Size(173, 20);
            lblTongTien_BangChu.TabIndex = 8;
            lblTongTien_BangChu.Text = "Tổng tiền (bằng chữ): ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 10.2F);
            label18.ForeColor = SystemColors.ActiveCaptionText;
            label18.Location = new Point(15, 427);
            label18.Name = "label18";
            label18.Size = new Size(159, 20);
            label18.TabIndex = 7;
            label18.Text = "Tổng tiền (bằng số):";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvDSHangHoaMua);
            groupBox6.ForeColor = SystemColors.ActiveCaptionText;
            groupBox6.Location = new Point(15, 104);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1143, 263);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách hàng hóa mua";
            // 
            // dgvDSHangHoaMua
            // 
            dgvDSHangHoaMua.AllowUserToAddRows = false;
            dgvDSHangHoaMua.AllowUserToDeleteRows = false;
            dgvDSHangHoaMua.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSHangHoaMua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSHangHoaMua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSHangHoaMua.Location = new Point(18, 26);
            dgvDSHangHoaMua.MultiSelect = false;
            dgvDSHangHoaMua.Name = "dgvDSHangHoaMua";
            dgvDSHangHoaMua.RowHeadersWidth = 51;
            dgvDSHangHoaMua.Size = new Size(1106, 220);
            dgvDSHangHoaMua.TabIndex = 0;
            dgvDSHangHoaMua.Click += dgvDSHangHoaMua_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10.2F);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(794, 70);
            label17.Name = "label17";
            label17.Size = new Size(92, 20);
            label17.TabIndex = 5;
            label17.Text = "Thành tiền:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 10.2F);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(794, 32);
            label16.Name = "label16";
            label16.Size = new Size(103, 20);
            label16.TabIndex = 4;
            label16.Text = "Đơn giá bán:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.2F);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(400, 70);
            label15.Name = "label15";
            label15.Size = new Size(122, 20);
            label15.TabIndex = 3;
            label15.Text = "Hãng sản xuất:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(400, 31);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 2;
            label14.Text = "Số lượng:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.2F);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(15, 70);
            label13.Name = "label13";
            label13.Size = new Size(115, 20);
            label13.TabIndex = 1;
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
            label12.TabIndex = 0;
            label12.Text = "Mã hàng hóa:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThem.Location = new Point(12, 862);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(157, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SkyBlue;
            btnLuu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnLuu.Location = new Point(175, 862);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(157, 34);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnXoa.Location = new Point(338, 862);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(157, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDSHoaDon
            // 
            btnDSHoaDon.BackColor = Color.SkyBlue;
            btnDSHoaDon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDSHoaDon.Location = new Point(706, 862);
            btnDSHoaDon.Name = "btnDSHoaDon";
            btnDSHoaDon.Size = new Size(157, 34);
            btnDSHoaDon.TabIndex = 5;
            btnDSHoaDon.Text = "DS Hóa đơn";
            btnDSHoaDon.UseVisualStyleBackColor = false;
            btnDSHoaDon.Click += btnDSHoaDon_Click;
            // 
            // btnInHD
            // 
            btnInHD.BackColor = Color.SkyBlue;
            btnInHD.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnInHD.Location = new Point(869, 862);
            btnInHD.Name = "btnInHD";
            btnInHD.Size = new Size(157, 34);
            btnInHD.TabIndex = 6;
            btnInHD.Text = "In hóa đơn";
            btnInHD.UseVisualStyleBackColor = false;
            btnInHD.Click += btnInHD_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThoat.Location = new Point(1032, 862);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(157, 34);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDatLai
            // 
            btnDatLai.BackColor = Color.SkyBlue;
            btnDatLai.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDatLai.Location = new Point(521, 862);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(157, 34);
            btnDatLai.TabIndex = 8;
            btnDatLai.Text = "Đặt lại";
            btnDatLai.UseVisualStyleBackColor = false;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1201, 908);
            Controls.Add(btnDatLai);
            Controls.Add(btnThoat);
            Controls.Add(btnInHD);
            Controls.Add(btnDSHoaDon);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa Đơn Bán Hàng";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSHangHoaMua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label lblTongTien_BangChu;
        private Label label18;
        private GroupBox groupBox6;
        private DataGridView dgvDSHangHoaMua;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnDSHoaDon;
        private Button btnInHD;
        private Button btnThoat;
        private TextBox txtTenNV;
        private TextBox txtSDT_NV;
        private ComboBox cbMaNV;
        private TextBox txtTenKH;
        private TextBox txtTongTienDaMua;
        private TextBox txtLoaiKH;
        private TextBox txtDiaChi;
        private TextBox txtSDT_KH;
        private ComboBox cbMaKH;
        private TextBox txtMaHD;
        private DateTimePicker dtpNgayLapHD;
        private ComboBox cbMaHH;
        private TextBox txtTongTien_BangSo;
        private TextBox txtThanhTien;
        private TextBox txtDGBan;
        private TextBox txtHangSX;
        private TextBox txtSoLuongMua;
        private TextBox txtTenHH;
        private TextBox txtChietKhau;
        private Label label19;
        private Button btnDatLai;
    }
}