namespace QLXeMay.forms
{
    partial class TrangChuUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoKhachHang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoDH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDoanhSoHT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtbKhachHangTrangChu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbKhachHangTrangChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = true;
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(32, 27);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(206, 36);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.Value = new System.DateTime(2024, 10, 26, 13, 47, 26, 303);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblSoKhachHang);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(32, 84);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(202, 93);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(65, 23);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(105, 18);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Số khách hàng";
            // 
            // lblSoKhachHang
            // 
            this.lblSoKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lblSoKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSoKhachHang.Location = new System.Drawing.Point(28, 62);
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.Size = new System.Drawing.Size(12, 20);
            this.lblSoKhachHang.TabIndex = 3;
            this.lblSoKhachHang.Text = "0";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lblSoSP);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(267, 84);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(202, 93);
            this.guna2Panel2.TabIndex = 4;
            // 
            // lblSoSP
            // 
            this.lblSoSP.BackColor = System.Drawing.Color.Transparent;
            this.lblSoSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSoSP.Location = new System.Drawing.Point(28, 62);
            this.lblSoSP.Name = "lblSoSP";
            this.lblSoSP.Size = new System.Drawing.Size(12, 20);
            this.lblSoSP.TabIndex = 3;
            this.lblSoSP.Text = "0";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(65, 23);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(93, 18);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Số sản phẩm";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lblSoDH);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(498, 84);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(202, 93);
            this.guna2Panel3.TabIndex = 5;
            // 
            // lblSoDH
            // 
            this.lblSoDH.BackColor = System.Drawing.Color.Transparent;
            this.lblSoDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSoDH.Location = new System.Drawing.Point(28, 62);
            this.lblSoDH.Name = "lblSoDH";
            this.lblSoDH.Size = new System.Drawing.Size(12, 20);
            this.lblSoDH.TabIndex = 3;
            this.lblSoDH.Text = "0";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(65, 23);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(90, 18);
            this.guna2HtmlLabel6.TabIndex = 2;
            this.guna2HtmlLabel6.Text = "Số đơn hàng";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.lblDoanhSoHT);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(731, 84);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(202, 93);
            this.guna2Panel4.TabIndex = 6;
            // 
            // lblDoanhSoHT
            // 
            this.lblDoanhSoHT.BackColor = System.Drawing.Color.Transparent;
            this.lblDoanhSoHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDoanhSoHT.Location = new System.Drawing.Point(28, 62);
            this.lblDoanhSoHT.Name = "lblDoanhSoHT";
            this.lblDoanhSoHT.Size = new System.Drawing.Size(12, 20);
            this.lblDoanhSoHT.TabIndex = 3;
            this.lblDoanhSoHT.Text = "0";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(65, 23);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(132, 18);
            this.guna2HtmlLabel8.TabIndex = 2;
            this.guna2HtmlLabel8.Text = "Doanh số hệ thống";
            // 
            // dtbKhachHangTrangChu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtbKhachHangTrangChu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtbKhachHangTrangChu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtbKhachHangTrangChu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtbKhachHangTrangChu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtbKhachHangTrangChu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtbKhachHangTrangChu.Location = new System.Drawing.Point(32, 201);
            this.dtbKhachHangTrangChu.Name = "dtbKhachHangTrangChu";
            this.dtbKhachHangTrangChu.RowHeadersVisible = false;
            this.dtbKhachHangTrangChu.Size = new System.Drawing.Size(566, 342);
            this.dtbKhachHangTrangChu.TabIndex = 7;
            this.dtbKhachHangTrangChu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtbKhachHangTrangChu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtbKhachHangTrangChu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtbKhachHangTrangChu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtbKhachHangTrangChu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtbKhachHangTrangChu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtbKhachHangTrangChu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtbKhachHangTrangChu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtbKhachHangTrangChu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtbKhachHangTrangChu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbKhachHangTrangChu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtbKhachHangTrangChu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbKhachHangTrangChu.ThemeStyle.HeaderStyle.Height = 15;
            this.dtbKhachHangTrangChu.ThemeStyle.ReadOnly = false;
            this.dtbKhachHangTrangChu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtbKhachHangTrangChu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtbKhachHangTrangChu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbKhachHangTrangChu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtbKhachHangTrangChu.ThemeStyle.RowsStyle.Height = 22;
            this.dtbKhachHangTrangChu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtbKhachHangTrangChu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(630, 378);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SoKhachHang";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "SoHoaDon";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Series.Add(series3);
            this.chartDoanhThu.Size = new System.Drawing.Size(298, 165);
            this.chartDoanhThu.TabIndex = 8;
            this.chartDoanhThu.Text = "chart1";
            // 
            // TrangChuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartDoanhThu);
            this.Controls.Add(this.dtbKhachHangTrangChu);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dtpDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TrangChuUserControl";
            this.Size = new System.Drawing.Size(967, 571);
            this.Load += new System.EventHandler(this.TrangChuUserControl_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbKhachHangTrangChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoKhachHang;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoDH;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDoanhSoHT;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2DataGridView dtbKhachHangTrangChu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
    }
}
