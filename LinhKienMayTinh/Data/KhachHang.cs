using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string MaLoaiKH { get; set; }
        public decimal SoTienMua { get; set; }
        public virtual LoaiKH LoaiKH { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get; set; } = new List<HoaDon>();
        public virtual ICollection<PhieuBaoHanh> PhieuBaoHanh { get; set; } = new List<PhieuBaoHanh>();
    }
}
