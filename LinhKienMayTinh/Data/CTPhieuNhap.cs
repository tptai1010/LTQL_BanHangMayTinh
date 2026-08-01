using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class CTPhieuNhap
    {
        public string MaPhieu { get; set; }
        public string MaHH { get; set; }
        public int SoLuong { get; set; }
        public decimal DGNhap { get; set; }
        public decimal ThanhTien { get; set; }
     
        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}
