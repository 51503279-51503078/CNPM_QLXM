
using System.Data;
using System.Data.SqlClient;


namespace QLCuaHangXe.DataLayer
{
    public class CQuantridata
    {
        readonly DataService _mDs = new DataService();
        public DataTable Hienthicmb()
        {
            SqlCommand cmb = new SqlCommand("select TAIKHOAN,QUYEN from TaiKhoan");
            _mDs.Load(cmb);
            return _mDs;
        }

        public DataTable Hienthi()
        {
            SqlCommand cmb = new SqlCommand("select * from TaiKhoan");
            _mDs.Load(cmb);
            return _mDs;
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
        public bool Insertuser(Businessobject.CQuantri objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TaiKhoan values(N'" +
                                                                                    objec.Taikhoan + "',N'" +
                                                                                    objec.Matkhau + "',N'" +
                                                                                    objec.Quyen + "')");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                // ignored return false
            }
            return false;
        }

        public bool Sua(Businessobject.CQuantri objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update TaiKhoan set QUYEN=N'" +
                                                                                    objec.Quyen + "' where TAIKHOAN=N'" +
                                                                                    objec.Taikhoan + "' and MATKHAU=N'" +
                                                                                    objec.Matkhau + "')");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                // ignored return false
            }
            return false;
        }

        public bool Xoa(Businessobject.CQuantri obje)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from TaiKhoan where TAIKHOAN='" + obje.Taikhoan + "'");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
