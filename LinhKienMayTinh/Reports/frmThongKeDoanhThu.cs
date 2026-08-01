using LinhKienMayTinh.Class;
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
    public partial class frmThongKeDoanhThu : Form
    {
        private ReportViewer reportViewer;

        LKMTdbContext context = new LKMTdbContext();
        QLBHMayTinhDataSet.DanhSachHoaDonDataTable danhSachHoaDonDataTable = new QLBHMayTinhDataSet.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
            reportViewer1 = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
                Dock = DockStyle.Fill
            };

            panelReport.Controls.Add(reportViewer1);
        }

        private void rbtnBaoCaoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBaoCaoNgay.Checked == true)
            {
                gbBaoCaoNgay.Visible = true;
                gbBaoCaoNam.Visible = gbBaoCaoThang.Visible = false;
            }
        }

        private void rbtnBaoCaoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBaoCaoNam.Checked == true)
            {
                gbBaoCaoNam.Visible = true;
                gbBaoCaoNgay.Visible = gbBaoCaoThang.Visible = false;
            }
        }

        private void rbtnBaoCaoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBaoCaoThang.Checked == true)
            {
                gbBaoCaoThang.Visible = true;
                gbBaoCaoNam.Visible = gbBaoCaoNgay.Visible = false;
            }
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            cboThangBD.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboThangBD.Items.Add(i.ToString());
            }
            cboThangBD.SelectedIndex = -1;

            cboNamBD.Items.Clear();
            for (int i = 2020; i <= 2025; i++)
            {
                cboNamBD.Items.Add(i.ToString());
            }
            cboNamBD.SelectedIndex = -1;

            cboThangKT.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboThangKT.Items.Add(i.ToString());
            }
            cboThangKT.SelectedIndex = -1;

            cboNamKT.Items.Clear();
            for (int i = 2020; i <= 2025; i++)
            {
                cboNamKT.Items.Add(i.ToString());
            }
            cboNamKT.SelectedIndex = -1;

            cboBCNamBD.Items.Clear();
            for (int i = 2020; i <= 2025; i++)
            {
                cboBCNamBD.Items.Add(i.ToString());
            }
            cboBCNamBD.SelectedIndex = -1;

            cboBCNamKT.Items.Clear();
            for (int i = 2020; i <= 2025; i++)
            {
                cboBCNamKT.Items.Add(i.ToString());
            }
            cboBCNamKT.SelectedIndex = -1;

            gbBaoCaoNgay.Visible = false;
            gbBaoCaoThang.Visible = false;
            gbBaoCaoNam.Visible = false;

            var danhSachHoaDon = (from hd in context.HoaDon
                                  join kh in context.KhachHang on hd.MaKH equals kh.MaKH
                                  join nv in context.NhanVien on hd.MaNV equals nv.MaNV
                                  select new
                                  {
                                      MaHD = hd.MaHD,
                                      MaKH = hd.MaKH,
                                      TenKH = kh.TenKH,
                                      MaNV = hd.MaNV,
                                      TenNV = nv.TenNV,
                                      NgayLapHD = hd.NgayLapHD,
                                      TongTien = hd.TongTien
                                  }).ToList();
            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(row.MaHD,
                row.MaKH,
                row.TenKH,
                row.MaNV,
                row.TenNV,
                row.NgayLapHD,
                row.TongTien);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = @"D:\Lập trình quản lý\BaoCaoMon\BanHangMayTinh\LinhKienMayTinh\Reports\rptThongKeDoanhThu.rdlc";

            decimal tongDoanhThu = danhSachHoaDon.Sum(hd => hd.TongTien);
            string tongDoanhThuFormatted = tongDoanhThu.ToString("#,##0") + " VNĐ";
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("MoTaKetQuaHienThi", "(Tất cả thời gian)"),
                new ReportParameter("TongDoanhThu", tongDoanhThuFormatted)
            }; 
            reportViewer1.LocalReport.SetParameters(reportParameters);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void LocBaoCaoTheoNgay()
        {
            DateTime ngayBD = dtpNgayBD.Value.Date;
            DateTime ngayKT = dtpNgayKT.Value.Date;

            var danhSachHoaDon = (from hd in context.HoaDon
                                  join kh in context.KhachHang on hd.MaKH equals kh.MaKH
                                  join nv in context.NhanVien on hd.MaNV equals nv.MaNV
                                  where hd.NgayLapHD >= ngayBD && hd.NgayLapHD <= ngayKT
                                  select new
                                  {
                                      MaHD = hd.MaHD,
                                      MaKH = hd.MaKH,
                                      TenKH = kh.TenKH,
                                      MaNV = hd.MaNV,
                                      TenNV = nv.TenNV,
                                      NgayLapHD = hd.NgayLapHD,
                                      TongTien = hd.TongTien
                                  }).ToList();

            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(row.MaHD, row.MaKH, row.TenKH, row.MaNV, row.TenNV, row.NgayLapHD, row.TongTien);
            }

            string moTaLoc = "";
            if (dtpNgayBD.Value.Date == dtpNgayKT.Value.Date)
                moTaLoc = "Ngày: " + ngayBD.ToString("dd/MM/yyyy");
            else
                moTaLoc = "Từ ngày " + ngayBD.ToString("dd/MM/yyyy") + " đến " + ngayKT.ToString("dd/MM/yyyy");

            CapNhatReportViewer(moTaLoc);
        }

        private void LocBaoCaoTheoThang()
        {
            if (cboThangBD.SelectedIndex == -1 || cboNamBD.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Tháng bắt đầu và Năm bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int thangBD = int.Parse(cboThangBD.Text);
            int namBD = int.Parse(cboNamBD.Text);

            int thangKT = thangBD;
            int namKT = namBD;

            if (cboThangKT.SelectedIndex != -1 && cboNamKT.SelectedIndex != -1)
            {
                thangKT = int.Parse(cboThangKT.Text);
                namKT = int.Parse(cboNamKT.Text);
            }

            DateTime ngayBD = new DateTime(namBD, thangBD, 1);
            DateTime ngayKT = new DateTime(namKT, thangKT, DateTime.DaysInMonth(namKT, thangKT));

            var danhSachHoaDon = (from hd in context.HoaDon
                                  join kh in context.KhachHang on hd.MaKH equals kh.MaKH
                                  join nv in context.NhanVien on hd.MaNV equals nv.MaNV
                                  where hd.NgayLapHD >= ngayBD && hd.NgayLapHD <= ngayKT
                                  select new
                                  {
                                      MaHD = hd.MaHD,
                                      MaKH = hd.MaKH,
                                      TenKH = kh.TenKH,
                                      MaNV = hd.MaNV,
                                      TenNV = nv.TenNV,
                                      NgayLapHD = hd.NgayLapHD,
                                      TongTien = hd.TongTien
                                  }).ToList();

            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(row.MaHD, row.MaKH, row.TenKH, row.MaNV, row.TenNV, row.NgayLapHD, row.TongTien);
            }

            string moTaLoc = "";
            if (ngayBD == ngayKT)
                moTaLoc = "Tháng " + thangBD + "/" + namBD;
            else
                moTaLoc = "Từ tháng " + thangBD + "/" + namBD + " đến tháng " + thangKT + "/" + namKT;

            CapNhatReportViewer(moTaLoc);
        }

        private void LocBaoCaoTheoNam()
        {
            if (cboBCNamBD.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Năm bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int namBD = int.Parse(cboBCNamBD.Text);
            int namKT = namBD;

            if (cboBCNamKT.SelectedIndex != -1)
            {
                namKT = int.Parse(cboBCNamKT.Text);
            }

            DateTime ngayBD = new DateTime(namBD, 1, 1);
            DateTime ngayKT = new DateTime(namKT, 12, 31);

            var danhSachHoaDon = (from hd in context.HoaDon
                                  join kh in context.KhachHang on hd.MaKH equals kh.MaKH
                                  join nv in context.NhanVien on hd.MaNV equals nv.MaNV
                                  where hd.NgayLapHD >= ngayBD && hd.NgayLapHD <= ngayKT
                                  select new
                                  {
                                      MaHD = hd.MaHD,
                                      MaKH = hd.MaKH,
                                      TenKH = kh.TenKH,
                                      MaNV = hd.MaNV,
                                      TenNV = nv.TenNV,
                                      NgayLapHD = hd.NgayLapHD,
                                      TongTien = hd.TongTien
                                  }).ToList();

            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(row.MaHD, row.MaKH, row.TenKH, row.MaNV, row.TenNV, row.NgayLapHD, row.TongTien);
            }

            string moTaLoc = "";
            if (namBD == namKT)
                moTaLoc = "Năm " + namBD;
            else
                moTaLoc = "Từ năm " + namBD + " đến năm " + namKT;

            CapNhatReportViewer(moTaLoc);
        }

        private void CapNhatReportViewer(string moTaLoc)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "BanHangMayTinh.Reports.rptThongKeDoanhThu.rdlc";

            decimal tongDoanhThu = danhSachHoaDonDataTable.Sum(r => r.TongTien);
            string tongDoanhThuFormatted = tongDoanhThu.ToString("#,##0") + " VNĐ";
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("MoTaKetQuaHienThi", "(" + moTaLoc + ")"),
                new ReportParameter("TongDoanhThu", tongDoanhThuFormatted)
            };
            reportViewer1.LocalReport.SetParameters(reportParameters);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnLocKQ_Click(object sender, EventArgs e)
        {
            if (rbtnBaoCaoNgay.Checked)
            {
                LocBaoCaoTheoNgay();
            }
            else if (rbtnBaoCaoThang.Checked)
            {
                LocBaoCaoTheoThang();
            }
            else if (rbtnBaoCaoNam.Checked)
            {
                LocBaoCaoTheoNam();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            rbtnBaoCaoNgay.Checked = false;
            rbtnBaoCaoThang.Checked = false;
            rbtnBaoCaoNam.Checked = false;

            gbBaoCaoNgay.Visible = false;
            gbBaoCaoThang.Visible = false;
            gbBaoCaoNam.Visible = false;

            cboThangBD.SelectedIndex = -1;
            cboNamBD.SelectedIndex = -1;
            cboThangKT.SelectedIndex = -1;
            cboNamKT.SelectedIndex = -1;
            cboBCNamBD.SelectedIndex = -1;
            cboBCNamKT.SelectedIndex = -1;

            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;

            frmThongKeDoanhThu_Load(sender, e);
        }
    }
}
