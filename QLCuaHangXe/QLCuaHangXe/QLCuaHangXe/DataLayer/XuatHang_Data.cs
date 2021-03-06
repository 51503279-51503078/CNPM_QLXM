using System;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLCuaHangXe.DataLayer
{
    public class XuatHangData
    {
        readonly DataService _mDs = new DataService();
        //in hoa don theo ma
        public DataTable View(string mapx)
        {
            SqlCommand cmd = new SqlCommand("select * from v_pxuat where Mapx='" + mapx + "'");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable DatagridPx(string ma,int sl)
        {
            SqlCommand cmd = new SqlCommand(
                "select CTPXuat.MAPX [Mã Phiếu Xuất], TENNHANVIEN [Nhân Viên]" +
                ", TENKHACHHANG [Khách Hàng],TENHANG [Tên Hàng], "+sl+" [Số Lượng Xuất]," +
                "DONGIA [Đơn Giá Xuất],THUE[Thuế],(" + sl + " * DONGIA +DONGIA *THUE/100) [Thành Tiền] from  " +
                " ((NhanVien inner join CTPXuat on CTPXuat.MANHANVIEN=NhanVien.MANHANVIEN)" +
                "inner join KhachHang on KhachHang.MAKHACHHANG=CTPXuat.MAKHACHHANG) " +
                "inner join SanPham on SanPham.MAHANG=CTPXuat.MAHANG where CTPXuat.MAPX = '" + ma + "'");

            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable DatagridPx(string ma)
        {
            SqlCommand cmd = new SqlCommand(
                "select CTPXuat.MAPX [Mã Phiếu Xuất], TENNHANVIEN [Nhân Viên]" +
                ", TENKHACHHANG [Khách Hàng],TENHANG [Tên Hàng], SOLUONG [Số Lượng Xuất]," +
                "DONGIA [Đơn Giá Xuất],THUE[Thuế],DONGIA  [Thành Tiền] from  " +
                " ((NhanVien inner join CTPXuat on CTPXuat.MANHANVIEN=NhanVien.MANHANVIEN)" +
                "inner join KhachHang on KhachHang.MAKHACHHANG=CTPXuat.MAKHACHHANG) " +
                "inner join SanPham on SanPham.MAHANG=CTPXuat.MAHANG where CTPXuat.MAPX = '" + ma + "'");

            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable CmbHang()
        {
            SqlCommand cmd = new SqlCommand("select MAHANG,TENHANG from SanPham");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable CmbNv()
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN,TENNHANVIEN from NhanVien");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable CmbKh()
        {
            SqlCommand cmd = new SqlCommand("select MAKHACHHANG,TENKHACHHANG from KhachHang");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable Matutang()
        {
            SqlCommand cmd = new SqlCommand("select MAPX from CTPXuat order by MAPX");
            _mDs.Load(cmd);
            return _mDs;
        }

        public bool InsertCtpx(Businessobject.ChiTietPx ctpx)
        {

            SqlCommand cmd = new SqlCommand("insert into CTPXuat values('" + ctpx.MaPx + "','" + 
                                                                                 ctpx.MaHang + "','" +  
                                                                                 ctpx.SoLuong + "','" + 
                                                                                 ctpx.DonGia + "','" + 
                                                                                 ctpx.Thue + "',N'" +
                                                                                 ctpx.Manhanvien +"',N'" +
                                                                                 ctpx.Makhachhang +"','"+
                                                                                 ctpx.NgayXuat + "')");
            
           
            _mDs.ExecuteNoneQuery(cmd);
            return true;
        }
        public int Soluong(string ma)
        {
            SqlCommand cmd = new SqlCommand("select SOLUONG from SanPham where MAHANG='"+ma+"'");
            Object obj = _mDs.ExecuteScalar(cmd);
            return Int32.Parse(obj.ToString());

        }
        public bool XoaCtpXuat(Businessobject.ChiTietPx objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from CTPXuat where MAPX='" + objec.MaPx + "'");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int LayGiaBan(string ma)
        {
            int a=0;
            SqlCommand select = new SqlCommand("select DONGIA from SanPham where MAHANG='" + ma + "'");
            _mDs.Load(select);
            try
            {
                a = Int32.Parse(_mDs.Rows[0][0].ToString());
                
            }
            catch
            {
                // ignored
            }
            return a;
        }

        public DataTable LayTenSanPham(string ma)
        {
            SqlCommand select = new SqlCommand("select TENHANG from SanPham where TENHANG LIKE '"+ ma+"'");
            _mDs.Load(select);
            return _mDs;

        }

        public DataTable load_dshangxuat(string thang, string nam)
        {
            SqlCommand cmd = new SqlCommand(" select * from v_pxuat where MONTH(NGAYXUAT)='" + thang + "' and YEAR(NGAYXUAT) ='" + nam + "'");
            _mDs.Load(cmd);
            return _mDs;
        }
    }
}
