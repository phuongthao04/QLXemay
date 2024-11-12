using QLXeMay.data_connection;
using QLXeMay.dto;
using QLXeMay.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeMay.forms
{
    public partial class SanPhamUserControl : UserControl
    {
        private MotoBikeRepository motoBikeRepo = new MotoBikeRepository();
        private HoaDonNhapRepo HoaDonNhapRepo = new HoaDonNhapRepo();
        private ChiTietHDNRepo ChiTietHDNRepo = new ChiTietHDNRepo();
        public SanPhamUserControl()
        {
            InitializeComponent();
            //dvgSanPham.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dvgSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.White;

            // Đổi màu chữ header thành màu đen
            dvgSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dvgSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void SanPhamUserControl_Load(object sender, EventArgs e)
        {
			string query = "SELECT " +
	                        "kho_hang.ten_xe, " +
	                        "the_loai.ten_loai, " +
	                        "dong_co.ten_dc, " +
	                        "mau_sac.ten_mau, " +
	                        "tinh_trang.ten_TT, " +
	                        "nha_san_xuat.ten_nsx, " +
	                        "phanh_xe.ten_phanh, " +
	                        "kho_hang.gia_ban, " +
	                        "kho_hang.gia_nhap, " +
	                        "kho_hang.so_luong " +
                        "FROM " +
	                        "kho_hang " +
                        "JOIN " +
	                        "the_loai ON kho_hang.id_loai = the_loai.id_loai " +
                        "JOIN " +
	                        "dong_co ON kho_hang.id_dc = dong_co.id_dongco " +
                        "JOIN " +
	                        "mau_sac ON kho_hang.id_mau = mau_sac.id_mau " +
                        "JOIN " +
	                        "tinh_trang ON kho_hang.id_tt = tinh_trang.id_tt " +
                        "JOIN " +
	                        "nha_san_xuat ON kho_hang.id_nsx = nha_san_xuat.id_nsx " +
                        "JOIN " +
	                        "phanh_xe ON kho_hang.id_phanh = phanh_xe.id_phanh";
			List<MotoBikeDto> motoBikes = motoBikeRepo.motobikes(query);
            dvgSanPham.DataSource = motoBikes;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var addMotoBikeForm = new AddMotoBikeForm())
            {
                if (addMotoBikeForm.ShowDialog() == DialogResult.OK)
                {
                    // Lấy thông tin từ form và tạo đối tượng MotoBikeDto
                    MotoBikeDto newMotoBike = new MotoBikeDto
                    {
                        TenXe = addMotoBikeForm.TenXe,
                        IdLoai = addMotoBikeForm.IdLoai,        // ID của loại xe
                        IdDongCo = addMotoBikeForm.IdDongCo,    // ID của động cơ
                        IdMau = addMotoBikeForm.IdMau,          // ID của màu
                        IdTinhTrang = addMotoBikeForm.IdTinhTrang, // ID của tình trạng
                        IdNSX = addMotoBikeForm.IdNSX,          // ID của nhà sản xuất
                        IdPhanh = addMotoBikeForm.IdPhanh,      // ID của phanh
                        GiaBan = addMotoBikeForm.GiaBan,
                        GiaNhap = addMotoBikeForm.GiaNhap,
                        SoLuong = addMotoBikeForm.SoLuong,
                    };

                    HoaDonNhap hoaDonNhap = new HoaDonNhap
                    {
                        IdNhanVien = addMotoBikeForm.IdNhanVien,
                        IdNhaCungCap = addMotoBikeForm.IdNhaCungCap,
                        GiaNhap = addMotoBikeForm.GiaNhap
                    };

                    ChiTietHDN chiTietHDN = new ChiTietHDN
                    {
                        SoLuong = addMotoBikeForm.SoLuong,
                        GiaNhap = addMotoBikeForm.GiaNhap
                    };

                    // Gọi phương thức thêm xe máy vào cơ sở dữ liệu
                    motoBikeRepo.AddMotoBike(newMotoBike);
                    HoaDonNhapRepo.AddHoaDonNhap(hoaDonNhap);
                    ChiTietHDNRepo.AddChiTietHDN(chiTietHDN);

                    // Tải lại dữ liệu để hiển thị
                    LoadData();
                }
            }
        }
        private void LoadData()
        {
			string query = "SELECT " +
	"kho_hang.ten_xe, " +
	"the_loai.ten_loai, " +
	"dong_co.ten_dc, " +
	"mau_sac.ten_mau, " +
	"tinh_trang.ten_TT, " +
	"nha_san_xuat.ten_nsx, " +
	"phanh_xe.ten_phanh, " +
	"kho_hang.gia_ban, " +
	"kho_hang.gia_nhap, " +
	"kho_hang.so_luong " +
"FROM " +
	"kho_hang " +
"JOIN " +
	"the_loai ON kho_hang.id_loai = the_loai.id_loai " +
"JOIN " +
	"dong_co ON kho_hang.id_dc = dong_co.id_dongco " +
"JOIN " +
	"mau_sac ON kho_hang.id_mau = mau_sac.id_mau " +
"JOIN " +
	"tinh_trang ON kho_hang.id_tt = tinh_trang.id_tt " +
"JOIN " +
	"nha_san_xuat ON kho_hang.id_nsx = nha_san_xuat.id_nsx " +
"JOIN " +
	"phanh_xe ON kho_hang.id_phanh = phanh_xe.id_phanh";
			List<MotoBikeDto> motoBikes = motoBikeRepo.motobikes(query);
            dvgSanPham.DataSource = motoBikes;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dvgSanPham.SelectedRows.Count > 0)
            {
                // Giả sử bạn lấy MotoBikeDto từ hàng được chọn
                MotoBikeDto selectedMoto = dvgSanPham.SelectedRows[0].DataBoundItem as MotoBikeDto;

                using (var editMotoBikeForm = new EditMotoBikeForm(selectedMoto))
                {
                    if (editMotoBikeForm.ShowDialog() == DialogResult.OK)
                    {
                        // Lấy thông tin đã chỉnh sửa
                        MotoBikeDto updatedMotoBike = new MotoBikeDto
                        {
                            TenXe = editMotoBikeForm.TenXe,
                            IdLoai = editMotoBikeForm.IdLoai,
                            IdDongCo = editMotoBikeForm.IdDongCo,
                            IdMau = editMotoBikeForm.IdMau,
                            IdTinhTrang = editMotoBikeForm.IdTinhTrang,
                            IdNSX = editMotoBikeForm.IdNSX,
                            IdPhanh = editMotoBikeForm.IdPhanh,
                            GiaBan = editMotoBikeForm.GiaBan,
                            GiaNhap = editMotoBikeForm.GiaNhap,
                            SoLuong = editMotoBikeForm.SoLuong,
                        };

                        // Cập nhật thông tin xe máy trong cơ sở dữ liệu
                        motoBikeRepo.UpdateMotoBike(updatedMotoBike);

                        // Tải lại dữ liệu để hiển thị
                        LoadData();
                    }
                }
            }
            }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dvgSanPham.SelectedRows.Count > 0)
            {
                // Lấy tên xe từ dòng được chọn
                string tenXe = dvgSanPham.SelectedRows[0].Cells["TenXe"].Value.ToString();

                // Xác nhận việc xóa
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa xe '{tenXe}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức xóa xe máy từ cơ sở dữ liệu
                    motoBikeRepo.DeleteMotoBike(tenXe);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe máy để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dvgSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
