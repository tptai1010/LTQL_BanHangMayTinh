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

namespace LinhKienMayTinh
{
    public partial class frmDKTK : Form
    {
        public frmDKTK()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                string username = txtUsername.Text.Trim();
                string password = mtxtPassword.Text.Trim();
                string hoten = txtHoTen.Text.Trim();
                DateTime ngaysinh = dtpNgaySinh.Value;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hoten))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (context.TaiKhoan.Any(tk => tk.Username == username))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashedPassword = HashPassword(password);

                var newTaiKhoan = new TaiKhoan
                {
                    Username = username,
                    Password = hashedPassword, 
                    HoTen = hoten,
                    NgaySinh = ngaysinh,
                    QuyenHan = "NhanVien"
                };

                try
                {
                    context.TaiKhoan.Add(newTaiKhoan);
                    context.SaveChanges(); 

                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValues();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ResetValues()
        {
            txtHoTen.Text = "";
            dtpNgaySinh.Text = DateTime.Now.ToShortDateString();
            txtUsername.Text = "";
            mtxtPassword.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (mtxtPassword.PasswordChar == '●')
            {
                mtxtPassword.PasswordChar = '\0';
                btnShowPassword.Text = "√";
            }
            else
            {
                mtxtPassword.PasswordChar = '●';
                btnShowPassword.Text = " ";
            }
        }

        private void frmDKTK_Load(object sender, EventArgs e)
        {
            mtxtPassword.PasswordChar = '●';
        }
    }
}
