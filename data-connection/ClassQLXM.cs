using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay.data_connection
{
    class ClassQLXM
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-HQ4Q088\\SQLEXPRESS;Initial Catalog=qlxm;Integrated Security=True;Encrypt=False");
        public DataTable taobang(string sql)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, con);
            ds.Fill(dt);
            return (dt);
        }
    }
}
