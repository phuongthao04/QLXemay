using QLXeMay.dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay.repository
{
    internal class ChiTietHDNRepo
    {
        private SqlCommand command;
        public void AddChiTietHDN(ChiTietHDN cthdn)
        {


            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();

                string query = @"
INSERT INTO chi_tiet_hdn (so_luong,thanh_tien)
VALUES (@soLuong,@GiaNhap)";
                command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@soLuong", cthdn.SoLuong);
                command.Parameters.AddWithValue("@GiaNhap", cthdn.GiaNhap);


                command.ExecuteNonQuery();


            }
        }
    }
}
