using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeMay.data_connection
{
    class ClassQLXM
    {
        public SqlConnection con = new SqlConnection("Data Source=TAHO\\SQLEXPRESS;Initial Catalog=qlxm;Integrated Security=True;Encrypt=False;");
        public DataTable taobang(string sql)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, con);
            ds.Fill(dt);
            return (dt);
        }
        //public void InsertUser(string firstName, string lastName, string phoneNumber, string email, string city, DateTime dateOfBirth, string postcode, string country)
        //{
        //    try
        //    {
        //        con.Open();
        //        string query = "INSERT INTO UserName (FirstName, LastName, PhoneNumber, Email, City, DateOfBirth, Postcode, Country) " +
        //                       "VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @City, @DateOfBirth, @Postcode, @Country)";

        //        using (SqlCommand command = new SqlCommand(query, con))
        //        {
        //            command.Parameters.AddWithValue("@FirstName", firstName);
        //            command.Parameters.AddWithValue("@LastName", lastName);
        //            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
        //            command.Parameters.AddWithValue("@Email", email);
        //            command.Parameters.AddWithValue("@City", city);
        //            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
        //            command.Parameters.AddWithValue("@Postcode", postcode);
        //            command.Parameters.AddWithValue("@Country", country);

        //            int result = command.ExecuteNonQuery();
        //            if (result > 0)
        //            {
        //                MessageBox.Show("Thông tin đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Không thể thêm thông tin. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
    }
}
