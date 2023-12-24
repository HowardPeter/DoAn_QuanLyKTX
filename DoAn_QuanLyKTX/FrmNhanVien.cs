using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKTX
{
    public partial class FrmNhanVien : Form, ICondition
    {
        QuanLyKyTucXaEntities4 db = new QuanLyKyTucXaEntities4();
        List<NHANVIEN> dsNV = new List<NHANVIEN>();
        NHANVIEN NhVien = null;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            this.Location = new Point(487, 170);

            dsNV = db.NHANVIENs.ToList();

            dgvThongTin.DataSource = dsNV;
            cBSearch.SelectedIndex = 0;
            firstLoadData();
        }
        void displayData(NHANVIEN nv)
        {
            string congViec = nv.CongViec;
            int index = cBCongViec.FindString(congViec);

            txtMaNV.Text = nv.MaNV;
            txtHoTenNV.Text = nv.HoTenNV;
            if (nv.GioiTinh == "Nam")
            {
                rBGTNam.Checked = true;
            }
            else
            {
                rBGTNu.Checked = true;
            }
            dtPNgaySinhNV.Value = nv.NgaySinh.Value;
            txtLuongThang.Text = nv.LuongThang.ToString();
            dtPNgayVLNV.Value = nv.NgayVaoLam.Value;
            cBCongViec.SelectedIndex = index;
        }
        void firstLoadData()
        {
            if (dgvThongTin.DataSource == null || dsNV.Count == 0) return;
            DataGridViewRow row = dgvThongTin.CurrentRow;
            int id = row.Index;
            NhVien = dsNV[id];
            displayData(NhVien);
        }
        void LoadData(List<NHANVIEN> n)
        {
            if (n.Count == 0) return;

            dgvThongTin.DataSource = null;
            dgvThongTin.DataSource = n;
        }
        private string maNVValue()
        {
            DataGridViewRow row = dgvThongTin.CurrentRow;
            object n = row.Cells["MaNV"].Value;
            string maNV = n.ToString();
            return maNV;
        }
        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThongTin.DataSource == null || e.RowIndex < 0 || e.RowIndex > dgvThongTin.RowCount) return;

            NhVien = dsNV.Where(n => n.MaNV == maNVValue()).SingleOrDefault();
            displayData(NhVien);
        }

        //kiểm tra ngày sinh phải < ngày hiện tại và ngày sinh < ngày vào làm <= ngày hiện tại
        public bool CheckDieuKienSQL()
        {
            return dtPNgaySinhNV.Value < DateTime.Now && dtPNgayVLNV.Value > dtPNgaySinhNV.Value && dtPNgayVLNV.Value <= DateTime.Now;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhVien = new NHANVIEN();

            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTenNV.Text)
                || string.IsNullOrWhiteSpace(txtLuongThang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Ngày sinh hoặc ngày vào làm không hợp lệ!");
                return;
            }
            List<NHANVIEN> lst = dsNV.Where(n => n.MaNV == txtMaNV.Text).ToList();
            if (lst.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            NhVien.MaNV = txtMaNV.Text;
            NhVien.HoTenNV = txtHoTenNV.Text;
            if (rBGTNam.Checked == true)
                NhVien.GioiTinh = "Nam";
            else
                NhVien.GioiTinh = "Nữ";
            NhVien.NgaySinh = dtPNgaySinhNV.Value;
            NhVien.LuongThang = decimal.Parse(txtLuongThang.Text);
            NhVien.NgayVaoLam = dtPNgayVLNV.Value;
            NhVien.CongViec = cBCongViec.SelectedItem.ToString();

            dsNV.Add(NhVien);
            db.NHANVIENs.Add(NhVien);
            db.SaveChanges();
            LoadData(dsNV);

            txtMaNV.Text = "";
            txtHoTenNV.Text = "";
            rBGTNam.Checked = true;
            dtPNgaySinhNV.Value = DateTime.Now;
            txtLuongThang.Text = "";
            dtPNgayVLNV.Value = DateTime.Now;
            cBCongViec.SelectedIndex = 0;
            MessageBox.Show("Thêm thông tin nhân viên thành công.");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dsNV.Count == 0) return;

            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTenNV.Text)
                || string.IsNullOrWhiteSpace(txtLuongThang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Ngày sinh hoặc ngày vào làm không hợp lệ!");
                return;
            }

            NhVien.MaNV = txtMaNV.Text;
            NhVien.HoTenNV = txtHoTenNV.Text;
            if (rBGTNam.Checked == true)
                NhVien.GioiTinh = "Nam";
            else
                NhVien.GioiTinh = "Nữ";
            NhVien.NgaySinh = dtPNgaySinhNV.Value;
            NhVien.LuongThang = decimal.Parse(txtLuongThang.Text);
            NhVien.CongViec = cBCongViec.SelectedItem.ToString();

            db.SaveChanges();
            LoadData(dsNV);
            MessageBox.Show("Cập nhật thông tin nhân viên thành công.");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dsNV.Count == 0) return;

            dsNV.Remove(NhVien);
            db.NHANVIENs.Remove(NhVien);
            db.SaveChanges();
            LoadData(dsNV);
            MessageBox.Show("Xóa thông tin nhân viên thành công.");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<NHANVIEN> searchList = null;
            if (string.IsNullOrWhiteSpace(txtSearch.Text) && cBMenuSearch.SelectedIndex != 2)
            {
                LoadData(dsNV);
                return;
            }
            if (cBMenuSearch.SelectedIndex == 0)
            {
                searchList = dsNV.Where(s => s.MaNV == txtSearch.Text).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 1)
            {
                searchList = dsNV.Where(s => s.HoTenNV.Contains(txtSearch.Text)).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 2)
            {
                string searchString = null;
                if (string.IsNullOrEmpty(searchString))
                {
                    searchString = cBSearch.Text;
                }
                else
                {
                    searchString = cBSearch.SelectedItem.ToString();
                }
                searchList = dsNV.Where(s => s.CongViec.Contains(searchString)).ToList();
            }
            LoadData(searchList);
        }
        private void cBMenuSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBMenuSearch.SelectedIndex == 2)
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
            if (dsNV.Count == 0) return;
            LoadData(dsNV);
        }
    }
}
