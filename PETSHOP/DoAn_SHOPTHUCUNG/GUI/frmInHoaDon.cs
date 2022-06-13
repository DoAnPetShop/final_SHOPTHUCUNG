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
    public partial class frmInHoaDon : Form
    {
        QL_NguoiDung xldt = new QL_NguoiDung();
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {

        }
        public void LoadBaoCao()
        {
            DataTable dt = new DataTable();
            dt = xldt.DocDuLieu(" select SANPHAM.TENSP,CTHOADON.DONGIA,CTHOADON.Soluong,CTHOADON.SOLUONG * CTHOADON.DONGIA AS Expr1, HOADON.NGAYHD, KHACHHANG.TENKH, NHANVIEN.TENNV, KHACHHANG.DTHOAI \n" +
  "  " + "  FROM  CTHOADON INNER JOIN \n" +
             "   " + "        HOADON ON CTHOADON.MAHD = HOADON.MAHD INNER JOIN  \n" +
"   " + " KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH INNER JOIN  \n" +
      "   " + "            NHANVIEN ON HOADON.MANV = NHANVIEN.MANV INNER JOIN\n" +
            "   " + "      SANPHAM ON CTHOADON.MASP = SANPHAM.MaSP where CTHOADON.MAHD = " + TruyenDuLieu.MAHD + "");

            HoaDon rpBao = new HoaDon();
            rpBao.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpBao;
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
    }
}
