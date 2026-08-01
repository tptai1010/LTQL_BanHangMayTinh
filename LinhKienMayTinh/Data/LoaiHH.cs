using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class LoaiHH
    {
        public string MaLoaiHH { get; set; }
        public string TenLoai { get; set; }
        public int SoLuong { get; set; }
        public virtual ICollection<HangHoa> HangHoa { get; set; } = new List<HangHoa>();
    }
}
