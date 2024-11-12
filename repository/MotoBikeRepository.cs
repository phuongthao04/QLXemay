using QLXeMay.dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay.repository
{
    internal class MotoBikeRepository
    {
        private SqlCommand command;
        private SqlDataReader dataReader;

        public List<MotoBikeDto> motobikes(string query)
        {
            List<MotoBikeDto> motobikes = new List<MotoBikeDto>();

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    MotoBikeDto moto = new MotoBikeDto();
                    moto.TenXe = dataReader.GetString(0);
                    moto.TenLoai = dataReader.GetString(1);
                    moto.DongCo = dataReader.GetString(2);
                    moto.Mau = dataReader.GetString(3);
                    moto.TinhTrang = dataReader.GetString(4);
                    moto.TenNSX = dataReader.GetString(5);
                    moto.Phanh = dataReader.GetString(6);
                    moto.GiaBan = dataReader.GetDecimal(7);     
                    moto.GiaNhap = dataReader.GetDecimal(8);
                    moto.SoLuong = dataReader.GetInt32(9);
                    motobikes.Add(moto);
                }

                sqlConnection.Close();
            }
            return motobikes;
        }
        public void AddMotoBike(MotoBikeDto moto)
        {
            string query = @"
    INSERT INTO kho_hang (ten_xe, id_loai, id_dc, id_mau, id_tt, id_nsx, id_phanh, gia_ban, gia_nhap, so_luong)
    VALUES (@TenXe, @IdLoai, @IdDongCo, @IdMau, @IdTinhTrang, @IdNSX, @IdPhanh, @GiaBan, @GiaNhap, @SoLuong)";

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@TenXe", moto.TenXe);
                command.Parameters.AddWithValue("@IdLoai", moto.IdLoai);        // Giá trị ID loại xe từ ComboBox
                command.Parameters.AddWithValue("@IdDongCo", moto.IdDongCo);    // Giá trị ID động cơ từ ComboBox
                command.Parameters.AddWithValue("@IdMau", moto.IdMau);          // Giá trị ID màu từ ComboBox
                command.Parameters.AddWithValue("@IdTinhTrang", moto.IdTinhTrang); // Giá trị ID tình trạng từ ComboBox
                command.Parameters.AddWithValue("@IdNSX", moto.IdNSX);          // Giá trị ID nhà sản xuất từ ComboBox
                command.Parameters.AddWithValue("@IdPhanh", moto.IdPhanh);      // Giá trị ID phanh từ ComboBox
                command.Parameters.AddWithValue("@GiaBan", moto.GiaBan);
                command.Parameters.AddWithValue("@GiaNhap", moto.GiaNhap);
				command.Parameters.AddWithValue("@SoLuong", moto.SoLuong);

				command.ExecuteNonQuery();
            }
        }
        public void UpdateMotoBike(MotoBikeDto moto)
        {
            string query = @"
    UPDATE kho_hang
    SET id_loai = @IdLoai, id_dc = @IdDongCo, 
        id_mau = @IdMau, id_tt = @IdTinhTrang, id_nsx = @IdNSX, 
        id_phanh = @IdPhanh, so_luong = @SoLuong
    WHERE ten_xe = @TenXe"; 

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@TenXe", moto.TenXe);
                command.Parameters.AddWithValue("@IdLoai", moto.IdLoai);
                command.Parameters.AddWithValue("@IdDongCo", moto.IdDongCo);
                command.Parameters.AddWithValue("@IdMau", moto.IdMau);
                command.Parameters.AddWithValue("@IdTinhTrang", moto.IdTinhTrang);
                command.Parameters.AddWithValue("@IdNSX", moto.IdNSX);
                command.Parameters.AddWithValue("@IdPhanh", moto.IdPhanh);
                command.Parameters.AddWithValue("@GiaBan", moto.GiaBan);
                command.Parameters.AddWithValue("@GiaNhap", moto.GiaNhap);
                command.Parameters.AddWithValue("@SoLuong", moto.SoLuong);

                command.ExecuteNonQuery();
            }
        }
        public void DeleteMotoBike(string tenXe)
        {
            string query = "DELETE FROM kho_hang WHERE ten_xe = @TenXe";

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@TenXe", tenXe);

                command.ExecuteNonQuery();
            }
        }

    }
}
