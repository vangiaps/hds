using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    internal class hoaDon
    {
        public int MaHoaDon { get; set; }
        public int? MaPhong { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TienPhong { get; set; }
        public decimal? TienDien { get; set; }
        public decimal? TienNuoc { get; set; }
        public decimal? TienDV { get; set; }
        public decimal? Tong { get; set; }
        public string? TrangThaiThanhToan { get; set; }
    }
}
