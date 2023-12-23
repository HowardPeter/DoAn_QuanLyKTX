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
    public partial class FrmPhongKTX : Form, ICondition
    {
        QuanLyKyTucXaEntities3 db = new QuanLyKyTucXaEntities3();
        List<PHONGKYTUC> dsphong = new List<PHONGKYTUC>();
        List<QUANLY> quanly = new List<QUANLY>();
        List<SINHVIEN> dsSinhVien = new List<SINHVIEN>();
        List<TRANGTHIETBI> dsTrangThietBi = new List<TRANGTHIETBI>();
        PHONGKYTUC phong = null;
        public FrmPhongKTX()
        {
            InitializeComponent();

            this.KeyPreview = true;
            
        }
        private void FrmPhongKTX_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                LoadData(dsphong);
            }
        }
        private void FrmPhongKTX_Load(object sender, EventArgs e)
        {
            this.Location = new Point(487, 170);

            dsphong = db.PHONGKYTUCs.ToList();
            quanly = db.QUANLies.ToList();
            dsSinhVien = db.SINHVIENs.ToList();
            dsTrangThietBi = db.TRANGTHIETBIs.ToList();
            cBMaQL.DataSource = quanly;
            cBSearch.SelectedIndex = 0;
            LoadData(dsphong);
            firstLoadData();
        }

        void hideColumn(int c)
        {
            dgvThongTin.Columns[c].Width = 0;
            dgvThongTin.Columns[c].Visible = false;
        }

        void firstLoadData()
        {
            if (dgvThongTin.DataSource == null || dsphong.Count == 0) return;

            DataGridViewRow row = dgvThongTin.CurrentRow;
            int id = row.Index;
            if (id > dsphong.Count - 1) return;
            phong = dsphong[id];
            string maQL = phong.MaQL.ToString();
            int index = cBMaQL.FindString(maQL);

            txtMaPhong.Text = phong.MaPhong;
            cBMaQL.SelectedIndex = index;
            if (phong.TinhTrangPhong == "Còn trống")
            {
                rBEmpty.Checked = true;
            }
            else
            {
                rBFull.Checked = true;
            }
            txtSoGiuong.Text = phong.SoGiuong + "";
            txtSoSV.Text = phong.SoSV + "";
        }
        void LoadData(List<PHONGKYTUC> phong)
        {
            if (phong.Count == 0) return;

            dgvThongTin.DataSource = null;
            dgvThongTin.DataSource = phong;
            SetSoSVvaTT(phong);
            hideColumn(5);
            hideColumn(6);
            hideColumn(7);
        }
        private int GetSoSV(string maPhong)
        {
            int count = dsSinhVien.Count(s => s.MaPhong == maPhong);
            return count;
        }
        //Set số lượng SV ở mỗi phòng ở SINHVIEN = số SV PHONGKYTUC
        //Mỗi khi số sinh viên = số giường thì chuyển trạng thái thành "Đầy"
        private void SetSoSVvaTT(List<PHONGKYTUC> phong)
        {
            foreach (PHONGKYTUC p in phong)
            {
                CapNhatPhong(p);
            }
        }
        private void CapNhatPhong(PHONGKYTUC phong)
        {
            phong.SoSV = GetSoSV(phong.MaPhong);

            if (phong.SoSV >= phong.SoGiuong)
            {
                phong.TinhTrangPhong = "Đầy";
            }
            else
            {
                phong.TinhTrangPhong = "Còn trống";
            }

            db.SaveChanges();
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dsphong.Count == 0) return;

            DataGridViewRow row = dgvThongTin.CurrentRow;
            int id = row.Index;
            if (id > dsphong.Count - 1) return;
            phong = dsphong[id];

            txtMaPhong.Text = phong.MaPhong.ToString();
            cBMaQL.Text = phong.MaQL.ToString();
            if (phong.TinhTrangPhong == "Còn trống")
            {
                rBEmpty.Checked = true;
            }
            else if (phong.TinhTrangPhong == "Đầy")
            {
                rBFull.Checked = true;
            }
            txtSoGiuong.Text = phong.SoGiuong.ToString();
            txtSoSV.Text = phong.SoSV.ToString();

            var sVlst = from c in db.SINHVIENs
                        where c.MaPhong == phong.MaPhong
                        select new
                        {
                            c.MaSV,
                            c.HoTenSV,
                            c.GioiTinh,
                            c.NgaySinh,
                            c.SoDT,
                            c.SoCCCD,
                            c.NgayVao,
                            c.NgayRa,
                            c.MaPhong,
                            c.TienCoc,
                            c.NgayCoc
                        };
            dgvSinhVien.DataSource = sVlst.ToList();
        }

        //ràng buộc số giường phải <= 6
        public bool CheckDieuKienSQL()
        {
            int soGiuong = int.Parse(txtSoGiuong.Text);
            return soGiuong <= 6;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            phong = new PHONGKYTUC();

            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || string.IsNullOrWhiteSpace(txtSoGiuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            List<PHONGKYTUC> mpt = dsphong.Where(a => a.MaPhong == txtMaPhong.Text).ToList();
            if (mpt.Count > 0)
            {
                MessageBox.Show("Mã phòng bị trùng!");
                return;
            }
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("1 phòng không thể chứa hơn 6 giường!");
                return;
            }
            string maQL = cBMaQL.SelectedItem.ToString();

            phong.MaPhong = txtMaPhong.Text;
            phong.MaQL = int.Parse(maQL);
            phong.SoGiuong = int.Parse(txtSoGiuong.Text);
            phong.SoSV = 0;
            phong.TinhTrangPhong = "Còn trống";
            dsphong.Add(phong);
            db.PHONGKYTUCs.Add(phong);
            db.SaveChanges();

            txtMaPhong.Text = "";
            cBMaQL.Text = "";
            txtSoGiuong.Text = "";
            txtSoSV.Text = "";
            rBEmpty.Checked = false;
            rBFull.Checked = false;
            LoadData(dsphong);
            MessageBox.Show("Thêm thông tin phòng thành công.");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dsphong.Count == 0 || dsphong == null) return;

            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || string.IsNullOrWhiteSpace(txtSoGiuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("1 phòng không thể chứa hơn 6 giường!");
                return;
            }
            string maQL = cBMaQL.SelectedItem.ToString();

            phong.SoGiuong = int.Parse(txtSoGiuong.Text);
            phong.MaQL = int.Parse(maQL);
            db.SaveChanges();
            LoadData(dsphong);
            MessageBox.Show("Cập nhật thông tin phòng thành công.");
        }
        private string maphongValue()
        {
            DataGridViewRow row = dgvThongTin.CurrentRow;
            object n = row.Cells["MaPhong"].Value;
            string maphong = Convert.ToString(n);
            return maphong;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dsphong.Count == 0 || dsphong == null) return;

            phong = dsphong.Where(p => p.MaPhong == maphongValue()).SingleOrDefault();

            // Kiểm tra xem có SV nào sử dụng MaPhong này không
            if (dsSinhVien.Any(sv => sv.MaPhong == maphongValue()))
            {
                MessageBox.Show("Không thể xóa phòng đang có sinh viên đang ở!");
                return;
            }
            if (dsTrangThietBi.Any(tb => tb.MaPhong == maphongValue()))
            {
                MessageBox.Show("Không thể xóa phòng có chứa các trang thiết bị!");
                return;
            }

            dsphong.Remove(phong);
            db.PHONGKYTUCs.Remove(phong);
            LoadData(dsphong);
            db.SaveChanges();
            MessageBox.Show("Xóa phòng thành công.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<PHONGKYTUC> searchList = null;

            if (txtSearch.Text == "" && cBMenuSearch.SelectedIndex != 2)
            {
                LoadData(dsphong);
                return;
            }
            if (cBMenuSearch.SelectedIndex == 0)
            {
                searchList = dsphong.Where(s => s.MaPhong.Contains(txtSearch.Text)).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 1)
            {
                searchList = dsphong.Where(s => s.SoGiuong == int.Parse(txtSearch.Text)).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 2)
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
                searchList = dsphong.Where(s => s.TinhTrangPhong == selectedItem).ToList();
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
            if (dsphong.Count == 0 || dsphong == null) return;

            LoadData(dsphong);
        }
    }
}
