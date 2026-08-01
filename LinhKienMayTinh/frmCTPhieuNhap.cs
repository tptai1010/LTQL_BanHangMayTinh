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
    public partial class frmCTPhieuNhap : Form
    {
        private DataTable CTPhieuNhap = new DataTable();
        public new event Action OnFormClosed;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmCTPhieuNhap(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string MaPhieu { get; set; }

        private void LoadDataGridView()
        {
            using (var context = new LKMTdbContext())
            {
                var chiTietPhieuNhapList = context.CTPhieuNhap
                    .Where(ct => ct.MaPhieu == MaPhieu)
                    .Select(ct => new
                    {
                        ct.MaPhieu,
                        ct.MaHH,
                        ct.SoLuong,
                        ct.DGNhap,
                        ct.ThanhTien
                    })
                    .ToList();

                dgvCTPhieuNhap.DataSource = chiTietPhieuNhapList;
            }

            dgvCTPhieuNhap.Columns[0].HeaderText = "Mã phiếu";
            dgvCTPhieuNhap.Columns[1].HeaderText = "Mã hàng hóa";
            dgvCTPhieuNhap.Columns[2].HeaderText = "Số lượng";
            dgvCTPhieuNhap.Columns[3].HeaderText = "Đơn giá nhập";
            dgvCTPhieuNhap.Columns[4].HeaderText = "Thành tiền";

            dgvCTPhieuNhap.Columns[0].Width = 180;
            dgvCTPhieuNhap.Columns[1].Width = 160;
            dgvCTPhieuNhap.Columns[2].Width = 160;
            dgvCTPhieuNhap.Columns[3].Width = 160;
            dgvCTPhieuNhap.Columns[4].Width = 200;

            dgvCTPhieuNhap.AllowUserToAddRows = false;
            dgvCTPhieuNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmCTPhieuNhap_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaPhieu))
            {
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Không có mã phiếu để hiển thị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCTPhieuNhap.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieu = Convert.ToString(dgvCTPhieuNhap.CurrentRow?.Cells["MaPhieu"]?.Value);
            string maHH = Convert.ToString(dgvCTPhieuNhap.CurrentRow?.Cells["MaHH"]?.Value);

            if (string.IsNullOrEmpty(maPhieu) || string.IsNullOrEmpty(maHH))
            {
                MessageBox.Show("Không thể lấy thông tin mã phiếu hoặc mã hàng hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var context = new LKMTdbContext())
                {
                    var chiTietPhieuNhap = context.CTPhieuNhap.FirstOrDefault(ct => ct.MaPhieu == maPhieu && ct.MaHH == maHH);
                    if (chiTietPhieuNhap != null)
                    {
                        context.CTPhieuNhap.Remove(chiTietPhieuNhap);
                    }

                    var hangHoa = context.HangHoa.FirstOrDefault(hh => hh.MaHH == maHH);
                    if (hangHoa != null)
                    {
                        hangHoa.SoLuong = Math.Max(0, hangHoa.SoLuong - chiTietPhieuNhap.SoLuong);
                    }

                    var phieuNhap = context.PhieuNhap.FirstOrDefault(pn => pn.MaPhieu == maPhieu);
                    if (phieuNhap != null)
                    {
                        phieuNhap.TongTien -= chiTietPhieuNhap.ThanhTien;

                        // 🔥 Kiểm tra nếu không còn hàng nào trong CTPhieuNhap, xóa luôn PhieuNhap
                        if (!context.CTPhieuNhap.Any(ct => ct.MaPhieu == maPhieu) && phieuNhap.TongTien <= 0)
                        {
                            context.PhieuNhap.Remove(phieuNhap);
                        }
                    }

                    context.SaveChanges();
                }
                logger.Info($"Người dùng {currentUsername} đã xóa chi tiết phiếu nhập hàng.");
                MessageBox.Show("Xóa chi tiết phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnFormClosed?.Invoke();
                this.Close();
            }
        }

        private void frmCTPhieuNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormClosed?.Invoke();
        }
    }
}
