
using System.Data;

using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    public class CKhachhangdata
    {
        readonly DataService _mDs = new DataService();
        public DataTable Hienthikh()
        {
            SqlCommand cmd = new SqlCommand("select MAKHACHHANG,TENKHACHHANG,DIACHI,GIOITINH,DIENTHOAI,EMAIL from Khachhang");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable Matt()
        {
            SqlCommand cmd = new SqlCommand("select MAKHACHHANG from Khachhang order by MAKHACHHANG");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable Xoakhachhang(string makh)
        {
            SqlCommand cmd = new SqlCommand("delete from Khachhang where MAKHACHHANG=N'" + makh + "'");
            _mDs.Load(cmd);
            return _mDs;
        }
        public bool CapnhatKh(Businessobject.CKhachhang objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Khachhang set TENKHACHHANG=N'" + 
                                                                               objec.TenKh + "',GIOITINH=N'" + 
                                                                               objec.Gioitinh + "',DIACHI=N'" + 
                                                                               objec.DiaChi + "',DIENTHOAI='" + 
                                                                               objec.DienThoai + "',EMAIL=N'" + 
                                                                               objec.Email + "' where MAKHACHHANG=N'" + objec.MaKh + "'");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                // ignored OK return false
            }
            return false;
        }

        public bool ThemKh(Businessobject.CKhachhang objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Khachhang values(N'" + objec.MaKh + "', N'" +
                                                                                        objec.TenKh + "',N'" +
                                                                                        objec.Gioitinh + "',N'" +
                                                                                        objec.DiaChi + "','" +
                                                                                        objec.DienThoai + "',N'" +
                                                                                        objec.Email + "')");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                // ignored OK return false
            }
            return false;
        }

        public DataTable Timtheoten(string ten)
        {
            SqlCommand cmd = new SqlCommand("select MAKHACHHANG,TENKHACHHANG,DIACHI,GIOITINH,DIENTHOAI,EMAIL from Khachhang where TENKHACHHANG like N'%" + ten + "%'");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable Timtheoma(string ma)
        {
            SqlCommand cmd = new SqlCommand("select MAKHACHHANG,TENKHACHHANG,DIACHI,GIOITINH,DIENTHOAI,EMAIL from Khachhang where MAKHACHHANG like '%" + ma + "%'");
            _mDs.Load(cmd);
            return _mDs;
        }
    }
}
