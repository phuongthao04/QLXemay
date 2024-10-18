namespace QLXeMay
{
    partial class RetakePassword
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
            this.registerEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.retakePwResult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.retakePwBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registerEmail
            // 
            this.registerEmail.Location = new System.Drawing.Point(205, 185);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(219, 22);
            this.registerEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // retakePwResult
            // 
            this.retakePwResult.AutoSize = true;
            this.retakePwResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retakePwResult.Location = new System.Drawing.Point(123, 257);
            this.retakePwResult.Name = "retakePwResult";
            this.retakePwResult.Size = new System.Drawing.Size(71, 20);
            this.retakePwResult.TabIndex = 4;
            this.retakePwResult.Text = "Kết quả:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 22);
            this.textBox1.TabIndex = 5;
            // 
            // retakePwBtn
            // 
            this.retakePwBtn.AutoSize = true;
            this.retakePwBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retakePwBtn.Location = new System.Drawing.Point(213, 309);
            this.retakePwBtn.Name = "retakePwBtn";
            this.retakePwBtn.Size = new System.Drawing.Size(141, 35);
            this.retakePwBtn.TabIndex = 7;
            this.retakePwBtn.Text = "Lấy lại mật khẩu";
            this.retakePwBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLXeMay.Properties.Resources.user_profile;
            this.pictureBox1.Location = new System.Drawing.Point(235, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // RetakePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 366);
            this.Controls.Add(this.retakePwBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.registerEmail);
            this.Controls.Add(this.retakePwResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RetakePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lấy lại mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox registerEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label retakePwResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button retakePwBtn;
    }
}