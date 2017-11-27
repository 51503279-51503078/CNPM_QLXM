using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    class CNhanviendata
    {
        DataService m_ds = new DataService();
        public DataTable nhanvien()
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN,TENNHANVIEN,NAMSINH,GIOITINH,DIENTHOAI,DIACHI,CHUCVU,LUONGCOBAN from Nhanvien");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable matutang()
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN from NhanVien order by MANHANVIEN");
            m_ds.Load(cmd);
            return m_ds;
        }

        public bool ThemNV(Businessobject.CNhanvien objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into NhanVien values(N'" +
                                                                         objec.MaNV + "',N'" +
                                                                         objec.TenNV + "','" +
                                                                         objec.Namsinh + "',N'" +
                                                                         objec.Gioitinh + "','" +
                                                                         objec.Dienthoai + "',N'" +
                                                                         objec.Diachi + "',N'" +
                                                                         objec.Chucvu + "','" +
                                                                         objec.LuongCB + "')");

                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { }
            return false;
        }

        public bool Xoanhanvien(Businessobject.CNhanvien objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from NhanVien where MANHANVIEN=N'" + objec.MaNV + "'");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool capnhatNV(Businessobject.CNhanvien objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update NhanVien set TENNHANVIEN=N'" +
                                                                         objec.TenNV + "',NAMSINH='" +
                                                                         objec.Namsinh + "',GIOITINH=N'" +
                                                                         objec.Gioitinh + "',DIENTHOAI='" +
                                                                         objec.Dienthoai + "',DIACHI=N'" +
                                                                         objec.Diachi + "',CHUCVU=N'" +
                                                                         objec.Chucvu + "',LUONGCOBAN='" +
                                                                         objec.LuongCB + "' where MANHANVIEN=N'" + objec.MaNV + "'");

                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { }
            return false;
        }

        public DataTable timtheoten(string ten)
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN,TENNHANVIEN,NAMSINH,GIOITINH,DIENTHOAI,DIACHI,CHUCVU,LUONGCOBAN from Nhanvien where TENNHANVIEN like N'%" + ten + "%'"); 
            m_ds.Load(cmd);
            return m_ds;
        }
        public DataTable timtheoma(string ma)
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN,TENNHANVIEN,NAMSINH,GIOITINH,DIENTHOAI,DIACHI,CHUCVU,LUONGCOBAN from Nhanvien where MANHANVIEN like '%" + ma + "%'");
            m_ds.Load(cmd);
            return m_ds;
        }
    }
}
