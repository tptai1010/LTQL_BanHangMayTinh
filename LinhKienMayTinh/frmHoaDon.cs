using BanHangMayTinh.Reports;
using LinhKienMayTinh.Class;
using LinhKienMayTinh.Data;
using Microsoft.EntityFrameworkCore;
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

namespace LinhKienMayTinh
{
    public partial class frmHoaDon : Form
    {
        private DataTable tblCTHD = new DataTable();
        private string currentUserRole;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmHoaDon(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var danhSachCTHD = context.CTHD
                    .Include(ct => ct.HangHoa)
                    .Where(ct => ct.MaHD == txtMaHD.Text.Trim())
                    .Select(ct => new
                    {
                        ct.MaHH,
                        TenHH = ct.HangHoa.TenHH,
                        ct.SoLuong,
                        ct.HangHoa.HangSX,
                        ct.DGBan,
                        ct.ThanhTien
                    })
                    .ToList();

                dgvDSHangHoaMua.DataSource = danhSachCTHD;
            }

            dgvDSHangHoaMua.Columns[0].HeaderText = "Mã hàng hóa";
            dgvDSHangHoaMua.Columns[0].Width = 150;
            dgvDSHangHoaMua.Columns[1].HeaderText = "Tên hàng hóa";
            dgvDSHangHoaMua.Columns[1].Width = 250;
            dgvDSHangHoaMua.Columns[2].HeaderText = "Số lượng";
            dgvDSHangHoaMua.Columns[2].Width = 100;
            dgvDSHangHoaMua.Columns[3].HeaderText = "Hãng sản xuất";
            dgvDSHangHoaMua.Columns[3].Width = 150;
            dgvDSHangHoaMua.Columns[4].HeaderText = "Đơn giá bán";
            dgvDSHangHoaMua.Columns[4].Width = 200;
            dgvDSHangHoaMua.Columns[5].HeaderText = "Thành tiền";
            dgvDSHangHoaMua.Columns[5].Width = 200;

            dgvDSHangHoaMua.AllowUserToAddRows = false;
            dgvDSHangHoaMua.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;

            txtMaHD.ReadOnly = true;

            txtTenNV.ReadOnly = true;
            txtSDT_NV.ReadOnly = true;

            txtTenKH.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT_KH.ReadOnly = true;
            txtLoaiKH.ReadOnly = true;
            txtTongTienDaMua.ReadOnly = true;

            txtTenHH.ReadOnly = true;
            txtSoLuongMua.ReadOnly = true;
            txtDGBan.ReadOnly = true;
            txtHangSX.ReadOnly = true;
            txtThanhTien.ReadOnly = true;

            txtTongTien_BangSo.ReadOnly = true;
            txtTongTien_BangSo.Text = "0";
            txtChietKhau.ReadOnly = true;
            txtChietKhau.Text = "0";

            using (var context = new LKMTdbContext())
            {
                var danhSachKH = context.KhachHang
                    .Select(kh => new { kh.MaKH })
                    .ToList();
                cbMaKH.DataSource = danhSachKH;
                cbMaKH.DisplayMember = "MaKH";
                cbMaKH.ValueMember = "MaKH";
                cbMaKH.SelectedIndex = -1;

                var danhSachNV = context.NhanVien
                    .Select(nv => new { nv.MaNV })
                    .ToList();
                cbMaNV.DataSource = danhSachNV;
                cbMaNV.DisplayMember = "MaNV";
                cbMaNV.ValueMember = "MaNV";
               // cbMaNV.SelectedIndex = -1;

                var danhSachHH = context.HangHoa
                    .Select(hh => new { hh.MaHH })
                    .ToList();
                cbMaHH.DataSource = danhSachHH;
                cbMaHH.DisplayMember = "MaHH";
                cbMaHH.ValueMember = "MaHH";
                cbMaHH.SelectedIndex = -1;
            }

            LoadMaNVTheoQuyen();

            if (!string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                LoadInfoHoaDon();
                btnXoa.Enabled = true;
            }
            LoadDataGridView();

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
            if (currentUserRole == "QuanLy" || currentUserRole == "Admin")
            {
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }

        private void LoadInfoHoaDon()
        {
            using (var context = new LKMTdbContext())
            {
                var hoaDon = context.HoaDon.FirstOrDefault(hd => hd.MaHD == txtMaHD.Text.Trim());
                if (hoaDon != null)
                {
                    dtpNgayLapHD.Value = hoaDon.NgayLapHD;
                    cbMaNV.Text = hoaDon.MaNV;
                    cbMaKH.Text = hoaDon.MaKH;
                    txtTongTien_BangSo.Text = hoaDon.TongTien.ToString();
                    lblTongTien_BangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongTien_BangSo.Text);
                }
            }
        }

        private void LoadNhanVienInfo(string maNV)
        {
            using (var context = new LKMTdbContext())
            {
                var nhanVien = context.NhanVien.FirstOrDefault(nv => nv.MaNV == maNV);
                if (nhanVien != null)
                {
                    txtTenNV.Text = nhanVien.TenNV;
                    txtSDT_NV.Text = nhanVien.SDT;
                }
                else
                {
                    txtTenNV.Text = "";
                    txtSDT_NV.Text = "";
                }
            }
        }
        private void LoadMaNVTheoQuyen()
        {
            using (var context = new LKMTdbContext())
            {
                var nvList = context.NhanVien.Select(nv => new { nv.MaNV }).ToList();
                cbMaNV.DataSource = nvList;
                cbMaNV.DisplayMember = "MaNV";
                cbMaNV.ValueMember = "MaNV";

                var user = context.TaiKhoan.FirstOrDefault(u => u.Username == currentUsername);
                if (user != null)
                {
                    currentUserRole = user.QuyenHan;

                    if (currentUserRole == "Admin")
                        cbMaNV.SelectedValue = "NV001";
                    else if (currentUserRole == "NhanVien")
                        cbMaNV.SelectedValue = "NV002";
                    else if (currentUserRole == "QuanLy")
                        cbMaNV.SelectedValue = "NV005";

                    LoadNhanVienInfo(cbMaNV.SelectedValue.ToString());
                }
            }
        }

        private void dgvDSHangHoaMua_Click(object sender, EventArgs e)
        {
            if (dgvDSHangHoaMua.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvDSHangHoaMua.CurrentRow != null)
            {
                string maHH = dgvDSHangHoaMua.CurrentRow.Cells["MaHH"].Value.ToString();
                cbMaHH.SelectedValue = maHH;
                LoadChiTietHangHoa(maHH);
            }

            PhanQuyen();
        }
        private void LoadChiTietHangHoa(string maHH)
        {
            using (var context = new LKMTdbContext())
            {
                var chiTietHangHoa = context.CTHD
                    .Where(ct => ct.MaHH == maHH && ct.MaHD == txtMaHD.Text.Trim())
                    .Select(ct => new
                    {
                        ct.MaHH,
                        TenHH = ct.HangHoa.TenHH,
                        ct.SoLuong,
                        HangSX = ct.HangHoa.HangSX,
                        ct.DGBan,
                        ct.ThanhTien
                    })
                    .FirstOrDefault();

                if (chiTietHangHoa != null)
                {
                    txtTenHH.Text = chiTietHangHoa.TenHH;
                    txtSoLuongMua.Text = chiTietHangHoa.SoLuong.ToString();
                    txtHangSX.Text = chiTietHangHoa.HangSX;
                    txtDGBan.Text = chiTietHangHoa.DGBan.ToString("F0");
                    txtThanhTien.Text = chiTietHangHoa.ThanhTien.ToString("F0");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaHD.Enabled = true;
            txtMaHD.ReadOnly = false;
            txtSoLuongMua.ReadOnly = false;
            txtMaHD.Focus();

            ResetValues();
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaHD.Text = "";
            dtpNgayLapHD.Text = DateTime.Now.ToShortDateString();

            //cbMaNV.SelectedIndex = -1;
            //txtTenNV.Text = "";
            //txtSDT_NV.Text = "";
            LoadMaNVTheoQuyen();

            cbMaKH.SelectedIndex = -1;
            txtTenKH.Text = "";
            txtLoaiKH.Text = "";
            txtSDT_KH.Text = "";
            txtDiaChi.Text = "";
            txtTongTienDaMua.Text = "0";

            txtTongTien_BangSo.Text = "0";
            lblTongTien_BangChu.Text = "Bằng chữ: ";
            txtChietKhau.Text = "0";

            cbMaHH.SelectedIndex = -1;
            txtTenHH.Text = "";
            txtSoLuongMua.Text = "";
            txtHangSX.Text = "";
            txtDGBan.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction()) 
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtMaHD.Text))
                    {
                        MessageBox.Show("Bạn phải nhập mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (cbMaHH.SelectedValue == null || string.IsNullOrWhiteSpace(txtSoLuongMua.Text))
                    {
                        MessageBox.Show("Bạn phải chọn mã hàng và nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int soLuong;
                    if (!int.TryParse(txtSoLuongMua.Text, out soLuong) || soLuong <= 0)
                    {
                        MessageBox.Show("Số lượng mua không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    decimal donGiaBan;
                    if (!decimal.TryParse(txtDGBan.Text, out donGiaBan) || donGiaBan <= 0)
                    {
                        MessageBox.Show("Đơn giá bán không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var hoaDon = context.HoaDon.FirstOrDefault(hd => hd.MaHD == txtMaHD.Text.Trim());
                    if (hoaDon == null)
                    {
                        hoaDon = new HoaDon
                        {
                            MaHD = txtMaHD.Text.Trim(),
                            MaKH = cbMaKH.SelectedValue.ToString(),
                            MaNV = cbMaNV.SelectedValue.ToString(),
                            NgayLapHD = dtpNgayLapHD.Value,
                            TongTien = 0
                        };
                        context.HoaDon.Add(hoaDon);
                    }

                    var hangHoa = context.HangHoa.FirstOrDefault(hh => hh.MaHH == cbMaHH.SelectedValue.ToString());
                    if (hangHoa == null)
                    {
                        MessageBox.Show("Mã hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    decimal thanhTien = soLuong * donGiaBan;
                    txtThanhTien.Text = thanhTien.ToString("F0");

                    var cthd = new CTHD
                    {
                        MaHD = hoaDon.MaHD,
                        MaHH = hangHoa.MaHH,
                        SoLuong = soLuong,
                        DGBan = donGiaBan,
                        ThanhTien = thanhTien
                    };
                    context.CTHD.Add(cthd);

                    hangHoa.SoLuong -= soLuong;

                    var loaiHH = context.LoaiHH.FirstOrDefault(lh => lh.MaLoaiHH == hangHoa.MaLoaiHH);
                    if (loaiHH != null)
                    {
                        loaiHH.SoLuong = context.HangHoa.Where(hh => hh.MaLoaiHH == loaiHH.MaLoaiHH).Sum(hh => hh.SoLuong);
                    }

                    var khachHang = context.KhachHang.FirstOrDefault(kh => kh.MaKH == hoaDon.MaKH);
                    if (khachHang != null)
                    {
                        khachHang.SoTienMua += thanhTien;
                        khachHang.MaLoaiKH = Functions.GetMaLoaiKHTheoTien(khachHang.SoTienMua); 
                    }

                    decimal chietKhau = 0;
                    var loaiKH = context.LoaiKH.FirstOrDefault(lk => lk.MaLoaiKH == khachHang.MaLoaiKH);
                    if (loaiKH != null)
                    {
                        chietKhau = thanhTien * (loaiKH.ChietKhau / 100); 
                    }

                    hoaDon.TongTien += (thanhTien - chietKhau);
                    txtChietKhau.Text = chietKhau.ToString("F0");
                    txtTongTien_BangSo.Text = hoaDon.TongTien.ToString("F0");
                    lblTongTien_BangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongTien_BangSo.Text);

                    logger.Info($"Người dùng {currentUsername} đã lập hóa đơn.");
                    context.SaveChanges();
                    transaction.Commit();

                    LoadDataGridView();
                    ResetValuesHang();
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetValuesHang()
        {
            cbMaHH.Text = "";
            txtDGBan.Text = "0";
            txtHangSX.Text = "";
            txtTenHH.Text = "";
            txtSoLuongMua.Text = "";
            txtThanhTien.Text = "0";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text) || string.IsNullOrWhiteSpace(cbMaHH.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction()) 
            {
                try
                {
                    var cthd = context.CTHD.FirstOrDefault(ct => ct.MaHD == txtMaHD.Text.Trim() && ct.MaHH == cbMaHH.Text.Trim());
                    if (cthd == null)
                    {
                        MessageBox.Show("Không tìm thấy chi tiết hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var hangHoa = context.HangHoa.FirstOrDefault(hh => hh.MaHH == cbMaHH.Text.Trim());
                    if (hangHoa != null)
                    {
                        hangHoa.SoLuong += cthd.SoLuong;
                    }

                    var loaiHH = context.LoaiHH.FirstOrDefault(lh => lh.MaLoaiHH == hangHoa.MaLoaiHH);
                    if (loaiHH != null)
                    {
                        loaiHH.SoLuong += cthd.SoLuong;
                    }

                    var hoaDon = context.HoaDon.FirstOrDefault(hd => hd.MaHD == txtMaHD.Text.Trim());
                    if (hoaDon != null)
                    {
                        hoaDon.TongTien -= cthd.ThanhTien;
                    }

                    context.CTHD.Remove(cthd);
                    context.SaveChanges();

                    txtTongTien_BangSo.Text = hoaDon?.TongTien.ToString("F0") ?? "0";
                    lblTongTien_BangChu.Text = "Tổng tiền (bằng chữ): " + Functions.ChuyenSoSangChu(txtTongTien_BangSo.Text);

                    if (!context.CTHD.Any(ct => ct.MaHD == txtMaHD.Text.Trim()))
                    {
                        context.HoaDon.Remove(hoaDon);
                        context.SaveChanges();
                    }

                    transaction.Commit();

                    LoadDataGridView();
                    ResetValuesHang();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbMaNV_TextChanged(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                var maNV = Convert.ToString(cbMaNV.SelectedValue);
                var nhanVien = context.NhanVien.Find(maNV);

                txtTenNV.Text = nhanVien?.TenNV ?? "";
                txtSDT_NV.Text = nhanVien?.SDT ?? "";
            }
        }

        private void cbMaKH_TextChanged(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                var maKH = Convert.ToString(cbMaKH.SelectedValue);
                var khachHang = context.KhachHang.Include(kh => kh.LoaiKH).FirstOrDefault(kh => kh.MaKH == maKH);

                txtTenKH.Text = khachHang?.TenKH ?? "";
                txtDiaChi.Text = khachHang?.DiaChi ?? "";
                txtSDT_KH.Text = khachHang?.SDT ?? "";
                txtLoaiKH.Text = khachHang?.LoaiKH?.TenLoai ?? "";
                txtTongTienDaMua.Text = khachHang?.SoTienMua.ToString() ?? "";

                decimal chietKhau = 0;
                if (khachHang?.LoaiKH != null)
                {
                    if (khachHang.LoaiKH.TenLoai == "VIP")
                        chietKhau = 10;
                    else if (khachHang.LoaiKH.TenLoai == "Đặc biệt")
                        chietKhau = 5;
                    else
                        chietKhau = 0;
                }
                txtChietKhau.Text = chietKhau.ToString("F0");
            }
        }

        private void cbMaHH_TextChanged(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                var maHH = Convert.ToString(cbMaHH.SelectedValue);
                var hangHoa = context.HangHoa.Find(maHH);

                txtTenHH.Text = hangHoa?.TenHH ?? "";
                txtDGBan.Text = hangHoa?.DGBan.ToString() ?? "";
                txtHangSX.Text = hangHoa?.HangSX ?? "";
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtSoLuongMua.Text, out double sl);
            double.TryParse(txtDGBan.Text, out double dg);
            double.TryParse(txtChietKhau.Text, out double ck);

            double thanhTien = sl * dg;
            double thanhTienSauGiamGia = thanhTien - (thanhTien * (ck / 100));

            txtThanhTien.Text = thanhTienSauGiamGia.ToString("F0");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDSHoaDon frmDSHoaDon = new frmDSHoaDon(currentUsername);
            frmDSHoaDon.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frmDSHoaDon.ShowDialog();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            ResetValuesHang();
            LoadDataGridView();

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;

            txtMaHD.Enabled = true;
            txtMaHD.ReadOnly = false;
            txtMaHD.Focus();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();

            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Chưa có mã hóa đơn để in!");
                return;
            }

            frmInHoaDon frm = new frmInHoaDon();
            frm.maHoaDon = maHD;
            frm.ShowDialog();
        }
    }
}
