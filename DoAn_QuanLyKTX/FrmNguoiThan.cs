using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn_QuanLyKTX
{
    public partial class FrmNguoiThan : Form, ICondition
    {
        QuanLyKyTucXaEntities4 db = new QuanLyKyTucXaEntities4();
        List<NGUOITHAN> dsNgThan = new List<NGUOITHAN>();
        List<SINHVIEN> dsSinhVien = new List<SINHVIEN>();
        List<THOIGIANTHAM> dsTG = new List<THOIGIANTHAM>();
        NGUOITHAN NgThan = null;
        THOIGIANTHAM tgTham = null;
        public FrmNguoiThan()
        {
            InitializeComponent();
        }
        private void FrmNguoiThan_Load(object sender, EventArgs e)
        {
            this.Location = new Point(487, 170);

            dsNgThan = db.NGUOITHANs.ToList();
            dsSinhVien = db.SINHVIENs.ToList();
            dsTG = db.THOIGIANTHAMs.ToList();

            cBMaSV.DataSource = dsSinhVien;
            cBSearch.DataSource = dsSinhVien;

            LoadData(dsNgThan);

            firstLoadData();
        }
        private string maNTValue()
        {
            if (dgvThongTin.RowCount != 0)
            {
                DataGridViewRow row = dgvThongTin.CurrentRow;
                object ma = row.Cells["MaNT"].Value;
                string maNT = ma.ToString();
                return maNT;
            }
            return null;
        }
        void firstLoadData()
        {
            if (dgvThongTin.DataSource == null || dsNgThan.Count == 0) return;

            NgThan = dsNgThan.SingleOrDefault(n => n.MaNT == maNTValue());

            txtTenNT.Text = NgThan.TenNT.ToString();
            txtSDT.Text = NgThan.SoDT;
            txtQuanHe.Text = NgThan.QuanHe.ToString();

            string maSV = NgThan.MaSV.ToString();
            int index = cBMaSV.FindString(maSV);
            cBMaSV.SelectedIndex = index;

            if (NgThan.GioiTinh == "Nam")
            {
                rBGTNam.Checked = true;
            }
            else if (NgThan.GioiTinh == "Nữ")
            {
                rBGTNu.Checked = true;
            }
        }
        void hideColumn(int c, DataGridView d)
        {
            d.Columns[c].Width = 0;
            d.Columns[c].Visible = false;
        }
        void LoadData(List<NGUOITHAN> nt)
        {
            if (nt.Count == 0) return;

            dgvThongTin.DataSource = null;
            dgvThongTin.DataSource = nt;

            hideColumn(6, dgvThongTin);
            hideColumn(7, dgvThongTin);

            dgvThongTin.Columns[2].Width -= 50;
            dgvThongTin.Columns[3].Width -= 50;
            dgvThongTin.Columns[4].Width -= 20;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayCell()
        {
            NgThan = dsNgThan.SingleOrDefault(p => p.MaNT == maNTValue());

            txtTenNT.Text = NgThan.TenNT.ToString();
            txtQuanHe.Text = NgThan.QuanHe.ToString();
            txtSDT.Text = NgThan.SoDT;
            cBMaSV.Text = NgThan.MaSV.ToString();
            if (NgThan.GioiTinh == "Nam")
            {
                rBGTNam.Checked = true;
            }
            else if (NgThan.GioiTinh == "Nữ")
            {
                rBGTNu.Checked = true;
            }

            //hiển thị thông tin sinh viên khi click vào đơn đăng ký tương ứng lên dgvSinhVien
            var sVlst = from c in db.SINHVIENs
                        where c.MaSV == NgThan.MaSV
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

            var tgLst = from c in db.THOIGIANTHAMs
                        where c.MaNT == NgThan.MaNT
                        select new
                        {
                            c.ThoiGianVao,
                            c.ThoiGianRa
                        };
            dgvTGTham.DataSource = tgLst.ToList();
        }

        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvThongTin.RowCount) return;
            displayCell();
        }
        private DateTime tgVao()
        {
            if(dgvTGTham.RowCount != 0)
            {
                DataGridViewRow row = dgvTGTham.CurrentRow;
                object tgv = row.Cells["ThoiGianVao"].Value;
                DateTime tgvao = DateTime.Parse(tgv.ToString());
                return tgvao;
            }
            return DateTime.Now;
        }
        private DateTime tgRa()
        {
            if (dgvTGTham.RowCount != 0)
            {
                DataGridViewRow row = dgvTGTham.CurrentRow;
                object tgr = row.Cells["ThoiGianRa"].Value;
                DateTime tgra = DateTime.Parse(tgr.ToString());
                return tgra;
            }
            return DateTime.Now;
        }
        private void dgvTGTham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvTGTham.RowCount) return;

            dtPThoiGianVao.Value = tgVao();
            dtPThoiGianRa.Value = tgRa();
        }
        private string getMaNT()
        {
            string ten = txtTenNT.Text.Trim();
            string[] words = ten.Split(' ');
            string letters = new string(words.Select(s => s.Length > 0 ? char.ToLower(s[0]) : ' ').ToArray());
            return letters + cBMaSV.Text;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NgThan = new NGUOITHAN();

            if (string.IsNullOrWhiteSpace(txtTenNT.Text) || string.IsNullOrWhiteSpace(txtQuanHe.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            NgThan.MaNT = getMaNT();
            NgThan.TenNT = txtTenNT.Text;
            NgThan.QuanHe = txtQuanHe.Text;
            NgThan.SoDT = txtSDT.Text;

            if (cBMaSV.SelectedItem != null)
            {
                string maSV = cBMaSV.SelectedItem.ToString();
                NgThan.MaSV = int.Parse(maSV);
            }
            else
            {
                NgThan.MaSV = int.Parse(cBMaSV.Text);
            }
            if (rBGTNam.Checked == true)
            {
                NgThan.GioiTinh = "Nam";
            }
            else
            {
                NgThan.GioiTinh = "Nữ";
            }

            dsNgThan.Add(NgThan);
            db.NGUOITHANs.Add(NgThan);
            db.SaveChanges();

            txtTenNT.Text = "";
            txtQuanHe.Text = "";
            cBMaSV.Text = "";
            rBGTNam.Checked = true;
            rBGTNu.Checked = false;
            LoadData(dsNgThan);
            MessageBox.Show("Thêm thông tin người thân thành công.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dsNgThan.Count == 0 || NgThan == null) return;

            if (string.IsNullOrWhiteSpace(txtTenNT.Text) || string.IsNullOrWhiteSpace(txtQuanHe.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            string maSV = cBMaSV.SelectedItem.ToString();

            NgThan.TenNT = txtTenNT.Text;
            NgThan.MaSV = int.Parse(maSV);
            NgThan.QuanHe = txtQuanHe.Text;
            if (rBGTNam.Checked == true)
            {
                NgThan.GioiTinh = "Nam";
            }
            else
            {
                NgThan.GioiTinh = "Nữ";
            }
            LoadData(dsNgThan);
            db.SaveChanges();
            MessageBox.Show("Cập nhật thông tin người thân thành công.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dsNgThan.Count == 0 || NgThan == null) return;

            DialogResult dlr = MessageBox.Show("Xóa thông tin người thân sẽ xóa thông tin thời gian ra vào của người thân.\nBạn có chắc muốn xóa?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.No)
            {
                return;
            }
            NgThan = dsNgThan.SingleOrDefault(p => p.MaNT == maNTValue());
            dsNgThan.Remove(NgThan);
            db.NGUOITHANs.Remove(NgThan);
            db.SaveChanges();
            LoadData(dsNgThan);
            NgThan = null;
            MessageBox.Show("Xóa thông tin người thân thành công.");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<NGUOITHAN> searchList = null;

            if (txtSearch.Text == "" && cBMenuSearch.SelectedIndex != 1)
            {
                LoadData(dsNgThan);
                return;
            }
            if (cBMenuSearch.SelectedIndex == 0)
            {
                searchList = dsNgThan.Where(s => s.TenNT.Contains(txtSearch.Text)).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 1)
            {
                string searchText = null;
                if (string.IsNullOrEmpty(searchText))
                {
                    searchText = cBSearch.Text;
                }
                else
                {
                    searchText = cBSearch.SelectedItem.ToString();
                }
                searchList = dsNgThan.Where(s => s.MaSV == int.Parse(searchText)).ToList();
            }
            LoadData(searchList);
        }
        private void cBMenuSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBMenuSearch.SelectedIndex == 1)
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
            if (dsNgThan.Count == 0 || NgThan == null) return;

            LoadData(dsNgThan);
        }
        void LoadDataTgTham(List<THOIGIANTHAM> tgt)
        {
            tgt = dsTG.Where(t => t.MaNT == maNTValue()).ToList();
            if(tgt.Count == 0) return;

            dgvTGTham.DataSource = null;
            dgvTGTham.DataSource = tgt;

            hideColumn(3, dgvTGTham);
            hideColumn(4, dgvTGTham);
            hideColumn(0, dgvTGTham);
        }
        public bool CheckDieuKienSQL()
        {
            DateTime dtV = dtPThoiGianVao.Value;
            DateTime dtR = dtPThoiGianRa.Value;
            return dtV <= DateTime.Now && dtR.Day >= dtV.Day && dtR.Day <= dtV.Day + 1 && dtR.Month == dtV.Month && dtR.Year == dtV.Year;
        }
        private string getMaTG()
        {
            DateTime dtV = dtPThoiGianVao.Value;
            DateTime dtR = dtPThoiGianRa.Value;
            string dtv = dtV.ToString("ddMMyyyyHHmmss");
            string dtr = dtR.ToString("ddMMyyyyHHmmss");
            return dtv + dtr;
        }
        private void btnAddTg_Click(object sender, EventArgs e)
        {
            if (dsNgThan.Count == 0 || NgThan == null) return;

            THOIGIANTHAM t = new THOIGIANTHAM();

            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Thời gian không hợp lệ!\nThời gian ra vào không thể lớn hơn ngày hiện tại và người thân chỉ được ở lại ký túc không quá 1 ngày.");
                return;
            }
            t.MaTG = getMaTG();
            t.ThoiGianVao = dtPThoiGianVao.Value;
            t.ThoiGianRa = dtPThoiGianRa.Value;
            t.MaNT = getMaNT();
            
            dsTG.Add(t);
            db.THOIGIANTHAMs.Add(t);
            db.SaveChanges();

            dtPThoiGianVao.Value = DateTime.Now;
            dtPThoiGianRa.Value = DateTime.Now;

            LoadDataTgTham(dsTG);
            MessageBox.Show("Thêm thông tin thời gian thăm của thân nhân thành công.");
        }

        private void btnUpdateTg_Click(object sender, EventArgs e)
        {
            if (dsNgThan.Count == 0 || NgThan == null) return;

            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Thời gian không hợp lệ!\nThời gian ra vào không thể lớn hơn ngày hiện tại và người thân chỉ được ở lại ký túc không quá 1 ngày.");
                return;
            }
            tgTham.ThoiGianVao = dtPThoiGianVao.Value;
            tgTham.ThoiGianRa = dtPThoiGianRa.Value;

            LoadDataTgTham(dsTG);
            db.SaveChanges();
            MessageBox.Show("Cập nhật thông tin thời gian thăm của thân nhân thành công!");
        }
    }
}
