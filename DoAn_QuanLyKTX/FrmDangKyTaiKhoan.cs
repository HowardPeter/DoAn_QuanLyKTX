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
    public partial class FrmDangKyTaiKhoan : Form, ICondition
    {
        QuanLyKyTucXaEntities3 db = new QuanLyKyTucXaEntities3();
        List<QUANLY> dsQuanLy = new List<QUANLY>();
        List<TAIKHOANQL> dsTaiKhoan = new List<TAIKHOANQL>();
        TAIKHOANQL taiKhoan = null;
        QUANLY quanly = null;
        public FrmDangKyTaiKhoan()
        {
            InitializeComponent();
        }
        private void FrmDangKyTaiKhoan_Load(object sender, EventArgs e)
        {
            dsQuanLy = db.QUANLies.ToList();
            dsTaiKhoan = db.TAIKHOANQLs.ToList();
        }
        private void cBoxHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHienMK.Checked)
            {
                txtMK.PasswordChar = '\0';
                txtXacNhanMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
                txtXacNhanMK.PasswordChar = '*';
            }
        }
        public bool CheckDieuKienSQL()
        {
            string email = txtEmail.Text.ToLower();
            return email.EndsWith("@gmail.com") || email.EndsWith("@yahoo.com");
        }

        //Kiểm tra có đúng mã quản lý không và quản lý đó đã có tài khoản chưa
        private bool CheckMaQuanLy()
        {
            quanly = dsQuanLy.Where(q => q.MaQL == int.Parse(txtMaQL.Text)).SingleOrDefault();
            return quanly != null;
        }
        private bool CheckTaiKhoan()
        {
            taiKhoan = dsTaiKhoan.Where(t => t.MaQL == int.Parse(txtMaQL.Text)).SingleOrDefault();
            return taiKhoan == null;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            TAIKHOANQL taiKhoan = new TAIKHOANQL();
            if (string.IsNullOrWhiteSpace(txtMaQL.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtXacNhanMK.Text))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu!");
                return;
            }
            if (!CheckMaQuanLy())
            {
                MessageBox.Show("Mã quản lý không tồn tại!");
                return;
            }
            if (!CheckTaiKhoan())
            {
                MessageBox.Show("Mỗi quản lý chỉ có thể tạo 1 tài khoản!");
                return;
            }
            if (!CheckDieuKienSQL())
            {
                MessageBox.Show("Email đăng nhập phải có dạng '@gmail.com' hoặc '@yahoo.com'!");
                return;
            }

            taiKhoan.TenDangNhap = txtEmail.Text;
            taiKhoan.MatKhau = txtMK.Text;
            taiKhoan.MaQL = int.Parse(txtMaQL.Text);

            if (txtMK.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Xác nhận sai mật khẩu!");
                return;
            }

            dsTaiKhoan.Add(taiKhoan);
            db.TAIKHOANQLs.Add(taiKhoan);
            db.SaveChanges();
            MessageBox.Show("Tạo tài khoản quản lý thành công.");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
