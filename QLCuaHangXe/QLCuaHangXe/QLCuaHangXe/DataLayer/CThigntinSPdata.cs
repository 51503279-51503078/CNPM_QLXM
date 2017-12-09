
using System.Data;

using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    public class CThigntinSPdata
    {
        readonly DataService _mDs = new DataService();
        public DataTable load_cmb()
        {
            SqlCommand cmd = new SqlCommand("select MANHACUNGCAP,TENNHACUNGCAP from NhaCungCap");
            _mDs.Load(cmd);
            return _mDs;
        }
        public DataTable HienthiSanPham()
        {
            SqlCommand cmd = new SqlCommand("select MAHANG,TENHANG,SOLUONG,DONGIA,THONGTINBAOHANH,DONVITINH,MOTA,TENNHACUNGCAP from SanPham inner join NhaCungCap on SanPham.MANHACUNGCAP=NhaCungCap.MANHACUNGCAP");
            _mDs.Load(cmd);
            return _mDs;
        }
        public DataTable Hienthitreeview(string tenhang)
        {
            SqlCommand cmd = new SqlCommand("select MAHANG,TENHANG,SOLUONG,DONGIA,THONGTINBAOHANH,DONVITINH,MOTA,TENNHACUNGCAP from SanPham inner join NhaCungCap on SanPham.MANHACUNGCAP=NhaCungCap.MANHACUNGCAP where SanPham.TENHANG=N'" + tenhang + "'");
            _mDs.Load(cmd);
            return _mDs;
        }
        public DataTable Sanpham(string mancc)
        {
            SqlCommand cmd = new SqlCommand("select TENHANG from SanPham where MANHACUNGCAP=N'" + mancc + "'");
            _mDs.Load(cmd);
            return _mDs;
        }
        public DataTable Matt()
        {
            SqlCommand cmd = new SqlCommand("select MAHANG from SanPham order by MAHANG");
            _mDs.Load(cmd);
            return _mDs;
        }
        public bool ThemHang(Businessobject.CSanpham objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into SanPham values(N'" +
                                                                         objec.Mahang + "',N'" +
                                                                         objec.Tenhang + "',N'"+
                                                                         objec.Soluong+"',N'"+
                                                                         objec.Dongia+"',N'"+
                                                                         objec.ThongtinBh+"',N'" +
                                                                         objec.DVtinh + "',N'" +
                                                                         objec.Mota + "',N'" +
                                                                         objec.MaNcc + "')");

                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            { return false; }
            
        }

        public bool CapnhatHang(Businessobject.CSanpham objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update SanPham set TENHANG=N'" +
                                                                         objec.Tenhang + "',SOLUONG=" +
                                                                         objec.Soluong + ",DONGIA=" +
                                                                         objec.Dongia + ",THONGTINBAOHANH=N'" +
                                                                         objec.ThongtinBh + "',DONVITINH=N'" +
                                                                         objec.DVtinh + "',MOTA=N'" +
                                                                         objec.Mota + "',MANHACUNGCAP=N'" +
                                                                         objec.MaNcc + "' where MAHANG=N'" + objec.Mahang + "'");

                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                // ignored
            }
            return false;
        }
        public bool XoaHang(Businessobject.CSanpham objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from SanPham where MAHANG=N'" + objec.Mahang + "'");
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
