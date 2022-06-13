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
    public partial class frmNhanVien : Form
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        QL_NguoiDung nguoidung = new QL_NguoiDung();
        BLLCBNhanVien bllnhanvien = new BLLCBNhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public void loadDataG()
        {

            dataGridView_nhanvien.DataSource = bllnhanvien.loadCBNhanVien();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadDataG();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
