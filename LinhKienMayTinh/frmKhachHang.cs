using LinhKienMayTinh.Class;
using LinhKienMayTinh.Data;
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
using Microsoft.EntityFrameworkCore;
using NLog;

namespace LinhKienMayTinh
{
    public partial class frmKhachHang : Form
    {
        private DataTable tblKhachHang = new DataTable();
        private string currentUserRole;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmKhachHang(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void btnLoaiKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoaiKH frmLoaiKH = new frmLoaiKH(currentUsername);
            frmLoaiKH.FormClosed += (s, args) =>
            {
                this.Show();
            };
            frmLoaiKH.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            LoadDataGridView();

            txtMaKH.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSoTienDaMua.ReadOnly = true;
            txtLoaiKH.ReadOnly = true;

            cbNoiDungTK.Items.Clear();
            cbNoiDungTK.Items.Add("Mã khách hàng");
            cbNoiDungTK.Items.Add("Tên khách hàng");
            cbNoiDungTK.Items.Add("Giới tính");
            cbNoiDungTK.Items.Add("Địa chỉ");
            cbNoiDungTK.Items.Add("Loại khách hàng");
            cbNoiDungTK.SelectedIndex = -1;
            txtTimKiem.Enabled = false;

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
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnNhap.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnNhap.Enabled = false;
            }
        }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var danhSachKhachHang = context.KhachHang
                    .Include(kh => kh.LoaiKH)
                    .Select(kh => new
                    {
                        kh.MaKH,
                        kh.TenKH,
                        kh.GioiTinh,
                        kh.DiaChi,
                        kh.SDT,
                        kh.SoTienMua,
                        kh.MaLoaiKH,
                        kh.LoaiKH.TenLoai
                    })
                    .ToList();

                dgvDSKhachHang.DataSource = danhSachKhachHang;
            }

            dgvDSKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvDSKhachHang.Columns[0].Width = 150;
            dgvDSKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvDSKhachHang.Columns[1].Width = 230;
            dgvDSKhachHang.Columns[2].HeaderText = "Giới tính";
            dgvDSKhachHang.Columns[2].Width = 130;
            dgvDSKhachHang.Columns[3].HeaderText = "Địa chỉ";
            dgvDSKhachHang.Columns[3].Width = 150;
            dgvDSKhachHang.Columns[4].HeaderText = "Số điện thoại";
            dgvDSKhachHang.Columns[4].Width = 170;
            dgvDSKhachHang.Columns[5].HeaderText = "Số tiền đã mua";
            dgvDSKhachHang.Columns[5].Width = 170;
            dgvDSKhachHang.Columns[6].HeaderText = "Mã loại khách hàng";
            dgvDSKhachHang.Columns[6].Width = 170;
            dgvDSKhachHang.Columns[7].HeaderText = "Tên loại khách hàng";
            dgvDSKhachHang.Columns[7].Width = 200;

            dgvDSKhachHang.AllowUserToAddRows = false;
            dgvDSKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvDSKhachHang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (dgvDSKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string maKH = dgvDSKhachHang.CurrentRow.Cells["MaKH"].Value?.ToString();
            if (string.IsNullOrEmpty(maKH)) return;

            using (var context = new LKMTdbContext())
            {
                var khachHang = context.KhachHang
                   .Include(kh => kh.LoaiKH)
                   .FirstOrDefault(kh => kh.MaKH == maKH);


                if (khachHang != null)
                {
                    txtMaKH.Text = khachHang.MaKH;
                    txtTenKH.Text = khachHang.TenKH;
                    rbtnNam.Checked = khachHang.GioiTinh == "Nam";
                    rbtnNu.Checked = khachHang.GioiTinh == "Nữ";
                    txtDiaChi.Text = khachHang.DiaChi;
                    txtSDT.Text = khachHang.SDT;
                    txtSoTienDaMua.Text = khachHang.SoTienMua.ToString();
                    txtLoaiKH.Text = khachHang.LoaiKH?.TenLoai ?? "";
                }
            }
            PhanQuyen();
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

            txtMaKH.Enabled = true;
            txtMaKH.Focus();

            txtMaKH.ReadOnly = false;
            txtTenKH.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtSoTienDaMua.ReadOnly = true;
            txtLoaiKH.ReadOnly = true;

            txtSoTienDaMua.Text = "0";
            txtLoaiKH.Text = "Thường";
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";

            txtSoTienDaMua.Text = "0";
            txtLoaiKH.Text = "";
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
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

            string gioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";
            decimal tien = decimal.TryParse(txtSoTienDaMua.Text.Trim(), out decimal parsedTien) ? parsedTien : 0;

            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction()) 
            {
                try
                {
                    string maKH = txtMaKH.Text.Trim();

                    if (context.KhachHang.Find(maKH) != null) 
                    {
                        MessageBox.Show("Mã khách hàng này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaKH.Focus();
                        txtMaKH.Text = "";
                        return;
                    }

                    string maLoaiKH = Functions.GetMaLoaiKHTheoTien(tien);

                    var khachHang = new KhachHang
                    {
                        MaKH = maKH,
                        TenKH = txtTenKH.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        SDT = txtSDT.Text.Trim(),
                        GioiTinh = gioiTinh,
                        SoTienMua = tien,
                        MaLoaiKH = maLoaiKH
                    };

                    context.KhachHang.Add(khachHang);
                    logger.Info($"Người dùng {currentUsername} đã thêm khách hàng.");
                    context.SaveChanges();
                    transaction.Commit(); 
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi lưu khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtMaKH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
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

            string gioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";

            using (var context = new LKMTdbContext())
            {
                var khachHang = context.KhachHang.Find(txtMaKH.Text.Trim()); 
                if (khachHang != null)
                {
                    khachHang.TenKH = txtTenKH.Text.Trim();
                    khachHang.DiaChi = txtDiaChi.Text.Trim();
                    khachHang.SDT = txtSDT.Text.Trim();
                    khachHang.GioiTinh = gioiTinh;

                    logger.Info($"Người dùng {currentUsername} đã sửa khách hàng.");
                    context.SaveChanges(); 
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var khachHang = context.KhachHang.Find(txtMaKH.Text.Trim());
                if (khachHang != null)
                {
                    context.KhachHang.Remove(khachHang);
                    logger.Info($"Người dùng {currentUsername} đã xóa khách hàng.");
                    context.SaveChanges();
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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
                var query = context.KhachHang.Include(kh => kh.LoaiKH).AsQueryable();

                switch (cbNoiDungTK.Text)
                {
                    case "Mã khách hàng":
                        query = query.Where(kh => kh.MaKH.Contains(keyword));
                        break;
                    case "Tên khách hàng":
                        query = query.Where(kh => kh.TenKH.Contains(keyword));
                        break;
                    case "Loại khách hàng":
                        query = query.Where(kh => kh.LoaiKH.TenLoai.Contains(keyword));
                        break;
                    case "Giới tính":
                        query = query.Where(kh => kh.GioiTinh.Contains(keyword));
                        break;
                    case "Địa chỉ":
                        query = query.Where(kh => kh.DiaChi.Contains(keyword));
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

                dgvDSKhachHang.DataSource = query.ToList();
            }
        }

        private void btnHuyTK_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtTimKiem.Text = "";
            cbNoiDungTK.SelectedIndex = -1;
            txtTimKiem.Enabled = false;
        }

        private void cbNoiDungTK_SelectedndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Nhập dữ liệu Khách Hàng",
                Filter = "Excel Files|*.xlsx;*.xls"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new LKMTdbContext())
                    using (var transaction = db.Database.BeginTransaction()) 
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
                                        table.Columns.Add(cell.Value.ToString());
                                    }
                                    firstRow = false;
                                }
                                else
                                {
                                    var newRow = table.NewRow();
                                    int i = 0;
                                    foreach (var cell in row.Cells(1, table.Columns.Count))
                                    {
                                        newRow[i++] = cell.Value.ToString();
                                    }
                                    table.Rows.Add(newRow);
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                string maKH = row["Mã khách hàng"]?.ToString()?.Trim();
                                if (string.IsNullOrEmpty(maKH)) continue;

                                if (db.KhachHang.Find(maKH) == null)
                                {
                                    db.KhachHang.Add(new KhachHang
                                    {
                                        MaKH = maKH,
                                        TenKH = row["Tên khách hàng"]?.ToString()?.Trim(),
                                        GioiTinh = row["Giới tính"]?.ToString()?.Trim(),
                                        DiaChi = row["Địa chỉ"]?.ToString()?.Trim(),
                                        SDT = row["Số điện thoại"]?.ToString()?.Trim(),
                                        SoTienMua = decimal.TryParse(row["Số tiền đã mua"]?.ToString(), out decimal tien) ? tien : 0,
                                        MaLoaiKH = row["Mã loại khách hàng"]?.ToString()?.Trim()
                                    });
                                }
                            }

                            db.SaveChanges();
                            transaction.Commit();
                            logger.Info($"Người dùng {currentUsername} đã nhập dữ liệu khách hàng.");
                            MessageBox.Show("Nhập dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Lỗi khi đọc Excel:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Xuất dữ liệu Khách Hàng",
                Filter = "Excel Files|*.xlsx",
                FileName = $"KhachHang_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new LKMTdbContext())
                    {
                        var danhSachKhachHang = db.KhachHang
                            .Include(kh => kh.LoaiKH)
                            .Select(kh => new
                            {
                                kh.MaKH,
                                kh.TenKH,
                                kh.GioiTinh,
                                kh.DiaChi,
                                kh.SDT,
                                kh.SoTienMua,
                                kh.MaLoaiKH,
                                TenLoaiKH = kh.LoaiKH.TenLoai
                            })
                            .ToList();

                        DataTable table = new DataTable();
                        table.Columns.Add("Mã khách hàng", typeof(string));
                        table.Columns.Add("Tên khách hàng", typeof(string));
                        table.Columns.Add("Giới tính", typeof(string));
                        table.Columns.Add("Địa chỉ", typeof(string));
                        table.Columns.Add("Số điện thoại", typeof(string));
                        table.Columns.Add("Số tiền đã mua", typeof(decimal));
                        table.Columns.Add("Mã loại khách hàng", typeof(string));
                        table.Columns.Add("Tên loại khách hàng", typeof(string));

                        foreach (var kh in danhSachKhachHang)
                        {
                            table.Rows.Add(
                                kh.MaKH, kh.TenKH, kh.GioiTinh, kh.DiaChi, kh.SDT, kh.SoTienMua, kh.MaLoaiKH, kh.TenLoaiKH
                            );
                        }

                        using (var workbook = new XLWorkbook())
                        {
                            var sheet = workbook.Worksheets.Add(table, "KhachHang");
                            sheet.Columns().AdjustToContents();
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                    }
                    logger.Info($"Người dùng {currentUsername} đã xuất dữ liệu khách hàng.");
                    MessageBox.Show("Xuất dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
