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
    public partial class frmBaoCaoThang : Form
    {
        QL_SHOPTHUCUNGDataContext qlthucung = new QL_SHOPTHUCUNGDataContext();
        QL_NguoiDung nguoidung = new QL_NguoiDung();
        BLLDemSoLuongSP blldemsoluongsp = new BLLDemSoLuongSP();
        BLLDoanhThu blldoanhthu = new BLLDoanhThu();
        public frmBaoCaoThang()
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


                count = blldemsoluongsp.loadsoluongSPTheoThang(dateTimePicker1.Value);
            }
            catch (Exception ex)
            {

            }
            if (count > 0)
            {
                dataGridView_doanhthu.DataSource = blldoanhthu.loadDoanThuTheoThang(dateTimePicker1.Value);
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
                tongtien += double.Parse(dataGridView_doanhthu.Rows[i].Cells[5].Value.ToString());
            txt_tongtien.Text = tongtien.ToString();
        }
        private void frmBaoCaoThang_Load(object sender, EventArgs e)
        {

        }
    }
}
