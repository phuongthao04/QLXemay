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
    public partial class RetakePassword : Form
    {
        UsersRepository usersRepository = new UsersRepository();
        public RetakePassword()
        {
            InitializeComponent();
        }

        private void retakePwBtn_Click(object sender, EventArgs e)
        {
            String email = registerEmail.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (usersRepository.existsByEmail(email))
            {
                String password = usersRepository.getUserByEmail(email)[0].Password;
                kquaTxt.Text = password;
            }
            else
            {
                MessageBox.Show("Email ko tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
