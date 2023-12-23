namespace DoAn_QuanLyKTX
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoTK = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.cBoxMatKhau = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(202, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 522);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoTK);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.cBoxMatKhau);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenDN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(104)))), ((int)(((byte)(174)))));
            this.btnTaoTK.AutoSize = true;
            this.btnTaoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoTK.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnTaoTK.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(104)))), ((int)(((byte)(174)))));
            this.btnTaoTK.Location = new System.Drawing.Point(359, 471);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(234, 29);
            this.btnTaoTK.TabIndex = 8;
            this.btnTaoTK.TabStop = true;
            this.btnTaoTK.Text = "Tạo tài khoản mới?\r\n";
            this.btnTaoTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTaoTK.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnTaoTK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnTaoTK_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(350, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(218, 58);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cBoxMatKhau
            // 
            this.cBoxMatKhau.AutoSize = true;
            this.cBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cBoxMatKhau.ForeColor = System.Drawing.Color.White;
            this.cBoxMatKhau.Location = new System.Drawing.Point(73, 324);
            this.cBoxMatKhau.Name = "cBoxMatKhau";
            this.cBoxMatKhau.Size = new System.Drawing.Size(191, 33);
            this.cBoxMatKhau.TabIndex = 6;
            this.cBoxMatKhau.Text = "Hiện mật khẩu";
            this.cBoxMatKhau.UseVisualStyleBackColor = true;
            this.cBoxMatKhau.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(95, 383);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(218, 58);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMatKhau.Location = new System.Drawing.Point(73, 255);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(520, 54);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMK_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTenDN.Location = new System.Drawing.Point(73, 140);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(520, 54);
            this.txtTenDN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(767, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "CHƯƠNG TRÌNH QUẢN LÝ KÝ TÚC XÁ";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(167)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(1105, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBoxMatKhau;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel btnTaoTK;
    }
}

