using DocumentFormat.OpenXml.Office2010.Excel;
using LinhKienMayTinh.Data;
using Microsoft.EntityFrameworkCore;
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
using static BanHangMayTinh.Reports.QLBHMayTinhDataSet;

namespace BanHangMayTinh.Reports
{
    public partial class frmInHoaDon : Form
    {
        private ReportViewer reportViewer1;
        public string maHoaDon;

        LKMTdbContext context = new LKMTdbContext();
        QLBHMayTinhDataSet.DanhSachChiTietHoaDonDataTable DSChiTietHoaDonDataTable = new QLBHMayTinhDataSet.DanhSachChiTietHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");

        public frmInHoaDon()
        {
            InitializeComponent();
            reportViewer1 = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
                Dock = DockStyle.Fill
            };

            panelReport.Controls.Add(reportViewer1);
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var chiTietHoaDon = (from ct in context.CTHD
                                 join hd in context.HoaDon on ct.MaHD equals hd.MaHD
                                 join hh in context.HangHoa on ct.MaHH equals hh.MaHH
                                 join kh in context.KhachHang on hd.MaKH equals kh.MaKH
                                 join nv in context.NhanVien on hd.MaNV equals nv.MaNV
                                 where ct.MaHD == maHoaDon
                                 select new
                                 {
                                     MaHD = ct.MaHD,
                                     MaHH = ct.MaHH,
                                     TenHH = hh.TenHH,
                                     SoLuong = ct.SoLuong,
                                     DGBan = ct.DGBan,
                                     ThanhTien = ct.ThanhTien,
                                     NgayLapHD = hd.NgayLapHD,

                                     TenKhachHang = kh.TenKH,
                                     DiaChiKhachHang = kh.DiaChi,
                                     SDTKhachHang = kh.SDT,

                                     TenNhanVien = nv.TenNV,
                                     DiaChiNhanVien = nv.DiaChi,
                                     SDTNhanVien = nv.SDT
                                 }).ToList();

            if (chiTietHoaDon.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu cho hóa đơn này!");
                return;
            }

            DSChiTietHoaDonDataTable.Clear();
            foreach (var ct in chiTietHoaDon)
            {
                DSChiTietHoaDonDataTable.AddDanhSachChiTietHoaDonRow(
                    ct.MaHD,
                    ct.MaHH,
                    ct.TenHH,
                    ct.SoLuong,
                    ct.DGBan,
                    ct.ThanhTien,
                    ct.NgayLapHD
                );
            }

            decimal tongTien = chiTietHoaDon.Sum(x => x.ThanhTien);
            string tienBangChu = LinhKienMayTinh.Class.Functions.ChuyenSoSangChu(tongTien.ToString());

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "inHoaDon";
            reportDataSource.Value = DSChiTietHoaDonDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = @"D:\Lập trình quản lý\BaoCaoMon\BanHangMayTinh\LinhKienMayTinh\Reports\rptInHoaDon.rdlc";

            var thongTin = chiTietHoaDon.First();
            List<ReportParameter> param = new List<ReportParameter>
            {
                new ReportParameter("MaHoaDon", thongTin.MaHD),
                new ReportParameter("NgayLapHD", thongTin.NgayLapHD.ToString("dd/MM/yyyy")),
                new ReportParameter("TenNguoiBan", thongTin.TenNhanVien),
                new ReportParameter("DiaChiNguoiBan", thongTin.DiaChiNhanVien),
                new ReportParameter("SDTNguoiBan", thongTin.SDTNhanVien),
                new ReportParameter("TenKhachHang", thongTin.TenKhachHang),
                new ReportParameter("DiaChiKhachHang", thongTin.DiaChiKhachHang),
                new ReportParameter("SDTKhachHang", thongTin.SDTKhachHang),
                new ReportParameter("MaSoThueKhachHang", ""),
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
