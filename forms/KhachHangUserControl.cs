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
        }

        private void KhachHangUserControl_Load(object sender, EventArgs e)
        {
            ClassQLXM kn = new ClassQLXM();
            string sql = "select * from khach_hang";
            dvgKhachHang.DataSource = kn.taobang(sql);
        }
    }
}
