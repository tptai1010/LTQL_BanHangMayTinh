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
using NLog;

namespace LinhKienMayTinh
{
    public partial class frmLoaiKH : Form
    {
        private DataTable tblLoaiKH = new DataTable();
        private string currentUserRole;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmLoaiKH(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void frmLoaiKH_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            LoadDataGridView();

            txtMaLoaiKH.ReadOnly = true;
            txtTenLoaiKH.ReadOnly = true;

            txtTimKiem.Enabled = false;

            cbNoiDungTK.Items.Clear();
            cbNoiDungTK.Items.Add("Mã loại");
            cbNoiDungTK.Items.Add("Tên loại");
            cbNoiDungTK.SelectedIndex = -1;

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
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var danhSachLoaiKH = context.LoaiKH
                    .Select(lk => new
                    {
                        lk.MaLoaiKH,
                        lk.TenLoai,
                        lk.ChietKhau
                    })
                    .ToList(); // 🛠 Lấy dữ liệu bằng LINQ thay vì SQL thuần

                dgvDSLoaiKH.DataSource = danhSachLoaiKH;
            }

            dgvDSLoaiKH.Columns[0].HeaderText = "Mã loại khách hàng";
            dgvDSLoaiKH.Columns[0].Width = 270;
            dgvDSLoaiKH.Columns[1].HeaderText = "Tên loại khách hàng";
            dgvDSLoaiKH.Columns[1].Width = 430;
            dgvDSLoaiKH.Columns[2].HeaderText = "Chiết khấu";
            dgvDSLoaiKH.Columns[2].Width = 250;

            dgvDSLoaiKH.AllowUserToAddRows = false;
            dgvDSLoaiKH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void cbNoiDungTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void dgvDSLoaiKH_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiKH.Focus();
                return;
            }
            if (dgvDSLoaiKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maLoaiKH = dgvDSLoaiKH.CurrentRow.Cells["MaLoaiKH"].Value?.ToString();
            if (string.IsNullOrEmpty(maLoaiKH)) return;

            using (var context = new LKMTdbContext())
            {
                var loaiKH = context.LoaiKH.Find(maLoaiKH);
                if (loaiKH != null)
                {
                    txtMaLoaiKH.Text = loaiKH.MaLoaiKH;
                    txtTenLoaiKH.Text = loaiKH.TenLoai;
                    txtChietKhau.Text = loaiKH.ChietKhau.ToString("0.#") + "%";
                }
            }
            PhanQuyen();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            ResetValues();
            btnTimKiem.Enabled = false;
            btnHuyTK.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;

            txtMaLoaiKH.Enabled = true;
            txtMaLoaiKH.Focus();
            txtMaLoaiKH.ReadOnly = false;
            txtTenLoaiKH.ReadOnly = false;
            txtChietKhau.ReadOnly = false;

            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaLoaiKH.Text = "";
            txtTenLoaiKH.Text = "";
            txtChietKhau.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoaiKH.Text))
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoaiKH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenLoaiKH.Text))
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoaiKH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtChietKhau.Text))
            {
                MessageBox.Show("Bạn phải nhập chiết khấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChietKhau.Focus();
                return;
            }

            string input = txtChietKhau.Text.Trim().Replace("%", "");
            if (!decimal.TryParse(input, out decimal chietkhau))
            {
                MessageBox.Show("Chiết khấu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChietKhau.Focus();
                return;
            }

            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction()) 
            {
                try
                {
                    string maLoaiKH = txtMaLoaiKH.Text.Trim();

                    if (context.LoaiKH.Find(maLoaiKH) != null) 
                    {
                        MessageBox.Show("Mã loại này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLoaiKH.Focus();
                        txtMaLoaiKH.Text = "";
                        return;
                    }

                    // Thêm mới loại khách hàng
                    var loaiKH = new LoaiKH
                    {
                        MaLoaiKH = maLoaiKH,
                        TenLoai = txtTenLoaiKH.Text.Trim(),
                        ChietKhau = chietkhau
                    };

                    context.LoaiKH.Add(loaiKH);
                    logger.Info($"Người dùng {currentUsername} đã thêm loại khách hàng.");
                    context.SaveChanges();
                    transaction.Commit(); 
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // 🛠 Nếu có lỗi, rollback để tránh mất dữ liệu
                    MessageBox.Show("Lỗi khi lưu loại khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadDataGridView();
            ResetValues();
            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;
            btnSua.Enabled = true;
            btnHuyTK.Enabled = true;
            btnLuu.Enabled = false;
            txtMaLoaiKH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenLoaiKH.ReadOnly = true;
            if (string.IsNullOrWhiteSpace(txtMaLoaiKH.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtChietKhau.Text))
            {
                MessageBox.Show("Bạn phải nhập chiết khấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChietKhau.Focus();
                return;
            }

            string input = txtChietKhau.Text.Trim().Replace("%", "");
            if (!decimal.TryParse(input, out decimal chietkhau))
            {
                MessageBox.Show("Chiết khấu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChietKhau.Focus();
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var loaiKH = context.LoaiKH.Find(txtMaLoaiKH.Text.Trim());
                if (loaiKH != null)
                {
                    loaiKH.ChietKhau = chietkhau;
                    logger.Info($"Người dùng {currentUsername} đã sửa loại khách hàng.");
                    context.SaveChanges();
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }

        private void txtChietKhau_Leave(object sender, EventArgs e)
        {
            string input = txtChietKhau.Text.Trim().Replace("%", "");

            if (decimal.TryParse(input, out decimal value))
            {
                if (value > 100)
                {
                    MessageBox.Show("Chiết khấu không được lớn hơn 100%", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChietKhau.Focus();
                    return;
                }

                txtChietKhau.Text = value.ToString("0.#") + "%";
            }
            else
            {
                MessageBox.Show("Chiết khấu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChietKhau.Focus();
            }
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

            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Bạn phải nhập nội dung cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimKiem.Focus();
                return;
            }

            string keyword = txtTimKiem.Text.Trim();

            using (var context = new LKMTdbContext())
            {
                var query = context.LoaiKH.AsQueryable();

                switch (cbNoiDungTK.Text)
                {
                    case "Mã loại khách hàng":
                        query = query.Where(lk => lk.MaLoaiKH.Contains(keyword));
                        break;
                    case "Tên loại khách hàng":
                        query = query.Where(lk => lk.TenLoai.Contains(keyword));
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

                dgvDSLoaiKH.DataSource = query.ToList(); 
            }
        }

        private void btnHuyTK_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtTimKiem.Text = "";
            cbNoiDungTK.SelectedIndex = -1;
            txtTimKiem.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoaiKH.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var loaiKH = context.LoaiKH.Find(txtMaLoaiKH.Text.Trim());
                if (loaiKH != null)
                {
                    context.LoaiKH.Remove(loaiKH);
                    logger.Info($"Người dùng {currentUsername} đã xóa loại khách hàng");
                    context.SaveChanges();
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }

        private void dgvDSLoaiKH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSLoaiKH.Columns[e.ColumnIndex].Name == "ChietKhau" && e.Value != null)
            {
                if (e.Value is decimal ck)
                {
                    e.Value = $"{ck:0.#}%";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
