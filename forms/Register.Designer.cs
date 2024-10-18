namespace QLXeMay
{
    partial class Register
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
            this.label = new System.Windows.Forms.Label();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.registerEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(57, 234);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(128, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Tên người dùng:";
            // 
            // registerUsername
            // 
            this.registerUsername.Location = new System.Drawing.Point(250, 234);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(166, 22);
            this.registerUsername.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu:";
            // 
            // registerPassword
            // 
            this.registerPassword.Location = new System.Drawing.Point(250, 289);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.Size = new System.Drawing.Size(166, 22);
            this.registerPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xác nhận mật khẩu:";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(250, 348);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(166, 22);
            this.confirmPassword.TabIndex = 3;
            // 
            // registerBtn
            // 
            this.registerBtn.AutoSize = true;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(179, 488);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(118, 35);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "Đăng ký";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // registerEmail
            // 
            this.registerEmail.Location = new System.Drawing.Point(250, 410);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(166, 22);
            this.registerEmail.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLXeMay.Properties.Resources.user_profile;
            this.pictureBox1.Location = new System.Drawing.Point(149, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 549);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.registerEmail);
            this.Controls.Add(this.registerPassword);
            this.Controls.Add(this.registerUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox registerEmail;
    }
}