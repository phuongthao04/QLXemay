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
    public partial class DonHangUserControl : UserControl
    {
        private void Form_DataUpdated(object sender, EventArgs e)
        {
            LoadKhachHangDonHangData(); // Gọi phương thức cập nhật dữ liệu
        }
        public DonHangUserControl()
        {
            InitializeComponent();
            LoadKhachHangDonHangData();
            dtbDonHang.CellClick += DtbDonHang_CellClick;
        }

        public void LoadKhachHangDonHangData()
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();

                    string query = @"
            SELECT ddh.id_ddh AS N'Mã đơn hàng', 
                   kh.ten_kh AS N'Tên khách hàng', 
                   ctddh.so_luong AS N'Số lượng', 
                   ddh.ngay_mua AS N'Ngày mua', 
                   (ctddh.so_luong * khb.gia_ban) AS N'Tổng tiền' 
            FROM don_dat_hang ddh
            INNER JOIN khach_hang kh ON ddh.id_kh = kh.id_kh
            INNER JOIN chi_tiet_ddh ctddh ON ddh.id_ddh = ctddh.id_ddh
            INNER JOIN kho_hang khb ON ctddh.id_xe = khb.id_xe 
            ORDER BY ddh.ngay_mua DESC"; // Sắp xếp theo ngày mua giảm dần

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dtbDonHang.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void SearchData(string keyword)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = @"
            SELECT ddh.id_ddh AS N'Mã đơn hàn', 
                   kh.ten_kh AS N'Tên khách hàng', 
                   ctddh.so_luong AS N'Số lượng', 
                   ddh.ngay_mua AS N'Ngày mua', 
                   (ctddh.so_luong * khb.gia_ban) AS N'Tổng tiền'  
            FROM don_dat_hang ddh
            INNER JOIN khach_hang kh ON ddh.id_kh = kh.id_kh
            INNER JOIN chi_tiet_ddh ctddh ON ddh.id_ddh = ctddh.id_ddh
            INNER JOIN kho_hang khb ON ctddh.id_xe = khb.id_xe  
            WHERE ddh.id_ddh LIKE @keyword
            OR kh.ten_kh LIKE @keyword
            ORDER BY ddh.ngay_mua DESC;"; // Sắp xếp theo ngày mua giảm dần

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dtbDonHang.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadDetialBill()
        {
            using (SqlConnection conn = DatabaseUtils.connection()) // Sử dụng kết nối từ DatabaseUtils
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT id_ddh ,ten_nv, ten_kh,ngay_mua,tong_tien
                    FROM don_dat_hang
                    JOIN khach_hang ON don_dat_hang.id_kh=khach_hang.id_kh
                    JOIN nhan_vien ON don_dat_hang.id_nv=nhan_vien.id_nv";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dtbDonHang.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void DtbDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào một dòng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Select Data
                DataGridViewRow selectedRow = dtbDonHang.Rows[e.RowIndex];
                string idddh = selectedRow.Cells["Mã đơn hàng"].Value.ToString();
                //string tennv = selectedRow.Cells["ten_nv"].Value.ToString();
                string tenkh = selectedRow.Cells["Tên khách hàng"].Value.ToString();
                string ngayMua = selectedRow.Cells["Ngày mua"].Value.ToString();
                string tongTien = selectedRow.Cells["Tổng tiền"].Value.ToString();

                // Create and open ProductDetailForm
                ChiTietHoaDon oderDetail = new ChiTietHoaDon(idddh, tenkh, ngayMua, tongTien);
                oderDetail.ShowDialog();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHoaDon themHoaDonForm = new ThemHoaDon();
            themHoaDonForm.DataUpdated += Form_DataUpdated;
            themHoaDonForm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            SearchData(keyword);
        }
    }
}
