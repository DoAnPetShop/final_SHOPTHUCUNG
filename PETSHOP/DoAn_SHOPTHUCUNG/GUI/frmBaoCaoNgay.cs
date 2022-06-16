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
    public partial class frmBaoCaoNgay : Form
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        QL_NguoiDung nguoidung = new QL_NguoiDung();
        BLLDemSoLuongSP soluongsp = new BLLDemSoLuongSP();
        BLLDoanhThu blldoanhthu = new BLLDoanhThu();
        public frmBaoCaoNgay()
        {
            InitializeComponent();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            int count = 0;
            double tongThanhTien = 0;

            //---------------Lấy số lượng ruou bán trong ngày cần kiểm tra
            try
            {

               
                count = soluongsp.loadsoluongSP(dateTimePicker1.Value);
            }
            catch (Exception ex)
            {

            }
            if (count > 0)
            {
                dataGridView_doanhthu.DataSource = blldoanhthu.loadDoanThu(dateTimePicker1.Value);
                hientongtien();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào được bán trong ngày ");
            }



        }
        public void hientongtien()
        {
            double tongtien = 0;
            int sc = dataGridView_doanhthu.Rows.Count;
            for (int i = 0; i < sc; i++)
                tongtien += double.Parse(dataGridView_doanhthu.Rows[i].Cells[6].Value.ToString());
            txt_tongtien.Text = tongtien.ToString();
        }
      
        private void frmBaoCaoNgay_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("May co muon thoat khong", "thong bao", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void cb_chucnang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_chucnang.SelectedItem.ToString() == "San pham duoc ban ra nhieu nhat")
            {
                dataGridView_hienthi.DataSource = blldoanhthu.loadDoanThuTheoSoLuong(dateTimePicker1.Value);
            }
            else
            {
                dataGridView_hienthi.DataSource = blldoanhthu.loadDoanThuTheoTien(dateTimePicker1.Value);
            }
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
           
            frmInBaoCaoNgay frm = new frmInBaoCaoNgay();
            frm.ShowDialog();
        }
    }
}
