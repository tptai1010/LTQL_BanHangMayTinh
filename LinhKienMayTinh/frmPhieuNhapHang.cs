using BanHangMayTinh.Reports;
using LinhKienMayTinh.Class;
using LinhKienMayTinh.Data;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using NLog;

namespace LinhKienMayTinh
{
    public partial class frmPhieuNhapHang : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private DataTable tblCTPN = new DataTable();
        private string currentUserRole;
        private string currentUsername;

        public frmPhieuNhapHang(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var danhSachHangNhap = context.CTPhieuNhap
                    .Where(ct => ct.MaPhieu == txtMaPhieu.Text)
                    .Select(ct => new
                    {
                        ct.MaHH,
                        TenHH = ct.HangHoa.TenHH,
                        ct.SoLuong,
                        HangSX = ct.HangHoa.HangSX,
                        ct.DGNhap,
                        ct.ThanhTien
                    })
                    .ToList();

                dgvDSHangHoaNhap.DataSource = danhSachHangNhap;
            }
            dgvDSHangHoaNhap.Columns[0].HeaderText = "Mã hàng hóa";
            dgvDSHangHoaNhap.Columns[0].Width = 170;
            dgvDSHangHoaNhap.Columns[1].HeaderText = "Tên hàng hóa";
            dgvDSHangHoaNhap.Columns[1].Width = 200;
            dgvDSHangHoaNhap.Columns[2].HeaderText = "Số lượng";
            dgvDSHangHoaNhap.Columns[2].Width = 130;
            dgvDSHangHoaNhap.Columns[3].HeaderText = "Hãng sản xuất";
            dgvDSHangHoaNhap.Columns[3].Width = 180;
            dgvDSHangHoaNhap.Columns[4].HeaderText = "Đơn giá nhập";
            dgvDSHangHoaNhap.Columns[4].Width = 170;
            dgvDSHangHoaNhap.Columns[5].HeaderText = "Thành tiền";
            dgvDSHangHoaNhap.Columns[5].Width = 170;

            dgvDSHangHoaNhap.AllowUserToAddRows = false;
            dgvDSHangHoaNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmPhieuNhapHang_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;

            txtMaPhieu.ReadOnly = true;

            txtTenNV.ReadOnly = true;
            txtSDT_NV.ReadOnly = true;

            txtTenNCC.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT_NCC.ReadOnly = true;
            txtEmail.ReadOnly = true;

            txtTenHH.ReadOnly = true;
            txtSLNhap.ReadOnly = true;
            txtDGNhap.ReadOnly = true;
            txtHangSX.ReadOnly = true;
            txtThanhTien.ReadOnly = true;

            txtTongTien_BangSo.ReadOnly = true;
            txtTongTien_BangSo.Text = "0";

            using (var context = new LKMTdbContext())
            {
                var nccList = context.NhaCungCap.Select(ncc => new { ncc.MaNCC }).ToList();
                cbMaNCC.DataSource = nccList;
                cbMaNCC.DisplayMember = "MaNCC";
                cbMaNCC.ValueMember = "MaNCC";
                cbMaNCC.SelectedIndex = -1;

                var nvList = context.NhanVien.Select(nv => new { nv.MaNV }).ToList();
                cbMaNV.DataSource = nvList;
                cbMaNV.DisplayMember = "MaNV";
                cbMaNV.ValueMember = "MaNV";
                //cbMaNV.SelectedIndex = -1;

                LoadMaNVTheoQuyen();

                var hhList = context.HangHoa.Select(hh => new { hh.MaHH }).ToList();
                cbMaHH.DataSource = hhList;
                cbMaHH.DisplayMember = "MaHH";
                cbMaHH.ValueMember = "MaHH";
                cbMaHH.SelectedIndex = -1;
            }

            if (txtMaPhieu.Text != "")
            {
                LoadInfoPhieuNhap();
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

        private void LoadInfoPhieuNhap()
        {
            using (var context = new LKMTdbContext())
            {
                var phieuNhap = context.PhieuNhap.FirstOrDefault(pn => pn.MaPhieu == txtMaPhieu.Text);

                if (phieuNhap != null)
                {
                    dtpNgayLap.Value = phieuNhap.NgayNhap;
                    cbMaNV.Text = phieuNhap.MaNV;
                    cbMaNCC.Text = phieuNhap.MaNCC;
                    txtTongTien_BangSo.Text = phieuNhap.TongTien.ToString();
                    lblTongTien_BangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongTien_BangSo.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDSHangHoaNhap_Click(object sender, EventArgs e)
        {
            if (dgvDSHangHoaNhap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvDSHangHoaNhap.CurrentRow != null)
            {
                string maHH = dgvDSHangHoaNhap.CurrentRow.Cells["MaHH"].Value.ToString();
                cbMaHH.SelectedValue = maHH;
                LoadChiTietHangHoa(maHH);
            }

            PhanQuyen();
        }

        private void LoadChiTietHangHoa(string maHH)
        {
            using (var context = new LKMTdbContext())
            {
                var chiTietHangHoa = context.CTPhieuNhap
                    .Where(ct => ct.MaHH == maHH)
                    .Select(ct => new
                    {
                        ct.MaHH,
                        ct.HangHoa.TenHH,
                        ct.SoLuong,
                        ct.HangHoa.HangSX,
                        ct.DGNhap,
                        ct.ThanhTien
                    })
                    .FirstOrDefault();

                if (chiTietHangHoa != null)
                {
                    txtTenHH.Text = chiTietHangHoa.TenHH;
                    txtSLNhap.Text = chiTietHangHoa.SoLuong.ToString();
                    txtHangSX.Text = chiTietHangHoa.HangSX;
                    txtDGNhap.Text = chiTietHangHoa.DGNhap.ToString("F0");
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
            txtMaPhieu.Enabled = true;
            txtMaPhieu.ReadOnly = false;
            txtSLNhap.ReadOnly = false;
            txtDGNhap.ReadOnly = false;
            txtMaPhieu.Focus();

            ResetValues();
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaPhieu.Text = "";
            dtpNgayLap.Text = DateTime.Now.ToShortDateString();

            //cbMaNV.SelectedIndex = -1;
            //txtTenNV.Text = "";
            //txtSDT_NV.Text = "";
            LoadMaNVTheoQuyen();

            cbMaNCC.SelectedIndex = -1;
            txtTenNCC.Text = "";
            txtSDT_NCC.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";

            txtTongTien_BangSo.Text = "0";
            lblTongTien_BangChu.Text = "Bằng chữ: ";

            cbMaHH.SelectedIndex = -1;
            txtTenHH.Text = "";
            txtSLNhap.Text = "";
            txtHangSX.Text = "";
            txtDGNhap.Text = "";
            txtThanhTien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                if (!dtpNgayLap.Checked)
                {
                    MessageBox.Show("Bạn phải nhập ngày lập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(cbMaNV.Text))
                {
                    MessageBox.Show("Bạn phải chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMaNV.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(cbMaNCC.Text))
                {
                    MessageBox.Show("Bạn phải chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMaNCC.Focus();
                    return;
                }

                var maPhieu = txtMaPhieu.Text.Trim();
                var ngayLap = dtpNgayLap.Value;
                var maNV = Convert.ToString(cbMaNV.SelectedValue);
                var maNCC = Convert.ToString(cbMaNCC.SelectedValue);

                var existingPhieuNhap = context.PhieuNhap.FirstOrDefault(pn => pn.MaPhieu == maPhieu);
                if (existingPhieuNhap == null)
                {
                    existingPhieuNhap = new PhieuNhap
                    {
                        MaPhieu = maPhieu,
                        MaNV = maNV,
                        MaNCC = maNCC,
                        NgayNhap = ngayLap,
                        TongTien = 0
                    };
                    context.PhieuNhap.Add(existingPhieuNhap);
                    context.SaveChanges();
                }

                if (cbMaHH.SelectedValue == null)
                {
                    MessageBox.Show("Bạn phải chọn mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMaHH.Focus();
                    return;
                }
                var maHH = Convert.ToString(cbMaHH.SelectedValue);

                if (!decimal.TryParse(txtSLNhap.Text, out decimal slNhap) || slNhap <= 0)
                {
                    MessageBox.Show("Số lượng nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSLNhap.Focus();
                    return;
                }

                if (!decimal.TryParse(txtDGNhap.Text, out decimal dgNhap) || dgNhap <= 0)
                {
                    MessageBox.Show("Đơn giá nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDGNhap.Focus();
                    return;
                }

                var thanhTien = slNhap * dgNhap;
                txtThanhTien.Text = thanhTien.ToString("F0");

                var existingCTPN = context.CTPhieuNhap.FirstOrDefault(ct => ct.MaPhieu == maPhieu && ct.MaHH == maHH);
                if (existingCTPN != null)
                {
                    MessageBox.Show("Mặt hàng này đã tồn tại trong phiếu nhập. Vui lòng chọn mặt hàng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValuesHang();
                    cbMaHH.Focus();
                    return;
                }

                var newCTPhieuNhap = new CTPhieuNhap
                {
                    MaPhieu = maPhieu,
                    MaHH = maHH,
                    SoLuong = (int)slNhap,
                    DGNhap = dgNhap,
                    ThanhTien = thanhTien
                };
                context.CTPhieuNhap.Add(newCTPhieuNhap);

                var hangHoa = context.HangHoa.FirstOrDefault(hh => hh.MaHH == maHH);
                if (hangHoa != null)
                {
                    hangHoa.SoLuong += (int)slNhap;
                    hangHoa.DGNhap = dgNhap;
                    hangHoa.DGBan = dgNhap * 1.25m;

                    var loaiHH = context.LoaiHH.FirstOrDefault(lh => lh.MaLoaiHH == hangHoa.MaLoaiHH);
                    if (loaiHH != null)
                    {
                        loaiHH.SoLuong = context.HangHoa.Where(hh => hh.MaLoaiHH == loaiHH.MaLoaiHH).Sum(hh => hh.SoLuong);
                    }
                }

                existingPhieuNhap.TongTien += thanhTien;

                try
                {
                    logger.Info($"Người dùng {currentUsername} đã nhập hàng.");
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtTongTien_BangSo.Text = existingPhieuNhap.TongTien.ToString("F0");
                lblTongTien_BangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(existingPhieuNhap.TongTien.ToString("F0"));

                LoadDataGridView();
                ResetValuesHang();
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
            }
        }

        private void ResetValuesHang()
        {
            cbMaHH.Text = "";
            txtDGNhap.Text = "";
            txtHangSX.Text = "";
            txtTenHH.Text = "";
            txtSLNhap.Text = "";
            txtThanhTien.Text = "0";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblCTPN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtMaPhieu.Text) || string.IsNullOrEmpty(cbMaHH.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new LKMTdbContext())
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        string maPhieu = txtMaPhieu.Text.Trim();
                        string maHH = cbMaHH.Text.Trim();

                        var ctPhieuNhap = context.CTPhieuNhap.FirstOrDefault(ct => ct.MaPhieu == maPhieu && ct.MaHH == maHH);
                        if (ctPhieuNhap == null)
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        decimal slXoa = ctPhieuNhap.SoLuong;
                        decimal thanhTienXoa = ctPhieuNhap.ThanhTien;

                        context.CTPhieuNhap.Remove(ctPhieuNhap);

                        var hangHoa = context.HangHoa.FirstOrDefault(hh => hh.MaHH == maHH);
                        if (hangHoa != null)
                        {
                            hangHoa.SoLuong = Math.Max(0, hangHoa.SoLuong - (int)slXoa); // 🛠 Đảm bảo số lượng không bị âm
                        }

                        var phieuNhap = context.PhieuNhap.FirstOrDefault(pn => pn.MaPhieu == maPhieu);
                        if (phieuNhap != null)
                        {
                            phieuNhap.TongTien = Math.Max(0, phieuNhap.TongTien - thanhTienXoa);
                        }

                        if (!context.CTPhieuNhap.Any(ct => ct.MaPhieu == maPhieu))
                        {
                            context.PhieuNhap.Remove(phieuNhap);
                            ResetValues();
                        }

                        context.SaveChanges();
                        transaction.Commit();

                        txtTongTien_BangSo.Text = phieuNhap?.TongTien.ToString("F0") ?? "0";
                        lblTongTien_BangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongTien_BangSo.Text);

                        LoadDataGridView();
                        ResetValuesHang();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); 
                        MessageBox.Show("Lỗi khi xóa phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            ResetValuesHang();
            LoadDataGridView();

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;

            txtMaPhieu.Enabled = true;
            txtMaPhieu.ReadOnly = false;
            txtMaPhieu.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaNV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMaNV.Text))
            {
                txtTenNV.Text = "";
                txtSDT_NV.Text = "";
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var nhanVien = context.NhanVien.FirstOrDefault(nv => nv.MaNV == cbMaNV.SelectedValue.ToString());
                if (nhanVien != null)
                {
                    txtTenNV.Text = nhanVien.TenNV;
                    txtSDT_NV.Text = nhanVien.SDT;
                }
            }
        }

        private void cbMaNCC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMaNCC.Text))
            {
                txtTenNCC.Text = "";
                txtDiaChi.Text = "";
                txtSDT_NCC.Text = "";
                txtEmail.Text = "";
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var nhaCungCap = context.NhaCungCap.FirstOrDefault(ncc => ncc.MaNCC == cbMaNCC.SelectedValue.ToString());
                if (nhaCungCap != null)
                {
                    txtTenNCC.Text = nhaCungCap.TenNCC;
                    txtDiaChi.Text = nhaCungCap.DiaChi;
                    txtSDT_NCC.Text = nhaCungCap.SDT;
                    txtEmail.Text = nhaCungCap.Email;
                }
            }
        }

        private void cbHangHoa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMaHH.Text))
            {
                txtTenHH.Text = "";
                txtHangSX.Text = "";
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var hangHoa = context.HangHoa.FirstOrDefault(hh => hh.MaHH == cbMaHH.SelectedValue.ToString());
                if (hangHoa != null)
                {
                    txtTenHH.Text = hangHoa.TenHH;
                    txtHangSX.Text = hangHoa.HangSX;
                }
            }
        }

        private void TinhThanhTienNhap()
        {
            double.TryParse(txtSLNhap.Text, out double sl);
            double.TryParse(txtDGNhap.Text, out double dg);

            txtThanhTien.Text = (sl * dg).ToString("F0");
        }

        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTienNhap();
        }

        private void txtDGNhap_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTienNhap();
        }

        private void btnDSPhieuNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDSPhieuNhap frmDSPN = new frmDSPhieuNhap(currentUsername);
            frmDSPN.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frmDSPN.ShowDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string p = txtMaPhieu.Text.Trim(); 

            if (string.IsNullOrEmpty(p))
            {
                MessageBox.Show("Chưa có phiếu nhập để in!");
                return;
            }

            frmInPhieuNhap frm = new frmInPhieuNhap();
            frm.p = p; 
            frm.ShowDialog();
        }
    }
}
