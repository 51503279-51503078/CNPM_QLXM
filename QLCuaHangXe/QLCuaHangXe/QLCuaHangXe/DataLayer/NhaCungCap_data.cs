
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    class NhaCungCapData
    {
        readonly DataService _mDs = new DataService();
        public DataTable Timtheoten(string ten)
        {
            SqlCommand cmd = new SqlCommand("select MANHACUNGCAP,TENNHACUNGCAP,DIACHI,DIENTHOAI,EMAIL from NhaCungCap where TENNHACUNGCAP like N'%" + ten + "%'");
            _mDs.Load(cmd);
            
            return _mDs;
        }

        public DataTable Timtheoma(string ma)
        {
            SqlCommand cmd = new SqlCommand("select MANHACUNGCAP,TENNHACUNGCAP,DIACHI,DIENTHOAI,EMAIL from NhaCungCap where MANHACUNGCAP like '%" + ma + "%'");
            _mDs.Load(cmd);
            return _mDs;
        }

        public bool CapNhatNcc(Businessobject.NhaCungCap objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update NhaCungCap set TENNHACUNGCAP=N'" +
                                                                               objec.TenNcc + "',DIACHI=N'" +
                                                                               objec.Diachi + "',DIENTHOAI='" +
                                                                               objec.Dienthoai + "',EMAIL=N'" +
                                                                               objec.Email + "' where MANHACUNGCAP=N'" + objec.MaNcc + "'");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                // ignored
            }
            return false;
        }

        public bool XoaNcc(Businessobject.NhaCungCap obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from NhaCungCap where MANHACUNGCAP=N'" + obj.MaNcc + "'");
                _mDs.Load(cmd);
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
                SqlCommand cmd = new SqlCommand("insert into NhaCungCap values (N'" + obj.MaNcc + "',N'" + obj.TenNcc + "','" + obj.Diachi + "','" + obj.Dienthoai + "','" + obj.Email + "')");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                // ignored
            }
            return false;
        }

        public DataTable Hienthidatagri()
        {
            SqlCommand cmd = new SqlCommand("select manhacungcap,tennhacungcap,diachi,dienthoai,email from nhacungcap");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable Matutang()
        {
            SqlCommand cmd = new SqlCommand("select MANHACUNGCAP from NHACUNGCAP order by MANHACUNGCAP");
            _mDs.Load(cmd);
            return _mDs;
        }

    }
}
