using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using QLCuaHangXe.Businessobject;

namespace QLCuaHangXe.DataLayer
{
    public class CDangnhapdata
    {
        DataService m_ds = new DataService();
        public DataTable quyenadmin(string ten, string ma)
        {
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TAIKHOAN='" + ten + "' and MATKHAU='" + ma + "' and QUYEN='admin'");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable quyennhanvien(string ten, string ma)
        {
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TAIKHOAN='" + ten + "' and MATKHAU='" + ma + "' and QUYEN='nhanvien'");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable quyenquanly(string ten, string ma)
        {
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TAIKHOAN='" + ten + "' and MATKHAU='" + ma + "' and QUYEN='quanly'");
            m_ds.Load(cmd);
            return m_ds;
        }
    }
}
