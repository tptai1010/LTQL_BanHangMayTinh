namespace LinhKienMayTinh
{
    partial class frmKhachHang
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
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtSoTienDaMua = new TextBox();
            txtTimKiem = new TextBox();
            cbNoiDungTK = new ComboBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            rbtnNu = new RadioButton();
            rbtnNam = new RadioButton();
            txtDiaChi = new TextBox();
            groupBox4 = new GroupBox();
            dgvDSKhachHang = new DataGridView();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            txtMaKH = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtLoaiKH = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            btnHuyTK = new Button();
            btnLoaiKH = new Button();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSKhachHang).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(870, 226);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(164, 32);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SkyBlue;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnTimKiem.Location = new Point(39, 96);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(129, 32);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.SkyBlue;
            btnXuat.Location = new Point(574, 218);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(129, 32);
            btnXuat.TabIndex = 26;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.SkyBlue;
            btnNhap.Location = new Point(425, 218);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(129, 32);
            btnNhap.TabIndex = 25;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.SkyBlue;
            btnHuy.Location = new Point(501, 175);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(129, 32);
            btnHuy.TabIndex = 24;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SkyBlue;
            btnLuu.Location = new Point(579, 96);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 32);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Location = new Point(579, 137);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 32);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SkyBlue;
            btnSua.Location = new Point(425, 137);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 32);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Location = new Point(425, 96);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 32);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtSoTienDaMua
            // 
            txtSoTienDaMua.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSoTienDaMua.Location = new Point(149, 180);
            txtSoTienDaMua.Name = "txtSoTienDaMua";
            txtSoTienDaMua.Size = new Size(239, 27);
            txtSoTienDaMua.TabIndex = 19;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTimKiem.Location = new Point(6, 63);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(339, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // cbNoiDungTK
            // 
            cbNoiDungTK.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbNoiDungTK.FormattingEnabled = true;
            cbNoiDungTK.Location = new Point(160, 21);
            cbNoiDungTK.Name = "cbNoiDungTK";
            cbNoiDungTK.Size = new Size(185, 28);
            cbNoiDungTK.TabIndex = 1;
            cbNoiDungTK.SelectedIndexChanged += cbNoiDungTK_SelectedndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(6, 29);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 0;
            label4.Text = "Nội dung tìm kiếm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtnNu);
            groupBox2.Controls.Add(rbtnNam);
            groupBox2.Location = new Point(425, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 64);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giới tính";
            // 
            // rbtnNu
            // 
            rbtnNu.AutoSize = true;
            rbtnNu.Font = new Font("Microsoft Sans Serif", 10.2F);
            rbtnNu.Location = new Point(154, 26);
            rbtnNu.Name = "rbtnNu";
            rbtnNu.Size = new Size(51, 24);
            rbtnNu.TabIndex = 15;
            rbtnNu.TabStop = true;
            rbtnNu.Text = "Nữ";
            rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            rbtnNam.AutoSize = true;
            rbtnNam.Font = new Font("Microsoft Sans Serif", 10.2F);
            rbtnNam.Location = new Point(41, 26);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(65, 24);
            rbtnNam.TabIndex = 14;
            rbtnNam.TabStop = true;
            rbtnNam.Text = "Nam";
            rbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtDiaChi.Location = new Point(148, 101);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(239, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvDSKhachHang);
            groupBox4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(13, 301);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1107, 375);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách khách hàng";
            // 
            // dgvDSKhachHang
            // 
            dgvDSKhachHang.AllowUserToAddRows = false;
            dgvDSKhachHang.AllowUserToDeleteRows = false;
            dgvDSKhachHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSKhachHang.Location = new Point(17, 26);
            dgvDSKhachHang.MultiSelect = false;
            dgvDSKhachHang.Name = "dgvDSKhachHang";
            dgvDSKhachHang.RowHeadersWidth = 51;
            dgvDSKhachHang.Size = new Size(1077, 331);
            dgvDSKhachHang.TabIndex = 0;
            dgvDSKhachHang.Click += dgvDSKhachHang_Click;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSDT.Location = new Point(148, 142);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(239, 27);
            txtSDT.TabIndex = 15;
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenKH.Location = new Point(148, 63);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(239, 27);
            txtTenKH.TabIndex = 10;
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtMaKH.Location = new Point(148, 26);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(239, 27);
            txtMaKH.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F);
            label9.Location = new Point(17, 187);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 8;
            label9.Text = "Số tiền đã mua:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(17, 149);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(17, 108);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(17, 70);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLoaiKH);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtSoTienDaMua);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(13, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(728, 274);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtLoaiKH
            // 
            txtLoaiKH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtLoaiKH.Location = new Point(149, 221);
            txtLoaiKH.Name = "txtLoaiKH";
            txtLoaiKH.Size = new Size(239, 27);
            txtLoaiKH.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.Location = new Point(17, 228);
            label7.Name = "label7";
            label7.Size = new Size(136, 20);
            label7.TabIndex = 6;
            label7.Text = "Loại khách hàng:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuyTK);
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(cbNoiDungTK);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(762, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(358, 140);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // btnHuyTK
            // 
            btnHuyTK.BackColor = Color.SkyBlue;
            btnHuyTK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnHuyTK.Location = new Point(194, 96);
            btnHuyTK.Name = "btnHuyTK";
            btnHuyTK.Size = new Size(129, 32);
            btnHuyTK.TabIndex = 27;
            btnHuyTK.Text = "Hủy";
            btnHuyTK.UseVisualStyleBackColor = false;
            btnHuyTK.Click += btnHuyTK_Click;
            // 
            // btnLoaiKH
            // 
            btnLoaiKH.BackColor = Color.SkyBlue;
            btnLoaiKH.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoaiKH.Location = new Point(870, 180);
            btnLoaiKH.Name = "btnLoaiKH";
            btnLoaiKH.Size = new Size(164, 35);
            btnLoaiKH.TabIndex = 32;
            btnLoaiKH.Text = "Phân loại";
            btnLoaiKH.UseVisualStyleBackColor = false;
            btnLoaiKH.Click += btnLoaiKH_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1147, 688);
            Controls.Add(btnLoaiKH);
            Controls.Add(btnThoat);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Mục Khách Hàng";
            Load += frmKhachHang_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSKhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtSoTienDaMua;
        private TextBox txtTimKiem;
        private ComboBox cbNoiDungTK;
        private Label label4;
        private GroupBox groupBox2;
        private RadioButton rbtnNu;
        private RadioButton rbtnNam;
        private TextBox txtDiaChi;
        private GroupBox groupBox4;
        private DataGridView dgvDSKhachHang;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Label label9;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private GroupBox groupBox3;
        private Button btnHuyTK;
        private Button btnLoaiKH;
        private TextBox txtLoaiKH;
    }
}