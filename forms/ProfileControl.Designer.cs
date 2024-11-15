﻿namespace QLXeMay.forms
{
    partial class ProfileControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.btnChangeImg = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbSetting = new System.Windows.Forms.GroupBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lable8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 94);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.buttonSaveImage);
            this.grb1.Controls.Add(this.btnChangeImg);
            this.grb1.Controls.Add(this.lblUserName);
            this.grb1.Controls.Add(this.pictureBox1);
            this.grb1.Dock = System.Windows.Forms.DockStyle.Left;
            this.grb1.Location = new System.Drawing.Point(0, 94);
            this.grb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb1.Size = new System.Drawing.Size(347, 633);
            this.grb1.TabIndex = 2;
            this.grb1.TabStop = false;
            this.grb1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.grb1.Resize += new System.EventHandler(this.groupBox1_Resize);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaveImage.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSaveImage.Location = new System.Drawing.Point(204, 266);
            this.buttonSaveImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(59, 34);
            this.buttonSaveImage.TabIndex = 5;
            this.buttonSaveImage.Text = "Lưu";
            this.buttonSaveImage.UseVisualStyleBackColor = false;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // btnChangeImg
            // 
            this.btnChangeImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeImg.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChangeImg.Location = new System.Drawing.Point(93, 266);
            this.btnChangeImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeImg.Name = "btnChangeImg";
            this.btnChangeImg.Size = new System.Drawing.Size(106, 34);
            this.btnChangeImg.TabIndex = 4;
            this.btnChangeImg.Text = "Chọn ảnh";
            this.btnChangeImg.UseVisualStyleBackColor = false;
            this.btnChangeImg.Click += new System.EventHandler(this.btnChangeImg_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(39, 351);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 24);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(94, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grbSetting
            // 
            this.grbSetting.Controls.Add(this.txtPassWord);
            this.grbSetting.Controls.Add(this.txtDateOfBirth);
            this.grbSetting.Controls.Add(this.txtEmail);
            this.grbSetting.Controls.Add(this.txtPhoneNumber);
            this.grbSetting.Controls.Add(this.txtFullName);
            this.grbSetting.Controls.Add(this.btnUpdate);
            this.grbSetting.Controls.Add(this.lable8);
            this.grbSetting.Controls.Add(this.label7);
            this.grbSetting.Controls.Add(this.label5);
            this.grbSetting.Controls.Add(this.label4);
            this.grbSetting.Controls.Add(this.label2);
            this.grbSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSetting.Location = new System.Drawing.Point(359, 94);
            this.grbSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSetting.Name = "grbSetting";
            this.grbSetting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSetting.Size = new System.Drawing.Size(890, 633);
            this.grbSetting.TabIndex = 3;
            this.grbSetting.TabStop = false;
            this.grbSetting.Text = "ACCOUNT SETTINGS";
            this.grbSetting.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(22, 347);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(230, 28);
            this.txtPassWord.TabIndex = 16;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(294, 347);
            this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(323, 28);
            this.txtDateOfBirth.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(294, 241);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 28);
            this.txtEmail.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(21, 241);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(231, 28);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(21, 134);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(417, 28);
            this.txtFullName.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.Location = new System.Drawing.Point(21, 528);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 49);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Location = new System.Drawing.Point(18, 298);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(104, 24);
            this.lable8.TabIndex = 7;
            this.lable8.Text = "PassWord";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "FullName";
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.grbSetting);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(1249, 727);
            this.Load += new System.EventHandler(this.ProfileControl_Load);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbSetting.ResumeLayout(false);
            this.grbSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbSetting;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnChangeImg;
        private System.Windows.Forms.Button buttonSaveImage;
    }
}
