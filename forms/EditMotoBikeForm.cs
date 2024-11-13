using QLXeMay.dto;
using QLXeMay.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeMay.forms
{
    public partial class EditMotoBikeForm : Form
    {
        public string TenXe { get; private set; }
        public int IdLoai { get; private set; }
        public int IdDongCo { get; private set; }
        public int IdMau { get; private set; }
        public int IdTinhTrang { get; private set; }
        public int IdNSX { get; private set; }
        public int IdPhanh { get; private set; }
        public string TenLoai { get; private set; }
        public string DongCo { get; private set; }
        public string Mau { get; private set; }
        public string TinhTrang { get; private set; }
        public string TenNSX { get; private set; }
        public string Phanh { get; private set; }
        public decimal GiaBan { get; private set; }
        public decimal GiaNhap { get; private set; }
        public int SoLuong { get; private set; }

        private MotoBikeRepository motoBikeRepo = new MotoBikeRepository();

        public EditMotoBikeForm(MotoBikeDto moto)
        {
            InitializeComponent();
            LoadComboBoxData();
            // Khởi tạo các trường thông tin từ đối tượng MotoBikeDto
            txtTenXe.Text = moto.TenXe;

            // Gán các ComboBox với giá trị ID
            txtGiaBan.Text = moto.GiaBan.ToString();
            txtGiaNhap.Text = moto.GiaNhap.ToString();
            txtSoLuong.Text = moto.SoLuong.ToString();
            txtTenXe.ReadOnly = true;
            txtGiaBan.ReadOnly = true;
            txtGiaNhap.ReadOnly = true;
            cboLoai.SelectedIndex = cboLoai.FindStringExact(moto.TenLoai);
            cboDongCo.SelectedIndex = cboDongCo.FindStringExact(moto.DongCo);
            cboMau.SelectedIndex = cboMau.FindStringExact(moto.Mau);
            cboTinhTrang.SelectedIndex = cboTinhTrang.FindStringExact(moto.TinhTrang);
            cboNSX.SelectedIndex = cboNSX.FindStringExact(moto.TenNSX);
            cboPhanh.SelectedIndex = cboPhanh.FindStringExact(moto.Phanh);
        }

        private DataTable GetComboBoxData(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = DatabaseUtils.connection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        private void LoadComboBoxData()
        {
            // Load dữ liệu vào các ComboBox
            cboLoai.DataSource = GetComboBoxData("SELECT id_loai, ten_loai FROM the_loai");
            cboLoai.DisplayMember = "ten_loai";
            cboLoai.ValueMember = "id_loai";

            cboDongCo.DataSource = GetComboBoxData("SELECT id_dongco, ten_dc FROM dong_co");
            cboDongCo.DisplayMember = "ten_dc";
            cboDongCo.ValueMember = "id_dongco";

            cboMau.DataSource = GetComboBoxData("SELECT id_mau, ten_mau FROM mau_sac");
            cboMau.DisplayMember = "ten_mau";
            cboMau.ValueMember = "id_mau";

            cboTinhTrang.DataSource = GetComboBoxData("SELECT id_tt, ten_TT FROM tinh_trang");
            cboTinhTrang.DisplayMember = "ten_TT";
            cboTinhTrang.ValueMember = "id_tt";

            cboNSX.DataSource = GetComboBoxData("SELECT id_nsx, ten_nsx FROM nha_san_xuat");
            cboNSX.DisplayMember = "ten_nsx";
            cboNSX.ValueMember = "id_nsx";

            cboPhanh.DataSource = GetComboBoxData("SELECT id_phanh, ten_phanh FROM phanh_xe");
            cboPhanh.DisplayMember = "ten_phanh";
            cboPhanh.ValueMember = "id_phanh";
        }
        private void btlLuu_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Số lượng phải là một số nguyên hợp lệ.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TenXe = txtTenXe.Text;
            IdLoai = (int)cboLoai.SelectedValue;
            IdDongCo = (int)cboDongCo.SelectedValue;
            IdMau = (int)cboMau.SelectedValue;
            IdTinhTrang = (int)cboTinhTrang.SelectedValue;
            IdNSX = (int)cboNSX.SelectedValue;
            IdPhanh = (int)cboPhanh.SelectedValue;
            GiaBan = decimal.Parse(txtGiaBan.Text);
            GiaNhap = decimal.Parse(txtGiaNhap.Text);
            SoLuong = int.Parse(txtSoLuong.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditMotoBikeForm_Load(object sender, EventArgs e)
        {

        }
    }

}
