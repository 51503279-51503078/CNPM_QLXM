
using System.Data;
using System.Data.SqlClient;


namespace QLCuaHangXe.DataLayer
{
    public class CDangnhapdata
    {
        readonly DataService _mDs = new DataService();
        public DataTable Quyenadmin(string ten, string ma)
        {
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TAIKHOAN='" + ten + "' and MATKHAU='" + ma + "' and QUYEN='admin'");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable Quyennhanvien(string ten, string ma)
        {
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TAIKHOAN='" + ten + "' and MATKHAU='" + ma + "' and QUYEN='nhanvien'");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable Quyenquanly(string ten, string ma)
        {
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TAIKHOAN='" + ten + "' and MATKHAU='" + ma + "' and QUYEN='quanly'");
            _mDs.Load(cmd);
            return _mDs;
        }
    }
}
