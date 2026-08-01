namespace LinhKienMayTinh
{
    partial class frmThongTinDN
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
            btnThoat = new Button();
            btnSua = new Button();
            label6 = new Label();
            btnShowPassword = new Button();
            mtxtPassword = new MaskedTextBox();
            txtQuyenHan = new TextBox();
            txtNgaySinh = new TextBox();
            txtUsername = new TextBox();
            txtHoTen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grDSTaiKhoan = new GroupBox();
            btnXoa = new Button();
            groupBox4 = new GroupBox();
            btnHuyTK = new Button();
            txtTimKiem = new TextBox();
            label7 = new Label();
            btnTimKiem = new Button();
            groupBox3 = new GroupBox();
            cbQuyen = new ComboBox();
            label8 = new Label();
            btnDoiQuyen = new Button();
            dgvDSTaiKhoan = new DataGridView();
            groupBox1.SuspendLayout();
            grDSTaiKhoan.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnShowPassword);
            groupBox1.Controls.Add(mtxtPassword);
            groupBox1.Controls.Add(txtQuyenHan);
            groupBox1.Controls.Add(txtNgaySinh);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1037, 194);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin người dùng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Location = new Point(865, 88);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(144, 34);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SkyBlue;
            btnSua.Location = new Point(865, 34);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(144, 34);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(495, 142);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 11;
            label6.Text = "Show password";
            // 
            // btnShowPassword
            // 
            btnShowPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnShowPassword.Location = new Point(451, 128);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(38, 34);
            btnShowPassword.TabIndex = 10;
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // mtxtPassword
            // 
            mtxtPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            mtxtPassword.Location = new Point(547, 88);
            mtxtPassword.Name = "mtxtPassword";
            mtxtPassword.Size = new Size(281, 27);
            mtxtPassword.TabIndex = 9;
            // 
            // txtQuyenHan
            // 
            txtQuyenHan.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtQuyenHan.Location = new Point(127, 128);
            txtQuyenHan.Multiline = true;
            txtQuyenHan.Name = "txtQuyenHan";
            txtQuyenHan.Size = new Size(281, 34);
            txtQuyenHan.TabIndex = 8;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtNgaySinh.Location = new Point(547, 34);
            txtNgaySinh.Multiline = true;
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(281, 34);
            txtNgaySinh.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtUsername.Location = new Point(127, 81);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(281, 34);
            txtUsername.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtHoTen.Location = new Point(127, 34);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(281, 34);
            txtHoTen.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(451, 95);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(451, 48);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(30, 142);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Quyền hạn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(30, 95);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(30, 48);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // grDSTaiKhoan
            // 
            grDSTaiKhoan.Controls.Add(btnXoa);
            grDSTaiKhoan.Controls.Add(groupBox4);
            grDSTaiKhoan.Controls.Add(groupBox3);
            grDSTaiKhoan.Controls.Add(dgvDSTaiKhoan);
            grDSTaiKhoan.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grDSTaiKhoan.Location = new Point(12, 212);
            grDSTaiKhoan.Name = "grDSTaiKhoan";
            grDSTaiKhoan.Size = new Size(1037, 317);
            grDSTaiKhoan.TabIndex = 1;
            grDSTaiKhoan.TabStop = false;
            grDSTaiKhoan.Text = "Danh sách tài khoản";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Location = new Point(835, 269);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(154, 35);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnHuyTK);
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(btnTimKiem);
            groupBox4.Location = new Point(640, 141);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(369, 109);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // btnHuyTK
            // 
            btnHuyTK.BackColor = Color.SkyBlue;
            btnHuyTK.Location = new Point(16, 68);
            btnHuyTK.Name = "btnHuyTK";
            btnHuyTK.Size = new Size(154, 35);
            btnHuyTK.TabIndex = 4;
            btnHuyTK.Text = "Hủy";
            btnHuyTK.UseVisualStyleBackColor = false;
            btnHuyTK.Click += btnHuyTK_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTimKiem.Location = new Point(152, 22);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(197, 34);
            txtTimKiem.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.Location = new Point(16, 36);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 2;
            label7.Text = "Username:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.SkyBlue;
            btnTimKiem.Location = new Point(195, 68);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(154, 35);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbQuyen);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnDoiQuyen);
            groupBox3.Location = new Point(640, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(369, 109);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Đổi quyền";
            // 
            // cbQuyen
            // 
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Location = new Point(152, 23);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(197, 28);
            cbQuyen.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F);
            label8.Location = new Point(16, 31);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 1;
            label8.Text = "Cập nhật quyền:";
            // 
            // btnDoiQuyen
            // 
            btnDoiQuyen.BackColor = Color.SkyBlue;
            btnDoiQuyen.Location = new Point(195, 68);
            btnDoiQuyen.Name = "btnDoiQuyen";
            btnDoiQuyen.Size = new Size(154, 35);
            btnDoiQuyen.TabIndex = 0;
            btnDoiQuyen.Text = "Đổi quyền";
            btnDoiQuyen.UseVisualStyleBackColor = false;
            btnDoiQuyen.Click += btnDoiQuyen_Click;
            // 
            // dgvDSTaiKhoan
            // 
            dgvDSTaiKhoan.AllowUserToAddRows = false;
            dgvDSTaiKhoan.AllowUserToDeleteRows = false;
            dgvDSTaiKhoan.AllowUserToResizeRows = false;
            dgvDSTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSTaiKhoan.Location = new Point(15, 26);
            dgvDSTaiKhoan.MultiSelect = false;
            dgvDSTaiKhoan.Name = "dgvDSTaiKhoan";
            dgvDSTaiKhoan.RowHeadersWidth = 51;
            dgvDSTaiKhoan.Size = new Size(599, 263);
            dgvDSTaiKhoan.TabIndex = 0;
            // 
            // frmThongTinDN
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1066, 541);
            Controls.Add(grDSTaiKhoan);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThongTinDN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Đăng Nhập";
            Load += frmThongTinDN_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grDSTaiKhoan.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnSua;
        private Label label6;
        private Button btnShowPassword;
        private MaskedTextBox mtxtPassword;
        private TextBox txtQuyenHan;
        private TextBox txtNgaySinh;
        private TextBox txtUsername;
        private TextBox txtHoTen;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grDSTaiKhoan;
        private Button btnXoa;
        private GroupBox groupBox4;
        private TextBox txtTimKiem;
        private Label label7;
        private Button btnTimKiem;
        private GroupBox groupBox3;
        private Label label8;
        private Button btnDoiQuyen;
        private DataGridView dgvDSTaiKhoan;
        private ComboBox cbQuyen;
        private Button btnHuyTK;
    }
}