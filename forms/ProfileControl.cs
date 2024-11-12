using QLXeMay.data_connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeMay.forms
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
            lblUserName.Text = "HARRY KANE";
            lblUserName.Font = new Font("Arial", 14, FontStyle.Bold);
            buttonSaveImage.Click += new EventHandler(SaveImage_Click);
        }
        private void SaveImage_Click(object sender, EventArgs e)
        {
            //// Kiểm tra xem PictureBox có ảnh hay không
            //if (pictureBox1.Image == null)
            //{
            //    MessageBox.Show("Vui lòng chọn ảnh trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return; // Dừng việc lưu nếu chưa có ảnh
            //}

            //// Nếu có ảnh, tiến hành lưu ảnh
            //Image selectedImage = pictureBox1.Image;

            //// Thực hiện các thao tác lưu ảnh vào cơ sở dữ liệu hoặc file...

            //// Đồng bộ ảnh với PictureBox ở trang chủ
            //Home mainForm = (Home)this.ParentForm;
            //mainForm.UpdateProfilePicture(selectedImage);

            //MessageBox.Show("Ảnh đã được lưu và đồng bộ với trang chủ!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void SetUserInfo(Dictionary<string, object> userInfo)
        {
            if (userInfo != null)
            {
                txtFirstName.Text = userInfo["FirstName"].ToString();
                txtLastName.Text = userInfo["LastName"].ToString();
                txtPhoneNumber.Text = userInfo["PhoneNumber"].ToString();
                txtEmail.Text = userInfo["Email"].ToString();
                txtDateOfBirth.Text = userInfo["DateOfBirth"].ToString();

            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            lblUserName.Text = $"{txtFirstName.Text} {txtLastName.Text}";
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string passWord = txtPassWord.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string dateOfBirth = txtDateOfBirth.Text.Trim();

            // Tạo username từ firstName và lastName
            string username = (firstName + lastName).ToLower(); // Chuyển tất cả thành chữ thường

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First Name không được để trống.");
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name không được để trống.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }

            if (!IsValidPassword(passWord))
            {
                MessageBox.Show("Password không hợp lệ.");
                return;
            }

            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            if (!IsValidDateOfBirth(dateOfBirth))
            {
                MessageBox.Show("Ngày sinh không hợp lệ.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=TAHO\\SQLEXPRESS;Initial Catalog=qlxm;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    // Kiểm tra xem username có tồn tại trong cơ sở dữ liệu
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount == 0)
                        {
                            MessageBox.Show("Không tìm thấy người dùng với username này.");
                            return; // Nếu không tìm thấy user, dừng lại
                        }
                    }

                    // Câu lệnh SQL UPDATE để cập nhật thông tin người dùng
                    string updateQuery = "UPDATE users SET firstName = @firstName, lastName = @lastName, passwrd = @passwrd, email = @Email, phoneNumber = @phoneNumber, dateOfBirth = @dateOfBirth " +
                                         "WHERE username = @username";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@passwrd", passWord);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@dateOfBirth", Convert.ToDateTime(dateOfBirth)); // Chuyển đổi ngày sinh sang DateTime
                        cmd.Parameters.AddWithValue("@username", username); // Không thay đổi username

                        // Thực thi lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật thông tin người dùng.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Lỗi SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }

            // Cập nhật ảnh ở trang chủ (nếu cần)
            Image updatedProfilePicture = pictureBox1.Image;
            Home mainForm = (Home)this.ParentForm;
            mainForm.UpdateProfilePicture(updatedProfilePicture);
        }
        private bool IsValidFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, @"^[a-zA-Z]+$");
        }
        private bool IsValidPassword(string password)
        {
            // Mật khẩu phải có ít nhất 6 ký tự, bao gồm cả chữ in hoa, chữ thường, số và ký tự đặc biệt
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{6,}$";
            return Regex.IsMatch(password, pattern);
        }
        private bool IsValidLastName(string lastName)
        {
            return Regex.IsMatch(lastName, @"^[a-zA-Z]+$");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool IsValidDateOfBirth(string dateOfBirth)
        {
            return DateTime.TryParseExact(dateOfBirth, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _);
        }

        private bool IsValidPostcode(string postcode)
        {
            return Regex.IsMatch(postcode, @"^\d+$");
        }

        private bool IsValidCity(string city)
        {
            return Regex.IsMatch(city, @"^[a-zA-Z]+$");
        }

        private bool IsValidCountry(string country)
        {
            return Regex.IsMatch(country, @"^[a-zA-Z]+$");
        }
        private void UpdateNameLabel(object sender, EventArgs e)
        {
            lblUserName.Text = $"{txtFirstName.Text} {txtLastName.Text}";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
        }
        private void MakePictureBoxCircular(PictureBox pictureBox)
        {
            
        }

        private void btnChangeImg_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Chỉ cho phép chọn file hình ảnh
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            // Kiểm tra nếu người dùng chọn file và nhấn OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đặt hình ảnh vào PictureBox1
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
        public void SetProfilePicture(Image profileImage)
        {
            pictureBox1.Image = profileImage;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Resize(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(200, 200);
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem PictureBox có ảnh hay không
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng việc lưu nếu chưa có ảnh
            }

            // Nếu có ảnh, tiến hành lưu ảnh
            Image selectedImage = pictureBox1.Image;

            // Thực hiện các thao tác lưu ảnh vào cơ sở dữ liệu hoặc file...

            // Đồng bộ ảnh với PictureBox ở trang chủ
            Home mainForm = (Home)this.ParentForm;
            mainForm.UpdateProfilePicture(selectedImage);

            MessageBox.Show("Ảnh đã được lưu và đồng bộ với trang chủ!");
        }
    }
}