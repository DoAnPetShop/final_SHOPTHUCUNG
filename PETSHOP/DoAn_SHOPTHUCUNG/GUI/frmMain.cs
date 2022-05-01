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
        }

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
    }
}
