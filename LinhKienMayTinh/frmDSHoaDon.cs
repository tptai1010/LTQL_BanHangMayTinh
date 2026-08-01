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
using BanHangMayTinh.Reports;
using LinhKienMayTinh.Data;
using NLog;

namespace LinhKienMayTinh
{
    public partial class frmDSHoaDon : Form
    {
        private DataTable tblDSHD = new DataTable();
        private string currentUserRole;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmDSHoaDon(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void btnXemThem_Click(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn nào để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHD = dgvDSHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();

            frmCTHD frmCTHD = new frmCTHD(currentUsername);
            frmCTHD.MaHD = maHD;

            this.Hide();
            frmCTHD.OnFormClosed += () =>
            {
                this.Show();
                LoadDataGridView();
            };
            frmCTHD.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var emptyHoaDons = context.HoaDon
                    .Where(hd => hd.TongTien <= 0 && !context.CTHD.Any(ct => ct.MaHD == hd.MaHD))
                    .ToList();
                if (emptyHoaDons.Any())
                {
                    context.HoaDon.RemoveRange(emptyHoaDons);
                    context.SaveChanges();
                }

                var hoaDons = context.HoaDon
                    .Select(hd => new
                    {
                        hd.MaHD,
                        hd.MaKH,
                        hd.MaNV,
                        hd.NgayLapHD,
                        hd.TongTien
                    })
                    .ToList();

                dgvDSHoaDon.DataSource = hoaDons;
            }
            dgvDSHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvDSHoaDon.Columns[0].Width = 150;
            dgvDSHoaDon.Columns[1].HeaderText = "Mã khách hàng";
            dgvDSHoaDon.Columns[1].Width = 170;
            dgvDSHoaDon.Columns[2].HeaderText = "Mã nhân viên";
            dgvDSHoaDon.Columns[2].Width = 170;
            dgvDSHoaDon.Columns[3].HeaderText = "Ngày lập hóa đơn";
            dgvDSHoaDon.Columns[3].Width = 200;
            dgvDSHoaDon.Columns[4].HeaderText = "Tổng tiền";
            dgvDSHoaDon.Columns[4].Width = 180;

            dgvDSHoaDon.AllowUserToAddRows = false;
            dgvDSHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmDSHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

            txtTimKiem.Enabled = false;

            cbNoiDungTK.Items.Clear();
            cbNoiDungTK.Items.Add("Mã hóa đơn");
            cbNoiDungTK.Items.Add("Mã khách hàng");
            cbNoiDungTK.Items.Add("Mã nhân viên");
            cbNoiDungTK.Items.Add("Năm");
            cbNoiDungTK.Items.Add("Tháng");
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
                btnXoa.Enabled = true;
                btnXemThem.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
                btnXemThem.Enabled = false;
            }
        }

        private void cbNoiDungTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
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

            using (var context = new LKMTdbContext())
            {
                var key = txtTimKiem.Text.Trim();
                var hoaDons = context.HoaDon.AsQueryable();

                if (cbNoiDungTK.Text == "Mã hóa đơn")
                    hoaDons = hoaDons.Where(hd => hd.MaHD.Contains(key));
                else if (cbNoiDungTK.Text == "Mã khách hàng")
                    hoaDons = hoaDons.Where(hd => hd.MaKH.Contains(key));
                else if (cbNoiDungTK.Text == "Mã nhân viên")
                    hoaDons = hoaDons.Where(hd => hd.MaNV.Contains(key));
                else if (cbNoiDungTK.Text == "Tháng")
                    hoaDons = hoaDons.Where(hd => hd.NgayLapHD.Month.ToString() == key);
                else if (cbNoiDungTK.Text == "Năm")
                    hoaDons = hoaDons.Where(hd => hd.NgayLapHD.Year.ToString() == key);
                else
                {
                    MessageBox.Show("Loại tìm kiếm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = hoaDons
                    .Select(hd => new
                    {
                        hd.MaHD,
                        hd.MaKH,
                        hd.MaNV,
                        hd.NgayLapHD,
                        hd.TongTien
                    })
                    .ToList();

                dgvDSHoaDon.DataSource = result;

                if (result.Count == 0)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn nào để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? maHD = Convert.ToString(dgvDSHoaDon.CurrentRow?.Cells["MaHD"]?.Value);
            string? maKH = Convert.ToString(dgvDSHoaDon.CurrentRow?.Cells["MaKH"]?.Value);

            if (string.IsNullOrEmpty(maHD) || string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Không thể lấy thông tin mã hóa đơn hoặc mã khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new LKMTdbContext())
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Lấy danh sách chi tiết hóa đơn
                        var cthdList = context.CTHD.Where(ct => ct.MaHD == maHD).ToList();

                        // Cập nhật lại số lượng hàng hóa
                        foreach (var cthd in cthdList)
                        {
                            var hangHoa = context.HangHoa.FirstOrDefault(hh => hh.MaHH == cthd.MaHH);
                            if (hangHoa != null)
                            {
                                hangHoa.SoLuong += cthd.SoLuong; // Cộng lại số lượng hàng hóa
                            }
                        }

                        // Xóa chi tiết hóa đơn
                        context.CTHD.RemoveRange(cthdList);

                        // Xóa hóa đơn
                        var hoaDon = context.HoaDon.FirstOrDefault(hd => hd.MaHD == maHD);
                        if (hoaDon != null)
                        {
                            context.HoaDon.Remove(hoaDon);
                        }

                        // Cập nhật tổng tiền khách hàng sau khi xóa hóa đơn
                        var tongTienSauXoa = context.HoaDon
                            .Where(hd => hd.MaKH == maKH)
                            .Sum(hd => (decimal?)hd.TongTien) ?? 0;

                        var khachHang = context.KhachHang.FirstOrDefault(kh => kh.MaKH == maKH);
                        if (khachHang != null)
                        {
                            khachHang.SoTienMua = tongTienSauXoa;
                            khachHang.MaLoaiKH = Functions.GetMaLoaiKHTheoTien(tongTienSauXoa);
                        }

                        context.SaveChanges();
                        transaction.Commit();

                        LoadDataGridView();
                        logger.Info($"Người dùng {currentUsername} đã xóa hóa đơn {maHD}.");
                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Xuất danh sách Hóa Đơn",
                Filter = "Excel Files|*.xlsx",
                FileName = "DSHoaDon_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    using (var context = new LKMTdbContext()) 
                    {
                        var sheet = workbook.Worksheets.Add("HoaDon");
                        var hoaDons = context.HoaDon.Select(hd => new
                        {
                            hd.MaHD,
                            hd.MaKH,
                            hd.MaNV,
                            hd.NgayLapHD,
                            hd.TongTien
                        }).ToList();

                        // Ghi tiêu đề cột
                        sheet.Cell(1, 1).Value = "Mã hóa đơn";
                        sheet.Cell(1, 2).Value = "Mã khách hàng";
                        sheet.Cell(1, 3).Value = "Mã nhân viên";
                        sheet.Cell(1, 4).Value = "Ngày lập hóa đơn";
                        sheet.Cell(1, 5).Value = "Tổng tiền";

                        int rowIndex = 2;
                        foreach (var hd in hoaDons)
                        {
                            sheet.Cell(rowIndex, 1).Value = hd.MaHD;
                            sheet.Cell(rowIndex, 2).Value = hd.MaKH;
                            sheet.Cell(rowIndex, 3).Value = hd.MaNV;
                            sheet.Cell(rowIndex, 4).Value = hd.NgayLapHD.ToString("yyyy-MM-dd");
                            sheet.Cell(rowIndex, 5).Value = hd.TongTien;
                            rowIndex++;
                        }

                        sheet.Columns().AdjustToContents();
                        workbook.SaveAs(saveFileDialog.FileName);
                        logger.Info($"Người dùng {currentUsername} đã xuất dữ liệu hóa đơn.");
                        MessageBox.Show("Xuất dữ liệu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
