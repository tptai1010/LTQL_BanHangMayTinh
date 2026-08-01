using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class ChamCong
    {
        public String MaChamCong { get; set; }
        public String MaNV { get; set; }
        public DateTime NgayChamCong { get; set; }
        public int SoGioLamThem { get; set; }
        public decimal TongLuong { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
