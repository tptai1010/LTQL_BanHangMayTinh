namespace LinhKienMayTinh
{
    partial class frmNhaCungCap
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtTenNCC = new TextBox();
            txtMaNCC = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnThoat = new Button();
            groupBox3 = new GroupBox();
            btnHuyTK = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            cbNoiDungTK = new ComboBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            dgvDS_NCC = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDS_NCC).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenNCC);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(746, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.SkyBlue;
            btnXuat.Location = new Point(605, 146);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(129, 32);
            btnXuat.TabIndex = 33;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.SkyBlue;
            btnNhap.Location = new Point(456, 146);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(129, 32);
            btnNhap.TabIndex = 32;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.SkyBlue;
            btnHuy.Location = new Point(532, 103);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(129, 32);
            btnHuy.TabIndex = 31;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SkyBlue;
            btnLuu.Location = new Point(605, 24);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 32);
            btnLuu.TabIndex = 30;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Location = new Point(605, 65);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 32);
            btnXoa.TabIndex = 29;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SkyBlue;
            btnSua.Location = new Point(456, 65);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 32);
            btnSua.TabIndex = 28;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Location = new Point(456, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 32);
            btnThem.TabIndex = 27;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtDiaChi.Location = new Point(168, 180);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(272, 27);
            txtDiaChi.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtEmail.Location = new Point(168, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(272, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSDT.Location = new Point(168, 105);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(272, 27);
            txtSDT.TabIndex = 7;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenNCC.Location = new Point(168, 67);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(272, 27);
            txtTenNCC.TabIndex = 6;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtMaNCC.Location = new Point(168, 29);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(272, 27);
            txtMaNCC.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(20, 149);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(20, 112);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(20, 187);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(20, 36);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã nhà cung cấp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(20, 74);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhà cung cấp:";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(879, 161);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(164, 32);
            btnThoat.TabIndex = 28;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuyTK);
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(cbNoiDungTK);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(773, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(358, 143);
            groupBox3.TabIndex = 27;
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
            cbNoiDungTK.SelectedIndexChanged += cbNoiDungTK_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(6, 29);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 0;
            label6.Text = "Nội dung tìm kiếm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDS_NCC);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1119, 328);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // dgvDS_NCC
            // 
            dgvDS_NCC.AllowUserToAddRows = false;
            dgvDS_NCC.AllowUserToDeleteRows = false;
            dgvDS_NCC.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDS_NCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDS_NCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDS_NCC.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDS_NCC.Location = new Point(19, 26);
            dgvDS_NCC.MultiSelect = false;
            dgvDS_NCC.Name = "dgvDS_NCC";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDS_NCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDS_NCC.RowHeadersWidth = 51;
            dgvDS_NCC.Size = new Size(1087, 287);
            dgvDS_NCC.TabIndex = 0;
            dgvDS_NCC.Click += dgvDS_NCC_Click;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1149, 581);
            Controls.Add(groupBox2);
            Controls.Add(btnThoat);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Mục Nhà Cung Cấp";
            Load += frmNCC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDS_NCC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtTenNCC;
        private TextBox txtMaNCC;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnThoat;
        private GroupBox groupBox3;
        private Button btnHuyTK;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbNoiDungTK;
        private Label label6;
        private GroupBox groupBox2;
        private DataGridView dgvDS_NCC;
    }
}