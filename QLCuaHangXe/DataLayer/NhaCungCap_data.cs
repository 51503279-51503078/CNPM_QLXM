using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    class NhaCungCap_data
    {
        DataService m_ds = new DataService();
        public DataTable timtheoten(string ten)
        {
            SqlCommand cmd = new SqlCommand("select MANHACUNGCAP,TENNHACUNGCAP,DIACHI,DIENTHOAI,EMAIL from NhaCungCap where TENNHACUNGCAP like N'%" + ten + "%'");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable timtheoma(string ma)
        {
            SqlCommand cmd = new SqlCommand("select MANHACUNGCAP,TENNHACUNGCAP,DIACHI,DIENTHOAI,EMAIL from NhaCungCap where MANHACUNGCAP like '%" + ma + "%'");
            m_ds.Load(cmd);
            return m_ds;
        }

        public bool CapNhatNCC(Businessobject.NhaCungCap objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update NhaCungCap set TENNHACUNGCAP=N'" +
                                                                               objec.TenNCC + "',DIACHI=N'" +
                                                                               objec.Diachi + "',DIENTHOAI='" +
                                                                               objec.Dienthoai + "',EMAIL=N'" +
                                                                               objec.Email + "' where MANHACUNGCAP=N'" + objec.MaNCC + "'");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { }
            return false;
        }

        public bool XoaNCC(Businessobject.NhaCungCap obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from NhaCungCap where MANHACUNGCAP=N'" + obj.MaNCC + "'");
                m_ds.Load(cmd);
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public bool ThemNhaCungCap(Businessobject.NhaCungCap obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into NhaCungCap values (N'" + obj.MaNCC + "',N'" + obj.TenNCC + "','" + obj.Diachi + "','" + obj.Dienthoai + "','" + obj.Email + "')");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { }
            return false;
        }

        public DataTable Hienthidatagri()
        {
            SqlCommand cmd = new SqlCommand("select manhacungcap,tennhacungcap,diachi,dienthoai,email from nhacungcap");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable matutang()
        {
            SqlCommand cmd = new SqlCommand("select MANHACUNGCAP from NHACUNGCAP order by MANHACUNGCAP");
            m_ds.Load(cmd);
            return m_ds;
        }

    }
}
