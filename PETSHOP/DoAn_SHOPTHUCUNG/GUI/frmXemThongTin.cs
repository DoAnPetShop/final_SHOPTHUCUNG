using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class frmXemThongTin : Form
    {
        QL_SHOPTHUCUNGDataContext qltc = new QL_SHOPTHUCUNGDataContext();
        BLLSanPham bll = new BLLSanPham();
        public frmXemThongTin()
        {
            InitializeComponent();
        }

        private void frmXemThongTin_Load(object sender, EventArgs e)
        {
            loadDataG();
        }
        public void loadDataG()
        {

            dataGridView1.DataSource = bll.loadSanPham();
        }
    }
}
