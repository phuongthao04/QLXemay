using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeMay
{
    public partial class Login : Form
    {
        private UsersRepository usersRepository = new UsersRepository();
        public Login()
        {
            InitializeComponent();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RetakePassword retakePassword = new RetakePassword();
            retakePassword.ShowDialog();
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void validateEntry(string usernameTxt, string passwordTxt)
        {
            
            if (usernameTxt.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }

            if (passwordTxt.Trim() == "") 
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string usernameTxt = username.Text;
            string passwordTxt = password.Text;
            validateEntry(usernameTxt, passwordTxt);
            string query = "select * from users " +
                "where username = '" + usernameTxt + "' " +
                "and passwrd = '" + passwordTxt + "'";
            if (usersRepository.users(query).Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Console.WriteLine("Any changes");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
