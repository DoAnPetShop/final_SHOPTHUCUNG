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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            //FindMenuPhanQuyen(this.menuStrip1.Items);
        }
        //private void FindMenuPhanQuyen(ToolStripItemCollection mnuItems)
        //{
        //    foreach (ToolStripItem menu in mnuItems)
        //    {
        //        if (menu is ToolStripMenuItem &&
        //       ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
        //        {

        //            FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems);
        //            menu.Enabled = CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
        //            menu.Visible = menu.Enabled;
        //        }
               
        //    }
        //}
        //private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        //{
        //    foreach (ToolStripItem menuItem in mnuItems)
        //    {
        //        if (menuItem is ToolStripMenuItem && menuItem.Enabled)
        //        {
        //            return true;
        //        }
        //        else if (menuItem is ToolStripSeparator)
        //        {
        //            continue;
        //        }
        //    }
        //    return false;
        //}
        private void kếtNốiHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnection frmConnec = new frmConnection();
            frmConnec.MdiParent = this;
            frmConnec.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            frmHD.MdiParent = this;
            frmHD.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.MdiParent = this;
            frmNV.Show();
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

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNhap = new frmNhapHang();
            frmNhap.MdiParent = this;
            frmNhap.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNhacc = new frmNhaCungCap();
            frmNhacc.MdiParent = this;
            frmNhacc.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frmNhacc = new frmSanPham();
            frmNhacc.MdiParent = this;
            frmNhacc.Show();
        }
    }
}
