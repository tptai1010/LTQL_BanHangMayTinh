using LinhKienMayTinh.Class;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using LinhKienMayTinh.Data;
using Microsoft.EntityFrameworkCore;
using NLog;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LinhKienMayTinh
{
    public partial class frmChamCong : Form
    {
        private DataTable tblChamCong = new DataTable();
        private bool daTinhLuong = false;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string currentUsername;

        public frmChamCong(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var danhSachChamCong = context.ChamCong
                    .Select(cc => new
                    {
                        cc.MaChamCong,
                        cc.MaNV,
                        cc.NhanVien.TenNV,
                        cc.NhanVien.ChucVu,
                        cc.NhanVien.LuongCoBan,
                        cc.NhanVien.HeSoLuongThem,
                        cc.NgayChamCong,
                        cc.SoGioLamThem,
                        cc.TongLuong
                    })
                    .ToList();

                dgvDSLuong.DataSource = danhSachChamCong;
            }

            dgvDSLuong.Columns[0].HeaderText = "Mã chấm công";
            dgvDSLuong.Columns[0].Width = 170;
            dgvDSLuong.Columns[1].HeaderText = "Mã nhân viên";
            dgvDSLuong.Columns[1].Width = 150;
            dgvDSLuong.Columns[2].HeaderText = "Tên nhân viên";
            dgvDSLuong.Columns[2].Width = 250;
            dgvDSLuong.Columns[3].HeaderText = "Chức vụ";
            dgvDSLuong.Columns[3].Width = 130;
            dgvDSLuong.Columns[4].HeaderText = "Lương cơ bản";
            dgvDSLuong.Columns[4].Width = 200;
            dgvDSLuong.Columns[5].HeaderText = "Hệ số lương thêm";
            dgvDSLuong.Columns[5].Width = 200;
            dgvDSLuong.Columns[6].HeaderText = "Ngày chấm công";
            dgvDSLuong.Columns[6].Width = 200;
            dgvDSLuong.Columns[7].HeaderText = "Số giờ làm thêm";
            dgvDSLuong.Columns[7].Width = 200;
            dgvDSLuong.Columns[8].HeaderText = "Tổng lương";
            dgvDSLuong.Columns[8].Width = 200;

            dgvDSLuong.AllowUserToAddRows = false;
            dgvDSLuong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void cbNoiDungTK_SelectedIndexChanged(object? sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;

            txtMaChamCong.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtChucVu.ReadOnly = true;
            txtSoGioLamThem.ReadOnly = true;
            txtTongLuong.ReadOnly = true;
            txtTongLuong.Text = "0";

            cbThang.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i.ToString());
            }
            cbThang.SelectedIndex = -1;

            cbNam.Items.Clear();
            for (int i = 2020; i <= 2025; i++)
            {
                cbNam.Items.Add(i.ToString());
            }
            cbNam.SelectedIndex = -1;

            using (var context = new LKMTdbContext())
            {
                var danhSachNV = context.NhanVien
                    .Select(nv => new { nv.MaNV, nv.TenNV })
                    .ToList();

                cbMaNV.DataSource = danhSachNV;
                cbMaNV.DisplayMember = "MaNV";
                cbMaNV.ValueMember = "MaNV";
                cbMaNV.SelectedIndex = -1;
            }

            if (!string.IsNullOrEmpty(txtMaChamCong.Text))
            {
                LoadInfoChamCong();
                btnXoa.Enabled = true;
            }

            cbNoiDungTK.Items.Clear();
            cbNoiDungTK.Items.Add("Mã nhân viên");
            cbNoiDungTK.Items.Add("Tên nhân viên");
            cbNoiDungTK.Items.Add("Chức vụ");
            cbNoiDungTK.Items.Add("Năm");
            cbNoiDungTK.Items.Add("Tháng");
            cbNoiDungTK.Items.Add("Mã chấm công");
            cbNoiDungTK.SelectedIndex = -1;
            txtTimKiem.Enabled = false;

            LoadDataGridView();
        }

        private void LoadInfoChamCong()
        {
            using (var context = new LKMTdbContext())
            {
                var chamCong = context.ChamCong
                    .Include(cc => cc.NhanVien)
                    .FirstOrDefault(cc => cc.MaChamCong == txtMaChamCong.Text);

                if (chamCong != null)
                {
                    cbMaNV.SelectedValue = chamCong.MaNV;
                    cbThang.Text = chamCong.NgayChamCong.Month.ToString();
                    cbNam.Text = chamCong.NgayChamCong.Year.ToString();
                    txtSoGioLamThem.Text = chamCong.SoGioLamThem.ToString();
                    txtTongLuong.Text = chamCong.TongLuong.ToString();
                    lblTongLuong.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(chamCong.TongLuong.ToString());
                }
            }
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaNV.SelectedIndex == -1) return;

            using (var context = new LKMTdbContext())
            {
                var maNV = cbMaNV.SelectedValue?.ToString();
                if (maNV == null) return;

                var nv = context.NhanVien.FirstOrDefault(n => n.MaNV == maNV);
                if (nv != null)
                {
                    txtTenNV.Text = nv.TenNV;
                    txtChucVu.Text = nv.ChucVu;
                }
            }
        }

        private void dgvDSLuong_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChamCong.Focus();
                return;
            }
            if (dgvDSLuong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maChamCong = dgvDSLuong.CurrentRow.Cells["MaChamCong"].Value?.ToString();
            if (string.IsNullOrEmpty(maChamCong)) return;

            using (var context = new LKMTdbContext())
            {
                var chamCong = context.ChamCong.Include(cc => cc.NhanVien).FirstOrDefault(cc => cc.MaChamCong == maChamCong);
                if (chamCong != null)
                {
                    txtMaChamCong.Text = chamCong.MaChamCong;
                    cbThang.Text = chamCong.NgayChamCong.Month.ToString();
                    cbNam.Text = chamCong.NgayChamCong.Year.ToString();
                    txtSoGioLamThem.Text = chamCong.SoGioLamThem.ToString();

                    cbMaNV.Text = chamCong.MaNV;
                    txtTenNV.Text = chamCong.NhanVien?.TenNV ?? "";
                    txtChucVu.Text = chamCong.NhanVien?.ChucVu ?? "";

                    txtTongLuong.Text = chamCong.TongLuong.ToString();
                    lblTongLuong.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongLuong.Text);
                }
            }

            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
            btnTimKiem.Enabled = false;
            btnHuyTK.Enabled = false;
            btnNhap.Enabled = false;
            btnXuat.Enabled = false;
            daTinhLuong = false;

            txtMaChamCong.Enabled = true;
            txtMaChamCong.ReadOnly = false;
            txtMaChamCong.Focus();
            txtSoGioLamThem.ReadOnly = false;

            ResetValues();
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaChamCong.Text = "";
            cbThang.SelectedIndex = -1;
            cbNam.SelectedIndex = -1;
            txtSoGioLamThem.Text = "";
            cbMaNV.SelectedIndex = -1;
            txtTenNV.Text = "";
            txtChucVu.Text = "";
            txtTongLuong.Text = "0";
            lblTongLuong.Text = "Bằng chữ: ";
            daTinhLuong = false;
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (cbMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaNV.Focus();
                return;
            }

            if (cbThang.SelectedIndex == -1 || cbNam.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn tháng và năm chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double soGioLamThem;
            if (!double.TryParse(txtSoGioLamThem.Text, out soGioLamThem))
            {
                MessageBox.Show("Số giờ làm thêm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoGioLamThem.Focus();
                return;
            }

            using (var context = new LKMTdbContext())
            {
                string maNV = cbMaNV.SelectedValue.ToString();
                var nv = context.NhanVien.Find(maNV);

                if (nv != null)
                {
                    decimal tongLuong = nv.LuongCoBan + (Convert.ToDecimal(soGioLamThem) * nv.HeSoLuongThem * 100000);
                    txtTongLuong.Text = tongLuong.ToString();
                    lblTongLuong.Text = $"Bằng chữ: {Functions.ChuyenSoSangChu(tongLuong.ToString())}";
                    daTinhLuong = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSLuong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaChamCong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new LKMTdbContext())
                {
                    var chamCong = context.ChamCong.Find(txtMaChamCong.Text.Trim());
                    if (chamCong != null)
                    {
                        context.ChamCong.Remove(chamCong);
                        logger.Info($"Người dùng {currentUsername} đã xóa thông tin lương nhân viên.");
                        context.SaveChanges();
                        LoadDataGridView();
                        ResetValues();
                    }
                }

                btnXoa.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaChamCong.Text))
            {
                MessageBox.Show("Bạn phải nhập mã chấm công", "Thông báo");
                txtMaChamCong.Focus();
                return;
            }

            if (cbMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo");
                cbMaNV.Focus();
                return;
            }

            if (cbThang.SelectedIndex == -1 || cbNam.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn tháng và năm", "Thông báo");
                return;
            }

            if (!daTinhLuong)
            {
                MessageBox.Show("Bạn phải 'Tính lương' trước khi lưu!", "Thông báo");
                return;
            }

            int thang = int.Parse(cbThang.Text);
            int nam = int.Parse(cbNam.Text);
            DateTime ngayChamCong;
            try
            {
                ngayChamCong = new DateTime(nam, thang, 1);
                if (ngayChamCong > DateTime.Now)
                {
                    MessageBox.Show("Ngày chấm công không được lớn hơn hiện tại.", "Thông báo");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ngày chấm công không hợp lệ.", "Thông báo");
                return;
            }

            using (var context = new LKMTdbContext())
            {
                string maCC = txtMaChamCong.Text.Trim();

                if (context.ChamCong.Any(cc => cc.MaChamCong == maCC))
                {
                    MessageBox.Show("Mã chấm công đã tồn tại!", "Thông báo");
                    return;
                }

                string maNV = cbMaNV.SelectedValue.ToString();
                bool daCo = context.ChamCong.Any(cc =>
                    cc.MaNV == maNV &&
                    cc.NgayChamCong.Month == thang &&
                    cc.NgayChamCong.Year == nam);

                if (daCo)
                {
                    MessageBox.Show("Đã có bản ghi chấm công tháng này cho nhân viên!", "Thông báo");
                    return;
                }

                var nv = context.NhanVien.FirstOrDefault(n => n.MaNV == maNV);
                if (nv == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên.", "Thông báo");
                    return;
                }

                if (!int.TryParse(txtSoGioLamThem.Text, out int soGio))
                {
                    MessageBox.Show("Số giờ làm thêm không hợp lệ!", "Thông báo");
                    return;
                }

                if (soGio > 52)
                {
                    MessageBox.Show("Không được quá 52 giờ.", "Thông báo");
                    return;
                }

                decimal tongLuong = nv.LuongCoBan + (Convert.ToDecimal(soGio) * nv.HeSoLuongThem * 100000);
                txtTongLuong.Text = tongLuong.ToString();
                lblTongLuong.Text = $"Bằng chữ: {Functions.ChuyenSoSangChu(tongLuong.ToString())}";

                ChamCong newCC = new ChamCong
                {
                    MaChamCong = maCC,
                    MaNV = maNV,
                    NgayChamCong = ngayChamCong,
                    SoGioLamThem = soGio,
                    TongLuong = tongLuong
                };

                context.ChamCong.Add(newCC);
                context.SaveChanges();
                logger.Info($"Người dùng {currentUsername} đã tính lương nhân viên.");
            }

            LoadDataGridView();
            ResetValues();

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiem.Enabled = true;
            btnHuyTK.Enabled = false;

            btnNhap.Enabled = true;
            btnXuat.Enabled = true;
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

            string keyword = txtTimKiem.Text.Trim();
            using (var context = new LKMTdbContext())
            {
                var query = from cc in context.ChamCong
                            join nv in context.NhanVien on cc.MaNV equals nv.MaNV
                            select new
                            {
                                nv.MaNV,
                                nv.TenNV,
                                nv.ChucVu,
                                nv.LuongCoBan,
                                nv.HeSoLuongThem,
                                cc.MaChamCong,
                                cc.NgayChamCong,
                                cc.SoGioLamThem,
                                cc.TongLuong
                            };

                switch (cbNoiDungTK.Text)
                {
                    case "Mã nhân viên":
                        query = query.Where(x => x.MaNV.Contains(keyword));
                        break;
                    case "Tên nhân viên":
                        query = query.Where(x => x.TenNV.Contains(keyword));
                        break;
                    case "Chức vụ":
                        query = query.Where(x => x.ChucVu.Contains(keyword));
                        break;
                    case "Năm":
                        if (int.TryParse(keyword, out int nam))
                            query = query.Where(x => x.NgayChamCong.Year == nam);
                        else
                            MessageBox.Show("Năm không hợp lệ!", "Thông báo");
                        break;
                    case "Tháng":
                        if (int.TryParse(keyword, out int thang))
                            query = query.Where(x => x.NgayChamCong.Month == thang);
                        else
                            MessageBox.Show("Tháng không hợp lệ!", "Thông báo");
                        break;
                    case "Mã chấm công":
                        query = query.Where(x => x.MaChamCong.Contains(keyword));
                        break;
                }

                var result = query.ToList();
                if (result.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo");
                }

                dgvDSLuong.DataSource = result;
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
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Xuất dữ liệu Chấm Công",
                Filter = "Excel Files|*.xlsx",
                FileName = $"ChamCong_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new LKMTdbContext())
                    {
                        var danhSachChamCong = db.ChamCong.Include(cc => cc.NhanVien).ToList();

                        var table = new DataTable();
                        table.Columns.Add("Mã chấm công", typeof(string));
                        table.Columns.Add("Mã nhân viên", typeof(string));
                        table.Columns.Add("Tên nhân viên", typeof(string));
                        table.Columns.Add("Chức vụ", typeof(string));
                        table.Columns.Add("Lương cơ bản", typeof(decimal));
                        table.Columns.Add("Hệ số lương thêm", typeof(decimal));
                        table.Columns.Add("Ngày chấm công", typeof(DateTime));
                        table.Columns.Add("Số giờ làm thêm", typeof(int));
                        table.Columns.Add("Tổng lương", typeof(decimal));

                        foreach (var chamCong in danhSachChamCong)
                        {
                            table.Rows.Add(
                                chamCong.MaChamCong,
                                chamCong.MaNV,
                                chamCong.NhanVien?.TenNV ?? "Không xác định",
                                chamCong.NhanVien?.ChucVu ?? "Không xác định",
                                chamCong.NhanVien?.LuongCoBan ?? 0,
                                chamCong.NhanVien?.HeSoLuongThem ?? 0,
                                chamCong.NgayChamCong,
                                chamCong.SoGioLamThem,
                                chamCong.TongLuong
                            );
                        }

                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var sheet = workbook.Worksheets.Add(table, "ChamCong");
                            sheet.Columns().AdjustToContents();
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                    }
                    logger.Info($"Người dùng {currentUsername} đã nhập dữ liệu lương nhân viên.");
                    MessageBox.Show("Nhập dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Xuất dữ liệu Chấm Công",
                Filter = "Excel Files|*.xlsx",
                FileName = $"ChamCong_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new LKMTdbContext())
                    {
                        var danhSachChamCong = db.ChamCong.Include(cc => cc.NhanVien).ToList();

                        var table = new DataTable();
                        table.Columns.Add("Mã chấm công", typeof(string));
                        table.Columns.Add("Mã nhân viên", typeof(string));
                        table.Columns.Add("Tên nhân viên", typeof(string));
                        table.Columns.Add("Chức vụ", typeof(string));
                        table.Columns.Add("Lương cơ bản", typeof(decimal));
                        table.Columns.Add("Hệ số lương thêm", typeof(decimal));
                        table.Columns.Add("Ngày chấm công", typeof(DateTime));
                        table.Columns.Add("Số giờ làm thêm", typeof(int));
                        table.Columns.Add("Tổng lương", typeof(decimal));

                        foreach (var chamCong in danhSachChamCong)
                        {
                            table.Rows.Add(
                                chamCong.MaChamCong,
                                chamCong.MaNV,
                                chamCong.NhanVien?.TenNV ?? "Không xác định",
                                chamCong.NhanVien?.ChucVu ?? "Không xác định",
                                chamCong.NhanVien?.LuongCoBan ?? 0,
                                chamCong.NhanVien?.HeSoLuongThem ?? 0,
                                chamCong.NgayChamCong,
                                chamCong.SoGioLamThem,
                                chamCong.TongLuong
                            );
                        }

                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var sheet = workbook.Worksheets.Add(table, "ChamCong");
                            sheet.Columns().AdjustToContents();
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                    }
                    logger.Info($"Người dùng {currentUsername} đã xuất dữ liệu lương nhân viên.");
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
