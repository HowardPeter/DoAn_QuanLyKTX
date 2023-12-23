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
    public partial class FrmPhiKTX : Form, ICondition
    {
        QuanLyKyTucXaEntities3 db = new QuanLyKyTucXaEntities3();
        List<PHIKTX> dsPhiKTX = new List<PHIKTX>();
        List<SINHVIEN> dsSV = new List<SINHVIEN>();
        PHIKTX phiKTX = null;
        public FrmPhiKTX()
        {
            InitializeComponent();
        }

        private void FrmPhiKTX_Load(object sender, EventArgs e)
        {
            this.Location = new Point(487, 170);

            dsPhiKTX = db.PHIKTXes.ToList();
            dsSV = db.SINHVIENs.ToList();
            cBMaSV.DataSource = dsSV;
            cBSearch.DataSource = dsSV;
            LoadData(dsPhiKTX);
            firstLoadData();
        }
        void firstLoadData()
        {
            if (dgvThongTin.DataSource == null || dsPhiKTX.Count == 0) return;

            DataGridViewRow row = dgvThongTin.CurrentRow;
            int id = row.Index;
            if (id > dsPhiKTX.Count - 1) return;
            phiKTX = dsPhiKTX[id];

            txtMaBienLai.Text = phiKTX.MaBienLai;
            cBMaSV.Text = phiKTX.MaSV.ToString();
            dtPNgayDong.Value = phiKTX.NgayDong;
            txtTongTien.Text = phiKTX.TongTien.ToString();
            txtTienDien.Text = phiKTX.TienDien.ToString();
            txtTienGuixe.Text = phiKTX.TienGuiXe.ToString();
            txtTienInternet.Text = phiKTX.TienInternet.ToString();
            txtTienPhong.Text = phiKTX.TienPhong.ToString();
        }
        void LoadData(List<PHIKTX> phiKTXs)
        {
            if (phiKTXs.Count == 0) return;

            dgvThongTin.DataSource = null;
            dgvThongTin.DataSource = phiKTXs;

            dgvThongTin.Columns[8].Width = 0;
            dgvThongTin.Columns[8].Visible = false;
        }
        private string maBienLaiValue()
        {
            DataGridViewRow row = dgvThongTin.CurrentRow;
            object n = row.Cells["MaBienLai"].Value;
            string maBLValue = Convert.ToString(n);
            return maBLValue;
        }
        private void displayCell()
        {
            phiKTX = dsPhiKTX.Where(p => p.MaBienLai == maBienLaiValue()).SingleOrDefault();
            txtMaBienLai.Text = phiKTX.MaBienLai;
            cBMaSV.Text = phiKTX.MaSV.ToString();
            dtPNgayDong.Value = phiKTX.NgayDong;
            txtTongTien.Text = phiKTX.TongTien.ToString();
            txtTienDien.Text = phiKTX.TienDien.ToString();
            txtTienGuixe.Text = phiKTX.TienGuiXe.ToString();
            txtTienInternet.Text = phiKTX.TienInternet.ToString();
            txtTienPhong.Text = phiKTX.TienPhong.ToString();
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvThongTin.RowCount) return;
            displayCell();
        }

        private void TinhTongTienChoPhiKTX(PHIKTX phiKTX)
        {
            if (phiKTX != null)
            {
                // Tính tổng tiền dựa trên các thành phần tương ứng
                decimal tienDien = (decimal)phiKTX.TienDien;
                decimal tienGuiXe = (decimal)phiKTX.TienGuiXe;
                decimal tienInternet = (decimal)phiKTX.TienInternet;
                decimal tienPhong = (decimal)phiKTX.TienPhong;

                decimal tongTien = tienDien + tienGuiXe + tienInternet + tienPhong;

                // Gán giá trị tổng tiền vào thuộc tính của đối tượng PHIKTX
                phiKTX.TongTien = tongTien;

                // Hiển thị tổng tiền lên TextBox
                txtTongTien.Text = tongTien.ToString("{0:N0}");
            }
        }

        private void ResetForm()
        {
            cBMaSV.Text = "";
            dtPNgayDong.Value = DateTime.Now;
            txtTienDien.Text = "";
            txtTienGuixe.Text = "";
            txtTienInternet.Text = "";
            txtTienPhong.Text = "";
            LoadData(dsPhiKTX);
        }

        //Kiểm tra ngày đóng phải nhỏ hơn ngày hiện tại
        public bool CheckDieuKienSQL()
        {
            return dtPNgayDong.Value <= DateTime.Now;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PHIKTX p = new PHIKTX();

            if (string.IsNullOrWhiteSpace(txtMaBienLai.Text) || string.IsNullOrWhiteSpace(txtTienPhong.Text)
                || string.IsNullOrWhiteSpace(txtTienDien.Text) || string.IsNullOrWhiteSpace(txtTienInternet.Text) || string.IsNullOrWhiteSpace(cBMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Ngày đóng không thể lớn hơn ngày hiện tại!");
                return;
            }
            // Lấy mã biên lai lớn nhất
            string maxMaBienLai = dsPhiKTX.Max(a => a.MaBienLai);

            // Tăng giá trị của số trong mã biên lai
            int nextMaBienLaiNumber = 1;
            if (!string.IsNullOrEmpty(maxMaBienLai))
            {
                // Lấy số cuối cùng trong mã biên lai
                string lastNumberPart = maxMaBienLai.Substring(3);

                // Chuyển số cuối cùng sang dạng số nguyên
                if (int.TryParse(lastNumberPart, out int lastNumber))
                {
                    nextMaBienLaiNumber = lastNumber + 1;
                }
            }

            // Tạo mã biên lai mới
            string nextMaBienLai = $"BL{nextMaBienLaiNumber:D3}";
            p.MaBienLai = nextMaBienLai;
            p.MaSV = int.Parse(cBMaSV.Text);
            p.NgayDong = dtPNgayDong.Value;

            if (decimal.Parse(txtTienPhong.Text) > 0)
            {
                p.TienPhong = decimal.Parse(txtTienPhong.Text);
            }
            if (decimal.Parse(txtTienDien.Text) > 0)
            {
                p.TienDien = decimal.Parse(txtTienDien.Text);
            }
            if (decimal.Parse(txtTienInternet.Text) > 0)
            {
                p.TienInternet = decimal.Parse(txtTienInternet.Text);
            }
            if (decimal.Parse(txtTienGuixe.Text) >= 0)
            {
                if (string.IsNullOrWhiteSpace(txtTienGuixe.Text))
                {
                    p.TienGuiXe = 0;
                }
                else
                {
                    p.TienGuiXe = decimal.Parse(txtTienGuixe.Text);
                }
            }
            TinhTongTienChoPhiKTX(p);
            dsPhiKTX.Add(p);
            db.PHIKTXes.Add(p);
            db.SaveChanges();
            ResetForm();
            MessageBox.Show("Thêm thông tin biên lai thành công.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dsPhiKTX.Count == 0 || phiKTX == null) return;
            phiKTX.MaSV = int.Parse(cBMaSV.Text);

            if (string.IsNullOrWhiteSpace(txtMaBienLai.Text) || string.IsNullOrWhiteSpace(txtTienPhong.Text)
                || string.IsNullOrWhiteSpace(txtTienDien.Text) || string.IsNullOrWhiteSpace(txtTienInternet.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Ngày đóng không thể lớn hơn ngày hiện tại!");
                return;
            }
            phiKTX.NgayDong = dtPNgayDong.Value;

            phiKTX.TienPhong = decimal.Parse(txtTienPhong.Text);
            phiKTX.TienDien = decimal.Parse(txtTienDien.Text);
            phiKTX.TienInternet = decimal.Parse(txtTienInternet.Text);
            if (string.IsNullOrWhiteSpace(txtTienGuixe.Text))
            {
                phiKTX.TienGuiXe = 0;
            }
            else
            {
                phiKTX.TienGuiXe = decimal.Parse(txtTienGuixe.Text);
            }
            TinhTongTienChoPhiKTX(phiKTX);
            LoadData(dsPhiKTX);
            db.SaveChanges();
            MessageBox.Show("Cập nhật thông tin biên lai thành công.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dsPhiKTX.Count == 0 || phiKTX == null) return;

            phiKTX = dsPhiKTX.Where(p => p.MaBienLai == maBienLaiValue()).SingleOrDefault();
            dsPhiKTX.Remove(phiKTX);
            db.PHIKTXes.Remove(phiKTX);
            db.SaveChanges();
            LoadData(dsPhiKTX);
            phiKTX = null;
            MessageBox.Show("Xóa thông tin biên lai thành công.");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<PHIKTX> searchList = null;
            if (string.IsNullOrWhiteSpace(txtSearch.Text) && cBMenuSearch.SelectedIndex == 0)
            {
                LoadData(dsPhiKTX);
                return;
            }
            if (cBMenuSearch.SelectedIndex == 0)
            {
                searchList = dsPhiKTX.Where(s => s.MaBienLai == txtSearch.Text).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 1)
            {
                string searchID = null;
                if (string.IsNullOrEmpty(searchID))
                {
                    searchID = cBSearch.Text;
                }
                else
                {
                    searchID = cBSearch.SelectedItem.ToString();
                }
                searchList = dsPhiKTX.Where(s => s.MaSV == int.Parse(searchID)).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 2)
            {
                searchList = dsPhiKTX.Where(s => s.NgayDong == dtPSearch.Value).ToList();
            }
            LoadData(searchList);
        }
        private void cBMenuSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBMenuSearch.SelectedIndex == 1)
            {
                txtSearch.Visible = false;
                dtPSearch.Visible = false;
                cBSearch.Visible = true;
            }
            else if(cBMenuSearch.SelectedIndex == 2)
            {
                txtSearch.Visible = false;
                dtPSearch.Visible = true;
                cBSearch.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;
                dtPSearch.Visible = false;
                cBSearch.Visible = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dsPhiKTX.Count == 0 || phiKTX == null) return;

            LoadData(dsPhiKTX);
        }
    }
}
