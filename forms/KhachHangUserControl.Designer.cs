namespace QLXeMay.forms
{
    partial class KhachHangUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dvgKhachHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Khách  Hàng";
            // 
            // dvgKhachHang
            // 
            this.dvgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgKhachHang.Location = new System.Drawing.Point(26, 183);
            this.dvgKhachHang.Name = "dvgKhachHang";
            this.dvgKhachHang.RowHeadersWidth = 51;
            this.dvgKhachHang.RowTemplate.Height = 24;
            this.dvgKhachHang.Size = new System.Drawing.Size(648, 352);
            this.dvgKhachHang.TabIndex = 1;
            // 
            // KhachHangUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgKhachHang);
            this.Controls.Add(this.label1);
            this.Name = "KhachHangUserControl";
            this.Size = new System.Drawing.Size(1386, 702);
            this.Load += new System.EventHandler(this.KhachHangUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgKhachHang;
    }
}
