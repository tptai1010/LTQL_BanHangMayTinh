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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using ClosedXML.Excel;
using LinhKienMayTinh.Data;
using Microsoft.EntityFrameworkCore;
using NLog;

namespace LinhKienMayTinh
{
    public partial class frmHangHoa : Form
    {
        private DataTable tblHangHoa = new DataTable();
        private string currentUserRole;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmHangHoa(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            LoadDataGridView();

            txtMaHH.ReadOnly = true;
            txtTenHH.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtDGNhap.ReadOnly = true;
            txtDGBan.ReadOnly = true;
            txtAnh.ReadOnly = true;

            using (var context = new LKMTdbContext())
            {
                var danhSachLoaiHH = context.LoaiHH
                    .Select(lh => new { lh.MaLoaiHH, lh.TenLoai })
                    .ToList();

                cbLoaiHH.DataSource = danhSachLoaiHH;
                cbLoaiHH.DisplayMember = "TenLoai";
                cbLoaiHH.ValueMember = "MaLoaiHH";
            }

            cbHangSX.Items.Clear();
            cbHangSX.Items.Add("a");
            cbHangSX.Items.Add("b");
            cbHangSX.Items.Add("c");
            cbHangSX.SelectedIndex = -1;

            cbNoiDungTK.Items.Clear();
            cbNoiDungTK.Items.Add("Mã hàng hóa");
            cbNoiDungTK.Items.Add("Tên hàng hóa");
            cbNoiDungTK.Items.Add("Hãng sản xuất");
            cbNoiDungTK.Items.Add("Loại hàng hóa");
            cbNoiDungTK.SelectedIndex = -1;
            txtTimKiem.Enabled = false;

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
                var danhSachHangHoa = context.HangHoa
                    .Include(hh => hh.LoaiHH)
                    .Select(hh => new
                    {
                        hh.MaHH,
                        hh.TenHH,
                        hh.HangSX,
                        hh.MaLoaiHH,
                        TenLoaiHH = hh.LoaiHH.TenLoai,
                        hh.SoLuong,
                        hh.Anh,
                        hh.DGNhap,
                        hh.DGBan
                    })
                    .ToList();

                dgvDSHangHoa.DataSource = danhSachHangHoa;
            }

            dgvDSHangHoa.Columns[0].HeaderText = "Mã hàng hóa";
            dgvDSHangHoa.Columns[0].Width = 150;
            dgvDSHangHoa.Columns[1].HeaderText = "Tên hàng hóa";
            dgvDSHangHoa.Columns[1].Width = 300;
            dgvDSHangHoa.Columns[2].HeaderText = "Hãng sản xuất";
            dgvDSHangHoa.Columns[2].Width = 200;
            dgvDSHangHoa.Columns[3].HeaderText = "Mã loại hàng hóa";
            dgvDSHangHoa.Columns[3].Width = 150;
            dgvDSHangHoa.Columns[4].HeaderText = "Tên loại hàng hóa";
            dgvDSHangHoa.Columns[4].Width = 200;
            dgvDSHangHoa.Columns[5].HeaderText = "Số lượng";
            dgvDSHangHoa.Columns[5].Width = 130;
            dgvDSHangHoa.Columns[6].HeaderText = "Ảnh";
            dgvDSHangHoa.Columns[6].Width = 200;
            dgvDSHangHoa.Columns[7].HeaderText = "Đơn giá nhập";
            dgvDSHangHoa.Columns[7].Width = 150;
            dgvDSHangHoa.Columns[8].HeaderText = "Đơn giá bán";
            dgvDSHangHoa.Columns[8].Width = 150;

            dgvDSHangHoa.AllowUserToAddRows = false;
            dgvDSHangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadInfoHangHoa()
        {
            using (var context = new LKMTdbContext())
            {
                var maLoaiHH = context.HangHoa
                    .Where(hh => hh.MaHH == txtMaHH.Text.Trim())
                    .Select(hh => hh.MaLoaiHH)
                    .FirstOrDefault();

                cbLoaiHH.SelectedValue = maLoaiHH;
            }
        }

        private void cbNoiDungTK_SelectedIndexChanged(object? sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void btnLoaiHH_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoaiHH frmLoaiHH = new frmLoaiHH(currentUsername);
            frmLoaiHH.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frmLoaiHH.ShowDialog();
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void dgvDSHangHoa_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHH.Focus();
                return;
            }
            if (dgvDSHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maHH = dgvDSHangHoa.CurrentRow.Cells["MaHH"].Value?.ToString();
            if (string.IsNullOrEmpty(maHH)) return;

            using (var context = new LKMTdbContext())
            {
                var hangHoa = context.HangHoa.Include(hh => hh.LoaiHH).FirstOrDefault(hh => hh.MaHH == maHH);
                if (hangHoa != null)
                {
                    txtMaHH.Text = hangHoa.MaHH;
                    txtTenHH.Text = hangHoa.TenHH;
                    cbLoaiHH.Text = hangHoa.LoaiHH?.TenLoai ?? "";
                    cbHangSX.Text = hangHoa.HangSX;
                    txtSoLuong.Text = hangHoa.SoLuong.ToString();
                    txtDGNhap.Text = hangHoa.DGNhap.ToString();
                    txtDGBan.Text = hangHoa.DGBan.ToString();

                    txtAnh.Text = hangHoa.Anh;
                    picAnh.Image = File.Exists(hangHoa.Anh) ? Image.FromFile(hangHoa.Anh) : null;
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

            txtMaHH.Enabled = true;
            txtMaHH.Focus();

            txtMaHH.ReadOnly = false;
            txtTenHH.ReadOnly = false;
            txtAnh.ReadOnly = false;

            txtSoLuong.Text = "0";
            txtDGNhap.Text = "0";
            txtDGBan.Text = "0";

            cbHangSX.Enabled = true;
            cbLoaiHH.Enabled = true;

            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            cbLoaiHH.SelectedIndex = -1;
            cbHangSX.SelectedIndex = -1;
            txtAnh.Text = "";
            picAnh.Image = null;

            txtSoLuong.Text = "0";
            txtDGNhap.Text = "0";
            txtDGBan.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHH.Text))
            {
                MessageBox.Show("Bạn phải nhập mã hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenHH.Text))
            {
                MessageBox.Show("Bạn phải nhập tên hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbHangSX.Text))
            {
                MessageBox.Show("Bạn phải chọn hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbHangSX.Focus();
                return;
            }
            if (cbLoaiHH.SelectedValue == null || string.IsNullOrWhiteSpace(cbLoaiHH.Text))
            {
                MessageBox.Show("Bạn phải chọn loại hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLoaiHH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAnh.Text))
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAnh.Focus();
                return;
            }

            int soLuong = int.TryParse(txtSoLuong.Text.Trim(), out int sl) ? sl : 0;
            decimal dgNhap = decimal.TryParse(txtDGNhap.Text.Trim(), out decimal dgN) ? dgN : 0;
            decimal dgBan = decimal.TryParse(txtDGBan.Text.Trim(), out decimal dgB) ? dgB : 0;

            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    string maHH = txtMaHH.Text.Trim();

                    if (context.HangHoa.Find(maHH) != null) 
                    {
                        MessageBox.Show("Mã hàng này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaHH.Focus();
                        txtMaHH.Text = "";
                        return;
                    }

                    var hangHoa = new HangHoa
                    {
                        MaHH = maHH,
                        TenHH = txtTenHH.Text.Trim(),
                        HangSX = cbHangSX.Text.Trim(),
                        MaLoaiHH = cbLoaiHH.SelectedValue.ToString(),
                        SoLuong = soLuong,
                        DGNhap = dgNhap,
                        DGBan = dgBan,
                        Anh = txtAnh.Text.Trim()
                    };

                    context.HangHoa.Add(hangHoa);
                    logger.Info($"Người dùng {currentUsername} đã thêm hàng hóa.");
                    context.SaveChanges();
                    transaction.Commit(); 
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); 
                    MessageBox.Show("Lỗi khi lưu hàng hóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHH.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var hangHoa = context.HangHoa.Find(txtMaHH.Text.Trim());
                if (hangHoa != null)
                {
                    var loaiHH = context.LoaiHH.Find(hangHoa.MaLoaiHH);
                    if (loaiHH != null)
                    {
                        loaiHH.SoLuong -= hangHoa.SoLuong;
                    }

                    context.HangHoa.Remove(hangHoa);
                    logger.Info($"Người dùng {currentUsername} đã xóa hàng hóa.");
                    context.SaveChanges();
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHH.Text))
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenHH.Text))
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbHangSX.Text))
            {
                MessageBox.Show("Bạn phải chọn hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbHangSX.Focus();
                return;
            }
            if (cbLoaiHH.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbLoaiHH.Text))
            {
                MessageBox.Show("Bạn phải nhập loại hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbLoaiHH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAnh.Text))
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var hangHoa = context.HangHoa.Find(txtMaHH.Text.Trim());
                if (hangHoa != null)
                {
                    hangHoa.TenHH = txtTenHH.Text.Trim();
                    hangHoa.HangSX = cbHangSX.Text.Trim();
                    hangHoa.MaLoaiHH = cbLoaiHH.SelectedValue.ToString();
                    hangHoa.Anh = txtAnh.Text.Trim();
                    logger.Info($"Người dùng {currentUsername} đã sửa hàng hóa.");
                    context.SaveChanges();
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
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
                var query = context.HangHoa.Include(hh => hh.LoaiHH).AsQueryable();

                switch (cbNoiDungTK.Text)
                {
                    case "Mã hàng hóa":
                        query = query.Where(hh => hh.MaHH.Contains(keyword));
                        break;
                    case "Tên hàng hóa":
                        query = query.Where(hh => hh.TenHH.Contains(keyword));
                        break;
                    case "Loại hàng hóa":
                        query = query.Where(hh => hh.LoaiHH.TenLoai.Contains(keyword));
                        break;
                    case "Hãng sản xuất":
                        query = query.Where(hh => hh.HangSX.Contains(keyword));
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

                dgvDSHangHoa.DataSource = query.ToList();
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
                Title = "Nhập dữ liệu Hàng Hóa",
                Filter = "Excel Files|*.xlsx;*.xls"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new LKMTdbContext())
                    using (var transaction = db.Database.BeginTransaction()) // 🛠 Thêm Transaction
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
                                string maHH = row["Mã hàng hóa"]?.ToString()?.Trim();
                                string maLoaiHH = row["Mã loại hàng hóa"]?.ToString()?.Trim();
                                string tenLoaiHH = db.LoaiHH.Where(lh => lh.MaLoaiHH == maLoaiHH).Select(lh => lh.TenLoai).FirstOrDefault() ?? "Không xác định";
                                if (string.IsNullOrEmpty(maHH)) continue;

                                if (db.HangHoa.Find(maHH) == null)
                                {
                                    db.HangHoa.Add(new HangHoa
                                    {
                                        MaHH = maHH,
                                        TenHH = row["Tên hàng hóa"]?.ToString()?.Trim(),
                                        HangSX = row["Hãng sản xuất"]?.ToString()?.Trim(),
                                        MaLoaiHH = maLoaiHH,
                                        SoLuong = int.TryParse(row["Số lượng"]?.ToString(), out int sl) ? sl : 0,
                                        Anh = row["Ảnh"]?.ToString()?.Trim(),
                                        DGNhap = decimal.TryParse(row["Đơn giá nhập"]?.ToString(), out decimal dgN) ? dgN : 0,
                                        DGBan = decimal.TryParse(row["Đơn giá bán"]?.ToString(), out decimal dgB) ? dgB : 0
                                    });
                                }
                            }

                            db.SaveChanges();
                            transaction.Commit();
                            logger.Info($"Người dùng {currentUsername} đã nhập dữ liệu hàng hóa.");
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
                Title = "Xuất dữ liệu Hàng Hóa",
                Filter = "Excel Files|*.xlsx",
                FileName = $"HangHoa_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new LKMTdbContext())
                    {
                        var danhSachHangHoa = db.HangHoa
                            .Include(hh => hh.LoaiHH)
                            .Select(hh => new
                            {
                                hh.MaHH,
                                hh.TenHH,
                                hh.HangSX,
                                hh.MaLoaiHH,
                                TenLoaiHH = hh.LoaiHH.TenLoai,
                                hh.SoLuong,
                                hh.Anh,
                                hh.DGNhap,
                                hh.DGBan
                            })
                            .ToList();

                        DataTable table = new DataTable();
                        table.Columns.Add("Mã hàng hóa", typeof(string));
                        table.Columns.Add("Tên hàng hóa", typeof(string));
                        table.Columns.Add("Hãng sản xuất", typeof(string));
                        table.Columns.Add("Mã loại hàng hóa", typeof(string));
                        table.Columns.Add("Tên loại hàng hóa", typeof(string));
                        table.Columns.Add("Số lượng", typeof(int));
                        table.Columns.Add("Ảnh", typeof(string));
                        table.Columns.Add("Đơn giá nhập", typeof(decimal));
                        table.Columns.Add("Đơn giá bán", typeof(decimal));

                        foreach (var hh in danhSachHangHoa)
                        {
                            table.Rows.Add(hh.MaHH, hh.TenHH, hh.HangSX, hh.MaLoaiHH, hh.TenLoaiHH, hh.SoLuong, hh.Anh, hh.DGNhap, hh.DGBan);
                        }

                        using (var workbook = new XLWorkbook())
                        {
                            var sheet = workbook.Worksheets.Add(table, "Hàng Hóa");
                            sheet.Columns().AdjustToContents();
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                    }
                    logger.Info($"Người dùng {currentUsername} đã xuất dữ liệu hàng hóa.");
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
