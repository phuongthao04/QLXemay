using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay.dto
{
    internal class ChiTietHDN
    {
        private int idXe;
        private int idHDN;
        private int soLuong;
        private decimal giaNhap;
        public ChiTietHDN() { }

        public int IdXe { get => idXe; set => idXe = value; }
        public int IdHDN { get => idHDN; set => idHDN = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal GiaNhap { get => giaNhap; set => giaNhap = value; }
    }
}
