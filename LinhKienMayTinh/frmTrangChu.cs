using BanHangMayTinh;
using BanHangMayTinh.Reports;
using LinhKienMayTinh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using LinhKienMayTinh.Data;

namespace LinhKienMayTinh
{
    public partial class frmTrangChu : Form
    {
        private string currentUsername;
        private string currentUserRole;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmTrangChu(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
            logger.Info($"Đăng nhập thành công: {currentUsername}");
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongTinDN frmTTDN = new frmThongTinDN(currentUsername); 
            frmTTDN.FormClosed += (s, args) => { this.Show(); };
            frmTTDN.ShowDialog();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            Task.Run(() => Functions.AutoBackupCuonChieu(currentUsername));

            using (var context = new LKMTdbContext())
            {
                var user = context.TaiKhoan.FirstOrDefault(u => u.Username == currentUsername);
                if (user != null)
                    currentUserRole = user.QuyenHan;
            }
            PhanQuyen();
        }

        private void PhanQuyen()
        {
            if (currentUserRole == "NhanVien")
            {
                mnuNhanVien.Enabled = false;
                mnuKhachHang.Enabled = false;
                mnNCC.Enabled = false;
                mnuBackupRestore.Enabled = false;
            }
            else if (currentUserRole == "QuanLy")
            {
                mnuNhanVien.Enabled = false;
                mnuBackupRestore.Enabled = false;
            }
        }

        private void frmTrangChu_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien frmNhanVien = new frmNhanVien(currentUsername);
            frmNhanVien.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frmNhanVien.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHangHoa frmHangHoa = new frmHangHoa(currentUsername);
            frmHangHoa.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frmHangHoa.ShowDialog();
        }

        private void mnPhanLoaiHH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoaiHH frmLoaiHH = new frmLoaiHH(currentUsername);
            frmLoaiHH.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frmLoaiHH.ShowDialog();
        }

        private void mnNCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhaCungCap frmNCC = new frmNhaCungCap(currentUsername);
            frmNCC.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frmNCC.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHang frmKhachHang = new frmKhachHang(currentUsername);
            frmKhachHang.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frmKhachHang.ShowDialog();
        }

        private void mnuPhanLoaiKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoaiKH frmLoaiKH = new frmLoaiKH(currentUsername);
            frmLoaiKH.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frmLoaiKH.ShowDialog();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDon frmHoaDon = new frmHoaDon(currentUsername);
            frmHoaDon.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frmHoaDon.ShowDialog();
        }

        private void mnuPhieuNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPhieuNhapHang frmPhieuNhap = new frmPhieuNhapHang(currentUsername);
            frmPhieuNhap.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frmPhieuNhap.ShowDialog();
        }

        private void mnuPhieuBaoHanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPhieuBaoHanh frmPBH = new frmPhieuBaoHanh(currentUsername);
            frmPBH.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frmPBH.ShowDialog();
        }

        private void mnuTonKho_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKeHangHoa frmThongKe = new frmThongKeHangHoa();
            frmThongKe.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frmThongKe.ShowDialog();
        }

        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKeDoanhThu frmThongKe = new frmThongKeDoanhThu();
            frmThongKe.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frmThongKe.ShowDialog();
        }

        private void mnuBackupRestore_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBackupRestore frm = new frmBackupRestore(currentUsername);
            frm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frm.ShowDialog();
        }
    }
}
