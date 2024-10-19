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
    public partial class SanPhamUserControl : UserControl
    {
        public SanPhamUserControl()
        {
            InitializeComponent();
        }

        private void SanPhamUserControl_Load(object sender, EventArgs e)
        {
            ClassQLXM kn = new ClassQLXM();
            string sql = "select * from kho_hang";
            dvgSanPham.DataSource = kn.taobang(sql);
        }
    }
}
