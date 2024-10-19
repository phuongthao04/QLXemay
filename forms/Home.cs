using QLXeMay.components;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            trangChuUserControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoundedButton button = sender as RoundedButton;
            if (button != null)
            {
                button.BackColor = Color.LightBlue;
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            sanPhamUserControl1.BringToFront();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            khachHangUserControl1.BringToFront();
        }
    }
}
