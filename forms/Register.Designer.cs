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
            this.label3 = new System.Windows.Forms.Label();
            this.registerEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHo = new System.Windows.Forms.Label();
            this.lastnameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstnameTxt = new System.Windows.Forms.TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneNumTxt = new System.Windows.Forms.TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.genderCbb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.genderTxt = new System.Windows.Forms.Label();
            this.registerBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(5, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(128, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Tên người dùng:";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // registerUsername
            // 
            this.registerUsername.BackColor = System.Drawing.SystemColors.HighlightText;
            this.registerUsername.Location = new System.Drawing.Point(156, 37);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(225, 22);
            this.registerUsername.TabIndex = 3;
            this.registerUsername.TextChanged += new System.EventHandler(this.registerUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // registerPassword
            // 
            this.registerPassword.Location = new System.Drawing.Point(110, 92);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.PasswordChar = '*';
            this.registerPassword.Size = new System.Drawing.Size(271, 22);
            this.registerPassword.TabIndex = 3;
            this.registerPassword.TextChanged += new System.EventHandler(this.registerPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xác nhận mật khẩu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(186, 151);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(195, 22);
            this.confirmPassword.TabIndex = 3;
            this.confirmPassword.TextChanged += new System.EventHandler(this.confirmPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // registerEmail
            // 
            this.registerEmail.Location = new System.Drawing.Point(99, 176);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(219, 22);
            this.registerEmail.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLXeMay.Properties.Resources.user_profile;
            this.pictureBox1.Location = new System.Drawing.Point(347, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelHo
            // 
            this.labelHo.AutoSize = true;
            this.labelHo.BackColor = System.Drawing.Color.Transparent;
            this.labelHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHo.Location = new System.Drawing.Point(38, 68);
            this.labelHo.Name = "labelHo";
            this.labelHo.Size = new System.Drawing.Size(36, 20);
            this.labelHo.TabIndex = 7;
            this.labelHo.Text = "Họ:";
            this.labelHo.Click += new System.EventHandler(this.labelHo_Click);
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Location = new System.Drawing.Point(80, 68);
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.Size = new System.Drawing.Size(238, 22);
            this.lastnameTxt.TabIndex = 8;
            this.lastnameTxt.TextChanged += new System.EventHandler(this.lastnameTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Location = new System.Drawing.Point(86, 120);
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.Size = new System.Drawing.Size(232, 22);
            this.firstnameTxt.TabIndex = 8;
            this.firstnameTxt.TextChanged += new System.EventHandler(this.firstnameTxt_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.dateOfBirth);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.registerUsername);
            this.guna2Panel1.Controls.Add(this.registerPassword);
            this.guna2Panel1.Controls.Add(this.phoneNumTxt);
            this.guna2Panel1.Controls.Add(this.confirmPassword);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(39, 244);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(393, 332);
            this.guna2Panel1.TabIndex = 9;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Checked = true;
            this.dateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirth.Location = new System.Drawing.Point(99, 200);
            this.dateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(282, 42);
            this.dateOfBirth.TabIndex = 12;
            this.dateOfBirth.Value = new System.DateTime(2024, 11, 10, 23, 35, 0, 569);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày sinh:";
            // 
            // phoneNumTxt
            // 
            this.phoneNumTxt.Location = new System.Drawing.Point(134, 273);
            this.phoneNumTxt.Name = "phoneNumTxt";
            this.phoneNumTxt.Size = new System.Drawing.Size(247, 22);
            this.phoneNumTxt.TabIndex = 3;
            this.phoneNumTxt.TextChanged += new System.EventHandler(this.confirmPassword_TextChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.genderCbb);
            this.guna2Panel2.Controls.Add(this.firstnameTxt);
            this.guna2Panel2.Controls.Add(this.registerEmail);
            this.guna2Panel2.Controls.Add(this.genderTxt);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.labelHo);
            this.guna2Panel2.Controls.Add(this.lastnameTxt);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(503, 244);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(343, 332);
            this.guna2Panel2.TabIndex = 9;
            // 
            // genderCbb
            // 
            this.genderCbb.BackColor = System.Drawing.Color.Transparent;
            this.genderCbb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCbb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCbb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCbb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderCbb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genderCbb.ItemHeight = 30;
            this.genderCbb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.genderCbb.Location = new System.Drawing.Point(120, 231);
            this.genderCbb.Name = "genderCbb";
            this.genderCbb.Size = new System.Drawing.Size(198, 36);
            this.genderCbb.TabIndex = 9;
            // 
            // genderTxt
            // 
            this.genderTxt.AutoSize = true;
            this.genderTxt.BackColor = System.Drawing.Color.Transparent;
            this.genderTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTxt.Location = new System.Drawing.Point(38, 237);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(76, 20);
            this.genderTxt.TabIndex = 2;
            this.genderTxt.Text = "Giới tính:";
            // 
            // registerBtn
            // 
            this.registerBtn.BorderRadius = 20;
            this.registerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerBtn.FillColor = System.Drawing.Color.White;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.Black;
            this.registerBtn.Location = new System.Drawing.Point(347, 636);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(180, 45);
            this.registerBtn.TabIndex = 9;
            this.registerBtn.Text = "Đăng ký";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click_1);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 710);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox registerEmail;
        private System.Windows.Forms.Label labelHo;
        private System.Windows.Forms.TextBox lastnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstnameTxt;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneNumTxt;
        private Guna.UI2.WinForms.Guna2ComboBox genderCbb;
        private System.Windows.Forms.Label genderTxt;
        private Guna.UI2.WinForms.Guna2Button registerBtn;
    }
}