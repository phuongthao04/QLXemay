using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXeMay.dto
{
    internal class UserRegister
    {
        private string username;
        private string password;
        private string phoneNumber;
        private string email;
        private int id_nv; // Có thể là null nếu không có khóa ngoại

        public UserRegister() { }

        public UserRegister( string username, string password, string phoneNumber, string email, int id_nv)
        {
            this.username = username;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.id_nv = id_nv;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public int IdNv { get => id_nv; set => id_nv = value; } // Nullable
    }
}
