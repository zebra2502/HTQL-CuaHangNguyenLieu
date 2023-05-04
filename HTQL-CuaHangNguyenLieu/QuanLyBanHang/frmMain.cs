using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }
        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            frmDMNhaCungCap frm = new frmDMNhaCungCap();
            frm.ShowDialog();
        }
        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm= new frmDMHangHoa();
            frm.MdiParent= this;
            frm.Show();
        }
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }
        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }
        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.MdiParent = this;
            frm.Show();
        }
        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimHDBan frm = new frmTimHDBan();
            frm.MdiParent = this;
            frm.Show();
        }
        private void mnuBCHangTon_Click(object sender, EventArgs e)
        {
            frmBCHangTon frm = new frmBCHangTon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuBCDoanhThu_Click(object sender, EventArgs e)
        {
            frmBCDoanhThu frm = new frmBCDoanhThu();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
