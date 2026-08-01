using DocumentFormat.OpenXml.InkML;
using LinhKienMayTinh.Class;
using LinhKienMayTinh.Data;
using Microsoft.Data.SqlClient;
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

namespace LinhKienMayTinh
{
    public partial class frmDangNhap : Form
    {
        public static string LoggedInUsername;
        public static string LoggedInRole;
        public static string LoggedInHoTen;
        public static string LoggedInNgaySinh;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            mtxtPassword.PasswordChar = '●';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                string username = txtUsername.Text.Trim();
                string password = mtxtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = context.TaiKhoan.FirstOrDefault(tk => tk.Username == username);
                if (user == null || !VerifyPassword(password, user.Password))
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Functions.currentUsername = user.Username;

                MessageBox.Show($"Đăng nhập thành công! Xin chào {user.HoTen}!", "Thông báo", MessageBoxButtons.OK);

                frmTrangChu TrangChu = new frmTrangChu(user.Username);
                TrangChu.ShowDialog();
                this.Hide();
            }
        }

        private bool VerifyPassword(string inputPassword, string storedHashedPassword)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
                string hashedInput = BitConverter.ToString(bytes).Replace("-", "").ToLower();
                return hashedInput == storedHashedPassword;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            frmDKTK frmDKTK = new frmDKTK();
            this.Hide();
            frmDKTK.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
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

        private void mtxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
