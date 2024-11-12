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
        private int userID;
        public ProfileControl( int userID)
        {
            InitializeComponent();
            lblUserName.Text = "HARRY KANE";
            this.userID = userID; // Gán userID cho biến toàn cục
            lblUserName.Font = new Font("Arial", 14, FontStyle.Bold);
            buttonSaveImage.Click += new EventHandler(SaveImage_Click);
            LoadUserInfo(userID);
        }
        private void SaveImage_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void SetUserInfo(Dictionary<string, object> userInfo)
        {
        }
        public void LoadUserInfo(int userID)
        {
            string query = @"SELECT u.user_id, u.username, u.email, u.phoneNumber, 
                                    nv.id_nv, nv.ten_nv, nv.ngay_sinh
                             FROM users u JOIN nhan_vien nv ON u.id_nv = nv.id_nv
                             WHERE u.id_nv = @userID";

            using (SqlConnection conn = DatabaseUtils.connection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblUserName.Text = reader["ten_nv"].ToString();
                        txtFullName.Text = reader["ten_nv"].ToString();
                        txtPhoneNumber.Text = reader["phoneNumber"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txtDateOfBirth.Text = DateTime.TryParse(reader["ngay_sinh"].ToString(), out DateTime dob)
                            ? dob.ToString("dd/MM/yyyy")
                            : "Ngày không hợp lệ";                        // Thêm các thông tin khác nếu cần
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin người dùng.");
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblUserName.Text = txtFullName.Text;
            string fullName = txtFullName.Text.Trim();
            string passWord = txtPassWord.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string dateOfBirth = txtDateOfBirth.Text.Trim();

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Fullname không được để trống.");
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

            if (!DateTime.TryParseExact(dateOfBirth, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập ngày theo định dạng dd/MM/yyyy.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=TAHO\\SQLEXPRESS;Initial Catalog=qlxm;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    // Câu lệnh SQL UPDATE để cập nhật thông tin người dùng trong bảng users và nhan_vien
                    string updateUsersQuery = "UPDATE users SET passwrd = @passwrd, email = @Email, phoneNumber = @phoneNumber WHERE user_id = @userID";
                    string updateNhanVienQuery = "UPDATE nhan_vien SET ten_nv = @ten_nv, ngay_sinh = @ngay_sinh WHERE id_nv = @id_nv";

                    // Cập nhật thông tin trong bảng `users`
                    using (SqlCommand cmd = new SqlCommand(updateUsersQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@passwrd", passWord);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@userID", this.userID);

                        cmd.ExecuteNonQuery();
                    }

                    // Cập nhật thông tin trong bảng `nhan_vien`
                    using (SqlCommand cmd = new SqlCommand(updateNhanVienQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ten_nv", fullName);
                        cmd.Parameters.AddWithValue("@ngay_sinh", parsedDate); // Sử dụng parsedDate thay vì Convert.ToDateTime
                        cmd.Parameters.AddWithValue("@id_nv", this.userID); // giả sử `id_nv` và `userID` trùng nhau

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật thông tin thành công!");
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
        private bool IsValidFullName(string fullName)
        {
            return Regex.IsMatch(fullName, @"^[a-zA-Z]+$");
        }
        private bool IsValidPassword(string password)
        {
            // Mật khẩu phải có ít nhất 6 ký tự, bao gồm cả chữ in hoa, chữ thường, số và ký tự đặc biệt
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{6,}$";
            return Regex.IsMatch(password, pattern);
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
            lblUserName.Text = txtFullName.Text;
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