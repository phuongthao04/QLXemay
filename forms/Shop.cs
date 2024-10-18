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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoundedButton button = sender as RoundedButton;
            if (button != null)
            {
                button.BackColor = Color.LightBlue;
            }
        }

        private void productMenu_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void productMenu_MouseHover(object sender, EventArgs e)
        {
            productMenu.BackColor = Color.White;
        }

        private void productMenu_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
