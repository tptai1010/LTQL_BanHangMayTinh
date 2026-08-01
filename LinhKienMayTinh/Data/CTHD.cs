using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class CTHD
    {
        public string MaHD { get; set; }
        public string MaHH { get; set; }
        public int SoLuong { get; set; }
        public decimal DGBan { get; set; }
        public decimal ThanhTien { get; set; }
       
        public virtual HoaDon HoaDon { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}
