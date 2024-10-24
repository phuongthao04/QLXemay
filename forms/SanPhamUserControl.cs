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
            string query = "SELECT \r\n    kho_hang.ten_xe,\r\n    the_loai.ten_loai ,\r\n    dong_co.ten_dc ,\r\n   " +
                " mau_sac.ten_mau,\r\n    tinh_trang.ten_TT ,\r\n    nha_san_xuat.ten_nsx ,\r\n    phanh_xe.ten_phanh ,\r\n    kho_hang.gia_ban,\r\n    kho_hang.gia_nhap \r\nFROM \r\n    kho_hang\r\nJOIN \r\n    the_loai ON kho_hang.id_loai = the_loai.id_loai\r\nJOIN \r\n    " +
                "dong_co ON kho_hang.id_dc = dong_co.id_dongco\r\nJOIN \r\n    mau_sac ON kho_hang.id_mau = mau_sac.id_mau\r\nJOIN \r\n    tinh_trang ON kho_hang.id_tt = tinh_trang.id_tt\r\nJOIN \r\n    nha_san_xuat ON kho_hang.id_nsx = nha_san_xuat.id_nsx\r\nJOIN \r\n    phanh_xe ON kho_hang.id_phanh = phanh_xe.id_phanh";
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
                        GiaNhap = addMotoBikeForm.GiaNhap
                    };

                    // Gọi phương thức thêm xe máy vào cơ sở dữ liệu
                    motoBikeRepo.AddMotoBike(newMotoBike);

                    // Tải lại dữ liệu để hiển thị
                    LoadData();
                }
            }
        }
        private void LoadData()
        {
            string query = "SELECT \r\n    kho_hang.ten_xe,\r\n    the_loai.ten_loai ,\r\n    dong_co.ten_dc ,\r\n   " +
                " mau_sac.ten_mau ,\r\n    tinh_trang.ten_TT ,\r\n    nha_san_xuat.ten_nsx ,\r\n    phanh_xe.ten_phanh ,\r\n    kho_hang.gia_ban ,\r\n    kho_hang.gia_nhap \r\nFROM \r\n    kho_hang\r\nJOIN \r\n    the_loai ON kho_hang.id_loai = the_loai.id_loai\r\nJOIN \r\n    " +
                "dong_co ON kho_hang.id_dc = dong_co.id_dongco\r\nJOIN \r\n    mau_sac ON kho_hang.id_mau = mau_sac.id_mau\r\nJOIN \r\n    tinh_trang ON kho_hang.id_tt = tinh_trang.id_tt\r\nJOIN \r\n    nha_san_xuat ON kho_hang.id_nsx = nha_san_xuat.id_nsx\r\nJOIN \r\n    phanh_xe ON kho_hang.id_phanh = phanh_xe.id_phanh";
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
                            GiaNhap = editMotoBikeForm.GiaNhap
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
