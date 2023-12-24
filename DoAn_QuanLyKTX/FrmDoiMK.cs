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
    public partial class FrmDoiMK : Form
    {
        QuanLyKyTucXaEntities4 db = new QuanLyKyTucXaEntities4();
        public FrmDoiMK()
        {
            InitializeComponent();
        }
        private void FrmDoiMK_Load(object sender, EventArgs e)
        {

        }
        private void cBoxHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHienMK.Checked)
            {
                txtMKCu.PasswordChar = (char)0;
                txtMKMoi.PasswordChar = (char)0;
                txtXacNhanMK.PasswordChar = (char)0;
            }
            else
            {
                txtMKCu.PasswordChar = '*';
                txtMKMoi.PasswordChar = '*';
                txtXacNhanMK.PasswordChar = '*';
            }
        }

        private void txtMKCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMKCu.Text.Length >= 16 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMKMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMKMoi.Text.Length >= 16 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtXacNhanMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMKMoi.Text.Length >= 16 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMKCu.Text;
            string matKhauMoi = txtMKMoi.Text;
            string xacNhanMKMoi = txtXacNhanMK.Text;
            int maQL = FrmLogin.maQL;
            if (string.IsNullOrWhiteSpace(txtMKCu.Text) || string.IsNullOrWhiteSpace(txtMKMoi.Text) || string.IsNullOrWhiteSpace(txtXacNhanMK.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return;
            }
            TAIKHOANQL taiKhoan = db.TAIKHOANQLs.SingleOrDefault(u => u.MaQL == maQL && u.MatKhau == matKhauCu);
            if (taiKhoan != null)
            {
                // Kiểm tra mật khẩu mới và xác nhận mật khẩu mới
                if (matKhauMoi.Equals(xacNhanMKMoi))
                {
                    // Cập nhật mật khẩu mới trong CSDL
                    taiKhoan.MatKhau = matKhauMoi;
                    db.SaveChanges();

                    MessageBox.Show("Đổi mật khẩu thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xác nhận sai mật khẩu!");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu cũ không đúng.");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
