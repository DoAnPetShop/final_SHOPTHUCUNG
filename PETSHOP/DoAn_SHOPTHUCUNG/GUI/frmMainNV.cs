using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMainNV : Form
    {
        public frmMainNV()
        {
            InitializeComponent();
        }

        private void kếtNốiHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnection frmConnec = new frmConnection();
            frmConnec.MdiParent = this;
            frmConnec.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            frmHD.MdiParent = this;
            frmHD.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.MdiParent = this;
            frmKH.Show();
        }

        private void báoCáoTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoNgay frmbaocaongay = new frmBaoCaoNgay();
            frmbaocaongay.MdiParent = this;
            frmbaocaongay.Show();
        }

        private void báoCáoTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThang frmbaocaongay = new frmBaoCaoThang();
            frmbaocaongay.MdiParent = this;
            frmbaocaongay.Show();
        }

        private void frmMainNV_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNhap = new frmNhapHang();
            frmNhap.MdiParent = this;
            frmNhap.Show();
        }
    }
}
