using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class LoaiKH
    {
        public string MaLoaiKH { get; set; }
        public string TenLoai { get; set; }
        public decimal ChietKhau { get; set; }
        public virtual ICollection<KhachHang> KhachHang { get; set; } = new List<KhachHang>();
    }
}
