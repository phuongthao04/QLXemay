namespace QLXeMay.forms
{
    partial class SanPhamUserControl
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
            this.dvgSanPham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgSanPham
            // 
            this.dvgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSanPham.Location = new System.Drawing.Point(0, 194);
            this.dvgSanPham.Name = "dvgSanPham";
            this.dvgSanPham.RowHeadersWidth = 51;
            this.dvgSanPham.RowTemplate.Height = 24;
            this.dvgSanPham.Size = new System.Drawing.Size(1268, 388);
            this.dvgSanPham.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý sản phẩm";
            // 
            // SanPhamUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgSanPham);
            this.Name = "SanPhamUserControl";
            this.Size = new System.Drawing.Size(1386, 702);
            this.Load += new System.EventHandler(this.SanPhamUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgSanPham;
        private System.Windows.Forms.Label label1;
    }
}
