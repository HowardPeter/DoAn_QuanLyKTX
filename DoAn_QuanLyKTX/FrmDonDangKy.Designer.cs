namespace DoAn_QuanLyKTX
{
    partial class FrmDonDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonDangKy));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cBMenuSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cBSearch = new System.Windows.Forms.ComboBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtPNgayNop = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(22, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 243);
            this.panel3.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.cBMenuSearch);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cBSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 236);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm thông tin";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(267, 168);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 45);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(23, 103);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(366, 45);
            this.txtSearch.TabIndex = 13;
            // 
            // cBMenuSearch
            // 
            this.cBMenuSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMenuSearch.FormattingEnabled = true;
            this.cBMenuSearch.Items.AddRange(new object[] {
            "Mã đơn",
            "Mã sinh viên",
            "Tình trạng"});
            this.cBMenuSearch.Location = new System.Drawing.Point(208, 46);
            this.cBMenuSearch.Name = "cBMenuSearch";
            this.cBMenuSearch.Size = new System.Drawing.Size(179, 37);
            this.cBMenuSearch.TabIndex = 4;
            this.cBMenuSearch.SelectedIndexChanged += new System.EventHandler(this.cBMenuSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::DoAn_QuanLyKTX.Properties.Resources.icons8_search_48__Custom_;
            this.btnSearch.Location = new System.Drawing.Point(115, 167);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm theo:";
            // 
            // cBSearch
            // 
            this.cBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSearch.FormattingEnabled = true;
            this.cBSearch.Items.AddRange(new object[] {
            "Chấp nhận",
            "Từ chối",
            "Chờ phê duyệt"});
            this.cBSearch.Location = new System.Drawing.Point(22, 103);
            this.cBSearch.Name = "cBSearch";
            this.cBSearch.Size = new System.Drawing.Size(366, 37);
            this.cBSearch.TabIndex = 20;
            this.cBSearch.Visible = false;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(107, 178);
            this.txtMaSV.Multiline = true;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(310, 39);
            this.txtMaSV.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày nộp";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Location = new System.Drawing.Point(22, 366);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 351);
            this.panel4.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(409, 345);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cập nhật";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::DoAn_QuanLyKTX.Properties.Resources.icons8_delete_48__Custom___Custom_;
            this.btnDelete.Location = new System.Drawing.Point(22, 251);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(367, 67);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::DoAn_QuanLyKTX.Properties.Resources.icons8_update_48__Custom___Custom_;
            this.btnUpdate.Location = new System.Drawing.Point(22, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(367, 67);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(21, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(367, 67);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtPNgayNop
            // 
            this.dtPNgayNop.CustomFormat = "dd/MM/yyyy";
            this.dtPNgayNop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPNgayNop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPNgayNop.Location = new System.Drawing.Point(107, 312);
            this.dtPNgayNop.Name = "dtPNgayNop";
            this.dtPNgayNop.Size = new System.Drawing.Size(310, 39);
            this.dtPNgayNop.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "ĐƠN ĐĂNG KÝ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBTinhTrang);
            this.groupBox2.Controls.Add(this.txtMaDon);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtPNgayNop);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1004, 429);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // cBTinhTrang
            // 
            this.cBTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTinhTrang.FormattingEnabled = true;
            this.cBTinhTrang.Items.AddRange(new object[] {
            "Chấp nhận",
            "Từ chối",
            "Chờ phê duyệt"});
            this.cBTinhTrang.Location = new System.Drawing.Point(599, 177);
            this.cBTinhTrang.Name = "cBTinhTrang";
            this.cBTinhTrang.Size = new System.Drawing.Size(310, 37);
            this.cBTinhTrang.TabIndex = 13;
            // 
            // txtMaDon
            // 
            this.txtMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDon.ForeColor = System.Drawing.Color.Black;
            this.txtMaDon.Location = new System.Drawing.Point(177, 54);
            this.txtMaDon.Multiline = true;
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.ReadOnly = true;
            this.txtMaDon.Size = new System.Drawing.Size(92, 39);
            this.txtMaDon.TabIndex = 12;
            this.txtMaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(455, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 435);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dgvSinhVien);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgvThongTin);
            this.panel2.Location = new System.Drawing.Point(455, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 526);
            this.panel2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(335, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Thông tin sinh viên nộp đơn";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(2, 373);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.RowTemplate.Height = 28;
            this.dgvSinhVien.Size = new System.Drawing.Size(1004, 148);
            this.dgvSinhVien.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Danh sách đơn đăng ký";
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Location = new System.Drawing.Point(3, 50);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 62;
            this.dgvThongTin.RowTemplate.Height = 28;
            this.dgvThongTin.Size = new System.Drawing.Size(1004, 262);
            this.dgvThongTin.TabIndex = 1;
            this.dgvThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::DoAn_QuanLyKTX.Properties.Resources.icons8_exit_52__Custom___Custom_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1415, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmDonDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1487, 1098);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDonDangKy";
            this.Text = "FrmDonDangKy";
            this.Load += new System.EventHandler(this.FrmDonDangKy_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtPNgayNop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBMenuSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.ComboBox cBSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cBTinhTrang;
        private System.Windows.Forms.Button btnRefresh;
    }
}