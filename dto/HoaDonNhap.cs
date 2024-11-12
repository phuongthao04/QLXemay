using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay.dto
{
    internal class HoaDonNhap
    {
        private int idHDN;
        private int idNhanVien;
        private int idNhaCungCap;
        private decimal giaNhap;
        public HoaDonNhap() { }

        public int IdHDN { get => idHDN; set => idHDN = value; }
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public int IdNhaCungCap { get => idNhaCungCap; set => idNhaCungCap = value; }
        public decimal GiaNhap { get => giaNhap; set => giaNhap = value; }
    }
}
