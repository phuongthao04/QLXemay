namespace QLXeMay.forms
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.pb1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnDangXuat = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnTrangChu = new System.Windows.Forms.Button();
			this.btnKhachHang = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnSanPham = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.trangChuUserControl2 = new QLXeMay.forms.TrangChuUserControl();
			this.sanPhamUserControl3 = new QLXeMay.forms.SanPhamUserControl();
			this.donHangUserControl1 = new QLXeMay.forms.DonHangUserControl();
			this.khachHangUserControl3 = new QLXeMay.forms.KhachHangUserControl();
			this.profileControl4 = new QLXeMay.forms.ProfileControl();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.pb1, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.96825F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.03175F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1540, 113);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 40);
			this.label2.Name = "label2";
			this.tableLayoutPanel1.SetRowSpan(this.label2, 2);
			this.label2.Size = new System.Drawing.Size(0, 32);
			this.label2.TabIndex = 0;
			// 
			// pb1
			// 
			this.pb1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
			this.pb1.Location = new System.Drawing.Point(1402, 23);
			this.pb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pb1.Name = "pb1";
			this.tableLayoutPanel1.SetRowSpan(this.pb1, 2);
			this.pb1.Size = new System.Drawing.Size(91, 66);
			this.pb1.TabIndex = 5;
			this.pb1.TabStop = false;
			this.pb1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.btnDangXuat);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.btnTrangChu);
			this.panel1.Controls.Add(this.btnKhachHang);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.btnSanPham);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 113);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(244, 726);
			this.panel1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(95, 449);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cài đặt";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::QLXeMay.Properties.Resources.settings2;
			this.pictureBox3.InitialImage = global::QLXeMay.Properties.Resources.settings1;
			this.pictureBox3.Location = new System.Drawing.Point(25, 441);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(41, 43);
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// btnDangXuat
			// 
			this.btnDangXuat.FlatAppearance.BorderSize = 0;
			this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangXuat.Image = global::QLXeMay.Properties.Resources.logout1;
			this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDangXuat.Location = new System.Drawing.Point(25, 594);
			this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDangXuat.Name = "btnDangXuat";
			this.btnDangXuat.Size = new System.Drawing.Size(219, 65);
			this.btnDangXuat.TabIndex = 0;
			this.btnDangXuat.Text = "   Đăng xuất";
			this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDangXuat.UseVisualStyleBackColor = true;
			this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
			// 
			// button4
			// 
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Image = global::QLXeMay.Properties.Resources.user__1_;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(21, 508);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(221, 68);
			this.button4.TabIndex = 0;
			this.button4.Text = "   Profile";
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnTrangChu
			// 
			this.btnTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnTrangChu.FlatAppearance.BorderSize = 0;
			this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrangChu.Image = global::QLXeMay.Properties.Resources.revenue2;
			this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTrangChu.Location = new System.Drawing.Point(21, 44);
			this.btnTrangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTrangChu.Name = "btnTrangChu";
			this.btnTrangChu.Size = new System.Drawing.Size(221, 65);
			this.btnTrangChu.TabIndex = 0;
			this.btnTrangChu.Text = "   Trang chủ";
			this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTrangChu.UseVisualStyleBackColor = true;
			this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
			// 
			// btnKhachHang
			// 
			this.btnKhachHang.FlatAppearance.BorderSize = 0;
			this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKhachHang.Image = global::QLXeMay.Properties.Resources.warehouse__1_;
			this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhachHang.Location = new System.Drawing.Point(21, 342);
			this.btnKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKhachHang.Name = "btnKhachHang";
			this.btnKhachHang.Size = new System.Drawing.Size(221, 65);
			this.btnKhachHang.TabIndex = 0;
			this.btnKhachHang.Text = "   Khách Hàng";
			this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKhachHang.UseVisualStyleBackColor = true;
			this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = global::QLXeMay.Properties.Resources.shopping_cart;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(21, 236);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(221, 65);
			this.button2.TabIndex = 0;
			this.button2.Text = "   Đơn hàng";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnSanPham
			// 
			this.btnSanPham.FlatAppearance.BorderSize = 0;
			this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSanPham.Image = global::QLXeMay.Properties.Resources.motocycle;
			this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSanPham.Location = new System.Drawing.Point(21, 133);
			this.btnSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSanPham.Name = "btnSanPham";
			this.btnSanPham.Size = new System.Drawing.Size(221, 65);
			this.btnSanPham.TabIndex = 0;
			this.btnSanPham.Text = "   Sản phẩm";
			this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSanPham.UseVisualStyleBackColor = true;
			this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.label);
			this.panel2.Location = new System.Drawing.Point(245, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(297, 113);
			this.panel2.TabIndex = 7;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.Location = new System.Drawing.Point(75, 23);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(150, 32);
			this.label.TabIndex = 0;
			this.label.Text = "Trang chủ";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Image = global::QLXeMay.Properties.Resources.biker;
			this.pictureBox2.Location = new System.Drawing.Point(48, 0);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(151, 113);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// trangChuUserControl2
			// 
			this.trangChuUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trangChuUserControl2.Location = new System.Drawing.Point(244, 113);
			this.trangChuUserControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.trangChuUserControl2.Name = "trangChuUserControl2";
			this.trangChuUserControl2.Size = new System.Drawing.Size(1296, 726);
			this.trangChuUserControl2.TabIndex = 8;
			// 
			// sanPhamUserControl3
			// 
			this.sanPhamUserControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sanPhamUserControl3.Location = new System.Drawing.Point(244, 113);
			this.sanPhamUserControl3.Name = "sanPhamUserControl3";
			this.sanPhamUserControl3.Size = new System.Drawing.Size(1296, 726);
			this.sanPhamUserControl3.TabIndex = 3;
			// 
			// donHangUserControl1
			// 
			this.donHangUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.donHangUserControl1.Location = new System.Drawing.Point(244, 113);
			this.donHangUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.donHangUserControl1.Name = "donHangUserControl1";
			this.donHangUserControl1.Size = new System.Drawing.Size(1296, 726);
			this.donHangUserControl1.TabIndex = 9;
			this.donHangUserControl1.UserID = 0;
			// 
			// khachHangUserControl3
			// 
			this.khachHangUserControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.khachHangUserControl3.Location = new System.Drawing.Point(244, 113);
			this.khachHangUserControl3.Name = "khachHangUserControl3";
			this.khachHangUserControl3.Size = new System.Drawing.Size(1296, 726);
			this.khachHangUserControl3.TabIndex = 3;
			// 
			// profileControl4
			// 
			this.profileControl4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.profileControl4.Location = new System.Drawing.Point(244, 113);
			this.profileControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.profileControl4.Name = "profileControl4";
			this.profileControl4.Size = new System.Drawing.Size(1296, 726);
			this.profileControl4.TabIndex = 3;
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1540, 839);
			this.Controls.Add(this.profileControl4);
			this.Controls.Add(this.khachHangUserControl3);
			this.Controls.Add(this.donHangUserControl1);
			this.Controls.Add(this.sanPhamUserControl3);
			this.Controls.Add(this.trangChuUserControl2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Location = new System.Drawing.Point(50, 50);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shop";
			this.Load += new System.EventHandler(this.Home_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private SanPhamUserControl sanPhamUserControl1;
        private KhachHangUserControl khachHangUserControl1;
        private TrangChuUserControl trangChuUserControl1;
        private SanPhamUserControl sanPhamUserControl2;
        private KhachHangUserControl khachHangUserControl2;
        private ProfileControl profileControl2;
        private ProfileControl profileControl1;
        private ProfileControl profileControl3;
        private TrangChuUserControl trangChuUserControl2;
        private SanPhamUserControl sanPhamUserControl3;
        private DonHangUserControl donHangUserControl1;
        private KhachHangUserControl khachHangUserControl3;
        private ProfileControl profileControl4;
    }
}