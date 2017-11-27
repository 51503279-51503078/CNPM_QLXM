using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace QLCuaHangXe.DataLayer
{
    public class CQuantridata
    {
        DataService m_ds = new DataService();
        public DataTable hienthicmb()
        {
            SqlCommand cmb = new SqlCommand("select TAIKHOAN,QUYEN from TaiKhoan");
            m_ds.Load(cmb);
            return m_ds;
        }

        public DataTable hienthi()
        {
            SqlCommand cmb = new SqlCommand("select * from TaiKhoan");
            m_ds.Load(cmb);
            return m_ds;
        }


        //byte[] pass;
        //public DataTable insertuser(string tk, string mk,string quyen)
        //{
        //    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //    UTF8Encoding encode = new UTF8Encoding();
        //    pass = md5.ComputeHash(encode.GetBytes(mk));
        //    SqlCommand cmd = new SqlCommand("insert into TaiKhoan(TAIKHOAN,MATKHAU,QUYEN)values(N'" + tk + "','" + BitConverter.ToString(pass) + "',N'" + quyen + "')");
        //    m_ds.ExecuteNoneQuery(cmd);
        //    return m_ds;
        //}
        public bool insertuser(Businessobject.CQuantri objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TaiKhoan values(N'" +
                                                                                    objec.taikhoan + "',N'" +
                                                                                    objec.matkhau + "',N'" +
                                                                                    objec.quyen + "')");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { }
            return false;
        }

        public bool sua(Businessobject.CQuantri objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update TaiKhoan set QUYEN=N'" +
                                                                                    objec.quyen + "' where TAIKHOAN=N'" +
                                                                                    objec.taikhoan + "' and MATKHAU=N'" +
                                                                                    objec.matkhau + "')");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { }
            return false;
        }

        public bool Xoa(Businessobject.CQuantri obje)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from TaiKhoan where TAIKHOAN='" + obje.taikhoan + "'");
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
