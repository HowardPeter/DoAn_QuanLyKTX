namespace DoAn_QuanLyKTX
{
    partial class FrmDangKyTaiKhoan
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
            this.btnExit = new System.Windows.Forms.Button();
            this.cBoxHienMK = new System.Windows.Forms.CheckBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaQL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(405, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 54);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cBoxHienMK
            // 
            this.cBoxHienMK.AutoSize = true;
            this.cBoxHienMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cBoxHienMK.ForeColor = System.Drawing.Color.White;
            this.cBoxHienMK.Location = new System.Drawing.Point(314, 454);
            this.cBoxHienMK.Name = "cBoxHienMK";
            this.cBoxHienMK.Size = new System.Drawing.Size(191, 33);
            this.cBoxHienMK.TabIndex = 18;
            this.cBoxHienMK.Text = "Hiện mật khẩu";
            this.cBoxHienMK.UseVisualStyleBackColor = true;
            this.cBoxHienMK.CheckedChanged += new System.EventHandler(this.cBoxHienMK_CheckedChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnXacNhan.Location = new System.Drawing.Point(192, 513);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(172, 54);
            this.btnXacNhan.TabIndex = 17;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMK.Location = new System.Drawing.Point(314, 392);
            this.txtXacNhanMK.Multiline = true;
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PasswordChar = '*';
            this.txtXacNhanMK.Size = new System.Drawing.Size(439, 41);
            this.txtXacNhanMK.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(72, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nhắc lại mật khẩu";
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(314, 303);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(439, 41);
            this.txtMK.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(72, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu";
            // 
            // txtMaQL
            // 
            this.txtMaQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQL.Location = new System.Drawing.Point(314, 121);
            this.txtMaQL.Multiline = true;
            this.txtMaQL.Name = "txtMaQL";
            this.txtMaQL.Size = new System.Drawing.Size(439, 41);
            this.txtMaQL.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(72, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(128, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "TẠO TÀI KHOẢN QUẢN LÝ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(314, 210);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(439, 41);
            this.txtEmail.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(72, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã quản lý của bạn";
            // 
            // FrmDangKyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(167)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(835, 598);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cBoxHienMK);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDangKyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDangKycs";
            this.Load += new System.EventHandler(this.FrmDangKyTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cBoxHienMK;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
    }
}