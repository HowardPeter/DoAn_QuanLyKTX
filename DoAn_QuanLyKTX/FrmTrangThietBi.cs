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
    public partial class FrmTrangThietBi : Form
    {
        QuanLyKyTucXaEntities4 db = new QuanLyKyTucXaEntities4();
        List<TRANGTHIETBI> dsThietBi = new List<TRANGTHIETBI>();
        List<PHONGKYTUC> dsPhong = new List<PHONGKYTUC>();
        TRANGTHIETBI thietbi = null;
        PHONGKYTUC phong = null;
        public FrmTrangThietBi()
        {
            InitializeComponent();
        }

        private void FrmTrangThietBi_Load(object sender, EventArgs e)
        {
            this.Location = new Point(487, 170);

            dsThietBi = db.TRANGTHIETBIs.ToList();
            dsPhong = db.PHONGKYTUCs.ToList();

            LoadDataPhong(dsPhong);
            LoadDataThietBi(dsThietBi);

            cBMaPhong.DataSource = dsPhong;

            if (dgvThongTin.DataSource == null || dsThietBi.Count == 0) return;
            DataGridViewRow row = dgvThongTin.CurrentRow;
            int id = row.Index;
            
            if (id > dsThietBi.Count - 1) return;
            thietbi = dsThietBi[id];

            txtMaTB.Text = thietbi.MaTB.ToString();
            txtTenTB.Text = thietbi.TenTB.ToString();

            string maPhong = thietbi.MaPhong;
            int index = cBMaPhong.FindString(maPhong);
            cBMaPhong.SelectedIndex = index;

        }

        void hideColumn(DataGridView dgv, int c)
        {
            dgv.Columns[c].Width = 0;
            dgv.Columns[c].Visible = false;
        }
        void LoadDataPhong(List<PHONGKYTUC> p)
        {
            if(p.Count == 0) return;

            dgvPhong.DataSource = null;
            dgvPhong.DataSource = p;

            hideColumn(dgvPhong, 3);
            hideColumn(dgvPhong, 5);
            hideColumn(dgvPhong, 6);
            hideColumn(dgvPhong, 7);
        }
        void LoadDataThietBi(List<TRANGTHIETBI> t)
        {
            if(t.Count == 0) return;

            dgvThongTin.DataSource = null;
            dgvThongTin.DataSource = t;

            hideColumn(dgvThongTin, 3);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string MaPhongValue()
        {
            DataGridViewRow row = dgvPhong.CurrentRow;
            object n = row.Cells["MaPhong"].Value;
            string maPhongValue = n.ToString();
            return maPhongValue;
        }
        private string MaTBValue()
        {
            DataGridViewRow row = dgvThongTin.CurrentRow;
            object n = row.Cells["MaTB"].Value;
            string maTBValue = n.ToString();
            return maTBValue;
        }
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            phong = dsPhong.Where(p => p.MaPhong == MaPhongValue()).FirstOrDefault();

            var pktxLst = from c in db.TRANGTHIETBIs
                          where c.MaPhong == phong.MaPhong
                          select new
                          {
                              c.MaTB,
                              c.TenTB
                          };
            dgvThongTin.DataSource = null;
            dgvThongTin.DataSource = pktxLst.ToList();
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dsThietBi.Count) return;

            thietbi = dsThietBi.Where(t => t.MaTB == MaTBValue()).SingleOrDefault();

            txtMaTB.Text = thietbi.MaTB;
            txtTenTB.Text = thietbi.TenTB;

            int index = cBMaPhong.FindString(thietbi.MaPhong);
            cBMaPhong.SelectedIndex = index;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            thietbi = new TRANGTHIETBI();

            if (string.IsNullOrWhiteSpace(txtMaTB.Text) || string.IsNullOrWhiteSpace(txtTenTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            thietbi.MaTB = txtMaTB.Text;
            thietbi.TenTB = txtTenTB.Text;
            thietbi.MaPhong = cBMaPhong.SelectedItem.ToString();

            dsThietBi.Add(thietbi);
            db.TRANGTHIETBIs.Add(thietbi);
            db.SaveChanges();
            LoadDataThietBi(dsThietBi);

            txtMaTB.Text = "";
            txtTenTB.Text = "";

            MessageBox.Show("Thêm thông tin trang thiết bị thành công.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dsThietBi.Count == 0) return;

            if (string.IsNullOrWhiteSpace(txtMaTB.Text) || string.IsNullOrWhiteSpace(txtTenTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            thietbi.TenTB = txtTenTB.Text;
            thietbi.MaPhong = cBMaPhong.SelectedItem.ToString();

            LoadDataThietBi(dsThietBi);
            db.SaveChanges();
            MessageBox.Show("Cập nhật thông tin trang thiết bị thành công.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dsThietBi.Count == 0) return;

            thietbi = dsThietBi.Where(t => t.MaTB == MaTBValue()).SingleOrDefault();
            dsThietBi.Remove(thietbi);
            db.TRANGTHIETBIs.Remove(thietbi);
            db.SaveChanges();
            LoadDataThietBi(dsThietBi);
            thietbi = null;
            MessageBox.Show("Xóa thông tin trang thiết bị thành công.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<TRANGTHIETBI> searchList = null;
            if (txtSearch.Text == "")
            {
                LoadDataThietBi(dsThietBi);
                return;
            }
            if (cBMenuSearch.SelectedIndex == 0)
            {
                searchList = dsThietBi.Where(s => s.MaTB == txtSearch.Text).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 1)
            {
                searchList = dsThietBi.Where(s => s.TenTB.Contains(txtSearch.Text)).ToList();
            }
            LoadDataThietBi(searchList);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dsThietBi.Count == 0) return;

            LoadDataThietBi(dsThietBi);
        }
    }
}
