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
using LinhKienMayTinh.Data;
using NLog;

namespace LinhKienMayTinh
{
    public partial class frmNhaCungCap : Form
    {
        private DataTable tblNCC = new DataTable();
        private string currentUserRole;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmNhaCungCap(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            LoadDataGridView();

            txtMaNCC.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtDiaChi.ReadOnly = true;

            cbNoiDungTK.Items.Clear();
            cbNoiDungTK.Items.Add("Mã nhà cung cấp");
            cbNoiDungTK.Items.Add("Tên nhà cung cấp");
            cbNoiDungTK.Items.Add("Địa chỉ");
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
                var danhSachNCC = context.NhaCungCap
                    .Select(ncc => new {
                        ncc.MaNCC,
                        ncc.TenNCC,
                        ncc.DiaChi,
                        ncc.SDT,
                        ncc.Email
                    }).ToList();

                dgvDS_NCC.DataSource = danhSachNCC;
            }
            dgvDS_NCC.Columns[0].HeaderText = "Mã nhà cung câp";
            dgvDS_NCC.Columns[0].Width = 200;
            dgvDS_NCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvDS_NCC.Columns[1].Width = 280;
            dgvDS_NCC.Columns[2].HeaderText = "Địa chỉ";
            dgvDS_NCC.Columns[2].Width = 150;
            dgvDS_NCC.Columns[3].HeaderText = "Số điện thoại";
            dgvDS_NCC.Columns[3].Width = 150;
            dgvDS_NCC.Columns[4].HeaderText = "Email";
            dgvDS_NCC.Columns[4].Width = 250;

            dgvDS_NCC.AllowUserToAddRows = false;
            dgvDS_NCC.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void cbNoiDungTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void dgvDS_NCC_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return;
            }
            if (dgvDS_NCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maNCC = dgvDS_NCC.CurrentRow.Cells["MaNCC"].Value?.ToString();
            if (string.IsNullOrEmpty(maNCC)) return;

            using (var context = new LKMTdbContext())
            {
                var nhaCungCap = context.NhaCungCap.Find(maNCC);
                if (nhaCungCap != null)
                {
                    txtMaNCC.Text = nhaCungCap.MaNCC;
                    txtTenNCC.Text = nhaCungCap.TenNCC;
                    txtDiaChi.Text = nhaCungCap.DiaChi;
                    txtSDT.Text = nhaCungCap.SDT;
                    txtEmail.Text = nhaCungCap.Email;
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
            txtMaNCC.Enabled = true;
            txtMaNCC.Focus();

            txtMaNCC.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTenNCC.ReadOnly = false;
            txtEmail.ReadOnly = false;

            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
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
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    string maNCC = txtMaNCC.Text.Trim();

                    if (context.NhaCungCap.Any(n => n.MaNCC == maNCC))
                    {
                        MessageBox.Show("Mã nhà cung cấp đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNCC.Focus();
                        txtMaNCC.Text = "";
                        return;
                    }

                    var ncc = new NhaCungCap
                    {
                        MaNCC = maNCC,
                        TenNCC = txtTenNCC.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        SDT = txtSDT.Text.Trim(),
                        Email = txtEmail.Text.Trim()
                    };

                    context.NhaCungCap.Add(ncc);
                    logger.Info($"Người dùng {currentUsername} đã thêm nhà cung cấp.");
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi lưu nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
            txtMaNCC.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDS_NCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new LKMTdbContext())
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var ncc = context.NhaCungCap.FirstOrDefault(n => n.MaNCC == txtMaNCC.Text.Trim());
                        if (ncc != null)
                        {
                            context.NhaCungCap.Remove(ncc);
                            logger.Info($"Người dùng {currentUsername} đã xóa nhà cung cấp.");
                            context.SaveChanges();
                            transaction.Commit();
                            LoadDataGridView();
                            ResetValues();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhà cung cấp để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi xóa nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDS_NCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
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
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var ncc = context.NhaCungCap.Find(txtMaNCC.Text.Trim());
                    if (ncc != null)
                    {
                        ncc.TenNCC = txtTenNCC.Text.Trim();
                        ncc.DiaChi = txtDiaChi.Text.Trim();
                        ncc.SDT = txtSDT.Text.Trim();
                        ncc.Email = txtEmail.Text.Trim();

                        logger.Info($"Người dùng {currentUsername} đã sửa nhà cung cấp.");
                        context.SaveChanges();
                        transaction.Commit();

                        LoadDataGridView();
                        ResetValues();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhà cung cấp để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi sửa nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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

            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập nội dung cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimKiem.Focus();
                return;
            }

            string key = txtTimKiem.Text.Trim();
            using (var context = new LKMTdbContext())
            {
                IQueryable<NhaCungCap> query = context.NhaCungCap.AsQueryable();

                if (cbNoiDungTK.Text == "Mã nhà cung cấp")
                {
                    query = query.Where(ncc => ncc.MaNCC.Contains(key));
                }
                else if (cbNoiDungTK.Text == "Tên nhà cung cấp")
                {
                    query = query.Where(ncc => ncc.TenNCC.Contains(key));
                }
                else if (cbNoiDungTK.Text == "Địa chỉ")
                {
                    query = query.Where(ncc => ncc.DiaChi.Contains(key));
                }
                else
                {
                    MessageBox.Show("Loại tìm kiếm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tblNCC = new DataTable();
                tblNCC.Columns.Add("MaNCC");
                tblNCC.Columns.Add("TenNCC");
                tblNCC.Columns.Add("DiaChi");
                tblNCC.Columns.Add("SDT");
                tblNCC.Columns.Add("Email");

                foreach (var ncc in query.ToList())
                {
                    tblNCC.Rows.Add(ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT, ncc.Email);
                }

                dgvDS_NCC.DataSource = tblNCC;

                if (tblNCC.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                Title = "Nhập dữ liệu Nhà Cung Cấp",
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
                        using (var workbook = new ClosedXML.Excel.XLWorkbook(openFileDialog.FileName))
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
                                var maNCC = row["Mã nhà cung cấp"]?.ToString()?.Trim();
                                if (string.IsNullOrEmpty(maNCC)) continue;

                                var existingNCC = db.NhaCungCap.Find(maNCC);
                                if (existingNCC == null)
                                {
                                    db.NhaCungCap.Add(new NhaCungCap
                                    {
                                        MaNCC = maNCC,
                                        TenNCC = row["Tên nhà cung cấp"]?.ToString()?.Trim() ?? "Không xác định",
                                        DiaChi = row["Địa chỉ"]?.ToString()?.Trim() ?? "Không có dữ liệu",
                                        SDT = row["Số điện thoại"]?.ToString()?.Trim() ?? "0000000000",
                                        Email = row["Email"]?.ToString()?.Trim() ?? "khong@xacdinh.com"
                                    });
                                }
                            }

                            db.SaveChanges();
                            transaction.Commit();
                            logger.Info($"Người dùng {currentUsername} đã nhập dữ liệu nhà cung cấp.");
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
                Title = "Xuất dữ liệu Nhà Cung Cấp",
                Filter = "Excel Files|*.xlsx",
                FileName = $"NhaCungCap_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new LKMTdbContext())
                    {
                        var danhSachNCC = db.NhaCungCap.ToList();

                        var table = new DataTable();
                        table.Columns.Add("Mã nhà cung cấp", typeof(string));
                        table.Columns.Add("Tên nhà cung cấp", typeof(string));
                        table.Columns.Add("Địa chỉ", typeof(string));
                        table.Columns.Add("Số điện thoại", typeof(string));
                        table.Columns.Add("Email", typeof(string));

                        foreach (var ncc in danhSachNCC)
                        {
                            table.Rows.Add(ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT, ncc.Email);
                        }

                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var sheet = workbook.Worksheets.Add(table, "NhaCungCap");
                            sheet.Columns().AdjustToContents();
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                    }
                    logger.Info($"Người dùng {currentUsername} đã xuất dữ liệu nhà cung cấp.");
                    MessageBox.Show("Xuất dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
