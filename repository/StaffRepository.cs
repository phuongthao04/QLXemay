using QLXeMay.dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay.repository
{
    public class StaffRepository
    {
        private SqlCommand command;
        private SqlDataReader dataReader;

        public StaffRepository() { }

        public List<Staff> staffs()
        {
            List<Staff> staffs = new List<Staff>();
            string query = "select * from nhan_vien";
            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    staffs.Add(new Staff(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetDateTime(3)));
                }

                sqlConnection.Close();
            }
            return staffs;
        }

        public void save(Staff staff)
        {
            string query = "INSERT INTO nhan_vien (ten_nv, gioi_tinh, ngay_sinh, ma_cv) VALUES (@ten_nv, @gioi_tinh, @ngay_sinh, @ma_cv)";

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@ten_nv", staff.FullName);
                command.Parameters.AddWithValue("@gioi_tinh", staff.Gender);
                command.Parameters.AddWithValue("@ngay_sinh", staff.Dob);
                command.Parameters.AddWithValue("@ma_cv", 2); // Tham số cho mã công việc

                // Thực thi câu lệnh
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }
    }
}
