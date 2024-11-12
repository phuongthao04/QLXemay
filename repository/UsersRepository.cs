using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLXeMay.dto;
namespace QLXeMay
{
    internal class UsersRepository
    {
        private SqlCommand command;
        private SqlDataReader dataReader;

        public UsersRepository() { }

        public List<Users> users(string query)
        {
            List<Users> users = new List<Users>();

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    users.Add(new Users(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2)));
                }

                sqlConnection.Close();
            }
            return users;
        }

        public void save(UserRegister user)
        {
            string query = "INSERT INTO users (username, passwrd, phoneNumber, email) VALUES (@username, @passwrd, @phoneNumber, @email)";

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@passwrd", user.Password);
                command.Parameters.AddWithValue("@phoneNumber", user.PhoneNumber); // Kiểm tra null
                command.Parameters.AddWithValue("@email", user.Email);

                // Thực thi câu lệnh
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public bool existsByEmail(string email)
        {
            string query = "SELECT COUNT(*) FROM users WHERE email = @Email";

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    // Sử dụng tham số để tránh SQL Injection
                    command.Parameters.AddWithValue("@Email", email);

                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Trả về true nếu có ít nhất 1 bản ghi
                }
            }
        }

        public bool existsByUsername(string username)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @Username";

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    // Sử dụng tham số để tránh SQL Injection
                    command.Parameters.AddWithValue("@Username", username);

                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Trả về true nếu có ít nhất 1 bản ghi
                }
            }
        }

        public List<Users> getUserByEmail(string email)
        {
            string query = "SELECT * FROM users WHERE email = @Email";

            List<Users> users = new List<Users>();

            using (SqlConnection sqlConnection = DatabaseUtils.connection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            users.Add(new Users(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2)));
                        }
                    }
                }
                sqlConnection.Close();
            }
            return users;
        }
    }
}
