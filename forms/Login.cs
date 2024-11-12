using QLXeMay.forms;
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

			// Validate input
			validateEntry(usernameTxt, passwordTxt);

			// Use parameterized query to avoid SQL injection
			string query = "SELECT user_id FROM users WHERE username = @username AND passwrd = @password";

			// Pass parameters to the repository method to avoid SQL injection
			var result = usersRepository.GetUserByCredentials(query, usernameTxt, passwordTxt);

			if (result.Count > 0)
			{
				int userId = result[0].UserId;
				MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Open the Home form and hide the Login form
				Home homeForm = new Home(userId);
				homeForm.Show();
				this.Hide(); // Hide Login form
			}
			else
			{
				MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
