namespace LinhKienMayTinh
{
    partial class frmChamCong
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
            groupBox1 = new GroupBox();
            txtChucVu = new TextBox();
            label7 = new Label();
            txtTenNV = new TextBox();
            cbMaNV = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtMaChamCong = new TextBox();
            label9 = new Label();
            txtSoGioLamThem = new TextBox();
            cbNam = new ComboBox();
            cbThang = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            dgvDSLuong = new DataGridView();
            groupBox4 = new GroupBox();
            btnTinhLuong = new Button();
            txtTongLuong = new TextBox();
            lblTongLuong = new Label();
            label6 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            groupBox5 = new GroupBox();
            btnHuyTK = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            cbNoiDungTK = new ComboBox();
            label8 = new Label();
            btnNhap = new Button();
            btnXuat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSLuong).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChucVu);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(cbMaNV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(628, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtChucVu
            // 
            txtChucVu.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtChucVu.Location = new Point(370, 29);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(156, 27);
            txtChucVu.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.Location = new Point(289, 36);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 4;
            label7.Text = "Chức vụ:";
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenNV.Location = new Point(138, 66);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(388, 27);
            txtTenNV.TabIndex = 3;
            // 
            // cbMaNV
            // 
            cbMaNV.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbMaNV.FormattingEnabled = true;
            cbMaNV.Location = new Point(138, 26);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(145, 28);
            cbMaNV.TabIndex = 2;
            cbMaNV.SelectedIndexChanged += cbMaNV_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(19, 36);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMaChamCong);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtSoGioLamThem);
            groupBox2.Controls.Add(cbNam);
            groupBox2.Controls.Add(cbThang);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 117);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chấm công";
            // 
            // txtMaChamCong
            // 
            txtMaChamCong.Location = new Point(160, 25);
            txtMaChamCong.Name = "txtMaChamCong";
            txtMaChamCong.Size = new Size(163, 27);
            txtMaChamCong.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 35);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 6;
            label9.Text = "Mã chấm công:";
            // 
            // txtSoGioLamThem
            // 
            txtSoGioLamThem.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSoGioLamThem.Location = new Point(160, 65);
            txtSoGioLamThem.Name = "txtSoGioLamThem";
            txtSoGioLamThem.Size = new Size(163, 27);
            txtSoGioLamThem.TabIndex = 5;
            // 
            // cbNam
            // 
            cbNam.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbNam.FormattingEnabled = true;
            cbNam.Location = new Point(413, 65);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(173, 28);
            cbNam.TabIndex = 3;
            // 
            // cbThang
            // 
            cbThang.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbThang.FormattingEnabled = true;
            cbThang.Location = new Point(413, 25);
            cbThang.Name = "cbThang";
            cbThang.Size = new Size(173, 28);
            cbThang.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(19, 73);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 4;
            label5.Text = "Số giờ làm thêm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(347, 72);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Năm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(347, 35);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 0;
            label4.Text = "Tháng:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvDSLuong);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 325);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1161, 280);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách lương nhân viên:";
            // 
            // dgvDSLuong
            // 
            dgvDSLuong.AllowUserToAddRows = false;
            dgvDSLuong.AllowUserToDeleteRows = false;
            dgvDSLuong.AllowUserToResizeRows = false;
            dgvDSLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLuong.Location = new Point(19, 26);
            dgvDSLuong.MultiSelect = false;
            dgvDSLuong.Name = "dgvDSLuong";
            dgvDSLuong.RowHeadersWidth = 51;
            dgvDSLuong.Size = new Size(1125, 237);
            dgvDSLuong.TabIndex = 0;
            dgvDSLuong.Click += dgvDSLuong_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnTinhLuong);
            groupBox4.Controls.Add(txtTongLuong);
            groupBox4.Controls.Add(lblTongLuong);
            groupBox4.Controls.Add(label6);
            groupBox4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox4.Location = new Point(12, 135);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(721, 100);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tính lương";
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.BackColor = Color.Silver;
            btnTinhLuong.Location = new Point(592, 26);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(123, 29);
            btnTinhLuong.TabIndex = 11;
            btnTinhLuong.Text = "Tính lương";
            btnTinhLuong.UseVisualStyleBackColor = false;
            btnTinhLuong.Click += btnTinhLuong_Click;
            // 
            // txtTongLuong
            // 
            txtTongLuong.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTongLuong.Location = new Point(197, 26);
            txtTongLuong.Name = "txtTongLuong";
            txtTongLuong.Size = new Size(389, 27);
            txtTongLuong.TabIndex = 10;
            // 
            // lblTongLuong
            // 
            lblTongLuong.AutoEllipsis = true;
            lblTongLuong.AutoSize = true;
            lblTongLuong.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblTongLuong.Location = new Point(19, 69);
            lblTongLuong.Name = "lblTongLuong";
            lblTongLuong.Size = new Size(85, 20);
            lblTongLuong.TabIndex = 9;
            lblTongLuong.Text = "Bằng chữ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(19, 33);
            label6.Name = "label6";
            label6.Size = new Size(172, 20);
            label6.TabIndex = 8;
            label6.Text = "Tổng lương (bằng số):";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThem.Location = new Point(12, 243);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(159, 36);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnXoa.Location = new Point(200, 243);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(159, 36);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SkyBlue;
            btnLuu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnLuu.Location = new Point(382, 243);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(159, 36);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.SkyBlue;
            btnHuy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnHuy.Location = new Point(574, 243);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(159, 36);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThoat.Location = new Point(474, 285);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(159, 36);
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
            groupBox5.Controls.Add(label8);
            groupBox5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox5.Location = new Point(757, 136);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(416, 193);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm kiếm";
            // 
            // btnHuyTK
            // 
            btnHuyTK.BackColor = Color.Silver;
            btnHuyTK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnHuyTK.Location = new Point(160, 149);
            btnHuyTK.Name = "btnHuyTK";
            btnHuyTK.Size = new Size(159, 36);
            btnHuyTK.TabIndex = 27;
            btnHuyTK.Text = "Hủy";
            btnHuyTK.UseVisualStyleBackColor = false;
            btnHuyTK.Click += btnHuyTK_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Silver;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnTimKiem.Location = new Point(160, 107);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(159, 36);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTimKiem.Location = new Point(6, 61);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(393, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // cbNoiDungTK
            // 
            cbNoiDungTK.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbNoiDungTK.FormattingEnabled = true;
            cbNoiDungTK.Location = new Point(160, 21);
            cbNoiDungTK.Name = "cbNoiDungTK";
            cbNoiDungTK.Size = new Size(239, 28);
            cbNoiDungTK.TabIndex = 1;
            cbNoiDungTK.SelectedIndexChanged += cbNoiDungTK_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F);
            label8.Location = new Point(6, 29);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 0;
            label8.Text = "Nội dung tìm kiếm:";
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.SkyBlue;
            btnNhap.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnNhap.Location = new Point(108, 285);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(159, 36);
            btnNhap.TabIndex = 17;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.SkyBlue;
            btnXuat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnXuat.Location = new Point(292, 285);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(159, 36);
            btnXuat.TabIndex = 18;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // frmChamCong
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1185, 620);
            Controls.Add(btnXuat);
            Controls.Add(btnNhap);
            Controls.Add(groupBox5);
            Controls.Add(btnLuu);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmChamCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chấm Công Khách Hàng";
            Load += frmChamCong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSLuong).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTenNV;
        private ComboBox cbMaNV;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cbNam;
        private ComboBox cbThang;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSoGioLamThem;
        private GroupBox groupBox3;
        private DataGridView dgvDSLuong;
        private GroupBox groupBox4;
        private TextBox txtTongLuong;
        private Label lblTongLuong;
        private Label label6;
        private Label label7;
        private Button btnThem;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private TextBox txtChucVu;
        private GroupBox groupBox5;
        private Button btnHuyTK;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbNoiDungTK;
        private Label label8;
        private Button btnNhap;
        private Button btnXuat;
        private TextBox txtMaChamCong;
        private Label label9;
        private Button btnTinhLuong;
    }
}