namespace DoAn_QuanLyKTX
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.LinkLabel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.btnThietBi = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnBienLai = new System.Windows.Forms.Button();
            this.btnNguoiThan = new System.Windows.Forms.Button();
            this.btnTTSV = new System.Windows.Forms.Button();
            this.btnDonDangKy = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(121)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.btnNhanVien);
            this.panel2.Controls.Add(this.btnDoiMK);
            this.panel2.Controls.Add(this.btnQuanLy);
            this.panel2.Controls.Add(this.btnThietBi);
            this.panel2.Controls.Add(this.btnPhong);
            this.panel2.Controls.Add(this.btnBienLai);
            this.panel2.Controls.Add(this.btnNguoiThan);
            this.panel2.Controls.Add(this.btnTTSV);
            this.panel2.Controls.Add(this.btnDonDangKy);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 1182);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(383, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1583, 1191);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1577, 1188);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ActiveLinkColor = System.Drawing.Color.White;
            this.btnDangXuat.AutoSize = true;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::DoAn_QuanLyKTX.Properties.Resources.icons8_logout_20;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnDangXuat.LinkColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(18, 23);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(156, 29);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.TabStop = true;
            this.btnDangXuat.Text = "    Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDangXuat_LinkClicked);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.Location = new System.Drawing.Point(18, 783);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(349, 79);
            this.btnNhanVien.TabIndex = 9;
            this.btnNhanVien.Text = "Thông Tin Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnDoiMK.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.Image")));
            this.btnDoiMK.Location = new System.Drawing.Point(18, 992);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(349, 79);
            this.btnDoiMK.TabIndex = 7;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.Color.White;
            this.btnQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLy.Image")));
            this.btnQuanLy.Location = new System.Drawing.Point(18, 887);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(349, 79);
            this.btnQuanLy.TabIndex = 6;
            this.btnQuanLy.Text = "Thông Tin Quản Lý";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnThietBi
            // 
            this.btnThietBi.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietBi.ForeColor = System.Drawing.Color.White;
            this.btnThietBi.Image = ((System.Drawing.Image)(resources.GetObject("btnThietBi.Image")));
            this.btnThietBi.Location = new System.Drawing.Point(18, 681);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(349, 79);
            this.btnThietBi.TabIndex = 5;
            this.btnThietBi.Text = "Trang Thiết Bị";
            this.btnThietBi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThietBi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThietBi.UseVisualStyleBackColor = true;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.Color.White;
            this.btnPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnPhong.Image")));
            this.btnPhong.Location = new System.Drawing.Point(18, 579);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(349, 79);
            this.btnPhong.TabIndex = 4;
            this.btnPhong.Text = "Thông Tin Phòng";
            this.btnPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnBienLai
            // 
            this.btnBienLai.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBienLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBienLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBienLai.ForeColor = System.Drawing.Color.White;
            this.btnBienLai.Image = ((System.Drawing.Image)(resources.GetObject("btnBienLai.Image")));
            this.btnBienLai.Location = new System.Drawing.Point(18, 474);
            this.btnBienLai.Name = "btnBienLai";
            this.btnBienLai.Size = new System.Drawing.Size(349, 79);
            this.btnBienLai.TabIndex = 3;
            this.btnBienLai.Text = "Thông Tin Biên Lai";
            this.btnBienLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBienLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBienLai.UseVisualStyleBackColor = true;
            this.btnBienLai.Click += new System.EventHandler(this.btnBienLai_Click);
            // 
            // btnNguoiThan
            // 
            this.btnNguoiThan.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnNguoiThan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguoiThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguoiThan.ForeColor = System.Drawing.Color.White;
            this.btnNguoiThan.Image = ((System.Drawing.Image)(resources.GetObject("btnNguoiThan.Image")));
            this.btnNguoiThan.Location = new System.Drawing.Point(18, 370);
            this.btnNguoiThan.Name = "btnNguoiThan";
            this.btnNguoiThan.Size = new System.Drawing.Size(349, 79);
            this.btnNguoiThan.TabIndex = 2;
            this.btnNguoiThan.Text = "Thông Tin Người Thân";
            this.btnNguoiThan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNguoiThan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNguoiThan.UseVisualStyleBackColor = true;
            this.btnNguoiThan.Click += new System.EventHandler(this.btnNguoiThan_Click);
            // 
            // btnTTSV
            // 
            this.btnTTSV.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnTTSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTSV.ForeColor = System.Drawing.Color.White;
            this.btnTTSV.Image = ((System.Drawing.Image)(resources.GetObject("btnTTSV.Image")));
            this.btnTTSV.Location = new System.Drawing.Point(18, 268);
            this.btnTTSV.Name = "btnTTSV";
            this.btnTTSV.Size = new System.Drawing.Size(349, 79);
            this.btnTTSV.TabIndex = 1;
            this.btnTTSV.Text = "Thông Tin Sinh Viên";
            this.btnTTSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTTSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTTSV.UseVisualStyleBackColor = true;
            this.btnTTSV.Click += new System.EventHandler(this.btnTTSV_Click);
            // 
            // btnDonDangKy
            // 
            this.btnDonDangKy.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDonDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDonDangKy.Image = ((System.Drawing.Image)(resources.GetObject("btnDonDangKy.Image")));
            this.btnDonDangKy.Location = new System.Drawing.Point(18, 163);
            this.btnDonDangKy.Name = "btnDonDangKy";
            this.btnDonDangKy.Size = new System.Drawing.Size(349, 79);
            this.btnDonDangKy.TabIndex = 0;
            this.btnDonDangKy.Text = "Đơn Đăng Ký";
            this.btnDonDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDonDangKy.UseVisualStyleBackColor = true;
            this.btnDonDangKy.Click += new System.EventHandler(this.btnDonDangKy_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(121)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1960, 1181);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnThietBi;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnBienLai;
        private System.Windows.Forms.Button btnNguoiThan;
        private System.Windows.Forms.Button btnTTSV;
        private System.Windows.Forms.Button btnDonDangKy;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel btnDangXuat;
    }
}