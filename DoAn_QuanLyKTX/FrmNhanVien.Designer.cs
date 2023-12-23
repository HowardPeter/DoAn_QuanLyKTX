namespace DoAn_QuanLyKTX
{
    partial class FrmNhanVien
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cBMenuSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cBSearch = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBCongViec = new System.Windows.Forms.ComboBox();
            this.txtLuongThang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtPNgayVLNV = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.rBGTNu = new System.Windows.Forms.RadioButton();
            this.rBGTNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Thông tin nhân viên";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgvThongTin);
            this.panel2.Location = new System.Drawing.Point(455, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 525);
            this.panel2.TabIndex = 23;
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Location = new System.Drawing.Point(3, 66);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 62;
            this.dgvThongTin.RowTemplate.Height = 28;
            this.dgvThongTin.Size = new System.Drawing.Size(1004, 456);
            this.dgvThongTin.TabIndex = 0;
            this.dgvThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Location = new System.Drawing.Point(22, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 351);
            this.panel4.TabIndex = 24;
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
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::DoAn_QuanLyKTX.Properties.Resources.icons8_delete_48__Custom___Custom_;
            this.btnDelete.Location = new System.Drawing.Point(21, 246);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(367, 67);
            this.btnDelete.TabIndex = 6;
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
            this.btnUpdate.Location = new System.Drawing.Point(21, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(367, 67);
            this.btnUpdate.TabIndex = 5;
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
            this.btnAdd.Image = global::DoAn_QuanLyKTX.Properties.Resources.icons8_add_properties_48__Custom___Custom_;
            this.btnAdd.Location = new System.Drawing.Point(20, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(367, 67);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 46);
            this.label2.TabIndex = 20;
            this.label2.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // cBMenuSearch
            // 
            this.cBMenuSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMenuSearch.FormattingEnabled = true;
            this.cBMenuSearch.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Họ tên",
            "Công việc"});
            this.cBMenuSearch.Location = new System.Drawing.Point(208, 46);
            this.cBMenuSearch.Name = "cBMenuSearch";
            this.cBMenuSearch.Size = new System.Drawing.Size(179, 37);
            this.cBMenuSearch.TabIndex = 4;
            this.cBMenuSearch.SelectedIndexChanged += new System.EventHandler(this.cBMenuSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSearch.Location = new System.Drawing.Point(23, 106);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(366, 45);
            this.txtSearch.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.cBMenuSearch);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.cBSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 236);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm thông tin";
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
            this.btnSearch.Location = new System.Drawing.Point(119, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cBSearch
            // 
            this.cBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSearch.FormattingEnabled = true;
            this.cBSearch.Items.AddRange(new object[] {
            "Nhân viên tạp vụ",
            "Nhân viên an ninh",
            "Nhân viên kỹ thuật",
            "Nhân viên y tế"});
            this.cBSearch.Location = new System.Drawing.Point(23, 107);
            this.cBSearch.Name = "cBSearch";
            this.cBSearch.Size = new System.Drawing.Size(365, 44);
            this.cBSearch.TabIndex = 19;
            this.cBSearch.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(455, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 435);
            this.panel1.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cBCongViec);
            this.groupBox2.Controls.Add(this.txtLuongThang);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtPNgayVLNV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtPNgaySinhNV);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.rBGTNu);
            this.groupBox2.Controls.Add(this.rBGTNam);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtHoTenNV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1004, 432);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(564, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "Công việc";
            // 
            // cBCongViec
            // 
            this.cBCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCongViec.FormattingEnabled = true;
            this.cBCongViec.Items.AddRange(new object[] {
            "Nhân viên tạp vụ",
            "Nhân viên an ninh",
            "Nhân viên kỹ thuật",
            "Nhân viên y tế"});
            this.cBCongViec.Location = new System.Drawing.Point(740, 246);
            this.cBCongViec.Name = "cBCongViec";
            this.cBCongViec.Size = new System.Drawing.Size(221, 37);
            this.cBCongViec.TabIndex = 33;
            // 
            // txtLuongThang
            // 
            this.txtLuongThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongThang.Location = new System.Drawing.Point(740, 79);
            this.txtLuongThang.Multiline = true;
            this.txtLuongThang.Name = "txtLuongThang";
            this.txtLuongThang.Size = new System.Drawing.Size(221, 39);
            this.txtLuongThang.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 29);
            this.label8.TabIndex = 31;
            this.label8.Text = "Lương tháng";
            // 
            // dtPNgayVLNV
            // 
            this.dtPNgayVLNV.CustomFormat = "dd/MM/yyyy";
            this.dtPNgayVLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPNgayVLNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPNgayVLNV.Location = new System.Drawing.Point(740, 166);
            this.dtPNgayVLNV.Name = "dtPNgayVLNV";
            this.dtPNgayVLNV.Size = new System.Drawing.Size(221, 35);
            this.dtPNgayVLNV.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ngày vào làm";
            // 
            // dtPNgaySinhNV
            // 
            this.dtPNgaySinhNV.CustomFormat = "dd/MM/yyyy";
            this.dtPNgaySinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPNgaySinhNV.Location = new System.Drawing.Point(234, 324);
            this.dtPNgaySinhNV.Name = "dtPNgaySinhNV";
            this.dtPNgaySinhNV.Size = new System.Drawing.Size(221, 35);
            this.dtPNgaySinhNV.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 29);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ngày sinh";
            // 
            // rBGTNu
            // 
            this.rBGTNu.AutoSize = true;
            this.rBGTNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBGTNu.Location = new System.Drawing.Point(369, 249);
            this.rBGTNu.Name = "rBGTNu";
            this.rBGTNu.Size = new System.Drawing.Size(67, 30);
            this.rBGTNu.TabIndex = 19;
            this.rBGTNu.TabStop = true;
            this.rBGTNu.Text = "Nữ";
            this.rBGTNu.UseVisualStyleBackColor = true;
            // 
            // rBGTNam
            // 
            this.rBGTNam.AutoSize = true;
            this.rBGTNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBGTNam.Location = new System.Drawing.Point(234, 247);
            this.rBGTNam.Name = "rBGTNam";
            this.rBGTNam.Size = new System.Drawing.Size(87, 30);
            this.rBGTNam.TabIndex = 18;
            this.rBGTNam.TabStop = true;
            this.rBGTNam.Text = "Nam";
            this.rBGTNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giới tính";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNV.Location = new System.Drawing.Point(234, 161);
            this.txtHoTenNV.Multiline = true;
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(221, 39);
            this.txtHoTenNV.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ tên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(234, 79);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(221, 39);
            this.txtMaNV.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã nhân viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(22, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 243);
            this.panel3.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::DoAn_QuanLyKTX.Properties.Resources.icons8_exit_52__Custom_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1415, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 19;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(267, 171);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 45);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1487, 1098);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBMenuSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtPNgayVLNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPNgaySinhNV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rBGTNu;
        private System.Windows.Forms.RadioButton rBGTNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLuongThang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBCongViec;
        private System.Windows.Forms.ComboBox cBSearch;
        private System.Windows.Forms.Button btnRefresh;
    }
}