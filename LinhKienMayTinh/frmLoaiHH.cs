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
    public partial class frmLoaiHH : Form
    {
        private DataTable tblLoaiHH = new DataTable();
        private string currentUserRole;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmLoaiHH(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void frmLoaiHH_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            LoadDataGridView();

            txtMaLoaiHH.ReadOnly = true;
            txtTenLoaiHH.ReadOnly = true;
            txtSoLuong.ReadOnly = true;

            txtTimKiem.Enabled = false;

            cbNoiDungTK.Items.Clear();
            cbNoiDungTK.Items.Add("Mã loại hàng hóa");
            cbNoiDungTK.Items.Add("Tên loại hàng hóa");
            cbNoiDungTK.SelectedIndex = -1;

            using (var context = new LKMTdbContext())
            {
                var user = context.TaiKhoan.FirstOrDefault(u => u.Username == currentUsername);
                if (user != null)
                    currentUserRole = user.QuyenHan;
            }
            PhanQuyen();

            using (var context = new LKMTdbContext())
            {
                var danhSachLoaiHH = context.LoaiHH.ToList();
                foreach (var loaiHH in danhSachLoaiHH)
                {
                    loaiHH.SoLuong = context.HangHoa.Where(hh => hh.MaLoaiHH == loaiHH.MaLoaiHH).Sum(hh => hh.SoLuong);
                }
                context.SaveChanges();

                var danhSachLoaiHHView = danhSachLoaiHH.Select(lh => new
                {
                    lh.MaLoaiHH,
                    lh.TenLoai,
                    lh.SoLuong
                }).ToList();

                dgvDSLoaiHH.DataSource = danhSachLoaiHHView;
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

        private void cbNoiDungTK_SelectedValueChanged(object? sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var danhSachLoaiHH = context.LoaiHH
                    .Select(lh => new
                    {
                        lh.MaLoaiHH,
                        lh.TenLoai,
                        lh.SoLuong
                    })
                    .ToList();

                dgvDSLoaiHH.DataSource = danhSachLoaiHH;
            }

            dgvDSLoaiHH.Columns[0].HeaderText = "Mã loại hàng hóa";
            dgvDSLoaiHH.Columns[0].Width = 270;
            dgvDSLoaiHH.Columns[1].HeaderText = "Tên loại hàng hóa";
            dgvDSLoaiHH.Columns[1].Width = 430;
            dgvDSLoaiHH.Columns[2].HeaderText = "Số lượng";
            dgvDSLoaiHH.Columns[2].Width = 250;

            dgvDSLoaiHH.AllowUserToAddRows = false;
            dgvDSLoaiHH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvDSLoaiHH_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiHH.Focus();
                return;
            }
            if (dgvDSLoaiHH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maLoaiHH = dgvDSLoaiHH.CurrentRow.Cells["MaLoaiHH"].Value?.ToString();
            if (string.IsNullOrEmpty(maLoaiHH)) return;

            using (var context = new LKMTdbContext())
            {
                var loaiHH = context.LoaiHH.Find(maLoaiHH);
                if (loaiHH != null)
                {
                    txtMaLoaiHH.Text = loaiHH.MaLoaiHH;
                    txtTenLoaiHH.Text = loaiHH.TenLoai;
                    txtSoLuong.Text = loaiHH.SoLuong.ToString();
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

            txtMaLoaiHH.Enabled = true;
            txtMaLoaiHH.Focus();
            txtMaLoaiHH.ReadOnly = false;
            txtTenLoaiHH.ReadOnly = false;

            txtSoLuong.Text = "0";
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaLoaiHH.Text = "";
            txtTenLoaiHH.Text = "";
            txtSoLuong.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoaiHH.Text))
            {
                MessageBox.Show("Bạn phải nhập mã loại hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoaiHH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenLoaiHH.Text))
            {
                MessageBox.Show("Bạn phải nhập tên loại hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoaiHH.Focus();
                return;
            }

            using (var context = new LKMTdbContext())
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    string maLoaiHH = txtMaLoaiHH.Text.Trim();

                    if (context.LoaiHH.Find(maLoaiHH) != null)
                    {
                        MessageBox.Show("Mã loại này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLoaiHH.Focus();
                        txtMaLoaiHH.Text = "";
                        return;
                    }

                    var loaiHH = new LoaiHH
                    {
                        MaLoaiHH = maLoaiHH,
                        TenLoai = txtTenLoaiHH.Text.Trim(),
                        SoLuong = int.TryParse(txtSoLuong.Text.Trim(), out int sl) ? sl : 0
                    };

                    context.LoaiHH.Add(loaiHH);
                    logger.Info($"Người dùng {currentUsername} đã thêm loại hàng hóa");
                    context.SaveChanges();
                    transaction.Commit(); 
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi lưu loại hàng hóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadDataGridView();
            ResetValues();
            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;
            btnHuyTK.Enabled = true;
            btnLuu.Enabled = false;
            txtMaLoaiHH.Enabled = false;
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
                var query = context.LoaiHH.AsQueryable();

                switch (cbNoiDungTK.Text)
                {
                    case "Mã loại hàng hóa":
                        query = query.Where(lh => lh.MaLoaiHH.Contains(keyword));
                        break;
                    case "Tên loại hàng hóa":
                        query = query.Where(lh => lh.TenLoai.Contains(keyword));
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

                dgvDSLoaiHH.DataSource = query.ToList();
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
            if (string.IsNullOrWhiteSpace(txtMaLoaiHH.Text))
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var loaiHH = context.LoaiHH.Find(txtMaLoaiHH.Text.Trim());
                if (loaiHH != null)
                {
                    context.LoaiHH.Remove(loaiHH);
                    logger.Info($"Người dùng {currentUsername} đã xóa loại hàng hóa");
                    context.SaveChanges();
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }
    }
}
