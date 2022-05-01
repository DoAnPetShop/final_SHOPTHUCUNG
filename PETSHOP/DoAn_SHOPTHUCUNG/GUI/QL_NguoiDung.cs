﻿using System;
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
    }
}