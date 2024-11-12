using QLXeMay.dto;
using QLXeMay.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeMay
{
    public partial class Register : Form
    {
        private UsersRepository usersRepository = new UsersRepository();
        private StaffRepository staffRepository = new StaffRepository();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lastnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelHo_Click(object sender, EventArgs e)
        {

        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firstnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validateInput(String username, String password, 
            String confirmPass, DateTime dob, String phoneNum,
            String firstname, String lastname, String email, object gender)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Tên đăng nhập không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra mật khẩu
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra xác nhận mật khẩu
            if (password != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra ngày sinh
            if (dob >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra số điện thoại
            if (string.IsNullOrEmpty(phoneNum) || !Regex.IsMatch(phoneNum, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra tên
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Tên và họ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra email
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra giới tính
            if (gender == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Tất cả đều hợp lệ
        }

        private void registerBtn_Click_1(object sender, EventArgs e)
        {
            String username = registerUsername.Text;
            String password = registerPassword.Text;
            String confirmPass = confirmPassword.Text;
            DateTime dob = dateOfBirth.Value;
            String phoneNum = phoneNumTxt.Text;
            String firstname = firstnameTxt.Text;
            String lastname = lastnameTxt.Text;
            String email = registerEmail.Text;
            var gender = genderCbb.SelectedItem;
            if (validateInput(username, password, confirmPass, dob,
                phoneNum, firstname, lastname, email, gender))
            {
                if (usersRepository.existsByUsername(username) || usersRepository.existsByEmail(email))
                {
                    MessageBox.Show("Username hoặc email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                String fullname = lastname + " " + firstname;
                Staff staff = new Staff(staffRepository.staffs().Count + 1, fullname, gender.ToString(), dob);
                UserRegister user = new UserRegister(username, password, phoneNum, email, staff.StaffId);
                staffRepository.save(staff);
                usersRepository.save(user);
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form
                this.Close();
            }

        }
    }
}
