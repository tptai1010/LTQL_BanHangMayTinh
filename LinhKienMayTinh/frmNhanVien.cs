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
using ClosedXML.Excel;
using System.Globalization;
using LinhKienMayTinh.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using NLog;

namespace LinhKienMayTinh
{
    public partial class frmNhanVien : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private DataTable tbleNhanVien = new DataTable();
        private string currentUserRole;
        private string currentUsername;

        public frmNhanVien(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            LoadDataGridView();

            txtMaNV.ReadOnly = true;
            txtLuongCoBan.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtHSLuongThem.ReadOnly = true;

            cbChucVu.Items.Clear();
            cbChucVu.Items.Add("Giám đốc");
            cbChucVu.Items.Add("Quản lý");
            cbChucVu.Items.Add("Nhân viên");
            cbChucVu.SelectedIndexChanged += cbChucVu_SelectedIndexChanged;

            cbNoiDungTK.Items.Clear();
            cbNoiDungTK.Items.Add("Mã nhân viên");
            cbNoiDungTK.Items.Add("Tên nhân viên");
            cbNoiDungTK.Items.Add("Giới tính");
            cbNoiDungTK.Items.Add("Chức vụ");
            cbNoiDungTK.Items.Add("Địa chỉ");
            cbNoiDungTK.Items.Add("Năm sinh");

            cbNoiDungTK.SelectedIndexChanged += cbTimKiem_SelectedIndexChanged;

            txtTimKiem.Enabled = false;
            using (var context = new LKMTdbContext())
            {
                var user = context.TaiKhoan.FirstOrDefault(u => u.Username == currentUsername);
                if (user != null)
                    currentUserRole = user.QuyenHan;
            }
            PhanQuyen();
        }

        private void cbChucVu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string chucVu = cbChucVu.Text.Trim();

            switch (chucVu)
            {
                case "Giám đốc":
                    txtLuongCoBan.Text = "20000000";
                    txtHSLuongThem.Text = "2.0";
                    break;

                case "Quản lý":
                    txtLuongCoBan.Text = "15000000";
                    txtHSLuongThem.Text = "1.5";
                    break;

                default: // Nhân viên
                    txtLuongCoBan.Text = "10000000";
                    txtHSLuongThem.Text = "1.0";
                    break;
            }
        }

        private void cbTimKiem_SelectedIndexChanged(object? sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var danhSachNV = context.NhanVien
                    .Select(nv => new
                    {
                        nv.MaNV,
                        nv.TenNV,
                        nv.GioiTinh,
                        nv.NgaySinh,
                        nv.DiaChi,
                        nv.SDT,
                        nv.ChucVu,
                        nv.LuongCoBan,
                        nv.HeSoLuongThem
                    })
                    .ToList();
                dgvNhanVien.DataSource = danhSachNV;
            }

            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[0].Width = 150;
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[1].Width = 200;
            dgvNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvNhanVien.Columns[2].Width = 130;
            dgvNhanVien.Columns[3].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[3].Width = 130;
            dgvNhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[4].Width = 130;
            dgvNhanVien.Columns[5].HeaderText = "SDT";
            dgvNhanVien.Columns[5].Width = 130;
            dgvNhanVien.Columns[6].HeaderText = "Chức vụ";
            dgvNhanVien.Columns[6].Width = 130;
            dgvNhanVien.Columns[7].HeaderText = "Lương cơ bản";
            dgvNhanVien.Columns[7].Width = 150;
            dgvNhanVien.Columns[8].HeaderText = "Hệ số lương thêm";
            dgvNhanVien.Columns[8].Width = 150;

            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null || dgvNhanVien.CurrentRow.Cells["MaNV"].Value == null)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (dgvNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var context = new LKMTdbContext())
            {
                string maNV = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
                var nhanVien = context.NhanVien.FirstOrDefault(nv => nv.MaNV == maNV);

                if (nhanVien != null)
                {
                    txtMaNV.Text = nhanVien.MaNV;
                    txtTenNV.Text = nhanVien.TenNV;
                    rbtnNam.Checked = nhanVien.GioiTinh == "Nam";
                    rbtnNu.Checked = nhanVien.GioiTinh == "Nữ";
                    dtpNgaySinh.Value = nhanVien.NgaySinh;
                    txtDiaChi.Text = nhanVien.DiaChi;
                    txtSDT.Text = nhanVien.SDT;
                    cbChucVu.Text = nhanVien.ChucVu;
                    txtLuongCoBan.Text = nhanVien.LuongCoBan.ToString();
                    txtHSLuongThem.Text = nhanVien.HeSoLuongThem.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên trong database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            if (currentUserRole == "QuanLy" || currentUserRole == "Admin")
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnNhap.Enabled = true;
                btnChamCong.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnNhap.Enabled = false;
                btnChamCong.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnTimKiem.Enabled = false;
            btnHuyTK.Enabled = false;
            ResetValues();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();

            txtMaNV.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTenNV.ReadOnly = false;

            cbChucVu.Enabled = true;
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cbChucVu.SelectedIndex = -1;
            txtLuongCoBan.Text = "";
            txtHSLuongThem.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            dtpNgaySinh.Text = DateTime.Now.ToShortDateString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new LKMTdbContext())
                {
                    var nhanVien = context.NhanVien.Find(txtMaNV.Text.Trim());
                    if (nhanVien != null)
                    {
                        context.NhanVien.Remove(nhanVien);
                        logger.Info($"Người dùng {currentUsername} đã xóa nhân viên.");
                        context.SaveChanges();
                        LoadDataGridView();
                        ResetValues();
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {                    
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbChucVu.Text))
            {
                MessageBox.Show("Bạn phải chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbChucVu.Focus();
                return;
            }
            if (!dtpNgaySinh.Checked)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction()) // 🛠 Thêm giao dịch để bảo vệ dữ liệu
            {
                try
                {
                    var nhanVien = context.NhanVien.Find(txtMaNV.Text.Trim());
                    if (nhanVien != null)
                    {
                        nhanVien.TenNV = txtTenNV.Text.Trim();
                        nhanVien.ChucVu = cbChucVu.Text.Trim();
                        nhanVien.DiaChi = txtDiaChi.Text.Trim();
                        nhanVien.SDT = txtSDT.Text.Trim();
                        nhanVien.NgaySinh = dtpNgaySinh.Value;
                        nhanVien.GioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";
                        nhanVien.LuongCoBan = decimal.Parse(txtLuongCoBan.Text.Trim());
                        if (!decimal.TryParse(txtHSLuongThem.Text.Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal heSoLuongThem))
                        {
                            MessageBox.Show("Hệ số lương thêm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        nhanVien.HeSoLuongThem = heSoLuongThem;

                        logger.Info($"Người dùng {currentUsername} đã sửa nhân viên.");
                        context.SaveChanges();
                        transaction.Commit();

                        LoadDataGridView();
                        ResetValues();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi sửa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }      
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbChucVu.Text))
            {
                MessageBox.Show("Bạn phải chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbChucVu.Focus();
                return;
            }
            if (!dtpNgaySinh.Checked)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";

            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    string maNV = txtMaNV.Text.Trim();

                    if (context.NhanVien.Find(maNV) != null)
                    {
                        MessageBox.Show("Mã nhân viên này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNV.Focus();
                        txtMaNV.Text = "";
                        return;
                    }

                    if (decimal.TryParse(txtHSLuongThem.Text.Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal heSoLuongThem))
                    {
                        var nhanVien = new NhanVien
                        {
                            MaNV = maNV,
                            TenNV = txtTenNV.Text.Trim(),
                            ChucVu = cbChucVu.Text.Trim(),
                            DiaChi = txtDiaChi.Text.Trim(),
                            SDT = txtSDT.Text.Trim(),
                            NgaySinh = dtpNgaySinh.Value,
                            GioiTinh = gioiTinh,
                            LuongCoBan = decimal.Parse(txtLuongCoBan.Text.Trim()),
                            HeSoLuongThem = heSoLuongThem 
                        };

                        context.NhanVien.Add(nhanVien);
                        logger.Info($"Người dùng {currentUsername} đã thêm nhân viên.");
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    else
                    {
                        MessageBox.Show("Hệ số lương thêm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi lưu nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnTimKiem.Enabled = true;
            btnHuyTK.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChamCong frmChamCong = new frmChamCong(currentUsername);
            frmChamCong.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frmChamCong.ShowDialog();
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
                var query = context.NhanVien.AsQueryable();

                switch (cbNoiDungTK.Text)
                {
                    case "Mã nhân viên":
                        query = query.Where(nv => nv.MaNV.Contains(keyword));
                        break;
                    case "Tên nhân viên":
                        query = query.Where(nv => nv.TenNV.Contains(keyword));
                        break;
                    case "Giới tính":
                        query = query.Where(nv => nv.GioiTinh.Contains(keyword));
                        break;
                    case "Chức vụ":
                        query = query.Where(nv => nv.ChucVu.Contains(keyword));
                        break;
                    case "Địa chỉ":
                        query = query.Where(nv => nv.DiaChi.Contains(keyword));
                        break;
                    case "Năm sinh":
                        if (!int.TryParse(keyword, out int nam))
                        {
                            MessageBox.Show("Năm sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        query = query.Where(nv => nv.NgaySinh.Year == nam);
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

                dgvNhanVien.DataSource = query.ToList();
            }
        }

        private void btnHuyTK_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtTimKiem.Text = "";
            cbNoiDungTK.SelectedIndex = -1;
            txtTimKiem.Enabled = false;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Nhập dữ liệu từ Excel",
                Filter = "Excel Files|*.xls;*.xlsx",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new LKMTdbContext())
                    using (var transaction = db.Database.BeginTransaction()) // 🔥 Transaction để bảo vệ dữ liệu
                    {
                        var table = new DataTable();
                        using (var workbook = new XLWorkbook(openFileDialog.FileName))
                        {
                            var worksheet = workbook.Worksheet(1);
                            bool firstRow = true;

                            foreach (var row in worksheet.RowsUsed())
                            {
                                if (firstRow)
                                {
                                    foreach (var cell in row.Cells())
                                    {
                                        table.Columns.Add(cell.Value.ToString().Trim()); 
                                    }
                                    firstRow = false;
                                }
                                else
                                {
                                    var newRow = table.NewRow();
                                    int i = 0;
                                    foreach (var cell in row.Cells(1, table.Columns.Count))
                                    {
                                        newRow[i++] = cell.Value.ToString().Trim();
                                    }
                                    table.Rows.Add(newRow);
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            int insertedCount = 0;
                            foreach (DataRow row in table.Rows)
                            {
                                string maNV = row["Mã nhân viên"]?.ToString()?.Trim();
                                if (string.IsNullOrEmpty(maNV)) continue;

                                bool exists = db.NhanVien.Any(nv => nv.MaNV == maNV);
                                if (!exists) 
                                {
                                    db.NhanVien.Add(new NhanVien
                                    {
                                        MaNV = maNV,
                                        TenNV = row["Tên nhân viên"]?.ToString()?.Trim() ?? "Không xác định",
                                        GioiTinh = row["Giới tính"]?.ToString()?.Trim() ?? "Chưa rõ",
                                        NgaySinh = DateTime.TryParse(row["Ngày sinh"]?.ToString()?.Trim(), out DateTime parsedDate) ? parsedDate : DateTime.Now,
                                        DiaChi = row["Địa chỉ"]?.ToString()?.Trim() ?? "Không có dữ liệu",
                                        SDT = row["SDT"]?.ToString()?.Trim() ?? "0000000000",
                                        ChucVu = row["Chức vụ"]?.ToString()?.Trim() ?? "Nhân viên",
                                        LuongCoBan = decimal.TryParse(row["Lương cơ bản"]?.ToString()?.Trim(), out decimal luong) ? luong : 0,
                                        HeSoLuongThem = decimal.TryParse(row["Hệ số lương thêm"]?.ToString()?.Trim(), out decimal hsl) ? hsl : 1
                                    });
                                    insertedCount++;
                                }
                            }

                            db.SaveChanges();
                            transaction.Commit();
                            logger.Info($"Người dùng {currentUsername} đã nhập danh sách nhân viên.");
                            MessageBox.Show($"Nhập dữ liệu thành công! Đã thêm {insertedCount} nhân viên mới.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Tập tin Excel không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file Excel:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Xuất dữ liệu ra tập tin Excel",
                Filter = "Excel Files|*.xls;*.xlsx",
                FileName = $"NhanVien_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new LKMTdbContext())
                    {
                        var danhSachNV = db.NhanVien
                            .Select(nv => new
                            {
                                nv.MaNV,
                                nv.TenNV,
                                nv.GioiTinh,
                                nv.NgaySinh,
                                nv.DiaChi,
                                nv.SDT,
                                nv.ChucVu,
                                nv.LuongCoBan,
                                nv.HeSoLuongThem
                            })
                            .ToList();

                        var table = new DataTable();
                        table.Columns.Add("Mã nhân viên", typeof(string));
                        table.Columns.Add("Tên nhân viên", typeof(string));
                        table.Columns.Add("Giới tính", typeof(string));
                        table.Columns.Add("Ngày sinh", typeof(DateTime));
                        table.Columns.Add("Địa chỉ", typeof(string));
                        table.Columns.Add("SDT", typeof(string));
                        table.Columns.Add("Chức vụ", typeof(string));
                        table.Columns.Add("Lương cơ bản", typeof(decimal));
                        table.Columns.Add("Hệ số lương thêm", typeof(decimal));

                        foreach (var nv in danhSachNV)
                        {
                            table.Rows.Add(nv.MaNV, nv.TenNV, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, nv.ChucVu, nv.LuongCoBan, nv.HeSoLuongThem);
                        }

                        using (var workbook = new XLWorkbook())
                        {
                            var sheet = workbook.Worksheets.Add(table, "DanhSachNhanVien");
                            sheet.Columns().AdjustToContents();
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                    }
                    logger.Info($"Người dùng {currentUsername} đã xuất dữ liệu.");
                    MessageBox.Show("Xuất dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file Excel:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
