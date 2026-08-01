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
    public partial class frmCTHD : Form
    {
        private DataTable CTHD = new DataTable();
        public new event Action OnFormClosed;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmCTHD(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string MaHD { get; set; }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var chiTietHDs = context.CTHD
                    .Where(ct => ct.MaHD == MaHD)
                    .Select(ct => new
                    {
                        ct.MaHD,
                        ct.MaHH,
                        ct.SoLuong,
                        ct.DGBan,
                        ct.ThanhTien
                    })
                    .ToList();

                dgvCTHD.DataSource = chiTietHDs;
            }

            dgvCTHD.Columns[0].HeaderText = "Mã hóa đơn";
            dgvCTHD.Columns[1].HeaderText = "Mã hàng hóa";
            dgvCTHD.Columns[2].HeaderText = "Số lượng";
            dgvCTHD.Columns[3].HeaderText = "Đơn giá bán";
            dgvCTHD.Columns[4].HeaderText = "Thành tiền";

            dgvCTHD.Columns[0].Width = 180;
            dgvCTHD.Columns[1].Width = 160;
            dgvCTHD.Columns[2].Width = 160;
            dgvCTHD.Columns[3].Width = 160;
            dgvCTHD.Columns[4].Width = 200;

            dgvCTHD.AllowUserToAddRows = false;
            dgvCTHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaHD))
            {
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Không có mã hóa đơn để hiển thị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHD = Convert.ToString(dgvCTHD.CurrentRow?.Cells["MaHD"]?.Value);
            string maHH = Convert.ToString(dgvCTHD.CurrentRow?.Cells["MaHH"]?.Value);

            if (string.IsNullOrEmpty(maHD) || string.IsNullOrEmpty(maHH))
            {
                MessageBox.Show("Không thể lấy thông tin mã hóa đơn hoặc mã hàng hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new LKMTdbContext())
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var cthd = context.CTHD.FirstOrDefault(ct => ct.MaHD == maHD && ct.MaHH == maHH);
                        if (cthd != null)
                        {
                            context.CTHD.Remove(cthd);
                        }

                        context.SaveChanges();

                        var tongTien = context.CTHD
                            .Where(ct => ct.MaHD == maHD)
                            .Sum(ct => (decimal?)ct.ThanhTien) ?? 0;

                        var hoaDon = context.HoaDon.FirstOrDefault(hd => hd.MaHD == maHD);

                        string maKH = hoaDon?.MaKH;

                        if (hoaDon != null)
                        {
                            hoaDon.TongTien = tongTien;

                            if (!context.CTHD.Any(ct => ct.MaHD == maHD) && hoaDon.TongTien <= 0)
                            {
                                context.HoaDon.Remove(hoaDon);
                            }
                        }

                        context.SaveChanges();

                        if (!string.IsNullOrEmpty(maKH))
                        {
                            var tongTienKH = context.HoaDon
                                .Where(hd => hd.MaKH == maKH)
                                .Sum(hd => (decimal?)hd.TongTien) ?? 0;
                            var khachHang = context.KhachHang.FirstOrDefault(kh => kh.MaKH == maKH);

                            if (khachHang != null)
                            {
                                khachHang.SoTienMua = tongTienKH;
                                khachHang.MaLoaiKH = Functions.GetMaLoaiKHTheoTien(tongTienKH);
                            }
                        }

                        context.SaveChanges();
                        transaction.Commit();

                        logger.Info($"Người dùng {currentUsername} đã xóa chi tiết hóa đơn.");
                        MessageBox.Show("Xóa chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OnFormClosed?.Invoke(); 
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmCTHD_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormClosed?.Invoke();
        }
    }
}
