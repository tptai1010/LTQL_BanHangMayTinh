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
    public partial class frmInPBH : Form
    {
        private ReportViewer reportViewer1;
        public string MaPhieuBH;

        LKMTdbContext context = new LKMTdbContext();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");

        public frmInPBH()
        {
            InitializeComponent();
            reportViewer1 = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
                Dock = DockStyle.Fill
            };
            panelReport.Controls.Add(reportViewer1);
        }

        private void frmInPBH_Load(object sender, EventArgs e)
        {
            var pbh = (from bh in context.PhieuBaoHanh
                       join kh in context.KhachHang on bh.MaKH equals kh.MaKH
                       join hh in context.HangHoa on bh.MaHH equals hh.MaHH
                       where bh.MaPhieu == MaPhieuBH
                       select new
                       {
                           MaPhieu = bh.MaPhieu,
                           TenKH = kh.TenKH,
                           DiaChiKH = kh.DiaChi,
                           SDT_KH = kh.SDT,
                           TenHH = hh.TenHH,
                           TGBaoHanh = bh.TGBaoHanh,
                           NgayLap = bh.NgayLap
                       }).FirstOrDefault();

            if (pbh == null)
            {
                MessageBox.Show("Không tìm thấy phiếu bảo hành!");
                return;
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"D:\Lập trình quản lý\BaoCaoMon\BanHangMayTinh\LinhKienMayTinh\Reports\rptInPBH.rdlc";

            List<ReportParameter> param = new List<ReportParameter>
            {
                new ReportParameter("MaPhieu", pbh.MaPhieu),
                new ReportParameter("TenKH", pbh.TenKH),
                new ReportParameter("DiaChiKH", pbh.DiaChiKH),
                new ReportParameter("SDT_KH", pbh.SDT_KH),
                new ReportParameter("TenHH", pbh.TenHH),
                new ReportParameter("TGBaoHanh", pbh.TGBaoHanh),
                new ReportParameter("NgayLap",$"ngày {pbh.NgayLap.Day:00} tháng {pbh.NgayLap.Month:00} năm {pbh.NgayLap.Year}")
            };

            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }
    }
}
