namespace LinhKienMayTinh
{
    partial class frmLoaiHH
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
            btnXoa = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            txtSoLuong = new TextBox();
            txtTenLoaiHH = new TextBox();
            txtMaLoaiHH = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            btnHuyTK = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            cbNoiDungTK = new ComboBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            dgvDSLoaiHH = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSLoaiHH).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtTenLoaiHH);
            groupBox1.Controls.Add(txtMaLoaiHH);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(597, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại hàng hóa";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Location = new Point(344, 62);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 31);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Location = new Point(471, 62);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(121, 31);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.SkyBlue;
            btnLuu.Location = new Point(471, 24);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(121, 31);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Location = new Point(344, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(121, 31);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSoLuong.Location = new Point(106, 105);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(207, 27);
            txtSoLuong.TabIndex = 4;
            // 
            // txtTenLoaiHH
            // 
            txtTenLoaiHH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTenLoaiHH.Location = new Point(106, 66);
            txtTenLoaiHH.Name = "txtTenLoaiHH";
            txtTenLoaiHH.Size = new Size(207, 27);
            txtTenLoaiHH.TabIndex = 3;
            // 
            // txtMaLoaiHH
            // 
            txtMaLoaiHH.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtMaLoaiHH.Location = new Point(106, 26);
            txtMaLoaiHH.Name = "txtMaLoaiHH";
            txtMaLoaiHH.Size = new Size(207, 27);
            txtMaLoaiHH.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(21, 112);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng:";
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
            // groupBox5
            // 
            groupBox5.Controls.Add(btnHuyTK);
            groupBox5.Controls.Add(btnTimKiem);
            groupBox5.Controls.Add(txtTimKiem);
            groupBox5.Controls.Add(cbNoiDungTK);
            groupBox5.Controls.Add(label8);
            groupBox5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox5.Location = new Point(615, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(416, 149);
            groupBox5.TabIndex = 17;
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
            cbNoiDungTK.SelectedValueChanged += cbNoiDungTK_SelectedValueChanged;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDSLoaiHH);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1022, 291);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại hàng hóa";
            // 
            // dgvDSLoaiHH
            // 
            dgvDSLoaiHH.AllowUserToAddRows = false;
            dgvDSLoaiHH.AllowUserToDeleteRows = false;
            dgvDSLoaiHH.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSLoaiHH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSLoaiHH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLoaiHH.Location = new Point(21, 26);
            dgvDSLoaiHH.MultiSelect = false;
            dgvDSLoaiHH.Name = "dgvDSLoaiHH";
            dgvDSLoaiHH.RowHeadersWidth = 51;
            dgvDSLoaiHH.Size = new Size(981, 250);
            dgvDSLoaiHH.TabIndex = 0;
            dgvDSLoaiHH.Click += dgvDSLoaiHH_Click;
            // 
            // frmLoaiHH
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1046, 471);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLoaiHH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Mục Loại Hàng Hóa";
            Load += frmLoaiHH_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSLoaiHH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtSoLuong;
        private TextBox txtTenLoaiHH;
        private TextBox txtMaLoaiHH;
        private Label label3;
        private Label label2;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnThem;
        private GroupBox groupBox5;
        private Button btnHuyTK;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbNoiDungTK;
        private Label label8;
        private GroupBox groupBox2;
        private DataGridView dgvDSLoaiHH;
        private Button btnXoa;
    }
}