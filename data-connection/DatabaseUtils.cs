﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLXeMay
{
    internal class DatabaseUtils
    {
        private static string stringConnection = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=qlxm;Integrated Security=True;";

        public static SqlConnection connection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}