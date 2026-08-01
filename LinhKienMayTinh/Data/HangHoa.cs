using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class HangHoa
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string HangSX { get; set; }
        public int SoLuong { get; set; }
        public string Anh { get; set; }
        public decimal DGNhap { get; set; }
        public decimal DGBan { get; set; }
        public string MaLoaiHH { get; set; }
        public virtual LoaiHH LoaiHH { get; set; }
        public virtual ICollection<CTPhieuNhap> CTPhieuNhap { get; set; } = new List<CTPhieuNhap>();
        public virtual ICollection<CTHD> CTHD { get; set; } = new List<CTHD>();
        public virtual ICollection<PhieuBaoHanh> PhieuBaoHanh  { get; set; } = new List<PhieuBaoHanh>();
    }
}
