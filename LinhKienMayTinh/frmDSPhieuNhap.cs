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
    public partial class frmDSPhieuNhap : Form
    {
        private DataTable tblDSPN = new DataTable();
        private string currentUserRole;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmDSPhieuNhap(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void btnXemThem_Click(object sender, EventArgs e)
        {
            if (dgvDSPhieuNhap.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn nào để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieu = dgvDSPhieuNhap.CurrentRow.Cells["MaPhieu"].Value.ToString();

            frmCTPhieuNhap frmCTPN = new frmCTPhieuNhap(currentUsername);
            frmCTPN.MaPhieu = maPhieu;

            this.Enabled = false;

            frmCTPN.FormClosed += (s, args) =>
            {
                this.Enabled = true;
                LoadDataGridView();
            };

            frmCTPN.ShowDialog();
        }



        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var phieuNhapCanXoa = context.PhieuNhap.Where(pn => pn.TongTien <= 0).ToList();
                if (phieuNhapCanXoa.Any())
                {
                    context.PhieuNhap.RemoveRange(phieuNhapCanXoa);
                    context.SaveChanges();
                }

                var phieuNhapList = context.PhieuNhap
                    .Select(pn => new
                    {
                        pn.MaPhieu,
                        pn.MaNCC,
                        pn.MaNV,
                        pn.NgayNhap,
                        pn.TongTien
                    })
                    .ToList();

                dgvDSPhieuNhap.DataSource = phieuNhapList;
            }
            dgvDSPhieuNhap.Columns[0].HeaderText = "Mã phiếu";
            dgvDSPhieuNhap.Columns[0].Width = 150;
            dgvDSPhieuNhap.Columns[1].HeaderText = "Mã nhà cung cấp";
            dgvDSPhieuNhap.Columns[1].Width = 170;
            dgvDSPhieuNhap.Columns[2].HeaderText = "Mã nhân viên";
            dgvDSPhieuNhap.Columns[2].Width = 170;
            dgvDSPhieuNhap.Columns[3].HeaderText = "Ngày nhập";
            dgvDSPhieuNhap.Columns[3].Width = 200;
            dgvDSPhieuNhap.Columns[4].HeaderText = "Tổng tiền";
            dgvDSPhieuNhap.Columns[4].Width = 180;

            dgvDSPhieuNhap.AllowUserToAddRows = false;
            dgvDSPhieuNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmDSPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

            txtTimKiem.Enabled = false;

            cbNoiDungTK.Items.Clear();
            cbNoiDungTK.Items.Add("Mã phiếu");
            cbNoiDungTK.Items.Add("Mã nhà cung cấp");
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                var phieuNhapList = context.PhieuNhap.AsQueryable();

                if (cbNoiDungTK.Text == "Mã phiếu")
                    phieuNhapList = phieuNhapList.Where(pn => pn.MaPhieu.Contains(key));
                else if (cbNoiDungTK.Text == "Mã nhà cung cấp")
                    phieuNhapList = phieuNhapList.Where(pn => pn.MaNCC.Contains(key));
                else if (cbNoiDungTK.Text == "Mã nhân viên")
                    phieuNhapList = phieuNhapList.Where(pn => pn.MaNV.Contains(key));
                else if (cbNoiDungTK.Text == "Tháng")
                    phieuNhapList = phieuNhapList.Where(pn => pn.NgayNhap.Month.ToString() == key);
                else if (cbNoiDungTK.Text == "Năm")
                    phieuNhapList = phieuNhapList.Where(pn => pn.NgayNhap.Year.ToString() == key);
                else
                {
                    MessageBox.Show("Loại tìm kiếm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = phieuNhapList
                    .Select(pn => new
                    {
                        pn.MaPhieu,
                        pn.MaNCC,
                        pn.MaNV,
                        pn.NgayNhap,
                        pn.TongTien
                    })
                    .ToList();

                dgvDSPhieuNhap.DataSource = result;

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
            if (dgvDSPhieuNhap.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn phiếu nhập nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieu = Convert.ToString(dgvDSPhieuNhap.CurrentRow?.Cells["MaPhieu"]?.Value);

            using (var context = new LKMTdbContext())
            {
                var ctPhieuNhap = context.CTPhieuNhap.Where(ct => ct.MaPhieu == maPhieu).ToList();
                if (ctPhieuNhap.Count > 0)
                {
                    context.CTPhieuNhap.RemoveRange(ctPhieuNhap);
                }

                var phieuNhap = context.PhieuNhap.FirstOrDefault(pn => pn.MaPhieu == maPhieu);
                if (phieuNhap != null)
                {
                    context.PhieuNhap.Remove(phieuNhap);
                }

                context.SaveChanges();
                logger.Info($"Người dùng {currentUsername} đã xóa phiếu nhập hàng.");
                MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDataGridView();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Xuất danh sách Phiếu Nhập",
                Filter = "Excel Files|*.xlsx",
                FileName = "DSPhieuNhap_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var context = new LKMTdbContext())
                {
                    var phieuNhapList = context.PhieuNhap
                        .Select(pn => new
                        {
                            pn.MaPhieu,
                            pn.MaNCC,
                            pn.MaNV,
                            pn.NgayNhap,
                            pn.TongTien
                        })
                        .ToList();

                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        var sheet = workbook.Worksheets.Add("PhieuNhap");
                        sheet.Cell(1, 1).Value = "Mã phiếu";
                        sheet.Cell(1, 2).Value = "Mã nhà cung cấp";
                        sheet.Cell(1, 3).Value = "Mã nhân viên";
                        sheet.Cell(1, 4).Value = "Ngày nhập";
                        sheet.Cell(1, 5).Value = "Tổng tiền";

                        int rowIndex = 2;
                        foreach (var pn in phieuNhapList)
                        {
                            sheet.Cell(rowIndex, 1).Value = pn.MaPhieu;
                            sheet.Cell(rowIndex, 2).Value = pn.MaNCC;
                            sheet.Cell(rowIndex, 3).Value = pn.MaNV;
                            sheet.Cell(rowIndex, 4).Value = pn.NgayNhap.ToString("yyyy-MM-dd");
                            sheet.Cell(rowIndex, 5).Value = pn.TongTien;
                            rowIndex++;
                        }

                        sheet.Columns().AdjustToContents();
                        workbook.SaveAs(saveFileDialog.FileName);
                    }
                    logger.Info($"Người dùng {currentUsername} đã xuất dữ liệu phiếu nhâp hàng.");
                    MessageBox.Show("Xuất dữ liệu phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
