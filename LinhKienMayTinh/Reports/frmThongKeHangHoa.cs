using DocumentFormat.OpenXml.Office2010.Drawing;
using LinhKienMayTinh.Class;
using LinhKienMayTinh.Data;
using Microsoft.Reporting.WinForms;
using System.Data;
using static BanHangMayTinh.Reports.QLBHMayTinhDataSet;

namespace BanHangMayTinh.Reports
{
    public partial class frmThongKeHangHoa : Form
    {
        private ReportViewer reportViewer;

        LKMTdbContext context = new LKMTdbContext();
        QLBHMayTinhDataSet.DanhSachSanPhamDataTable danhSachHangHoaDataTable = new QLBHMayTinhDataSet.DanhSachSanPhamDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");

        public frmThongKeHangHoa()
        {
            InitializeComponent();
            reportViewer1 = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
                Dock = DockStyle.Fill
            };

            panelReport.Controls.Add(reportViewer1);
        }

        private void frmThongKeHangHoa_Load(object sender, EventArgs e)
        {
            using (var context = new LKMTdbContext())
            {
                var danhSachHangSX = context.HangHoa
                    .Where(hh => hh.HangSX != null)
                    .Select(hh => hh.HangSX)
                    .Distinct()
                    .ToList();

                cboHangSX.DataSource = danhSachHangSX;
                cboHangSX.SelectedIndex = -1;

                var danhSachLoaiHH = context.LoaiHH
                    .Select(lh => new { lh.MaLoaiHH, lh.TenLoai })
                    .ToList();

                cboLoaiHH.DataSource = danhSachLoaiHH;
                cboLoaiHH.DisplayMember = "TenLoai";
                cboLoaiHH.ValueMember = "MaLoaiHH";
                cboLoaiHH.SelectedIndex = -1;
            }

            var danhSachHangHoa = context.HangHoa.Select(r => new HangHoa
            {
                MaHH = r.MaHH,
                TenHH = r.TenHH,
                HangSX = r.HangSX,
                MaLoaiHH = r.MaLoaiHH,
                DGBan = r.DGBan,
                DGNhap = r.DGNhap,
                SoLuong = r.SoLuong,
                Anh = r.Anh
            }).ToList();
            danhSachHangHoaDataTable.Clear();
            foreach (var row in danhSachHangHoa)
            {
                danhSachHangHoaDataTable.AddDanhSachSanPhamRow(row.MaHH,
                row.TenHH,
                row.HangSX,
                row.SoLuong,
                row.Anh,
                row.DGNhap,
                row.DGBan,
                row.MaLoaiHH);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHangHoa";
            reportDataSource.Value = danhSachHangHoaDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = @"D:\Lập trình quản lý\BaoCaoMon\BanHangMayTinh\LinhKienMayTinh\Reports\rptThongKeHangHoa.rdlc";

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả sản phẩm)");
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnLocKQ_Click_1(object sender, EventArgs e)
        {
            if (cboHangSX.Text == "" && cboLoaiHH.Text == "")
            {
                frmThongKeHangHoa_Load(sender, e);
            }
            else
            {
                var danhSachHangHoa = context.HangHoa.Select(r => new HangHoa
                {
                    MaHH = r.MaHH,
                    TenHH = r.TenHH,
                    HangSX = r.HangSX,
                    MaLoaiHH = r.MaLoaiHH,
                    DGBan = r.DGBan,
                    DGNhap = r.DGNhap,
                    SoLuong = r.SoLuong,
                    Anh = r.Anh
                }).ToList();

                string moTaLoc = "";

                if (cboHangSX.Text != "")
                {
                    string hangSX = cboHangSX.Text;
                    moTaLoc += "Hãng sản xuất: " + hangSX;
                    danhSachHangHoa = danhSachHangHoa.Where(r => r.HangSX == hangSX).ToList();
                }

                if (cboLoaiHH.Text != "")
                {
                    string loaiHH = cboLoaiHH.SelectedValue.ToString();
                    if (moTaLoc != "") moTaLoc += " - ";
                    moTaLoc += "Loại sản phẩm: " + cboLoaiHH.Text;
                    danhSachHangHoa = danhSachHangHoa.Where(r => r.MaLoaiHH == loaiHH).ToList();
                }

                danhSachHangHoaDataTable.Clear();
                foreach (var row in danhSachHangHoa)
                {
                    danhSachHangHoaDataTable.AddDanhSachSanPhamRow(
                        row.MaHH,
                        row.TenHH,
                        row.HangSX,
                        row.SoLuong,
                        row.Anh,
                        row.DGNhap,
                        row.DGBan,
                        row.MaLoaiHH
                    );
                }

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachHangHoa";
                reportDataSource.Value = danhSachHangHoaDataTable;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportEmbeddedResource = "BanHangMayTinh.Reports.rptThongKeHangHoa.rdlc";

                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(" + moTaLoc + ")");
                reportViewer1.LocalReport.SetParameters(reportParameter);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            cboHangSX.SelectedIndex = -1;
            cboLoaiHH.SelectedIndex = -1;

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("MoTaKetQuaHienThi", "(Tất cả sản phẩm)"));

            frmThongKeHangHoa_Load(sender, e);
        }
    }
}
