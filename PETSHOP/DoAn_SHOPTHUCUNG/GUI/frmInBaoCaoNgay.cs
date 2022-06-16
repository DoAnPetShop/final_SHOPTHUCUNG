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
    public partial class frmInBaoCaoNgay : Form
    {
        QL_NguoiDung xldt = new QL_NguoiDung();
        public frmInBaoCaoNgay()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            loadBaoCao();
        }
        public void loadBaoCao()
        {
            DataTable dt = new DataTable();
            dt = xldt.DocDuLieu("select TENSP,CTNHAPHANG.DONGIA,CTHOADON.DONGIA as DONGIABAN, sum(CTHOADON.soLuong) as soluong,sum(CTHOADON.soLuong*CTHOADON.DONGIA - CTHOADON.soLuong*CTNHAPHANG.DONGIA) as TongTien \n" +
        "  " + "                 from HOADON,CTHOADON,SANPHAM,NHAPHANG,CTNHAPHANG\n" +
        "   " + "              where NHAPHANG.MANHAP = CTNHAPHANG.MANHAP and CTNHAPHANG.MASP = SANPHAM.MASP and HOADON.MAHD = CTHOADON.MAHD and SANPHAM.MASP = CTHOADON.MASP\n" +
        "   " + "               and NGAYHD = '"+ TruyenDuLieu.ngaybaocao + "' GROUP BY TENSP,CTNHAPHANG.DONGIA,CTHOADON.DONGIA");
    
            BaoCaoNgay rpBao = new BaoCaoNgay();
            rpBao.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpBao;
        }

        private void frmInBaoCaoNgay_Load(object sender, EventArgs e)
        {
            MessageBox.Show(TruyenDuLieu.ngaybaocao.ToString());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
