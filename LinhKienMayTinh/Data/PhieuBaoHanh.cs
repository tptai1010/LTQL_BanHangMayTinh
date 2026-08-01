using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class PhieuBaoHanh
    {
        public string MaPhieu { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaKH { get; set; }
        public string MaHH { get; set; }
        public string MaNV { get; set; }
        public string TGBaoHanh { get; set; }
        
        public virtual NhanVien NhanVien { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}
