
using System.Data;

using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    class CNhanviendata
    {
        readonly DataService _mDs = new DataService();
        public DataTable Nhanvien()
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN,TENNHANVIEN,NAMSINH,GIOITINH,DIENTHOAI,DIACHI,CHUCVU,LUONGCOBAN from Nhanvien");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable Matutang()
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN from NhanVien order by MANHANVIEN");
            _mDs.Load(cmd);
            return _mDs;
        }

        public bool ThemNv(Businessobject.CNhanvien objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into NhanVien values(N'" +
                                                                         objec.MaNv + "',N'" +
                                                                         objec.TenNv + "','" +
                                                                         objec.Namsinh + "',N'" +
                                                                         objec.Gioitinh + "','" +
                                                                         objec.Dienthoai + "',N'" +
                                                                         objec.Diachi + "',N'" +
                                                                         objec.Chucvu + "','" +
                                                                         objec.LuongCb + "')");

                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                // ignored
            }
            return false;
        }

        public bool Xoanhanvien(Businessobject.CNhanvien objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from NhanVien where MANHANVIEN=N'" + objec.MaNv + "'");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CapnhatNv(Businessobject.CNhanvien objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update NhanVien set TENNHANVIEN=N'" +
                                                                         objec.TenNv + "',NAMSINH='" +
                                                                         objec.Namsinh + "',GIOITINH=N'" +
                                                                         objec.Gioitinh + "',DIENTHOAI='" +
                                                                         objec.Dienthoai + "',DIACHI=N'" +
                                                                         objec.Diachi + "',CHUCVU=N'" +
                                                                         objec.Chucvu + "',LUONGCOBAN='" +
                                                                         objec.LuongCb + "' where MANHANVIEN=N'" + objec.MaNv + "'");

                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                // ignored
            }
            return false;
        }

        public DataTable Timtheoten(string ten)
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN,TENNHANVIEN,NAMSINH,GIOITINH,DIENTHOAI,DIACHI,CHUCVU,LUONGCOBAN from Nhanvien where TENNHANVIEN like N'%" + ten + "%'"); 
            _mDs.Load(cmd);
            return _mDs;
        }
        public DataTable Timtheoma(string ma)
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN,TENNHANVIEN,NAMSINH,GIOITINH,DIENTHOAI,DIACHI,CHUCVU,LUONGCOBAN from Nhanvien where MANHANVIEN like '%" + ma + "%'");
            _mDs.Load(cmd);
            return _mDs;
        }
    }
}
