using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay.dto
{
    public class MotoBikeDto
    {
        private string tenXe;
        private string dongCo;
        private string tenLoai;
        private string mau;
        private string tinhTrang;
        private string tenNSX;
        private string phanh;
        private decimal giaBan;
        private decimal giaNhap;
        public int IdLoai;
        public int IdDongCo;
        public int IdMau;
        public int IdTinhTrang;  
        public int IdNSX;         
        public int IdPhanh;
		private int soLuong;
		public MotoBikeDto()
        {
        }

        [DisplayName("Tên xe")]
        public string TenXe { get => tenXe; set => tenXe = value; }
        [DisplayName("Tên loại")]
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        [DisplayName("Động cơ")]
        public string DongCo { get => dongCo; set => dongCo = value; }
        [DisplayName("Màu")]
        public string Mau { get => mau; set => mau = value; }
        [DisplayName("Tình trạng")]
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        [DisplayName("Nhà sản xuất")]
        public string TenNSX { get => tenNSX; set => tenNSX = value; }
        [DisplayName("Phanh")]
        public string Phanh { get => phanh; set => phanh = value; }
        [DisplayName("Giá bán")]
        public decimal GiaBan { get => giaBan; set => giaBan = value; }
        [DisplayName("Giá nhập")]
        public decimal GiaNhap { get => giaNhap; set => giaNhap = value; }
		[DisplayName("Số Lượng")]
		public int SoLuong { get => soLuong; set => soLuong = value; }
	}
}
