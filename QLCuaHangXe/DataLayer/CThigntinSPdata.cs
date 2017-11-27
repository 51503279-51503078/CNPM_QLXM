using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    public class CThigntinSPdata
    {
        DataService m_ds = new DataService();
        public DataTable load_cmb()
        {
            SqlCommand cmd = new SqlCommand("select MANHACUNGCAP,TENNHACUNGCAP from NhaCungCap");
            m_ds.Load(cmd);
            return m_ds;
        }
        public DataTable hienthiSanPham()
        {
            SqlCommand cmd = new SqlCommand("select MAHANG,TENHANG,SOLUONG,DGBAN,THONGTINBAOHANH,DONVITINH,MOTA,TENNHACUNGCAP from MatHang inner join NhaCungCap on MatHang.MANHACUNGCAP=NhaCungCap.MANHACUNGCAP");
            m_ds.Load(cmd);
            return m_ds;
        }
        public DataTable hienthitreeview(string tenhang)
        {
            SqlCommand cmd = new SqlCommand("select MAHANG,TENHANG,SOLUONG,DGBAN,THONGTINBAOHANH,DONVITINH,MOTA,TENNHACUNGCAP from MatHang inner join NhaCungCap on MatHang.MANHACUNGCAP=NhaCungCap.MANHACUNGCAP where MatHang.TENHANG=N'" + tenhang + "'");
            m_ds.Load(cmd);
            return m_ds;
        }
        public DataTable sanpham(string mancc)
        {
            SqlCommand cmd = new SqlCommand("select TENHANG from MatHang where MANHACUNGCAP=N'" + mancc + "'");
            m_ds.Load(cmd);
            return m_ds;
        }
        public DataTable matt()
        {
            SqlCommand cmd = new SqlCommand("select MAHANG from MatHang order by MAHANG");
            m_ds.Load(cmd);
            return m_ds;
        }
        public bool ThemHang(Businessobject.CSanpham objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into MatHang values(N'" +
                                                                         objec.Mahang + "',N'" +
                                                                         objec.Tenhang + "',N'"+
                                                                         objec.Soluong+"',N'"+
                                                                         objec.Dongia+"',N'"+
                                                                         objec.ThongtinBH+"',N'" +
                                                                         objec.DVtinh + "',N'" +
                                                                         objec.Mota + "',N'" +
                                                                         objec.MaNCC + "')");

                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { return false; }
            
        }

        public bool CapnhatHang(Businessobject.CSanpham objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update MatHang set TENHANG=N'" +
                                                                         objec.Tenhang + "',SOLUONG=" +
                                                                         objec.Soluong + ",DGBAN=" +
                                                                         objec.Dongia + ",THONGTINBAOHANH=N'" +
                                                                         objec.ThongtinBH + "',DONVITINH=N'" +
                                                                         objec.DVtinh + "',MOTA=N'" +
                                                                         objec.Mota + "',MANHACUNGCAP=N'" +
                                                                         objec.MaNCC + "' where MAHANG=N'" + objec.Mahang + "'");

                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { }
            return false;
        }
        public bool XoaHang(Businessobject.CSanpham objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from MatHang where MAHANG=N'" + objec.Mahang + "'");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
