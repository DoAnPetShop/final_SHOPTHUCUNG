using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class QL_NguoiDung
    {
        SqlCommand sqlcm;
        SqlDataAdapter da;
        public int check_config()
        {
            if (Properties.Settings.Default.QL_SHOPTHUCUNG == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new
            SqlConnection(Properties.Settings.Default.QL_SHOPTHUCUNG);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
        public int check_user(string tk, string mk)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from NhanVien where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'", Properties.Settings.Default.QL_SHOPTHUCUNG);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 5;
            }
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "false")
            {
                return 10;
            }
            return 15;
        }
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
            "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " + pPass + "");
            da.Fill(dt);
            return dt;
        }
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            GUI.Properties.Settings.Default.QL_SHOPTHUCUNG = "Data Source=" + pServer +
            ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
            GUI.Properties.Settings.Default.Save();
        }
        public int GetSoLuongSanPham(string pMasp)
        {
            SqlConnection _Sqlconn = new
            SqlConnection(Properties.Settings.Default.QL_SHOPTHUCUNG);
            string sql = "select SoLuong from SanPham where MASP = '" + pMasp + "' ";
            if (_Sqlconn.State == ConnectionState.Closed)
                _Sqlconn.Open();
            sqlcm = new SqlCommand(sql, _Sqlconn);
            int n = (int)sqlcm.ExecuteScalar();
            _Sqlconn.Close();
            return n;


        }
        public string phanQuyen(string taikhoan)
        {
            SqlConnection _Sqlconn = new
            SqlConnection(Properties.Settings.Default.QL_SHOPTHUCUNG);
            string sql = "select ChucVu from NhanVien where taikhoan = '" + taikhoan + "' ";
            if (_Sqlconn.State == ConnectionState.Closed)
                _Sqlconn.Open();
            sqlcm = new SqlCommand(sql, _Sqlconn);
            string n = (string)sqlcm.ExecuteScalar();
            _Sqlconn.Close();
            return n;


        }
        public int upDateSoLuongSanPham(int pMahd)
        {
            try
            {
            SqlConnection _Sqlconn = new
            SqlConnection(Properties.Settings.Default.QL_SHOPTHUCUNG);
            string sql = "Update SanPham set soluong = (select (SANPHAM.SOLUONG - CTHOADON.SOLUONG) from HOADON, CTHOADON where HOADON.MAHD = CTHOADON.MAHD and SANPHAM.MASP = CTHOADON.MASP and CTHOADON.MAHD = " + pMahd + ") where exists(select * from CTHOADON where SANPHAM.MASP = CTHOADON.MASP and CTHOADON.MAHD = " + pMahd + ")";
            if (_Sqlconn.State == ConnectionState.Closed)
                _Sqlconn.Open();
            sqlcm = new SqlCommand(sql, _Sqlconn);
            int n = sqlcm.ExecuteNonQuery();
            _Sqlconn.Close();
            return n;
            }catch (SqlException e)
              {
                  return -1;
              }
            


        }
        public int upDateNhapHang(int pMaNhap)
        {
            try
            {
                SqlConnection _Sqlconn = new
                SqlConnection(Properties.Settings.Default.QL_SHOPTHUCUNG);
                string sql = "Update SanPham set soluong = (select (SANPHAM.SOLUONG + CTNHAPHANG.SOLUONG) from NHAPHANG,CTNHAPHANG where NHAPHANG.MANHAP = CTNHAPHANG.MANHAP and SANPHAM.MASP = CTNHAPHANG.MASP and CTNHAPHANG.MANHAP = '" + pMaNhap + "') where exists(select * from CTNHAPHANG where SANPHAM.MASP = CTNHAPHANG.MASP and CTNHAPHANG.MANHAP = '" + pMaNhap + "')";
                if (_Sqlconn.State == ConnectionState.Closed)
                    _Sqlconn.Open();
                sqlcm = new SqlCommand(sql, _Sqlconn);
                int n = sqlcm.ExecuteNonQuery();
                _Sqlconn.Close();
                return n;

            }
            catch (SqlException e)
            {
                return -1;
            }
        }
        public DataTable DocDuLieu(String sql)
        {
            SqlConnection _Sqlconn = new
            SqlConnection(Properties.Settings.Default.QL_SHOPTHUCUNG);
            if (_Sqlconn.State == ConnectionState.Closed)
                _Sqlconn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, _Sqlconn);
            da.Fill(dt);
            return dt;
        }
    }
}
