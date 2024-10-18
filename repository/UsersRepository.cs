using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
                    users.Add(new Users(dataReader.GetString(1), dataReader.GetString(2)));
                }

                sqlConnection.Close();  
            }
                return users;
        }
    }
}
