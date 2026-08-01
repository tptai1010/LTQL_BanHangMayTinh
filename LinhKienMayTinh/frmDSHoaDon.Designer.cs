namespace LinhKienMayTinh
{
    partial class frmDSHoaDon
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
            groupBox3 = new GroupBox();
            btnHuyTK = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            cbNoiDungTK = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dgvDSHoaDon = new DataGridView();
            btnXoa = new Button();
            btnXuat = new Button();
            btnThoat = new Button();
            btnXemThem = new Button();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSHoaDon).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHuyTK);
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(cbNoiDungTK);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 394);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(358, 140);
            groupBox3.TabIndex = 29;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDSHoaDon);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(968, 376);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn bán hàng";
            // 
            // dgvDSHoaDon
            // 
            dgvDSHoaDon.AllowUserToAddRows = false;
            dgvDSHoaDon.AllowUserToDeleteRows = false;
            dgvDSHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDSHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDSHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSHoaDon.Location = new Point(16, 26);
            dgvDSHoaDon.Margin = new Padding(4, 3, 4, 3);
            dgvDSHoaDon.MultiSelect = false;
            dgvDSHoaDon.Name = "dgvDSHoaDon";
            dgvDSHoaDon.RowHeadersWidth = 51;
            dgvDSHoaDon.Size = new Size(933, 333);
            dgvDSHoaDon.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = SystemColors.ControlText;
            btnXoa.Location = new Point(422, 410);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 33);
            btnXoa.TabIndex = 31;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.SkyBlue;
            btnXuat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnXuat.ForeColor = SystemColors.ControlText;
            btnXuat.Location = new Point(629, 410);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 33);
            btnXuat.TabIndex = 32;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.ControlText;
            btnThoat.Location = new Point(727, 457);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 33);
            btnThoat.TabIndex = 34;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXemThem
            // 
            btnXemThem.BackColor = Color.SkyBlue;
            btnXemThem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnXemThem.ForeColor = SystemColors.ControlText;
            btnXemThem.Location = new Point(525, 457);
            btnXemThem.Name = "btnXemThem";
            btnXemThem.Size = new Size(150, 33);
            btnXemThem.TabIndex = 35;
            btnXemThem.Text = "Xem thêm";
            btnXemThem.UseVisualStyleBackColor = false;
            btnXemThem.Click += btnXemThem_Click;
            // 
            // frmDSHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1004, 549);
            Controls.Add(btnXemThem);
            Controls.Add(btnThoat);
            Controls.Add(btnXuat);
            Controls.Add(btnXoa);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDSHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Sách Hóa Đơn Bán Hàng";
            TopMost = true;
            Load += frmDSHoaDon_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox3;
        private Button btnHuyTK;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbNoiDungTK;
        private Label label4;
        private GroupBox groupBox1;
        private DataGridView dgvDSHoaDon;
        private Button btnXoa;
        private Button btnXuat;
        private Button btnThoat;
        private Button btnXemThem;
    }
}