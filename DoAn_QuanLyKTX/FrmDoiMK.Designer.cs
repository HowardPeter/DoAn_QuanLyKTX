namespace DoAn_QuanLyKTX
{
    partial class FrmDoiMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cBoxHienMK = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(127, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCu.Location = new System.Drawing.Point(133, 146);
            this.txtMKCu.Multiline = true;
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(567, 46);
            this.txtMKCu.TabIndex = 2;
            this.txtMKCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKCu_KeyPress);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMoi.Location = new System.Drawing.Point(133, 261);
            this.txtMKMoi.Multiline = true;
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(567, 46);
            this.txtMKMoi.TabIndex = 4;
            this.txtMKMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKMoi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(127, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMK.Location = new System.Drawing.Point(133, 376);
            this.txtXacNhanMK.Multiline = true;
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PasswordChar = '*';
            this.txtXacNhanMK.Size = new System.Drawing.Size(567, 46);
            this.txtXacNhanMK.TabIndex = 6;
            this.txtXacNhanMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXacNhanMK_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(127, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnXacNhan.Location = new System.Drawing.Point(207, 501);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(172, 54);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cBoxHienMK
            // 
            this.cBoxHienMK.AutoSize = true;
            this.cBoxHienMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cBoxHienMK.ForeColor = System.Drawing.Color.White;
            this.cBoxHienMK.Location = new System.Drawing.Point(133, 443);
            this.cBoxHienMK.Name = "cBoxHienMK";
            this.cBoxHienMK.Size = new System.Drawing.Size(191, 33);
            this.cBoxHienMK.TabIndex = 8;
            this.cBoxHienMK.Text = "Hiện mật khẩu";
            this.cBoxHienMK.UseVisualStyleBackColor = true;
            this.cBoxHienMK.CheckedChanged += new System.EventHandler(this.cBoxHienMK_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(420, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 54);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(167)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(835, 596);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cBoxHienMK);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDoiMK";
            this.Load += new System.EventHandler(this.FrmDoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.CheckBox cBoxHienMK;
        private System.Windows.Forms.Button btnExit;
    }
}