using BanHangMayTinh.Reports;
using LinhKienMayTinh.Class;
using LinhKienMayTinh.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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
    public partial class frmPhieuBaoHanh : Form
    {
        private DataTable tblPhieuBaoHanh = new DataTable();
        private string currentUserRole;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmPhieuBaoHanh(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var danhSachPhieuBaoHanh = context.PhieuBaoHanh
                    .Include(pb => pb.NhanVien)
                    .Include(pb => pb.KhachHang)
                    .Include(pb => pb.HangHoa)
                    .Select(pb => new
                    {
                        pb.MaPhieu,
                        pb.NgayLap,
                        pb.MaKH,
                        pb.MaHH,
                        pb.MaNV,
                        pb.TGBaoHanh
                    })
                    .ToList();

                dgvDSPhieuBaoHanh.DataSource = danhSachPhieuBaoHanh;
            }

            dgvDSPhieuBaoHanh.Columns[0].HeaderText = "Mã phiếu";
            dgvDSPhieuBaoHanh.Columns[0].Width = 150;
            dgvDSPhieuBaoHanh.Columns[1].HeaderText = "Ngày lập phiếu";
            dgvDSPhieuBaoHanh.Columns[1].Width = 150;
            dgvDSPhieuBaoHanh.Columns[2].HeaderText = "Mã khách hàng";
            dgvDSPhieuBaoHanh.Columns[2].Width = 170;
            dgvDSPhieuBaoHanh.Columns[3].HeaderText = "Mã hàng hóa";
            dgvDSPhieuBaoHanh.Columns[3].Width = 170;
            dgvDSPhieuBaoHanh.Columns[4].HeaderText = "Mã nhân viên";
            dgvDSPhieuBaoHanh.Columns[4].Width = 170;
            dgvDSPhieuBaoHanh.Columns[5].HeaderText = "Thời gian bảo hành";
            dgvDSPhieuBaoHanh.Columns[5].Width = 200;

            dgvDSPhieuBaoHanh.AllowUserToAddRows = false;
            dgvDSPhieuBaoHanh.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmPhieuBaoHang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            LoadDataGridView();

            txtMaPhieu.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtSDT_NV.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtSDT_KH.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtTenHH.ReadOnly = true;

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
                //cbMaNV.SelectedIndex = -1;

                LoadMaNVTheoQuyen();

                var danhSachHH = context.HangHoa
                    .Select(hh => new { hh.MaHH })
                    .ToList();
                cbMaHH.DataSource = danhSachHH;
                cbMaHH.DisplayMember = "MaHH";
                cbMaHH.ValueMember = "MaHH";
                cbMaHH.SelectedIndex = -1;
            }

            cbTGBaoHanh.SelectedIndex = -1;
            cbTGBaoHanh.Items.Add("6 tháng");
            cbTGBaoHanh.Items.Add("12 tháng");
            cbTGBaoHanh.Items.Add("24 tháng");

            cbTGBaoHanh.Items.Clear();
            cbTGBaoHanh.Items.Add("6 tháng");
            cbTGBaoHanh.Items.Add("12 tháng");
            cbTGBaoHanh.Items.Add("24 tháng");
            cbTGBaoHanh.SelectedIndex = -1;

            if (!string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                LoadInfoPhieuBaoHanh();
                btnXoa.Enabled = true;
            }

            txtTimKiem.Enabled = false;

            cbNoiDungTK.Items.Clear();
            cbNoiDungTK.Items.Add("Mã phiếu");
            cbNoiDungTK.Items.Add("Mã khách hàng");
            cbNoiDungTK.Items.Add("Mã nhân viên");
            cbNoiDungTK.Items.Add("Mã hàng hóa");
            cbNoiDungTK.Items.Add("Năm");
            cbNoiDungTK.Items.Add("Tháng");
            cbNoiDungTK.Items.Add("Thời gian bảo hành");
            cbNoiDungTK.SelectedIndex = -1;

            using (var context = new LKMTdbContext())
            {
                var user = context.TaiKhoan.FirstOrDefault(u => u.Username == currentUsername);
                if (user != null)
                    currentUserRole = user.QuyenHan;
            }
            PhanQuyen();
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

        private void PhanQuyen()
        {
            if (currentUserRole == "QuanLy" || currentUserRole == "Admin")
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void LoadInfoPhieuBaoHanh()
        {
            using (var context = new LKMTdbContext())
            {
                var phieuBaoHanh = context.PhieuBaoHanh.Find(txtMaPhieu.Text.Trim());
                if (phieuBaoHanh != null)
                {
                    dtpNgayLap.Value = phieuBaoHanh.NgayLap;
                    cbMaKH.Text = phieuBaoHanh.MaKH;
                    cbMaHH.Text = phieuBaoHanh.MaHH;
                    cbMaNV.Text = phieuBaoHanh.MaNV;
                    cbTGBaoHanh.Text = phieuBaoHanh.TGBaoHanh;
                }
            }
        }

        private void dgvDSPhieuBaoHanh_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPhieu.Focus();
                return;
            }
            if (dgvDSPhieuBaoHanh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var phieuBaoHanh = context.PhieuBaoHanh.Find(dgvDSPhieuBaoHanh.CurrentRow.Cells["MaPhieu"].Value.ToString());
                if (phieuBaoHanh != null)
                {
                    txtMaPhieu.Text = phieuBaoHanh.MaPhieu;
                    dtpNgayLap.Value = phieuBaoHanh.NgayLap;
                    cbTGBaoHanh.Text = phieuBaoHanh.TGBaoHanh;
                    cbMaKH.Text = phieuBaoHanh.MaKH;
                    cbMaHH.Text = phieuBaoHanh.MaHH;
                    cbMaNV.Text = phieuBaoHanh.MaNV;
                }
            }
            PhanQuyen();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaPhieu.Enabled = true;
            txtMaPhieu.ReadOnly = false;
            txtMaPhieu.Focus();
            ResetValues();
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaPhieu.Text = "";
            dtpNgayLap.Text = DateTime.Now.ToShortDateString();
            cbTGBaoHanh.Text = "";

            //cbMaNV.SelectedIndex = -1;
            //txtTenNV.Text = "";
            //txtSDT_NV.Text = "";
            LoadMaNVTheoQuyen();

            cbMaKH.SelectedIndex = -1;
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT_KH.Text = "";

            cbMaHH.SelectedIndex = -1;
            txtTenHH.Text = "";
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


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Bạn phải nhập mã phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;
            }
            if (!dtpNgayLap.Checked)
            {
                MessageBox.Show("Bạn phải nhập ngày lập phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbTGBaoHanh.Text) || string.IsNullOrWhiteSpace(cbMaKH.Text) ||
                string.IsNullOrWhiteSpace(cbMaHH.Text) || string.IsNullOrWhiteSpace(cbMaNV.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin phiếu bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    string maPhieu = txtMaPhieu.Text.Trim();

                    if (context.PhieuBaoHanh.Find(maPhieu) != null)
                    {
                        MessageBox.Show("Mã phiếu này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaPhieu.Focus();
                        txtMaPhieu.Text = "";
                        return;
                    }

                    var phieuBaoHanh = new PhieuBaoHanh
                    {
                        MaPhieu = maPhieu,
                        NgayLap = dtpNgayLap.Value,
                        MaKH = cbMaKH.Text.Trim(),
                        MaHH = cbMaHH.Text.Trim(),
                        MaNV = cbMaNV.Text.Trim(),
                        TGBaoHanh = cbTGBaoHanh.Text.Trim()
                    };

                    context.PhieuBaoHanh.Add(phieuBaoHanh);

                    logger.Info($"Người dùng {currentUsername} đã lập phiếu bảo hành.");
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi lưu phiếu bảo hành: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaPhieu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!dtpNgayLap.Checked)
            {
                MessageBox.Show("Bạn phải nhập ngày lập phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbTGBaoHanh.Text) || string.IsNullOrWhiteSpace(cbMaKH.Text) ||
                string.IsNullOrWhiteSpace(cbMaHH.Text) || string.IsNullOrWhiteSpace(cbMaNV.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin phiếu bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var phieuBaoHanh = context.PhieuBaoHanh.Find(txtMaPhieu.Text.Trim());
                if (phieuBaoHanh != null)
                {
                    phieuBaoHanh.NgayLap = dtpNgayLap.Value;
                    phieuBaoHanh.MaKH = cbMaKH.Text.Trim();
                    phieuBaoHanh.MaHH = cbMaHH.Text.Trim();
                    phieuBaoHanh.MaNV = cbMaNV.Text.Trim();
                    phieuBaoHanh.TGBaoHanh = cbTGBaoHanh.Text.Trim();

                    logger.Info($"Người dùng {currentUsername} đã sửa phiếu bảo hành.");
                    context.SaveChanges();
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var phieuBaoHanh = context.PhieuBaoHanh.Find(txtMaPhieu.Text.Trim());
                if (phieuBaoHanh != null)
                {
                    logger.Info($"Người dùng {currentUsername} đã xóa phiếu bảo hành.");
                    context.PhieuBaoHanh.Remove(phieuBaoHanh);
                    context.SaveChanges();
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNoiDungTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbNoiDungTK.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn loại tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Bạn phải nhập nội dung cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimKiem.Focus();
                return;
            }

            string keyword = txtTimKiem.Text.Trim();

            using (var context = new LKMTdbContext())
            {
                var query = context.PhieuBaoHanh.Include(pb => pb.NhanVien).Include(pb => pb.KhachHang).Include(pb => pb.HangHoa).AsQueryable();

                switch (cbNoiDungTK.Text)
                {
                    case "Mã phiếu":
                        query = query.Where(pb => pb.MaPhieu.Contains(keyword));
                        break;
                    case "Mã khách hàng":
                        query = query.Where(pb => pb.MaKH.Contains(keyword));
                        break;
                    case "Mã nhân viên":
                        query = query.Where(pb => pb.MaNV.Contains(keyword));
                        break;
                    case "Mã hàng hóa":
                        query = query.Where(pb => pb.MaHH.Contains(keyword));
                        break;
                    case "Tháng":
                        if (int.TryParse(keyword, out int month))
                            query = query.Where(pb => pb.NgayLap.Month == month);
                        else
                            MessageBox.Show("Tháng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Năm":
                        if (int.TryParse(keyword, out int year))
                            query = query.Where(pb => pb.NgayLap.Year == year);
                        else
                            MessageBox.Show("Năm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Thời gian bảo hành":
                        query = query.Where(pb => pb.TGBaoHanh.Contains(keyword));
                        break;
                    default:
                        MessageBox.Show("Loại tìm kiếm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (!query.Any())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvDSPhieuBaoHanh.DataSource = query.ToList();
            }
        }

        private void btnHuyTK_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtTimKiem.Text = "";
            cbNoiDungTK.SelectedIndex = -1;
            txtTimKiem.Enabled = false;
        }

        private void cbMaNV_TextChanged(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                var nhanVien = context.NhanVien.Find(cbMaNV.SelectedValue?.ToString());
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

        private void cbMaKH_TextChanged(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                var khachHang = context.KhachHang.Find(cbMaKH.SelectedValue?.ToString());
                if (khachHang != null)
                {
                    txtTenKH.Text = khachHang.TenKH;
                    txtSDT_KH.Text = khachHang.SDT;
                    txtDiaChi.Text = khachHang.DiaChi;
                }
                else
                {
                    txtTenKH.Text = "";
                    txtSDT_KH.Text = "";
                    txtDiaChi.Text = "";
                }
            }
        }

        private void cbMaHH_TextChanged(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                var hangHoa = context.HangHoa.Find(cbMaHH.SelectedValue?.ToString());
                txtTenHH.Text = hangHoa?.TenHH ?? "";
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string MaPhieuBH = txtMaPhieu.Text.Trim();

            if (string.IsNullOrEmpty(MaPhieuBH))
            {
                MessageBox.Show("Chưa có phiếu nhập để in!");
                return;
            }

            frmInPBH frm = new frmInPBH();
            MessageBox.Show("Đã nhận MaPhieuBH = " + MaPhieuBH);
            frm.MaPhieuBH = MaPhieuBH;
            frm.ShowDialog();
        }
    }
}
