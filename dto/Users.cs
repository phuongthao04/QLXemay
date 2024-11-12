using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay
{
    internal class Users
    {
        private int userId;
        private string username;
        private string password;

        public Users()
        {
        }

        public Users(int userId,string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
