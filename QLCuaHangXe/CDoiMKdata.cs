using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using QLCuaHangXe.Businessobject;

namespace QLCuaHangXe.DataLayer
{
    public class CDoiMKdata
    {
        DataService m_ds = new DataService();
        public bool doimatkhau(CDoiMK User, string newpass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update TaiKhoan set MATKHAU='" + newpass + "' where TAIKHOAN='" + User.TaiKhoan + "' and MATKHAU='" + User.MatKhau + "'");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
