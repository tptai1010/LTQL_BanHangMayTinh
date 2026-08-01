namespace LinhKienMayTinh
{
    partial class frmLoaiKH
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
            dgvDSLoaiKH = new DataGridView();
            btnThoat = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            txtChietKhau = new TextBox();
            txtTenLoaiKH = new TextBox();
            txtMaLoaiKH = new TextBox();
            label3 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            cbNoiDungTK = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            groupBox5 = new GroupBox();
            btnHuyTK = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSLoaiKH).BeginInit();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDSLoaiKH
            // 
            dgvDSLoaiKH.AllowUserToAddRows = false;
            dgvDSLoaiKH.AllowUserToDeleteRows = false;
            dgvDSLoaiKH.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSLoaiKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSLoaiKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLoaiKH.Location = new Point(21, 26);
            dgvDSLoaiKH.MultiSelect = false;
            dgvDSLoaiKH.Name = "dgvDSLoaiKH";
            dgvDSLoaiKH.RowHeadersWidth = 51;
            dgvDSLoaiKH.Size = new Size(981, 250);
            dgvDSLoaiKH.TabIndex = 0;
            dgvDSLoaiKH.CellFormatting += dgvDSLoaiKH_CellFormatting;
            dgvDSLoaiKH.Click += dgvDSLoaiKH_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Location = new Point(463, 64);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 31);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SkyBlue;
            btnLuu.Location = new Point(463, 24);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(128, 31);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Location = new Point(329, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(128, 31);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtChietKhau
            // 
            txtChietKhau.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtChietKhau.Location = new Point(120, 105);
            txtChietKhau.Name = "txtChietKhau";
            txtChietKhau.Size = new Size(186, 27);
            txtChietKhau.TabIndex = 4;
            txtChietKhau.Leave += txtChietKhau_Leave;
            // 
            // txtTenLoaiKH
            // 
            txtTenLoaiKH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenLoaiKH.Location = new Point(120, 66);
            txtTenLoaiKH.Name = "txtTenLoaiKH";
            txtTenLoaiKH.Size = new Size(186, 27);
            txtTenLoaiKH.TabIndex = 3;
            // 
            // txtMaLoaiKH
            // 
            txtMaLoaiKH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtMaLoaiKH.Location = new Point(120, 26);
            txtMaLoaiKH.Name = "txtMaLoaiKH";
            txtMaLoaiKH.Size = new Size(186, 27);
            txtMaLoaiKH.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(21, 112);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Chiết khấu:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Silver;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnTimKiem.Location = new Point(217, 94);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(21, 73);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên loại:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnHuyTK);
            groupBox5.Controls.Add(btnTimKiem);
            groupBox5.Controls.Add(txtTimKiem);
            groupBox5.Controls.Add(cbNoiDungTK);
            groupBox5.Controls.Add(label8);
            groupBox5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox5.Location = new Point(618, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(416, 149);
            groupBox5.TabIndex = 20;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm kiếm";
            // 
            // btnHuyTK
            // 
            btnHuyTK.BackColor = Color.Silver;
            btnHuyTK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnHuyTK.Location = new Point(37, 94);
            btnHuyTK.Name = "btnHuyTK";
            btnHuyTK.Size = new Size(159, 36);
            btnHuyTK.TabIndex = 27;
            btnHuyTK.Text = "Hủy";
            btnHuyTK.UseVisualStyleBackColor = false;
            btnHuyTK.Click += btnHuyTK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã loại:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDSLoaiKH);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1022, 291);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại hàng hóa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtChietKhau);
            groupBox1.Controls.Add(txtTenLoaiKH);
            groupBox1.Controls.Add(txtMaLoaiKH);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 149);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại hàng hóa";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Location = new Point(329, 101);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(128, 31);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SkyBlue;
            btnSua.Location = new Point(329, 64);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(128, 31);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // frmLoaiKH
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1050, 473);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLoaiKH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Mục Loại Khách Hàng";
            Load += frmLoaiKH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSLoaiKH).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDSLoaiKH;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnThem;
        private TextBox txtChietKhau;
        private TextBox txtTenLoaiKH;
        private TextBox txtMaLoaiKH;
        private Label label3;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbNoiDungTK;
        private Label label8;
        private Label label2;
        private GroupBox groupBox5;
        private Button btnHuyTK;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnXoa;
    }
}