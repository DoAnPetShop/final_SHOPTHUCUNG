using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        BLLHoaDon bllbanghoadon = new BLLHoaDon();
        BLLCBHoaDon bllcbhoadon = new BLLCBHoaDon();
        BLLSanPham bllsanpham = new BLLSanPham();
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void loadcombo()
        {

            cbo_mahd.DataSource = bllcbhoadon.loadCBHoaDon();
            cbo_mahd.DisplayMember = "MAHD";
            cbo_mahd.ValueMember = "MAHD";
            
        }
        
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadcombo();
            loadDataG();
        }

        private void cbo_mahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }
        public void loadDataG()
        {

            int mahd = int.Parse(cbo_mahd.SelectedValue.ToString());
            dataGridView_CTHD.DataSource = bllbanghoadon.loadCTHoaDon(mahd);
            dataGridView_SanPham.DataSource = bllsanpham.loadSanPham();
        }
    }
}
