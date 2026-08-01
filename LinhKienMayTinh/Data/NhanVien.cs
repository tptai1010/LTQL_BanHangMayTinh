using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public decimal LuongCoBan { get; set; }
        public decimal HeSoLuongThem { get; set; }

        public virtual ICollection<PhieuBaoHanh> PhieuBaoHanh { get; set; } = new List<PhieuBaoHanh>(); 
        public virtual ICollection<HoaDon> HoaDon { get; set; } = new  List<HoaDon>();
        public virtual ICollection<PhieuNhap> PhieuNhap { get; set; } = new List<PhieuNhap>();
        public virtual ICollection<ChamCong> ChamCong { get; set; } = new List<ChamCong>();
    }
}

