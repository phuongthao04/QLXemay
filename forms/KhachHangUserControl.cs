using QLXeMay.data_connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeMay.forms
{
    public partial class KhachHangUserControl : UserControl
    {
        public KhachHangUserControl()
        {
            InitializeComponent();
            dvgKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.White;

            // Đổi màu chữ header thành màu đen
            dvgKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void KhachHangUserControl_Load(object sender, EventArgs e)
        {
            ClassQLXM kn = new ClassQLXM();
            string sql = "Select ten_kh, dia_chi,so_dt\r\n\tfrom khach_hang";
            dvgKhachHang.DataSource = kn.taobang(sql);
            dvgKhachHang.Columns[0].HeaderText = "Tên khách hàng"; 
            dvgKhachHang.Columns[1].HeaderText = "Địa chỉ";        // Cột dia_chi
            dvgKhachHang.Columns[2].HeaderText = "Số điện thoại";
        }

        private void dvgKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
