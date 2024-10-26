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
using System.Windows.Forms.DataVisualization.Charting;

namespace QLXeMay.forms
{
    public partial class TrangChuUserControl : UserControl
    {
        public TrangChuUserControl()
        {
            InitializeComponent();
            dtpDate.Value = DateTime.Today; // Set initial date to today
            LoadTrangChuData();
            dtpDate.ValueChanged += new EventHandler(dtpDate_ValueChanged);
            LoadDoanhThuChart();
            LoadXeBanChart();
            LoadKhachHangTrangChuData();
        }

        private void TrangChuUserControl_Load(object sender, EventArgs e)
        {
            LoadTrangChuData();  // Tải dữ liệu trang chủ
            LoadKhachHangTrangChuData();
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadTrangChuData();
            LoadKhachHangTrangChuData();
        }

        private void LoadTrangChuData()
        {
            DateTime selectedDate = DateTime.Today; // Lấy ngày hôm nay
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();

                    // Truy vấn đếm khách hàng trong ngày từ bảng don_dat_hang
                    string queryKhachHang = @"
            SELECT COUNT(DISTINCT id_kh) 
            FROM don_dat_hang 
            WHERE CAST(ngay_mua AS DATE) = @selectedDate";
                    SqlCommand cmdKhachHang = new SqlCommand(queryKhachHang, conn);
                    cmdKhachHang.Parameters.AddWithValue("@selectedDate", selectedDate);
                    object resultKhachHang = cmdKhachHang.ExecuteScalar();
                    int soKhachHang = resultKhachHang != DBNull.Value ? Convert.ToInt32(resultKhachHang) : 0;
                    lblSoKhachHang.Text = soKhachHang.ToString();

                    // Truy vấn đếm đơn đặt hàng theo ngày từ bảng don_dat_hang
                    string queryHoaDon = @"
            SELECT COUNT(*) 
            FROM don_dat_hang 
            WHERE CAST(ngay_mua AS DATE) = @selectedDate";
                    SqlCommand cmdHoaDon = new SqlCommand(queryHoaDon, conn);
                    cmdHoaDon.Parameters.AddWithValue("@selectedDate", selectedDate);
                    object resultHoaDon = cmdHoaDon.ExecuteScalar();
                    int soHoaDon = resultHoaDon != DBNull.Value ? Convert.ToInt32(resultHoaDon) : 0;
                    lblSoDH.Text = soHoaDon.ToString();

                    // Truy vấn tổng tiền theo ngày từ bảng don_dat_hang
                    string queryTongTien = @"
            SELECT SUM(tong_tien) 
            FROM don_dat_hang 
            WHERE CAST(ngay_mua AS DATE) = @selectedDate";
                    SqlCommand cmdTongTien = new SqlCommand(queryTongTien, conn);
                    cmdTongTien.Parameters.AddWithValue("@selectedDate", selectedDate);
                    object resultTongTien = cmdTongTien.ExecuteScalar();
                    decimal tongTien = resultTongTien != DBNull.Value ? Convert.ToDecimal(resultTongTien) : 0;
                    lblDoanhSoHT.Text = tongTien.ToString("C");

                    // Truy vấn tổng số lượng xe được bán trong ngày từ bảng chi_tiet_ddh
                    string querySoSanPham = @"
            SELECT SUM(so_luong) 
            FROM chi_tiet_ddh 
            WHERE id_ddh IN 
                (SELECT id_ddh 
                 FROM don_dat_hang 
                 WHERE CAST(ngay_mua AS DATE) = @selectedDate)";
                    SqlCommand cmdSoSanPham = new SqlCommand(querySoSanPham, conn);
                    cmdSoSanPham.Parameters.AddWithValue("@selectedDate", selectedDate);
                    object resultSoSanPham = cmdSoSanPham.ExecuteScalar();
                    int soSanPham = resultSoSanPham != DBNull.Value ? Convert.ToInt32(resultSoSanPham) : 0;
                    lblSoSP.Text = soSanPham.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        // Load revenue chart


        // Load customer data based on selected date
        private void LoadKhachHangTrangChuData()
        {
            DateTime selectedDate = dtpDate.Value.Date;

            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT ddh.id_ddh AS 'Mã đơn hàng', kh.ten_kh AS 'Tên khách', SUM(ctddh.so_luong) AS 'Số lượng đơn hàng', 
                           ddh.ngay_mua AS 'Ngày mua', ddh.tong_tien AS 'Tổng tiền'
                    FROM don_dat_hang ddh
                    INNER JOIN khach_hang kh ON ddh.id_kh = kh.id_kh
                    INNER JOIN chi_tiet_ddh ctddh ON ddh.id_ddh = ctddh.id_ddh
                    WHERE CAST(ddh.ngay_mua AS DATE) = @selectedDate
                    GROUP BY ddh.id_ddh, kh.ten_kh, ddh.ngay_mua, ddh.tong_tien";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@selectedDate", SqlDbType.Date).Value = selectedDate;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dtbKhachHangTrangChu.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void LoadDoanhThuChart()
        {
            DateTime today = DateTime.Now;

            // Tính toán ngày bắt đầu và kết thúc của tuần hiện tại
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek + 1);
            DateTime endOfWeek = startOfWeek.AddDays(6);

            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();

                    // Truy vấn doanh thu, số khách hàng và số hóa đơn theo từng ngày trong tuần hiện tại
                    string query = @"
                    SELECT 
                    CAST(ngay_mua AS DATE) AS Ngay, 
                    SUM(tong_tien) AS DoanhThu
                    FROM don_dat_hang 
                    WHERE ngay_mua >= @startDate AND ngay_mua <= @endDate 
                    GROUP BY CAST(ngay_mua AS DATE)
                    ORDER BY Ngay";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@startDate", startOfWeek);
                    cmd.Parameters.AddWithValue("@endDate", endOfWeek);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa các điểm dữ liệu hiện có trong chart
                    chartDoanhThu.Series["Doanh thu"].Points.Clear();

                    // Thêm dữ liệu vào biểu đồ
                    while (reader.Read())
                    {
                        DateTime ngay = reader.GetDateTime(0); // Ngày mua
                        decimal doanhThu = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1); // Doanh thu

                        // Thêm dữ liệu vào các series trong chart
                        chartDoanhThu.Series["Doanh thu"].Points.AddXY(ngay.ToString("dd/MM"), doanhThu);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void LoadXeBanChart()
        {
            using (SqlConnection conn = DatabaseUtils.connection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT k.ten_xe AS TenXe, SUM(ct.so_luong) AS SoLuongDaBan
                FROM chi_tiet_ddh ct
                JOIN don_dat_hang ddh ON ct.id_ddh = ddh.id_ddh
                JOIN kho_hang k ON ct.id_xe = k.id_xe
                GROUP BY k.ten_xe
                ORDER BY SoLuongDaBan DESC;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear existing data in the chart
                    chartSSXe.Series.Clear();

                    // Add a new series for the doughnut chart
                    Series series = new Series("XeBan")
                    {
                        ChartType = SeriesChartType.Doughnut,
                        IsValueShownAsLabel = false // Hide labels on the chart itself
                    };
                    chartSSXe.Series.Add(series);

                    // Add data points to the series
                    while (reader.Read())
                    {
                        string tenXe = reader.GetString(0);           // Model name
                        int soLuongDaBan = reader.GetInt32(1);        // Quantity sold

                        // Add each bike model and quantity sold to the chart
                        series.Points.AddXY(tenXe, soLuongDaBan);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
