using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class PhieuNhap
    {
        public string MaPhieu { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal TongTien { get; set; }
      
        public virtual NhanVien NhanVien { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual ICollection<CTPhieuNhap> CTPhieuNhap { get; set; } = new List<CTPhieuNhap>();
    }
}
