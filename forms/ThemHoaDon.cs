using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeMay.forms
{
    public partial class ThemHoaDon : Form
    {
        public event EventHandler DataUpdated;
        int idnv = 1;
        private int? selectedXeId = null;
        public ThemHoaDon()
        {
            InitializeComponent();
        }
        private void LoadTenXe()
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_xe, ten_xe FROM kho_hang"; // Thay đổi truy vấn nếu cần
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbbTenXe.Items.Clear();
                    while (reader.Read())
                    {
                        cbbTenXe.Items.Add(new { Text = reader["ten_xe"].ToString(), Value = reader["id_xe"] });
                    }
                    cbbTenXe.DisplayMember = "Text";
                    cbbTenXe.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void LoadMauSac(int idXe)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT m.id_mau, m.ten_mau FROM mau_sac m INNER JOIN kho_hang k ON m.id_mau = k.id_mau WHERE k.id_xe = @idXe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idXe", idXe);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbbMauSac.Items.Clear();
                    while (reader.Read())
                    {
                        cbbMauSac.Items.Add(new { Text = reader["ten_mau"].ToString(), Value = reader["id_mau"] });
                    }
                    cbbMauSac.DisplayMember = "Text";
                    cbbMauSac.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void LoadTenLoai(int idXe)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT p.id_phanh, p.ten_phanh FROM phanh_xe p INNER JOIN kho_hang k ON p.id_phanh = k.id_phanh WHERE k.id_xe = @idXe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idXe", idXe);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbbLoaiXe.Items.Clear();
                    while (reader.Read())
                    {
                        cbbLoaiXe.Items.Add(new { Text = reader["ten_phanh"].ToString(), Value = reader["id_phanh"] });
                    }
                    cbbLoaiXe.DisplayMember = "Text";
                    cbbLoaiXe.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void LoadTinhTrang(int idXe)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT t.id_tt, t.ten_TT, k.id_xe,k.ten_xe FROM tinh_trang t INNER JOIN kho_hang k ON t.id_tt = k.id_tt WHERE k.id_xe = @idXe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idXe", idXe);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbbTinhTrang.Items.Clear();
                    while (reader.Read())
                    {
                        cbbTinhTrang.Items.Add(new { Text = reader["ten_TT"].ToString(), Value = reader["id_tt"] });
                    }
                    cbbTinhTrang.DisplayMember = "Text";
                    cbbTinhTrang.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void UpdateSoLuongKhoHang(int idXe, int soLuongNhap)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE kho_hang SET so_luong = so_luong - @soLuongNhap WHERE id_xe = @idXe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@soLuongNhap", soLuongNhap);
                    cmd.Parameters.AddWithValue("@idXe", idXe);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Số lượng trong kho đã được cập nhật!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy xe trong kho hàng.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi3: " + ex.Message);
                }
            }
        }
        public int? GetMaXeByTenVaMau(string tenXe)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                conn.Open();
                string query = "SELECT id_xe FROM kho_hang WHERE ten_xe = @tenXe";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenXe", tenXe);
                return (int)cmd.ExecuteScalar(); // Ensure you handle potential null values
            }
        }


        public int? GetMaMauByTenXeAndMau(string mauSac)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_mau FROM mau_sac WHERE ten_mau = @tenMau";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tenMau", mauSac);
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy mã màu cho màu {mauSac}.");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi4: " + ex.Message);
                    return null;
                }
            }
        }
        public int? GetTinhTrang(string tinhTrang)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_tt FROM tinh_trang WHERE ten_TT = @tenTinhTrang";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tenTinhTrang", tinhTrang);

                    var result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int idTinhTrang))
                    {
                        return idTinhTrang;
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy mã tình trạng '{tinhTrang}'.");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn mã tình trạng: " + ex.Message);
                    return null;
                }
            }
        }

        public int? GetLoaiXe(string loaiXe)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_phanh FROM phanh_xe WHERE ten_phanh = @tenLoaiXe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tenLoaiXe", loaiXe);

                    var result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int idLoaiXe))
                    {
                        return idLoaiXe;
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy mã loại xe '{loaiXe}'.");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn mã loại xe: " + ex.Message);
                    return null;
                }
            }
        }


        private int? GetOrInsertKhachHang(string tenKH, string diaChi, string soDT)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    // Kiểm tra xem khách hàng đã tồn tại chưa
                    string checkQuery = "SELECT id_kh FROM khach_hang WHERE ten_kh = @tenKH AND so_dt = @soDT";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@tenKH", tenKH);
                    checkCmd.Parameters.AddWithValue("@soDT", soDT);

                    object result = checkCmd.ExecuteScalar();

                    if (result != null) // Khách hàng đã tồn tại
                    {
                        return Convert.ToInt32(result);
                    }
                    else // Thêm khách hàng mới
                    {
                        string insertQuery = "INSERT INTO khach_hang (ten_kh, dia_chi, so_dt) OUTPUT INSERTED.id_kh VALUES (@tenKH, @diaChi, @soDT)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@tenKH", tenKH);
                        insertCmd.Parameters.AddWithValue("@diaChi", diaChi);
                        insertCmd.Parameters.AddWithValue("@soDT", soDT);

                        return (int)insertCmd.ExecuteScalar(); // Trả về ID của khách hàng mới
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi5: " + ex.Message);
                    return null;
                }
            }
        }


        private void InsertChiTietDonHang(int idDonDatHang, int idXe, int soLuong, decimal giamGia, decimal thanhTien)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO chi_tiet_ddh (id_xe, id_ddh, so_luong, giam_gia, thanh_tien) VALUES (@idXe, @idDonDatHang, @soLuong, @giamGia, @thanhTien)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idXe", idXe);
                    cmd.Parameters.AddWithValue("@idDonDatHang", idDonDatHang); // Tham số id_ddh
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@giamGia", giamGia); // Nếu có
                    cmd.Parameters.AddWithValue("@thanhTien", thanhTien);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi6: " + ex.Message);
                }
            }
        }
        private int InsertDonDatHang(int idNV, int idKhachHang, DateTime ngayMua, decimal datCoc, decimal tongTien)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO don_dat_hang (id_nv, id_kh, ngay_mua, dat_coc, tong_tien) OUTPUT INSERTED.id_ddh VALUES (@idNV, @idKhachHang, @ngayMua, @datCoc, @tongTien)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idNV", idNV); // ID nhân viên, nếu có
                    cmd.Parameters.AddWithValue("@idKhachHang", idKhachHang);
                    cmd.Parameters.AddWithValue("@ngayMua", ngayMua);
                    cmd.Parameters.AddWithValue("@datCoc", datCoc);
                    cmd.Parameters.AddWithValue("@tongTien", tongTien);

                    return (int)cmd.ExecuteScalar(); // Trả về ID của đơn đặt hàng mới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi9: " + ex.Message);
                    return -1; // Giá trị trả về không hợp lệ
                }
            }
        }
        private void UpdateKhoHang()
        {
            foreach (var item in lbDanhSachMua.Items)
            {
                // Tách thông tin từ item nếu cần thiết
                string[] details = item.ToString().Split('-');
                string tenXe = details[3].Trim();
                int soLuong = int.Parse(details[5].Trim());

                // Gọi hàm để cập nhật kho hàng
                UpdateSoLuongKhoHang(tenXe, soLuong);
            }
        }

        private void UpdateSoLuongKhoHang(string tenXe, int soLuong)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE kho_hang SET so_luong = so_luong - @soLuong WHERE ten_xe = @tenXe"; // Thay đổi nếu cần
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@tenXe", tenXe);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đơn hàng của bạn đã được đặt.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy xe trong kho hàng.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi7: " + ex.Message);
                }
            }
        }
        private decimal CalculateThanhTien(int idXe, int soLuong)
        {
            decimal giaXe = GetGiaXeById(idXe); // Gọi hàm này để lấy giá xe từ cơ sở dữ liệu bằng idXe
            return giaXe * soLuong;
        }
        private decimal GetGiaXeById(int idXe)
        {
            decimal giaXe = 0;
            // Update the query to select the price from the kho_hang table
            string query = "SELECT gia_ban FROM kho_hang WHERE id_xe = @idXe";

            using (SqlConnection conn = DatabaseUtils.connection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idXe", idXe);

                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    giaXe = Convert.ToDecimal(result);
                }
            }

            return giaXe;
        }




        private decimal GetGiaXe(string tenXe)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT gia_ban FROM kho_hang WHERE ten_xe = @tenXe"; // Thay đổi truy vấn nếu cần
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tenXe", tenXe);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToDecimal(result);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giá xe.");
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi8: " + ex.Message);
                    return 0;
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lbDanhSachMua.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    lbDanhSachMua.Items.Remove(lbDanhSachMua.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục cần xóa.");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                return;
            }

            if (cbbTenXe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn xe.");
                return;
            }

            if (cbbMauSac.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc.");
                return;
            }

            if (cbbTinhTrang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tình trạng.");
                return;
            }

            if (cbbLoaiXe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại xe.");
                return;
            }

            // Chỉ khai báo soLuong một lần
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                return;
            }

            if (dtpDate.Value == null)
            {
                MessageBox.Show("Vui lòng chọn ngày mua.");
                return;
            }

            if (selectedXeId.HasValue && cbbMauSac.SelectedItem != null)
            {
                var selectedXe = (dynamic)cbbTenXe.SelectedItem;
                var selectedMau = (dynamic)cbbMauSac.SelectedItem;
                string tenKhachHang = txtTenKH.Text;
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSDT.Text;
                DateTime ngayMua = dtpDate.Value;
                var selectedTinhTrang = (dynamic)cbbTinhTrang.SelectedItem;
                var selectedLoatXe = (dynamic)cbbLoaiXe.SelectedItem;
                // Tạo chuỗi hiển thị trong ListBox bao gồm tên khách hàng, địa chỉ, số điện thoại, tên xe, màu sắc, số lượng và ngày mua
                string itemText = $"{tenKhachHang} - {diaChi} - {soDienThoai} - {selectedXe.Text} - {selectedMau.Text} - {soLuong} - {ngayMua.ToShortDateString()} - {selectedTinhTrang.Text} - {selectedLoatXe.Text}";
                lbDanhSachMua.Items.Add(itemText);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn xe, màu sắc, nhập số lượng hợp lệ và điền thông tin khách hàng.");
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin cần thiết trước khi xử lý
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                lbDanhSachMua.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng và danh sách mua.");
                return;
            }

            string tenKhachHang = txtTenKH.Text;
            string soDienThoai = txtSDT.Text;
            int? idKhachHang = GetOrInsertKhachHang(tenKhachHang, txtDiaChi.Text, soDienThoai);

            if (idKhachHang.HasValue)
            {
                decimal datCoc = 0; // Đặt cọc mặc định là 0
                decimal tongTien = 0; // Khởi tạo tổng tiền

                // Lặp qua từng item trong ListBox và thực hiện thêm vào SQL
                foreach (var item in lbDanhSachMua.Items)
                {
                    string[] details = item.ToString().Split('-');
                    string tenXe = details[3].Trim();
                    string mauSac = details[4].Trim();
                    int soLuong = int.Parse(details[5].Trim());
                    string tinhTrang = details[7].Trim();
                    string loaiXe = details[8].Trim();

                    int? maXe = GetMaXeByTenVaMau(tenXe);
                    int? maMau = GetMaMauByTenXeAndMau(mauSac);
                    int? maTT = GetTinhTrang(tinhTrang);
                    int? maLX = GetLoaiXe(loaiXe);

                    if (maXe.HasValue && maMau.HasValue && maTT.HasValue && maLX.HasValue)
                    {
                        decimal thanhTien = CalculateThanhTien(maXe.Value, soLuong); // Tính thành tiền
                        tongTien += thanhTien; // Cộng dồn tổng tiền

                        // Thêm thông tin vào bảng chi tiết đơn hàng
                        int idDonDatHang = InsertDonDatHang(idnv, idKhachHang.Value, dtpDate.Value, datCoc, tongTien);
                        InsertChiTietDonHang(idDonDatHang, maXe.Value, soLuong, 0, thanhTien); // giamGia = 0 nếu không có
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy mã xe cho xe {tenXe} với màu {mauSac}.");
                        return;
                    }
                }

                DataUpdated?.Invoke(this, EventArgs.Empty); // Cập nhật dữ liệu
                UpdateKhoHang(); // Cập nhật kho hàng

                // Thoát khỏi form
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể thêm khách hàng mới.");
            }
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            LoadTenXe();
            dtpDate.Value = DateTime.Today;
            dtpDate.MinDate = DateTime.Today;
            dtpDate.MaxDate = DateTime.Today;
        }

        private void cbbTenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenXe.SelectedItem != null)
            {
                var selectedXe = (dynamic)cbbTenXe.SelectedItem;
                selectedXeId = selectedXe.Value; // Lưu ID xe đã chọn
                LoadMauSac(selectedXeId.Value); // Nạp màu sắc dựa trên id_xe đã chọn
                LoadTinhTrang(selectedXeId.Value);
                LoadTenLoai(selectedXeId.Value);
            }
        }
    }
}
