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
    public partial class FrmQuanLy : Form, ICondition
    {
        QuanLyKyTucXaEntities4 db = new QuanLyKyTucXaEntities4();
        List<QUANLY> dsquanly = new List<QUANLY>();
        QUANLY quanly = null;
        public FrmQuanLy()
        {
            InitializeComponent();
        }
        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            this.Location = new Point(487, 170);

            dsquanly = db.QUANLies.ToList();
            LoadData(dsquanly);
            firstLoadData();
        }
        void LoadData(List<QUANLY> ql)
        {
            if (ql.Count == 0) return;

            dgvThongTin.DataSource = null;
            dgvThongTin.DataSource = ql;

            dgvThongTin.Columns[5].Width = 0;
            dgvThongTin.Columns[5].Visible = false;

            dgvThongTin.Columns[6].Width = 0;
            dgvThongTin.Columns[6].Visible = false;
        }
        void firstLoadData()
        {
            if (dgvThongTin.DataSource == null || dsquanly.Count == 0) return;

            DataGridViewRow row = dgvThongTin.CurrentRow;
            int id = row.Index;
            if (id > dsquanly.Count - 1) return;
            quanly = dsquanly[id];

            txtMaQL.Text = quanly.MaQL.ToString();
            txtHoTenQL.Text = quanly.HoTenQL.ToString();
            rBGTNam.Checked = true;
            dtPNgaySinhQL.Value = quanly.NgaySinh.Value;
            dtPNgayVLQL.Value = quanly.NgayVaoLam.Value;

        }
        private int maqlValue()
        {
            DataGridViewRow row = dgvThongTin.CurrentRow;
            object n = row.Cells["MaQL"].Value;
            int maquanly = Convert.ToInt32(n);
            return maquanly;
        }
        public bool CheckDieuKienSQL()
        {
            return dtPNgaySinhQL.Value < DateTime.Now && dtPNgayVLQL.Value > dtPNgaySinhQL.Value && dtPNgayVLQL.Value <= DateTime.Now;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            quanly = new QUANLY();
            if (string.IsNullOrWhiteSpace(txtMaQL.Text) || string.IsNullOrWhiteSpace(txtHoTenQL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Ngày sinh hoặc ngày vào làm không hợp lệ!");
                return;
            }
            // kiem tra xem lai can them da co chưa
            int maql = int.Parse(txtMaQL.Text);
            List<QUANLY> mqltrung = dsquanly.Where(a => a.MaQL == maql).ToList();
            if (mqltrung.Count > 0)
            {
                MessageBox.Show("Mã quản lý bị trùng!");
                return;
            }

            quanly.MaQL = int.Parse(txtMaQL.Text);
            quanly.HoTenQL = txtHoTenQL.Text;
            if (rBGTNam.Checked == true)
            {
                quanly.GioiTinh = "Nam";
            }
            else
            {
                quanly.GioiTinh = "Nữ";
            }
            quanly.NgaySinh = dtPNgaySinhQL.Value;
            quanly.NgayVaoLam = dtPNgayVLQL.Value;

            dsquanly.Add(quanly);
            db.QUANLies.Add(quanly);
            db.SaveChanges();

            txtMaQL.Text = "";
            txtHoTenQL.Text = "";
            rBGTNam.Checked = false;
            rBGTNu.Checked = false;
            dtPNgaySinhQL.Value = DateTime.Now;
            dtPNgayVLQL.Value = DateTime.Now;
            LoadData(dsquanly);
            MessageBox.Show("Thêm thông tin quản lý thành công!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dsquanly.Count == 0 || dsquanly == null) return;
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Ngày sinh hoặc ngày vào làm không hợp lệ!");
                return;
            }
            quanly.HoTenQL = txtHoTenQL.Text;
            if (rBGTNam.Checked == true)
            {
                quanly.GioiTinh = "Nam";
            }
            else
            {
                quanly.GioiTinh = "Nữ";
            }
            quanly.NgaySinh = dtPNgaySinhQL.Value;
            quanly.NgayVaoLam = dtPNgayVLQL.Value;
            LoadData(dsquanly);
            db.SaveChanges();
            MessageBox.Show("Cập nhật thông tin quản lý thành công!");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dsquanly.Count == 0 || dsquanly == null) return;

            quanly = dsquanly.Where(p => p.MaQL == maqlValue()).SingleOrDefault();
            dsquanly.Remove(quanly);
            db.QUANLies.Remove(quanly);
            db.SaveChanges();
            LoadData(dsquanly);
            MessageBox.Show("Quản lý đã bị đuổi việc!");
            quanly = null;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<QUANLY> searchList = null;

            if (txtSearch.Text == "")
            {
                LoadData(dsquanly);
                return;
            }
            if (cBMenuSearch.SelectedIndex == 0)
            {
                searchList = dsquanly.Where(s => s.MaQL == int.Parse(txtSearch.Text)).ToList();
            }
            else if (cBMenuSearch.SelectedIndex == 1)
            {
                searchList = dsquanly.Where(s => s.HoTenQL == txtSearch.Text).ToList();
            }
            LoadData(searchList);
        }
        private void dgvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dsquanly.Count == 0) return;

            DataGridViewRow row = dgvThongTin.CurrentRow;
            int id = row.Index;
            if (id > dsquanly.Count - 1) return;
            quanly = dsquanly[id];

            txtMaQL.Text = quanly.MaQL.ToString();
            txtHoTenQL.Text = quanly.HoTenQL.ToString();
            if (quanly.GioiTinh == "Nam")
            {
                rBGTNam.Checked = true;
            }
            else if (quanly.GioiTinh == "Nữ")
            {
                rBGTNu.Checked = true;
            }
            dtPNgaySinhQL.Value = quanly.NgaySinh.Value;
            dtPNgayVLQL.Value = quanly.NgayVaoLam.Value;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dsquanly.Count == 0 || dsquanly == null) return;

            LoadData(dsquanly);
        }
    }
}
