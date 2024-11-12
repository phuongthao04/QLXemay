using QLXeMay.dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay.repository
{
    internal class HoaDonNhapRepo
    {
        private SqlCommand command;
        public void AddHoaDonNhap(HoaDonNhap hdn)
        {

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();

                string query = @"
    INSERT INTO hoa_don_nhap (id_nv, id_ncc,ngay_nhap,tong_tien)
    VALUES (@idNV ,@idNCC,CAST(GETDATE() AS DATE),@GiaNhap)";
                command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@idNV", hdn.IdNhanVien);
                command.Parameters.AddWithValue("@idNCC", hdn.IdNhaCungCap);
                command.Parameters.AddWithValue("@GiaNhap", hdn.GiaNhap);

                command.ExecuteNonQuery();
            }
        }
    }
}
