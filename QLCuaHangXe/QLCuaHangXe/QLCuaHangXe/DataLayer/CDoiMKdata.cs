using System;

using System.Data.SqlClient;

using QLCuaHangXe.Businessobject;

namespace QLCuaHangXe.DataLayer
{
    public class CDoiMKdata
    {
        DataService _mDs = new DataService();
        public bool Doimatkhau(CDoiMk user, string newpass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update TaiKhoan set MATKHAU='" + newpass + "' where TAIKHOAN='" + user.TaiKhoan + "' and MATKHAU='" + user.MatKhau + "'");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
