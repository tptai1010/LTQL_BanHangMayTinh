namespace LinhKienMayTinh
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            menu = new MenuStrip();
            mnDanhMuc = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuHangHoa = new ToolStripMenuItem();
            mnPhanLoaiHH = new ToolStripMenuItem();
            mnNCC = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuPhanLoaiKH = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuPhieuNhap = new ToolStripMenuItem();
            mnuPhieuBaoHanh = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuDoanhThu = new ToolStripMenuItem();
            mnuTonKho = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuBackupRestore = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 129);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 61);
            label2.Name = "label2";
            label2.Size = new Size(243, 52);
            label2.TabIndex = 2;
            label2.Text = "Phát - A_IT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(392, 52);
            label1.TabIndex = 1;
            label1.Text = "Cửa Hàng Máy Tính";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(menu);
            panel2.Font = new Font("Calibri Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(1136, 561);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = BanHangMayTinh.Properties.Resources.anh1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(1143, 524);
            panel3.TabIndex = 1;
            // 
            // menu
            // 
            menu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { mnDanhMuc, mnuHoaDon, mnuPhieuNhap, mnuPhieuBaoHanh, mnuBaoCao, mnuDangNhap, mnuBackupRestore, mnuThoat });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1136, 36);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // mnDanhMuc
            // 
            mnDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuNhanVien, mnuHangHoa, mnNCC, mnuKhachHang });
            mnDanhMuc.Name = "mnDanhMuc";
            mnDanhMuc.Size = new Size(114, 32);
            mnDanhMuc.Text = "Danh mục";
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(218, 32);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuHangHoa
            // 
            mnuHangHoa.DropDownItems.AddRange(new ToolStripItem[] { mnPhanLoaiHH });
            mnuHangHoa.Name = "mnuHangHoa";
            mnuHangHoa.Size = new Size(218, 32);
            mnuHangHoa.Text = "Hàng hóa";
            mnuHangHoa.Click += mnuHangHoa_Click;
            // 
            // mnPhanLoaiHH
            // 
            mnPhanLoaiHH.Name = "mnPhanLoaiHH";
            mnPhanLoaiHH.Size = new Size(178, 32);
            mnPhanLoaiHH.Text = "Phân loại";
            mnPhanLoaiHH.Click += mnPhanLoaiHH_Click;
            // 
            // mnNCC
            // 
            mnNCC.Name = "mnNCC";
            mnNCC.Size = new Size(218, 32);
            mnNCC.Text = "Nhà cung cấp";
            mnNCC.Click += mnNCC_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.DropDownItems.AddRange(new ToolStripItem[] { mnuPhanLoaiKH });
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(218, 32);
            mnuKhachHang.Text = "Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuPhanLoaiKH
            // 
            mnuPhanLoaiKH.Name = "mnuPhanLoaiKH";
            mnuPhanLoaiKH.Size = new Size(178, 32);
            mnuPhanLoaiKH.Text = "Phân loại";
            mnuPhanLoaiKH.Click += mnuPhanLoaiKH_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(102, 32);
            mnuHoaDon.Text = "Hóa đơn";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuPhieuNhap
            // 
            mnuPhieuNhap.Name = "mnuPhieuNhap";
            mnuPhieuNhap.Size = new Size(123, 32);
            mnuPhieuNhap.Text = "Phiếu nhập";
            mnuPhieuNhap.Click += mnuPhieuNhap_Click;
            // 
            // mnuPhieuBaoHanh
            // 
            mnuPhieuBaoHanh.Name = "mnuPhieuBaoHanh";
            mnuPhieuBaoHanh.Size = new Size(161, 32);
            mnuPhieuBaoHanh.Text = "Phiếu bảo hành";
            mnuPhieuBaoHanh.Click += mnuPhieuBaoHanh_Click;
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { mnuDoanhThu, mnuTonKho });
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(95, 32);
            mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuDoanhThu
            // 
            mnuDoanhThu.Name = "mnuDoanhThu";
            mnuDoanhThu.Size = new Size(190, 32);
            mnuDoanhThu.Text = "Doanh thu";
            mnuDoanhThu.Click += mnuDoanhThu_Click;
            // 
            // mnuTonKho
            // 
            mnuTonKho.Name = "mnuTonKho";
            mnuTonKho.Size = new Size(190, 32);
            mnuTonKho.Text = "Tồn kho";
            mnuTonKho.Click += mnuTonKho_Click;
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(209, 32);
            mnuDangNhap.Text = "Thông tin đăng nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuBackupRestore
            // 
            mnuBackupRestore.Name = "mnuBackupRestore";
            mnuBackupRestore.Size = new Size(175, 32);
            mnuBackupRestore.Text = "Sao lưu/Phục hồi";
            mnuBackupRestore.Click += mnuBackupRestore_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(76, 32);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1137, 690);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = menu;
            Name = "frmTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Bán Hàng Máy Tính";
            Load += frmTrangChu_Load;
            Click += frmTrangChu_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private MenuStrip menu;
        private ToolStripMenuItem mnDanhMuc;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuHangHoa;
        private ToolStripMenuItem mnNCC;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuPhieuBaoHanh;
        private ToolStripMenuItem mnuPhieuNhap;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuBackupRestore;
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuDoanhThu;
        private ToolStripMenuItem mnuTonKho;
        private ToolStripMenuItem mnPhanLoaiHH;
        private ToolStripMenuItem mnuPhanLoaiKH;
        private Panel panel3;
    }
}