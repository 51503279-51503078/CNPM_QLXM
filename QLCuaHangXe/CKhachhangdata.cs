using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    public class CKhachhangdata
    {
        DataService m_ds = new DataService();
        public DataTable hienthikh()
        {
            SqlCommand cmd = new SqlCommand("select MAKHACHHANG,TENKHACHHANG,DIACHI,GIOITINH,DIENTHOAI,EMAIL from Khachhang");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable matt()
        {
            SqlCommand cmd = new SqlCommand("select MAKHACHHANG from Khachhang order by MAKHACHHANG");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable Xoakhachhang(string makh)
        {
            SqlCommand cmd = new SqlCommand("delete from Khachhang where MAKHACHHANG=N'" + makh + "'");
            m_ds.Load(cmd);
            return m_ds;
        }
        public bool capnhatKH(Businessobject.CKhachhang objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Khachhang set TENKHACHHANG=N'" + 
                                                                               objec.TenKH + "',GIOITINH=N'" + 
                                                                               objec.Gioitinh + "',DIACHI=N'" + 
                                                                               objec.DiaChi + "',DIENTHOAI='" + 
                                                                               objec.DienThoai + "',EMAIL=N'" + 
                                                                               objec.Email + "' where MAKHACHHANG=N'" + objec.MaKH + "'");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { }
            return false;
        }

        public bool ThemKH(Businessobject.CKhachhang objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Khachhang values(N'" + objec.MaKH + "', N'" +
                                                                                        objec.TenKH + "',N'" +
                                                                                        objec.Gioitinh + "',N'" +
                                                                                        objec.DiaChi + "','" +
                                                                                        objec.DienThoai + "',N'" +
                                                                                        objec.Email + "')");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { }
            return false;
        }

        public DataTable timtheoten(string ten)
        {
            SqlCommand cmd = new SqlCommand("select MAKHACHHANG,TENKHACHHANG,DIACHI,GIOITINH,DIENTHOAI,EMAIL from Khachhang where TENKHACHHANG like N'%" + ten + "%'");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable timtheoma(string ma)
        {
            SqlCommand cmd = new SqlCommand("select MAKHACHHANG,TENKHACHHANG,DIACHI,GIOITINH,DIENTHOAI,EMAIL from Khachhang where MAKHACHHANG like '%" + ma + "%'");
            m_ds.Load(cmd);
            return m_ds;
        }
    }
}
