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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }
        private bool IsFormOpen(Type formOpen)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == formOpen)
                {
                    return true;
                }
            }
            return false;
        }
        private void OpenForm(Form formToOpen)
        {
            formToOpen.Show();
            formToOpen.Owner = this;
        }
        private void OpenForm(Type formType)
        {
            if (!IsFormOpen(formType))
            {
                Form form = (Form)Activator.CreateInstance(formType);
                OpenForm(form);
            }
        }
        private void btnDonDangKy_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FrmDonDangKy));
        }

        private void btnTTSV_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FrmSinhVien));
        }

        private void btnNguoiThan_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FrmNguoiThan));
        }

        private void btnBienLai_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FrmPhiKTX));
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FrmPhongKTX));
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FrmTrangThietBi));
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FrmQuanLy));
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FrmNhanVien));
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(FrmDoiMK));
        }

        private void btnDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
