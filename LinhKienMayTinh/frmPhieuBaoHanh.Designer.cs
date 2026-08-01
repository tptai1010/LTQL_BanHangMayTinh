namespace LinhKienMayTinh
{
    partial class frmPhieuBaoHanh
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
            dtpNgayLap = new DateTimePicker();
            txtMaPhieu = new TextBox();
            cbTGBaoHanh = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtDiaChi = new TextBox();
            label13 = new Label();
            txtSDT_KH = new TextBox();
            txtTenKH = new TextBox();
            cbMaKH = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            txtTenHH = new TextBox();
            cbMaHH = new ComboBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox4 = new GroupBox();
            txtSDT_NV = new TextBox();
            label16 = new Label();
            txtTenNV = new TextBox();
            cbMaNV = new ComboBox();
            label10 = new Label();
            label14 = new Label();
            label15 = new Label();
            btnThem = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnIn = new Button();
            btnThoat = new Button();
            groupBox5 = new GroupBox();
            btnHuyTK = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            cbNoiDungTK = new ComboBox();
            label17 = new Label();
            btnDatLai = new Button();
            groupBox6 = new GroupBox();
            dgvDSPhieuBaoHanh = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieuBaoHanh).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(txtMaPhieu);
            groupBox1.Controls.Add(cbTGBaoHanh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu bảo hành";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Font = new Font("Microsoft Sans Serif", 10.2F);
            dtpNgayLap.Location = new Point(138, 64);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(320, 27);
            dtpNgayLap.TabIndex = 6;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtMaPhieu.Location = new Point(138, 24);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(320, 27);
            txtMaPhieu.TabIndex = 5;
            // 
            // cbTGBaoHanh
            // 
            cbTGBaoHanh.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbTGBaoHanh.FormattingEnabled = true;
            cbTGBaoHanh.Location = new Point(138, 104);
            cbTGBaoHanh.Name = "cbTGBaoHanh";
            cbTGBaoHanh.Size = new Size(320, 28);
            cbTGBaoHanh.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(22, 71);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày lập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(22, 112);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "TG bảo hành:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(22, 71);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtSDT_KH);
            groupBox2.Controls.Add(txtTenKH);
            groupBox2.Controls.Add(cbMaKH);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(495, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 188);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtDiaChi.Location = new Point(159, 146);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(299, 27);
            txtDiaChi.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.2F);
            label13.Location = new Point(22, 153);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 7;
            label13.Text = "Địa chỉ:";
            // 
            // txtSDT_KH
            // 
            txtSDT_KH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSDT_KH.Location = new Point(159, 105);
            txtSDT_KH.Name = "txtSDT_KH";
            txtSDT_KH.Size = new Size(299, 27);
            txtSDT_KH.TabIndex = 6;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenKH.Location = new Point(159, 64);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(299, 27);
            txtTenKH.TabIndex = 5;
            // 
            // cbMaKH
            // 
            cbMaKH.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbMaKH.FormattingEnabled = true;
            cbMaKH.Location = new Point(159, 23);
            cbMaKH.Name = "cbMaKH";
            cbMaKH.Size = new Size(299, 28);
            cbMaKH.TabIndex = 4;
            cbMaKH.TextChanged += cbMaKH_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(22, 71);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 3;
            label5.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(22, 112);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 2;
            label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.Location = new Point(22, 71);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F);
            label8.Location = new Point(22, 31);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 0;
            label8.Text = "Mã khách hàng:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTenHH);
            groupBox3.Controls.Add(cbMaHH);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(495, 206);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(473, 112);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin hàng hóa";
            // 
            // txtTenHH
            // 
            txtTenHH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenHH.Location = new Point(143, 64);
            txtTenHH.Name = "txtTenHH";
            txtTenHH.Size = new Size(315, 27);
            txtTenHH.TabIndex = 5;
            // 
            // cbMaHH
            // 
            cbMaHH.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbMaHH.FormattingEnabled = true;
            cbMaHH.Location = new Point(143, 23);
            cbMaHH.Name = "cbMaHH";
            cbMaHH.Size = new Size(315, 28);
            cbMaHH.TabIndex = 4;
            cbMaHH.TextChanged += cbMaHH_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F);
            label9.Location = new Point(22, 71);
            label9.Name = "label9";
            label9.Size = new Size(115, 20);
            label9.TabIndex = 3;
            label9.Text = "Tên hàng hóa:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F);
            label11.Location = new Point(22, 71);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F);
            label12.Location = new Point(22, 31);
            label12.Name = "label12";
            label12.Size = new Size(110, 20);
            label12.TabIndex = 0;
            label12.Text = "Mã hàng hóa:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtSDT_NV);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(txtTenNV);
            groupBox4.Controls.Add(cbMaNV);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label15);
            groupBox4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(12, 174);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(473, 144);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nhân viên";
            // 
            // txtSDT_NV
            // 
            txtSDT_NV.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSDT_NV.Location = new Point(143, 102);
            txtSDT_NV.Name = "txtSDT_NV";
            txtSDT_NV.Size = new Size(315, 27);
            txtSDT_NV.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 10.2F);
            label16.Location = new Point(22, 109);
            label16.Name = "label16";
            label16.Size = new Size(111, 20);
            label16.TabIndex = 6;
            label16.Text = "Số điện thoại:";
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenNV.Location = new Point(143, 64);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(315, 27);
            txtTenNV.TabIndex = 5;
            // 
            // cbMaNV
            // 
            cbMaNV.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbMaNV.FormattingEnabled = true;
            cbMaNV.Location = new Point(143, 23);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(315, 28);
            cbMaNV.TabIndex = 4;
            cbMaNV.TextChanged += cbMaNV_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F);
            label10.Location = new Point(22, 71);
            label10.Name = "label10";
            label10.Size = new Size(118, 20);
            label10.TabIndex = 3;
            label10.Text = "Tên nhân viên:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F);
            label14.Location = new Point(22, 71);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.2F);
            label15.Location = new Point(22, 31);
            label15.Name = "label15";
            label15.Size = new Size(113, 20);
            label15.TabIndex = 0;
            label15.Text = "Mã nhân viên:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThem.Location = new Point(984, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(139, 34);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SkyBlue;
            btnLuu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnLuu.Location = new Point(984, 83);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(139, 34);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SkyBlue;
            btnSua.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnSua.Location = new Point(984, 137);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(139, 34);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnXoa.Location = new Point(984, 191);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(139, 34);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.SkyBlue;
            btnIn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnIn.Location = new Point(984, 300);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(139, 34);
            btnIn.TabIndex = 13;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThoat.Location = new Point(984, 355);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(139, 34);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnHuyTK);
            groupBox5.Controls.Add(btnTimKiem);
            groupBox5.Controls.Add(txtTimKiem);
            groupBox5.Controls.Add(cbNoiDungTK);
            groupBox5.Controls.Add(label17);
            groupBox5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(12, 324);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(956, 65);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm kiếm";
            // 
            // btnHuyTK
            // 
            btnHuyTK.BackColor = Color.SkyBlue;
            btnHuyTK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnHuyTK.Location = new Point(821, 17);
            btnHuyTK.Name = "btnHuyTK";
            btnHuyTK.Size = new Size(120, 32);
            btnHuyTK.TabIndex = 27;
            btnHuyTK.Text = "Hủy";
            btnHuyTK.UseVisualStyleBackColor = false;
            btnHuyTK.Click += btnHuyTK_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SkyBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnTimKiem.Location = new Point(695, 18);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 32);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTimKiem.Location = new Point(367, 18);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(306, 32);
            txtTimKiem.TabIndex = 2;
            // 
            // cbNoiDungTK
            // 
            cbNoiDungTK.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbNoiDungTK.FormattingEnabled = true;
            cbNoiDungTK.Location = new Point(176, 23);
            cbNoiDungTK.Name = "cbNoiDungTK";
            cbNoiDungTK.Size = new Size(185, 28);
            cbNoiDungTK.TabIndex = 1;
            cbNoiDungTK.SelectedIndexChanged += cbNoiDungTK_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10.2F);
            label17.Location = new Point(22, 31);
            label17.Name = "label17";
            label17.Size = new Size(148, 20);
            label17.TabIndex = 0;
            label17.Text = "Nội dung tìm kiếm:";
            // 
            // btnDatLai
            // 
            btnDatLai.BackColor = Color.SkyBlue;
            btnDatLai.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDatLai.Location = new Point(984, 245);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(139, 34);
            btnDatLai.TabIndex = 17;
            btnDatLai.Text = "Đặt lại";
            btnDatLai.UseVisualStyleBackColor = false;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvDSPhieuBaoHanh);
            groupBox6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(12, 395);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1111, 279);
            groupBox6.TabIndex = 18;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách phiếu bảo hành";
            // 
            // dgvDSPhieuBaoHanh
            // 
            dgvDSPhieuBaoHanh.AllowUserToAddRows = false;
            dgvDSPhieuBaoHanh.AllowUserToDeleteRows = false;
            dgvDSPhieuBaoHanh.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSPhieuBaoHanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSPhieuBaoHanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhieuBaoHanh.Location = new Point(22, 26);
            dgvDSPhieuBaoHanh.MultiSelect = false;
            dgvDSPhieuBaoHanh.Name = "dgvDSPhieuBaoHanh";
            dgvDSPhieuBaoHanh.RowHeadersWidth = 51;
            dgvDSPhieuBaoHanh.Size = new Size(1068, 231);
            dgvDSPhieuBaoHanh.TabIndex = 0;
            dgvDSPhieuBaoHanh.Click += dgvDSPhieuBaoHanh_Click;
            // 
            // frmPhieuBaoHanh
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1139, 686);
            Controls.Add(groupBox6);
            Controls.Add(btnDatLai);
            Controls.Add(groupBox5);
            Controls.Add(btnThoat);
            Controls.Add(btnIn);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10.2F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPhieuBaoHanh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu bảo hành";
            Load += frmPhieuBaoHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieuBaoHanh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMaPhieu;
        private ComboBox cbTGBaoHanh;
        private Label label4;
        private DateTimePicker dtpNgayLap;
        private GroupBox groupBox2;
        private TextBox txtTenKH;
        private ComboBox cbMaKH;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private TextBox txtTenHH;
        private ComboBox cbMaHH;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox txtDiaChi;
        private Label label13;
        private TextBox txtSDT_KH;
        private GroupBox groupBox4;
        private TextBox txtTenNV;
        private ComboBox cbMaNV;
        private Label label10;
        private Label label14;
        private Label label15;
        private TextBox txtSDT_NV;
        private Label label16;
        private Button btnThem;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnIn;
        private Button btnThoat;
        private GroupBox groupBox5;
        private Button btnHuyTK;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbNoiDungTK;
        private Label label17;
        private Button btnDatLai;
        private GroupBox groupBox6;
        private DataGridView dgvDSPhieuBaoHanh;
    }
}