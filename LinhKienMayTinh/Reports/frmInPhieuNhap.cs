using LinhKienMayTinh.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangMayTinh.Reports
{
    public partial class frmInPhieuNhap : Form
    {
        private ReportViewer reportViewer1;
        public string p;

        LKMTdbContext context = new LKMTdbContext();
        QLBHMayTinhDataSet.DanhSachChiTietPhieuNhapDataTable DSChiTietPNDataTable = new QLBHMayTinhDataSet.DanhSachChiTietPhieuNhapDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");

        public frmInPhieuNhap()
        {
            InitializeComponent();
            reportViewer1 = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
                Dock = DockStyle.Fill
            };

            panelReport.Controls.Add(reportViewer1);
        }

        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            var chiTietPN = (from ct in context.CTPhieuNhap
                                 join hd in context.PhieuNhap on ct.MaPhieu equals hd.MaPhieu
                                 join hh in context.HangHoa on ct.MaHH equals hh.MaHH
                                 join kh in context.NhaCungCap on hd.MaNCC equals kh.MaNCC
                                 join nv in context.NhanVien on hd.MaNV equals nv.MaNV
                                 where ct.MaPhieu == p
                                 select new
                                 {
                                     MaPhieu = ct.MaPhieu,
                                     MaHH = ct.MaHH,
                                     TenHH = hh.TenHH,
                                     SoLuong = ct.SoLuong,
                                     DGNhap = ct.DGNhap,
                                     ThanhTien = ct.ThanhTien,
                                     NgayNhap = hd.NgayNhap,

                                     TenNCC = kh.TenNCC,
                                     DiaChiNCC = kh.DiaChi,
                                     SDT_NCC = kh.SDT,

                                 }).ToList();

            if (chiTietPN.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu cho hóa đơn này!");
                return;
            }

            DSChiTietPNDataTable.Clear();
            foreach (var ct in chiTietPN)
            {
                DSChiTietPNDataTable.AddDanhSachChiTietPhieuNhapRow(
                    ct.MaPhieu,
                    ct.MaHH,
                    ct.TenHH,
                    (short)ct.SoLuong,
                    ct.DGNhap,
                    ct.ThanhTien,
                    ct.NgayNhap
                );
            }

            // Tính tổng tiền
            decimal tongTien = chiTietPN.Sum(x => x.ThanhTien);
            // Chuyển thành chữ
            string tienBangChu = LinhKienMayTinh.Class.Functions.ChuyenSoSangChu(tongTien.ToString());

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "InPhieuNhap";
            reportDataSource.Value = DSChiTietPNDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = @"D:\Lập trình quản lý\BaoCaoMon\BanHangMayTinh\LinhKienMayTinh\Reports\rptInPhieuNhap.rdlc";

            var thongTin = chiTietPN.First();
            List<ReportParameter> param = new List<ReportParameter>
            {
                new ReportParameter("MaPhieu", thongTin.MaPhieu),
                new ReportParameter("NgayNhap", thongTin.NgayNhap.ToString("dd/MM/yyyy")),
                new ReportParameter("TenNCC", thongTin.TenNCC),
                new ReportParameter("DiaChiNCC", thongTin.DiaChiNCC),
                new ReportParameter("SDT_NCC", thongTin.SDT_NCC),
                new ReportParameter("TienBangChu", tienBangChu)
            };

            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }
    }
}
