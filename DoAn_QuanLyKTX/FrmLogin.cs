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
    public partial class FrmLogin : Form
    {
        QuanLyKyTucXaEntities3 db = new QuanLyKyTucXaEntities3();
        List<TAIKHOANQL> dsTK = new List<TAIKHOANQL>();
        public static int maQL;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            dsTK = db.TAIKHOANQLs.ToList();
            txtMatKhau.KeyPress += txtMK_KeyPress;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentk = txtTenDN.Text;
            string matkhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(txtTenDN.Text) || string.IsNullOrWhiteSpace(txtTenDN.Text) ||
                string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản không được để trống");
                return;
            }
            TAIKHOANQL taikhoan = dsTK.SingleOrDefault(s => s.TenDangNhap == tentk && s.MatKhau == matkhau);
            if (taikhoan != null)
            {
                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản không đúng!");
            }
            if (taikhoan != null)
            {
                maQL = (int)taikhoan.MaQL;
            }
        }

        private void txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMatKhau.Text.Length >= 16 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTaoTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKyTaiKhoan dk = new FrmDangKyTaiKhoan();
            dk.Show();
            this.Hide();
        }
    }
}
