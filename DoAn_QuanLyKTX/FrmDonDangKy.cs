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
    public partial class FrmDonDangKy : Form, ICondition
    {
        QuanLyKyTucXaEntities4 db = new QuanLyKyTucXaEntities4();
        List<DONDANGKY> dsDonDK = new List<DONDANGKY>();
        DONDANGKY donDangKy = null;

        bool iscBTinhTrangClicked = false;

        public FrmDonDangKy()
        {
            InitializeComponent();
        }

        private void FrmDonDangKy_Load(object sender, EventArgs e)
        {
            this.Location = new Point(487, 170);

            dsDonDK = db.DONDANGKies.ToList();
            cBSearch.SelectedIndex = 0;
            LoadData(dsDonDK);
            firstLoadData();
        }

        void firstLoadData()
        {
            if (dgvThongTin.DataSource == null || dsDonDK.Count == 0) return;

            donDangKy = dsDonDK.SingleOrDefault(d => d.MaDon == maDonValue());

            txtMaDon.Text = donDangKy.MaDon.ToString();
            txtMaSV.Text = donDangKy.MaSV.ToString();
            dtPNgayNop.Value = donDangKy.NgayNop.Value;
            if (donDangKy.TinhTrang == "Chấp nhận")
            {
                cBTinhTrang.SelectedIndex = 0;
            }
            else if (donDangKy.TinhTrang == "Từ chối")
            {
                cBTinhTrang.SelectedIndex = 1;
            }
            else if (donDangKy.TinhTrang == "Chờ phê duyệt")
            {
                cBTinhTrang.SelectedIndex = 2;
            }
        }

        void LoadData(List<DONDANGKY> ddk)
        {
            ddk = dsDonDK.Where(d => d.TinhTrang == "Chờ phê duyệt").ToList();
            if (dsDonDK.Count == 0) return;
            if (ddk.Count == 0)
            {
                dgvThongTin.DataSource = null;
            }
            else
            {
                dgvThongTin.DataSource = null;
                dgvThongTin.DataSource = ddk;

                dgvThongTin.Columns[4].Width = 0;
                dgvThongTin.Columns[4].Visible = false;
            }
        }

        private int maDonValue()
        {
            if (dgvThongTin.RowCount != 0)
            {
                DataGridViewRow row = dgvThongTin.CurrentRow;
                object n = row.Cells["MaDon"].Value;
                int maDonValue = Convert.ToInt32(n);
                return maDonValue;
            }
            return 0;
        }

        private void displayCell()
        {
            donDangKy = dsDonDK.Where(p => p.MaDon == maDonValue()).SingleOrDefault();

            txtMaDon.Text = donDangKy.MaDon.ToString();
            txtMaSV.Text = donDangKy.MaSV.ToString();
            dtPNgayNop.Value = donDangKy.NgayNop.Value;
            if (donDangKy.TinhTrang == "Chấp nhận")
            {
                cBTinhTrang.SelectedIndex = 0;
            }
            else if (donDangKy.TinhTrang == "Từ chối")
            {
                cBTinhTrang.SelectedIndex = 1;
            }
            else if (donDangKy.TinhTrang == "Chờ phê duyệt")
            {
                cBTinhTrang.SelectedIndex = 2;
            }

            var sVlst = from c in db.SINHVIENs
                        where c.MaSV == donDangKy.MaSV
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
        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThongTin.DataSource == null && e.RowIndex < 0 || e.RowIndex > dgvThongTin.RowCount) return;
            displayCell();
        }

        //Kiểm tra ngày nộp phải nhỏ hơn ngày hiện tại
        public bool CheckDieuKienSQL()
        {
            return dtPNgayNop.Value <= DateTime.Now;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DONDANGKY d = new DONDANGKY();
            int maDon;
            if (dsDonDK.Any())
            {
                maDon = dsDonDK.Max(a => a.MaDon) + 1;
            }
            else { maDon = 1; }

            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            DONDANGKY doncn = dsDonDK.SingleOrDefault(p => p.MaSV == int.Parse(txtMaSV.Text) && p.TinhTrang == "Chấp nhận");
            if (doncn != null)
            {
                MessageBox.Show($"Sinh viên này đã có đơn được chấp thuận!\nMã đơn: {doncn.MaDon}.");
                return;
            }
            DONDANGKY doncpd = dsDonDK.SingleOrDefault(p => p.MaSV == int.Parse(txtMaSV.Text) && p.TinhTrang == "Chờ phê duyệt");
            if (doncpd != null)
            {
                MessageBox.Show($"Sinh viên này đang có đơn chờ được phê duyệt!\nMã đơn: {doncpd.MaDon}.");
                return;
            }
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Ngày nộp không thể lớn hơn ngày hiện tại!");
                return;
            }
            d.MaDon = maDon;
            d.MaSV = int.Parse(txtMaSV.Text);
            d.NgayNop = dtPNgayNop.Value;
            if (cBTinhTrang.SelectedItem == null)
            {
                d.TinhTrang = "Chờ phê duyệt";
            }
            else
            {
                d.TinhTrang = cBTinhTrang.SelectedItem.ToString();
            }

            dsDonDK.Add(d);
            db.DONDANGKies.Add(d);
            db.SaveChanges();

            txtMaDon.Text = "";
            txtMaSV.Text = "";
            dtPNgayNop.Value = DateTime.Now;
            cBTinhTrang.SelectedIndex = 0;
            LoadData(dsDonDK);
            MessageBox.Show("Thêm đơn thành công.");
        }
        private void cBTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dsDonDK.Count == 0 || !iscBTinhTrangClicked) return;

            DataGridViewRow row = dgvThongTin.CurrentRow;
            object n = row.Cells["MaSV"].Value;
            int maSV = Convert.ToInt32(n);
            if (txtMaSV.Text != maSV.ToString()) return;
            row.Cells["TinhTrang"].Value = cBTinhTrang.SelectedItem.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dsDonDK.Count == 0 || donDangKy == null) return;

            donDangKy.MaSV = int.Parse(txtMaSV.Text);

            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Ngày nộp không thể lớn hơn ngày hiện tại!");
                return;
            }
            donDangKy.NgayNop = dtPNgayNop.Value;

            donDangKy.TinhTrang = cBTinhTrang.SelectedItem.ToString();

            LoadData(dsDonDK);
            db.SaveChanges();
            MessageBox.Show("Cập nhật đơn thành công.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dsDonDK.Count == 0 || donDangKy == null) return;

            dsDonDK.Remove(donDangKy);
            db.DONDANGKies.Remove(donDangKy);
            db.SaveChanges();
            LoadData(dsDonDK);
            donDangKy = null;
            MessageBox.Show("Xóa đơn thành công.");
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DONDANGKY> searchList = null;

            if (txtSearch.Text == "" && cBMenuSearch.SelectedIndex != 2)
            {
                LoadData(dsDonDK);
                return;
            }
            if (cBMenuSearch.SelectedIndex == 0)
            {
                searchList = dsDonDK.Where(s => s.MaDon == int.Parse(txtSearch.Text)).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 1)
            {
                searchList = dsDonDK.Where(s => s.MaSV == int.Parse(txtSearch.Text)).ToList();
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
                searchList = dsDonDK.Where(s => s.TinhTrang == searchString).ToList();
            }
            dgvThongTin.DataSource = null;
            lblNull.Visible = false;
            dgvThongTin.DataSource = searchList;

            dgvThongTin.Columns[4].Width = 0;
            dgvThongTin.Columns[4].Visible = false;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dsDonDK.Count == 0 || donDangKy == null) return;

            LoadData(dsDonDK);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cBTinhTrang_Enter(object sender, EventArgs e)
        {
            iscBTinhTrangClicked = true;
        }

        private void cBTinhTrang_Leave(object sender, EventArgs e)
        {
            iscBTinhTrangClicked = false;
        }
    }
}
