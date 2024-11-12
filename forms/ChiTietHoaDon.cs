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
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        public ChiTietHoaDon(string idddh, string tenkh, string ngayMua, string tongTien)
        {
            InitializeComponent();
            lblIDDDH.Text = idddh;
            lblTenKH.Text = tenkh;
            //lblTenPhanh.Text = tenPhanh;
            lblTongTien.Text = tongTien;
            LoadChiTietSanPham(idddh);
        }
        private void LoadChiTietSanPham(string idddh)
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT k.ten_xe AS TenSanPham, ctddh.so_luong AS SoLuong, k.gia_ban AS GiaBan, 
                       ctddh.giam_gia AS GiamGia
                FROM chi_tiet_ddh ctddh
                JOIN kho_hang k ON ctddh.id_xe = k.id_xe
                JOIN don_dat_hang ddh ON ctddh.id_ddh = ddh.id_ddh
                WHERE ctddh.id_ddh = @idddh";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idddh", idddh);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string tenSanPham = reader["TenSanPham"].ToString();
                            int soLuong = Convert.ToInt32(reader["SoLuong"]);
                            decimal giaBan = Convert.ToDecimal(reader["GiaBan"]);
                            decimal giamGia = Convert.ToDecimal(reader["GiamGia"]);

                            // Tính tổng thanh toán
                            decimal thanhToan = soLuong * giaBan;

                            // Cập nhật các label
                            nameItem.Text = tenSanPham + Environment.NewLine;
                            price.Text = giaBan + " x " + soLuong + Environment.NewLine;
                            lblGiamGia.Text = giamGia + Environment.NewLine;

                            // Hiển thị tổng thanh toán
                            lblThanhToan.Text = thanhToan + Environment.NewLine;
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {

        }

		private void nameItem_Click(object sender, EventArgs e)
		{


		}
	}
}
