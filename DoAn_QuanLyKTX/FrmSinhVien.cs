using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKTX
{
    public partial class FrmSinhVien : Form, ICondition
    {
        QuanLyKyTucXaEntities4 db = new QuanLyKyTucXaEntities4();
        List<SINHVIEN> dsSV = new List<SINHVIEN>();
        List<PHONGKYTUC> dsphong = new List<PHONGKYTUC>();
        SINHVIEN sinhvien = null;
        PHONGKYTUC phong = null;
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            this.Location = new Point(487, 170);

            dsSV = db.SINHVIENs.ToList();

            dsphong = db.PHONGKYTUCs.ToList();
            cBMaPhong.DataSource = dsphong;
            cBSearch.DataSource = dsphong;
            LoadData(dsSV);
            firstLoadData();
        }
        void firstLoadData()
        {
            if (dgvThongTin.DataSource == null || dsSV.Count == 0) return;

            DataGridViewRow row = dgvThongTin.CurrentRow;
            int id = row.Index;
            if (id > dsSV.Count - 1) return;
            sinhvien = dsSV[id];

            txtMaSV.Text = sinhvien.MaSV.ToString();
            txtHoTen.Text = sinhvien.HoTenSV;
            txtSoCCCD.Text = sinhvien.SoCCCD;
            txtSoDT.Text = sinhvien.SoDT;
            txtTienCoc.Text = sinhvien.TienCoc.ToString();
            if (sinhvien.GioiTinh == "Nam")
            {
                rBGTNam.Checked = true;
            }
            else { rBGTNu.Checked = true; }
            string maPhong = sinhvien.MaPhong;
            int cbMaPhongID = cBMaPhong.FindString(maPhong);
            cBMaPhong.SelectedIndex = cbMaPhongID;
            dtPNgaySinh.Value = sinhvien.NgaySinh.Value;
            dtPNgayVao.Value = sinhvien.NgayVao;
            dtPNgayRa.Value = sinhvien.NgayRa.Value;
            dtPNgayCoc.Value = sinhvien.NgayCoc.Value;
        }
        void hideColumn(int c)
        {
            dgvThongTin.Columns[c].Width = 0;
            dgvThongTin.Columns[c].Visible = false;
        }
        void LoadData(List<SINHVIEN> sV)
        {
            if(sV.Count == 0) return;

            dgvThongTin.DataSource = null;
            dgvThongTin.DataSource = sV;

            hideColumn(11);
            hideColumn(12);
            hideColumn(13);
            hideColumn(14);
        }
        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dsSV.Count == 0) return;

            DataGridViewRow row = dgvThongTin.CurrentRow;
            int id = row.Index;
            if (id > dsSV.Count - 1) return;
            sinhvien = dsSV[id];

            txtMaSV.Text = sinhvien.MaSV.ToString();
            txtHoTen.Text = sinhvien.HoTenSV.ToString();
            if (sinhvien.GioiTinh == "Nam")
            {
                rBGTNam.Checked = true;
            }
            else if (sinhvien.GioiTinh == "Nữ")
            {
                rBGTNu.Checked = true;
            }
            dtPNgaySinh.Value = sinhvien.NgaySinh.Value;
            txtSoDT.Text = sinhvien.SoDT.ToString();
            txtSoCCCD.Text = sinhvien.SoCCCD.ToString();
            dtPNgayVao.Value = sinhvien.NgayVao;
            dtPNgayRa.Value = sinhvien.NgayRa != null ? sinhvien.NgayRa.Value : DateTime.Now;
            cBMaPhong.Text = sinhvien.MaPhong.ToString();
            txtTienCoc.Text = sinhvien.TienCoc.ToString();
            dtPNgayCoc.Value = sinhvien.NgayCoc.Value;
        }
        private int maSvValue()
        {
            DataGridViewRow row = dgvThongTin.CurrentRow;
            object n = row.Cells["MaSV"].Value;
            int maSvValue = Convert.ToInt32(n);
            return maSvValue;
        }

        //Kiểm tra ngày ra phải lớn hơn ngày vào
        public bool CheckDieuKienSQL()
        {
            return dtPNgayRa.Value > dtPNgayVao.Value;
        }

        //Kiểm tra phòng còn trống hay không
        private bool CheckTinhTrangPhong()
        {
            string maPhong = cBMaPhong.SelectedItem.ToString();
            phong = db.PHONGKYTUCs.SingleOrDefault(p => p.MaPhong == maPhong);

            return phong.TinhTrangPhong == "Còn trống";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SINHVIEN t = new SINHVIEN();
            // kiem tra tinh hop le cua du lieu
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text)
                || string.IsNullOrWhiteSpace(txtSoDT.Text) || string.IsNullOrWhiteSpace(txtTienCoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            List<SINHVIEN> lstcccd = dsSV.Where(c => c.SoCCCD == txtSoCCCD.Text).ToList();
            if (txtSoCCCD.TextLength != 12 || lstcccd.Count > 0)
            {
                MessageBox.Show("Số CCCD không hợp lệ!");
                return;
            }

            // kiem tra xem lai can them da co chưa
            int masv = int.Parse(txtMaSV.Text);
            string sđt = txtSoDT.Text;
            string cccd = txtSoCCCD.Text;
            List<SINHVIEN> lsv = dsSV.Where(a => a.MaSV == masv).ToList();
            if (lsv.Count > 0)
            {
                MessageBox.Show("Mã sinh viên bị trùng!");
                return;
            }
            List<SINHVIEN> nsv = dsSV.Where(a => a.SoCCCD == cccd).ToList();
            if (nsv.Count > 0)
            {
                MessageBox.Show("Số căn cước bị trùng!");
                return;
            }
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Ngày ra không thể nhỏ hơn ngày vào!");
                return;
            }
            if (!CheckTinhTrangPhong())
            {
                MessageBox.Show("Phòng đã đầy! Hãy chuyển sinh viên qua phòng khác.");
                return;
            }

            t.MaSV = int.Parse(txtMaSV.Text);
            t.HoTenSV = txtHoTen.Text;
            if (rBGTNam.Checked == true)
            {
                t.GioiTinh = "Nam";
            }
            else
            {
                t.GioiTinh = "Nữ";
            }
            t.NgaySinh = dtPNgaySinh.Value;
            t.SoDT = txtSoDT.Text;
            t.SoCCCD = txtSoCCCD.Text;
            t.NgayVao = dtPNgayVao.Value;
            t.NgayRa = dtPNgayRa.Value;
            t.MaPhong = cBMaPhong.Text;
            t.TienCoc = decimal.Parse(txtTienCoc.Text);
            t.NgayCoc = dtPNgayCoc.Value;

            dsSV.Add(t);
            db.SINHVIENs.Add(t);
            db.SaveChanges();

            txtMaSV.Text = "";
            txtHoTen.Text = "";
            txtSoCCCD.Text = "";
            txtSoDT.Text = "";
            txtTienCoc.Text = "";
            rBGTNam.Checked = false;
            rBGTNu.Checked = false;
            cBMaPhong.Text = "";
            dtPNgaySinh.Value = DateTime.Now;
            dtPNgayVao.Value = DateTime.Now;
            dtPNgayRa.Value = DateTime.Now;
            dtPNgayCoc.Value = DateTime.Now;

            LoadData(dsSV);
            MessageBox.Show("Thêm thông tin sinh viên thành công!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dsSV.Count == 0 || dsSV == null) return;

            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text)
                || string.IsNullOrWhiteSpace(txtSoDT.Text) || string.IsNullOrWhiteSpace(txtTienCoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (txtSoCCCD.TextLength != 12)
            {
                MessageBox.Show("Số CCCD không hợp lệ!");
                return;
            }
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Ngày ra không thể nhỏ hơn ngày vào!");
                return;
            }
            if (!CheckTinhTrangPhong())
            {
                MessageBox.Show("Phòng đã đầy! Hãy chuyển sinh viên qua phòng khác.");
                return;
            }
            sinhvien.HoTenSV = txtHoTen.Text;
            if (rBGTNam.Checked == true)
            {
                sinhvien.GioiTinh = "Nam";
            }
            else
            {
                sinhvien.GioiTinh = "Nữ";
            }
            sinhvien.NgaySinh = dtPNgaySinh.Value;
            sinhvien.SoDT = txtSoDT.Text;
            sinhvien.SoCCCD = txtSoCCCD.Text;
            sinhvien.NgayVao = dtPNgayVao.Value;
            sinhvien.NgayRa = dtPNgayRa.Value;
            sinhvien.MaPhong = cBMaPhong.Text;
            sinhvien.TienCoc = decimal.Parse(txtTienCoc.Text);
            sinhvien.NgayCoc = dtPNgayCoc.Value;
            LoadData(dsSV);
            db.SaveChanges();
            MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
        }

        //kiểm tra sinh viên có là khóa ngoại của bảng dữ liệu khác hay không
        private bool CheckForeignKeyData(int maSV)
        {
            var bangDDK = db.DONDANGKies.Any(c => c.MaSV == maSV);
            var bangNT = db.NGUOITHANs.Any(c => c.MaSV == maSV);
            var bangPKTX = db.PHIKTXes.Any(c => c.MaSV == maSV);
            return bangDDK || bangNT || bangPKTX;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dsSV.Count == 0 || dsSV == null) return;

            if (CheckForeignKeyData(sinhvien.MaSV))
            {
                MessageBox.Show("Sinh viên đang có dữ liệu ở nơi khác! Không thể xóa.");
                return;
            }

            sinhvien = dsSV.Where(p => p.MaSV == maSvValue()).SingleOrDefault();
            dsSV.Remove(sinhvien);
            db.SINHVIENs.Remove(sinhvien);
            db.SaveChanges();
            LoadData(dsSV);
            sinhvien = null;
            MessageBox.Show("Xóa thông tin sinh viên thành công.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<SINHVIEN> searchList = null;

            if (txtSearch.Text == "" && cBMenuSearch.SelectedIndex != 4)
            {
                LoadData(dsSV);
                return;
            }
            if (cBMenuSearch.SelectedIndex == 0)
            {
                searchList = dsSV.Where(s => s.MaSV == int.Parse(txtSearch.Text)).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 1)
            {
                searchList = dsSV.Where(s => s.HoTenSV.Contains(txtSearch.Text)).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 2)
            {
                searchList = dsSV.Where(s => s.SoDT == txtSearch.Text).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 3)
            {
                searchList = dsSV.Where(s => s.SoCCCD == txtSearch.Text).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 4)
            {
                string selectedItem = null;
                if (string.IsNullOrEmpty(selectedItem))
                {
                    selectedItem = cBSearch.Text;
                }
                else
                {
                    selectedItem = cBSearch.SelectedItem.ToString();
                }
                searchList = dsSV.Where(s => s.MaPhong == selectedItem).ToList();
            }
            LoadData(searchList);
        }

        private void cBMenuSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBMenuSearch.SelectedIndex == 4)
            {
                txtSearch.Visible = false;
                cBSearch.Visible = true;
            }
            else
            {
                txtSearch.Visible = true;
                cBSearch.Visible = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dsSV.Count == 0 || dsSV == null) return;

            LoadData(dsSV);
        }
    }
}
