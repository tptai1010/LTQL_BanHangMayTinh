using DocumentFormat.OpenXml.InkML;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using NLog;

namespace LinhKienMayTinh
{
    public partial class frmThongTinDN : Form
    {
        private string currentUsername = string.Empty;
        private string currentPassword = string.Empty;
        private string currentRole = string.Empty;
        private string currentHoTen = string.Empty;
        private string currentNgaySinh = string.Empty;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmThongTinDN(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            using (var context = new LKMTdbContext())
            {
                var user = context.TaiKhoan.FirstOrDefault(tk => tk.Username == currentUsername);
                if (user != null)
                {
                    currentUsername = user.Username;
                    currentPassword = user.Password;
                    currentHoTen = user.HoTen;
                    currentNgaySinh = user.NgaySinh.ToString("yyyy-MM-dd");
                    currentRole = user.QuyenHan;
                }
            }
        }

        private void frmThongTinDN_Load(object sender, EventArgs e)
        {
            txtUsername.Text = currentUsername;
            txtHoTen.Text = currentHoTen;
            txtNgaySinh.Text = currentNgaySinh;
            mtxtPassword.Text = new string('●', currentPassword.Length);
            txtQuyenHan.Text = currentRole;

            txtUsername.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;
            txtQuyenHan.ReadOnly = true;

            grDSTaiKhoan.Visible = (currentRole == "Admin");
            if (currentRole == "Admin")
            {
                LoadDataGridView();
            }

            cbQuyen.Items.Add("Admin");
            cbQuyen.Items.Add("NhanVien");
            cbQuyen.Items.Add("QuanLy");
        }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var users = context.TaiKhoan
                    .Select(tk => new
                    {
                        tk.Username,
                        tk.HoTen,
                        NgaySinh = tk.NgaySinh.ToString("yyyy-MM-dd"),
                        tk.QuyenHan
                    })
                    .ToList();

                dgvDSTaiKhoan.DataSource = users;
            }

            dgvDSTaiKhoan.Columns[0].HeaderText = "Username";
            dgvDSTaiKhoan.Columns[0].Width = 100;
            dgvDSTaiKhoan.Columns[1].HeaderText = "Họ và tên";
            dgvDSTaiKhoan.Columns[1].Width = 250;
            dgvDSTaiKhoan.Columns[2].HeaderText = "Ngày sinh";
            dgvDSTaiKhoan.Columns[2].Width = 150;
            dgvDSTaiKhoan.Columns[3].HeaderText = "Quyền";
            dgvDSTaiKhoan.Columns[3].Width = 100;

            dgvDSTaiKhoan.AllowUserToAddRows = false;
            dgvDSTaiKhoan.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (mtxtPassword.PasswordChar == '●')
            {
                mtxtPassword.PasswordChar = '\0';
                mtxtPassword.Text = currentPassword;
                btnShowPassword.Text = "√";
            }
            else
            {
                mtxtPassword.PasswordChar = '●';
                mtxtPassword.Text = new string('●', currentPassword.Length);
                btnShowPassword.Text = " ";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                string newPassword = mtxtPassword.Text.Trim();

                if (string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = context.TaiKhoan.FirstOrDefault(tk => tk.Username == currentUsername);
                if (user == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (VerifyPassword(newPassword, user.Password))
                {
                    MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                user.Password = HashPassword(newPassword);

                try
                {
                    context.SaveChanges();
                    logger.Info($"Người dùng {currentUsername} đã cập nhật mật khẩu thành công.");
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        private bool VerifyPassword(string inputPassword, string storedHashedPassword)
        {
            return HashPassword(inputPassword) == storedHashedPassword;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiQuyen_Click(object sender, EventArgs e)
        {
            if (dgvDSTaiKhoan.CurrentRow?.Cells["Username"]?.Value == null)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbQuyen.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn quyền mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedUsername = dgvDSTaiKhoan.CurrentRow.Cells["Username"].Value?.ToString() ?? "";
            string newRole = cbQuyen.SelectedItem?.ToString() ?? "";
            string currentSelectedRole = dgvDSTaiKhoan.CurrentRow.Cells["QuyenHan"].Value?.ToString() ?? "";

            if (currentSelectedRole == newRole)
            {
                MessageBox.Show("Quyền mới không được trùng với quyền hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var user = context.TaiKhoan.FirstOrDefault(tk => tk.Username == selectedUsername);
                if (user != null)
                {
                    user.QuyenHan = newRole;
                    context.SaveChanges();

                    logger.Info($"Người dùng {currentUsername} đã cập nhật quyền hạn.");
                    MessageBox.Show("Cập nhật quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDSTaiKhoan.CurrentRow.Cells["QuyenHan"].Value = newRole;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new LKMTdbContext())
            {
                var searchResults = context.TaiKhoan
                    .Where(tk => tk.Username.Contains(keyword))
                    .Select(tk => new
                    {
                        tk.Username,
                        tk.HoTen,
                        NgaySinh = tk.NgaySinh.ToString("yyyy-MM-dd"),
                        tk.QuyenHan
                    })
                    .ToList();

                if (searchResults.Any())
                {
                    dgvDSTaiKhoan.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSTaiKhoan.CurrentRow?.Cells["Username"]?.Value == null)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvDSTaiKhoan.CurrentRow.Cells["Username"].Value?.ToString() ?? "";

            if (MessageBox.Show($"Bạn có chắc muốn xóa tài khoản '{username}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new LKMTdbContext())
                {
                    var user = context.TaiKhoan.FirstOrDefault(tk => tk.Username == username);
                    if (user != null)
                    {
                        context.TaiKhoan.Remove(user);
                        context.SaveChanges();

                        logger.Info($"Người dùng {currentUsername} đã xóa tài khoản.");
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuyTK_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtTimKiem.Text = "";
        }
    }
}
