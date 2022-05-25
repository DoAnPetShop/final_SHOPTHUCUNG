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
    public partial class frmKhachHang : Form
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        QL_NguoiDung nguoidung = new QL_NguoiDung();
        BLLCBKhachHang bllkhachhang = new BLLCBKhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void loadDataG()
        {
                       
                dataGridView_khachhang.DataSource = bllkhachhang.loadCBKhachHang();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadDataG();
        }

        private void dataGridView_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dataGridView_khachhang.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = dataGridView_khachhang.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView_khachhang.CurrentRow.Cells[2].Value.ToString();
            cbo_phanloai.Text = dataGridView_khachhang.CurrentRow.Cells[3].Value.ToString();
            txt_diachi.Text = dataGridView_khachhang.CurrentRow.Cells[4].Value.ToString();
            txt_dth.Text = dataGridView_khachhang.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
